using System;
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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
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
        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Enabled = false;
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
        private bool CellNumberisValid()
        {
            if(isAllDigit(textBox10.Text) || textBox10.Text.Length != 9)
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
            if(textBox8.Text.Length < 4)
            {
                label21.Visible = true;
                textBox8.BackColor = Color.Red;
                textBox9.BackColor = Color.Red;
                return false;
            }
            if(textBox8.Text != textBox9.Text)
            {
                label20.Visible = true;
                textBox8.BackColor = Color.Red;
                textBox9.BackColor = Color.Red;
                return false;
            }
            return true;
        }
        private bool signUIsValid()
        {
            return NameIsValid() && AddrressIsValid() && CellNumberisValid() && EmailISValid() && PasswordIsValid();
        }

        private void Form10_Load(object sender, EventArgs e)
        {
            customerTableAdapter1.Fill(fullDatabase1.Customer);
        }
    }
}
