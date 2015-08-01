namespace MileageCalculator
{
    partial class mainForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.startingMileage = new System.Windows.Forms.NumericUpDown();
            this.endingMileage = new System.Windows.Forms.NumericUpDown();
            this.labelOwed = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.startingMileage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.endingMileage)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(158, 158);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Starting Mileage";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ending Mileage";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Amount Owed";
            // 
            // startingMileage
            // 
            this.startingMileage.Location = new System.Drawing.Point(158, 29);
            this.startingMileage.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.startingMileage.Name = "startingMileage";
            this.startingMileage.Size = new System.Drawing.Size(120, 20);
            this.startingMileage.TabIndex = 4;
            // 
            // endingMileage
            // 
            this.endingMileage.Location = new System.Drawing.Point(158, 65);
            this.endingMileage.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.endingMileage.Name = "endingMileage";
            this.endingMileage.Size = new System.Drawing.Size(120, 20);
            this.endingMileage.TabIndex = 5;
            // 
            // labelOwed
            // 
            this.labelOwed.AutoSize = true;
            this.labelOwed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOwed.Location = new System.Drawing.Point(154, 96);
            this.labelOwed.Name = "labelOwed";
            this.labelOwed.Size = new System.Drawing.Size(0, 20);
            this.labelOwed.TabIndex = 6;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 212);
            this.Controls.Add(this.labelOwed);
            this.Controls.Add(this.endingMileage);
            this.Controls.Add(this.startingMileage);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "mainForm";
            this.Text = "Mileage Calculator";
            ((System.ComponentModel.ISupportInitialize)(this.startingMileage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.endingMileage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown startingMileage;
        private System.Windows.Forms.NumericUpDown endingMileage;
        private System.Windows.Forms.Label labelOwed;
    }
}

