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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            customerTableAdapter.Fill(fullDatabase.Customer);
        }
        private bool IsLoginValid()
        {
            int count = 0;

            if (textBox1.Text.Length < 3 || !isAllLetters(textBox1.Text))
            {
                ChangeColor(textBox1);
                count++;
            }
            if (textBox2.Text.Length < 3 || !isAllLetters(textBox2.Text))
            {
                ChangeColor(textBox2);
                count++;
            }
            if (textBox3.Text.Length != 13 || !isAllDigit(textBox3))
            {
                ChangeColor(textBox3);
                count++;
            }
            if (textBox4.Text.Length != 10 || !isAllDigit(textBox4))
            {
                ChangeColor(textBox4);
                count++;
            }
            if (!IsValidMailAddress(textBox5.Text))
            {
                label16.Visible = true;
                ChangeColor(textBox5);
                count++;
            }
            if (textBox7.Text.Length < 5 )
            {
                ChangeColor(textBox7);
                count++;
            }
            if(textBox10.Text.Length != 4 || !isAllDigit(textBox10))
            {
                ChangeColor(textBox10);
                count++;
            }
            if (count > 0)
            {
                return false;
            }
            return true;
        }
        private bool RecordsAlreadyExists()
        {
            if (textBox5.Text.Length < 8)
                return false;
            DataRow foundRow = fullDatabase.Tables["Customer"].Rows.Find(textBox5.Text.ToLower());
            if (foundRow != null)
            {
                label13.Visible = true;
                return true;
            }
            return false;
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(!RecordsAlreadyExists() && IsLoginValid())
            {
                
                customerTableAdapter.Insert(textBox5.Text.ToLower(), capFirst(textBox1.Text), capFirst(textBox2.Text), textBox3.Text, textBox4.Text, textBox7.Text, capFirst(textBox8.Text), capFirst(textBox6.Text), capFirst(textBox9.Text), textBox10.Text);
                panel1.Enabled = false;
                panel2.Enabled = false;
                panel3.Enabled = false;
                panel4.Visible= true;
                customerTableAdapter.Fill(fullDatabase.Customer);
            }
            else if (RecordsAlreadyExists())
            {
                button3.Visible = true;
                label13.Visible = true;
            }
        }
        private void ChangeColor(TextBox textBox)
        {
            textBox.BackColor = Color.Red;
        }
        private bool isDigit(char ch)
        {
            if (ch >= '0' && ch <= '9')
                return true;
            return false;
        }
        private bool isAllDigit(TextBox textbox)
        {
            string s = textbox.Text.ToString();
            for(int i = 0; i < s.Length; i++)
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
            for(int i = 0; i < s.Length; i++)
            {
                if (!isLetter(s[i]))
                    return false;
            }
            return true;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            currentUser.setEmailID(textBox5.Text);
            Form8 homePage = new Form8();
            this.Hide();
            homePage.ShowDialog();
            this.Close();
        }
        private string capFirst(string s)
        {
            return (s[0] + "").ToUpper() + s.Substring(1).ToLower();
        }
        public  bool IsValidMailAddress(string s)
        {
            if (s != null)
            {
                EmailAddressAttribute email = new EmailAddressAttribute();
                return email.IsValid(s);
            }
            return false;
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
            label16.Visible = false;
            button3.Visible = false;
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            textBox7.BackColor = Color.White;
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            textBox8.BackColor = Color.White;
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }
    }
}
