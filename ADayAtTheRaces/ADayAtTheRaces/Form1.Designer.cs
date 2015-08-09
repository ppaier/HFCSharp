namespace ADayAtTheRaces
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBoxDog1 = new System.Windows.Forms.PictureBox();
            this.racetrackPictureBox = new System.Windows.Forms.PictureBox();
            this.pictureBoxDog3 = new System.Windows.Forms.PictureBox();
            this.pictureBoxDog2 = new System.Windows.Forms.PictureBox();
            this.pictureBoxDog4 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonJoe = new System.Windows.Forms.RadioButton();
            this.radioButtonAl = new System.Windows.Forms.RadioButton();
            this.radioButtonBob = new System.Windows.Forms.RadioButton();
            this.labelBetJoe = new System.Windows.Forms.Label();
            this.labelBetBob = new System.Windows.Forms.Label();
            this.labelBetAl = new System.Windows.Forms.Label();
            this.buttonRace = new System.Windows.Forms.Button();
            this.labelCurrentBettor = new System.Windows.Forms.Label();
            this.buttonBet = new System.Windows.Forms.Button();
            this.labelMinBet = new System.Windows.Forms.Label();
            this.numericUpDownBet = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDownDog = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDog1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.racetrackPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDog3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDog2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDog4)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDog)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxDog1
            // 
            this.pictureBoxDog1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxDog1.Image")));
            this.pictureBoxDog1.Location = new System.Drawing.Point(12, 23);
            this.pictureBoxDog1.Name = "pictureBoxDog1";
            this.pictureBoxDog1.Size = new System.Drawing.Size(75, 20);
            this.pictureBoxDog1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxDog1.TabIndex = 0;
            this.pictureBoxDog1.TabStop = false;
            // 
            // racetrackPictureBox
            // 
            this.racetrackPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("racetrackPictureBox.Image")));
            this.racetrackPictureBox.Location = new System.Drawing.Point(12, 12);
            this.racetrackPictureBox.Name = "racetrackPictureBox";
            this.racetrackPictureBox.Size = new System.Drawing.Size(600, 200);
            this.racetrackPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.racetrackPictureBox.TabIndex = 1;
            this.racetrackPictureBox.TabStop = false;
            // 
            // pictureBoxDog3
            // 
            this.pictureBoxDog3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxDog3.Image")));
            this.pictureBoxDog3.Location = new System.Drawing.Point(12, 128);
            this.pictureBoxDog3.Name = "pictureBoxDog3";
            this.pictureBoxDog3.Size = new System.Drawing.Size(75, 20);
            this.pictureBoxDog3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxDog3.TabIndex = 2;
            this.pictureBoxDog3.TabStop = false;
            // 
            // pictureBoxDog2
            // 
            this.pictureBoxDog2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxDog2.Image")));
            this.pictureBoxDog2.Location = new System.Drawing.Point(12, 72);
            this.pictureBoxDog2.Name = "pictureBoxDog2";
            this.pictureBoxDog2.Size = new System.Drawing.Size(75, 20);
            this.pictureBoxDog2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxDog2.TabIndex = 3;
            this.pictureBoxDog2.TabStop = false;
            // 
            // pictureBoxDog4
            // 
            this.pictureBoxDog4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxDog4.Image")));
            this.pictureBoxDog4.Location = new System.Drawing.Point(12, 177);
            this.pictureBoxDog4.Name = "pictureBoxDog4";
            this.pictureBoxDog4.Size = new System.Drawing.Size(75, 20);
            this.pictureBoxDog4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxDog4.TabIndex = 4;
            this.pictureBoxDog4.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.numericUpDownDog);
            this.groupBox1.Controls.Add(this.numericUpDownBet);
            this.groupBox1.Controls.Add(this.buttonRace);
            this.groupBox1.Controls.Add(this.labelMinBet);
            this.groupBox1.Controls.Add(this.buttonBet);
            this.groupBox1.Controls.Add(this.radioButtonJoe);
            this.groupBox1.Controls.Add(this.labelCurrentBettor);
            this.groupBox1.Controls.Add(this.radioButtonAl);
            this.groupBox1.Controls.Add(this.labelBetAl);
            this.groupBox1.Controls.Add(this.radioButtonBob);
            this.groupBox1.Controls.Add(this.labelBetBob);
            this.groupBox1.Controls.Add(this.labelBetJoe);
            this.groupBox1.Location = new System.Drawing.Point(12, 227);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(603, 216);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Betting Parlor";
            // 
            // radioButtonJoe
            // 
            this.radioButtonJoe.AutoSize = true;
            this.radioButtonJoe.Checked = true;
            this.radioButtonJoe.Location = new System.Drawing.Point(6, 49);
            this.radioButtonJoe.Name = "radioButtonJoe";
            this.radioButtonJoe.Size = new System.Drawing.Size(85, 17);
            this.radioButtonJoe.TabIndex = 5;
            this.radioButtonJoe.TabStop = true;
            this.radioButtonJoe.Text = "radioButton1";
            this.radioButtonJoe.UseVisualStyleBackColor = true;
            this.radioButtonJoe.CheckedChanged += new System.EventHandler(this.radioButtonJoe_CheckedChanged);
            // 
            // radioButtonAl
            // 
            this.radioButtonAl.AutoSize = true;
            this.radioButtonAl.Location = new System.Drawing.Point(6, 95);
            this.radioButtonAl.Name = "radioButtonAl";
            this.radioButtonAl.Size = new System.Drawing.Size(85, 17);
            this.radioButtonAl.TabIndex = 6;
            this.radioButtonAl.Text = "radioButton1";
            this.radioButtonAl.UseVisualStyleBackColor = true;
            this.radioButtonAl.CheckedChanged += new System.EventHandler(this.radioButtonAl_CheckedChanged);
            // 
            // radioButtonBob
            // 
            this.radioButtonBob.AutoSize = true;
            this.radioButtonBob.Location = new System.Drawing.Point(6, 72);
            this.radioButtonBob.Name = "radioButtonBob";
            this.radioButtonBob.Size = new System.Drawing.Size(85, 17);
            this.radioButtonBob.TabIndex = 7;
            this.radioButtonBob.Text = "radioButton1";
            this.radioButtonBob.UseVisualStyleBackColor = true;
            this.radioButtonBob.CheckedChanged += new System.EventHandler(this.radioButtonBob_CheckedChanged);
            // 
            // labelBetJoe
            // 
            this.labelBetJoe.AutoSize = true;
            this.labelBetJoe.Location = new System.Drawing.Point(143, 51);
            this.labelBetJoe.Name = "labelBetJoe";
            this.labelBetJoe.Size = new System.Drawing.Size(35, 13);
            this.labelBetJoe.TabIndex = 8;
            this.labelBetJoe.Text = "label1";
            // 
            // labelBetBob
            // 
            this.labelBetBob.AutoSize = true;
            this.labelBetBob.Location = new System.Drawing.Point(143, 74);
            this.labelBetBob.Name = "labelBetBob";
            this.labelBetBob.Size = new System.Drawing.Size(35, 13);
            this.labelBetBob.TabIndex = 9;
            this.labelBetBob.Text = "label1";
            // 
            // labelBetAl
            // 
            this.labelBetAl.AutoSize = true;
            this.labelBetAl.Location = new System.Drawing.Point(143, 97);
            this.labelBetAl.Name = "labelBetAl";
            this.labelBetAl.Size = new System.Drawing.Size(35, 13);
            this.labelBetAl.TabIndex = 10;
            this.labelBetAl.Text = "label1";
            // 
            // buttonRace
            // 
            this.buttonRace.Location = new System.Drawing.Point(422, 49);
            this.buttonRace.Name = "buttonRace";
            this.buttonRace.Size = new System.Drawing.Size(160, 61);
            this.buttonRace.TabIndex = 11;
            this.buttonRace.Text = "Race";
            this.buttonRace.UseVisualStyleBackColor = true;
            this.buttonRace.Click += new System.EventHandler(this.buttonRace_Click);
            // 
            // labelCurrentBettor
            // 
            this.labelCurrentBettor.AutoSize = true;
            this.labelCurrentBettor.Location = new System.Drawing.Point(6, 134);
            this.labelCurrentBettor.Name = "labelCurrentBettor";
            this.labelCurrentBettor.Size = new System.Drawing.Size(24, 13);
            this.labelCurrentBettor.TabIndex = 12;
            this.labelCurrentBettor.Text = "Joe";
            // 
            // buttonBet
            // 
            this.buttonBet.Location = new System.Drawing.Point(58, 129);
            this.buttonBet.Name = "buttonBet";
            this.buttonBet.Size = new System.Drawing.Size(75, 23);
            this.buttonBet.TabIndex = 13;
            this.buttonBet.Text = "Bets";
            this.buttonBet.UseVisualStyleBackColor = true;
            this.buttonBet.Click += new System.EventHandler(this.buttonBet_Click);
            // 
            // labelMinBet
            // 
            this.labelMinBet.AutoSize = true;
            this.labelMinBet.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMinBet.Location = new System.Drawing.Point(6, 28);
            this.labelMinBet.Name = "labelMinBet";
            this.labelMinBet.Size = new System.Drawing.Size(41, 13);
            this.labelMinBet.TabIndex = 15;
            this.labelMinBet.Text = "label2";
            // 
            // numericUpDownBet
            // 
            this.numericUpDownBet.Location = new System.Drawing.Point(146, 131);
            this.numericUpDownBet.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDownBet.Name = "numericUpDownBet";
            this.numericUpDownBet.Size = new System.Drawing.Size(52, 20);
            this.numericUpDownBet.TabIndex = 16;
            this.numericUpDownBet.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(205, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "bucks on dog number";
            // 
            // numericUpDownDog
            // 
            this.numericUpDownDog.Location = new System.Drawing.Point(321, 131);
            this.numericUpDownDog.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numericUpDownDog.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownDog.Name = "numericUpDownDog";
            this.numericUpDownDog.Size = new System.Drawing.Size(52, 20);
            this.numericUpDownDog.TabIndex = 18;
            this.numericUpDownDog.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 467);
            this.Controls.Add(this.pictureBoxDog4);
            this.Controls.Add(this.pictureBoxDog2);
            this.Controls.Add(this.pictureBoxDog3);
            this.Controls.Add(this.pictureBoxDog1);
            this.Controls.Add(this.racetrackPictureBox);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "A Day at the Races";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDog1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.racetrackPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDog3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDog2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDog4)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDog)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxDog1;
        private System.Windows.Forms.PictureBox racetrackPictureBox;
        private System.Windows.Forms.PictureBox pictureBoxDog3;
        private System.Windows.Forms.PictureBox pictureBoxDog2;
        private System.Windows.Forms.PictureBox pictureBoxDog4;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonJoe;
        private System.Windows.Forms.RadioButton radioButtonAl;
        private System.Windows.Forms.RadioButton radioButtonBob;
        private System.Windows.Forms.Label labelBetJoe;
        private System.Windows.Forms.Label labelBetBob;
        private System.Windows.Forms.Label labelBetAl;
        private System.Windows.Forms.Button buttonRace;
        private System.Windows.Forms.Label labelCurrentBettor;
        private System.Windows.Forms.Button buttonBet;
        private System.Windows.Forms.Label labelMinBet;
        private System.Windows.Forms.NumericUpDown numericUpDownBet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDownDog;
    }
}

