using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using CarDealership.Models;
using System.Globalization;

namespace CarDealership.Controllers
{
    public class HomeController : Controller
    {
      [HttpGet("/")]
      public ActionResult IndexGet()
      {
        return View();
      }
      [HttpGet("/form")]
      public ActionResult CreateCar()
      {
        return View();
      }

      [HttpPost("/CreateNew")]
      public ActionResult CreateNew()
      {
        string makeModel = Request.Form["make-model"];
        string color = Request.Form["color"];
        int year = int.Parse(Request.Form["year"]);
        int mileage = int.Parse(Request.Form["mileage"]);
        // float price = float.Parse(Request.Form["make-model"],  CultureInfo.InvariantCulture);
        Car newCar = new Car(makeModel, color, year, mileage);
        Car.Save(newCar);
        return View(newCar);
      }

    }
}
