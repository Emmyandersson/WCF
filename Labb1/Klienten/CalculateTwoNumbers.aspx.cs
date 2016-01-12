using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Klienten.Calc2Nums;

namespace Klienten
{
    public partial class CalculateTwoNumbers : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void CalculateButton_Click(object sender, EventArgs e)
        {
            Calc2Nums.CalculatorSoapClient calc = new CalculatorSoapClient();
            SumLbl.Text = calc.Calc(int.Parse(Num1Tbx.Text), int.Parse(Num2Tbx.Text)).ToString();
        }
    }
}