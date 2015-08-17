namespace GoFish
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
            this.tbProgress = new System.Windows.Forms.TextBox();
            this.tbBooks = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.btStart = new System.Windows.Forms.Button();
            this.lbHand = new System.Windows.Forms.ListBox();
            this.btCard = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Your name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(347, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Your hand";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Game progress";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 329);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Books";
            // 
            // tbProgress
            // 
            this.tbProgress.Location = new System.Drawing.Point(16, 69);
            this.tbProgress.Multiline = true;
            this.tbProgress.Name = "tbProgress";
            this.tbProgress.ReadOnly = true;
            this.tbProgress.Size = new System.Drawing.Size(328, 257);
            this.tbProgress.TabIndex = 4;
            // 
            // tbBooks
            // 
            this.tbBooks.Location = new System.Drawing.Point(16, 345);
            this.tbBooks.Multiline = true;
            this.tbBooks.Name = "tbBooks";
            this.tbBooks.ReadOnly = true;
            this.tbBooks.Size = new System.Drawing.Size(328, 119);
            this.tbBooks.TabIndex = 5;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(16, 30);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(184, 20);
            this.tbName.TabIndex = 6;
            // 
            // btStart
            // 
            this.btStart.Location = new System.Drawing.Point(207, 30);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(137, 23);
            this.btStart.TabIndex = 7;
            this.btStart.Text = "Start the game!";
            this.btStart.UseVisualStyleBackColor = true;
            this.btStart.Click += new System.EventHandler(this.btStart_Click);
            // 
            // lbHand
            // 
            this.lbHand.FormattingEnabled = true;
            this.lbHand.Location = new System.Drawing.Point(350, 30);
            this.lbHand.Name = "lbHand";
            this.lbHand.Size = new System.Drawing.Size(155, 407);
            this.lbHand.TabIndex = 8;
            // 
            // btCard
            // 
            this.btCard.Enabled = false;
            this.btCard.Location = new System.Drawing.Point(350, 440);
            this.btCard.Name = "btCard";
            this.btCard.Size = new System.Drawing.Size(155, 23);
            this.btCard.TabIndex = 9;
            this.btCard.Text = "Ask for a Card";
            this.btCard.UseVisualStyleBackColor = true;
            this.btCard.Click += new System.EventHandler(this.btCard_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 476);
            this.Controls.Add(this.btCard);
            this.Controls.Add(this.lbHand);
            this.Controls.Add(this.btStart);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.tbBooks);
            this.Controls.Add(this.tbProgress);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Go Fish";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbProgress;
        private System.Windows.Forms.TextBox tbBooks;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Button btStart;
        private System.Windows.Forms.ListBox lbHand;
        private System.Windows.Forms.Button btCard;
    }
}

