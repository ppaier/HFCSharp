using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ExcuseManager
{
    public partial class Form1 : Form
    {
        private Excuse currentExcuse = new Excuse();
        private bool formChanged;
        private string currentFolder;
        private Random random = new Random();

        public Form1()
        {
            InitializeComponent();
            currentExcuse.LastUsed = dtpLastUsed.Value;
            
            sfdSave.Filter = "Excuse Files (*.excuse)|*.excuse|All files (*.*)|*.*";
            ofdOpen.Filter = "Excuse Files (*.excuse)|*.excuse|All files (*.*)|*.*";

        }

        private void UpdateForm(bool changed)
        {
            if (!changed)
            {
                tbExcuse.Text = currentExcuse.CurrentDescription;
                tbResults.Text = currentExcuse.Results;
                dtpLastUsed.Value = currentExcuse.LastUsed;
                if (!String.IsNullOrEmpty(currentExcuse.ExcusePath))
                    lbFileDate.Text = File.GetLastWriteTime(currentExcuse.ExcusePath).ToString();
                this.Text = "ExcuseManager";
            }
            else
            {
                this.Text = "ExcuseManager*";
            }
            formChanged = changed;
        }

        private void btFolder_Click(object sender, EventArgs e)
        {
            bffFolder.SelectedPath = currentFolder;
            if(bffFolder.ShowDialog() == DialogResult.OK)
            {
                currentFolder = bffFolder.SelectedPath;
                btLoad.Enabled = true;
                btSave.Enabled = true;
                btRandom.Enabled = true;
            }
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            sfdSave.InitialDirectory = currentFolder;
            sfdSave.FileName = currentExcuse.CurrentDescription + ".excuse";
            if(sfdSave.ShowDialog()==DialogResult.OK)
            {
                if (String.IsNullOrEmpty(currentExcuse.Results) || String.IsNullOrEmpty(currentExcuse.CurrentDescription))
                {
                    MessageBox.Show("Please specify an excuse and a result", "Unable to save", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    currentExcuse.Save(sfdSave.FileName);
                    UpdateForm(false);
                }
            }
        }

        private void btLoad_Click(object sender, EventArgs e)
        {
            if (CheckChanged())
            {
                ofdOpen.InitialDirectory = currentFolder;
                ofdOpen.FileName = currentExcuse.CurrentDescription;
                if (ofdOpen.ShowDialog() == DialogResult.OK)
                {
                    currentExcuse = new Excuse(ofdOpen.FileName);
                    UpdateForm(false);
                }
            }
        }

        private bool CheckChanged()
        {
            if(formChanged)
            {
                DialogResult result = MessageBox.Show("The current excuse has not been saved. Continue?",
                    "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.No)
                    return false;
                return true;
            }
            return true;
        }

        private void tbExcuse_TextChanged(object sender, EventArgs e)
        {
            currentExcuse.CurrentDescription = tbExcuse.Text;
            UpdateForm(true);
        }

        private void tbResults_TextChanged(object sender, EventArgs e)
        {
            currentExcuse.Results = tbResults.Text;
            UpdateForm(true);
        }

        private void dtpLastUsed_ValueChanged(object sender, EventArgs e)
        {
            currentExcuse.LastUsed = dtpLastUsed.Value;
            UpdateForm(true);
        }

        private void btRandom_Click(object sender, EventArgs e)
        {
            if(CheckChanged())
            {
                currentExcuse = new Excuse(random, currentFolder);
                UpdateForm(false);
            }
        }
    }
}
