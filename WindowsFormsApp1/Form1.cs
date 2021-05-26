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
    public partial class Form1 : Form
    {
        private Customer currentCust;
        public Form1()
        {
            InitializeComponent();
            customerTableAdapter.Fill(fullDatabase.Customer);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (LoginIsValid())
            {
                Form8 homePage = new Form8();
                this.Hide();
                homePage.ShowDialog();
                this.Close();
            }
            else
            {
                label5.Visible = true;
            }
            
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Form2 signup = new Form2();
            this.Hide();
            signup.ShowDialog();
            this.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fullDatabase.Customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.fullDatabase.Customer);

        }
        private bool LoginIsValid()
        {
            for (int i = 0; i < fullDatabase.Customer.Rows.Count; i++)
            {
                if (fullDatabase.Tables["Customer"].Rows[i]["Password"].ToString() == textBox2.Text && fullDatabase.Tables["Customer"].Rows[i]["emailID"].ToString() == textBox1.Text)
                {
                    this.currentCust = new Customer(fullDatabase.Tables["Customer"].Rows[i]["emailID"].ToString(),
                                                fullDatabase.Tables["Customer"].Rows[i]["name"].ToString(),
                                                fullDatabase.Tables["Customer"].Rows[i]["surname"].ToString(),
                                                fullDatabase.Tables["Customer"].Rows[i]["idNumber"].ToString(),
                                                fullDatabase.Tables["Customer"].Rows[i]["cellNumber"].ToString());
                    return true;
                }
            }
            return false;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }
        public Customer currentUser()
        {
            return this.currentCust;
        }
    }
}
