using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.Odbc;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test_DataBase
{
    public partial class vet_services_table : Form
    {
        DB_connection dB_Connection = new DB_connection();
        public vet_services_table()
        {
            InitializeComponent();
        }

        private void vet_srevices_table_Load(object sender, EventArgs e)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            string querystring = $"select name as Название, price as Стоимость from vet_services;";

            SqlCommand command = new SqlCommand(querystring, dB_Connection.GetConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);

            dataGridView_services.DataSource = table;
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            if (textBox_search.Text != "")
            {
                string value = textBox_search.Text;
                SqlDataAdapter adapter = new SqlDataAdapter();
                DataTable table = new DataTable();
                string querystring = $"select name as Название, price as Стоимость from vet_services where name = '{value}';";

                SqlCommand command = new SqlCommand(querystring, dB_Connection.GetConnection());

                adapter.SelectCommand = command;
                adapter.Fill(table);

                dataGridView_services.DataSource = table;
            }
            else
            {
                SqlDataAdapter adapter = new SqlDataAdapter();
                DataTable table = new DataTable();
                string querystring = $"select name as Название, price as Стоимость from vet_services;";

                SqlCommand command = new SqlCommand(querystring, dB_Connection.GetConnection());

                adapter.SelectCommand = command;
                adapter.Fill(table);

                dataGridView_services.DataSource = table;
            }
        }

        private void button_insert_Click(object sender, EventArgs e)
        {
            Services_add add_services = new Services_add();
            add_services.Show();
            this.Show();
        }

        private void button_upd_Click(object sender, EventArgs e)
        {
            Services_upd upd_services = new Services_upd();
            upd_services.Show();
            this.Show();
        }

        private void button_del_Click(object sender, EventArgs e)
        {
            services_del del_services = new services_del();
            del_services.Show();
            this.Show();
        }
    }
}
