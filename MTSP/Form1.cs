﻿using System;
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
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace MTSP
{
    public partial class Form1 : Form
    {

        private EALoop eaLoop;
        private BackgroundWorker bgw;
        private CityData cityData;
        private List<Individual> plotPopulation = new List<Individual>();


        // Random object
        private Random random = new Random();
        

        public Form1()
        {
            InitializeComponent();
            //PlotPopulation(null);
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

                lock(plotPopulation)
                {
                    plotPopulation.Clear();
                    plotPopulation.AddRange(eaLoop.AdultPopulation);
                }

                bgw.ReportProgress(1,i);
            }
            
        }

        private void bgw_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            generationCountLabel.Text = e.UserState.ToString();

            lock (plotPopulation)
            {
                PlotPopulation(plotPopulation, true);
            }

        }

        private void bgw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            
        }


        private void ClearPlot()
        {
            // Remove striplines
            chart.ChartAreas[0].AxisX.StripLines.Clear();
            chart.ChartAreas[0].AxisY.StripLines.Clear();

            // Clear all but standard serie
            while (chart.Series.Count > 1)
                chart.Series.RemoveAt(1);


            // Clear points
            chart.Series["Series1"].Points.Clear();
        }

        private void PlotPopulations(List<List<Individual>> populations)
        {
            foreach (List<Individual> population in populations)
                PlotPopulation(population, true);
        }

        private void PlotPopulation(List<Individual> population, bool clear, string seriename="Serie1")
        {
            // Get a new color for each plot, in case we combine several plots
            //Color color = ColorSelector.GetColor();
            Color color = Color.Blue;
            if (clear)
            {
                ClearPlot();
                color = Color.DarkRed;
                chart.Series["Series1"].Color = Color.Blue;
            }
            else
            {
                Series s = new Series();
                s.Name = seriename;
                s.ChartType = SeriesChartType.FastPoint;
                color = ColorSelector.GetColor();
                s.Color = color;
                chart.Series.Add(s);
            }

            Series currentSeries = chart.Series[chart.Series.Count - 1];

            int numInFront = population.Count(x => x.Rank == 0);

            chart.ChartAreas[0].AxisX.Minimum = 0;

            bool firstFrontOnly = checkBoxFirstFrontOnly.Checked;

            int bestX = (int)population.Min(x => (firstFrontOnly && x.Rank==0 || !firstFrontOnly) ? x.Distance : double.PositiveInfinity);
            int worstX = (int)population.Max(x => (firstFrontOnly && x.Rank == 0 || !firstFrontOnly) ? x.Distance : double.NegativeInfinity);
            // Get y limits
            int bestY = (int)population.Min(y => (firstFrontOnly && y.Rank == 0 || !firstFrontOnly) ? y.Cost : double.PositiveInfinity);
            int worstY = (int)population.Max(y => (firstFrontOnly && y.Rank == 0 || !firstFrontOnly) ? y.Cost : double.NegativeInfinity);

            // Log statistics
            Console.WriteLine("Best distance: {0}  Worst distance: {1} Best cost: {2}  Worst cost: {3} In front: {4}",
                bestX, worstX, bestY, worstY, numInFront);


            // Plot limits
            chart.ChartAreas[0].AxisX.StripLines.Add(GetLimit(bestX, color));
            chart.ChartAreas[0].AxisX.StripLines.Add(GetLimit(worstX, color));
            chart.ChartAreas[0].AxisY.StripLines.Add(GetLimit(bestY, color));
            chart.ChartAreas[0].AxisY.StripLines.Add(GetLimit(worstY, color));


            // Plot population
            foreach (Individual ind in population)
            {
                if (!firstFrontOnly || firstFrontOnly && ind.Rank == 0)
                {
                    currentSeries.Points.AddXY(ind.Distance, ind.Cost); //Update when individual done
            }
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
                foreach (string s in openFileDialog1.FileNames) {
                    List<Individual> pop = DeserializePopulation(s);
                    string filename = Path.GetFileName(s);
                    PlotPopulation(pop, false, filename);
                }
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
