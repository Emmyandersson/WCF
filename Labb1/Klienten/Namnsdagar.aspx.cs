using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Klienten.Namesdagar;

namespace Klienten
{
    public partial class Namnsdagar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            var nameDay = new NamnsdagGeneratorSoapClient();
            lblResult.Text = nameDay.NameDayDateReturner(TextBox1.Text);

        }
    }
}