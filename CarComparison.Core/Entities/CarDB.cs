using CarComparison.Core.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarComparison.Core.Entities
{
    public class CarDB: ICarDB
    {
        public List<Car> Cars { get; set; }
        public CarDB()
        {
            Cars = new List<Car>();
            Cars.Add(
               new Car() { ID=1, Make = "Honda", Model = "CRV", Year = 2016, Price = 23845, TccRating = 8, HwyMpg = 33, Color = EnumColor.Green });
            Cars.Add(
                new Car() { ID=2, Make = "Ford", Model = "Escape", Year = 2017, Price = 23590, TccRating = 7.8, HwyMpg = 32, Color = EnumColor.Red });
            Cars.Add(
                new Car() { ID=3, Make = "Hyundai", Model = "Sante Fe", Year = 2016, Price = 24590, TccRating = 8, HwyMpg = 27, Color = EnumColor.Grey });
            Cars.Add(
                new Car() { ID=4, Make = "Mazda", Model = "CX-5", Year = 2017, Price = 21795, TccRating = 8, HwyMpg = 35, Color = EnumColor.Red });
            Cars.Add(
                new Car() { ID=5, Make = "Subaru", Model = "Forester", Year = 2016, Price = 22395, TccRating = 8.4, HwyMpg = 32, Color = EnumColor.Blue });
        }
        
    }
}
