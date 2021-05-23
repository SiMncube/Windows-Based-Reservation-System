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
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            taCus.Fill(dsCus.Customer1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            taCus.Insert(textBox1.Text,textBox2.Text,textBox3.Text,textBox4.Text,textBox5.Text,textBox6.Text,textBox7.Text,textBox8.Text,textBox9.Text,textBox10.Text);
            Form3 login = new Form3();
            this.Hide();
            login.ShowDialog();
            this.Show();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
