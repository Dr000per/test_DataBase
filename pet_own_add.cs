using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test_DataBase
{
    public partial class pet_own_add : Form
    {
        DB_connection dB_Connection = new DB_connection();
        StringCheck stringCheck = new StringCheck();
        NumCheck num = new NumCheck();

        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        public pet_own_add()
        {
            InitializeComponent();
        }

        private void button_insert_Click(object sender, EventArgs e)
        {
            string surname = textBox_Sname.Text;
            string fname = textBox_Fname.Text;
            string midname = textBox_Mname.Text;
            string phone = textBox_phn.Text;
            string email = textBox_email.Text;
            string address = textBox_adr.Text;
            string city = textBox_city.Text;
            string region = textBox_reg.Text;

            try
            {
                string querystring = $"insert into pet_owner values ('{surname}', '{fname}', '{midname}', '{phone}', '{email}', '{address}', '{city}', '{region}')";                 // Добавление данных
                SqlCommand command = new SqlCommand(querystring, dB_Connection.GetConnection());
                adapter.SelectCommand = command;
                adapter.Fill(table);
                MessageBox.Show("Новая запись добавлена.", "Добавление новой записи");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Все поля кроме Email должны обязательно быть заполнены", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void textBox_phn_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textBox_sname_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (stringCheck.StringIsValid(c) && c != '\b')
            {
                e.Handled= true;
            }
            else
            {
                e.Handled = false;
            } 
        }

        private void pet_own_add_Load(object sender, EventArgs e)
        {

        }

        private void textBox_fname_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (stringCheck.StringIsValid(c) && c != '\b')
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }

        private void textBox_Mname_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (stringCheck.StringIsValid(c) && c != '\b')
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

        private void button_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            textBox_adr.Text = null; textBox_reg.Text = null; textBox_city.Text = null; textBox_email.Text = null;  
            textBox_Fname.Text = null; textBox_Mname.Text = null; textBox_phn.Text = null; textBox_Sname.Text = null; 
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
    }
}
