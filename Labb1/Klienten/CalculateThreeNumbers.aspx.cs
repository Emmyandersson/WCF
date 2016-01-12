using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Klienten.Calc3Nums;

namespace Klienten
{
    public partial class CalculateThreeNumbers : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSumOfThree_Click(object sender, EventArgs e)
        {
            Calc3Nums.CalcThreeNumsSoapClient calc = new CalcThreeNumsSoapClient();
             lblResult.Text = calc.CalcThree(int.Parse(num1Tbx.Text), int.Parse(tbxNum2.Text), int.Parse(tbxNum3.Text)).ToString();
        }
    }
}