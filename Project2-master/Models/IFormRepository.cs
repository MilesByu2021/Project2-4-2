using System;
using System.Linq;

namespace Project2.Models
{
    public interface IFormRepository
    {
        public IQueryable<Schedules> Schedules { get; }

        public void SaveSchedule(Schedules schedules);
    }
}
