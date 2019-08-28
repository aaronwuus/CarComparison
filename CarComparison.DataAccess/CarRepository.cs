using CarComparison.Core.Entities;
using CarComparison.IDataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarComparison.DataAccess
{
    public class CarRepository:ICarRepository
    {
        private readonly ICarDB _carDB;
        public CarRepository(ICarDB carDB)
        {
            _carDB = carDB;
        }
        public IEnumerable<Car> AllCars()
        {
            return _carDB.Cars;
        }

        public IEnumerable<Car> GetCarsByCondition(Func<Car,bool> whereCondition)
        {
            return _carDB.Cars.Where(whereCondition);
        }

        public Car GetCarByCondition(Func<Car, bool> whereCondition)
        {
            return _carDB.Cars.FirstOrDefault(whereCondition);
        }
    }
}
