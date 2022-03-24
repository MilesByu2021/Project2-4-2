using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Project2.Models;

namespace Project2.Controllers
{
    public class FormController : Controller
    {
        
        [HttpGet]
        public IActionResult Form()
        {
            return View("Form");
        }
        [HttpPost]
        public IActionResult Form(Schedules s)
        {
            return View("Form", s);
        }


    }
}
