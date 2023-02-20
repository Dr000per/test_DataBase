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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace test_DataBase
{
    public partial class users_upd : Form
    {
        DB_connection db_Connection = new DB_connection();
        public users_upd()
        {
            InitializeComponent();
        }

        private void users_upd_Load(object sender, EventArgs e)
        {
            comboBox_log.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_roles.DropDownStyle = ComboBoxStyle.DropDownList;


            string querystring = "select login from users where id_employee != 11;";
            SqlCommand command = new SqlCommand(querystring, db_Connection.GetConnection());
            db_Connection.openConnection();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                comboBox_log.Items.Add(reader[0].ToString());
            }
            reader.Close();

            string querystring1 = "select name from roles;";
            SqlCommand command1 = new SqlCommand(querystring1, db_Connection.GetConnection());
            SqlDataReader reader1 = command1.ExecuteReader();
            while (reader1.Read())
            {
                comboBox_roles.Items.Add(reader1[0].ToString());
            }
            reader1.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string log = comboBox_log.Text;
            

            object querystr = $"select * from users where login = '{log}';";
            SqlCommand comm = new SqlCommand((string)querystr, db_Connection.GetConnection());
            SqlDataReader read = comm.ExecuteReader();
            read.Read();
            object id_role = read.GetValue(2);
            object pass_now = read.GetValue(4);
            read.Close();

            object new_role = id_role;
            object NewPass = pass_now;

            DialogResult dr = MessageBox.Show("Вы уверены что хотите обновить данные у этого пользователя?",
                      "Подтверждение", MessageBoxButtons.YesNo);
            switch (dr)
            {
                case DialogResult.Yes:
                    try
                    {
                        if (checkBox_pass.Checked && textBox_pass.Text != null && textBox_pass.Text.Length > 3)
                        {
                            NewPass = textBox_pass.Text;

                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Пароль должен состоять минимум из 3 символов!", "Оповещение");
                    }    
                    if (checkBox_roles.Checked)
                    {
                        string name_role = comboBox_roles.Text;                                                                                                                             // Проверка чекбокса с Email
                        object querystring = $"select id from roles where name = '{name_role}';";
                        SqlCommand command = new SqlCommand((string)querystring, db_Connection.GetConnection());
                        SqlDataReader reader = command.ExecuteReader();
                        reader.Read();
                        new_role = reader.GetValue(0);
                        reader.Close();
                    }

                    string zaprosUpd = $"update users set id_role = {new_role}, password = '{NewPass}' where login = '{log}';";
                    SqlCommand commanda = new SqlCommand(zaprosUpd, db_Connection.GetConnection());
                    commanda.ExecuteNonQuery();

                    MessageBox.Show("Вы изменили данные!", "Оповещение");
                    break;
                case DialogResult.No:
                    break;
            }

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
