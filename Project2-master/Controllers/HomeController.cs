using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Project2.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Project2.Controllers
{
    public class HomeController : Controller
    {
        private ScheduleApplicationContext blahContext { get; set; }
        public HomeController(ScheduleApplicationContext some)
        {
            blahContext = some;
        }
        
        
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult SignUp()
        {
            var schedules = blahContext.Schedule.ToList();
            var datetime = blahContext.DateTime.ToList();
            foreach (Schedules s in schedules)
            {
                datetime = datetime.Where(x => x.DateTimeId != s.DateTimeId).ToList();
            }
            ViewBag.DateTime = datetime;
            return View();
        }

    }
}
