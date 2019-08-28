using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using CarComparison.App.Infrastructure.DTO;
using CarComparison.Core.Entities;
using CarComparison.IService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CarComparison.App.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarComparisonController : ControllerBase
    {
        private readonly ICarService _carService;
        private readonly IMapper _mapper;
        public CarComparisonController(ICarService carService, IMapper mapper)
        {
            _carService = carService;
            _mapper = mapper;
        }

        // GET: A function to calculate newest vehicles in order // GetVehicleByNewest
        [HttpGet]
        [Route("GetVehicleByNewest")]
        public IActionResult GetVehicleByNewest()
        {
            var cars = _carService.GetVehicleByNewest().ToList();
            var carDtos = _mapper.Map<IEnumerable<Car>, IEnumerable<CarDTO>>(cars);
            return Ok(carDtos);
        }

        // GET: A function to calculate alphabetized List of vehicles // GetVehicleByAlphabetized
        [HttpGet]
        [Route("GetVehicleByAlphabetized")]
        public IActionResult GetVehicleByAlphabetized()
        {
            var cars = _carService.GetVehicleByAlphabetized();
            var carDtos = _mapper.Map<IEnumerable<Car>, IEnumerable<CarDTO>>(cars);
            return Ok(carDtos);
        }

        // GET: function to calculate ordered List of Vehicles by Price  // GetVehicleByPrice
        [HttpGet]
        [Route("GetVehicleByPrice")]
        public IActionResult GetVehicleByPrice()
        {
            var cars = _carService.GetVehicleByPrice();
            var carDtos = _mapper.Map<IEnumerable<Car>, IEnumerable<CarDTO>>(cars);
            return Ok(carDtos);
        }

        // GET: function to calculate the best value  // GetVehicleByBestValue
        [HttpGet]
        [Route("GetVehicleByBestValue")]
        public IActionResult GetVehicleByBestValue()
        {
            var car = _carService.GetVehicleByBestValue();
            var carDto = _mapper.Map<Car, CarDTO>(car);
            return Ok(carDto);
        }

        // GET: function to calculate full consumption for a given distance  //  GetConsumptionByDistance
        [HttpGet]
        [Route("GetConsumptionByDistance/{carId:int}/{distance:int}")]
        public IActionResult GetConsumptionByDistance(int carId, int distance)
        {
            return Ok(_carService.GetConsumptionByDistance(distance,new Car() { ID=carId }));
        }

        // GET: function to return a random car from the list  //  GetVehicleByRandom
        [HttpGet]
        [Route("GetVehicleByRandom")]
        public IActionResult GetVehicleByRandom()
        {
            var car = _carService.GetVehicleByRandom();
            var carDto = _mapper.Map<Car, CarDTO>(car);
            return Ok(carDto);
        }

        // GET:  A function to return average MPG by year  //  GetAverageMpgByYear
        [HttpGet]
        [Route("GetAverageMpgByYear/{year:int}")]
        public IActionResult GetAverageMpgByYear(int year)
        {
            return Ok(_carService.GetAverageMpgByYear(year));
        }
    }
}
