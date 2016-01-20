using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WCF.MyAge
{
    /// <summary>
    /// Summary description for MyAgeCalculator
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class MyAgeCalculator : System.Web.Services.WebService
    {

        [WebMethod]
        public string CalculateAge(DateTime birthDay)
        {
            int age = 0;
            age = DateTime.Now.Year - birthDay.Year;
            if (DateTime.Now.DayOfYear < birthDay.DayOfYear)
                age -= 1;

            return age.ToString();
        }
    }
}
