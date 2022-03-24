using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Project2.Models
{
    public class Basket
    {
        public List<BasketLineItem> Items { get; set; } = new List<BasketLineItem>();

        public virtual void AddItem(Schedules schedule)
        {
            BasketLineItem line = Items
                .Where(s => s.Schedule.ScheduleId == schedule.ScheduleId)
                .FirstOrDefault();
            if (line == null)
            {
                Items.Add(new BasketLineItem
                {
                    Schedule = schedule
                });
            }
            
        }
    }
    
    public class BasketLineItem
    {
        [Key]
        [Required]
        public int BasketLineItemId { get; set; }
        public Schedules Schedule { get; set; }
    }
}
