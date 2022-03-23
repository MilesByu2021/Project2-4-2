using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Project2.Models;

namespace Project2.Pages
{
    public class SignUpModel : PageModel
    {
        private Schedules repo { get; set; }
          
        
        public void OnGet()
        {
        }
    }
}
