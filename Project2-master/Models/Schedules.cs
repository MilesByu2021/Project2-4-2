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
        public string GroupName { get; set; }
        public int GroupSize { get; set; }
        public string GroupEmail { get; set; }
        public string GroupPhone { get; set; }
        public string StartDate { get; set; }
        public string StartTime { get; set; }
    }
}
