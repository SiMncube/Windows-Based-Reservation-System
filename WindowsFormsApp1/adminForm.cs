﻿using System;
using System.Collections;
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
    public partial class adminForm : Form
    {
        public adminForm()
        {
            InitializeComponent();
            bookingInnerTa.Fill(fullDs.BookingInner);
            paymentTa.Fill(fullDs.Payment);
            bookingSummaryTa.Fill(fullDs.BookingSummary);
            viewBookingInnerTa.Fill(fullDs.viewBookingInner);
            staffTa.Fill(fullDs.Staff);
            modifyBookingInnerTa.Fill(fullDs.ModifyBookingInner);
            customerTa.Fill(fullDs.Customer);
            customer1Ta1.Fill(fullDs.Customer1);
            bookedRoomTa.Fill(fullDs.BookedRoom);
            label12.Text += logedInAdmin();
        }
        /*=========================================================================================== Kaygee code ===========================================================================================*/

        private string logedInAdmin()
        {
            string admin = "";
            for (int i = 0; i < fullDs.Staff.Rows.Count; i++)
            {
                if (fullDs.Staff[i].emailID.Equals(currentUser.getEmailID(), StringComparison.OrdinalIgnoreCase))
                {
                    admin += fullDs.Staff[i].surname + " " + fullDs.Staff[i].name;
                    break;
                }
            }
            return admin;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (signUIsValid())
            {
                customerTa.Insert(capFirst(emailTextBox.Text), capFirst(firtNameTextBox.Text), capFirst(lastNameTextBox.Text), IDTextBox.Text, cellNumberTextBox.Text, "00000000", capFirst(addressLine1TextBox.Text), capFirst(addressLine2TextBox.Text), capFirst(cityTextBox.Text), postalCodeTextBox.Text);
                bookingInnerTa.Fill(fullDs.BookingInner);
                paymentTa.Fill(fullDs.Payment);
                bookingSummaryTa.Fill(fullDs.BookingSummary);
                viewBookingInnerTa.Fill(fullDs.viewBookingInner);
                staffTa.Fill(fullDs.Staff);
                modifyBookingInnerTa.Fill(fullDs.ModifyBookingInner);
                customerTa.Fill(fullDs.Customer);
                customer1Ta1.Fill(fullDs.Customer1);
                bookedRoomTa.Fill(fullDs.BookedRoom);
                label9.Visible = true;
                firtNameTextBox.Text = "First name";
                firtNameTextBox.ForeColor = Color.Gray;
                lastNameTextBox.Text = "Last name";
                lastNameTextBox.ForeColor = Color.Gray;
                addressLine1TextBox.Text = "Street Address Line 1";
                addressLine1TextBox.ForeColor = Color.Gray;
                addressLine2TextBox.Text = "Street Address Line 2";
                addressLine2TextBox.ForeColor = Color.Gray;
                cityTextBox.Text = "City";
                cityTextBox.ForeColor = Color.Gray;
                postalCodeTextBox.Text = "Postal code";
                postalCodeTextBox.ForeColor = Color.Gray;
                cellNumberTextBox.Text = "Cell number";
                cellNumberTextBox.ForeColor = Color.Gray;
                IDTextBox.Text = "ID number";
                IDTextBox.ForeColor = Color.Gray;
                emailTextBox.Text = "Email";
                emailTextBox.ForeColor = Color.Gray;
            }
        }
        private string capFirst(string s)
        {
            return (s[0] + "").ToUpper() + s.Substring(1).ToLower();
        }
        private bool isDigit(char ch)
        {
            if (ch >= '0' && ch <= '9')
                return true;
            return false;
        }
        private bool isAllDigit(string s)
        {
            for (int i = 0; i < s.Length; i++)
            {
                if (!isDigit(s[i]))
                    return false;
            }
            return true;
        }
        private bool isLetter(char c)
        {
            if (c >= 'a' && c <= 'z')
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
        private bool NameIsValid()
        {
            int count = 0;
            if (!isAllLetters(firtNameTextBox.Text) || firtNameTextBox.Text.Length < 3)
            {
                firtNameTextBox.BackColor = Color.Red;
                count++;
            }
            if (!isAllLetters(lastNameTextBox.Text) || lastNameTextBox.Text.Length < 3)
            {
                lastNameTextBox.BackColor = Color.Red;
                count++;
            }
            return count == 0;
        }
        private bool CellNumberisValid()
        {
            if (!isAllDigit(cellNumberTextBox.Text) || cellNumberTextBox.Text.Length != 10)
            {
                cellNumberTextBox.BackColor = Color.Red;
                return false;
            }
            return true;
        }
        private bool EmailISValid()
        {
            if (emailTextBox.Text != null)
            {
                EmailAddressAttribute email = new EmailAddressAttribute();
                if (!email.IsValid(emailTextBox.Text))
                {
                    emailTextBox.BackColor = Color.Red;
                    label22.Visible = true;
                    return false;
                }
                if (EmailIsRegistred())
                {
                    emailTextBox.BackColor = Color.Red;
                    label23.Visible = true;
                    return false;
                }
                return true;
            }
            emailTextBox.BackColor = Color.Red;
            return false;
        }
        private bool EmailIsRegistred()
        {
            for (int i = 0; i < fullDs.Customer.Rows.Count; i++)
            {
                if (fullDs.Customer[i].emailID.Equals(emailTextBox.Text, StringComparison.OrdinalIgnoreCase))
                    return true;
            }
            return false;
        }
        private bool AddrressIsValid()
        {
            if (!isAllDigit(postalCodeTextBox.Text) || postalCodeTextBox.Text.Length != 4)
            {
                postalCodeTextBox.BackColor = Color.Red;
                return false;
            }
            return true;
        }
        private bool IdIsValid()
        {
            if (!isAllDigit(IDTextBox.Text) || IDTextBox.Text.Length != 13)
            {
                IDTextBox.BackColor = Color.Red;
                return false;
            }
            return true;
        }
        private bool signUIsValid()
        {
            int count = 0;
            if (!NameIsValid())
                count++;
            if (!AddrressIsValid())
                count++;
            if (!CellNumberisValid())
                count++;
            if (!EmailISValid())
                count++;
            if (!IdIsValid())
                count++;
            return count == 0;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            bookingInnerTa.FillByPreference(fullDs.BookingInner, textBox1.Text);
        }

        private void bookingInnerDGV_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            label4.Visible = false;
            if (!bookingIsCanceled((int)bookingInnerDGV.CurrentRow.Cells[4].Value) && !bookingIsIncomplete((int)bookingInnerDGV.CurrentRow.Cells[4].Value))
            {
                DataRow dataRow = fullDs1.BookingInner.NewRow();
                for (int i = 0; i < dataRow.ItemArray.Length; i++)
                {
                    dataRow[i] = bookingInnerDGV.CurrentRow.Cells[i].Value;
                }
                try
                {
                    fullDs1.BookingInner.Rows.Add(dataRow);
                    label5.Visible = false;
                    label13.Visible = false;
                    label14.Visible = false;
                }
                catch (ConstraintException)
                {
                    label5.Visible = true;

                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                cancelBooking((int)dataGridView1.CurrentRow.Cells[4].Value);
            }

            bookingSummaryTa.Update(fullDs.BookingSummary);
            paymentTa.Update(fullDs.Payment);

            label4.Visible = true;
            bookingInnerTa.Fill(fullDs.BookingInner);
            paymentTa.Fill(fullDs.Payment);
            bookingSummaryTa.Fill(fullDs.BookingSummary);
            viewBookingInnerTa.Fill(fullDs.viewBookingInner);
            staffTa.Fill(fullDs.Staff);
            modifyBookingInnerTa.Fill(fullDs.ModifyBookingInner);
            customerTa.Fill(fullDs.Customer);
            customer1Ta1.Fill(fullDs.Customer1);
            bookedRoomTa.Fill(fullDs.BookedRoom);
            fullDs1.Clear();
            label5.Visible = false;
            label13.Visible = false;


        }
        private string calculateAmountDue(string s)
        {
            s = s.Substring(2, s.Length - 5);
            double due = double.Parse(s) * 0.5;
            return due + "";
        }
        private void processRefund(int summaryID)
        {
            for (int i = 0; i < fullDs.Payment.Rows.Count; i++)
            {
                if (fullDs.Payment[i].summaryID == summaryID)
                {
                    string newAmount = calculateAmountDue(fullDs.Payment[i].amountDue.ToString());
                    paymentTa.Insert(DateTime.Today, "-R " + newAmount + ".00", summaryID, fullDs.Payment[i].typeOfPayment);
                    paymentTa.Fill(fullDs.Payment);
                    break;
                }
            }
        }
        private void cancelBooking(int summaryID)
        {
            for (int i = 0; i < fullDs.BookingSummary.Rows.Count; i++)
            {
                if (fullDs.Payment[i].summaryID == summaryID)
                {
                    fullDs.BookingSummary[i].bookingStatus = "Cancelled";
                    bookingSummaryTa.Update(fullDs.BookingSummary);
                    bookingSummaryTa.Fill(fullDs.BookingSummary);
                    bookingInnerTa.Fill(fullDs.BookingInner);
                    processRefund(summaryID);
                }
            }
        }
        private bool bookingIsCanceled(int summaryID)
        {
            for (int i = 0; i < fullDs.BookingSummary.Rows.Count; i++)
            {
                if (fullDs.BookingSummary[i].summaryID == summaryID && fullDs.BookingSummary[i].bookingStatus == "Cancelled")
                {
                    label13.Visible = true;
                    label14.Visible = false;
                    return true;
                }

            }
            return false;
        }
        private bool bookingIsIncomplete(int summaryID)
        {
            for (int i = 0; i < fullDs.BookingSummary.Rows.Count; i++)
            {
                if (fullDs.BookingSummary[i].summaryID == summaryID && fullDs.BookingSummary[i].bookingStatus == "inComplete")
                {
                    label14.Visible = true;
                    label13.Visible = false;
                    return true;
                }
            }
            return false;
        }
        private void firtNameTextBox_Enter(object sender, EventArgs e)
        {
            if (firtNameTextBox.Text == "First name")
            {
                firtNameTextBox.Text = null;
                firtNameTextBox.ForeColor = Color.Black;
            }
        }

        private void firtNameTextBox_Leave(object sender, EventArgs e)
        {
            if (firtNameTextBox.Text == "")
            {
                firtNameTextBox.Text = "First name";
                firtNameTextBox.ForeColor = Color.Gray;
            }
        }

        private void lastNameTextBox_Enter(object sender, EventArgs e)
        {
            if (lastNameTextBox.Text == "Last name")
            {
                lastNameTextBox.Text = null;
                lastNameTextBox.ForeColor = Color.Black;
            }
        }

        private void lastNameTextBox_Leave(object sender, EventArgs e)
        {
            if (lastNameTextBox.Text == "")
            {
                lastNameTextBox.Text = "Last name";
                lastNameTextBox.ForeColor = Color.Gray;
            }
        }

        private void addressLine1TextBox_Enter(object sender, EventArgs e)
        {
            if (addressLine1TextBox.Text == "Street Address Line 1")
            {
                addressLine1TextBox.Text = null;
                addressLine1TextBox.ForeColor = Color.Black;
            }
        }

        private void addressLine1TextBox_Leave(object sender, EventArgs e)
        {
            if (addressLine1TextBox.Text == "")
            {
                addressLine1TextBox.Text = "Street Address Line 1";
                addressLine1TextBox.ForeColor = Color.Gray;
            }
        }

        private void addressLine2TextBox_Enter(object sender, EventArgs e)
        {
            if (addressLine2TextBox.Text == "Street Address Line 2")
            {
                addressLine2TextBox.Text = null;
                addressLine2TextBox.ForeColor = Color.Black;
            }
        }

        private void addressLine2TextBox_Leave(object sender, EventArgs e)
        {
            if (addressLine2TextBox.Text == "")
            {
                addressLine2TextBox.Text = "Street Address Line 2";
                addressLine2TextBox.ForeColor = Color.Gray;
            }
        }

        private void cityTextBox_Enter(object sender, EventArgs e)
        {
            if (cityTextBox.Text == "City")
            {
                cityTextBox.Text = null;
                cityTextBox.ForeColor = Color.Black;
            }
        }

        private void cityTextBox_Leave(object sender, EventArgs e)
        {
            if (cityTextBox.Text == "")
            {
                cityTextBox.Text = "City";
                cityTextBox.ForeColor = Color.Gray;
            }
        }

        private void postalCodeTextBox_Enter(object sender, EventArgs e)
        {
            if (postalCodeTextBox.Text == "Postal code")
            {
                postalCodeTextBox.Text = null;
                postalCodeTextBox.ForeColor = Color.Black;
            }
        }

        private void postalCodeTextBox_Leave(object sender, EventArgs e)
        {
            if (postalCodeTextBox.Text == "")
            {
                postalCodeTextBox.Text = "Postal code";
                postalCodeTextBox.ForeColor = Color.Gray;
            }
        }

        private void IDTextBox_Enter(object sender, EventArgs e)
        {
            if (IDTextBox.Text == "ID number")
            {
                IDTextBox.Text = null;
                IDTextBox.ForeColor = Color.Black;
            }
        }

        private void IDTextBox_Leave(object sender, EventArgs e)
        {
            if (IDTextBox.Text == "")
            {
                IDTextBox.Text = "ID number";
                IDTextBox.ForeColor = Color.Gray;
            }
        }

        private void cellNumberTextBox_Enter(object sender, EventArgs e)
        {
            if (cellNumberTextBox.Text == "Cell number")
            {
                cellNumberTextBox.Text = null;
                cellNumberTextBox.ForeColor = Color.Black;
            }
        }

        private void cellNumberTextBox_Leave(object sender, EventArgs e)
        {
            if (cellNumberTextBox.Text == "")
            {
                cellNumberTextBox.Text = "Cell number";
                cellNumberTextBox.ForeColor = Color.Gray;
            }
        }

        private void emailTextBox_Enter(object sender, EventArgs e)
        {
            if (emailTextBox.Text == "Email")
            {
                emailTextBox.Text = null;
                emailTextBox.ForeColor = Color.Black;
            }
        }

        private void emailTextBox_Leave(object sender, EventArgs e)
        {
            if (emailTextBox.Text == "")
            {
                emailTextBox.Text = "Email";
                emailTextBox.ForeColor = Color.Gray;
            }
        }

        private void firtNameTextBox_TextChanged(object sender, EventArgs e)
        {
            firtNameTextBox.BackColor = Color.White;
            label9.Visible = false;
        }

        private void lastNameTextBox_TextChanged(object sender, EventArgs e)
        {
            lastNameTextBox.BackColor = Color.White;
            label9.Visible = false;
        }

        private void addressLine1TextBox_TextChanged(object sender, EventArgs e)
        {
            addressLine1TextBox.BackColor = Color.White;
            label9.Visible = false;
        }

        private void addressLine2TextBox_TextChanged(object sender, EventArgs e)
        {
            addressLine2TextBox.BackColor = Color.White;
            label9.Visible = false;
        }

        private void cityTextBox_TextChanged(object sender, EventArgs e)
        {
            cityTextBox.BackColor = Color.White;
            label9.Visible = false;
        }

        private void postalCodeTextBox_TextChanged(object sender, EventArgs e)
        {
            postalCodeTextBox.BackColor = Color.White;
            label9.Visible = false;
        }

        private void IDTextBox_TextChanged(object sender, EventArgs e)
        {
            IDTextBox.BackColor = Color.White;
            label9.Visible = false;
        }

        private void cellNumberTextBox_TextChanged(object sender, EventArgs e)
        {
            cellNumberTextBox.BackColor = Color.White;
            label9.Visible = false;
        }

        private void emailTextBox_TextChanged(object sender, EventArgs e)
        {
            emailTextBox.BackColor = Color.White;
            label23.Visible = false;
            label22.Visible = false;
            label9.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Enabled = true;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            viewBookingInnerTa.FillByPreference(fullDs.viewBookingInner, textBox2.Text);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            this.Hide();
            f.ShowDialog();
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            this.Hide();
            f.ShowDialog();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            this.Hide();
            f.ShowDialog();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            this.Hide();
            f.ShowDialog();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            this.Hide();
            f.ShowDialog();
            this.Close();
        }


        /*=========================================================================================== Kaygee code END ===========================================================================================*/


        /*================================================================================= Author @Sihle Make Booking Tab ===========================================================================================*/
        string currentCustomerEmailID;

        DateTime dateIn = DateTime.Today;
        DateTime dateOut = DateTime.Today;
        int numberOfNights;
        string bookingMethod = "Admin";
        string bookingStatus = "inComplete";
        double amountDue = 0;

        ArrayList availableSingleRooms = new ArrayList();
        ArrayList availableDoubleRooms = new ArrayList();

        int numberOfSingleRooms = 0;
        int numberOfDoubleRooms = 0;


        private bool bookingIsComplete(string summaryID)
        {
            for (int i = 0; i < fullDs.BookingSummary.Rows.Count; i++)
            {
                if ((fullDs.Tables["BookingSummary"].Rows[i]["summaryID"].ToString().Equals(summaryID)) &&
                   (fullDs.Tables["BookingSummary"].Rows[i]["bookingStatus"].ToString().Equals("Complete")))
                    return true;
            }
            return false;
        }

        private bool isRoomAvailable(int roomID, DateTime dateID)
        {
            for (int i = 0; i < fullDs.BookedRoom.Rows.Count; i++)
            {
                if (((fullDs.Tables["BookedRoom"].Rows[i]["dateID"].ToString().Equals(dateID.ToString())) &&
                   (int.Parse(fullDs.Tables["BookedRoom"].Rows[i]["roomID"].ToString()) == roomID)) &&
                   (bookingIsComplete(fullDs.Tables["BookedRoom"].Rows[i]["summaryID"].ToString())))
                //if the record of the room in bookedRoom is complete then that room is not available
                //however if the booking of that room has been cancelled than that room has to be marked available
                //even though it exist in bookedRoom records
                {
                    return false;
                }
            }
            return true;
        }

        private void updateAvailableRoomList()
        {
            availableSingleRooms = new ArrayList();
            availableDoubleRooms = new ArrayList();

            for (int roomID = 1; roomID <= 15; roomID++)
            {
                bool roomAvailableFlag = true;
                for (DateTime dateID = dateIn; DateTime.Compare(dateID, dateOut) < 0; dateID = dateID.AddDays(1))
                {
                    if (!isRoomAvailable(roomID, dateID))
                    {
                        roomAvailableFlag = false;
                        break;
                    }
                }

                if (roomAvailableFlag)
                {
                    if (roomID <= 7)
                        availableSingleRooms.Add(roomID);
                    else
                        availableDoubleRooms.Add(roomID);
                }
            }
        }

        private string getAmountDue(ComboBox cb1, ComboBox cb2)
        {
            double amountDueForSingleRooms;
            double amountDueForDoubleRooms;
            numberOfNights = dateOut.Subtract(dateIn).Days;
            if (numberOfNights == 0)
                numberOfNights++;

            if (cb1.SelectedItem == null || cb1.SelectedItem.ToString() == "0")
            {
                amountDueForSingleRooms = 0.0;
            }
            else
            {
                numberOfSingleRooms = int.Parse(cb1.SelectedItem.ToString());
                amountDueForSingleRooms = (numberOfSingleRooms * 450 * numberOfNights);
            }
            if (cb2.SelectedItem == null || cb2.SelectedItem.ToString() == "0")
            {
                amountDueForDoubleRooms = 0.0;
            }
            else
            {
                numberOfDoubleRooms = int.Parse(cb2.SelectedItem.ToString());
                amountDueForDoubleRooms = (numberOfDoubleRooms * 800 * numberOfNights);
            }
            amountDue = amountDueForSingleRooms + amountDueForDoubleRooms;
            return "R " + amountDue.ToString() + ".00";
        }

        private void loadAvailableSinlges(ComboBox cb)
        {

            cb.Items.Clear();
            cb.Items.Add("0");
            for (int i = 0; i < availableSingleRooms.Count; i++)
                cb.Items.Add(i + 1 + "");
        }

        private void loadAvailableDoubles(ComboBox cb)
        {
            cb.Items.Clear();
            cb.Items.Add("0");
            for (int i = 0; i < availableDoubleRooms.Count; i++)
                cb.Items.Add(i + 1 + "");
        }

        private bool dateIsValid()
        {
            if (((DateTime.Compare(DateTime.Today, dateIn) <= 0) && (DateTime.Compare(DateTime.Today, dateOut) < 0) && (DateTime.Compare(dateIn, dateOut) < 0)))
                return true;
            return false;
        }

        private void updateBookingSummary(string callAmountDueMethod)
        {
            int[] singleAllocatedRooms = new int[numberOfSingleRooms];
            int[] doubleAllocatedRooms = new int[numberOfDoubleRooms];

            bookingSummaryTa.Insert(currentCustomerEmailID, dateIn, dateOut, numberOfNights, bookingMethod, bookingStatus, callAmountDueMethod);
            int summaryID = (int)bookingSummaryTa.getLastRecord();
            currentBooking.setSummaryID(summaryID);

            for (int i = 0; i < numberOfSingleRooms; i++) //adding single rooms to bookedRoom table
            {
                for (DateTime dateID = dateIn; DateTime.Compare(dateID, dateOut) < 0; dateID = dateID.AddDays(1))
                {
                    singleAllocatedRooms[i] = (int)availableSingleRooms[i];
                }
            }

            for (int i = 0; i < numberOfDoubleRooms; i++) //adding double rooms to bookedRoom table
            {
                for (DateTime dateID = dateIn; DateTime.Compare(dateID, dateOut) < 0; dateID = dateID.AddDays(1)) //adding double rooms to bookedRoom table
                {
                    doubleAllocatedRooms[i] = (int)availableDoubleRooms[i];
                }
            }

            int[] allAllocatedRooms = new int[singleAllocatedRooms.Length + doubleAllocatedRooms.Length];
            Array.Copy(singleAllocatedRooms, allAllocatedRooms, singleAllocatedRooms.Length);
            Array.Copy(doubleAllocatedRooms, 0, allAllocatedRooms, singleAllocatedRooms.Length, doubleAllocatedRooms.Length);
            currentBooking.setRoomIDs(allAllocatedRooms);

            this.bookingSummaryTa.Update(this.fullDs.BookingSummary);
            this.bookingSummaryTa.Fill(this.fullDs.BookingSummary);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateIn = dateTimePicker1.Value.Date;
            dateOut = dateTimePicker2.Value.Date;
            if (dateIsValid())
            {
                label24.Visible = false;
                comboBox1.Enabled = true;
                comboBox2.Enabled = true;
                updateAvailableRoomList();
                loadAvailableSinlges(this.comboBox1);
                loadAvailableDoubles(this.comboBox2);
            }
            else
            {
                label24.Visible = true;
                comboBox1.Enabled = false;
                comboBox2.Enabled = false;
            }
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            dateIn = dateTimePicker1.Value.Date;
            dateOut = dateTimePicker2.Value.Date;
            label24.Visible = false;
            if (dateIsValid())
            {
                label24.Visible = false;
                comboBox1.Enabled = true;
                comboBox2.Enabled = true;
                updateAvailableRoomList();
                loadAvailableSinlges(this.comboBox1);
                loadAvailableDoubles(this.comboBox2);
            }
            else
            {
                label24.Visible = true;
                comboBox1.Enabled = false;
                comboBox2.Enabled = false;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox5.Text = getAmountDue(comboBox1, comboBox2);
            numberOfSingleRooms = int.Parse(comboBox1.SelectedItem.ToString());
            if (amountDue != 0)
                button8.Enabled = true;
            else
                button8.Enabled = false;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox5.Text = getAmountDue(comboBox1, comboBox2);
            numberOfDoubleRooms = int.Parse(comboBox2.SelectedItem.ToString());
            if (amountDue != 0)
                button8.Enabled = true;
            else
                button8.Enabled = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            updateBookingSummary(getAmountDue(comboBox1, comboBox2).ToString());
            comboBox1.Enabled = false;
            comboBox2.Enabled = false;
            button9.Enabled = true;
            button8.Enabled = false;
            dateTimePicker1.Enabled = false;
            dateTimePicker2.Enabled = false;
            this.bookingSummaryTa.Fill(this.fullDs.BookingSummary);
            this.bookingSummaryTa.Update(this.fullDs.BookingSummary);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            currentUser.setEmailID(currentCustomerEmailID);
            PaymentForm payment = new PaymentForm();
            //this.Hide();
            payment.ShowDialog();
            //this.Close();

            label33.Visible = false;
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            customerTa.FillByAnythingGiven(fullDs.Customer, textBox3.Text);
            customerDataGridView.ClearSelection();
            panel5.Enabled = false;
            label33.Visible = false;

        }

        private void button10_Click(object sender, EventArgs e)
        {
            panel5.Enabled = true;
            dateTimePicker1.Enabled = true;
            dateTimePicker2.Enabled = true;
        }

        private void tabPage6_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void customerDataGridView_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            currentCustomerEmailID = customerDataGridView.CurrentRow.Cells[0].Value.ToString();
            label33.Text = "To Process Booking for: " + customerDataGridView.CurrentRow.Cells[1].Value.ToString() + " " + customerDataGridView.CurrentRow.Cells[2].Value.ToString() + " (" + customerDataGridView.CurrentRow.Cells[0].Value.ToString() + ")";
            label33.Visible = true;
            button10.Enabled = true;
        }

        private void customerDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bookingInnerDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {

            customerDataGridView.ClearSelection();
            textBox3.Clear();
            label24.Visible = false;
            label33.Visible = false;
            panel5.Enabled = false;
            textBox5.Clear();
            button10.Enabled = false;

            dateTimePicker1.Value = DateTime.Today;
            dateTimePicker2.Value = DateTime.Today;

            bookingSummaryTa.Fill(fullDs.BookingSummary);
            bookedRoomTa.Fill(fullDs.BookedRoom);
        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        //=============================================================== Author @Sihle Modify Booking Tab ==============================================

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            modifyBookingInnerTa.FillByAnythingGiven(this.fullDs.ModifyBookingInner, textBox4.Text);
        }

        private void label37_Click(object sender, EventArgs e)
        {

        }

        private void adminForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fullDs.ModifyBookingInner' table. You can move, or remove it, as needed.
            this.modifyBookingInnerTa.Fill(this.fullDs.ModifyBookingInner);
        }

        private void modifyBookingInnerDataGridView_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            currentCustomerEmailID = modifyBookingInnerDataGridView.CurrentRow.Cells[0].Value.ToString();
            label36.Text = "To Modify Booking for: " + modifyBookingInnerDataGridView.CurrentRow.Cells[1].Value.ToString() + " " + modifyBookingInnerDataGridView.CurrentRow.Cells[2].Value.ToString() + " (" + modifyBookingInnerDataGridView.CurrentRow.Cells[0].Value.ToString() + " - Booking Ref: " + modifyBookingInnerDataGridView.CurrentRow.Cells[4].Value.ToString() + ")";
            label36.Visible = true;
            button13.Enabled = true;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            panel8.Enabled = true;
            dateTimePicker3.Enabled = true;
            dateTimePicker4.Enabled = true;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            updateBookingSummary(getAmountDue(comboBox3, comboBox4).ToString());
            comboBox3.Enabled = false;
            comboBox4.Enabled = false;
            button15.Enabled = true;
            button14.Enabled = false;
            dateTimePicker3.Enabled = false;
            dateTimePicker4.Enabled = false;
            this.bookingSummaryTa.Fill(this.fullDs.BookingSummary);
            this.bookingSummaryTa.Update(this.fullDs.BookingSummary);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            customerDataGridView.ClearSelection();
            textBox6.Clear();
            label36.Visible = false;
            panel8.Enabled = false;
            textBox4.Clear();
            button13.Enabled = false;

            dateTimePicker3.Value = DateTime.Today;
            dateTimePicker4.Value = DateTime.Today;
        }

        private void dateTimePicker3_ValueChanged(object sender, EventArgs e)
        {
            dateIn = dateTimePicker3.Value.Date;
            if (dateIsValid())
            {
                label39.Visible = false;
            }
            else
            {
                comboBox3.Enabled = false;
                comboBox4.Enabled = false;
            }
        }

        private void dateTimePicker4_ValueChanged(object sender, EventArgs e)
        {
            dateOut = dateTimePicker4.Value.Date;
            label39.Visible = false;
            if (dateIsValid())
            {
                comboBox3.Enabled = true;
                comboBox4.Enabled = true;
                updateAvailableRoomList();
                loadAvailableSinlges(comboBox3);
                loadAvailableDoubles(comboBox4);
                label39.Visible = false;
            }
            else
            {
                label39.Visible = true;
                comboBox3.Enabled = false;
                comboBox4.Enabled = false;
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox6.Text = getAmountDue(comboBox3, comboBox4).ToString();
            numberOfSingleRooms = int.Parse(comboBox3.SelectedItem.ToString());
            if (amountDue != 0)
                button14.Enabled = true;
            else
                button14.Enabled = false;
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox6.Text = getAmountDue(comboBox3, comboBox4).ToString();
            numberOfDoubleRooms = int.Parse(comboBox4.SelectedItem.ToString());
            if (amountDue != 0)
                button14.Enabled = true;
            else
                button14.Enabled = false;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            currentUser.setEmailID(currentCustomerEmailID);
            PaymentForm payment = new PaymentForm();
            //this.Hide();
            payment.ShowDialog();
            //this.Close();

            label36.Visible = false;
        }

        private void dataGridView3_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataRow dataRow = fullDs1.Customer1.NewRow();
            for (int i = 0; i < dataRow.ItemArray.Length; i++)
            {
                dataRow[i] = dataGridView3.CurrentRow.Cells[i].Value;
            }
            label55.Visible = false;
            label56.Visible = false;
            updateTextBox(textBox7, dataRow[0].ToString());
            updateTextBox(textBox17, dataRow[1].ToString());
            updateTextBox(textBox16, dataRow[2].ToString());
            updateTextBox(textBox15, dataRow[5].ToString());
            updateTextBox(textBox14, dataRow[6].ToString());
            updateTextBox(textBox13, dataRow[7].ToString());
            updateTextBox(textBox11, dataRow[8].ToString());
            updateTextBox(textBox12, dataRow[3].ToString());
            updateTextBox(textBox10, dataRow[4].ToString());
        }
        private void updateTextBox(TextBox textBox, string s)
        {
            textBox.Text = s;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox7.Text = "";
            textBox17.Text = "";
            textBox16.Text = "";
            textBox15.Text = "";
            textBox14.Text = "";
            textBox13.Text = "";
            textBox11.Text = "";
            textBox12.Text = "";
            textBox10.Text = "";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (textBox7.Text != "")
            {
                label55.Visible = false;
                for (int i = 0; i < fullDs.Customer1.Rows.Count; i++)
                {
                    if (fullDs.Customer1[i].Email_Address.Equals(textBox7.Text, StringComparison.OrdinalIgnoreCase))
                    {
                        fullDs.Customer[i].name = textBox17.Text;
                        fullDs.Customer[i].surname = textBox16.Text;
                        fullDs.Customer[i].streetName = textBox15.Text;
                        fullDs.Customer[i].suburb = textBox14.Text;
                        fullDs.Customer[i].city = textBox13.Text;
                        fullDs.Customer[i].postalCode = textBox11.Text;
                        fullDs.Customer[i].idNumber = textBox12.Text;
                        fullDs.Customer[i].cellNumber = textBox10.Text;
                        customerTa.Update(fullDs.Customer[i]);
                        customer1Ta1.Update(fullDs.Customer1[i]);
                        customer1Ta1.Fill(fullDs.Customer1);
                        label56.Visible = true;
                        break;
                    }
                }
            }
            else
            {
                label55.Visible = true;
                label56.Visible = false;
            }
            textBox7.Text = "";
            textBox17.Text = "";
            textBox16.Text = "";
            textBox15.Text = "";
            textBox14.Text = "";
            textBox13.Text = "";
            textBox11.Text = "";
            textBox12.Text = "";
            textBox10.Text = "";
        }
        private bool updateNameIsValid()
        {
            /*int count = 0;
            if (!isAllLetters(textBox1.Text) || textBox1.Text.Length < 3)
            {
                textBox1.BackColor = Color.Red;
                count++;
            }
            if (!isAllLetters(textBox2.Text) || textBox2.Text.Length < 3)
            {
                textBox2.BackColor = Color.Red;
                count++;
            }
            return count == 0;*/
            return true;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            this.Hide();
            f.ShowDialog();
            this.Close();
        }

        private void dataGridView3_RowHeaderMouseDoubleClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataRow dataRow = fullDs1.Customer1.NewRow();
            for (int i = 0; i < dataRow.ItemArray.Length; i++)
            {
                dataRow[i] = dataGridView3.CurrentRow.Cells[i].Value;
            }
            label55.Visible = false;
            label56.Visible = false;
            updateTextBox(textBox7, dataRow[0].ToString());
            updateTextBox(textBox17, dataRow[1].ToString());
            updateTextBox(textBox16, dataRow[2].ToString());
            updateTextBox(textBox15, dataRow[5].ToString());
            updateTextBox(textBox14, dataRow[6].ToString());
            updateTextBox(textBox13, dataRow[7].ToString());
            updateTextBox(textBox11, dataRow[8].ToString());
            updateTextBox(textBox12, dataRow[3].ToString());
            updateTextBox(textBox10, dataRow[4].ToString());
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
