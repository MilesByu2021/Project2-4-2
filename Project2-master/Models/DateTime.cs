using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Project2.Models
{
    public class DateTime
    {
        [Key]
        [Required]
        public int DateTimeId { get; set; }
        public string StartDate { get; set; }
        public string StartTime { get; set; }
    }
}
