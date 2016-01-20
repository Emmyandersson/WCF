using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WCF.HarryPotter
{
    /// <summary>
    /// Summary description for HarryPotterBooks
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class HarryPotterBooks : System.Web.Services.WebService
    {

        [WebMethod]
        public string BookName(string name)
        {
            var books = new List<string>() { "Harry Potter and the Philosophers Stone", "Harry Potter and the Chamber of Secrets", "Harry Potter and the Prisoner of Azkaban", "Harry Potter and the Goblet of Fire", "Harry Potter and the Order of the Phoenix", "Harry Potter and the Half Blood Prince", "Harry Potter and the Deathly Hallows" };
            foreach (var book in books)
            {
                if (book.ToLower().Contains(name.ToLower()))
                {
                    return book;
                }

            }
            return "No book contains that name.";
        }
    }
}
