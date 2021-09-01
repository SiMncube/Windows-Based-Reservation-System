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
    public partial class HelpFirstTimeCus : Form
    {
        public HelpFirstTimeCus()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            adminForm f = new adminForm();
            this.Hide();
            this.Close();
        }

        private void linkFirsttimehelp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            HelpMakeBooking f = new HelpMakeBooking();
            this.Hide();
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
