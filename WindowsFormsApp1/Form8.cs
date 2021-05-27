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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
            string s = currentUser.getEmailID();
            label1.Text = "Current logged in user emailID : " + s;
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 login = new Form1();
            this.Hide();
            login.ShowDialog();
            this.Close();
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

        private void modifyBookingToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Form4 cancelBooking = new Form4();
            this.Hide();
            cancelBooking.ShowDialog();
            this.Show();
        }

        private void picturesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 pics = new Form3();
            this.Hide();
            pics.ShowDialog();
            this.Show();
        }

        private void extendStayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form9 extend = new Form9();
            this.Hide();
            extend.ShowDialog();
            this.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form8_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fullDatabase.Customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.fullDatabase.Customer);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
