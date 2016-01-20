using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WCF.NextThousand
{
    /// <summary>
    /// Summary description for Calculator
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class Calculator : System.Web.Services.WebService
    {

        [WebMethod]
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
