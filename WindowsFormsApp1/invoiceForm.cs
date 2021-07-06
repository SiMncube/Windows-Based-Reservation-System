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
            customerTa.Fill(fullDs.Customer);
            setDateIn();
            setDateOut();
            setName();
            setPrices();
            label20.Text = currentBooking.getSummaryID().ToString();
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
            for (int i = 0; i < amountDue.Length;i++)
            {
                if (amountDue[i] == '.')
                    break;
                temp += amountDue[i];
            }
            return decimal.Parse(temp);
        }
        private void setPrices()
        {
            int[] rooms = currentBooking.getRoomIDs();
            if (rooms[0] != -1)
            {
                for (int i = fullDs.BookingSummary.Rows.Count - 1; i >= 0; i--)
                {
                    if (fullDs.BookingSummary[i].summaryID == currentBooking.getSummaryID())
                    {
                        label17.Text = fullDs.BookingSummary[i].numberOfNights + "";
                        label19.Text = "R " + (getAmountDue() / fullDs.BookingSummary[i].numberOfNights) + ".00";
                        label21.Text = fullDs.BookingSummary[i].amountDue;
                    }
                }
            }
            else
            {
                label21.Text = "R " + rooms[1] + ".00";
            }
        }

        private void invoiceForm_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
            Homepage form = new Homepage();
            form.ShowDialog();
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            this.Close();
            Homepage form = new Homepage();
            form.ShowDialog();
        }

        private void pictureBox2_Click_2(object sender, EventArgs e)
        {
            this.Close();
            Homepage form = new Homepage();
            form.ShowDialog();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            adminForm a = new adminForm();
            this.Hide();
            a.ShowDialog();
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
