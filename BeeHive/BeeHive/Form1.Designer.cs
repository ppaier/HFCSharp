namespace BeeHive
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxJobs = new System.Windows.Forms.ComboBox();
            this.numericUpDownShifts = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonAssignJob = new System.Windows.Forms.Button();
            this.buttonWorkShift = new System.Windows.Forms.Button();
            this.textBoxReport = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownShifts)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxReport);
            this.groupBox1.Controls.Add(this.buttonWorkShift);
            this.groupBox1.Controls.Add(this.buttonAssignJob);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.numericUpDownShifts);
            this.groupBox1.Controls.Add(this.comboBoxJobs);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(524, 276);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Worker Bee Assignments";
            // 
            // comboBoxJobs
            // 
            this.comboBoxJobs.FormattingEnabled = true;
            this.comboBoxJobs.Location = new System.Drawing.Point(10, 50);
            this.comboBoxJobs.Name = "comboBoxJobs";
            this.comboBoxJobs.Size = new System.Drawing.Size(200, 21);
            this.comboBoxJobs.TabIndex = 0;
            // 
            // numericUpDownShifts
            // 
            this.numericUpDownShifts.Location = new System.Drawing.Point(243, 50);
            this.numericUpDownShifts.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownShifts.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownShifts.Name = "numericUpDownShifts";
            this.numericUpDownShifts.Size = new System.Drawing.Size(67, 20);
            this.numericUpDownShifts.TabIndex = 1;
            this.numericUpDownShifts.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Job";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(240, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Shifts";
            // 
            // buttonAssignJob
            // 
            this.buttonAssignJob.Location = new System.Drawing.Point(10, 87);
            this.buttonAssignJob.Name = "buttonAssignJob";
            this.buttonAssignJob.Size = new System.Drawing.Size(300, 23);
            this.buttonAssignJob.TabIndex = 4;
            this.buttonAssignJob.Text = "Assign this job to a bee";
            this.buttonAssignJob.UseVisualStyleBackColor = true;
            this.buttonAssignJob.Click += new System.EventHandler(this.buttonAssignJob_Click);
            // 
            // buttonWorkShift
            // 
            this.buttonWorkShift.Location = new System.Drawing.Point(335, 31);
            this.buttonWorkShift.Name = "buttonWorkShift";
            this.buttonWorkShift.Size = new System.Drawing.Size(180, 79);
            this.buttonWorkShift.TabIndex = 5;
            this.buttonWorkShift.Text = "Work the next shift";
            this.buttonWorkShift.UseVisualStyleBackColor = true;
            this.buttonWorkShift.Click += new System.EventHandler(this.buttonWorkShift_Click);
            // 
            // textBoxReport
            // 
            this.textBoxReport.Location = new System.Drawing.Point(10, 117);
            this.textBoxReport.Multiline = true;
            this.textBoxReport.Name = "textBoxReport";
            this.textBoxReport.Size = new System.Drawing.Size(505, 153);
            this.textBoxReport.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 300);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Bee Hive Management System";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownShifts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonWorkShift;
        private System.Windows.Forms.Button buttonAssignJob;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDownShifts;
        private System.Windows.Forms.ComboBox comboBoxJobs;
        private System.Windows.Forms.TextBox textBoxReport;
    }
}

