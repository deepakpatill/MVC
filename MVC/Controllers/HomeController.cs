using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC.Models;

namespace MVC.Controllers
{
    public class HomeController : Controller
    {
        public string Index()
        {
            return "Controller Demo";
        }

        public ActionResult ViewDemo()
        {
            ViewBag.Message = "View Demo";
            ViewBag.Countries = new List<string>()
            {
                "India",
                "US",
                "Germany"
            };

            return View();
        }

        public ActionResult ModelDemo()
        {
            ViewBag.Message = "Model Demo";
            Employee E = new Employee()
            {
                EmployeeId = 101,
                name = "ABC" 
            };


            return View(E);
        }
    }
}