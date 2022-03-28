using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Project2.Models;
using Microsoft.EntityFrameworkCore;

namespace Project2.Controllers
{
    public class SubmitController : Controller
    {
        private ScheduleApplicationContext scheduleContext { get; set; }
        public SubmitController(ScheduleApplicationContext some)
        {
            scheduleContext = some;
        }
        //private IFormRepository repo { get; set; }

        //private Basket basket { get; set; }

        //public SubmitController(IFormRepository temp, Basket b)
        //{
        //    repo = temp;
        //    basket = b;
        //}

        [HttpGet]
        public IActionResult Submit()
        {
            return View("Index");
        }

        [HttpPost]
        public IActionResult Submit(Schedules s)
        {
            scheduleContext.Add(s);
            scheduleContext.SaveChanges();
            //basket = new Basket();

            //basket.AddItem(s);

            //repo.SaveSchedule(s);

            return View("~/Views/Home/Index.cshtml");
        }

        [HttpGet]
        public IActionResult ScheduleList ()
        {
            var applications = scheduleContext.Schedule
                .Include(x => x.DateTime)
                .ToList();
            return View("~/Views/ScheduleTable/ScheduleTable.cshtml", applications);
        }
        [HttpGet]
        public IActionResult Edit(int scheduleid)
        {
            var applications = scheduleContext.Schedule.ToList();

            var application = applications.Single(x => x.ScheduleId == scheduleid);


            return View("~/Views/Form/EditForm.cshtml", application);
        }
        [HttpPost]
        public IActionResult Edit (Schedules blah)
        {
            scheduleContext.Update(blah);
            scheduleContext.SaveChanges();

            return RedirectToAction("ScheduleList");
        }
        
        public IActionResult Delete(int scheduleid)
        {
            var application = scheduleContext.Schedule.Single(x => x.ScheduleId == scheduleid);
            scheduleContext.Schedule.Remove(application);
            scheduleContext.SaveChanges();

            return RedirectToAction("ScheduleList");
        }


    }
}
