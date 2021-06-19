using System;
using System.Collections;
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
    public partial class Form5 : Form
    {
        DateTime dateIn = DateTime.Today;
        DateTime dateOut = DateTime.Today;
        int numberOfNights;
        string bookingMethod = "Online";
        string bookingStatus = "inComplete";
        double amountDue = 0;

        ArrayList availableSingleRooms = new ArrayList();
        ArrayList availableDoubleRooms = new ArrayList();

        int numberOfSingleRooms = 0;
        int numberOfDoubleRooms = 0;

        public Form5()
        {
            InitializeComponent();
            this.bookingSummaryTableAdapter.Fill(this.fullDatabase.BookingSummary);
            this.bookedRoomTableAdapter.Fill(this.fullDatabase.BookedRoom);
            this.paymentTableAdapter.Fill(this.fullDatabase.Payment);
            this.customerTableAdapter1.Fill(this.fullDatabase.Customer);
            string userName = "";
            for (int i = 0; i < fullDatabase.Customer.Rows.Count; i++)
            {
                if (fullDatabase.Customer[i].emailID.Equals(currentUser.getEmailID()))
                {
                    userName += fullDatabase.Customer[i].surname + " " + fullDatabase.Customer[i].name;
                    break;
                }

            }
            label6.Text += userName;
        }

        private bool bookingIsComplete(string summaryID)
        {
            for (int i = 0; i < fullDatabase.BookingSummary.Rows.Count; i++)
            {
                if ((fullDatabase.Tables["BookingSummary"].Rows[i]["summaryID"].ToString().Equals(summaryID)) &&
                   (fullDatabase.Tables["BookingSummary"].Rows[i]["bookingStatus"].ToString().Equals("Complete")))
                    return true;
            }
            return false;
        }

        private bool isRoomAvailable(int roomID, DateTime dateID)
        {   
            //int numberOfRecordsInBookedRoom = fullDatabase.BookedRoom.Rows.Count;
            for (int i = 0; i < fullDatabase.BookedRoom.Rows.Count; i++)
            {
                if (((fullDatabase.Tables["BookedRoom"].Rows[i]["dateID"].ToString().Equals(dateID.ToString())) &&
                   (int.Parse(fullDatabase.Tables["BookedRoom"].Rows[i]["roomID"].ToString()) == roomID)) &&
                   (bookingIsComplete(fullDatabase.Tables["BookedRoom"].Rows[i]["summaryID"].ToString())))
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

        private string getAmountDue()
        {
            double amountDueForSingleRooms;
            double amountDueForDoubleRooms;
            numberOfNights = dateOut.Subtract(dateIn).Days;
            if (numberOfNights == 0)
                numberOfNights++;

            if (comboBox1.SelectedItem == null || comboBox1.SelectedItem.ToString() == "0")
            {
                amountDueForSingleRooms = 0.0;
            }
            else
            {
                numberOfSingleRooms = int.Parse(comboBox1.SelectedItem.ToString());
                amountDueForSingleRooms = (numberOfSingleRooms * 450 * numberOfNights);
            }
            if (comboBox2.SelectedItem == null || comboBox2.SelectedItem.ToString() == "0")
            {
                amountDueForDoubleRooms = 0.0;
            }
            else
            {
                numberOfDoubleRooms = int.Parse(comboBox2.SelectedItem.ToString());
                amountDueForDoubleRooms = (numberOfDoubleRooms * 800 * numberOfNights);
            }
            amountDue = amountDueForSingleRooms + amountDueForDoubleRooms;
            return "R " + amountDue.ToString() + ".00";
        }

        private void loadAvailableSinlges()
        {

            comboBox1.Items.Clear();
            comboBox1.Items.Add("0");
            for (int i = 0; i < availableSingleRooms.Count; i++)
                comboBox1.Items.Add(i + 1 + "");
        }

        private void loadAvailableDoubles()
        {
            comboBox2.Items.Clear();
            comboBox2.Items.Add("0");
            for (int i = 0; i < availableDoubleRooms.Count; i++)
                comboBox2.Items.Add(i + 1 + "");
        }

        private bool dateIsValid()
        {
            if (((DateTime.Compare(DateTime.Today, dateIn) <= 0) && (DateTime.Compare(DateTime.Today, dateOut) < 0) && (DateTime.Compare(dateIn, dateOut) < 0)))
                return true;
            return false;
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            this.Close();
            Form8 form = new Form8();
            form.ShowDialog();
        }

        private void updateBookingSummary()
        {
            int[] singleAllocatedRooms = new int[numberOfSingleRooms];
            int[] doubleAllocatedRooms = new int[numberOfDoubleRooms];

            bookingSummaryTableAdapter.Insert(currentUser.getEmailID(), dateIn, dateOut, numberOfNights, bookingMethod, bookingStatus, getAmountDue().ToString());
            int summaryID = (int)bookingSummaryTableAdapter.getLastRecord();
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
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateIn = dateTimePicker1.Value.Date;
            dateOut = dateTimePicker2.Value.Date;
            if (dateIsValid())
            {
                label7.Visible = false;
                comboBox1.Enabled = true;
                comboBox2.Enabled = true;
                updateAvailableRoomList();
                loadAvailableSinlges();
                loadAvailableDoubles();
            }
            else
            {
                label7.Visible = true;
                comboBox1.Enabled = false;
                comboBox2.Enabled = false;
            }

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            dateIn = dateTimePicker1.Value.Date;
            dateOut = dateTimePicker2.Value.Date;
            label7.Visible = false;
            if (dateIsValid())
            {
                label7.Visible = false;
                comboBox1.Enabled = true;
                comboBox2.Enabled = true;
                updateAvailableRoomList();
                loadAvailableSinlges();
                loadAvailableDoubles();
            }
            else
            {
                label7.Visible = true;
                comboBox1.Enabled = false;
                comboBox2.Enabled = false;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox5.Text = getAmountDue();
            numberOfSingleRooms = int.Parse(comboBox1.SelectedItem.ToString());
            if (amountDue != 0)
                button4.Enabled = true;
            else
                button4.Enabled = false;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox5.Text = getAmountDue();
            numberOfDoubleRooms = int.Parse(comboBox2.SelectedItem.ToString());
            if (amountDue != 0)
                button4.Enabled = true;
            else
                button4.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            updateBookingSummary();
            comboBox1.Enabled = false;
            comboBox2.Enabled = false;
            button1.Enabled = true;
            button4.Enabled = false;
            dateTimePicker1.Enabled = false;
            dateTimePicker2.Enabled = false;
            this.bookingSummaryTableAdapter.Fill(this.fullDatabase.BookingSummary);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PaymentForm payment = new PaymentForm();
            this.Hide();
            payment.ShowDialog();
            this.Close();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
