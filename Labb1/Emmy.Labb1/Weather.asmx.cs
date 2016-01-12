using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace Emmy.Labb1
{
    /// <summary>
    /// Summary description for Weather
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class Weather : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        readonly string[] _weathers = { "Soligt", "Regn", "Blåsigt", "Snö", "Storm", "Åska" };

        [WebMethod]
        public string WeatherForecast()
        {
            var random = new Random();
           return _weathers[random.Next(0,6)];
        }
    }
}
