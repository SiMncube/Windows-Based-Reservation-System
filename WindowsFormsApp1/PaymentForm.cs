using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class PaymentForm : Form
    {
        public PaymentForm()
        {
            InitializeComponent();
            paymentTa.Fill(fullDs.Payment);
            bookingSummaryTa.Fill(fullDs.BookingSummary);
            bookedRoomTa.Fill(fullDs.BookedRoom);
            toolTip1.SetToolTip(cardNumberTextBox, "Must be 16 digits");
            toolTip1.SetToolTip(cvvTextbox,"Must be 3 digits");
            textBox1.Text = currentUser.getEmailID();
        }
        private string getAmountDue()
        {
            for (int i = 0; i < fullDs.BookingSummary.Rows.Count; i++)
            {
                if (fullDs.BookingSummary[i].summaryID == currentBooking.getSummaryID())
                    return fullDs.BookingSummary[i].amountDue;
            }
            return "";
        }
        private string getSurname()
        {
            int startIndex = 0;
            for (int i = 0; i < holderNameTextBox.Text.Length; i++)
            {
                if (holderNameTextBox.Text[i] == ' ')
                {
                    startIndex = i + 1;
                    break;
                }
            }
            return holderNameTextBox.Text.Substring(startIndex).Trim();
        }
        private bool isLetter(char c)
        {
            if(c >= 'a' && c <= 'z' || c == ' ')
                return true;
            return false;
        }
        private bool isAllLetters(string s)
        {
            s = s.ToLower();
            for (int i = 0; i < s.Length; i++)
            {
                if (!isLetter(s[i]))
                    return false;
            }
            return true;
        }
        private bool nameIsValid()
        {
            if (isAllLetters(holderNameTextBox.Text)&& holderNameTextBox.Text.Length > 3)
                return true;
            holderNameTextBox.BackColor = Color.Red;
            return false;
        }
        private bool cardNumberIsValid()
        {
            if (cardNumberTextBox.Text.Length == 16)
                return true;
            cardNumberTextBox.BackColor = Color.Red;
            return false;
        }
        private bool cvvIsValid()
        {
            if (cvvTextbox.Text.Length == 3)
                return true;
            cvvTextbox.BackColor = Color.Red;
            return false;
        }
        private bool dateIsSelected()
        {
            if (monthComboBox.SelectedItem != null && yearComboBox.SelectedItem != null)
                return true;
            monthComboBox.BackColor = Color.Red;
            yearComboBox.BackColor = Color.Red;
            return false;
        }
        private bool creditDetailsValid()
        {
            int count = 0;
            if (!nameIsValid())
                count++;
            if (!cardNumberIsValid())
                count++;
            if (!cvvIsValid())
                count++;
            if (!dateIsSelected())
                count++;
            return count == 0;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (creditDetailsValid())
            {
                paymentTa.Insert(DateTime.Today, getAmountDue(), currentBooking.getSummaryID(), "Credit card");
                updateBookedRoom();
                updateBookingStatus();
                InvoiceForm i = new InvoiceForm();
                Email.bookingStatus = "Complete";  //added by Sihle
                Email.sendInvoice();               //added by Sihle
                i.ShowDialog();
                this.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Homepage i = new Homepage();
         //   this.Hide();
            i.ShowDialog();
            this.Close();
        }
        private bool emailValid()
        {
            if (textBox1.Text != null)
            {
                EmailAddressAttribute email = new EmailAddressAttribute();
                if (email.IsValid(textBox1.Text))
                    return true;
            }
            textBox1.BackColor = Color.Red;
            return false;

        }
        private DateTime GetDateIn()
        {
            DateTime dateIn = DateTime.Today;
            for (int i = fullDs.BookingSummary.Rows.Count - 1; i >= 0; i--)
            {
                if (fullDs.BookingSummary[i].summaryID == currentBooking.getSummaryID())
                {
                    dateIn = fullDs.BookingSummary[i].dateIn;
                    break;
                }
            }
            return dateIn;
        }
        private DateTime GetDateOut()
        {
            DateTime dateOut = DateTime.Today;
            for (int i = fullDs.BookingSummary.Rows.Count - 1; i >= 0; i--)
            {
                if (fullDs.BookingSummary[i].summaryID == currentBooking.getSummaryID())
                {
                    dateOut = fullDs.BookingSummary[i].dateOut;
                }
            }
            return dateOut;
        }
        private void updateBookedRoom()
        {
            int[] rooms = currentBooking.getRoomIDs();
            if (rooms[0] != -1)
            {
                for (int i = 0; i < rooms.Length; i++)
                {
                    for (DateTime dateID = GetDateIn(); DateTime.Compare(dateID, GetDateOut()) < 0; dateID = dateID.AddDays(1))
                    {
                        bookedRoomTa.Insert(dateID, currentBooking.getSummaryID(), rooms[i]);
                    }
                }
                bookedRoomTa.Update(fullDs.BookedRoom);
                bookedRoomTa.Fill(fullDs.BookedRoom);
            }
        }
        private void updateBookingStatus()
        {
            int[] rooms = currentBooking.getRoomIDs();
            if (rooms[0] != -1)
            {
                for (int i = 0; i < fullDs.BookingSummary.Rows.Count; i++)
                {
                    if (fullDs.BookingSummary[i].summaryID == currentBooking.getSummaryID())
                    {
                        fullDs.BookingSummary[i].bookingStatus = "Complete";
                        bookingSummaryTa.Update(fullDs.BookingSummary);
                        bookingSummaryTa.Fill(fullDs.BookingSummary);
                    }
                }
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            if (emailValid())
            {
                paymentTa.Insert(DateTime.Today, getAmountDue(), currentBooking.getSummaryID(), "EFT");
                updateBookedRoom();
                updateBookingStatus();
                InvoiceForm i = new InvoiceForm();
                Email.bookingStatus = "Complete";  //added by Sihle
                Email.isBankingDetails = true;   //added by Sihle
                Email.sendInvoice();               //added by Sihle
                this.Hide();
                i.ShowDialog();
                this.Close();
            }
        }

        private void PaymentForm_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
