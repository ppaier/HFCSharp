namespace RandomCard
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
            this.tbCardDescription = new System.Windows.Forms.TextBox();
            this.btDrawCard = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbCardDescription
            // 
            this.tbCardDescription.Location = new System.Drawing.Point(12, 43);
            this.tbCardDescription.Name = "tbCardDescription";
            this.tbCardDescription.Size = new System.Drawing.Size(260, 20);
            this.tbCardDescription.TabIndex = 0;
            // 
            // btDrawCard
            // 
            this.btDrawCard.Location = new System.Drawing.Point(13, 10);
            this.btDrawCard.Name = "btDrawCard";
            this.btDrawCard.Size = new System.Drawing.Size(259, 23);
            this.btDrawCard.TabIndex = 1;
            this.btDrawCard.Text = "Draw Card";
            this.btDrawCard.UseVisualStyleBackColor = true;
            this.btDrawCard.Click += new System.EventHandler(this.btDrawCard_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 79);
            this.Controls.Add(this.btDrawCard);
            this.Controls.Add(this.tbCardDescription);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Random Card Generator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbCardDescription;
        private System.Windows.Forms.Button btDrawCard;
    }
}

