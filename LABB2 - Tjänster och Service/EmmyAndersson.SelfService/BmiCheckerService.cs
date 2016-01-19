using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmmyAndersson.SelfService
{
    public class BmiCheckerService : IBmi
    {
        public string Calculate(double height, double weight)
        {
            return (weight/(height*height)).ToString();
        }

       
    }
}
