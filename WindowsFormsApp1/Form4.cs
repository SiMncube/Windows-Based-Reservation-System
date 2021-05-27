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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            bookingSummaryTableAdapter.Fill(fullDatabase.BookingSummary);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fullDatabase.BookingSummary' table. You can move, or remove it, as needed.
            this.bookingSummaryTableAdapter.Fill(this.fullDatabase.BookingSummary);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(bookingExist(textBox1.Text))
            {
                label4.Visible = true;
                label5.Visible = false;
            }
            else
            {
                label5.Visible = true;
                label4.Visible = false;
            }
        }
        private bool bookingExist(string summaryID)
        {
            
            for (int i = 0; i < fullDatabase.BookingSummary.Rows.Count; i++)
            {
                if (fullDatabase.Tables["BookingSummary"].Rows[i]["summaryID"].ToString() == summaryID)
                {
                    fullDatabase.Tables["BookingSummary"].Rows[i]["bookingStatus"] = "Canceled";
                    return true;
                }

            }
            return false;
        }
    }
}
