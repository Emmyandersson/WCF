using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace Namnsdagar
{
    /// <summary>
    /// Summary description for NamnsdagGenerator
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class NamnsdagGenerator : System.Web.Services.WebService
    {

        [WebMethod]
        public string NameDays(string name)
        {
            var nameDaysDict = new Dictionary<string, DateTime>();
            using (var sr = new StreamReader("../namnsdagar.txt"))
            {
                while (sr.Peek() >= 0)
                {
                    var line = sr.ReadLine();
                    if (line != null)
                    {
                        var splitLine = line.Split(new string[] { "  ", ",", "\n" }, StringSplitOptions.RemoveEmptyEntries);

                        if (splitLine.Length == 2)
                        {
                            nameDaysDict.Add(splitLine[1], DateTime.Parse(splitLine[0]));
                        }
                        if (splitLine.Length == 3)
                        {
                            nameDaysDict.Add(splitLine[1], DateTime.Parse(splitLine[0]));
                            nameDaysDict.Add(splitLine[2], DateTime.Parse(splitLine[0]));
                        }
                        if (splitLine.Length != 4) continue;
                        nameDaysDict.Add(splitLine[1], DateTime.Parse(splitLine[0]));
                        nameDaysDict.Add(splitLine[2], DateTime.Parse(splitLine[0]));
                        nameDaysDict.Add(splitLine[3], DateTime.Parse(splitLine[0]));
                    }
                  

                }

            }

        }


    }
}
