using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PartyPlanner
{

    class DinnerParty : Party
    {

        public bool HealthyOption { get; set; }

        public DinnerParty(int numberOfPeople, bool isHealthy, bool isFancy) : base(numberOfPeople, isFancy)
        {
            HealthyOption = isHealthy;
        }

        override public decimal Cost
        {
            get
            {
                decimal totalCost = base.Cost + NumberOfPeople * CalculateCostOfBeveragesPerPerson();

                if (HealthyOption)
                    totalCost *= 0.95M;

                return totalCost;
            }
        }

        private decimal CalculateCostOfBeveragesPerPerson()
        {
            if (HealthyOption)
                return 5.00M;
            else
                return 20.00M;
        }

    }
}
