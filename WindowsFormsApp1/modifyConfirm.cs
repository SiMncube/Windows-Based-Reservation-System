﻿using System;
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
    public partial class ModifyConfirm : Form
    {
        private decimal finalAmountDue;
        public ModifyConfirm(decimal finalAmount)
        {
            InitializeComponent();
            this.finalAmountDue = finalAmount;
            bookingSummaryTa.Fill(fullDs.BookingSummary);
            customerTa.Fill(fullDs.Customer);
            setDateIn();
            setDateOut();
            setName();
            setPrices();
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
            for (int i = 0; i < amountDue.Length; i++)
            {
                if (amountDue[i] == '.')
                    break;
                temp += amountDue[i];
            }
            return decimal.Parse(temp);
        }
        private void setPrices()
        {
            for (int i = fullDs.BookingSummary.Rows.Count - 1; i >= 0; i--)
            {
                if (fullDs.BookingSummary[i].summaryID == currentBooking.getSummaryID())
                {
                    label17.Text = fullDs.BookingSummary[i].numberOfNights + "";
                    label19.Text = "R " + (getAmountDue() / fullDs.BookingSummary[i].numberOfNights) + ".00";
                    label21.Text = fullDs.BookingSummary[i].amountDue;
                    if (finalAmountDue <= 0)
                        label23.Text = "R " + (finalAmountDue * -1) + ".00";
                    else
                    {
                        label22.Text = "Amount Due";
                        label22.ForeColor = Color.Red;
                        label23.Text = "-R " + (finalAmountDue) + ".00";
                        label23.ForeColor = Color.Red;
                    }
                    break;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*//if(finalAmountDue > 0) //commented out by Sihle, i wanted to reach payment form for all case including refund case, so i could be able to send the invoice
            //{
                PaymentForm p = new PaymentForm();
                this.Hide();
                p.ShowDialog();
            //}  */
            PaymentForm p = new PaymentForm();
            for (int index = Application.OpenForms.Count - 1; index >= 0; index--)
            {
                if (Application.OpenForms[index].Name == "MakebookingForm" || Application.OpenForms[index].Name == "adminForm")
                {
                    Application.OpenForms[index].Hide();
                    Application.OpenForms[index].Close();
                }
            }
            this.Hide();
            p.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
