using System;
using System.Linq;

namespace Project2.Models
{
    public class EFFormRepository : IFormRepository
    {
        public EFFormRepository()
        {
        }

        public IQueryable<Schedules> Schedules => throw new NotImplementedException();

        public void SaveSchedule(Schedules schedules)
        {
            throw new NotImplementedException();
        }
    }
}
