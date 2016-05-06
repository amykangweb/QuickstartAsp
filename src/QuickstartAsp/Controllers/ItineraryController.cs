using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using QuickstartAsp.Models;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace QuickstartAsp.Controllers
{
    public class ItineraryController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            var model = new ItineraryItem();
            return View();
        }

        [HttpPost]
        public ActionResult Create(ItineraryItem data)
        {
            if (ModelState.IsValid)
            {
                // Handle saving the data only if
                // the model state is valid
            }
            else
            {
                ModelState.AddModelError("", "The data you entered was not valid");
            }
            return View();
        }
    }
}
