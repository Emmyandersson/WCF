using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace CalcThreeNumbers
{
    /// <summary>
    /// Summary description for CalcThreeNums
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class CalcThreeNums : System.Web.Services.WebService
    {

        [WebMethod]
        public int CalcThree(int num1, int num2, int num3)
        {
            return num1 + num2 + num3;
        }
    }
}
