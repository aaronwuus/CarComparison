using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CarComparison.App.Infrastructure.DTO
{
    public class CarDTO
    {
        public int ID { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int Year { get; set; }
        [DataType(DataType.Currency)]
        public double Price { get; set; }
        public double TccRating { get; set; }
        public int HwyMpg { get; set; }
    }
}
