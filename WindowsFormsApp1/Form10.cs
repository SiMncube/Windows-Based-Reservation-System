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

        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < fullDatabase1.Customer.Rows.Count; i++)
            {
                if (fullDatabase1.Customer[i].emailID.Equals(textBox1.Text, StringComparison.OrdinalIgnoreCase) || textBox1.Text.Equals(fullDatabase1.Customer[i].cellNumber))
                {
                    label4.Text = "Your Password is \n" + fullDatabase1.Customer[i].password.ToString();
                    label4.Visible = true;
                    break;
                }

                label4.Text = "Your account doesnt exist";
                label4.Visible = true;

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form = new Form1();
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
