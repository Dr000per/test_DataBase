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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace test_DataBase
{
    public partial class empl_update : Form
    {
        DB_connection db_Connection = new DB_connection();
        public empl_update()
        {
            InitializeComponent();
        }
        
        private void empl_update_Load(object sender, EventArgs e)
        {
            comboBox_post.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_email.DropDownStyle = ComboBoxStyle.DropDownList;
            

            string querystring = "select name from post where id != 1;";
            SqlCommand command = new SqlCommand(querystring, db_Connection.GetConnection());
            db_Connection.openConnection();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                comboBox_post.Items.Add(reader[0].ToString());
            }
            reader.Close();

            string querystring1 = "select Employee.email from Employee where id != 1;";
            SqlCommand command1 = new SqlCommand(querystring1, db_Connection.GetConnection());
            SqlDataReader reader1 = command1.ExecuteReader();
            while (reader1.Read())
            {
                comboBox_email.Items.Add(reader1[0].ToString()); 
            }
            reader1.Close();
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_insert_Click(object sender, EventArgs e)
        {
            string empl_email_now = comboBox_email.Text;

            object querystr = $"select * from employee where Email = '{empl_email_now}';";
            SqlCommand comm = new SqlCommand((string)querystr, db_Connection.GetConnection());
            SqlDataReader read = comm.ExecuteReader();
            read.Read();
            object id_post = read.GetValue(1);
            object empl_phone_now = read.GetValue(5);
            read.Close();
            
            object empl_post = comboBox_post.Text;
            object NewEmail = empl_email_now;
            object NewPhone = empl_phone_now;
            object post_id = id_post;

            if (checkBox_post.Checked) 
            {
                string querystring1 = $"select id from post where name = '{empl_post}';";
                SqlCommand command1 = new SqlCommand(querystring1, db_Connection.GetConnection());                                                        // Поиск ID по Post.name и проверка чекбокса с должностью
                db_Connection.openConnection();
                SqlDataReader reader = command1.ExecuteReader();
                while (reader.Read())
                { 
                    post_id = int.Parse(reader[0].ToString());
                }
                reader.Close();
            }
            if (checkBox_email.Checked)
            {
                NewEmail = textBox_email.Text;                                                                                                                             // Проверка чекбокса с Email
            }
            if (checkBox_phone.Checked)
            {
                NewPhone = textBox_phone.Text;                                                                                                                             // Проверка чекбокса с Телефоном
            }

            string zaprosUpd = $"update Employee set id_post = {post_id}, phone = '{NewPhone}', email = '{NewEmail}' where Email = '{empl_email_now}';";
            SqlCommand commanda = new SqlCommand(zaprosUpd, db_Connection.GetConnection());
            commanda.ExecuteNonQuery();

            MessageBox.Show("Вы изменили данные!", "Оповещение");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            comboBox_email.Text = null;
            comboBox_post.Text = null;
            textBox_email.Text = null;
            textBox_phone.Text = null;
        }

        private void textBox_phone_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!char.IsDigit(ch) && ch != 8 && ch != 43)
            {
                e.Handled = true;
            }
        }
    }
}
