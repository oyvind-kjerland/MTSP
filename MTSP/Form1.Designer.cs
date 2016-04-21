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
            this.startButton = new System.Windows.Forms.Button();
            this.comboBoxProblem = new System.Windows.Forms.ComboBox();
            this.labelProblem = new System.Windows.Forms.Label();
            this.labelAdultSelector = new System.Windows.Forms.Label();
            this.comboBoxAdultSelector = new System.Windows.Forms.ComboBox();
            this.crossoverNumeric = new System.Windows.Forms.NumericUpDown();
            this.mutationNumeric = new System.Windows.Forms.NumericUpDown();
            this.mutationRateLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numericPopulation = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numericNumGenerations = new System.Windows.Forms.NumericUpDown();
            this.cancelButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.crossoverNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mutationNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPopulation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericNumGenerations)).BeginInit();
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
            // 
            // labelProblem
            // 
            this.labelProblem.AutoSize = true;
            this.labelProblem.Location = new System.Drawing.Point(12, 14);
            this.labelProblem.Name = "labelProblem";
            this.labelProblem.Size = new System.Drawing.Size(48, 13);
            this.labelProblem.TabIndex = 2;
            this.labelProblem.Text = "Problem:";
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
            // 
            // mutationRateLabel
            // 
            this.mutationRateLabel.AutoSize = true;
            this.mutationRateLabel.Location = new System.Drawing.Point(699, 14);
            this.mutationRateLabel.Name = "mutationRateLabel";
            this.mutationRateLabel.Size = new System.Drawing.Size(85, 13);
            this.mutationRateLabel.TabIndex = 13;
            this.mutationRateLabel.Text = "Mutation Rate %";
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
            // numericPopulation
            // 
            this.numericPopulation.Location = new System.Drawing.Point(342, 38);
            this.numericPopulation.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericPopulation.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericPopulation.Name = "numericPopulation";
            this.numericPopulation.Size = new System.Drawing.Size(87, 20);
            this.numericPopulation.TabIndex = 15;
            this.numericPopulation.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(229, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Population Size";
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(895, 486);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numericNumGenerations);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericPopulation);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mutationRateLabel);
            this.Controls.Add(this.mutationNumeric);
            this.Controls.Add(this.crossoverNumeric);
            this.Controls.Add(this.labelAdultSelector);
            this.Controls.Add(this.comboBoxAdultSelector);
            this.Controls.Add(this.labelProblem);
            this.Controls.Add(this.comboBoxProblem);
            this.Controls.Add(this.startButton);
            this.Name = "Form1";
            this.Text = "Evolutionary Algorithm";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.crossoverNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mutationNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPopulation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericNumGenerations)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.ComboBox comboBoxProblem;
        private System.Windows.Forms.Label labelProblem;
        private System.Windows.Forms.Label labelAdultSelector;
        private System.Windows.Forms.ComboBox comboBoxAdultSelector;
        private System.Windows.Forms.NumericUpDown crossoverNumeric;
        private System.Windows.Forms.NumericUpDown mutationNumeric;
        private System.Windows.Forms.Label mutationRateLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericPopulation;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericNumGenerations;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button clearButton;
    }
}

