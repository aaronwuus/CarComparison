using CarComparison.Core.Entities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CarComparison.Core.Utils
{
    public class ValueComparer : IComparer<Car>
    {
        public int Compare(Car c1, Car c2)
        {
            var c1Value = c1.Price / c1.TccRating;
            var c2Value = c2.Price / c2.TccRating;
            if (c1Value == c2Value)
                return 0;
            if (c1Value < c2Value)
                return -1;
            return 1;
        }
    }
}
