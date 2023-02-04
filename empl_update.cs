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
            string empl_post = comboBox_post.Text;
            string empl_email_new= textBox_email.Text;
            string empl_phone = textBox_phone.Text;
            int post_id = 0;

            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter();
                string querystring1 = $"select id from post where name = '{empl_post}';";
                SqlCommand command1 = new SqlCommand(querystring1, db_Connection.GetConnection());
                adapter.SelectCommand = command1;                                                                               // Поиск ID по Post.name
                db_Connection.openConnection();
                SqlDataReader reader = command1.ExecuteReader();
                while (reader.Read())
                {

                    post_id = int.Parse(reader[0].ToString());
                    MessageBox.Show(post_id.ToString());
                }
                reader.Close();
                if (checkBox_post.Checked == true && checkBox_phone.Checked == false && checkBox_email.Checked == false)
                {
                    string querystring = $"update Employee\r\nset id_post = '{post_id}', Email = Email, Phone = Phone\r\nwhere Email = '{empl_email_now}';";
                    SqlCommand command = new SqlCommand(querystring, db_Connection.GetConnection());

                    MessageBox.Show("Вы успешно сменили должность сотрудника!", "Оповещение");
                }
                else if (checkBox_email.Checked && !checkBox_phone.Checked && !checkBox_post.Checked)
                {
                    string querystring = $"update Employee\r\nset id_post = id_post, Email = '{empl_email_new}', Phone = Phone\r\nwhere Email = '{empl_email_now}';";
                    SqlCommand command = new SqlCommand(querystring, db_Connection.GetConnection());

                    MessageBox.Show("Вы успешно сменили Email сотрудника!", "Оповещение");
                }
                else if (checkBox_phone.Checked && !checkBox_post.Checked && !checkBox_email.Checked)
                {
                    string querystring = $"update Employee\r\nset id_post = id_post, Email = Email, Phone = '{empl_phone}'\r\nwhere Email = '{empl_email_now}';";
                    SqlCommand command = new SqlCommand(querystring, db_Connection.GetConnection());

                    MessageBox.Show("Вы успешно сменили телефон сотрудника!", "Оповещение");
                }
                else if (checkBox_post.Checked == true && checkBox_email.Checked == true && checkBox_phone.Checked == false)
                {
                    string querystring = $"update Employee set id_post = '{post_id}', Email = '{empl_email_new}', Phone = Phone where Email = '{empl_email_now}' and employee.id_post = post.id;";
                    SqlCommand command = new SqlCommand(querystring, db_Connection.GetConnection());
                    MessageBox.Show(empl_email_now.ToString(), "Сейчас email");
                    MessageBox.Show(empl_email_new.ToString(), "Теперь email");
                    MessageBox.Show(post_id.ToString(), "Должность");
                    MessageBox.Show("Вы успешно сменили должность и Email сотрудника!", "Оповещение");
                }
                else if (checkBox_phone.Checked && checkBox_email.Checked && !checkBox_post.Checked)
                {
                    string querystring = $"update Employee\r\nset id_post = id_post, Email = '{empl_email_new}', Phone = '{empl_phone}'\r\nwhere Email = '{empl_email_now}';";
                    SqlCommand command = new SqlCommand(querystring, db_Connection.GetConnection());

                    MessageBox.Show("Вы успешно сменили телефон и Email сотрудника!", "Оповещение");
                }
                else if (checkBox_phone.Checked && checkBox_post.Checked && !checkBox_email.Checked)
                {
                    string querystring = $"update Employee\r\nset id_post = '{post_id}', Email = Email, Phone = '{empl_phone}'\r\nwhere Email = '{empl_email_now}';";
                    SqlCommand command = new SqlCommand(querystring, db_Connection.GetConnection());

                    MessageBox.Show("Вы успешно сменили должность и телефон сотрудника!", "Оповещение");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Выберите пункты, которые хотите обновить.", "Оповещение");
            }
        }
    }
}
