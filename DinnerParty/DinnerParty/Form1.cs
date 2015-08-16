using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DinnerParty
{
    public partial class Form1 : Form
    {
        DinnerParty dinnerParty;
        public Form1()
        {
            InitializeComponent();
            dinnerParty = new DinnerParty((int)numericUpDownNumPeople.Value, checkBoxHealthy.Checked, checkBoxFancy.Checked);
            DisplayDinnerPartyCost();
        }


        private void DisplayDinnerPartyCost()
        {
            decimal Cost = dinnerParty.Cost;
            labelCost.Text = Cost.ToString("c");
        }

        private void numericUpDownNumPeople_ValueChanged(object sender, EventArgs e)
        {
            dinnerParty.NumberOfPeople = (int)numericUpDownNumPeople.Value;
            DisplayDinnerPartyCost();
        }

        private void checkBoxFancy_CheckedChanged(object sender, EventArgs e)
        {
            dinnerParty.FancyDecorations = checkBoxFancy.Checked;
            DisplayDinnerPartyCost();
        }

        private void checkBoxHealthy_CheckedChanged(object sender, EventArgs e)
        {
            dinnerParty.HealthyOption = checkBoxHealthy.Checked;
            DisplayDinnerPartyCost();
        }
    }
}
