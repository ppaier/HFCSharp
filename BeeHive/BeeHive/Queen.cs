using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeeHive
{
    class Queen : Bee
    {
        private Worker[] workers;
        private int shiftNumber = 0;

        public Queen(Worker [] w, double weight) : base(weight)
        {
            workers = w;
        }


        public bool AssignWork(string job, int shifts)
        {
            foreach(Worker w in workers)
            {
                if (w.DoThisJob(job, shifts))
                    return true;
            }
            return false;
        }

        public string WorkTheNextShift()
        {
            ++shiftNumber;
            string report = "Report for shift #" + shiftNumber + "\r\n";
            double honeyConsumed = HoneyConsumptionRate();
            for (int i = 0; i < workers.Length; ++i)
            {
                honeyConsumed += workers[i].HoneyConsumptionRate();
                if (workers[i].DidYouFinish())
                    report += "Worker #" + (i + 1) + " finished the job\r\n";
                else if (String.IsNullOrEmpty(workers[i].CurrentJob))
                    report += "Worker #" + (i + 1) + " is not working\r\n";
                else
                {
                    if (workers[i].ShiftsLeft > 0)
                    {
                        report += "Worker #" + (i + 1) + " is doing '" + workers[i].CurrentJob +
                                  "' for " + workers[i].ShiftsLeft + " more shifts \r\n";
                    }
                    else
                    {
                        report += "Worker #" + (i + 1) + " will be done with '" + workers[i].CurrentJob +
                                  "' after this shift\r\n";
                    }
                }
            }
            report += "Total honey consumed for the shift: " + honeyConsumed + "€";
            return report;
        }

    }
}
