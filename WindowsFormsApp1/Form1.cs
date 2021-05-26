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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (LoginIsValid())
            {
                Form8 homePage = new Form8();
                this.Hide();
                homePage.ShowDialog();
                this.Close();
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Form2 signup = new Form2();
            this.Hide();
            signup.ShowDialog();
            this.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private bool LoginIsValid()
        {
            return true;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
