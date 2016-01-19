using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WorstMaleCharacter
{
    /// <summary>
    /// Summary description for MaleActor
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class MaleActor : System.Web.Services.WebService
    {
        private Dictionary<string, string> _worstActorDict;

        public MaleActor()
        {
            _worstActorDict = new Dictionary<string, string>();
            AddAllBadActors();
        }
        [WebMethod]
        public void AddAllBadActors()
        {
            using (var sr = new StreamReader(@"C:\Users\Emmy\Documents\Visual Studio 2015\Projects\WCF\WCF\Labb1\WorstMaleCharacter\worstActor.txt"))
            {
                while (sr.Peek() >= 0)
                {
                    var line = sr.ReadLine();
                     var splitLine = line?.Split(new []{"\t", "\n"},StringSplitOptions.RemoveEmptyEntries);
                    
                }
            }
        }
    }
}
