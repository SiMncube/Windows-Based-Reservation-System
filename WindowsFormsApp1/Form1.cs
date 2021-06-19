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
            customerTableAdapter1.Fill(fullDs.Customer);
            staffTa.Fill(fullDs.Staff);
        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (loginisValid())
            {
                if(userNameIsCorrect() && userPasswordIsCorrect())
                {
                    this.Hide();
                    Form8 homePage = new Form8();
                    homePage.ShowDialog();
                    this.Close();
                }
                if(adminNameIsCorrect() && adminPasswordIsCorrect())
                {
                    this.Hide();
                    adminForm a = new adminForm();
                    a.ShowDialog();
                    this.Close();
                }
                if(managerNameIsCorrect() && managerNameIsCorrect())
                {
                    this.Hide();
                    managerForm m = new managerForm();
                    m.ShowDialog();
                    this.Close();
                }
            }
        }
        private bool userNameIsCorrect()
        {
            for (int i = 0; i < fullDs.Customer.Rows.Count; i++)
            {
                if (fullDs.Customer[i].emailID.Equals(textBox1.Text, StringComparison.OrdinalIgnoreCase))
                {
                    currentUser.setEmailID(fullDs.Customer[i].emailID);
                    return true;
                }
            }
            label8.Visible = true;
            return false;
        }
        private bool userPasswordIsCorrect()
        {
            for (int i = 0; i < fullDs.Customer.Rows.Count; i++)
            {
                if(fullDs.Customer[i].password == textBox2.Text && fullDs.Customer[i].emailID.Equals(textBox1.Text, StringComparison.OrdinalIgnoreCase))
                    return true;
            }
            if (userNameIsCorrect())
                label9.Visible = true;
            return false;
        }
        private bool adminNameIsCorrect()
        {
            for (int i = 0; i < fullDs.Staff.Rows.Count; i++)
            {
                if (fullDs.Staff[i].emailID.Equals(textBox1.Text, StringComparison.OrdinalIgnoreCase) && fullDs.Staff[i].staffType == "Admin")
                {
                    currentUser.setEmailID(fullDs.Staff[i].emailID);

                    return true;
                }
            }
            label8.Visible = true;
            return false;
        }
        private bool adminPasswordIsCorrect()
        {
            for (int i = 0; i < fullDs.Staff.Rows.Count; i++)
            {
                if (fullDs.Staff[i].password == textBox2.Text && fullDs.Staff[i].emailID.Equals(textBox1.Text, StringComparison.OrdinalIgnoreCase))
                    return true;
            }
            if (adminNameIsCorrect())
                label9.Visible = true;
            return false;
        }
        private bool managerNameIsCorrect()
        {
            for (int i = 0; i < fullDs.Staff.Rows.Count; i++)
            {
                if (fullDs.Staff[i].emailID.Equals(textBox1.Text, StringComparison.OrdinalIgnoreCase) && fullDs.Staff[i].staffType == "Manager")
                {
                    currentUser.setEmailID(fullDs.Staff[i].emailID);
                    return true;
                }
            }
            label8.Visible = true;
            return false;
        }
        private bool managerPasswordIsCorrect()
        {
            for (int i = 0; i < fullDs.Staff.Rows.Count; i++)
            {
                if (fullDs.Staff[i].password == textBox2.Text && fullDs.Staff[i].emailID.Equals(textBox1.Text, StringComparison.OrdinalIgnoreCase))
                    return true;
            }
            if (managerNameIsCorrect())
                label9.Visible = true;
            return false;
        }
        private bool loginisValid()
        {
            if (userNameIsCorrect() && userPasswordIsCorrect())
                return true;
            if (adminNameIsCorrect() && adminPasswordIsCorrect())
                return true;
            if (managerNameIsCorrect() && managerNameIsCorrect())
                return true;
            return false;
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
           // this.Hide();
            forgot.ShowDialog();
            this.Close();
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                if (loginisValid())
                {
                    if (userNameIsCorrect() && userPasswordIsCorrect())
                    {
                        Form8 homePage = new Form8();
                      //  this.Hide();
                        homePage.ShowDialog();
                        this.Close();
                    }
                    else if (adminNameIsCorrect() && adminPasswordIsCorrect())
                    {
                        adminForm a = new adminForm();
                       // this.Hide();
                        a.ShowDialog();
                        this.Close();
                    }
                    else if (managerNameIsCorrect() && managerNameIsCorrect())
                    {
                        managerForm m = new managerForm();
                     //   this.Hide();
                        m.ShowDialog();
                        this.Close();
                    }
                }
            }
        }
    }
}
