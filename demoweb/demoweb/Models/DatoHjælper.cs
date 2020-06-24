using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace demoweb.Models
{
    public class DatoHjælper
    {
        public DateTime FindDag() {
            if (DateTime.Now.Date.DayOfWeek == DayOfWeek.Saturday)
                return DateTime.Now.AddDays(2);
            if (DateTime.Now.Date.DayOfWeek == DayOfWeek.Sunday)
                return DateTime.Now.AddDays(1);
            return DateTime.Now.Date;
        }
    }
}
