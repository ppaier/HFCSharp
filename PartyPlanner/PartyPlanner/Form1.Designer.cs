namespace PartyPlanner
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
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDownNumPeople = new System.Windows.Forms.NumericUpDown();
            this.checkBoxFancy = new System.Windows.Forms.CheckBox();
            this.checkBoxHealthy = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelCost = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxPartyType = new System.Windows.Forms.ComboBox();
            this.textBoxCakeWriting = new System.Windows.Forms.TextBox();
            this.labelTooLong = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumPeople)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number of People";
            // 
            // numericUpDownNumPeople
            // 
            this.numericUpDownNumPeople.Location = new System.Drawing.Point(131, 43);
            this.numericUpDownNumPeople.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDownNumPeople.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownNumPeople.Name = "numericUpDownNumPeople";
            this.numericUpDownNumPeople.Size = new System.Drawing.Size(112, 20);
            this.numericUpDownNumPeople.TabIndex = 1;
            this.numericUpDownNumPeople.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDownNumPeople.ValueChanged += new System.EventHandler(this.numericUpDownNumPeople_ValueChanged);
            // 
            // checkBoxFancy
            // 
            this.checkBoxFancy.AutoSize = true;
            this.checkBoxFancy.Checked = true;
            this.checkBoxFancy.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxFancy.Location = new System.Drawing.Point(26, 81);
            this.checkBoxFancy.Name = "checkBoxFancy";
            this.checkBoxFancy.Size = new System.Drawing.Size(115, 17);
            this.checkBoxFancy.TabIndex = 2;
            this.checkBoxFancy.Text = "Fancy Decorations";
            this.checkBoxFancy.UseVisualStyleBackColor = true;
            this.checkBoxFancy.CheckedChanged += new System.EventHandler(this.checkBoxFancy_CheckedChanged);
            // 
            // checkBoxHealthy
            // 
            this.checkBoxHealthy.AutoSize = true;
            this.checkBoxHealthy.Location = new System.Drawing.Point(147, 81);
            this.checkBoxHealthy.Name = "checkBoxHealthy";
            this.checkBoxHealthy.Size = new System.Drawing.Size(96, 17);
            this.checkBoxHealthy.TabIndex = 3;
            this.checkBoxHealthy.Text = "Healthy Option";
            this.checkBoxHealthy.UseVisualStyleBackColor = true;
            this.checkBoxHealthy.CheckedChanged += new System.EventHandler(this.checkBoxHealthy_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Cost:";
            // 
            // labelCost
            // 
            this.labelCost.AutoSize = true;
            this.labelCost.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelCost.Location = new System.Drawing.Point(66, 166);
            this.labelCost.Name = "labelCost";
            this.labelCost.Size = new System.Drawing.Size(2, 15);
            this.labelCost.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Cake Writing:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Type of Party";
            // 
            // comboBoxPartyType
            // 
            this.comboBoxPartyType.DisplayMember = "Birthday Party";
            this.comboBoxPartyType.FormattingEnabled = true;
            this.comboBoxPartyType.Items.AddRange(new object[] {
            "Birthday Party",
            "Dinner Party"});
            this.comboBoxPartyType.Location = new System.Drawing.Point(131, 14);
            this.comboBoxPartyType.Name = "comboBoxPartyType";
            this.comboBoxPartyType.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.comboBoxPartyType.Size = new System.Drawing.Size(112, 21);
            this.comboBoxPartyType.TabIndex = 0;
            this.comboBoxPartyType.SelectedIndexChanged += new System.EventHandler(this.comboBoxPartyType_SelectedIndexChanged);
            // 
            // textBoxCakeWriting
            // 
            this.textBoxCakeWriting.Location = new System.Drawing.Point(26, 132);
            this.textBoxCakeWriting.Name = "textBoxCakeWriting";
            this.textBoxCakeWriting.Size = new System.Drawing.Size(217, 20);
            this.textBoxCakeWriting.TabIndex = 9;
            this.textBoxCakeWriting.TextChanged += new System.EventHandler(this.textBoxCakeWriting_TextChanged);
            // 
            // labelTooLong
            // 
            this.labelTooLong.AutoSize = true;
            this.labelTooLong.BackColor = System.Drawing.Color.Red;
            this.labelTooLong.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTooLong.Location = new System.Drawing.Point(105, 110);
            this.labelTooLong.Name = "labelTooLong";
            this.labelTooLong.Size = new System.Drawing.Size(53, 13);
            this.labelTooLong.TabIndex = 10;
            this.labelTooLong.Text = "too long";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 197);
            this.Controls.Add(this.labelTooLong);
            this.Controls.Add(this.textBoxCakeWriting);
            this.Controls.Add(this.comboBoxPartyType);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelCost);
            this.Controls.Add(this.numericUpDownNumPeople);
            this.Controls.Add(this.checkBoxHealthy);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.checkBoxFancy);
            this.Name = "Form1";
            this.Text = "Party Planner";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumPeople)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDownNumPeople;
        private System.Windows.Forms.CheckBox checkBoxFancy;
        private System.Windows.Forms.CheckBox checkBoxHealthy;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelCost;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxPartyType;
        private System.Windows.Forms.TextBox textBoxCakeWriting;
        private System.Windows.Forms.Label labelTooLong;
    }
}

