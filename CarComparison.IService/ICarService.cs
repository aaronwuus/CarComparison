using CarComparison.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarComparison.IService
{
    public interface ICarService
    {
        IEnumerable<Car> GetVehicleByNewest();
        IEnumerable<Car> GetVehicleByAlphabetized();
        IEnumerable<Car> GetVehicleByPrice();
        Car GetVehicleByBestValue();
        double GetConsumptionByDistance(int distance, Car car);
        Car GetVehicleByRandom();
        IEnumerable<Car> GetAllCars();
        double GetAverageMpgByYear(int year);
    }
}
