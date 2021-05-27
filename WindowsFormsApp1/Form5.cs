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

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double amountDueForSingleRooms;
            double amountDueForDoubleRooms;

            dateIn = dateTimePicker1.Value.Date;
            dateOut = dateTimePicker2.Value.Date;
            numberOfNights = dateOut.Subtract(dateIn).Days;

            try
            {
                int numberOfSingleRooms = int.Parse(textBox3.Text);
                int numberOfDoubleRooms = int.Parse(textBox4.Text);

                amountDueForSingleRooms = (numberOfSingleRooms * double.Parse(roomTypeTableAdapter.getSingleRoomPrice())) * numberOfNights;
                amountDueForDoubleRooms = (numberOfDoubleRooms * double.Parse((string)roomTypeTableAdapter.getDoubleRoomPrice())) * numberOfNights;

                amountDue = amountDueForSingleRooms + amountDueForDoubleRooms;
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid input", "Error");
            }

            bookingSummaryTableAdapter.Insert("test101", dateIn, dateOut, numberOfNights, bookingMethod, bookingStatus, amountDue.ToString());
            textBox1.Text = amountDue.ToString("C");

            string user = currentUser.getEmailID();
            int summaryID = int.Parse((string)bookingSummaryTableAdapter.getLastRecordID());
            //if (currentUser.getEmailID.Equals("2160"))
            //   bookingMethod = "Admin - Sihle";


            //------------------------------------------------adding booking to to booked room record.

            //checking room availability
            ArrayList availableSingleRooms = new ArrayList();
            ArrayList availableDoubleRooms = new ArrayList();

            /*conditions that must be true for a valid date input
            DateTime.Compare(DateTime.Today, dateIn) <= 0
            DateTime.Compare(DateTime.Today, dateOut) < 0
            DateTime.Compare(dateIn, dateOut) < 0
            */

            bookedRoomTableAdapter.
            //available single rooms
            int numberOfRecordsInBookedRoom = (int)bookedRoomTableAdapter.numberOfRecords();
            for (int roomID = 1; roomID <= 7; roomID++)
            {
                bool isRoomAvailable = true;
                for (DateTime dateID = dateIn; DateTime.Compare(dateID, dateOut) < 0; dateID.AddDays(1))
                {
                    for (int i = 1; i <= numberOfRecordsInBookedRoom; i++)
                    {
                        if()
                        if (bookedRoomTableAdapter.hasBoth(roomID,dateID) > 0) //the has both method returns the roomID if the record exists
                            isRoomAvailable = false;
                    }
                    if (!isRoomAvailable)
                        break;
                }
                availableSingleRooms.Add(roomID);
            }

            MessageBox.Show("Number of Available Single Rooms: " + availableSingleRooms.Count +
                "\nNumber of Available Double Rooms:" + availableDoubleRooms.Count, "Available Rooms");
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
            Form7 payment = new Form7();
            this.Hide();
            payment.ShowDialog();
            this.Show();
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

    }
}
