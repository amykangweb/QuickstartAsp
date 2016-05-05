using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using QuickstartAsp.Models;

namespace QuickstartAsp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var model = new GreetingModel
            {
                Greeting = "Welcome to the World of MVC",
                Name = "Your friendly neighborhood MVC App"
            };
            return View(model);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
