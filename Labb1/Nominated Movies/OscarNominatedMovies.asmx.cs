using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace Nominated_Movies
{
    /// <summary>
    /// Summary description for OscarNominatedMovies
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class OscarNominatedMovies : System.Web.Services.WebService
    {
        Dictionary<string, string> _movieDictionary;

        public OscarNominatedMovies()
        {
            _movieDictionary = new Dictionary<string, string>();
            Movies();
        }

        [WebMethod]
        public void Movies()
        {
            using (var sr = new StreamReader(@"C:\Users\Emmy\Documents\Visual Studio 2015\Projects\WCF\WCF\Labb1\Nominated Movies\animerad film.txt"))
            {
                while (sr.Peek() >= 0)
                {
                    var line = sr.ReadLine();
                    var splitLine = line?.Split(new[] { ":", "\n" }, StringSplitOptions.RemoveEmptyEntries);

                    if (splitLine?.Length == 2 )
                    _movieDictionary.Add(splitLine[0], splitLine[1]);
                    
                } 
            }
        }

        [WebMethod]
        public string GetAllWinningMovies(string year)
        {
            return _movieDictionary.ContainsKey(year) ? _movieDictionary[year] : "Finns ingen film som vann detta år";
        }
    }
}
