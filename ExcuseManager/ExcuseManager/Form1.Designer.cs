namespace ExcuseManager
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbExcuse = new System.Windows.Forms.TextBox();
            this.tbResults = new System.Windows.Forms.TextBox();
            this.lbFileDate = new System.Windows.Forms.Label();
            this.btFolder = new System.Windows.Forms.Button();
            this.btSave = new System.Windows.Forms.Button();
            this.btLoad = new System.Windows.Forms.Button();
            this.btRandom = new System.Windows.Forms.Button();
            this.dtpLastUsed = new System.Windows.Forms.DateTimePicker();
            this.ofdOpen = new System.Windows.Forms.OpenFileDialog();
            this.sfdSave = new System.Windows.Forms.SaveFileDialog();
            this.bffFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Excuse";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "File date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Last used";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Results";
            // 
            // tbExcuse
            // 
            this.tbExcuse.Location = new System.Drawing.Point(81, 6);
            this.tbExcuse.Name = "tbExcuse";
            this.tbExcuse.Size = new System.Drawing.Size(421, 20);
            this.tbExcuse.TabIndex = 5;
            this.tbExcuse.TextChanged += new System.EventHandler(this.tbExcuse_TextChanged);
            // 
            // tbResults
            // 
            this.tbResults.Location = new System.Drawing.Point(81, 32);
            this.tbResults.Name = "tbResults";
            this.tbResults.Size = new System.Drawing.Size(421, 20);
            this.tbResults.TabIndex = 6;
            this.tbResults.TextChanged += new System.EventHandler(this.tbResults_TextChanged);
            // 
            // lbFileDate
            // 
            this.lbFileDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbFileDate.Location = new System.Drawing.Point(81, 92);
            this.lbFileDate.Name = "lbFileDate";
            this.lbFileDate.Size = new System.Drawing.Size(421, 23);
            this.lbFileDate.TabIndex = 7;
            // 
            // btFolder
            // 
            this.btFolder.Location = new System.Drawing.Point(15, 128);
            this.btFolder.Name = "btFolder";
            this.btFolder.Size = new System.Drawing.Size(110, 23);
            this.btFolder.TabIndex = 8;
            this.btFolder.Text = "Folder";
            this.btFolder.UseVisualStyleBackColor = true;
            this.btFolder.Click += new System.EventHandler(this.btFolder_Click);
            // 
            // btSave
            // 
            this.btSave.Enabled = false;
            this.btSave.Location = new System.Drawing.Point(131, 128);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(110, 23);
            this.btSave.TabIndex = 9;
            this.btSave.Text = "Save";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // btLoad
            // 
            this.btLoad.Enabled = false;
            this.btLoad.Location = new System.Drawing.Point(247, 128);
            this.btLoad.Name = "btLoad";
            this.btLoad.Size = new System.Drawing.Size(110, 23);
            this.btLoad.TabIndex = 10;
            this.btLoad.Text = "Load";
            this.btLoad.UseVisualStyleBackColor = true;
            this.btLoad.Click += new System.EventHandler(this.btLoad_Click);
            // 
            // btRandom
            // 
            this.btRandom.Enabled = false;
            this.btRandom.Location = new System.Drawing.Point(363, 128);
            this.btRandom.Name = "btRandom";
            this.btRandom.Size = new System.Drawing.Size(139, 23);
            this.btRandom.TabIndex = 11;
            this.btRandom.Text = "Random";
            this.btRandom.UseVisualStyleBackColor = true;
            this.btRandom.Click += new System.EventHandler(this.btRandom_Click);
            // 
            // dtpLastUsed
            // 
            this.dtpLastUsed.Location = new System.Drawing.Point(81, 60);
            this.dtpLastUsed.Name = "dtpLastUsed";
            this.dtpLastUsed.Size = new System.Drawing.Size(421, 20);
            this.dtpLastUsed.TabIndex = 12;
            this.dtpLastUsed.ValueChanged += new System.EventHandler(this.dtpLastUsed_ValueChanged);
            // 
            // ofdOpen
            // 
            this.ofdOpen.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 163);
            this.Controls.Add(this.dtpLastUsed);
            this.Controls.Add(this.btRandom);
            this.Controls.Add(this.btLoad);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.btFolder);
            this.Controls.Add(this.lbFileDate);
            this.Controls.Add(this.tbResults);
            this.Controls.Add(this.tbExcuse);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Excuse Manager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbExcuse;
        private System.Windows.Forms.TextBox tbResults;
        private System.Windows.Forms.Label lbFileDate;
        private System.Windows.Forms.Button btFolder;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Button btLoad;
        private System.Windows.Forms.Button btRandom;
        private System.Windows.Forms.DateTimePicker dtpLastUsed;
        private System.Windows.Forms.OpenFileDialog ofdOpen;
        private System.Windows.Forms.SaveFileDialog sfdSave;
        private System.Windows.Forms.FolderBrowserDialog bffFolder;
    }
}

