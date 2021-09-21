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
    public partial class ManagerForm : Form
    {
        public ManagerForm()
        {
            InitializeComponent();
         
        }

        public double getAmount(string s)
        {
            string p = "";
            for(int i = 1; i <s.Length; i++)
            {
                if (s[i]!='.')
                {
                    p += s[i].ToString();
                }
                if(s[i] == '.')
                {
                    p += ',';
                }
                if (s.Length == s.Length-1 || s.Length ==s.Length-2)
                {
                    p += '0';
                }
                //p += s[i].ToString();
            }
            p = p.Trim();
            return Convert.ToDouble(p);

        }

        private void managerForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fullDatabase.Payment' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'fullDatabase.BookingSummary' table. You can move, or remove it, as needed.
            //  this.bookingSummaryTableAdapter.Fill(this.fullDatabase.BookingSummary);

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            BookingReport one = new BookingReport();
            one.ShowDialog();
            this.Show();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            PaymentReport one = new PaymentReport();
            one.ShowDialog();
            this.Show();
        }
    }
}
