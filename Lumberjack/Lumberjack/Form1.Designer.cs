namespace Lumberjack
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
            this.tbLumberjackName = new System.Windows.Forms.TextBox();
            this.btAddLumberjack = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.nudNumber = new System.Windows.Forms.NumericUpDown();
            this.btAddFlapjacks = new System.Windows.Forms.Button();
            this.tbFlapjacks = new System.Windows.Forms.TextBox();
            this.btNextLumberjack = new System.Windows.Forms.Button();
            this.lbLumberjacks = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbCrispy = new System.Windows.Forms.RadioButton();
            this.rbSoggy = new System.Windows.Forms.RadioButton();
            this.rbBrowned = new System.Windows.Forms.RadioButton();
            this.rbBanana = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumber)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lumberjack name";
            // 
            // tbLumberjackName
            // 
            this.tbLumberjackName.Location = new System.Drawing.Point(110, 10);
            this.tbLumberjackName.Name = "tbLumberjackName";
            this.tbLumberjackName.Size = new System.Drawing.Size(201, 20);
            this.tbLumberjackName.TabIndex = 1;
            // 
            // btAddLumberjack
            // 
            this.btAddLumberjack.Location = new System.Drawing.Point(16, 37);
            this.btAddLumberjack.Name = "btAddLumberjack";
            this.btAddLumberjack.Size = new System.Drawing.Size(294, 23);
            this.btAddLumberjack.TabIndex = 2;
            this.btAddLumberjack.Text = "Add lumberjack";
            this.btAddLumberjack.UseVisualStyleBackColor = true;
            this.btAddLumberjack.Click += new System.EventHandler(this.btAddLumberjack_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Breakfast line";
            // 
            // nudNumber
            // 
            this.nudNumber.Location = new System.Drawing.Point(6, 19);
            this.nudNumber.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudNumber.Name = "nudNumber";
            this.nudNumber.Size = new System.Drawing.Size(120, 20);
            this.nudNumber.TabIndex = 9;
            this.nudNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btAddFlapjacks
            // 
            this.btAddFlapjacks.Location = new System.Drawing.Point(6, 147);
            this.btAddFlapjacks.Name = "btAddFlapjacks";
            this.btAddFlapjacks.Size = new System.Drawing.Size(120, 23);
            this.btAddFlapjacks.TabIndex = 10;
            this.btAddFlapjacks.Text = "Add flapjacks";
            this.btAddFlapjacks.UseVisualStyleBackColor = true;
            this.btAddFlapjacks.Click += new System.EventHandler(this.btAddFlapjacks_Click);
            // 
            // tbFlapjacks
            // 
            this.tbFlapjacks.Location = new System.Drawing.Point(6, 176);
            this.tbFlapjacks.Multiline = true;
            this.tbFlapjacks.Name = "tbFlapjacks";
            this.tbFlapjacks.Size = new System.Drawing.Size(120, 70);
            this.tbFlapjacks.TabIndex = 11;
            // 
            // btNextLumberjack
            // 
            this.btNextLumberjack.Location = new System.Drawing.Point(7, 252);
            this.btNextLumberjack.Name = "btNextLumberjack";
            this.btNextLumberjack.Size = new System.Drawing.Size(120, 23);
            this.btNextLumberjack.TabIndex = 12;
            this.btNextLumberjack.Text = "Next lumberjack";
            this.btNextLumberjack.UseVisualStyleBackColor = true;
            this.btNextLumberjack.Click += new System.EventHandler(this.btNextLumberjack_Click);
            // 
            // lbLumberjacks
            // 
            this.lbLumberjacks.FormattingEnabled = true;
            this.lbLumberjacks.Location = new System.Drawing.Point(19, 84);
            this.lbLumberjacks.Name = "lbLumberjacks";
            this.lbLumberjacks.Size = new System.Drawing.Size(147, 264);
            this.lbLumberjacks.TabIndex = 13;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbBanana);
            this.groupBox1.Controls.Add(this.rbBrowned);
            this.groupBox1.Controls.Add(this.rbSoggy);
            this.groupBox1.Controls.Add(this.rbCrispy);
            this.groupBox1.Controls.Add(this.nudNumber);
            this.groupBox1.Controls.Add(this.btAddFlapjacks);
            this.groupBox1.Controls.Add(this.btNextLumberjack);
            this.groupBox1.Controls.Add(this.tbFlapjacks);
            this.groupBox1.Location = new System.Drawing.Point(172, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(138, 281);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Feed a lumberjack";
            // 
            // rbCrispy
            // 
            this.rbCrispy.AutoSize = true;
            this.rbCrispy.Location = new System.Drawing.Point(7, 46);
            this.rbCrispy.Name = "rbCrispy";
            this.rbCrispy.Size = new System.Drawing.Size(53, 17);
            this.rbCrispy.TabIndex = 13;
            this.rbCrispy.TabStop = true;
            this.rbCrispy.Text = "Crispy";
            this.rbCrispy.UseVisualStyleBackColor = true;
            // 
            // rbSoggy
            // 
            this.rbSoggy.AutoSize = true;
            this.rbSoggy.Location = new System.Drawing.Point(7, 69);
            this.rbSoggy.Name = "rbSoggy";
            this.rbSoggy.Size = new System.Drawing.Size(55, 17);
            this.rbSoggy.TabIndex = 14;
            this.rbSoggy.TabStop = true;
            this.rbSoggy.Text = "Soggy";
            this.rbSoggy.UseVisualStyleBackColor = true;
            // 
            // rbBrowned
            // 
            this.rbBrowned.AutoSize = true;
            this.rbBrowned.Location = new System.Drawing.Point(7, 92);
            this.rbBrowned.Name = "rbBrowned";
            this.rbBrowned.Size = new System.Drawing.Size(67, 17);
            this.rbBrowned.TabIndex = 15;
            this.rbBrowned.TabStop = true;
            this.rbBrowned.Text = "Browned";
            this.rbBrowned.UseVisualStyleBackColor = true;
            // 
            // rbBanana
            // 
            this.rbBanana.AutoSize = true;
            this.rbBanana.Location = new System.Drawing.Point(7, 115);
            this.rbBanana.Name = "rbBanana";
            this.rbBanana.Size = new System.Drawing.Size(62, 17);
            this.rbBanana.TabIndex = 16;
            this.rbBanana.TabStop = true;
            this.rbBanana.Text = "Banana";
            this.rbBanana.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 359);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbLumberjacks);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btAddLumberjack);
            this.Controls.Add(this.tbLumberjackName);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nudNumber)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbLumberjackName;
        private System.Windows.Forms.Button btAddLumberjack;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudNumber;
        private System.Windows.Forms.Button btAddFlapjacks;
        private System.Windows.Forms.TextBox tbFlapjacks;
        private System.Windows.Forms.Button btNextLumberjack;
        private System.Windows.Forms.ListBox lbLumberjacks;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbBanana;
        private System.Windows.Forms.RadioButton rbBrowned;
        private System.Windows.Forms.RadioButton rbSoggy;
        private System.Windows.Forms.RadioButton rbCrispy;
    }
}

