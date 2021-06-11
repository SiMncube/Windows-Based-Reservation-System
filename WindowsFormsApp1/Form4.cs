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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            bookingSummaryTableAdapter.Fill(fullDatabase.BookingSummary);
            paymentTableAdapter1.Fill(fullDatabase.Payment);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fullDatabase.BookingSummary' table. You can move, or remove it, as needed.
            this.bookingSummaryTableAdapter.Fill(this.fullDatabase.BookingSummary);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (bookingIsCancelled(textBox1.Text))
            {
                label5.Visible = true;
                label7.Visible = false;
                label4.Visible = false;
                label6.Visible = false;
                label8.Visible = false;
            }
            else if(bookingIsIncomplete(textBox1.Text))
            {
                label5.Visible = false;
                label7.Visible = false;
                label4.Visible = false;
                label6.Visible = false;
                label8.Visible = true;
            }
            else if(bookingExist(textBox1.Text))
            {
                label4.Visible = true;
                label6.Visible = true;
                label7.Visible = false;
                label5.Visible = false;
                label8.Visible = false;
            }
            else
            {
                label7.Visible = true;
                label4.Visible = false;
                label6.Visible = false;
                label5.Visible = false;
                label8.Visible = false;
            }
        }
        private bool bookingExist(string summaryID)
        {
            for (int i = 0; i < fullDatabase.BookingSummary.Rows.Count; i++)
            {
                if (fullDatabase.Tables["BookingSummary"].Rows[i]["summaryID"].ToString() == summaryID)
                {
                    if (fullDatabase.BookingSummary[i].dateIn.CompareTo(DateTime.Today.Date) < 0)
                        return false;
                    fullDatabase.Tables["BookingSummary"].Rows[i]["bookingStatus"] = "Cancelled";
                    bookingSummaryTableAdapter.Update(fullDatabase.BookingSummary);
                    processRefund(summaryID);
                    return true;
                }
            }
            return false;
        }
        private string calculateAmountDue(string s)
        {
            s = s.Substring(2, s.Length - 5);
            double due = double.Parse(s) * 0.5;
            return due + "";
        }
        private void processRefund(string summaryID)
        {
            for (int i = 0; i < fullDatabase.Payment.Rows.Count; i++)
            {
                if (fullDatabase.Tables["Payment"].Rows[i]["summaryID"].ToString() == summaryID)
                {
                    string newAmount = calculateAmountDue(fullDatabase.Tables["Payment"].Rows[i]["amountDue"].ToString());
                    string typeOfPayment = fullDatabase.Tables["Payment"].Rows[i]["typeOfPayment"].ToString();
                    paymentTableAdapter1.Insert(DateTime.Today, "-R"+newAmount, int.Parse(summaryID), typeOfPayment);
                    label6.Text += "R " + newAmount;
                    paymentTableAdapter1.Fill(fullDatabase.Payment);
                    break;
                }
            }
        }
        private bool bookingIsCancelled(string summaryID)
        {
            for (int i = 0; i < fullDatabase.BookingSummary.Rows.Count; i++)
            {
                if (fullDatabase.Tables["BookingSummary"].Rows[i]["summaryID"].ToString() == summaryID)
                {
                    if (fullDatabase.Tables["BookingSummary"].Rows[i]["bookingStatus"].ToString().Equals("Cancelled"))
                        return true;
                    return false;
                }
            }
            return false;
        }
        private bool bookingIsIncomplete(string summaryID)
        {
            for (int i = 0; i < fullDatabase.BookingSummary.Rows.Count; i++)
            {
                if (fullDatabase.Tables["BookingSummary"].Rows[i]["summaryID"].ToString() == summaryID)
                {
                    if (fullDatabase.Tables["BookingSummary"].Rows[i]["bookingStatus"].ToString().Equals("inComplete"))
                        return true;
                    return false;
                }
            }
            return false;
        }
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
