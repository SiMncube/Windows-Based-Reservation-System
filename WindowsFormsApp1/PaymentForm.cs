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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            panel3.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel3.Visible = true;
            panel2.Visible = false;
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
        private bool nameIsValid()
        {
            for (int i = 0; i < fullDs.Customer.Rows.Count; i++)
            {
                if (fullDs.Customer[i].emailID == currentUser.getEmailID() && fullDs.Customer[i].surname.Equals(getSurname(), StringComparison.OrdinalIgnoreCase))
                    return true;
            }
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
            return nameIsValid() && cardNumberIsValid() && cvvIsValid() && dateIsSelected();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (creditDetailsValid())
            {
                paymentTa.Insert(DateTime.Today, getAmountDue(), currentBooking.getSummaryID(), "Credit card");
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
        private bool eftIsValid()
        {
            return usernameIsValid() && passwordIsValid();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            if(eftIsValid())
            paymentTa.Insert(DateTime.Today, getAmountDue(), currentBooking.getSummaryID(), "EFT");
            invoiceForm i = new invoiceForm();
            this.Hide();
            i.ShowDialog();
            this.Close();
        }
    }
}
