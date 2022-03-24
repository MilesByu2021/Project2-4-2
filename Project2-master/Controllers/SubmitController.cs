using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Project2.Models;

namespace Project2.Controllers
{
    public class SubmitController : Controller
    {
        private IFormRepository repo { get; set; }

        private Basket basket { get; set; }

        public SubmitController(IFormRepository temp, Basket b)
        {
            repo = temp;
            basket = b;
        }

        [HttpGet]
        public IActionResult Submit()
        {
            return View("Index");
        }

        [HttpPost]
        public IActionResult Submit(Schedules s)
        {
            basket = new Basket();

            basket.AddItem(s);

            repo.SaveSchedule(s);

            return View("~/Views/ScheduleTable/ScheduleTable.cshtml", basket);
        }

    }
}
