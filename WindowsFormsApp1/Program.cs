﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Collections;
using System.Windows.Forms;
using System.Net.Mail;

namespace WindowsFormsApp1
{
    public static class Email
    {
        private static void send(string toEmail, string emailSubject, string emailBody)
        {
            MailMessage mail = new MailMessage();
            SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
            mail.From = new MailAddress("TheCottageGroup7@gmail.com");
            mail.To.Add(toEmail);
            mail.Subject = emailSubject;
            mail.IsBodyHtml = true;  //to make message body as html could be commented out.
            mail.Body = emailBody;
            SmtpServer.Port = 587;
            SmtpServer.Credentials = new System.Net.NetworkCredential("TheCottageGroup7@gmail.com", "UKZNgroup7");
            SmtpServer.EnableSsl = true;
            SmtpServer.Send(mail);
            MessageBox.Show("mail Send");
        }
        public static void sendEmail(string toEmail, string emailSubject, string emailBody)
        {

            try
            {
                send(toEmail, emailSubject, emailBody);
            }
            catch (Exception ex)
            {
                send(toEmail, emailSubject, emailBody);
            }
        }

        public static void sendInvoice() //for sending resevation invoice after making a booking
        {
            sendEmail(currentUser.getEmailID(), "The Cottage BNB, Reservation Invoice", invoiceBody());
        }

        public static string invoiceBody()  //this method will just creating some structure for the booking invoice email
        {
            string htmlTdStart = "<td style=\" border-color:#5c87b2; border-style:solid; border-width:thin; padding: 5px;\">";
            string messageBody = "<font>Dear " + customerName + ",</font><br><br>";
            if (isModify)
            {
                messageBody += "<font> Your booking with ref: " + oldBookingID + "has been successfully modified.</font><br><br>";
                messageBody += "<font> Here Is Modified Invoice, We're Looking Forward To Having You As Our Guest.</font><br><br>";
            }
            else
            {
                messageBody += "<font> Thank you for your payment, your booking has been confirmed.</font><br><br>";
                messageBody += "<font> Here Is Your Invoice, We're Looking Forward To Having You As Our Guest.</font><br><br>";
            }
            messageBody += "<table style=\"border-collapse:collapse; text-align:center;\">";

            messageBody += "<tr style=\"background-color:#6FA1D2; color:#ffffff;\">" + htmlTdStart + "Booking Details </td>" + htmlTdStart + " Values </td></tr>"; //table header or first row
            messageBody += "<tr style=\"color:#555555;\">" + htmlTdStart + "Booking Reference </td>" + htmlTdStart + bookingID + "</td></tr> ";
            messageBody += "<tr style=\"color:#555555;\">" + htmlTdStart + "Booking Status </td>" + htmlTdStart + bookingStatus + "</td></tr> ";
            messageBody += "<tr style=\"color:#555555;\">" + htmlTdStart + "Name </td>" + htmlTdStart + customerName + "</td></tr> ";
            messageBody += "<tr style=\"color:#555555;\">" + htmlTdStart + "Surname </td>" + htmlTdStart + customerSurname + "</td></tr> ";
            messageBody += "<tr style=\"color:#555555;\">" + htmlTdStart + "Checking In Date </td>" + htmlTdStart + dateIn + "</td></tr> ";
            messageBody += "<tr style=\"color:#555555;\">" + htmlTdStart + "Checking Out Date </td>" + htmlTdStart + dateOut + "</td></tr> ";
            messageBody += "<tr style=\"color:#555555;\">" + htmlTdStart + "Number Of Nights </td>" + htmlTdStart + numberOfNights + "</td></tr> ";
            messageBody += "<tr style=\"color:#555555;\">" + htmlTdStart + "Number Of Single Rooms </td>" + htmlTdStart + numberOfSingles + "</td></tr> ";
            messageBody += "<tr style=\"color:#555555;\">" + htmlTdStart + "Number Of Double Rooms </td>" + htmlTdStart + numberOfDoubles + "</td></tr> ";
            messageBody += "<tr style=\"color:#555555;\">" + htmlTdStart + "Booked Single Rooms </td>" + htmlTdStart + singleRoomIDs + "</td></tr> ";
            messageBody += "<tr style=\"color:#555555;\">" + htmlTdStart + "Booked Double Rooms </td>" + htmlTdStart + doubleRoomIDs + "</td></tr> ";

            messageBody += "<tr style=\"color:#555555;\">" + htmlTdStart + "----- </td>" + htmlTdStart + "--- </td></tr> ";
            messageBody += "<tr style=\"color:#555555;\">" + htmlTdStart + "Single Room Rate </td>" + htmlTdStart + "R450 Per Night" + "</td></tr> ";
            messageBody += "<tr style=\"color:#555555;\">" + htmlTdStart + "Double Room Rate </td>" + htmlTdStart + "R800 Per Night" + "</td></tr> ";
            //messageBody += "<tr style=\"color:#555555;\">" + htmlTdStart + "You Are Paying </td>" + htmlTdStart +  +" Per Night" + "</td></tr> ";
            messageBody += "<tr style=\"color:#555555;\">" + htmlTdStart + "----- </td>" + htmlTdStart + "--- </td></tr> ";
            messageBody += "<tr style=\"color:#555555;\">" + htmlTdStart + "Total Amount Paid </td>" + htmlTdStart + amountDue + "</td></tr> ";
            messageBody += "</table>";
            messageBody += "<font><br>This is an autogenerated email, for enquiries <br>call: +27 64 090 3388 <br> Or email: sonya@TheCottageBnB.co.za</font><br><br>";

            return messageBody;  //return HTML Table as string from this function  

            //original Code 
            /*
            try
            {
                string messageBody = "<font>The following are the records: </font><br><br>";
                if (grid.RowCount == 0) return messageBody;
                string htmlTableStart = "<table style=\"border-collapse:collapse; text-align:center;\" >";
                string htmlTableEnd = "</table>";
                string htmlHeaderRowStart = "<tr style=\"background-color:#6FA1D2; color:#ffffff;\">";
                string htmlHeaderRowEnd = "</tr>";
                string htmlTrStart = "<tr style=\"color:#555555;\">";
                string htmlTrEnd = "</tr>";
                string htmlTdStart = "<td style=\" border-color:#5c87b2; border-style:solid; border-width:thin; padding: 5px;\">";
                string htmlTdEnd = "</td>";
                messageBody += htmlTableStart;
                messageBody += htmlHeaderRowStart;
                messageBody += htmlTdStart + "Student Name" + htmlTdEnd;
                messageBody += htmlTdStart + "DOB" + htmlTdEnd;
                messageBody += htmlTdStart + "Email" + htmlTdEnd;
                messageBody += htmlTdStart + "Mobile" + htmlTdEnd;
                messageBody += htmlHeaderRowEnd;
                //Loop all the rows from grid vew and added to html td  
                for (int i = 0; i <= grid.RowCount - 1; i++)
                {
                    messageBody = messageBody + htmlTrStart;
                    messageBody = messageBody + htmlTdStart + grid.Rows[i].Cells[0].Value + htmlTdEnd; //adding student name  
                    messageBody = messageBody + htmlTdStart + grid.Rows[i].Cells[1].Value + htmlTdEnd; //adding DOB  
                    messageBody = messageBody + htmlTdStart + grid.Rows[i].Cells[2].Value + htmlTdEnd; //adding Email  
                    messageBody = messageBody + htmlTdStart + grid.Rows[i].Cells[3].Value + htmlTdEnd; //adding Mobile  
                    messageBody = messageBody + htmlTrEnd;
                }
                messageBody = messageBody + htmlTableEnd;
                return messageBody; // return HTML Table as string from this function  
            }
            catch (Exception ex)
            {
                return null;
            }
            */
        }

