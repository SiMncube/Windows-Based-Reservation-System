using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Collections;
using System.Windows.Forms;
using System.Net.Mail;

namespace WindowsFormsApp1
{
    public class Email
    {
        private static void send(string toEmail, string emailSubject, string emailBody)
        {
            MailAddress addressFrom = new MailAddress("TheCottageGroup7@gmail.com", "The Cottage BnB");
            MailAddress addressTo = new MailAddress(toEmail);
            MailMessage mail = new MailMessage(addressFrom, addressTo);
            SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
            mail.Subject = emailSubject;
            mail.IsBodyHtml = true;  //to make message body as html could be commented out.
            mail.Body = emailBody;
            SmtpServer.Port = 587;
            SmtpServer.Credentials = new System.Net.NetworkCredential("TheCottageGroup7@gmail.com", "UKZNgroup7");
            SmtpServer.EnableSsl = true;
            SmtpServer.Send(mail);
            MessageBox.Show("Email has been Send");
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
            if (isCancel)
            {
                send(customerEmail, "The Cottage BNB, Canceled Reservation Invoice", invoiceBody());
                isCancel = false;
            }
                
            else if (isModify)
            {
                send(customerEmail, "The Cottage BNB, Modified Reservation Invoice", invoiceBody());
                isModify = false;
            }
            else
                send(customerEmail, "The Cottage BNB, Reservation Invoice", invoiceBody());
        }

        public static string invoiceBody()  //this method will just creating some structure for the booking invoice email
        {
            string htmlTdStart = "<td style=\" border-color:#5c87b2; border-style:solid; border-width:thin; padding: 5px;\">";
            string messageBody = "<font>Dear " + customerName + ",</font><br><br>";
            if (isModify)
            {
                messageBody += "<font> Your booking with ref: " + oldBookingID + " has been successfully modified.</font><br><br>";
                messageBody += "<font> Take note of your new Booking reference: " + bookingID + "</font><br><br>";
                messageBody += "<font> Here Is Your Invoice, We're Looking Forward To Having You As Our Guest.</font><br><br>";
            }
            else if (isCancel)
            {
                messageBody += "<font> Your booking with ref: " + bookingID + " has been successfully Cancelled.</font><br><br>";
                messageBody += "<font> Here Is Your Invoice, Your Refund will be processed within the next 3-5 business days</font><br><br>";
            }
            else
            {
                messageBody += "<font> Thank You for your payment, your booking has been confirmed.</font><br><br>";
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
            if (!isCancel)
            {
                messageBody += "<tr style=\"color:#555555;\">" + htmlTdStart + "Number Of Single Rooms </td>" + htmlTdStart + numberOfSingles + "</td></tr> ";
                messageBody += "<tr style=\"color:#555555;\">" + htmlTdStart + "Number Of Double Rooms </td>" + htmlTdStart + numberOfDoubles + "</td></tr> ";
                messageBody += "<tr style=\"color:#555555;\">" + htmlTdStart + "Booked Single Rooms </td>" + htmlTdStart + singleRoomIDs + "</td></tr> ";
                messageBody += "<tr style=\"color:#555555;\">" + htmlTdStart + "Booked Double Rooms </td>" + htmlTdStart + doubleRoomIDs + "</td></tr> ";
                messageBody += "<tr style=\"color:#555555;\">" + htmlTdStart + "----- </td>" + htmlTdStart + "--- </td></tr> ";
                messageBody += "<tr style=\"color:#555555;\">" + htmlTdStart + "Single Room Rate </td>" + htmlTdStart + "R450 Per Night" + "</td></tr> ";
                messageBody += "<tr style=\"color:#555555;\">" + htmlTdStart + "Double Room Rate </td>" + htmlTdStart + "R800 Per Night" + "</td></tr> ";

            }
            messageBody += "<tr style=\"color:#555555;\">" + htmlTdStart + "----- </td>" + htmlTdStart + "--- </td></tr> ";
            if (isModify)
            {
                messageBody += "<tr style=\"color:#555555;\">" + htmlTdStart + "Previous Booking Payment </td>" + htmlTdStart + "R " + oldBookingAmountDue + "</td></tr> ";
                messageBody += "<tr style=\"color:#555555;\">" + htmlTdStart + "New Booking Amount Due </td>" + htmlTdStart + amountDue + "</td></tr> ";
                if (excessOrefund < 0)
                    messageBody += "<tr style=\"color:#555555;\">" + htmlTdStart + "Total Refund Amount </td>" + htmlTdStart + "R " + Math.Abs(excessOrefund) + "</td></tr> ";
                else if (excessOrefund > 0)
                    messageBody += "<tr style=\"color:#555555;\">" + htmlTdStart + "Total Amount Paid </td>" + htmlTdStart + "R " + excessOrefund + "</td></tr> ";
                else
                    messageBody += "<tr style=\"color:#555555;\">" + htmlTdStart + " No Excess amount </td>" + htmlTdStart + "R " + excessOrefund + "</td></tr> ";
            }
            else if (isCancel)
            {
                messageBody += "<tr style=\"color:#555555;\">" + htmlTdStart + "Total Paid </td>" + htmlTdStart + amountDue + "</td></tr> ";
                messageBody += "<tr style=\"color:#555555;\">" + htmlTdStart + "Total Refund Amount </td>" + htmlTdStart + "R " + Math.Abs(excessOrefund) + "</td></tr> ";
            }
            else
            {
                messageBody += "<tr style=\"color:#555555;\">" + htmlTdStart + "Total Amount Paid </td>" + htmlTdStart + amountDue + "</td></tr> ";
            }

            messageBody += "</table>";
            messageBody += "<font><br>This is an autogenerated email, for enquiries <br>call: +27 64 090 3388 <br> Or email: sonya@TheCottageBnB.co.za</font><br><br>";

            return messageBody;  //return HTML Table as string from this function  
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

        public static bool isCancel = false;
        public static bool isModify = false;
        public static string oldBookingID;      //also used in cancel booking form
        public static string oldBookingAmountDue;
        public static decimal excessOrefund;    //also used in cancel booking form
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
        }
    }
}
