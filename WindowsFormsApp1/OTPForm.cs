using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class OTPForm : Form
    {
        public OTPForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_MouseEnter_1(object sender, EventArgs e)
        {
            if (textBox1.Text == "Enter OTP")
            {
                textBox1.Text = null;
                textBox1.ForeColor = Color.Black;
            }
        }

        private void textBox1_MouseLeave_1(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "Enter OTP";
                textBox1.ForeColor = Color.Gray;
            }
        }
    }
}
