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
        public Basket basket { get; set; }
        
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
            return RedirectToPage("/SchedukeTable");
        }
    }
}
