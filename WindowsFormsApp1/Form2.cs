﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if(signUIsValid())
            {
                panel1.Enabled = false;
                customerTableAdapter1.Insert(capFirst(textBox7.Text), capFirst(textBox1.Text), capFirst(textBox2.Text), textBox12.Text, "0" + textBox10.Text, textBox8.Text, capFirst(textBox3.Text), capFirst(textBox4.Text), capFirst(textBox5.Text), textBox6.Text);
                button1.Enabled = false;
            }
            
        }
        private string capFirst(string s)
        {
            return (s[0] + "").ToUpper() + s.Substring(1).ToLower();
        }
        private bool isDigit(char ch)
        {
            if (ch >= '0' && ch <= '9')
                return true;
            return false;
        }
        private bool isAllDigit(string s)
        {
            for (int i = 0; i < s.Length; i++)
            {
                if (!isDigit(s[i]))
                    return false;
            }
            return true;
        }
        private bool isLetter(char c)
        {
            if (c >= 'a' && c <= 'z')
                return true;
            return false;
        }
        private bool isAllLetters(string s)
        {
            s = s.ToLower();
            for (int i = 0; i < s.Length; i++)
            {
                if (!isLetter(s[i]))
                    return false;
            }
            return true;
        }
        private bool NameIsValid()
        {
            int count = 0;
            if(!isAllLetters(textBox1.Text) || textBox1.Text.Length < 3)
            {
                textBox1.BackColor = Color.Red;
                count++;
            }
            if (!isAllLetters(textBox2.Text) || textBox2.Text.Length < 3)
            {
                textBox2.BackColor = Color.Red;
                count++;
            }
            return count == 0;
        }

        private bool AddrressIsValid()
        {
            if (!isAllDigit(textBox6.Text) || textBox6.Text.Length != 4)
            {
                textBox6.BackColor = Color.Red;
                return false;
            }
            return true;
        }
        private bool IdIsValid()
        {
            if(!isAllDigit(textBox12.Text) || textBox12.Text.Length != 13)
            {
                textBox12.BackColor = Color.Red;
                return false;
            }
            return true;
        }
        private bool CellNumberisValid()
        {
            if(!isAllDigit(textBox10.Text) || textBox10.Text.Length != 10)
            {
                textBox10.BackColor = Color.Red;
                return false;
            }
            return true;
        }
        private bool EmailISValid()
        {
            if (textBox7.Text != null)
            {
                EmailAddressAttribute email = new EmailAddressAttribute();
                if (!email.IsValid(textBox7.Text))
                {
                    textBox7.BackColor = Color.Red;
                    label22.Visible = true;
                    return false;
                }
                if(EmailIsRegistred())
                {
                    textBox7.BackColor = Color.Red;
                    label23.Visible = true;
                    return false;
                }
                return true;
            }
            textBox7.BackColor = Color.Red;
            return false;
        }
        private bool EmailIsRegistred()
        {
            for(int i = 0; i < fullDatabase1.Customer.Rows.Count; i++)
            {
                if (fullDatabase1.Customer[i].emailID == textBox7.Text)
                    return true;
            }
            return false;
        }
        private bool PasswordIsValid()
        {
            if (textBox8.Text != textBox9.Text)
            {
                label20.Visible = true;
                textBox8.BackColor = Color.Red;
                textBox9.BackColor = Color.Red;
                return false;
            }
            if (textBox8.Text.Length < 4)
            {
                label21.Visible = true;
                textBox8.BackColor = Color.Red;
                textBox9.BackColor = Color.Red;
                return false;
            }
            return true;
        }
        private bool signUIsValid()
        {
            int count = 0;
            if (!NameIsValid())
                count ++;
            if (!AddrressIsValid())
                count ++;
            if (!CellNumberisValid())
                count ++;
            if (!EmailISValid())
                count ++;
            if (!PasswordIsValid())
                count ++;
            if (IdIsValid())
                count ++;
            return count == 0;
        }

        private void Form10_Load(object sender, EventArgs e)
        {
            customerTableAdapter1.Fill(fullDatabase1.Customer);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.White;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.BackColor = Color.White;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            textBox3.BackColor = Color.White;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            textBox4.BackColor = Color.White;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            textBox5.BackColor = Color.White;
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            textBox6.BackColor = Color.White;
        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {
            textBox12.BackColor = Color.White;
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            textBox10.BackColor = Color.White;
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            textBox7.BackColor = Color.White;
            label23.Visible = false;
            label22.Visible = false;
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            textBox8.BackColor = Color.White;
            textBox9.BackColor = Color.White;
            label20.Visible = false;
            label21.Visible = false;
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if(textBox1.Text == "First name")
            {
                textBox1.Text = null;
                textBox1.ForeColor = Color.Black;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "First name";
                textBox1.ForeColor = Color.Gray;
            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == "Last name")
            {
                textBox2.Text = null;
                textBox2.ForeColor = Color.Black;
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.Text = "Last name";
                textBox2.ForeColor = Color.Gray;
            }
        }

        private void textBox3_Enter(object sender, EventArgs e)
        {
            if (textBox3.Text == "Street Address Line 1")
            {
                textBox3.Text = null;
                textBox3.ForeColor = Color.Black;
            }
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            if (textBox3.Text == "")
            {
                textBox3.Text = "Street Address Line 1";
                textBox3.ForeColor = Color.Gray;
            }
        }

        private void textBox4_Enter(object sender, EventArgs e)
        {
            if (textBox4.Text == "Street Address Line 2")
            {
                textBox4.Text = null;
                textBox4.ForeColor = Color.Black;
            }
        }

        private void textBox4_Leave(object sender, EventArgs e)
        {
            if (textBox4.Text == "")
            {
                textBox4.Text = "Street Address Line 2";
                textBox4.ForeColor = Color.Gray;
            }
        }

        private void textBox5_Enter(object sender, EventArgs e)
        {
            if (textBox5.Text == "City")
            {
                textBox5.Text = null;
                textBox5.ForeColor = Color.Black;
            }
        }

        private void textBox5_Leave(object sender, EventArgs e)
        {
            if (textBox5.Text == "")
            {
                textBox5.Text = "City";
                textBox5.ForeColor = Color.Gray;
            }
        }

        private void textBox6_Enter(object sender, EventArgs e)
        {
            if (textBox6.Text == "Postal code")
            {
                textBox6.Text = null;
                textBox6.ForeColor = Color.Black;
            }
        }

        private void textBox6_Leave(object sender, EventArgs e)
        {
            if (textBox6.Text == "")
            {
                textBox6.Text = "Postal code";
                textBox6.ForeColor = Color.Gray;
            }
        }

        private void textBox12_Enter(object sender, EventArgs e)
        {
            if (textBox12.Text == "ID number")
            {
                textBox12.Text = null;
                textBox12.ForeColor = Color.Black;
            }
        }

        private void textBox12_Leave(object sender, EventArgs e)
        {
            if (textBox12.Text == "")
            {
                textBox12.Text = "ID number";
                textBox12.ForeColor = Color.Gray;
            }
        }

        private void textBox10_Enter(object sender, EventArgs e)
        {
            if (textBox10.Text == "Cell number")
            {
                textBox10.Text = null;
                textBox10.ForeColor = Color.Black;
            }
        }

        private void textBox10_Leave(object sender, EventArgs e)
        {
            if (textBox10.Text == "")
            {
                textBox10.Text = "Cell number";
                textBox10.ForeColor = Color.Gray;
            }
        }

        private void textBox7_Enter(object sender, EventArgs e)
        {
            if (textBox7.Text == "Email")
            {
                textBox7.Text = null;
                textBox7.ForeColor = Color.Black;
            }
        }

        private void textBox7_Leave(object sender, EventArgs e)
        {
            if (textBox7.Text == "")
            {
                textBox7.Text = "Email";
                textBox7.ForeColor = Color.Gray;
            }
        }

        private void textBox8_Enter(object sender, EventArgs e)
        {
            if (textBox8.Text == "Enter password")
            {
                textBox8.Text = null;
                textBox8.ForeColor = Color.Black;
            }
        }

        private void textBox8_Leave(object sender, EventArgs e)
        {
            if (textBox8.Text == "")
            {
                textBox8.Text = "Enter password";
                textBox8.ForeColor = Color.Gray;
            }
        }

        private void textBox9_Enter(object sender, EventArgs e)
        {
            if (textBox9.Text == "Confirm password")
            {
                textBox9.Text = null;
                textBox9.ForeColor = Color.Black;
            }
        }

        private void textBox9_Leave(object sender, EventArgs e)
        {
            if (textBox9.Text == "")
            {
                textBox9.Text = "Confirm password";
                textBox9.ForeColor = Color.Gray;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
