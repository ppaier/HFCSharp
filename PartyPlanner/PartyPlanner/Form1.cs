using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PartyPlanner
{
    public partial class Form1 : Form
    {
        DinnerParty dinnerParty;
        BirthdayParty birthdayParty;
        Party currentParty;
        public Form1()
        {
            InitializeComponent();

            birthdayParty = new BirthdayParty((int)numericUpDownNumPeople.Value, checkBoxHealthy.Checked, "");
            dinnerParty = new DinnerParty((int)numericUpDownNumPeople.Value, checkBoxHealthy.Checked, checkBoxFancy.Checked);

            currentParty = birthdayParty;
            comboBoxPartyType.SelectedIndex = 0;
            DisplayPartyCost();
        }


        private void DisplayPartyCost()
        {
            decimal Cost = currentParty.Cost;
            labelCost.Text = Cost.ToString("c");

            if (comboBoxPartyType.SelectedIndex == 0)
            {
                labelTooLong.Visible = birthdayParty.CakeWritingTooLong;
            }
        }

        private void numericUpDownNumPeople_ValueChanged(object sender, EventArgs e)
        {
            currentParty.NumberOfPeople = (int)numericUpDownNumPeople.Value;
            DisplayPartyCost();
        }

        private void checkBoxFancy_CheckedChanged(object sender, EventArgs e)
        {
            currentParty.FancyDecorations = checkBoxFancy.Checked;
            DisplayPartyCost();
        }

        private void checkBoxHealthy_CheckedChanged(object sender, EventArgs e)
        {
            dinnerParty.HealthyOption = checkBoxHealthy.Checked;
            DisplayPartyCost();
        }

        private void comboBoxPartyType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBoxPartyType.SelectedIndex==0)
            {
                currentParty = birthdayParty;
                currentParty.FancyDecorations = checkBoxFancy.Checked;
                currentParty.NumberOfPeople = (int) numericUpDownNumPeople.Value;
                birthdayParty.CakeWriting = textBoxCakeWriting.Text;
                labelTooLong.Visible = birthdayParty.CakeWritingTooLong;

                checkBoxHealthy.Enabled = false;
                textBoxCakeWriting.Enabled = true;               
            }
            else
            {
                currentParty = dinnerParty;
                currentParty.FancyDecorations = checkBoxFancy.Checked;
                currentParty.NumberOfPeople = (int)numericUpDownNumPeople.Value;
                dinnerParty.HealthyOption = checkBoxHealthy.Checked;

                checkBoxHealthy.Enabled = true;
                textBoxCakeWriting.Enabled = false;
                labelTooLong.Visible = false;
            }

            DisplayPartyCost();
        }

        private void textBoxCakeWriting_TextChanged(object sender, EventArgs e)
        {
            birthdayParty.CakeWriting = textBoxCakeWriting.Text;
            labelTooLong.Visible = birthdayParty.CakeWritingTooLong;

            DisplayPartyCost();
        }
    }
}
