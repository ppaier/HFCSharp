using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lumberjack
{
    enum Flapjack
    {
        Crispy,
        Soggy,
        Browned,
        Banana,
    }
    class Lumberjack
    {
        public string Name { get; private set; }
        private Stack<Flapjack> meal;

        public Lumberjack(string name)
        {
            Name = name;
            meal = new Stack<Flapjack>();
        }

        public int FlapjackCount
        {
            get
            {
                return meal.Count;
            }
        }

        public void TakeFlapjacks(Flapjack food, int howMany)
        {
            for (int i = 0; i < howMany; ++i)
                meal.Push(food);
        }

        public string EatFlapjacks()
        {
            string eating = Name + "'s eating flapjacks" + Environment.NewLine;
            while (meal.Count > 0)
            {
                eating += Name + " ate a " + meal.Pop().ToString().ToLower() + " flapjack" + Environment.NewLine;
            }
            return eating;
        }
    }
}
