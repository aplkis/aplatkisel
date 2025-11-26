using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Зарегистрироваться_Click(object sender, EventArgs e)
        {
            string NameMan, SurnameMan, AgeMan, CityMan, EmailMan, WhatSurenameMan;
            NameMan = textBox1.Text;
            SurnameMan = textBox2.Text;
            AgeMan = numericUpDown1.Text;
            CityMan = textBox4.Text;
            EmailMan = textBox3.Text;
            WhatSurenameMan = checkedListBox1.Text;


            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source= E:\\3 курс\\тимонина\\си шарп\\dbirna.accdb";
            OleDbConnection dbConnection = new OleDbConnection(connectionString);

            dbConnection.Open();
            string query = "INSERT INTO Man VALUES ('" + NameMan + "','" + SurnameMan + "', '" + AgeMan + "', '" + CityMan + "', '" + EmailMan + "', '" + WhatSurenameMan + "')";
            OleDbCommand dbCommand = new OleDbCommand(query, dbConnection);

            if (dbCommand.ExecuteNonQuery() != 1)
            {
                MessageBox.Show("Ошибка выполнения запроса", "Внимание!");
            }
            else
            {
                MessageBox.Show("Данные добавлены", "Внимание!");
            }
            dbConnection.Close();


            Form2 newForm = new Form2();
            newForm.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
