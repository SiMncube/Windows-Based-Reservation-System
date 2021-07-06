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
    public partial class Homepage : Form
    {
        public Homepage()
        {
            InitializeComponent();
            customerTableAdapter.Fill(fullDatabase.Customer);
            string userName = "";
            for (int i = 0; i < fullDatabase.Customer.Rows.Count; i++)
            {
                if (fullDatabase.Customer[i].emailID.Equals(currentUser.getEmailID()))
                {
                    userName += fullDatabase.Customer[i].surname +" "+ fullDatabase.Customer[i].name;
                    break;
                }
            }
            label1.Text += userName;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            this.Hide();
            login.ShowDialog();
            this.Close();
        }

        private void makeBookingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MakebookingForm makebooking = new MakebookingForm();
            this.Hide();
            makebooking.ShowDialog();
            this.Show();
        }

        private void checkBookingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CheckbookingForm checkBooking = new CheckbookingForm();
            this.Hide();
            checkBooking.ShowDialog();
            this.Close();
        }

        private void modifyBookingToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            CancelbookingForm cancelBooking = new CancelbookingForm();
            this.Hide();
            cancelBooking.ShowDialog();
            this.Close();
        }

        private void picturesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GalleryForm pics = new GalleryForm();
            this.Hide();
            pics.ShowDialog();
            this.Close();
        }

        private void Form8_Load(object sender, EventArgs e)
        {

        }

        private void galleryToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
