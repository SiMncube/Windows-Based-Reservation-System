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
    public partial class invoiceForm : Form
    {
        public invoiceForm()
        {
            InitializeComponent();
            bookingSummaryTa.Fill(fullDs.BookingSummary);
            setDateIn();
            setDateOut();
            setName();
            setPrices();
        }
        private DateTime setDateIn()
        {
            DateTime dateIn = DateTime.Today;
            for (int i = fullDs.BookingSummary.Rows.Count - 1; i >= 0; i--)
            {
                if (fullDs.BookingSummary[i].summaryID == currentBooking.getSummaryID())
                {
                    dateIn = fullDs.BookingSummary[i].dateIn;
                    label19.Text = dateIn.ToString();
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
                    label11.Text = dateOut.ToString();
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
        private void setPrices()
        {
            for (int i = fullDs.BookingSummary.Rows.Count - 1; i >= 0; i--)
            {
                if (fullDs.BookingSummary[i].summaryID == currentBooking.getSummaryID())
                {
                    label4.Text = fullDs.BookingSummary[i].numberOfNights + "";
                    label19.Text = "R " + int.Parse(fullDs.BookingSummary[i].amountDue) / fullDs.BookingSummary[i].numberOfNights;
                    label21.Text = "R " + fullDs.BookingSummary[i].amountDue;
                }
            }
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }
    }
}
