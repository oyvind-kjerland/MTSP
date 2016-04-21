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
            PlotPopulation(null);
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
                PlotPopulation(population);
        }

        private void PlotPopulation(List<Individual> population)
        {
            // Get a new color for each plot, in case we combine several plots
            Color color = ColorSelector.GetColor();


            // Get x limits
            int bestX = 5;
            int worstX = 1;
            // Get y limits
            int bestY = 4;
            int worstY = 1;

            // Plot limits
            chart.ChartAreas[0].AxisX.StripLines.Add(GetLimit(bestX, color));
            chart.ChartAreas[0].AxisX.StripLines.Add(GetLimit(worstX, color));
            chart.ChartAreas[0].AxisY.StripLines.Add(GetLimit(bestY, color));
            chart.ChartAreas[0].AxisY.StripLines.Add(GetLimit(worstY, color));

            // Debugging
            chart.Series["Series1"].Color = color;
            chart.Series["Series1"].Points.AddXY(0, 0);
            chart.Series["Series1"].Points.AddXY(10, 10);


            // Plot population
            /*foreach (Individual ind in population)
            {
                chart.Series["Series1"].Points.AddXY(0, 0); //Update when individual done
            }*/
        }

        private StripLine GetLimit(int limit, Color color)
        {
            return new StripLine
            {
                BorderDashStyle = ChartDashStyle.Dash,
                BorderWidth = 2,
                BorderColor = color,
                Interval = 0,
                IntervalOffset = limit
            };
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

        
        

        
    }
}
