using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Klienten.WorstMaleActor;

namespace Klienten
{
    public partial class BadActors : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            MaleActorSoapClient client = new MaleActorSoapClient();
            lblResult.Text = client.GetAllBadActors(TextBox1.Text);
        }
    }
}