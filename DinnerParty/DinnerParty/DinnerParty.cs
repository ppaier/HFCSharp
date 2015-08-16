using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinnerParty
{

    class DinnerParty
    {
        private const int costOfFoodPerPerson = 25;

        public int NumberOfPeople { get; set; }
        public bool FancyDecorations { get; set; }
        public bool HealthyOption { get; set; }
        public decimal Cost
        {
            get
            {
                decimal totalCost = CalculateCostOfDecorations() + NumberOfPeople * (costOfFoodPerPerson + CalculateCostOfBeveragesPerPerson());

                if (HealthyOption)
                    totalCost *= 0.95M;

                return totalCost;
            }
        }
        public DinnerParty(int numberOfPeople, bool isHealthy, bool isFancy)
        {
            NumberOfPeople = numberOfPeople;
            HealthyOption = isHealthy;
            FancyDecorations = isFancy;
        }


        private decimal CalculateCostOfDecorations()
        {
            if (FancyDecorations)
                return (NumberOfPeople * 15.00M) + 50.00M;
            else
                return (NumberOfPeople * 7.50M) + 30.00M;
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
