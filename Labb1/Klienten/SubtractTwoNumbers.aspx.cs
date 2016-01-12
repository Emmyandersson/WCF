using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Klienten.SubtractTwoNums;

namespace Klienten
{
    public partial class SubtractTwoNumbers : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubtract_Click(object sender, EventArgs e)
        {
            SubtractTwoNums.Subtract_2_NumsSoapClient sub = new Subtract_2_NumsSoapClient();
            lblResult.Text = sub.Subtractor(int.Parse(tbxNum1.Text), int.Parse(tbxNum2.Text)).ToString();
        }
    }
}