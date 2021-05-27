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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            customerTableAdapter.Fill(fullDatabase.Customer);
        }
        private bool IsLoginValid()
        {
            int count = 0;

            if (textBox1.Text.Length < 3)
            {
                ChangeColor(textBox1);
                count++;
            }
            if (textBox2.Text.Length < 3)
            {
                ChangeColor(textBox2);
                count++;
            }
            if (textBox3.Text.Length != 13 || !isAllDigit(textBox3))
            {
                ChangeColor(textBox3);
                count++;
            }
            if (textBox4.Text.Length != 10 || !isAllDigit(textBox4))
            {
                ChangeColor(textBox4);
                count++;
            }
            if (textBox5.Text.Length < 8)
            {
                ChangeColor(textBox5);
                count++;
            }
            if (textBox7.Text.Length < 5)
            {
                ChangeColor(textBox7);
                count++;
            }
            if (count > 0)
            {
                return false;
            }
            return true;
        }
        private bool RecordsAlreadyExists()
        {
            if (textBox5.Text.Length < 8)
                return false;
            DataRow foundRow = fullDatabase.Tables["Customer"].Rows.Find(textBox5.Text.ToLower());
            if (foundRow != null)
            {
                label13.Visible = true;
                return true;
            }
            return false;
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(!RecordsAlreadyExists() && IsLoginValid())
            {
                customerTableAdapter.Insert(textBox5.Text.ToLower(), textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox7.Text, textBox8.Text, textBox6.Text, textBox9.Text, textBox10.Text);
                panel1.Visible = false;
                panel2.Visible = false;
                panel3.Visible = false;
                panel4.Visible = true;
            }
        }
        private void ChangeColor(TextBox textBox)
        {
            textBox.BackColor = Color.Red;
        }
        private bool isDigit(char ch)
        {
            if (ch >= '0' && ch <= '9')
                return true;
            return false;
        }
        private bool isAllDigit(TextBox textbox)
        {
            string s = textbox.Text.ToString();
            for(int i = 0; i < s.Length; i++)
            {
                if (!isDigit(s[i]))
                    return false;
            }
            return true;
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fullDatabase.Customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.fullDatabase.Customer);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form8 homePage = new Form8();
            this.Hide();
            homePage.ShowDialog();
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void customerBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
