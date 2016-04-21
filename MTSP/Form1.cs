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

namespace MTSP
{
    public partial class Form1 : Form
    {

        private EALoop eaLoop;
        private BackgroundWorker bgw;




        // Random object
        private Random random = new Random();
        

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBoxProblem.SelectedIndex = 0;
            comboBoxAdultSelector.SelectedIndex = 0;

        }


        private void SetupProblem()
        {
        }

        private void SetupAdultSelector()
        {
        }

        private void SetupParentSelector()
        {
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
            
            }
            
        }

        private void bgw_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            
        }

        private void bgw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            
        }

        

        
        
       
        
        // Cancel button
        private void button1_Click_1(object sender, EventArgs e)
        {
            bgw.CancelAsync();
        }

        // Clear button
        private void button2_Click(object sender, EventArgs e)
        {
            ClearChart();
        }

        private void ClearChart()
        {
        
        }
        

        
    }
}
