using CarComparison.Core.Entities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CarComparison.Core.Utils
{
    public class PriceComparer: IComparer<Car>
    {
        public int Compare(Car c1, Car c2)
        {
            if (c1.Price == c2.Price)
                return 0;
            if (c1.Price < c2.Price)
                return -1;
            return 1; 
        }
    }
}
