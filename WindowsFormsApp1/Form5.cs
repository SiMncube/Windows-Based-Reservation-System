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
        DateTime dateIn;
        DateTime dateOut;
        int numberOfNights;
        string bookingMethod = "Online";
        string bookingStatus = "inComplete";
        double amountDue = 0;

        ArrayList availableSingleRooms = new ArrayList();
        ArrayList availableDoubleRooms = new ArrayList();

        int numberOfSingleRooms = 0;
        int numberOfDoubleRooms = 0;

        private void ChangeColor(TextBox textBox)
        {
            textBox.BackColor = Color.Red;
        }
        private bool isDigit(char ch)
        {
            if (ch >= '0' && ch <= '9')
                return true;
            return false;
        }
        private bool isAllDigit(TextBox textbox)
        {
            string s = textbox.Text.ToString();
            for (int i = 0; i < s.Length; i++)
            {
                if (!isDigit(s[i]))
                    return false;
            }
            return true;
        }

        public Form5()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void updateAvailableRoomList()
        {
            availableSingleRooms.Clear();
            availableDoubleRooms.Clear();

            int numberOfRecordsInBookedRoom = (int)bookedRoomTableAdapter.numberOfRecords();
            for (int roomID = 1; roomID <= 15; roomID++)
            {
                bool isRoomAvailable = true;
                for (DateTime dateID = dateIn; DateTime.Compare(dateID, dateOut) < 0; dateID = dateID.AddDays(1))
                {
                    for (int i = 0; i < numberOfRecordsInBookedRoom; i++)
                    {
                        if ((fullDatabase.Tables["BookedRoom"].Rows[i]["dateID"].ToString().Equals(dateID.ToString())) &&
                           (int.Parse(fullDatabase.Tables["BookedRoom"].Rows[i]["roomID"].ToString()) == roomID))
                        {
                            isRoomAvailable = false;
                            break;
                        }
                    }
                    if (!isRoomAvailable)
                        break;
                }

                if (isRoomAvailable)
                {
                    if (roomID <= 7)
                        availableSingleRooms.Add(roomID);
                    else
                        availableDoubleRooms.Add(roomID);
                }
            }
        }

        private void updateAmountDue()
        {
            double amountDueForSingleRooms;
            double amountDueForDoubleRooms;

            if (isAllDigit(textBox3) && !textBox3.Text.Equals(""))
            {
                numberOfSingleRooms = int.Parse(textBox3.Text);
                amountDueForSingleRooms = (numberOfSingleRooms * 450 * numberOfNights);
            }
            else
            {
                ChangeColor(textBox3);
                amountDueForSingleRooms = 0;
            }

            if (isAllDigit(textBox4) && !textBox4.Text.Equals(""))
            {
                numberOfDoubleRooms = int.Parse(textBox4.Text);
                amountDueForDoubleRooms = (numberOfDoubleRooms * 800 * numberOfNights);
            }
            else
            {
                ChangeColor(textBox4);
                amountDueForDoubleRooms = 0;
            }

            amountDue = amountDueForSingleRooms + amountDueForDoubleRooms;
            textBox1.Text = "R" + amountDue.ToString() + ".00";
        }

        private bool DoWeHaveSuffientRooms()
        {
            //Checking Number of rooms input then allowing the user to check if all Input Is Valid
            //and the requested number of rooms if they are available in the specified period

            if (numberOfSingleRooms > availableSingleRooms.Count)
            {
                label10.Text = "Appologies We now Have: " + availableSingleRooms.Count + "Single Rooms";
                label10.Visible = true;
                return false;
            }
            if (numberOfDoubleRooms > availableDoubleRooms.Count)
            {
                label11.Text = "Appologies We now have: " + availableDoubleRooms.Count + "Double Rooms";
                label11.Visible = true;
                return false;
            }

            return true;
        }

        private void button4_Click(object sender, EventArgs e)
        {

            dateIn = dateTimePicker1.Value.Date;
            dateOut = dateTimePicker2.Value.Date;
            numberOfNights = dateOut.Subtract(dateIn).Days;

            //checking room availability, and validating date input
            if (((DateTime.Compare(DateTime.Today, dateIn) <= 0) && (DateTime.Compare(DateTime.Today, dateOut) < 0) && (DateTime.Compare(dateIn, dateOut) < 0)))
            {
                this.updateAvailableRoomList();

                if (DoWeHaveSuffientRooms() && !(numberOfSingleRooms == 0 && numberOfDoubleRooms == 0))
                {
                    this.updateAmountDue();
                    button1.Enabled = true;     //checking out button
                }
            }
            else
                label7.Visible = true;   //selected date is invalid label

            textBox5.Text = "Singles: " + availableSingleRooms.Count + ", Doubles: " + availableDoubleRooms.Count;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label7.Visible = false;


            //adding booking to array that would be to an array that would be processed for payments
            if (numberOfSingleRooms <= availableSingleRooms.Count && numberOfDoubleRooms <= availableDoubleRooms.Count)
            {
                int[] singleAllocatedRooms = new int[numberOfSingleRooms];
                int[] doubleAllocatedRooms = new int[numberOfDoubleRooms];

                bookingSummaryTableAdapter.Insert(currentUser.getEmailID(), dateIn, dateOut, numberOfNights, bookingMethod, bookingStatus, amountDue.ToString());
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


                //testing code for checking allocated rooms
                string sss = "";

                for (int i = 0; i < allAllocatedRooms.Length; i++)
                {
                    sss += allAllocatedRooms[i] + ", ";
                }
                textBox2.Text = sss;
            }

            Form7 payment = new Form7();
            this.Hide();
            payment.ShowDialog();
            this.Show();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fullDatabase.Payment' table. You can move, or remove it, as needed.
            this.paymentTableAdapter.Fill(this.fullDatabase.Payment);
            // TODO: This line of code loads data into the 'fullDatabase.BookedRoom' table. You can move, or remove it, as needed.
            this.bookedRoomTableAdapter.Fill(this.fullDatabase.BookedRoom);
            // TODO: This line of code loads data into the 'fullDatabase.BookingSummary' table. You can move, or remove it, as needed.
            this.bookingSummaryTableAdapter.Fill(this.fullDatabase.BookingSummary);

        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged_1(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.bookingSummaryTableAdapter.Fill(this.fullDatabase.BookingSummary);
            this.bookedRoomTableAdapter.Fill(this.fullDatabase.BookedRoom);
            this.paymentTableAdapter.Fill(this.fullDatabase.Payment);
        }

        private void dataGridView1_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bookingSummaryBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void bookingSummaryBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bookingSummaryBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.fullDatabase);

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click_1(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click_1(object sender, EventArgs e)
        {

        }
    }
}
