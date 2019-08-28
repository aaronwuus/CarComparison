using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using CarComparison.IService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CarComparison.App.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICarService _carService;
        private readonly IMapper _mapper;
        public HomeController(ICarService carService, IMapper mapper)
        {
            _carService = carService;
            _mapper = mapper;
    }
        // GET: Home
        public ActionResult Index()
        {

            var cars = _carService.GetAllCars();
            var items = new List<SelectListItem>();
            var years = new List<SelectListItem>();
            foreach (var car in cars)
            {
                items.Add(
                new SelectListItem()
                {
                    Value = car.ID.ToString(),
                    Text = car.Model
                });
                if (!years.Any(y=>y.Value==car.Year.ToString()))
                {
                    years.Add(new SelectListItem()
                    {
                        Value = car.Year.ToString(),
                        Text = car.Year.ToString()
                    });
                }
            }
            
            ViewBag.items = items;
            ViewBag.years = years;
            return View(cars);
        }
    }
}