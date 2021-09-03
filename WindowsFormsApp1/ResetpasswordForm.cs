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
    public partial class ResetpasswordForm : Form
    {
        private string otp;
        private int check = 0;
        private string firstName;
        public ResetpasswordForm()
        {
            InitializeComponent();
            customerTableAdapter1.Fill(fullDatabase1.Customer);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            this.Hide();
            login.ShowDialog();
            this.Close();
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == "Email or Phone")
            {
                textBox2.Text = null;
                textBox2.ForeColor = Color.Black;
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.Text = "Email or Phone";
                textBox2.ForeColor = Color.Gray;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != null)
            {
                if (userExist())
                {
                    for (int i = 0; i < fullDatabase1.Customer.Rows.Count; i++)
                    {
                        if (fullDatabase1.Customer[i].emailID.Equals(textBox2.Text, StringComparison.OrdinalIgnoreCase))
                        {
                            this.firstName = fullDatabase1.Customer[i].name;
                            panel1.Visible = false;
                            panel6.Visible = true;
                            string temp = randomOTP();
                            Email.sendEmail(textBox2.Text, "Reset password OTP confirmation", htmlOTP(temp));
                            break;
                        }
                    }
                }
                else
                    label10.Visible = true;
            }
            else
            {
                label12.Visible = true;
            }
            
        }
        private bool userExist()
        {
            for (int i = 0; i < fullDatabase1.Customer.Rows.Count; i++)
            {
                if (fullDatabase1.Customer[i].emailID.Equals(textBox2.Text, StringComparison.OrdinalIgnoreCase) || textBox2.Text.Equals(fullDatabase1.Customer[i].cellNumber))
                {
                    return true;
                }
            }
            return false;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            label10.Visible = false;
            label12.Visible = false;
        }

        private void textBox3_Enter(object sender, EventArgs e)
        {
            if (textBox3.Text == "Enter password")
            {
                textBox3.Text = null;
                textBox3.UseSystemPasswordChar = true;
                textBox3.ForeColor = Color.Black;
            }
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            if (textBox3.Text == "")
            {
                textBox3.Text = "Enter password";
                textBox3.ForeColor = Color.Gray;
                textBox3.UseSystemPasswordChar = false;
            }
        }

        private void textBox4_Enter(object sender, EventArgs e)
        {
            if (textBox4.Text == "Confirm password")
            {
                textBox4.Text = null;
                textBox4.UseSystemPasswordChar = true;
                textBox4.ForeColor = Color.Black;
            }
        }

        private void textBox4_Leave(object sender, EventArgs e)
        {
            if (textBox4.Text == "")
            {
                textBox4.Text = "Confirm password";
                textBox4.UseSystemPasswordChar = false;
                textBox4.ForeColor = Color.Gray;
            }
        }
        private bool PasswordIsValid()
        {
            if (textBox3.Text != textBox4.Text)
            {
                label9.Visible = true;
                return false;
            }
            if (textBox3.Text.Length < 8)
            {
                label21.Visible = true;
                return false;
            }
            return true;
        }
        private void button6_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < fullDatabase1.Customer.Rows.Count; i++)
            {
                if (fullDatabase1.Customer[i].emailID.Equals(textBox2.Text, StringComparison.OrdinalIgnoreCase) || textBox2.Text.Equals(fullDatabase1.Customer[i].cellNumber))
                {
                    if(PasswordIsValid())
                    {
                        fullDatabase1.Customer[i].password = textBox3.Text;
                        customerTableAdapter1.Update(fullDatabase1);
                        panel3.Visible = true;
                        panel2.Visible = false;
                    }
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            this.Hide();
            login.ShowDialog();
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            this.Hide();
            login.ShowDialog();
            this.Close();
        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
            LoginForm login = new LoginForm();
            login.ShowDialog();
        }
        private void button9_Click_1(object sender, EventArgs e)
        {
            if(textBox3.Text != "Enter password")
                textBox3.UseSystemPasswordChar = true;
            button12.Visible = true;
            button9.Visible = false;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (textBox3.Text != "Enter password")
                textBox3.UseSystemPasswordChar = false;
            button12.Visible = false;
            button9.Visible = true;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (textBox4.Text != "Confirm password")
                textBox4.UseSystemPasswordChar = true;
            button10.Visible = false;
            button11.Visible = true;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (textBox4.Text != "Confirm password")
                textBox4.UseSystemPasswordChar = false;
            button10.Visible = true;
            button11.Visible = false;
        }

        private void textBox1_MouseEnter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Enter OTP")
            {
                textBox1.Text = null;
                textBox1.ForeColor = Color.Black;
            }
        }

        private void textBox1_MouseLeave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "Enter OTP";
                textBox1.ForeColor = Color.Gray;
            }
        }
        private string htmlOTP(string temp)
        {
            string body = @"<html>
                           <body>";
            body += "<p>Dear " + firstName + "</p><p>There was a request to change your password!<br>If you did not make this request then please ignore this email</p>";
            body += "<p> Otherwise, please use the One Time Pin(OTP) below to change your password<br>";
            body += "Here's your One Time Pin(OTP) : " + temp + "</p>";
            body += "<p>This is an autogenerated email, for enquiries<br>call: +27 64 090 3388<br>Or email: sonya@TheCottageBnB.co.za</p>";
            body += " </body></html>";
            return body;
        }
        private void button13_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == this.otp)
            {
                panel6.Visible = false;
                panel2.Visible = true;
            }
            else
            {
                label18.Visible = true;
                check++;
                if (check > 1)
                    button3.Visible = true;
            }
        }
        public string randomOTP()
        {
            Random r = new Random();
            int randNum = r.Next(1000000);
            string temp = randNum.ToString("D6");
            otp = temp;
            string random = null;
            for (int i = 0; i < 6; i++)
                random += temp[i] + " ";
            return random;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            label18.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string temp = randomOTP();
            Email.sendEmail(textBox2.Text, "Reset password OTP confirmation", htmlOTP(temp));
        }

        private void textBox2_MouseEnter_1(object sender, EventArgs e)
        {
            if (textBox2.Text == "Email")
            {
                textBox2.Text = null;
                textBox2.ForeColor = Color.Black;
            }
        }

        private void textBox2_MouseLeave_1(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.Text = "Email";
                textBox2.ForeColor = Color.Gray;
            }
        }
    }

}
