using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ducks
{
    enum Order
    {
        ASCENDING,
        DESCENDING
    }

    class DuckComparerBySize : IComparer<Duck>
    {
        public Order Order;

        public DuckComparerBySize(Order order)
        {
            Order = order;
        }

        public int Compare(Duck x, Duck y)
        {
            if (x.Size > y.Size)
                return (Order == Order.ASCENDING) ? 1 : -1;
            else if (x.Size < y.Size)
                return (Order == Order.ASCENDING) ? -1 : 1;
            else
                return 0;
        }
    }

    class DuckComparerByKind : IComparer<Duck>
    {
        public Order Order;

        public DuckComparerByKind(Order order)
        {
            Order = order;
        }

        public int Compare(Duck x, Duck y)
        {
            if (x.Kind > y.Kind)
                return (Order == Order.ASCENDING) ? -1 : 1;
            else if (x.Kind < y.Kind)
                return (Order == Order.ASCENDING) ? 1 : -1;
            else
                return 0;
        }
    }
}
