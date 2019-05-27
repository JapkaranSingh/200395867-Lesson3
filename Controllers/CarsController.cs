using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using _200395867_Lesson3.Models;
namespace _200395867_Lesson3.Controllers
{
    public class CarsController : Controller
    {
        List<Car> carList = new List<Car>()
        {
            new Car {Id = 1, Brand = "HONDA", Model = "300s", Type = "Luxury Sedan", Year = 2019 },
            new Car {Id = 2, Brand = "TOYOTA", Model = "Veloster", Type = "Hatchback", Year = 2013 },
            new Car {Id = 3, Brand = "DODGE", Model = "Charger", Type = "Sedan", Year = 2015 }
        };
        // GET: Cars
        public ActionResult Index()
        {
            return View(carList);
        }


        //GET: Cars/Details - Single car
        public ActionResult Details(int? id)
        {
            if (id == null || id > carList.Count)
        {
                return Content("Invalid car id");
            }
            var ind = Convert.ToInt32(id) - 1;
            var car = carList[ind];

            return View(car);
        }
    }
}