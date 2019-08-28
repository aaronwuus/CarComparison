using System;
using System.Collections.Generic;
using System.Text;

namespace CarComparison.Core.Entities
{
    public interface ICarDB
    {
        List<Car> Cars { get; set; }
    }
}
