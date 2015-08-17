using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ducks
{
    class Program
    {
        private static List<Duck> ducks;
        static void Main(string[] args)
        {
            //DuckListTest();
            ducks = new List<Duck>
            {
                new Duck(KindOfDuck.Mallard, 17),
                new Duck(KindOfDuck.Muscovy, 18),
                new Duck(KindOfDuck.Decoy, 14),
                new Duck(KindOfDuck.Muscovy, 11),
                new Duck(KindOfDuck.Mallard, 14),
                new Duck(KindOfDuck.Decoy, 13)
            };
            UpcastTest();

        }

        private static void UpcastTest()
        {
            IEnumerable<Bird> upcastDucks = ducks;

            List<Bird> birds = new List<Bird>();
            birds.Add( new Bird() { Name = "Feathers" });
            birds.AddRange(upcastDucks);
            birds.Add( new Penguin() { Name = "George" });

            ducks.Sort();

            foreach (Bird bird in birds)
                Console.WriteLine(bird);

        }

        private static void DuckListTest()
        {
            ducks.Sort();
            PrintDucks(ducks);

            IComparer<Duck> comparerSizeAsc = new DuckComparerBySize(Order.ASCENDING);
            IComparer<Duck> comparerSizeDesc = new DuckComparerBySize(Order.DESCENDING);

            IComparer<Duck> comparerKindAsc = new DuckComparerByKind(Order.ASCENDING);
            IComparer<Duck> comparerKindDesc = new DuckComparerByKind(Order.DESCENDING);

            ducks.Sort(comparerSizeAsc);
            PrintDucks(ducks);
            ducks.Sort(comparerSizeDesc);
            PrintDucks(ducks);
            ducks.Sort(comparerKindAsc);
            PrintDucks(ducks);
            ducks.Sort(comparerKindDesc);
            PrintDucks(ducks);
        }

        private static void PrintDucks(List<Duck> ducks)
        {
            foreach (Duck duck in ducks)
                System.Console.WriteLine(duck);
            System.Console.WriteLine("---------------------------------");
        }
    }


}
