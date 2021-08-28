using System;
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
                send(toEmail,emailSubject,emailBody);
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
            string body = "Dear ";

            return body;
        }

        public static void updateBookingInvoice()
        {

        }

        //these fields needs to be updated at some point of the program runtime, So they could be used to generate invoice.
        //these are initialized in admin form, around line 775 to line 788
        public static string customerName;      
        public static string customerSurname;
        public static string customerIdNumber;
        public static string customerEmail;     
        public static string bookingID;         
        public static string bookingStatus;     
        public static string bookingMethod;    
        public static string dateIn;            
        public static string dateOut;           
        public static string numberOfNights;   
        public static string numberOfSingles;  
        public static string numberOfDoubles;  
        public static string singleRoomIDs;    
        public static string doubleRoomIDs;    
        public static string amountDue;         
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
