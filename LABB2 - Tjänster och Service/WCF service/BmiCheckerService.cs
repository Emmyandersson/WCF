﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WCF_service
{
    public class BmiCheckerService : IBmi
    {
        public string Calculate(int height, int weight)
        {
            return (weight/(height*height)).ToString();
        }
    }
}
