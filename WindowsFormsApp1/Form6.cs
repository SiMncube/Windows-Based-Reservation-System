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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
            bookingSummaryTableAdapter1.Fill(fullDatabase1.BookingSummary);
            customerTableAdapter1.Fill(fullDatabase1.Customer);
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

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            this.Close();
            Form8 form = new Form8();
            form.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.White;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private bool bookingExist(string summaryID)
        {
            string intro = "  === You Bookin Details Are ===";
            string dateIn = "\n  Check in date : ";
            string dateOut = "\n  Check out date : ";
            string numNights = "\n  Number of nights : ";
            string bookingMethod = "\n  Bookin was made : ";
            string bookingStatus = "\n  The Booking is : ";
            string amount = "\n  The amount for the booking : ";
            for (int i = 0; i < fullDatabase1.BookingSummary.Rows.Count; i++)
            {
                if(fullDatabase1.Tables["BookingSummary"].Rows[i]["summaryID"].ToString() == summaryID)
                {
                    dateIn += fullDatabase1.Tables["BookingSummary"].Rows[i]["dateIn"].ToString().Substring(0,10);
                    dateOut += fullDatabase1.Tables["BookingSummary"].Rows[i]["dateOut"].ToString().Substring(0,10);
                    numNights += fullDatabase1.Tables["BookingSummary"].Rows[i]["numberOfNights"].ToString();
                    bookingMethod += fullDatabase1.Tables["BookingSummary"].Rows[i]["bookingMethod"].ToString();
                    bookingStatus += fullDatabase1.Tables["BookingSummary"].Rows[i]["bookingStatus"].ToString();
                    amount += fullDatabase1.Tables["BookingSummary"].Rows[i]["amountDue"].ToString();
                    label4.Text = intro + dateIn + dateOut + numNights + bookingMethod + bookingStatus + amount;
                    label3.Visible = false;
                    return true;
                }
                
            }
            textBox1.BackColor = Color.Red;
            return false;
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            this.bookingSummaryTableAdapter1.Fill(fullDatabase1.BookingSummary);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form8 f = new Form8();
            this.Hide();
            f.ShowDialog();
            this.Close();
        }
    }
}