        //these fields needs to be updated at some point of the program runtime, So they could be used to generate invoice.
        //these are initialized in admin form, around line 775 to line 788
        public static string customerName;
        public static string customerSurname;
        public static string customerIdNumber;
        public static string customerEmail;
        public static string bookingID;
        public static string bookingStatus;   //initailized at line 788 of adminForm, then updated at line 203 of paymentForm  
        public static string bookingMethod;
        public static string dateIn;
        public static string dateOut;
        public static string numberOfNights;
        public static string numberOfSingles;
        public static string numberOfDoubles;
        public static string singleRoomIDs;
        public static string doubleRoomIDs;
        public static string amountDue;

        public static bool isModify = false;
        public static string oldBookingID;
        public static string refund;
    }

    public static class currentUser
    {
        private static string emailID;
        public static string getEmailID()
        {
            return emailID;
        }
        public static void setEmailID(string e)
        {
            emailID = e;
        }
    }

    public static class currentBooking
    {
        private static int summaryID;
        private static int[] roomIDs;
        public static int getSummaryID()
        {
            return summaryID;
        }
        public static void setSummaryID(int s)
        {
            summaryID = s;
        }
        public static int[] getRoomIDs()
        {
            return roomIDs;
        }
        public static void setRoomIDs(int[] r)
        {
            roomIDs = r;
        }
    }
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());
            //Application.Run(new adminForm());
            //Application.Run(new managerForm());
        }
    }
}
