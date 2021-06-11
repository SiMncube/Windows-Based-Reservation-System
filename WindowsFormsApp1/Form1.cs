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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            customerTableAdapter1.Fill(fullDatabase1.Customer);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            adminForm a = new adminForm();
            this.Hide();
            a.ShowDialog();
            this.Close();
            if (LoginIsValid())
            {
                Form8 homePage = new Form8();
                this.Hide();
                homePage.ShowDialog();
                this.Close();
            }
        }
        private bool userNameIsCorrect()
        {
            for (int i = 0; i < fullDatabase1.Customer.Rows.Count; i++)
            {
                if(fullDatabase1.Customer[i].emailID.Equals(textBox1.Text, StringComparison.OrdinalIgnoreCase))
                {
                    currentUser.setEmailID(fullDatabase1.Customer[i].emailID);
                    return true;
                }
            }
            label8.Visible = true;
            return false;
        }
        private bool passwordIsCorrect()
        {
            for (int i = 0; i < fullDatabase1.Customer.Rows.Count; i++)
            {
                if(fullDatabase1.Customer[i].password == textBox2.Text && fullDatabase1.Customer[i].emailID.Equals(textBox1.Text, StringComparison.OrdinalIgnoreCase))
                    return true;
            }
            if (userNameIsCorrect())
                label9.Visible = true;
            return false;
        }
        private bool LoginIsValid()
        {
            return userNameIsCorrect() && passwordIsCorrect();
        }
        private void Form10_Load(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            label8.Visible = false;
            label9.Visible = false;
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            label9.Visible = false;
            label8.Visible = false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Form2 signup = new Form2();
            this.Hide();
            signup.ShowDialog();
            this.Close();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            textBox2.UseSystemPasswordChar = false;
            button4.Visible = true;
            button5.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox2.UseSystemPasswordChar = true;
            button5.Visible = true;
            button4.Visible = false;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form10 forgot = new Form10();
            this.Hide();
            forgot.ShowDialog();
            this.Close();
        }
    }
}
