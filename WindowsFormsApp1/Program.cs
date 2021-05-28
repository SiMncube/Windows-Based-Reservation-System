using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Collections;
using System.Windows.Forms;

namespace WindowsFormsApp1   
{
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
            Application.Run(new Form1());
        }
    }
}
