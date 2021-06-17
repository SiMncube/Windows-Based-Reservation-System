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
    public partial class managerForm : Form
    {
        public managerForm()
        {
            InitializeComponent();
            this.bookingSummaryTableAdapter.Fill(fullDatabase.BookingSummary);
            // this.paymentTableAdapter.Fill(fullDatabase.Payment);
            //Complete Vs Incomplete
            int countComplete=0;
            int countIncomplete = 0;
            
            for(int i = 0; i < fullDatabase.BookingSummary.Rows.Count; i++)
            {
                if (fullDatabase.BookingSummary[i].bookingStatus.Equals("Complete"))
                {
                    countComplete++;
                }
                else if (fullDatabase.BookingSummary[i].bookingStatus.Equals("inComplete")){
                    countIncomplete++;
                }

                
            }
            
            double paid = countComplete;
            double unpaid = countIncomplete;

            
            if (paid > 0)
            {
                chart1.Series["Series1"].Points.AddXY("Complete", paid);
            }
            if (unpaid > 0)
            {
                chart1.Series["Series1"].Points.AddXY("InComplete", unpaid);
            }

           





            //Admin VS Online
            int countAdmin = 0;
            int countOnline = 0;
            for (int i = 0; i < fullDatabase.BookingSummary.Rows.Count; i++)
            {
                if (fullDatabase.BookingSummary[i].bookingMethod.Equals("Admin"))
                {
                    countAdmin++;
                }
                else if (fullDatabase.BookingSummary[i].bookingMethod.Equals("Online"))
                {
                    countOnline++;
                }


            }
            double admin = countAdmin;
            double online = countOnline;

            if (admin > 0)
            {
                chart3.Series["Series3"].Points.AddXY("Admin", admin);
            }
            if (online>0){
                chart3.Series["Series3"].Points.AddXY("Online", online);
            }
            



            //AMOUNT PAID PER MONTH
            double sum1=0;
            double sum2 = 0;
            double sum3 = 0;
            double sum4 = 0;
            double sum5 = 0;
            double sum6 = 0;
            double sum7 = 0;
            double sum8 = 0;
            double sum9 = 0;
            double sum10 = 0;
            double sum11 = 0;
            double sum12 = 0;

            for (int i = 0; i < fullDatabase.BookingSummary.Rows.Count; i++)
            {
                if (fullDatabase.BookingSummary[i].bookingStatus.Equals("Complete"))
                {
                    if (fullDatabase.BookingSummary[i].dateIn.Month == 01)
                    {
                        sum1 += getAmount(fullDatabase.BookingSummary[i].amountDue.ToString());
                        //sum8 = getAmount("R230");
                    }
                    if (fullDatabase.BookingSummary[i].dateIn.Month == 02)
                    {
                        sum2 += getAmount(fullDatabase.BookingSummary[i].amountDue.ToString());
                    }
                    if (fullDatabase.BookingSummary[i].dateIn.Month == 3)
                    {
                        sum3 += getAmount(fullDatabase.BookingSummary[i].amountDue.ToString());
                    }
                    if (fullDatabase.BookingSummary[i].dateIn.Month == 4)
                    {
                        sum4 += getAmount(fullDatabase.BookingSummary[i].amountDue.ToString());
                    }
                    if (fullDatabase.BookingSummary[i].dateIn.Month == 5)
                    {
                        sum5 += getAmount(fullDatabase.BookingSummary[i].amountDue.ToString());
                    }
                    if (fullDatabase.BookingSummary[i].dateIn.Month == 6)
                    {
                        sum6 += getAmount(fullDatabase.BookingSummary[i].amountDue.ToString());
                    }
                    if (fullDatabase.BookingSummary[i].dateIn.Month == 7)
                    {
                        sum7 += getAmount(fullDatabase.BookingSummary[i].amountDue.ToString());
                    }
                    if (fullDatabase.BookingSummary[i].dateIn.Month == 8)
                    {
                        sum8 += getAmount(fullDatabase.BookingSummary[i].amountDue.ToString());
                    }
                    if (fullDatabase.BookingSummary[i].dateIn.Month == 9)
                    {
                        sum9 += getAmount(fullDatabase.BookingSummary[i].amountDue.ToString());
                    }
                    if (fullDatabase.BookingSummary[i].dateIn.Month == 10)
                    {
                        sum10 += getAmount(fullDatabase.BookingSummary[i].amountDue.ToString());
                    }
                    if (fullDatabase.BookingSummary[i].dateIn.Month == 11)
                    {
                        sum11 += getAmount(fullDatabase.BookingSummary[i].amountDue.ToString());
                    }
                    if (fullDatabase.BookingSummary[i].dateIn.Month == (12))
                    {
                        sum12 += getAmount(fullDatabase.BookingSummary[i].amountDue.ToString()); ;
                    }
                }
            }
            chart2.Series["Series2"].Points.AddXY("January",sum1);
            chart2.Series["Series2"].Points.AddXY("February",sum2);
            chart2.Series["Series2"].Points.AddXY("March",sum3);
            chart2.Series["Series2"].Points.AddXY("April",sum4);
            chart2.Series["Series2"].Points.AddXY("May",sum5);
            chart2.Series["Series2"].Points.AddXY("June",sum6);
            chart2.Series["Series2"].Points.AddXY("July",sum7);
            chart2.Series["Series2"].Points.AddXY("August",sum8);
            chart2.Series["Series2"].Points.AddXY("September",sum9);
            chart2.Series["Series2"].Points.AddXY("October",sum10);
            chart2.Series["Series2"].Points.AddXY("November",sum11);
            chart2.Series["Series2"].Points.AddXY("December",sum12);

            label4.Text = " January: R" + sum1 + "\n Febrauary: R" + sum2 + "\n March: R" + sum3 + "\n April: R" + sum4 + "\n May: R" + sum5 + "\n June: R" + sum6 + "\n July: R" + sum7 + "\n August: R" + sum8 + "\n September: R" + sum9 + "\n October: R" + sum10 + "\n November: R" + sum11 + "\n December: R" + sum12;  
        }

        public double getAmount(string s)
        {
            string p = "";
            for(int i = 1; i <s.Length; i++)
            {
                if (s[i]!='.')
                {
                    p += s[i].ToString();
                }
                if(s[i] == '.')
                {
                    p += ',';
                }
                if (s.Length == s.Length-1 || s.Length ==s.Length-2)
                {
                    p += '0';
                }
                //p += s[i].ToString();
            }
            p = p.Trim();
            return Convert.ToDouble(p);

        }

        private void managerForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fullDatabase.Payment' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'fullDatabase.BookingSummary' table. You can move, or remove it, as needed.
            //  this.bookingSummaryTableAdapter.Fill(this.fullDatabase.BookingSummary);

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.bookingSummaryTableAdapter.Fill(this.fullDatabase.BookingSummary);
            dataGridView1.Visible = true;
            button1.Visible = false;
            chart3.Visible = true;
            label3.Visible = true;
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.paymentTableAdapter.Fill(fullDatabase.Payment);
            //dataGridView2.Visible = true;
            label2.Visible = true;
            chart1.Visible = true;
            chart2.Visible = true;
            button2.Visible = false;
            label1.Visible = true;
            label4.Visible = true;
            groupBox6.Visible = true;
        }
    }
}
