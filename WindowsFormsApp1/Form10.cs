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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
            customerTableAdapter1.Fill(fullDatabase1.Customer);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Form1 login = new Form1();
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
                        if (fullDatabase1.Customer[i].emailID.Equals(textBox2.Text, StringComparison.OrdinalIgnoreCase) || textBox2.Text.Equals(fullDatabase1.Customer[i].cellNumber))
                        {
                            panel1.Visible = false;
                            panel2.Visible = true;
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
            Form1 login = new Form1();
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
            Form1 login = new Form1();
            this.Hide();
            login.ShowDialog();
            this.Close();
        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            Form1 login = new Form1();
            this.Hide();
            login.ShowDialog();
            this.Close();
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
    }
}
