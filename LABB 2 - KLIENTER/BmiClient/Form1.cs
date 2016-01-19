using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BmiClient.BmiCalc;


namespace BmiClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
       {
            BmiCalculatorSoapClient bmi = new BmiCalculatorSoapClient();
            lblResult.Text = "Ditt bmi är: " + bmi.Calculator(double.Parse(tbxHeight.Text), double.Parse(tbxKg.Text)).ToString(CultureInfo.CurrentCulture);
        }
    }
}
