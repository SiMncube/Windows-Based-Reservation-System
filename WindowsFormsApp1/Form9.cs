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
    public partial class Form9 : Form
    {
        public Form9()
        {
            
            InitializeComponent();
            customerTableAdapter1.Fill(fullDatabase1.Customer);
            string userName = "";
            for (int i = 0; i < fullDatabase1.Customer.Rows.Count; i++)
            {
                if (fullDatabase1.Customer[i].emailID.Equals(currentUser.getEmailID()))
                {
                    userName += fullDatabase1.Customer[i].surname + " " + fullDatabase1.Customer[i].name;
                    break;
                }

            }
            label4.Text += userName;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form9_Load(object sender, EventArgs e)
        {

        }
    }
}
