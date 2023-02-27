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
    public partial class Users_table : Form
    {
        DB_connection db_Connection = new DB_connection();
        public Users_table()
        {
            InitializeComponent();
        }

        private void User_table_Load(object sender, EventArgs e)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            string querystring = $"select post.name as Должность, users.login as Логин, users.password as Пароль, roles.name as Роль from users, employee, post, roles where users.id_employee = employee.id and users.id_role = roles.id and employee.id_post = post.id;";

            SqlCommand command = new SqlCommand(querystring, db_Connection.GetConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);

            dataGridView_Users.DataSource = table;


        }

        private void button_search_Click(object sender, EventArgs e)
        {
            if (textBox_search.Text != "") 
            {
                string value = textBox_search.Text;
                SqlDataAdapter adapter = new SqlDataAdapter();
                DataTable table = new DataTable();
                string querystring = $"select post.name as Должность, users.login as Логин, users.password as Пароль, roles.name as Роль from users, employee, post, roles where users.id_employee = employee.id and users.id_role = roles.id  and employee.id_post = post.id and (login = '{value}' or password = '{value}');";

                SqlCommand command = new SqlCommand(querystring, db_Connection.GetConnection());

                adapter.SelectCommand = command;
                adapter.Fill(table);

                dataGridView_Users.DataSource = table;
            }
            else
            {
                SqlDataAdapter adapter = new SqlDataAdapter();
                DataTable table = new DataTable();
                string querystring = $"select post.name as Должность, users.login as Логин, users.password as Пароль, roles.name as Роль from users, employee, post, roles where users.id_employee = employee.id and users.id_role = roles.id and employee.id_post = post.id;";

                SqlCommand command = new SqlCommand(querystring, db_Connection.GetConnection());

                adapter.SelectCommand = command;
                adapter.Fill(table);

                dataGridView_Users.DataSource = table;
            }
        }

        private void button_upd_Click(object sender, EventArgs e)
        {
            users_upd users_Upd= new users_upd();
            users_Upd.Show();
            this.Show();
        }

        private void dataGridView_Users_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 2 && e.Value != null)
            {
                e.Value = new String('*', e.Value.ToString().Length);
            }
        }
    }
}
