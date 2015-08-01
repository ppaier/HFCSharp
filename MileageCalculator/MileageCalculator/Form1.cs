using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MileageCalculator
{

    public partial class mainForm : Form
    {
        double milesTraveled = 0.0;
        const double reimburseRate = 0.39;
        double amountOwed = 0.0;

        public mainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            milesTraveled = (double) (endingMileage.Value - startingMileage.Value);
            amountOwed = milesTraveled * reimburseRate;

            labelOwed.Text = "$" + amountOwed;

        }
    }
}
