using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace test_DataBase
{
    public partial class Post_table : Form
    {
        DB_connection db_connection = new DB_connection();
        public Post_table()
        {
            InitializeComponent();
        }

        private void Post_table_Load(object sender, EventArgs e)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            string querystring = $"select name as Название_должности, salary as Оклад from post;";

            SqlCommand command = new SqlCommand(querystring, db_connection.GetConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);

            dataGridView_Post.DataSource = table;
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            if (textBox_search.Text != "")
            {
                string value = textBox_search.Text;
                SqlDataAdapter adapter = new SqlDataAdapter();
                DataTable table = new DataTable();
                string querystring = $"select name as Название_должности, salary as Оклад from post where name = '{value}';";

                SqlCommand command = new SqlCommand(querystring, db_connection.GetConnection());

                adapter.SelectCommand = command;
                adapter.Fill(table);

                dataGridView_Post.DataSource = table;
            }
            else
            {
                SqlDataAdapter adapter = new SqlDataAdapter();
                DataTable table = new DataTable();
                string querystring = $"select name as Название_должности, salary as Оклад from post;";

                SqlCommand command = new SqlCommand(querystring, db_connection.GetConnection());

                adapter.SelectCommand = command;
                adapter.Fill(table);

                dataGridView_Post.DataSource = table;
            }
        }
    }
}
