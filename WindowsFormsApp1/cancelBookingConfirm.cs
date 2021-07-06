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
    public partial class CancelbookingConfirm : Form
    {
        public CancelbookingConfirm()
        {
            InitializeComponent();
            bookingSummaryTa.Fill(fullDs.BookingSummary);
            customerTa.Fill(fullDs.Customer);
            setDateIn();
            setDateOut();
            setName();
            setPrices();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PaymentForm p = new PaymentForm();
            this.Hide();
            p.ShowDialog();
            this.Close();
        }

        private DateTime setDateIn()
        {
            DateTime dateIn = DateTime.Today;
            for (int i = fullDs.BookingSummary.Rows.Count - 1; i >= 0; i--)
            {
                if (fullDs.BookingSummary[i].summaryID == currentBooking.getSummaryID())
                {
                    dateIn = fullDs.BookingSummary[i].dateIn;
                    label9.Text = dateIn.ToString("dd/MM/yyyy");
                    break;
                }
            }
            return dateIn;
        }
        private void setDateOut()
        {
            DateTime dateOut = DateTime.Today;
            for (int i = fullDs.BookingSummary.Rows.Count - 1; i >= 0; i--)
            {
                if (fullDs.BookingSummary[i].summaryID == currentBooking.getSummaryID())
                {
                    dateOut = fullDs.BookingSummary[i].dateOut;
                    label11.Text = dateOut.ToString("dd/MM/yyyy");
                    break;
                }
            }
        }
        private void setName()
        {
            for (int i = 0; i < fullDs.Customer.Rows.Count; i++)
            {
                if (fullDs.Customer[i].emailID.Equals(currentUser.getEmailID(), StringComparison.OrdinalIgnoreCase))
                {
                    label8.Text = fullDs.Customer[i].surname + " " + fullDs.Customer[i].name;
                    label18.Text = currentUser.getEmailID();
                    break;
                }
            }
        }
        private decimal getAmountDue()
        {
            string amountDue = "";
            for (int i = fullDs.BookingSummary.Rows.Count - 1; i >= 0; i--)
            {
                if (fullDs.BookingSummary[i].summaryID == currentBooking.getSummaryID())
                {
                    amountDue = fullDs.BookingSummary[i].amountDue.Substring(2);
                    break;
                }
            }
            string temp = "";
            for (int i = 0; i < amountDue.Length; i++)
            {
                if (amountDue[i] == '.')
                    break;
                temp += amountDue[i];
            }
            return decimal.Parse(temp);
        }
        private void setPrices()
        {
            for (int i = fullDs.BookingSummary.Rows.Count - 1; i >= 0; i--)
            {
                if (fullDs.BookingSummary[i].summaryID == currentBooking.getSummaryID())
                {
                    label17.Text = fullDs.BookingSummary[i].numberOfNights + "";
                    label19.Text = "R " + (getAmountDue() / fullDs.BookingSummary[i].numberOfNights) + ".00";
                    label21.Text = fullDs.BookingSummary[i].amountDue;
                    label23.Text = "R " + (getAmountDue()/2)+".00";
                }
            }
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
