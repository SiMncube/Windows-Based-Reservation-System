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
    public partial class PaymentForm : Form
    {
        public PaymentForm()
        {
            InitializeComponent();
            paymentTa.Fill(fullDs.Payment);
            bookingSummaryTa.Fill(fullDs.BookingSummary);
            bookedRoomTa.Fill(fullDs.BookedRoom);
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
            //if (c >= 'a' && c <= 'z' || c == ' ')
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
                invoiceForm i = new invoiceForm();
                this.Hide();
                i.ShowDialog();
                this.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form8 i = new Form8();
            this.Hide();
            i.ShowDialog();
            this.Close();
        }
        private bool usernameIsValid()
        {
            if (usernameTextbox.Text.Length > 3)
                return true;
            usernameTextbox.BackColor = Color.Red;
            return false;
        }
        private bool passwordIsValid()
        {
            if (passwordTextbox.Text.Length > 3)
                return true;
            passwordTextbox.BackColor = Color.Red;
            return false;
        }
        private bool bankIsChoosen()
        {
            if (bankComboBox.SelectedItem != null)
                return true;
            bankComboBox.BackColor = Color.Red;
            return false;
        }
        private bool eftIsValid()
        {
            int count = 0;
            if(!usernameIsValid())
                count++;
            if(!passwordIsValid())
                count++;
            if (!bankIsChoosen())
                count++;
            return count == 0;
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
                    break;
                }
            }
            return dateOut;
        }
        private void updateBookedRoom()
        {
            int[] rooms = currentBooking.getRoomIDs();
            for (int i = 0; i < rooms.Length; i++)
            {
                for (DateTime dateID = GetDateIn(); DateTime.Compare(dateID, GetDateOut()) < 0; dateID = dateID.AddDays(1))
                { 
                    bookedRoomTa.Insert(GetDateIn(), currentBooking.getSummaryID(), rooms[i]);
                    break;
                }
            }
        }
        private void updateBookingStatus()
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
        private void button5_Click(object sender, EventArgs e)
        {
            if (eftIsValid())
            {
                paymentTa.Insert(DateTime.Today, getAmountDue(), currentBooking.getSummaryID(), "EFT");
                updateBookedRoom();
                updateBookingStatus();
                invoiceForm i = new invoiceForm();
                this.Hide();
                i.ShowDialog();
                this.Close();
            }
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
