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
using System.Security.Cryptography;

namespace test_DataBase
{
    public partial class auth : Form
    {
        Timer timer1 = new Timer();
        int i = 0;
        DB_connection db_Connection = new DB_connection();
        public auth()
        {
            InitializeComponent();
            StartPosition= FormStartPosition.CenterScreen;
        }


        private void textBox_login_TextChanged(object sender, EventArgs e)
        {

        }

        private void auth_Load(object sender, EventArgs e)
        {
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Interval = 10000;

            textBox_password.PasswordChar = '*';
            pictureBox2.Visible = false;
            textBox_login.MaxLength= 20;
            textBox_password.MaxLength= 30;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            button1.Enabled = true;
            i = 0;
            timer1.Stop();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            i++;
            if (i >= 4)
            {
                MessageBox.Show("Превышено попыток входа, попробуйте ещё раз через 10 секунд.", "Ошибка", MessageBoxButtons.OK);
                button1.Enabled = false;
                timer1.Start();
            }
            var loginUser = textBox_login.Text;
            var passwordUser = textBox_password.Text;

            SqlDataAdapter adapter= new SqlDataAdapter();
            DataTable table= new DataTable();

            string querystring = $"select id, login, password from users where login = '{loginUser}' and password = '{passwordUser}'";

            SqlCommand command = new SqlCommand(querystring, db_Connection.GetConnection());

            adapter.SelectCommand= command;
            adapter.Fill(table);

            if (table.Rows.Count == 1 )
            {
                MessageBox.Show("Вход выполнен успешно!", "Вход", MessageBoxButtons.OK, MessageBoxIcon.Information);
                worksheet wrksheet = new worksheet();
                this.Hide();
                wrksheet.ShowDialog();
                this.Show();
            }
            else 
            {
                MessageBox.Show("Такого аккаунта не существует! Зарегистрируйтесь.", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            reg form_reg = new reg();
            form_reg.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            textBox_login.Text = "";
            textBox_password.Text = "";

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            textBox_password.UseSystemPasswordChar = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = true;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            textBox_password.UseSystemPasswordChar = true;
            pictureBox2.Visible = true;
            pictureBox3.Visible = false;
        }
    }
}
