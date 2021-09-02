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
    public partial class HelpUpdate : Form
    {
        public HelpUpdate()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            adminForm f = new adminForm();
            this.Hide();
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
