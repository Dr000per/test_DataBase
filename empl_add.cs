using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.SqlClient;
using System.Data.Odbc;

namespace test_DataBase
{
    public partial class empl_add : Form
    {
        int post_id = 0;
        DB_connection db_Connection = new DB_connection();
        public empl_add()
        {
            InitializeComponent();
        }

        private void empl_add_Load(object sender, EventArgs e)
        {
            comboBox_post.DropDownStyle = ComboBoxStyle.DropDownList;

            string querystring = "select name from post where id != 1;";
            SqlCommand command = new SqlCommand(querystring, db_Connection.GetConnection());
            db_Connection.openConnection();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                comboBox_post.Items.Add(reader[0].ToString());
            }
            reader.Close();
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!char.IsDigit(ch) && ch != 8 && ch != 43)
            {
                e.Handled = true;
            }
        }

        private void button_insert_Click(object sender, EventArgs e)
        {
            string employee_post = comboBox_post.Text;
            string surname = textBox_surname.Text;
            string fname = textBox_fname.Text;
            string midname = textBox_midname.Text;
            string phone = textBox_phone.Text;
            string email = textBox_email.Text;
            
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            string querystring = $"select post.id from post where name = '{employee_post}';";
            SqlCommand command = new SqlCommand(querystring, db_Connection.GetConnection());
            adapter.SelectCommand = command;                                                                               // Поиск post_id по Post.name
            db_Connection.openConnection();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                post_id = int.Parse(reader[0].ToString());
            }
            reader.Close();

            string querystring1 = $"insert into employee values ({post_id}, '{surname}', '{fname}', '{midname}', '{phone}', '{email}')";                 // Добавление данных
            SqlCommand command1 = new SqlCommand(querystring1, db_Connection.GetConnection());
            MessageBox.Show("Новая запись добавлена.", "Добавление новой записи");
            adapter.SelectCommand = command1;
            adapter.Fill(table);
            
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
                 
        }
    }
}
