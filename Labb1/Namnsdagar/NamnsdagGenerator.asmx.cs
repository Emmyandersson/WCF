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
        Dictionary<string, string> nameDaysDict = new Dictionary<string, string>();

    
        [WebMethod]
        public void NameDays()
        {
            
            using (var sr = new StreamReader(@"C:\Users\Emmy\Documents\Visual Studio 2015\Projects\WCF\WCF\LABB1\Namnsdagar\namnsdagar.txt"))
            {
                while (sr.Peek() >= 0)
                {
                    var line = sr.ReadLine();
                    if (line != null)
                    {
                        var splitLine = line.Split(new string[] {"\t", ",", "\n"}, StringSplitOptions.RemoveEmptyEntries);

                        if (splitLine.Length == 2)
                        {
                            nameDaysDict.Add(splitLine[1].ToLower(), (splitLine[0]));
                        }
                        if (splitLine.Length == 3)
                        {
                            nameDaysDict.Add(splitLine[1].ToLower(), splitLine[0]);
                            nameDaysDict.Add(splitLine[2].ToLower(), splitLine[0]);
                        }
                        if (splitLine.Length == 4)
                        {
                            nameDaysDict.Add(splitLine[1].ToLower(), splitLine[0]);
                            nameDaysDict.Add(splitLine[2].ToLower(), splitLine[0]);
                            nameDaysDict.Add(splitLine[3].ToLower(), splitLine[0]);
                        }                                                        
                    }
                }                                                                   
                
            }

        }

        [WebMethod]
        public string NameDayDateReturner(string inputName)
        {
            NameDays();
            return nameDaysDict.ContainsKey(inputName.ToLower()) ? nameDaysDict[inputName.ToLower()] : "Namnet du angav har ingen namnsdag! ";
        }



    }
}
