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
        private string OTP;
        public OTPForm()
        {
            InitializeComponent();
            this.OTP = randomOTP().Trim();
            //label2.Text += currentUser.getEmailID();
            label2.Text += OTP;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private string randomOTP()
        {
            Random r = new Random();
            int randNum = r.Next(1000000);
            string temp = randNum.ToString("D6");
            string random = null;

            for(int i = 0; i < 6; i ++)
                random += temp[i] + " ";

            return random;
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

        private void button3_Click(object sender, EventArgs e)
        {
            LoginForm l = new LoginForm();
            this.Hide();
            l.ShowDialog();
            this.Close();
        }
    }
}
