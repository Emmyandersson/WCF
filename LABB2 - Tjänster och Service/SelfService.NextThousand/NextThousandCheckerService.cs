using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfService.NextThousand
{
    class NextThousandCheckerService : INextThousand
    {
        public DateTime NextThousandDays(DateTime birthDay)
        {
            var span = DateTime.Now.Subtract(birthDay);
            int daysOld = span.Days;
            var moduloresult = daysOld % 1000;
            var daysLeft = 1000 - moduloresult;
            return DateTime.Now.AddDays(daysLeft);
        }
    }
}
