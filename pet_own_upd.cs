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
    public partial class pet_own_upd : Form
    {
        DB_connection dB_Connection = new DB_connection();
        StringCheck stringCheck = new StringCheck();
        NumCheck num = new NumCheck();
        public pet_own_upd()
        {
            InitializeComponent();
        }

        private void pet_own_upd_Load(object sender, EventArgs e)
        {
            comboBox_phn.DropDownStyle = ComboBoxStyle.DropDownList;

            string querystring = "select phone from pet_owner;";
            SqlCommand command = new SqlCommand(querystring, dB_Connection.GetConnection());
            dB_Connection.openConnection();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                comboBox_phn.Items.Add(reader[0].ToString());
            }
            reader.Close();
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            string own_phn_now = comboBox_phn.Text;

            object querystr = $"select * from pet_owner where phone = '{own_phn_now}';";
            SqlCommand comm = new SqlCommand((string)querystr, dB_Connection.GetConnection());
            SqlDataReader read = comm.ExecuteReader();
            read.Read();
            object email_now = read.GetValue(5);
            object adr_now = read.GetValue(6);
            object city_now = read.GetValue(7);
            object reg_now = read.GetValue(8);
            read.Close();

            object NewEmail = email_now;
            object NewPhone = own_phn_now;
            object NewAddress = adr_now;
            object NewCity = city_now;
            object NewRegion = reg_now;

            if (checkBox_phone.Checked)
            {
                NewPhone = textBox_phone.Text;                                                                                                                             // Проверка чекбокса с Телефоном
            }
            if (checkBox_email.Checked)
            {
                NewEmail = textBox_email.Text;                                                                                                                             // Проверка чекбокса с Email
            }
            if (checkBox_adr.Checked)
            {
                NewAddress = textBox_adr.Text;                                                                                                                             // Проверка чекбокса с Адресом
            }
            if (checkBox_city.Checked)
            {
                NewCity = textBox_city.Text;                                                                                                                             // Проверка чекбокса с Городом
            }
            if (checkBox_reg.Checked)
            {
                NewRegion = textBox_reg.Text;                                                                                                                             // Проверка чекбокса с Областью
            }

            string zaprosUpd = $"update pet_owner set phone = '{NewPhone}', email = '{NewEmail}', address = '{NewAddress}', city = '{NewCity}', region = '{NewRegion}' where phone = '{own_phn_now}';";
            SqlCommand commanda = new SqlCommand(zaprosUpd, dB_Connection.GetConnection());
            commanda.ExecuteNonQuery();

            MessageBox.Show("Вы изменили данные!", "Оповещение");

            comboBox_phn.Items.Clear();
            string querystring2 = "select phone from pet_owner;";
            SqlCommand command2 = new SqlCommand(querystring2, dB_Connection.GetConnection());
            SqlDataReader reader2 = command2.ExecuteReader();
            while (reader2.Read())
            {
                comboBox_phn.Items.Add(reader2[0].ToString());
            }
            reader2.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            textBox_adr.Text = null; textBox_city.Text = null; textBox_email.Text = null; textBox_phone.Text = null; textBox_reg.Text= null;
        }

        private void textBox_reg_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (stringCheck.StringIsValid(c) && c != '\b' && c != ' ')
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }

        private void textBox_phone_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (num.checknum(c) || c == '+' || c == '\b')
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void textBox_email_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if ((c < 'A' || c > 'z') && c != '\b' && c != '.' && c != '@' && !num.checknum(c))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }

        private void textBox_adr_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;

            if (stringCheck.StringIsValid(c) && c != '\b' && c != 46 && c != ' ' && c != ',' && !num.checknum(c))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }

        private void textBox_city_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (stringCheck.StringIsValid(c) && c != '\b' && c != ' ')
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
