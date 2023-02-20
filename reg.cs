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
    public partial class reg : Form
    {
        int employee_id = 0;
        Timer timer1 = new Timer();
        int i = 0;
        DB_connection dB_Connection = new DB_connection();
        public reg()
        {
            InitializeComponent();
            StartPosition= FormStartPosition.CenterScreen;
        }

        private void cr_acc_bth_Click(object sender, EventArgs e)
        {
            i++;
            if (i >= 4)
            {
                MessageBox.Show("Превышено попыток входа, попробуйте ещё раз через 10 секунд.", "Ошибка", MessageBoxButtons.OK);                    // Блокировка кнопки
                cr_acc_bth.Enabled = false;
                timer1.Start();
            }
            if (lblcaptcha.Text == textBox_captcha.Text)
            {
                if (checkUser())
                {
                    return;
                }

                
                var loginUs = textBox_login2.Text;
                var passwordUs = textBox_password2.Text;
                string employee_email = comboBox1.Text;

                SqlDataAdapter adapter = new SqlDataAdapter();
                string querystring2 = $"select Employee.id from employee where email = '{employee_email}';";
                SqlCommand command1 = new SqlCommand(querystring2, dB_Connection.GetConnection());
                adapter.SelectCommand = command1;                                                                                       // Поиск ID_employee по Email
                dB_Connection.openConnection();
                SqlDataReader reader = command1.ExecuteReader();
                while (reader.Read())
                {
                    employee_id = int.Parse(reader[0].ToString());
                }
                reader.Close();

                if (loginUs != "" && passwordUs != "")
                {
                    string querystring = $"insert into users(id_employee, id_role, login, password) values ({employee_id}, 5, '{loginUs}', '{passwordUs}')";

                    SqlCommand command = new SqlCommand(querystring, dB_Connection.GetConnection());
                                                                                                                                                            // Внесение данных о новом аккаунте
                    dB_Connection.openConnection();

                    if (command.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Вы успешно создали аккаунт!", "Регистрация");
                        auth frm_auth = new auth();
                        this.Hide();
                        frm_auth.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Произошла ошибка регистрации! Аккаунт уже существует.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    dB_Connection.closeConnection();
                }
                else
                {
                    MessageBox.Show("Заполните все поля!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Введена неверная каптча! Попробуйте ещё раз.");
                this.OnLoad(e);
                textBox_captcha.Text = "";
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            cr_acc_bth.Enabled = true;
            i = 0;                                                                                                                      // Разблокировка кнопки
            timer1.Stop();
        }
        
        private Boolean checkUser()
        {
            string employee_email = comboBox1.Text;
            var loginUser = textBox_login2.Text;
            var PassUser = textBox_password2.Text;
            
            SqlDataAdapter adapter= new SqlDataAdapter();
            DataTable table= new DataTable();

            string querystring2 = $"select Employee.id from employee where email = '{employee_email}';";
            SqlCommand command1 = new SqlCommand(querystring2, dB_Connection.GetConnection());
            adapter.SelectCommand = command1;                                                                               // Поиск ID_employee по Email
            dB_Connection.openConnection();
            SqlDataReader reader = command1.ExecuteReader();
            while (reader.Read())
            {

               employee_id = int.Parse(reader[0].ToString());
            }
            reader.Close();

            string querystring = $"select * from users where id_employee = {employee_id} or login = '{loginUser}' and password = '{PassUser}'";                 // Проверка на совпадение с уже имеющимися данными
            SqlCommand command = new SqlCommand(querystring, dB_Connection.GetConnection());

            adapter.SelectCommand= command;
            adapter.Fill(table);

            if (table.Rows.Count > 0) 
            {
                MessageBox.Show("Аккаунт уже существует.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            else 
            {
                return false;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            textBox_password2.UseSystemPasswordChar = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = true;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            textBox_password2.UseSystemPasswordChar = true;
            pictureBox2.Visible = true;
            pictureBox3.Visible = false;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            textBox_login2.Text = "";
            textBox_password2.Text = "";
            textBox_captcha.Text = "";
        }

        private void reg_Load(object sender, EventArgs e)
        {
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Interval = 10000;

            textBox_password2.PasswordChar = '*';
            pictureBox2.Visible = false;
            textBox_login2.MaxLength = 50;
            textBox_password2.MaxLength = 50;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;

            Random rand = new Random();
            int num = rand.Next(4, 6);
            string captcha = "";
            int totl = 0;
            do
            {
                int chr = rand.Next(48, 123);
                if ((chr >= 48 && chr <= 57) || (chr >= 65 && chr <= 90) || (chr >= 97 && chr <= 122))
                {
                    captcha = captcha + (char)chr;
                    totl++;
                    if (totl > num)
                        break;
                    {
                    }
                }
            } while (true);
            lblcaptcha.Text = captcha;

            string querystring1 = "select Employee.email from Employee where not exists (select 1 from Users where Users.ID_employee = Employee.id);";
            SqlCommand command = new SqlCommand(querystring1, dB_Connection.GetConnection());
            dB_Connection.openConnection();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                comboBox1.Items.Add(reader[0].ToString());
            }
            reader.Close();
        }
    }
}
