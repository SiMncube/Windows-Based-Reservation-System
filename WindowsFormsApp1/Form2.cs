﻿using System;
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
        private bool IsLoginValid()
        {
            int count = 0;

            if(textBox1.Text.Length < 3)
            {
                ChangeColor(textBox1);
                count++;
            }
            if(textBox2.Text.Length < 3)
            {
                ChangeColor(textBox2);
                count++;
            }
            if (textBox3.Text.Length != 13 || !isAllDigits(textBox3))
            {
                ChangeColor(textBox3);
                count++;
            }
            if(textBox4.Text.Length != 10 || !isAllDigits(textBox4))
            {
                ChangeColor(textBox4);
                count++;
            }
            if(textBox5.Text.Length < 8)
            {
                ChangeColor(textBox5);
                count++;
            }
            if(textBox7.Text.Length < 5)
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
            taCus.Fill(dsCus.Customer);
            if (textBox5.Text.Length < 8)
            {
                return false;
            }
            DataRow foundRow = dsCus.Tables["Customer1"].Rows.Find(textBox5.Text);
            if (foundRow != null)
            {
                label13.Visible = true;
                return true;
            }
            return false;
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            taCus.Fill(dsCus.Customer);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!RecordsAlreadyExists() && IsLoginValid())
            {
                taCus.Insert(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text, textBox7.Text, textBox8.Text, textBox9.Text, textBox10.Text);
                Form1 login = new Form1();
                this.Close();
                login.ShowDialog();
                login.Show();
            }
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void ChangeColor(TextBox textBox)
        {
            textBox.BackColor = Color.Red;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            
        }
        private bool isDigit(char ch)
        {
            if (ch >= '0' && ch <= '9')
                return true;
            return false;
        }
        private bool isAllDigits(TextBox textBox)
        {
            String s = textBox.Text.ToString();
            for(int i = 0; i < s.Length; i++)
            {
                if (!isDigit(s[i]))
                    return false;
            }
            return true;
        }
    }
}
