using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test_DataBase
{
    public partial class pet_owner_table : Form
    {
        DB_connection dB_Connection = new DB_connection();
        public pet_owner_table()
        {
            InitializeComponent();
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            if (textBox_search.Text != "")
            {
                string value = textBox_search.Text;
                string querystring = $"select surname as Фамилия, firstname as Имя, middlename as Отчество, phone as Телефон, email as Почта, address as Адрес, city as Город, region as Область from pet_owner where surname = '{value}' or phone = '{value}' or email = '{value}';";

                SqlCommand command = new SqlCommand(querystring, dB_Connection.GetConnection());

                adapter.SelectCommand = command;
                adapter.Fill(table);

                dataGridView_pet_own.DataSource = table;
            }
            else
            {
                string querystring = $"select surname as Фамилия, firstname as Имя, middlename as Отчество, phone as Телефон, email as Почта, address as Адрес, city as Город, region as Область from pet_owner;";

                SqlCommand command = new SqlCommand(querystring, dB_Connection.GetConnection());

                adapter.SelectCommand = command;
                adapter.Fill(table);

                dataGridView_pet_own.DataSource = table;
            }
        }

        private void pet_owner_table_Load(object sender, EventArgs e)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            string querystring = $"select surname as Фамилия, firstname as Имя, middlename as Отчество, phone as Телефон, email as Почта, address as Адрес, city as Город, region as Область from pet_owner;";

            SqlCommand command = new SqlCommand(querystring, dB_Connection.GetConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);

            dataGridView_pet_own.DataSource = table;
        }

        private void button_insert_Click(object sender, EventArgs e)
        {
            pet_own_add pet_Own_Add = new pet_own_add();
            pet_Own_Add.Show();
            this.Show();
        }

        private void button_upd_Click(object sender, EventArgs e)
        {
            pet_own_upd pet_Own_Upd = new pet_own_upd();
            pet_Own_Upd.Show();
            this.Show();
        }

        private void button_del_Click(object sender, EventArgs e)
        {
            pet_own_del pet_Own_Del = new pet_own_del();
            pet_Own_Del.Show();
            this.Show();
        }
    }
}
