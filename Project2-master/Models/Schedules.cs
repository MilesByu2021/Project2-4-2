using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Project2.Models
{
    public class Schedules
    {
        [Key]
        [Required]
        public int ScheduleId { get; set; }
        [Required]
        public string GroupName { get; set; }
        [Required]
        public int GroupSize { get; set; }
        [Required]
        public string GroupEmail { get; set; }
       
        public string? GroupPhone { get; set; }
        // Foreign Key
        public int DateTimeId { get; set; }
        public DateTime DateTime { get; set; }
    }
}
