using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BeeHiveWPF
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string[] jobs;
        private Queen queen;
        public MainWindow()
        {
            InitializeComponent();
            jobs = new string[] { "Nectar collector" , "Honey manufactoring", "Egg care",
                                  "Baby bee tutoring", "Hive maintenance", "Sting patrol" };
            
            foreach (string j in jobs)
            {
                cbJob.Items.Add(j);
            }
            //cbJob.Sorted = true;
            cbJob.SelectedIndex = 0;

            Worker[] workers = new Worker[4];
            workers[0] = new Worker(new string[] { jobs[0], jobs[1] }, 175);
            workers[1] = new Worker(new string[] { jobs[2], jobs[3] }, 114);
            workers[2] = new Worker(new string[] { jobs[4], jobs[5] }, 149);
            workers[3] = new Worker(new string[] { jobs[0], jobs[1], jobs[2], jobs[3], jobs[4], jobs[5] }, 155);

            queen = new Queen(workers, 275);
        }

        private void btStartShift_Click(object sender, RoutedEventArgs e)
        {
            tbReport.Content = queen.WorkTheNextShift();
        }

        private void btAssign_Click(object sender, RoutedEventArgs e)
        {
            if (!queen.AssignWork(cbJob.Text, (int)iudShifts.Value))
                System.Windows.MessageBox.Show("No workers are available to do the job '" +
                    cbJob.Text + "'", "The queen bee says...");
            else
                System.Windows.MessageBox.Show("The job '" + cbJob.Text +
                    "' will be done in " + iudShifts.Value + " shifts", "The queen bee says...");
        }
    }
}
