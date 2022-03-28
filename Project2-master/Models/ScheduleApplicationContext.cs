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
            // Leave Blank
        }
        public DbSet<Schedules> Schedule { get; set; }
        public DbSet<DateTime> DateTime { get; set; }
        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<DateTime>().HasData(
                new DateTime
                {
                    DateTimeId = 1,
                    StartDate = "03/21/2022",
                    StartTime = "8 AM"
                },
                new DateTime
                {
                    DateTimeId = 2,
                    StartDate = "03/21/2022",
                    StartTime = "9 AM"
                },
                new DateTime
                {
                    DateTimeId = 3,
                    StartDate = "03/21/2022",
                    StartTime = "10 AM"
                },
                new DateTime
                {
                    DateTimeId = 4,
                    StartDate = "03/21/2022",
                    StartTime = "11 AM"
                },
                new DateTime
                {
                    DateTimeId = 5,
                    StartDate = "03/21/2022",
                    StartTime = "12 AM"
                },
                new DateTime
                {
                    DateTimeId = 6,
                    StartDate = "03/21/2022",
                    StartTime = "1 PM"
                },
                new DateTime
                {
                    DateTimeId = 7,
                    StartDate = "03/21/2022",
                    StartTime = "2 PM"
                },
                new DateTime
                {
                    DateTimeId = 8,
                    StartDate = "03/21/2022",
                    StartTime = "3 PM"
                },
                new DateTime
                {
                    DateTimeId = 9,
                    StartDate = "03/21/2022",
                    StartTime = "4 PM"
                },
                new DateTime
                {
                    DateTimeId = 10,
                    StartDate = "03/21/2022",
                    StartTime = "5 PM"
                },
                new DateTime
                {
                    DateTimeId = 11,
                    StartDate = "03/21/2022",
                    StartTime = "6 PM"
                },
                new DateTime
                {
                    DateTimeId = 12,
                    StartDate = "03/21/2022",
                    StartTime = "7 PM"
                },
                new DateTime
                {
                    DateTimeId = 13,
                    StartDate = "03/21/2022",
                    StartTime = "8 PM"
                },
                new DateTime
                {
                    DateTimeId = 14,
                    StartDate = "03/22/2022",
                    StartTime = "8 AM"
                },
                new DateTime
                {
                    DateTimeId = 15,
                    StartDate = "03/22/2022",
                    StartTime = "9 AM"
                },
                new DateTime
                {
                    DateTimeId = 16,
                    StartDate = "03/22/2022",
                    StartTime = "10 AM"
                },
                new DateTime
                {
                    DateTimeId = 17,
                    StartDate = "03/22/2022",
                    StartTime = "11 AM"
                },
                new DateTime
                {
                    DateTimeId = 18,
                    StartDate = "03/22/2022",
                    StartTime = "12 AM"
                },
                new DateTime
                {
                    DateTimeId = 19,
                    StartDate = "03/22/2022",
                    StartTime = "1 PM"
                },
                new DateTime
                {
                    DateTimeId = 20,
                    StartDate = "03/22/2022",
                    StartTime = "2 PM"
                },
                new DateTime
                {
                    DateTimeId = 21,
                    StartDate = "03/22/2022",
                    StartTime = "3 PM"
                },
                new DateTime
                {
                    DateTimeId = 22,
                    StartDate = "03/22/2022",
                    StartTime = "4 PM"
                },
                new DateTime
                {
                    DateTimeId = 23,
                    StartDate = "03/22/2022",
                    StartTime = "5 PM"
                },
                new DateTime
                {
                    DateTimeId = 24,
                    StartDate = "03/22/2022",
                    StartTime = "6 PM"
                },
                new DateTime
                {
                    DateTimeId = 25,
                    StartDate = "03/22/2022",
                    StartTime = "7 PM"
                },
                new DateTime
                {
                    DateTimeId = 26,
                    StartDate = "03/22/2022",
                    StartTime = "8 PM"
                },
                new DateTime
                {
                    DateTimeId = 27,
                    StartDate = "03/23/2022",
                    StartTime = "8 AM"
                },
                new DateTime
                {
                    DateTimeId = 28,
                    StartDate = "03/23/2022",
                    StartTime = "9 AM"
                },
                new DateTime
                {
                    DateTimeId = 29,
                    StartDate = "03/23/2022",
                    StartTime = "10 AM"
                },
                new DateTime
                {
                    DateTimeId = 30,
                    StartDate = "03/23/2022",
                    StartTime = "11 AM"
                },
                new DateTime
                {
                    DateTimeId = 31,
                    StartDate = "03/23/2022",
                    StartTime = "12 AM"
                },
                new DateTime
                {
                    DateTimeId = 32,
                    StartDate = "03/23/2022",
                    StartTime = "1 PM"
                },
                new DateTime
                {
                    DateTimeId = 33,
                    StartDate = "03/23/2022",
                    StartTime = "2 PM"
                },
                new DateTime
                {
                    DateTimeId = 34,
                    StartDate = "03/23/2022",
                    StartTime = "3 PM"
                },
                new DateTime
                {
                    DateTimeId = 35,
                    StartDate = "03/23/2022",
                    StartTime = "4 PM"
                },
                new DateTime
                {
                    DateTimeId = 36,
                    StartDate = "03/23/2022",
                    StartTime = "5 PM"
                },
                new DateTime
                {
                    DateTimeId = 37,
                    StartDate = "03/23/2022",
                    StartTime = "6 PM"
                },
                new DateTime
                {
                    DateTimeId = 38,
                    StartDate = "03/23/2022",
                    StartTime = "7 PM"
                },
                new DateTime
                {
                    DateTimeId = 39,
                    StartDate = "03/23/2022",
                    StartTime = "8 PM"
                }
            );
            mb.Entity<Schedules>().HasData(
                new Schedules
                {
                    ScheduleId = 1,
                    GroupName = "Sheng Lei",
                    GroupSize = 4,
                    GroupEmail = "123@gmail.com",
                    GroupPhone = "123-123-1234",
                    DateTimeId = 1,
                }
            );

        }
    }
}
