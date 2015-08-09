using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADayAtTheRaces
{
    public partial class Form1 : Form
    {
        Greyhound [] GreyhoundArray = new Greyhound[4];
        Guy[] Guys = new Guy[3];
        Random MyRandomizer = new Random();

        public Form1()
        {
            InitializeComponent();
            labelMinBet.Text = "Bet-Size Range: " + numericUpDownBet.Minimum + "-" + numericUpDownBet.Maximum + " bucks";
            InitGreyhounds();
            InitGuys();
        }

        public void InitGreyhounds()
        {
            GreyhoundArray[0] = new Greyhound()
            {
                StartingPosition = pictureBoxDog1.Left,
                RacetrackLength = racetrackPictureBox.Width - pictureBoxDog1.Width,
                MyPictureBox = pictureBoxDog1,
                Randomizer = MyRandomizer
            };
            GreyhoundArray[1] = new Greyhound()
            {
                StartingPosition = pictureBoxDog2.Left,
                RacetrackLength = racetrackPictureBox.Width - pictureBoxDog2.Width,
                MyPictureBox = pictureBoxDog2,
                Randomizer = MyRandomizer
            };
            GreyhoundArray[2] = new Greyhound()
            {
                StartingPosition = pictureBoxDog3.Left,
                RacetrackLength = racetrackPictureBox.Width - pictureBoxDog3.Width,
                MyPictureBox = pictureBoxDog3,
                Randomizer = MyRandomizer
            };
            GreyhoundArray[3] = new Greyhound()
            {
                StartingPosition = pictureBoxDog4.Left,
                RacetrackLength = racetrackPictureBox.Width - pictureBoxDog4.Width,
                MyPictureBox = pictureBoxDog4,
                Randomizer = MyRandomizer
            };

        }
        public void InitGuys()
        {
            Guys[0] = new Guy() {
                Name = "Joe",
                Cash = 50,
                MyRadioButton = radioButtonJoe,
                MyLabel = labelBetJoe
            };
            Guys[1] = new Guy()
            {
                Name = "Bob",
                Cash = 75,
                MyRadioButton = radioButtonBob,
                MyLabel = labelBetBob
            };
            Guys[2] = new Guy()
            {
                Name = "Al",
                Cash = 45,
                MyRadioButton = radioButtonAl,
                MyLabel = labelBetAl
            };
            foreach(Guy g in Guys)
            {
                g.UpdateLabels();
            }
        }

        private void radioButtonJoe_CheckedChanged(object sender, EventArgs e)
        {
            labelCurrentBettor.Text = "Joe";
        }

        private void radioButtonBob_CheckedChanged(object sender, EventArgs e)
        {
            labelCurrentBettor.Text = "Bob";
        }

        private void radioButtonAl_CheckedChanged(object sender, EventArgs e)
        {
            labelCurrentBettor.Text = "Al";
        }

        private void buttonBet_Click(object sender, EventArgs e)
        {
            int idxGuy = 0;
            if (radioButtonJoe.Checked)
                idxGuy = 0;
            else if (radioButtonBob.Checked)
                idxGuy = 1;
            else if(radioButtonAl.Checked)
               idxGuy = 2;

            if (Guys[idxGuy].PlaceBet((int)numericUpDownBet.Value, (int)numericUpDownDog.Value))
                Guys[idxGuy].UpdateLabels();
            else
            {
                MessageBox.Show(Guys[idxGuy].Name + " has not enough money to place the Bet or tried to bet on a non-existing dog", 
                    Guys[idxGuy].Name + "'s Bet couldn't be made!");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            for(int i=0; i < GreyhoundArray.Length; ++i)
            {
                Greyhound dog = GreyhoundArray[i];
                if(dog.Run())
                {
                    foreach (Guy g in Guys)
                    {
                        g.Collect(i+1);
                        g.ClearBet();
                        g.UpdateLabels();
                    }
                    timer1.Stop();
                    MessageBox.Show("Dog #" + (i + 1) + " won the Race", "We have a Winner!");
                    groupBox1.Enabled = true;
                    break;
                }
            }
        }

        private void buttonRace_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = false;
            foreach (Greyhound dog in GreyhoundArray)
                dog.TakingStartingPosition();
            timer1.Start();
        }
    }
}
