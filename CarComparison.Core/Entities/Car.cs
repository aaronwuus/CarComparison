using CarComparison.Core.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CarComparison.Core.Entities
{
    public class Car
    {
        public int ID { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public EnumColor Color { get;set; }
        public int Year { get; set; }
        [DataType(DataType.Currency)]
        public double Price { get; set; }
        public double TccRating { get; set; }
        public int HwyMpg { get; set; }
    }
}
