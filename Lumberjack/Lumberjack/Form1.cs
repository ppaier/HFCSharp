using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lumberjack
{
    public partial class Form1 : Form
    {
        private Queue<Lumberjack> breakfastLine = new Queue<Lumberjack>(); 

        public Form1()
        {
            InitializeComponent();
        }

        private void RedrawList()
        {
            lbLumberjacks.Items.Clear();
            int cnt = 0;
            foreach (Lumberjack lumberjack in breakfastLine)
            {
                lbLumberjacks.Items.Add((++cnt) + ". " + lumberjack.Name);
            }

            tbFlapjacks.Text = breakfastLine.Peek().Name + " has " + breakfastLine.Peek().FlapjackCount + " flapjacks";
        }
        

        private void btAddFlapjacks_Click(object sender, EventArgs e)
        {
            if (breakfastLine.Count == 0)
                return;

            Flapjack food;
            if (rbCrispy.Checked)
                food = Flapjack.Crispy;
            else if (rbSoggy.Checked)
                food = Flapjack.Soggy;
            else if (rbBrowned.Checked)
                food = Flapjack.Browned;
            else if (rbBanana.Checked)
                food = Flapjack.Banana;
            else
                return;

            breakfastLine.Peek().TakeFlapjacks(food, (int) nudNumber.Value);
            RedrawList();
        }

        private void btAddLumberjack_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tbLumberjackName.Text))
            {
                MessageBox.Show("Please insert the name of the lumberjack.");
                return;
            }
            else
            {
                breakfastLine.Enqueue(new Lumberjack(tbLumberjackName.Text));
                RedrawList();
            }
        }

        private void btNextLumberjack_Click(object sender, EventArgs e)
        {
            if (breakfastLine.Count > 0)
            {
                Lumberjack lumberjack = breakfastLine.Dequeue();
                string eating = lumberjack.EatFlapjacks();
                MessageBox.Show(eating, "Lumberjack is eating.");
                RedrawList();
            }
        }
    }
}
