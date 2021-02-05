using FirstResponsiveWebAppBurton.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace FirstResponsiveWebAppBurton.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.Age = "";
            return View();
        }

        [HttpPost]
        public IActionResult Index(AgeCalculatorModel age)
        {
            if (ModelState.IsValid)
            {
                ViewBag.Age = age.AgeThisYear();
            }
            else
            {
                ViewBag.Age = "";
            }

            return View();
        }
    }
}

