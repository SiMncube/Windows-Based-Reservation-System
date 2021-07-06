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
    public partial class GalleryForm : Form
    {
        public GalleryForm()
        {
            InitializeComponent();
            customerTableAdapter1.Fill(fullDatabase1.Customer);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            Homepage form = new Homepage();
            form.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoginForm f = new LoginForm();
            this.Hide();
            f.ShowDialog();
            this.Close();
        }

        /* private void pictureBox1_Click(object sender, EventArgs e)
            {
            this.Close();
            }
            private void pictureBox2_Click_1(object sender, EventArgs e)
            {
            if (count > 0)
            {
            count--;
            }
            else
            {
            count = 6;
            }
            pictureBox4.Image = imageList1.Images[count];
            }

            private void pictureBox3_Click(object sender, EventArgs e)
            {
            if(count < 6)
            {
            count++;
            }
            else
            {
            count = 0;
            }
            pictureBox4.Image = imageList1.Images[count];
            }
        */
    }
}
