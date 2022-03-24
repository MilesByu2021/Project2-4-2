using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project2.Models
{
    public class ScheduleApplicationContext : DbContext
    {
        // Constructor
        public ScheduleApplicationContext (DbContextOptions<ScheduleApplicationContext> options) : base (options)
        {

        }
        public DbSet<Schedules> Schedule { get; set; }
    }
}
