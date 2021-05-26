using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Customer
    {
        private string emailID;
        private string name;
        private string surname;
        private string idNumber;
        private string cellNumber;
        public Customer(string e, string n, string s, string i, string c)
        {
            this.emailID= e;
            this.name = n;
            this.surname = s;
            this.idNumber = i;
            this.cellNumber = c;
        }
        public string getEmailID()
        {
            return this.emailID;
        }
        public string getName()
        {
            return this.name;
        }
        public string getSurname()
        {
            return this.surname;
        }
        public string getIdNumber()
        {
            return this.idNumber;
        }
        public string getCellphone()
        {
            return this.cellNumber;
        }
    }
}
