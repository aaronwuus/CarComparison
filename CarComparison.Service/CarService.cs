using CarComparison.Core.Entities;
using CarComparison.Core.Utils;
using CarComparison.IDataAccess;
using CarComparison.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarComparison.Service
{
    public class CarService : ICarService
    {
        private readonly ICarRepository _carRepository;
        public CarService(ICarRepository carRepository)
        {
            _carRepository = carRepository;
        }

        public IEnumerable<Car> GetAllCars()
        {
            return _carRepository.AllCars();
        }

        public double GetAverageMpgByYear(int year)
        {
            return _carRepository.GetCarsByCondition(c=>c.Year==year).Average(c=>c.HwyMpg);
        }

        public double GetConsumptionByDistance(int distance,Car car)
        {
            var cr = _carRepository.GetCarByCondition(c=>c.ID==car.ID);
            return cr.HwyMpg * distance;
        }

        public IEnumerable<Car> GetVehicleByAlphabetized()
        {
            var cars = _carRepository.AllCars().OrderBy(c=>c.Make).ThenBy(c=>c.Model);
            return cars;
        }

        public Car GetVehicleByBestValue()
        {
            //also can use Linq OrderBy method
            var cars = _carRepository.AllCars().ToList();
            cars.Sort(new ValueComparer());
            return cars.FirstOrDefault();
        }

        public IEnumerable<Car> GetVehicleByNewest()
        {
            return _carRepository.GetCarsByCondition(c=>c.Year == _carRepository.AllCars().Max(cr=>cr.Year)).OrderBy(c=>c.Model);
        }

        public IEnumerable<Car> GetVehicleByPrice()
        {
            //also can use Linq OrderBy method
            var cars = _carRepository.AllCars().ToList();
            cars.Sort(new PriceComparer());
            return cars;
        }

        public Car GetVehicleByRandom()
        {
            Random r = new Random();
            return _carRepository.AllCars().ToArray()[r.Next(0,4)];
        }
    }
}
