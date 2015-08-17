using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ducks
{
    enum KindOfDuck
    {
        Mallard,
        Muscovy,
        Decoy
    }
    class Duck : Bird, IComparable<Duck>
    {
        public int Size { get; private set; }
        public KindOfDuck Kind
        {
            get; private set;
        }

        public Duck(KindOfDuck kind, int size)
        {
            Size = size;
            Kind = kind;
        }

        public int CompareTo(Duck duckToCompare)
        {
            if (Size > duckToCompare.Size)
                return 1;
            else if (Size < duckToCompare.Size)
                return -1;
            else
                return 0;
        }

        public override string ToString()
        {
            return Kind.ToString() + " duck with size " + Size;
        }
    }
}
