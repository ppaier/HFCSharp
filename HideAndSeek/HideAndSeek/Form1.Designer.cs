namespace HideAndSeek
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
            this.comboBoxLocation = new System.Windows.Forms.ComboBox();
            this.buttonGoThroughDoor = new System.Windows.Forms.Button();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.buttonGoHere = new System.Windows.Forms.Button();
            this.buttonCheck = new System.Windows.Forms.Button();
            this.buttonHide = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxLocation
            // 
            this.comboBoxLocation.FormattingEnabled = true;
            this.comboBoxLocation.Location = new System.Drawing.Point(94, 185);
            this.comboBoxLocation.Name = "comboBoxLocation";
            this.comboBoxLocation.Size = new System.Drawing.Size(220, 21);
            this.comboBoxLocation.TabIndex = 1;
            // 
            // buttonGoThroughDoor
            // 
            this.buttonGoThroughDoor.Location = new System.Drawing.Point(13, 217);
            this.buttonGoThroughDoor.Name = "buttonGoThroughDoor";
            this.buttonGoThroughDoor.Size = new System.Drawing.Size(301, 23);
            this.buttonGoThroughDoor.TabIndex = 2;
            this.buttonGoThroughDoor.Text = "Go through the door";
            this.buttonGoThroughDoor.UseVisualStyleBackColor = true;
            this.buttonGoThroughDoor.Click += new System.EventHandler(this.buttonGoThroughDoor_Click);
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(13, 13);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(301, 158);
            this.textBoxDescription.TabIndex = 3;
            // 
            // buttonGoHere
            // 
            this.buttonGoHere.Location = new System.Drawing.Point(13, 183);
            this.buttonGoHere.Name = "buttonGoHere";
            this.buttonGoHere.Size = new System.Drawing.Size(75, 23);
            this.buttonGoHere.TabIndex = 4;
            this.buttonGoHere.Text = "Go here:";
            this.buttonGoHere.UseVisualStyleBackColor = true;
            this.buttonGoHere.Click += new System.EventHandler(this.buttonGoHere_Click);
            // 
            // buttonCheck
            // 
            this.buttonCheck.Location = new System.Drawing.Point(13, 247);
            this.buttonCheck.Name = "buttonCheck";
            this.buttonCheck.Size = new System.Drawing.Size(301, 23);
            this.buttonCheck.TabIndex = 5;
            this.buttonCheck.Text = "Check";
            this.buttonCheck.UseVisualStyleBackColor = true;
            this.buttonCheck.Click += new System.EventHandler(this.buttonCheck_Click);
            // 
            // buttonHide
            // 
            this.buttonHide.Location = new System.Drawing.Point(13, 277);
            this.buttonHide.Name = "buttonHide";
            this.buttonHide.Size = new System.Drawing.Size(301, 23);
            this.buttonHide.TabIndex = 6;
            this.buttonHide.Text = "Hide";
            this.buttonHide.UseVisualStyleBackColor = true;
            this.buttonHide.Click += new System.EventHandler(this.buttonHide_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 308);
            this.Controls.Add(this.buttonHide);
            this.Controls.Add(this.buttonCheck);
            this.Controls.Add(this.buttonGoHere);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.buttonGoThroughDoor);
            this.Controls.Add(this.comboBoxLocation);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Hide and Seek";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBoxLocation;
        private System.Windows.Forms.Button buttonGoThroughDoor;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.Button buttonGoHere;
        private System.Windows.Forms.Button buttonCheck;
        private System.Windows.Forms.Button buttonHide;
    }
}

