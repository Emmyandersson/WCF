using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NextThousand__Win.ThousandDays;

namespace NextThousand__Win
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CalculatorSoapClient client = new CalculatorSoapClient();
            lblResult.Text = "Du fyller 1000 dagar igen den " +client.NextThousandDays(DateTime.Parse(textBox1.Text)).ToString();
        }
    }
}
