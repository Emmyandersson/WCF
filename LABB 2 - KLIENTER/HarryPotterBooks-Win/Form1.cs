using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HarryPotterBooks_Win.HarryPotterBooks;

namespace HarryPotterBooks_Win
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HarryPotterBooksSoapClient client = new HarryPotterBooksSoapClient();
            lblResult.Text = client.BookName(textBox1.Text);
        }
    }
}
