using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeeHiveWPF
{
    class Worker : Bee
    {
        private string[] jobsICanDo;
        private string currentJob = "";
        private int shiftsToWork = 0;
        private int shiftsWorked = 0;

        public int ShiftsLeft
        {
            get
            {
                return shiftsToWork - shiftsWorked;
            }
        }

        public string CurrentJob
        {
            get
            {
                return currentJob;
            }
        }

        public Worker(string[] jobs, double weight) : base(weight)
        {
            jobsICanDo = jobs;
        }


        public bool DoThisJob(string job, int shifts)
        {
            if (!String.IsNullOrEmpty(currentJob))
                return false;

            foreach(string j in jobsICanDo)
            {
                if (j.Equals(job))
                {
                    shiftsToWork = shifts;
                    shiftsWorked = 0;
                    currentJob = job;
                    return true;
                }
            }
            return false;
        }

        public bool DidYouFinish()
        {
            if (String.IsNullOrEmpty(currentJob))
                return false;

            ++shiftsWorked;

            if (shiftsWorked > shiftsToWork)
            {
                shiftsWorked = 0;
                shiftsToWork = 0;
                currentJob = "";
                return true;
            }
            else
                return false;

        }

        public override double HoneyConsumptionRate()
        {
            return base.HoneyConsumptionRate() + 0.65*shiftsWorked;
        }

    }
}
