using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Project2.Models;
using DateTime = Project2.Models.DateTime;

namespace Project2.Controllers
{
    public class FormController : Controller
    {
        
        [HttpGet]
        public IActionResult Form()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Form(DateTime dt)
        {
            ViewBag.DateTime = dt.DateTimeId;
            return View();
        }


    }
}
