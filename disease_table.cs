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
    public partial class disease_table : Form
    {
        DB_connection dB_Connection = new DB_connection();

        public disease_table()
        {
            InitializeComponent();
        }

        private void disease_table_Load(object sender, EventArgs e)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            string querystring = $"select name as Название from disease;";

            SqlCommand command = new SqlCommand(querystring, dB_Connection.GetConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);

            dataGridView_dise.DataSource = table;
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            if (textBox_search.Text != "")
            {
                string value = textBox_search.Text;
                SqlDataAdapter adapter = new SqlDataAdapter();
                DataTable table = new DataTable();
                string querystring = $"select name as Название from disease where name = '{value}';";

                SqlCommand command = new SqlCommand(querystring, dB_Connection.GetConnection());

                adapter.SelectCommand = command;
                adapter.Fill(table);

                dataGridView_dise.DataSource = table;
            }
            else
            {
                SqlDataAdapter adapter = new SqlDataAdapter();
                DataTable table = new DataTable();
                string querystring = $"select name as Название from disease;";

                SqlCommand command = new SqlCommand(querystring, dB_Connection.GetConnection());

                adapter.SelectCommand = command;
                adapter.Fill(table);

                dataGridView_dise.DataSource = table;
            }
        }

        private void button_insert_Click(object sender, EventArgs e)
        {
            dis_add add_dis = new dis_add();
            add_dis.Show();
            this.Show();
        }

        private void button_del_Click(object sender, EventArgs e)
        {
            dis_del del_dis = new dis_del();
            del_dis.Show();
            this.Show();
        }
    }
}
