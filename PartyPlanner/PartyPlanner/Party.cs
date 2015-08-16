using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartyPlanner
{
    class Party
    {
        public const int costOfFoodPerPerson = 25;
        public int NumberOfPeople { get; set; }
        public bool FancyDecorations { get; set; }

        public Party(int numberOfPeople, bool isFancy)
        {
            NumberOfPeople = numberOfPeople;
            FancyDecorations = isFancy;
        }

        virtual public decimal Cost
        {
            get
            {
                decimal totalCost = CalculateCostOfDecorations() + NumberOfPeople * costOfFoodPerPerson;
                if (NumberOfPeople > 12)
                    totalCost += 100;        
                return totalCost;
            }
        }


        private decimal CalculateCostOfDecorations()
        {
            if (FancyDecorations)
                return (NumberOfPeople * 15.00M) + 50.00M;
            else
                return (NumberOfPeople * 7.50M) + 30.00M;
        }

    }
}
