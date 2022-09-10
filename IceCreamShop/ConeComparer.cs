using System;
using System.Collections.Generic;
using System.Text;

namespace IceCreamShop
{
    public class ConeComparer : IComparer<Cone>
    {
        public int Compare(Cone x, Cone y)
        {
            double priceDifference = x.Cost - y.Cost;

            if (priceDifference == 0)
            {
                return 0;
            }
            else if (priceDifference < 0)
            {
                return -1;
            }
            else
            {
                return 1;
            }
        }
    }
}
