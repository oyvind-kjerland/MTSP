namespace MTSP
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.startButton = new System.Windows.Forms.Button();
            this.comboBoxProblem = new System.Windows.Forms.ComboBox();
            this.labelProblem = new System.Windows.Forms.Label();
            this.labelAdultSelector = new System.Windows.Forms.Label();
            this.comboBoxAdultSelector = new System.Windows.Forms.ComboBox();
            this.labelParentSelector = new System.Windows.Forms.Label();
            this.comboBoxParentSelector = new System.Windows.Forms.ComboBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.crossoverNumeric = new System.Windows.Forms.NumericUpDown();
            this.mutationNumeric = new System.Windows.Forms.NumericUpDown();
            this.mutationRateLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numericChildCount = new System.Windows.Forms.NumericUpDown();
            this.numericAdultCount = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelNumBits = new System.Windows.Forms.Label();
            this.numericNumBits = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.numericNumGenerations = new System.Windows.Forms.NumericUpDown();
            this.labelTournamentE = new System.Windows.Forms.Label();
            this.labelTournamentK = new System.Windows.Forms.Label();
            this.numericTournamentE = new System.Windows.Forms.NumericUpDown();
            this.numericTournamentK = new System.Windows.Forms.NumericUpDown();
            this.labelSymbolSize = new System.Windows.Forms.Label();
            this.numericSurprisingS = new System.Windows.Forms.NumericUpDown();
            this.labelLength = new System.Windows.Forms.Label();
            this.numericSurprisingL = new System.Windows.Forms.NumericUpDown();
            this.cancelButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.checkBoxMax = new System.Windows.Forms.CheckBox();
            this.checkBoxAverage = new System.Windows.Forms.CheckBox();
            this.checkBoxClearOnRun = new System.Windows.Forms.CheckBox();
            this.numericZ = new System.Windows.Forms.NumericUpDown();
            this.labelZ = new System.Windows.Forms.Label();
            this.checkBoxLocal = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.numericNumRuns = new System.Windows.Forms.NumericUpDown();
            this.checkBoxRandomGoal = new System.Windows.Forms.CheckBox();
            this.labelRankMax = new System.Windows.Forms.Label();
            this.labelRankMin = new System.Windows.Forms.Label();
            this.numericRankMax = new System.Windows.Forms.NumericUpDown();
            this.numericRankMin = new System.Windows.Forms.NumericUpDown();
            this.checkBoxSd = new System.Windows.Forms.CheckBox();
            this.checkBoxElitism = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.crossoverNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mutationNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericChildCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericAdultCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericNumBits)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericNumGenerations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericTournamentE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericTournamentK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericSurprisingS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericSurprisingL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericNumRuns)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericRankMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericRankMin)).BeginInit();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(15, 177);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "Run";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBoxProblem
            // 
            this.comboBoxProblem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxProblem.FormattingEnabled = true;
            this.comboBoxProblem.Items.AddRange(new object[] {
            "OneMax",
            "LOLZ",
            "Surprising Sequences"});
            this.comboBoxProblem.Location = new System.Drawing.Point(66, 11);
            this.comboBoxProblem.Name = "comboBoxProblem";
            this.comboBoxProblem.Size = new System.Drawing.Size(121, 21);
            this.comboBoxProblem.TabIndex = 0;
            this.comboBoxProblem.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // labelProblem
            // 
            this.labelProblem.AutoSize = true;
            this.labelProblem.Location = new System.Drawing.Point(12, 14);
            this.labelProblem.Name = "labelProblem";
            this.labelProblem.Size = new System.Drawing.Size(48, 13);
            this.labelProblem.TabIndex = 2;
            this.labelProblem.Text = "Problem:";
            this.labelProblem.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelAdultSelector
            // 
            this.labelAdultSelector.AutoSize = true;
            this.labelAdultSelector.Location = new System.Drawing.Point(229, 14);
            this.labelAdultSelector.Name = "labelAdultSelector";
            this.labelAdultSelector.Size = new System.Drawing.Size(73, 13);
            this.labelAdultSelector.TabIndex = 4;
            this.labelAdultSelector.Text = "Adult Selector";
            // 
            // comboBoxAdultSelector
            // 
            this.comboBoxAdultSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAdultSelector.FormattingEnabled = true;
            this.comboBoxAdultSelector.Items.AddRange(new object[] {
            "Full",
            "Over-Production",
            "Mixing"});
            this.comboBoxAdultSelector.Location = new System.Drawing.Point(308, 11);
            this.comboBoxAdultSelector.Name = "comboBoxAdultSelector";
            this.comboBoxAdultSelector.Size = new System.Drawing.Size(121, 21);
            this.comboBoxAdultSelector.TabIndex = 3;
            this.comboBoxAdultSelector.SelectedIndexChanged += new System.EventHandler(this.comboBoxAdultSelector_SelectedIndexChanged);
            // 
            // labelParentSelector
            // 
            this.labelParentSelector.AutoSize = true;
            this.labelParentSelector.Location = new System.Drawing.Point(467, 14);
            this.labelParentSelector.Name = "labelParentSelector";
            this.labelParentSelector.Size = new System.Drawing.Size(80, 13);
            this.labelParentSelector.TabIndex = 6;
            this.labelParentSelector.Text = "Parent Selector";
            // 
            // comboBoxParentSelector
            // 
            this.comboBoxParentSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxParentSelector.FormattingEnabled = true;
            this.comboBoxParentSelector.Items.AddRange(new object[] {
            "Fitness-Proportionate",
            "Sigma-Scaling",
            "Rank",
            "Tournament"});
            this.comboBoxParentSelector.Location = new System.Drawing.Point(553, 11);
            this.comboBoxParentSelector.Name = "comboBoxParentSelector";
            this.comboBoxParentSelector.Size = new System.Drawing.Size(121, 21);
            this.comboBoxParentSelector.TabIndex = 5;
            this.comboBoxParentSelector.SelectedIndexChanged += new System.EventHandler(this.comboBoxParentSelector_SelectedIndexChanged);
            // 
            // chart1
            // 
            chartArea1.AxisX.Maximum = 100D;
            chartArea1.AxisX.Minimum = 0D;
            chartArea1.AxisX.Title = "Generation";
            chartArea1.AxisY.Title = "Fitness";
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(12, 206);
            this.chart1.Name = "chart1";
            this.chart1.Size = new System.Drawing.Size(871, 268);
            this.chart1.TabIndex = 8;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // crossoverNumeric
            // 
            this.crossoverNumeric.DecimalPlaces = 4;
            this.crossoverNumeric.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.crossoverNumeric.Location = new System.Drawing.Point(821, 41);
            this.crossoverNumeric.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.crossoverNumeric.Name = "crossoverNumeric";
            this.crossoverNumeric.Size = new System.Drawing.Size(66, 20);
            this.crossoverNumeric.TabIndex = 11;
            this.crossoverNumeric.Value = new decimal(new int[] {
            9,
            0,
            0,
            65536});
            this.crossoverNumeric.ValueChanged += new System.EventHandler(this.crossoverNumeric_ValueChanged);
            // 
            // mutationNumeric
            // 
            this.mutationNumeric.DecimalPlaces = 4;
            this.mutationNumeric.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.mutationNumeric.Location = new System.Drawing.Point(821, 12);
            this.mutationNumeric.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.mutationNumeric.Name = "mutationNumeric";
            this.mutationNumeric.Size = new System.Drawing.Size(66, 20);
            this.mutationNumeric.TabIndex = 12;
            this.mutationNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.mutationNumeric.ValueChanged += new System.EventHandler(this.mutationNumeric_ValueChanged);
            // 
            // mutationRateLabel
            // 
            this.mutationRateLabel.AutoSize = true;
            this.mutationRateLabel.Location = new System.Drawing.Point(699, 14);
            this.mutationRateLabel.Name = "mutationRateLabel";
            this.mutationRateLabel.Size = new System.Drawing.Size(85, 13);
            this.mutationRateLabel.TabIndex = 13;
            this.mutationRateLabel.Text = "Mutation Rate %";
            this.mutationRateLabel.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(699, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Crossover Rate %";
            // 
            // numericChildCount
            // 
            this.numericChildCount.Location = new System.Drawing.Point(342, 38);
            this.numericChildCount.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericChildCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericChildCount.Name = "numericChildCount";
            this.numericChildCount.Size = new System.Drawing.Size(87, 20);
            this.numericChildCount.TabIndex = 15;
            this.numericChildCount.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // numericAdultCount
            // 
            this.numericAdultCount.Location = new System.Drawing.Point(342, 64);
            this.numericAdultCount.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericAdultCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericAdultCount.Name = "numericAdultCount";
            this.numericAdultCount.Size = new System.Drawing.Size(87, 20);
            this.numericAdultCount.TabIndex = 16;
            this.numericAdultCount.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericAdultCount.ValueChanged += new System.EventHandler(this.numericAdultCount_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(229, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Child Population Size";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(229, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Adult Population Size";
            // 
            // labelNumBits
            // 
            this.labelNumBits.AutoSize = true;
            this.labelNumBits.Location = new System.Drawing.Point(9, 40);
            this.labelNumBits.Name = "labelNumBits";
            this.labelNumBits.Size = new System.Drawing.Size(76, 13);
            this.labelNumBits.TabIndex = 20;
            this.labelNumBits.Text = "Number of Bits";
            // 
            // numericNumBits
            // 
            this.numericNumBits.Location = new System.Drawing.Point(94, 38);
            this.numericNumBits.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericNumBits.Name = "numericNumBits";
            this.numericNumBits.Size = new System.Drawing.Size(93, 20);
            this.numericNumBits.TabIndex = 19;
            this.numericNumBits.Value = new decimal(new int[] {
            40,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(699, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Number of Generations";
            // 
            // numericNumGenerations
            // 
            this.numericNumGenerations.Location = new System.Drawing.Point(821, 67);
            this.numericNumGenerations.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericNumGenerations.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericNumGenerations.Name = "numericNumGenerations";
            this.numericNumGenerations.Size = new System.Drawing.Size(66, 20);
            this.numericNumGenerations.TabIndex = 21;
            this.numericNumGenerations.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // labelTournamentE
            // 
            this.labelTournamentE.AutoSize = true;
            this.labelTournamentE.Location = new System.Drawing.Point(467, 69);
            this.labelTournamentE.Name = "labelTournamentE";
            this.labelTournamentE.Size = new System.Drawing.Size(41, 13);
            this.labelTournamentE.TabIndex = 26;
            this.labelTournamentE.Text = "Epsilon";
            this.labelTournamentE.Click += new System.EventHandler(this.label6_Click);
            // 
            // labelTournamentK
            // 
            this.labelTournamentK.AutoSize = true;
            this.labelTournamentK.Location = new System.Drawing.Point(467, 42);
            this.labelTournamentK.Name = "labelTournamentK";
            this.labelTournamentK.Size = new System.Drawing.Size(75, 13);
            this.labelTournamentK.TabIndex = 25;
            this.labelTournamentK.Text = "Group Size (K)";
            this.labelTournamentK.Click += new System.EventHandler(this.label7_Click);
            // 
            // numericTournamentE
            // 
            this.numericTournamentE.DecimalPlaces = 2;
            this.numericTournamentE.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericTournamentE.Location = new System.Drawing.Point(587, 64);
            this.numericTournamentE.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericTournamentE.Name = "numericTournamentE";
            this.numericTournamentE.Size = new System.Drawing.Size(87, 20);
            this.numericTournamentE.TabIndex = 24;
            this.numericTournamentE.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            // 
            // numericTournamentK
            // 
            this.numericTournamentK.Location = new System.Drawing.Point(587, 38);
            this.numericTournamentK.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericTournamentK.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericTournamentK.Name = "numericTournamentK";
            this.numericTournamentK.Size = new System.Drawing.Size(87, 20);
            this.numericTournamentK.TabIndex = 23;
            this.numericTournamentK.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // labelSymbolSize
            // 
            this.labelSymbolSize.AutoSize = true;
            this.labelSymbolSize.Location = new System.Drawing.Point(9, 112);
            this.labelSymbolSize.Name = "labelSymbolSize";
            this.labelSymbolSize.Size = new System.Drawing.Size(80, 13);
            this.labelSymbolSize.TabIndex = 28;
            this.labelSymbolSize.Text = "Symbol Size (S)";
            // 
            // numericSurprisingS
            // 
            this.numericSurprisingS.Location = new System.Drawing.Point(94, 110);
            this.numericSurprisingS.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericSurprisingS.Name = "numericSurprisingS";
            this.numericSurprisingS.Size = new System.Drawing.Size(93, 20);
            this.numericSurprisingS.TabIndex = 27;
            this.numericSurprisingS.Value = new decimal(new int[] {
            40,
            0,
            0,
            0});
            // 
            // labelLength
            // 
            this.labelLength.AutoSize = true;
            this.labelLength.Location = new System.Drawing.Point(12, 138);
            this.labelLength.Name = "labelLength";
            this.labelLength.Size = new System.Drawing.Size(55, 13);
            this.labelLength.TabIndex = 30;
            this.labelLength.Text = "Length (L)";
            // 
            // numericSurprisingL
            // 
            this.numericSurprisingL.Location = new System.Drawing.Point(94, 136);
            this.numericSurprisingL.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericSurprisingL.Name = "numericSurprisingL";
            this.numericSurprisingL.Size = new System.Drawing.Size(93, 20);
            this.numericSurprisingL.TabIndex = 29;
            this.numericSurprisingL.Value = new decimal(new int[] {
            40,
            0,
            0,
            0});
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(96, 177);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 31;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(177, 177);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 32;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // checkBoxMax
            // 
            this.checkBoxMax.AutoSize = true;
            this.checkBoxMax.Checked = true;
            this.checkBoxMax.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxMax.Location = new System.Drawing.Point(796, 119);
            this.checkBoxMax.Name = "checkBoxMax";
            this.checkBoxMax.Size = new System.Drawing.Size(67, 17);
            this.checkBoxMax.TabIndex = 33;
            this.checkBoxMax.Text = "Plot Max";
            this.checkBoxMax.UseVisualStyleBackColor = true;
            // 
            // checkBoxAverage
            // 
            this.checkBoxAverage.AutoSize = true;
            this.checkBoxAverage.Location = new System.Drawing.Point(796, 137);
            this.checkBoxAverage.Name = "checkBoxAverage";
            this.checkBoxAverage.Size = new System.Drawing.Size(87, 17);
            this.checkBoxAverage.TabIndex = 34;
            this.checkBoxAverage.Text = "Plot Average";
            this.checkBoxAverage.UseVisualStyleBackColor = true;
            // 
            // checkBoxClearOnRun
            // 
            this.checkBoxClearOnRun.AutoSize = true;
            this.checkBoxClearOnRun.Location = new System.Drawing.Point(796, 173);
            this.checkBoxClearOnRun.Name = "checkBoxClearOnRun";
            this.checkBoxClearOnRun.Size = new System.Drawing.Size(88, 17);
            this.checkBoxClearOnRun.TabIndex = 35;
            this.checkBoxClearOnRun.Text = "Clear on Run";
            this.checkBoxClearOnRun.UseVisualStyleBackColor = true;
            // 
            // numericZ
            // 
            this.numericZ.Location = new System.Drawing.Point(94, 84);
            this.numericZ.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericZ.Name = "numericZ";
            this.numericZ.Size = new System.Drawing.Size(93, 20);
            this.numericZ.TabIndex = 36;
            this.numericZ.Value = new decimal(new int[] {
            40,
            0,
            0,
            0});
            // 
            // labelZ
            // 
            this.labelZ.AutoSize = true;
            this.labelZ.Location = new System.Drawing.Point(9, 86);
            this.labelZ.Name = "labelZ";
            this.labelZ.Size = new System.Drawing.Size(14, 13);
            this.labelZ.TabIndex = 37;
            this.labelZ.Text = "Z";
            // 
            // checkBoxLocal
            // 
            this.checkBoxLocal.AutoSize = true;
            this.checkBoxLocal.Location = new System.Drawing.Point(135, 160);
            this.checkBoxLocal.Name = "checkBoxLocal";
            this.checkBoxLocal.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBoxLocal.Size = new System.Drawing.Size(52, 17);
            this.checkBoxLocal.TabIndex = 38;
            this.checkBoxLocal.Text = "Local";
            this.checkBoxLocal.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(699, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 40;
            this.label4.Text = "Number of Runs";
            // 
            // numericNumRuns
            // 
            this.numericNumRuns.Location = new System.Drawing.Point(821, 93);
            this.numericNumRuns.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericNumRuns.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericNumRuns.Name = "numericNumRuns";
            this.numericNumRuns.Size = new System.Drawing.Size(66, 20);
            this.numericNumRuns.TabIndex = 39;
            this.numericNumRuns.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // checkBoxRandomGoal
            // 
            this.checkBoxRandomGoal.AutoSize = true;
            this.checkBoxRandomGoal.Location = new System.Drawing.Point(94, 62);
            this.checkBoxRandomGoal.Name = "checkBoxRandomGoal";
            this.checkBoxRandomGoal.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBoxRandomGoal.Size = new System.Drawing.Size(91, 17);
            this.checkBoxRandomGoal.TabIndex = 41;
            this.checkBoxRandomGoal.Text = "Random Goal";
            this.checkBoxRandomGoal.UseVisualStyleBackColor = true;
            // 
            // labelRankMax
            // 
            this.labelRankMax.AutoSize = true;
            this.labelRankMax.Location = new System.Drawing.Point(467, 118);
            this.labelRankMax.Name = "labelRankMax";
            this.labelRankMax.Size = new System.Drawing.Size(27, 13);
            this.labelRankMax.TabIndex = 45;
            this.labelRankMax.Text = "Max";
            // 
            // labelRankMin
            // 
            this.labelRankMin.AutoSize = true;
            this.labelRankMin.Location = new System.Drawing.Point(467, 94);
            this.labelRankMin.Name = "labelRankMin";
            this.labelRankMin.Size = new System.Drawing.Size(24, 13);
            this.labelRankMin.TabIndex = 44;
            this.labelRankMin.Text = "Min";
            this.labelRankMin.Click += new System.EventHandler(this.label7_Click_1);
            // 
            // numericRankMax
            // 
            this.numericRankMax.DecimalPlaces = 2;
            this.numericRankMax.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericRankMax.Location = new System.Drawing.Point(587, 116);
            this.numericRankMax.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericRankMax.Name = "numericRankMax";
            this.numericRankMax.Size = new System.Drawing.Size(87, 20);
            this.numericRankMax.TabIndex = 43;
            this.numericRankMax.Value = new decimal(new int[] {
            15,
            0,
            0,
            65536});
            // 
            // numericRankMin
            // 
            this.numericRankMin.DecimalPlaces = 2;
            this.numericRankMin.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericRankMin.Location = new System.Drawing.Point(587, 90);
            this.numericRankMin.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericRankMin.Name = "numericRankMin";
            this.numericRankMin.Size = new System.Drawing.Size(87, 20);
            this.numericRankMin.TabIndex = 42;
            this.numericRankMin.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            // 
            // checkBoxSd
            // 
            this.checkBoxSd.AutoSize = true;
            this.checkBoxSd.Location = new System.Drawing.Point(796, 155);
            this.checkBoxSd.Name = "checkBoxSd";
            this.checkBoxSd.Size = new System.Drawing.Size(62, 17);
            this.checkBoxSd.TabIndex = 46;
            this.checkBoxSd.Text = "Plot SD";
            this.checkBoxSd.UseVisualStyleBackColor = true;
            // 
            // checkBoxElitism
            // 
            this.checkBoxElitism.AutoSize = true;
            this.checkBoxElitism.Location = new System.Drawing.Point(362, 96);
            this.checkBoxElitism.Name = "checkBoxElitism";
            this.checkBoxElitism.Size = new System.Drawing.Size(55, 17);
            this.checkBoxElitism.TabIndex = 47;
            this.checkBoxElitism.Text = "Elitism";
            this.checkBoxElitism.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(895, 486);
            this.Controls.Add(this.checkBoxElitism);
            this.Controls.Add(this.checkBoxSd);
            this.Controls.Add(this.labelRankMax);
            this.Controls.Add(this.labelRankMin);
            this.Controls.Add(this.numericRankMax);
            this.Controls.Add(this.numericRankMin);
            this.Controls.Add(this.checkBoxRandomGoal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numericNumRuns);
            this.Controls.Add(this.checkBoxLocal);
            this.Controls.Add(this.labelZ);
            this.Controls.Add(this.numericZ);
            this.Controls.Add(this.checkBoxClearOnRun);
            this.Controls.Add(this.checkBoxAverage);
            this.Controls.Add(this.checkBoxMax);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.labelLength);
            this.Controls.Add(this.numericSurprisingL);
            this.Controls.Add(this.labelSymbolSize);
            this.Controls.Add(this.numericSurprisingS);
            this.Controls.Add(this.labelTournamentE);
            this.Controls.Add(this.labelTournamentK);
            this.Controls.Add(this.numericTournamentE);
            this.Controls.Add(this.numericTournamentK);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numericNumGenerations);
            this.Controls.Add(this.labelNumBits);
            this.Controls.Add(this.numericNumBits);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericAdultCount);
            this.Controls.Add(this.numericChildCount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mutationRateLabel);
            this.Controls.Add(this.mutationNumeric);
            this.Controls.Add(this.crossoverNumeric);
            this.Controls.Add(this.labelParentSelector);
            this.Controls.Add(this.comboBoxParentSelector);
            this.Controls.Add(this.labelAdultSelector);
            this.Controls.Add(this.comboBoxAdultSelector);
            this.Controls.Add(this.labelProblem);
            this.Controls.Add(this.comboBoxProblem);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.chart1);
            this.Name = "Form1";
            this.Text = "Evolutionary Algorithm";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.crossoverNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mutationNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericChildCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericAdultCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericNumBits)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericNumGenerations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericTournamentE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericTournamentK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericSurprisingS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericSurprisingL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericZ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericNumRuns)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericRankMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericRankMin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.ComboBox comboBoxProblem;
        private System.Windows.Forms.Label labelProblem;
        private System.Windows.Forms.Label labelAdultSelector;
        private System.Windows.Forms.ComboBox comboBoxAdultSelector;
        private System.Windows.Forms.Label labelParentSelector;
        private System.Windows.Forms.ComboBox comboBoxParentSelector;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.NumericUpDown crossoverNumeric;
        private System.Windows.Forms.NumericUpDown mutationNumeric;
        private System.Windows.Forms.Label mutationRateLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericChildCount;
        private System.Windows.Forms.NumericUpDown numericAdultCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelNumBits;
        private System.Windows.Forms.NumericUpDown numericNumBits;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericNumGenerations;
        private System.Windows.Forms.Label labelTournamentE;
        private System.Windows.Forms.Label labelTournamentK;
        private System.Windows.Forms.NumericUpDown numericTournamentE;
        private System.Windows.Forms.NumericUpDown numericTournamentK;
        private System.Windows.Forms.Label labelSymbolSize;
        private System.Windows.Forms.NumericUpDown numericSurprisingS;
        private System.Windows.Forms.Label labelLength;
        private System.Windows.Forms.NumericUpDown numericSurprisingL;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.CheckBox checkBoxMax;
        private System.Windows.Forms.CheckBox checkBoxAverage;
        private System.Windows.Forms.CheckBox checkBoxClearOnRun;
        private System.Windows.Forms.NumericUpDown numericZ;
        private System.Windows.Forms.Label labelZ;
        private System.Windows.Forms.CheckBox checkBoxLocal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericNumRuns;
        private System.Windows.Forms.CheckBox checkBoxRandomGoal;
        private System.Windows.Forms.Label labelRankMax;
        private System.Windows.Forms.Label labelRankMin;
        private System.Windows.Forms.NumericUpDown numericRankMax;
        private System.Windows.Forms.NumericUpDown numericRankMin;
        private System.Windows.Forms.CheckBox checkBoxSd;
        private System.Windows.Forms.CheckBox checkBoxElitism;
    }
}

