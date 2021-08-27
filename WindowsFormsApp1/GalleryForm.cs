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
        int count = 1;

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
            Homepage f = new Homepage();
            this.Hide();
            f.ShowDialog();
            this.Close();
        }

        private void nextBTN_Click(object sender, EventArgs e)
        {
            count++;
            
            if (count > 5)
            {
                count = 1;
            }
               
            changeImage(count);


        }

        private void backBTN_Click(object sender, EventArgs e)
        {
            count--;

            if (count < 1)
            {
                count = 5;
            }
           
            changeImage(count);
        }

        private void changeImage(int num)

        {
            switch(num)
            {
                case 1:
                    pictureBox1.Image = Properties.Resources.SIngleLux;
                    break;
                case 2:
                    pictureBox1.Image = Properties.Resources.SingleRoom1;
                    break;
                case 3:
                    pictureBox1.Image = Properties.Resources.DoubleRoom1;
                    break;
                case 4:
                    pictureBox1.Image = Properties.Resources.DoubleStand;
                    break;
                case 5:
                    pictureBox1.Image = Properties.Resources.Outside2;
                    break;

            }


        }

       
    }
}
