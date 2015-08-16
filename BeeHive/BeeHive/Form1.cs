using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeeHive
{
    public partial class Form1 : Form
    {
        private string [] jobs;
        private Queen queen;

        public Form1()
        {
            InitializeComponent();
            jobs = new string[] { "Nectar collector" , "Honey manufactoring", "Egg care",
                                  "Baby bee tutoring", "Hive maintenance", "Sting patrol" };
            
            foreach(string j in jobs)
            {
                comboBoxJobs.Items.Add(j);
            }
            comboBoxJobs.Sorted = true;
            comboBoxJobs.SelectedIndex = 0;

            Worker[] workers = new Worker[4];
            workers[0] = new Worker(new string[] { jobs[0], jobs[1] }, 175);
            workers[1] = new Worker(new string[] { jobs[2], jobs[3] }, 114);
            workers[2] = new Worker(new string[] { jobs[4], jobs[5] }, 149);
            workers[3] = new Worker(new string[] { jobs[0], jobs[1], jobs[2], jobs[3], jobs[4], jobs[5] }, 155);

            queen = new Queen(workers, 275);


        }

        private void buttonAssignJob_Click(object sender, EventArgs e)
        {
            if (!queen.AssignWork(comboBoxJobs.Text, (int)numericUpDownShifts.Value))
                MessageBox.Show("No workers are available to do the job '" +
                    comboBoxJobs.Text + "'", "The queen bee says...");
            else
                MessageBox.Show("The job '" + comboBoxJobs.Text + 
                    "' will be done in " + numericUpDownShifts.Value + " shifts", "The queen bee says...");
        }

        private void buttonWorkShift_Click(object sender, EventArgs e)
        {
            textBoxReport.Text = queen.WorkTheNextShift();
        }
    }
}
