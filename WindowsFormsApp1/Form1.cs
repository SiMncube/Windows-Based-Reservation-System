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

        private void signUpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 signup = new Form2();
            this.Hide();
            signup.ShowDialog();
            this.Show();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 login = new Form3();
            this.Hide();
            login.ShowDialog();
            this.Show();
        }
        private void makeBookingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 makebooking = new Form5();
            this.Hide();
            makebooking.ShowDialog();
            this.Show();
        }

        private void checkBookingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 checkBooking = new Form6();
            this.Hide();
            checkBooking.ShowDialog();
            this.Show();
        }
    }
}
