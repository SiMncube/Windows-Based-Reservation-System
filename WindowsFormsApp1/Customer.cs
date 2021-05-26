using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Customer
    {
        private string emailAddress;
        private string name;
        private string surname;
        private string idNumber;
        private string cellNumber;
        public Customer(string e, string n, string s, string i, string c)
        {
            this.emailAddress = e;
            this.name = n;
            this.surname = s;
            this.idNumber = i;
            this.cellNumber = c;
        }
        public string getEmailAddress()
        {
            return this.emailAddress;
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
