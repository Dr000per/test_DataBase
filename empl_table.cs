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
    public partial class empl_table : Form
    {
        DB_connection db_Connection = new DB_connection();
        public empl_table()
        {
            InitializeComponent();
        }

        private void empl_table_Load(object sender, EventArgs e)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            string querystring = $"select post.name as Должность, Employee.Surname as Фамилия, Employee.Firstname as Имя, Employee.Middlename as Отчество, Employee.Email as Email, Employee.Phone as Телефон\r\nfrom post, Employee where Employee.ID_post = post.ID;";

            SqlCommand command = new SqlCommand(querystring, db_Connection.GetConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);

            dataGridView_empl.DataSource = table;
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            if (textBox_search.Text != "")
            {
                string value = textBox_search.Text;
                SqlDataAdapter adapter = new SqlDataAdapter();
                DataTable table = new DataTable();
                string querystring = $"select post.name as Должность, Employee.Surname as Фамилия, Employee.Firstname as Имя, Employee.Middlename as Отчество, Employee.Email as Email, Employee.Phone as Телефон\r\nfrom post, Employee where\r\nEmployee.ID_post = post.ID and (Post.name = '{value}' or Employee.Phone = '{value}' or Employee.Email = '{value}' or Employee.Firstname = '{value}' or Employee.Surname = '{value}' or Employee.Middlename = '{value}' or Employee.phone = '{value}');";

                SqlCommand command = new SqlCommand(querystring, db_Connection.GetConnection());

                adapter.SelectCommand = command;
                adapter.Fill(table);

                dataGridView_empl.DataSource = table;
            }
            else
            {
                SqlDataAdapter adapter = new SqlDataAdapter();
                DataTable table = new DataTable();
                string querystring = $"select post.name as Должность, Employee.Surname as Фамилия, Employee.Firstname as Имя, Employee.Middlename as Отчество, Employee.Email as Email, Employee.Phone as Телефон\r\nfrom post, Employee where Employee.ID_post = post.ID;";

                SqlCommand command = new SqlCommand(querystring, db_Connection.GetConnection());

                adapter.SelectCommand = command;
                adapter.Fill(table);                                          
                                                                              
                dataGridView_empl.DataSource = table;                         
            }
        }

        private void button_insert_Click(object sender, EventArgs e)
        {
            empl_add add_empl = new empl_add();
            add_empl.Show();
            this.Show();
        }

        private void button_upd_Click(object sender, EventArgs e)
        {
            empl_update upd_empl = new empl_update();
            upd_empl.Show();
            this.Show();
        }

        private void button_del_Click(object sender, EventArgs e)
        {
            empl_del del_empl = new empl_del();
            del_empl.Show();
            this.Show();
        }

        private void dataGridView_empl_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
