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
            customerTableAdapter.Fill(fullDatabase.Customer);
            string userName = "";
            for (int i = 0; i < fullDatabase.Customer.Rows.Count; i++)
            {
                if (fullDatabase.Customer[i].emailID.Equals(currentUser.getEmailID()))
                {
                    userName += fullDatabase.Customer[i].surname + " " + fullDatabase.Customer[i].name;
                    break;
                }

            }
            label1.Text += userName;
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
            this.Close();
        }

        private void checkBookingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 checkBooking = new Form6();
            this.Hide();
            checkBooking.ShowDialog();
            this.Close();
        }

        private void modifyBookingToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            cancelBookingForm cancelBooking = new cancelBookingForm();
            this.Hide();
            cancelBooking.ShowDialog();
            this.Close();
        }

        private void picturesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 pics = new Form3();
            this.Hide();
            pics.ShowDialog();
            this.Close();
        }

        private void extendStayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form9 extend = new Form9();
            this.Hide();
            extend.ShowDialog();
            this.Close();
        }
        private void Form8_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fullDatabase.Customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.fullDatabase.Customer);

        }
    }
}
