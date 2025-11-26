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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Зарегистрироваться_Click(object sender, EventArgs e)
        {
            string NameGirl, SurnameGirl, AgeGirl, CityGirl, EmailGirl, WhatSurenameGirl;
            NameGirl = textBox1.Text;
            SurnameGirl = textBox2.Text;
            AgeGirl = numericUpDown1.Text;
            CityGirl = textBox4.Text;
            EmailGirl = textBox3.Text;
            WhatSurenameGirl = checkedListBox1.Text;


            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source= E:\\3 курс\\тимонина\\си шарп\\dbirna.accdb";
            OleDbConnection dbConnection = new OleDbConnection(connectionString);

            dbConnection.Open();
            string query = "INSERT INTO Girl VALUES ('" + NameGirl + "','" + SurnameGirl + "', '" + AgeGirl + "', '" + CityGirl + "', '" + EmailGirl + "', '" + WhatSurenameGirl + "')";
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

            MessageBox.Show("Регистрация успешно завершена!!!");
            Form1 newForm = new Form1();
            newForm.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

