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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private bool IsLoginValid()
        {
            int count = 0;

            if (textBox1.Text.Length < 3)
            {
                ChangeColor(textBox1);
                count++;
            }
            if (textBox2.Text.Length < 3)
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
            if (textBox5.Text.Length < 8)
            {
                ChangeColor(textBox5);
                count++;
            }
            if (textBox7.Text.Length < 5)
            {
                ChangeColor(textBox7);
                count++;
            }
            if (count > 0)
            {
                return false;
            }
            return true;
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(IsLoginValid())
            {
                Form1 login = new Form1();
                this.Close();
                login.ShowDialog();
                login.Show();
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
    }
}
