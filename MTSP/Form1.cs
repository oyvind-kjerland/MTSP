using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using MTSP.EA;
using System.Threading;
using System.Diagnostics;
using MTSP.EA.DomainSpecific;
using System.Xml.Serialization;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace MTSP
{
    public partial class Form1 : Form
    {

        private EALoop eaLoop;
        private BackgroundWorker bgw;
        private CityData cityData;



        // Random object
        private Random random = new Random();
        

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            cityData = new CityData();

            comboBoxProblem.SelectedIndex = 0;
            comboBoxAdultSelector.SelectedIndex = 0;
            comboBoxParentSelector.SelectedIndex = 0;
            
        }


        private void SetupProblem()
        {

            IntGenotype genotype = new IntGenotype(48);
            genotype.Min = 0;
            genotype.Max = 48;
            eaLoop.Genotype = genotype;

            eaLoop.GeneticOperator = new IntGeneticOperator();
            eaLoop.GeneticOperator.MutationRate = (float)mutationNumeric.Value;
            eaLoop.GeneticOperator.CrossoverRate = (float)crossoverNumeric.Value;

            eaLoop.PhenotypeDeveloper = new IntToTourDeveloper();
            eaLoop.ChildCount = (int)numericPopulation.Value;
            TourEvaluator evaluator = new TourEvaluator();
            evaluator.cityData = cityData;
            eaLoop.FitnessEvaluator = evaluator;
        }

        private void SetupAdultSelector()
        {
            NSGAIISelector selector = new NSGAIISelector();
            selector.AdultCount = (int)numericPopulation.Value;
            eaLoop.AdultSelector = selector;
        }

        private void SetupParentSelector()
        {
            TournamentSelector selector = new TournamentSelector();
            selector.ChildCount = (int)numericPopulation.Value;
            selector.TournamentSize = (int)numericTournamentSize.Value;
            eaLoop.ParentSelector = selector;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (bgw != null && bgw.IsBusy) return;

            // Instantiate EALoop
            eaLoop = new EALoop();

            // Setup the selected problem
            SetupProblem();

            // Set up adult selector and parent selector
            SetupAdultSelector();
            SetupParentSelector();

            // Start background worker
            if (bgw == null)
            {
                bgw = new BackgroundWorker();
                bgw.DoWork += new DoWorkEventHandler(bgw_DoWork);
                bgw.ProgressChanged += new ProgressChangedEventHandler(bgw_ProgressChanged);
                bgw.RunWorkerCompleted += new RunWorkerCompletedEventHandler(bgw_RunWorkerCompleted);
            }

            bgw.WorkerReportsProgress = true;
            bgw.WorkerSupportsCancellation = true;
            


            // Run the background worker
            bgw.RunWorkerAsync();

        }

        private void bgw_DoWork(object sender, DoWorkEventArgs e)
        {
            
            BackgroundWorker worker = sender as BackgroundWorker;

            // Get settings
            int numGenerations = (int)numericNumGenerations.Value;
            

            eaLoop.Initialize();
            for (int i = 0; i < numGenerations; i++)
            {
                if (worker.CancellationPending) return;

                // Perform one iteration of the loop
                eaLoop.Iterate();
                bgw.ReportProgress(1,i);
            }
            
        }

        private void bgw_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            generationCountLabel.Text = e.UserState.ToString();

            List<Individual> adultPopulation = new List<Individual>();
            adultPopulation.AddRange(eaLoop.AdultPopulation);
            if (adultPopulation.Count > 0) PlotPopulation(adultPopulation, true);
        }

        private void bgw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
        }


        private void ClearPlot()
        {
            // Remove striplines
            chart.ChartAreas[0].AxisX.StripLines.Clear();
            chart.ChartAreas[0].AxisY.StripLines.Clear();

            // Clear points
            chart.Series["Series1"].Points.Clear();
        }

        private void PlotPopulations(List<List<Individual>> populations)
        {
            foreach (List<Individual> population in populations)
                PlotPopulation(population, true);
        }

        private void PlotPopulation(List<Individual> population, bool clear)
        {
            // Get a new color for each plot, in case we combine several plots
            //Color color = ColorSelector.GetColor();
            Color color = Color.Blue;
            if (clear)
            {
                ClearPlot();
                color = Color.DarkRed;
            } else
            {
                color = ColorSelector.GetColor();
            }
             

            chart.ChartAreas[0].AxisX.Minimum = 0;

            int bestX = (int)population.Min(x => x.Distance);
            int worstX = (int)population.Max(x => x.Distance);
            // Get y limits
            int bestY = (int)population.Min(y => y.Cost);
            int worstY = (int)population.Max(y => y.Cost);

            // Plot limits
            chart.ChartAreas[0].AxisX.StripLines.Add(GetLimit(bestX, color));
            chart.ChartAreas[0].AxisX.StripLines.Add(GetLimit(worstX, color));
            chart.ChartAreas[0].AxisY.StripLines.Add(GetLimit(bestY, color));
            chart.ChartAreas[0].AxisY.StripLines.Add(GetLimit(worstY, color));

            // Debugging
            //chart.Series["Series1"].Color = color;
            //chart.Series["Series1"].Points.AddXY(0, 0);
            //chart.Series["Series1"].Points.AddXY(10, 10);


            // Plot population
            foreach (Individual ind in population)
            {
                chart.Series["Series1"].Points.AddXY(ind.Distance, ind.Cost); //Update when individual done
            }
        }

        private StripLine GetLimit(int limit, Color color)
        {
            return new StripLine
            {
                BorderDashStyle = ChartDashStyle.Dash,
                BorderWidth = 1,
                BorderColor = color,
                Interval = 0,
                IntervalOffset = limit
            };
        }

        private List<Individual> DeserializePopulation(String fileName)
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(fileName, FileMode.Open, FileAccess.Read, FileShare.Read);
            Population obj = (Population)formatter.Deserialize(stream);
            stream.Close();
            return obj.RestorePopulation();
        }

        private void SerializePopulation(List<Individual> population, String fileName)
        {
            Population obj = new Population(population);
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(fileName, FileMode.Create, FileAccess.Write, FileShare.None);
            formatter.Serialize(stream, obj);
            stream.Close();
        }




        // Cancel button
        private void button1_Click_1(object sender, EventArgs e)
        {
            bgw.CancelAsync();
        }

        // Clear button
        private void button2_Click(object sender, EventArgs e)
        {
            ClearPlot();
        }

        private void loadPopulation_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK) // Test result.
            {
                string fileName = openFileDialog1.FileName;
                List<Individual> pop = DeserializePopulation(fileName);
                PlotPopulation(pop, false);
            }
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            // When user clicks button, show the dialog.
            saveFileDialog1.ShowDialog();
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            string name = saveFileDialog1.FileName;
            SerializePopulation(eaLoop.AdultPopulation, name);
        }
    }
}
