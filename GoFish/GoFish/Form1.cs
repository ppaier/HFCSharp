using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoFish
{
    public partial class Form1 : Form
    {
        private Game game;

        public Form1()
        {
            InitializeComponent();
        }

        private void btStart_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tbName.Text))
            {
                MessageBox.Show("Please enter your name!", "Can't start the game yet");
                return;
            }
            game = new Game(tbName.Text, new List<string> { "Joe", "Bob" }, tbProgress);
            btStart.Enabled = false;
            tbName.Enabled = false;
            btCard.Enabled = true;
            UpdateForm();
        }

        private void UpdateForm()
        {
            lbHand.Items.Clear();
            foreach (String cardName in game.GetPlayerCardNames())
                lbHand.Items.Add(cardName);
            tbBooks.Text = game.DescribeBooks();
            tbBooks.SelectionStart = tbProgress.Text.Length;
            tbBooks.ScrollToCaret();
            tbProgress.Text += game.DescribePlayerHands();
            tbProgress.SelectionStart = tbProgress.Text.Length;
            tbProgress.ScrollToCaret();
        }

        private void btCard_Click(object sender, EventArgs e)
        {
            tbProgress.Text = "";
            if(lbHand.SelectedIndex<0)
            {
                MessageBox.Show("Please select a card");
                return;
            }
            if(game.PlayOneRound(lbHand.SelectedIndex))
            {
                tbProgress.Text += "The winner is..." + game.GetWinnerName();
                tbBooks.Text = game.DescribeBooks();
                btCard.Enabled = false;
                btStart.Enabled = true;
                tbName.Enabled = true;
            }
            else
            {
                UpdateForm();
            }
        }
    }
}
