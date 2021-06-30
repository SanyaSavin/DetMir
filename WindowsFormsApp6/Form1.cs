using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

using System.Data.SqlClient;

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {
        private SqlConnection sqlConnection = null;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["TestDB"].ConnectionString);
            sqlConnection.Open();
            if (sqlConnection.State == ConnectionState.Open)
            {
                MessageBox.Show("Подключение установлено");
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand(
                $"INSERT INTO [assortiment] (Nazvanie, cena) VALUES (@Nazvanie, @cena)",
                sqlConnection);
            command.Parameters.AddWithValue("Nazvanie", textBox1.Text);
            command.Parameters.AddWithValue("cena", textBox2.Text);
           


            MessageBox.Show(command.ExecuteNonQuery().ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand(
            $"INSERT INTO [postavshiki] (imya, nomer, gorod, kod_postavki) VALUES (@imya, @nomer, @gorod, @kod_postavki)",
                sqlConnection);
            command.Parameters.AddWithValue("imya", textBox5.Text);
            command.Parameters.AddWithValue("nomer", textBox6.Text);
            command.Parameters.AddWithValue("gorod", textBox3.Text);
            command.Parameters.AddWithValue("kod_postavki", textBox4.Text);

            MessageBox.Show(command.ExecuteNonQuery().ToString());

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand(
            $"INSERT INTO [Zakazchiki] (imya, nomer, gorod, kod_zahazchika) VALUES (@imya, @nomer, @gorod, @kod_zahazchika)",
                sqlConnection);
            command.Parameters.AddWithValue("imya", textBox10.Text);
            command.Parameters.AddWithValue("nomer", textBox11.Text);
            command.Parameters.AddWithValue("gorod", textBox12.Text);
            command.Parameters.AddWithValue("kod_zahazchika", textBox7.Text);

            MessageBox.Show(command.ExecuteNonQuery().ToString());
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlDataAdapter dataAdapter = new SqlDataAdapter(
                textBox15.Text,
                sqlConnection);
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet);

            dataGridView1.DataSource = dataSet.Tables[0];

           
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {

        }

        

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
