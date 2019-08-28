using CarComparison.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarComparison.IDataAccess
{
    public interface ICarRepository
    {
        IEnumerable<Car> AllCars();
        IEnumerable<Car> GetCarsByCondition(Func<Car, bool> whereCondition);
        Car GetCarByCondition(Func<Car, bool> whereCondition);
    }
}
