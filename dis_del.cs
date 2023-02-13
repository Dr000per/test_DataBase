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
    public partial class dis_del : Form
    {
        DB_connection db_connection = new DB_connection();
        public dis_del()
        {
            InitializeComponent();
        }

        private void dis_del_Load(object sender, EventArgs e)
        {
            string querystring = "select name from disease";
            SqlCommand command = new SqlCommand(querystring, db_connection.GetConnection());
            db_connection.openConnection();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                comboBox1.Items.Add(reader[0].ToString());
            }
            reader.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            object name = comboBox1.Text;
            DialogResult dr = MessageBox.Show("Вы уверены что хотите удалить данные об этом сотруднике?",
                      "Подтверждение", MessageBoxButtons.YesNo);
            switch (dr)
            {
                case DialogResult.Yes:
                    string querystring = $"delete from disease where name = '{name}'";
                    SqlCommand command = new SqlCommand(querystring, db_connection.GetConnection());
                    command.ExecuteNonQuery();

                    comboBox1.Items.Clear();
                    comboBox1.Text = null;

                    string querystring1 = "select email from employee where id != 1";
                    SqlCommand command1 = new SqlCommand(querystring1, db_connection.GetConnection());
                    db_connection.openConnection();
                    SqlDataReader reader = command1.ExecuteReader();
                    while (reader.Read())
                    {
                        comboBox1.Items.Add(reader[0].ToString());
                    }
                    reader.Close();

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
