using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfService.MyAge
{
    public class AgeCheckerService : IAge
    {
        public string HowOldAmI(DateTime birthDay)
        {
            int age = 0;
            age = DateTime.Now.Year - birthDay.Year;
            if (DateTime.Now.DayOfYear < birthDay.DayOfYear)
                age -= 1;

            return age.ToString();
        }
    }
}

