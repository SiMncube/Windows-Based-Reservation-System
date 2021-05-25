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
    public partial class Form3 : Form
    {
        int count = 0;
        public Form3()
        {
            InitializeComponent();
            pictureBox4.Image = imageList1.Images[count];
        }

        private void pictureBox1_Click(object sender, EventArgs e)
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
    }
}
