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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "yyyy/mm";
            dateTimePicker1.ShowUpDown = true;
            customerTableAdapter1.Fill(fullDatabase1.Customer);
            paymentTableAdapter1.Fill(fullDatabase1.Payment);
            bookingSummaryTableAdapter1.Fill(fullDatabase1.BookingSummary);
            bookedRoomTableAdapter1.Fill(fullDatabase1.BookedRoom);
            label7.Text += getAmountDue();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if(paymentDetailIsValid())
            {
                paymentTableAdapter1.Insert(DateTime.Today, getAmountDue(), currentBooking.getSummaryID(), "EFT");
                updateBookingStatus();
                updateBookedRoom();
                label8.Text += getAmountDue();
                label9.Visible = true;
                label8.Visible = true;
                label6.Visible = false;
                label7.Visible = false;
                resetColor(textBox1);
                resetColor(textBox2);
                resetColor(textBox3);
                paymentTableAdapter1.Fill(fullDatabase1.Payment);
                button1.Enabled = false;
                label8.Text = toString();
                panel1.Enabled = false;
            }
        }       
        private void pictureBox1_Click_2(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private string getSurname()
        {
            int startIndex = 0;
            for (int i = 0; i < textBox3.Text.Length; i++)
            {
                if (textBox3.Text[i] == ' ')
                {
                    startIndex = i + 1;
                    break;
                }
            }
            return textBox3.Text.Substring(startIndex);
        }
        private bool nameIsValid()
        {
            for (int i = 0; i < fullDatabase1.Customer.Rows.Count; i++)
            {
                if (fullDatabase1.Tables["Customer"].Rows[i]["emailID"].ToString() == currentUser.getEmailID() && fullDatabase1.Tables["Customer"].Rows[i]["surname"].ToString().Equals(getSurname(), StringComparison.OrdinalIgnoreCase))
                    return true;
            }
            return false;
        }
        private bool cardNumberIsValid()
        {
            return textBox1.Text.Length == 16;
        }
        private bool cardNotExpired()
        {
            return dateTimePicker1.Value.Year > DateTime.Today.Year && dateTimePicker1.Value.Month < 13 && dateTimePicker1.Value.Month > 0;
        }
        private bool cvvIsValid()
        {
            return textBox2.Text.Length == 3;
        }
        private bool paymentDetailIsValid()
        {
            int count = 0;
            if(!nameIsValid())
            {
                textBox3.BackColor = Color.Red;
                count++;
            }
            if(!cardNumberIsValid())
            {
                textBox1.BackColor = Color.Red;
                count++;
            }
            if(!cvvIsValid())
            {
                textBox2.BackColor = Color.Red;
                count++;
            }
            if(!cardNotExpired())
            {
                label6.Visible = true;
                count++;
            }
            return count == 0;
        }
        private string getAmountDue()
        {
            for (int i = 0; i < fullDatabase1.BookingSummary.Rows.Count; i++)
            {
                if(fullDatabase1.Tables["BookingSummary"].Rows[i]["summaryID"].ToString() == currentBooking.getSummaryID()+"")
                    return fullDatabase1.Tables["BookingSummary"].Rows[i]["amountDue"].ToString();
            }
            return "";
        }
        private void updateBookingStatus()
        {
            for (int i = 0; i < fullDatabase1.BookingSummary.Rows.Count; i++)
            {
                if (fullDatabase1.Tables["BookingSummary"].Rows[i]["summaryID"].ToString() == currentBooking.getSummaryID() + "")
                {
                    fullDatabase1.Tables["BookingSummary"].Rows[i]["bookingStatus"] = "Complete" ;
                    bookingSummaryTableAdapter1.Update(fullDatabase1.BookingSummary);
                    bookingSummaryTableAdapter1.Fill(fullDatabase1.BookingSummary);
                }

            }
        }
        private void updateBookedRoom()
        {
            int[] rooms = currentBooking.getRoomIDs();
            for (int i = 0; i < rooms.Length; i++)
            {
                for (DateTime dateID = GetDateIn(); DateTime.Compare(dateID, GetDateOut()) <= 0; dateID = dateID.AddDays(1))
                {
                    bookedRoomTableAdapter1.Insert(dateID, currentBooking.getSummaryID(), rooms[i]);
                }
            }
            bookedRoomTableAdapter1.Fill(fullDatabase1.BookedRoom);
        }
        private DateTime GetDateIn()
        {
            DateTime dateIn =  DateTime.Today;
            for (int i = fullDatabase1.BookingSummary.Rows.Count - 1; i >= 0; i--)
            {
                if (fullDatabase1.Tables["BookingSummary"].Rows[i]["summaryID"].ToString() == currentBooking.getSummaryID() + "")
                {
                    DateTime date = (DateTime)fullDatabase1.Tables["BookingSummary"].Rows[i]["dateIn"];
                    break;
                }

            }
            return dateIn;
        }
        private DateTime GetDateOut()
        {
            DateTime dateIn = DateTime.Today;
            for (int i = 0; i < fullDatabase1.BookingSummary.Rows.Count; i++)
            {
                if (fullDatabase1.Tables["BookingSummary"].Rows[i]["summaryID"].ToString() == currentBooking.getSummaryID() + "")
                {
                    DateTime date = (DateTime)fullDatabase1.Tables["BookingSummary"].Rows[i]["dateOut"];
                    break;
                }

            }
            return dateIn;
        }
        private void resetColor(TextBox textBox)
        {
            textBox.BackColor = Color.White;
        }
        /*private string getDataBaseColumn(string databaseName,string primaryKeyName , string dataBasColumn , string primaryKey)
        {
            for (int i = 0; i < fullDatabase1.f.Rows.Count; i++)
            {
                if(fullDatabase1.Tables[databaseName].Rows[i][primaryKeyName].ToString() ==  primaryKey)
                    return fullDatabase1.Tables[databaseName].Rows[i][dataBasColumn].ToString();

            }
                return "";
        }*/
        private string getCustomerColumn()
        {
            for(int i = 0; i < fullDatabase1.Customer.Rows.Count; i++)
            {
                if (fullDatabase1.Tables["Customer"].Rows[i]["emailID"].ToString() == currentUser.getEmailID())
                {
                    return "Name : " + fullDatabase1.Tables["Customer"].Rows[i]["surname"].ToString() + " " + fullDatabase1.Tables["Customer"].Rows[i]["name"].ToString();
                }
            }
            return "";
        }
        private string getSummaryDetails()
        {
            for (int i = 0; i < fullDatabase1.BookingSummary.Rows.Count; i++)
            {
                if (fullDatabase1.Tables["BookingSummary"].Rows[i]["summaryID"].ToString() == currentBooking.getSummaryID() + "")
                {
                    return "\nDate in   : " + ((DateTime)fullDatabase1.Tables["BookingSummary"].Rows[i]["dateIn"]).ToString("MM/dd/yyyy") +
                            "\nDate out : " + ((DateTime)fullDatabase1.Tables["BookingSummary"].Rows[i]["dateOut"]).ToString("MM/dd/yyyy") +
                            "\nAmount paid : " + getAmountDue() +
                            "\nBooking reference : " + currentBooking.getSummaryID();
                }

            }
            return "";
        }
        private string toString()
        {
            return getCustomerColumn() + getSummaryDetails();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            textBox3.BackColor = Color.White;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.White;
            textBox3.BackColor = Color.White;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            label6.Visible = false;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.BackColor = Color.White;
        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }
    }

}