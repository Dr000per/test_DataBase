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
    public partial class pet_own_del : Form
    {
        DB_connection dB_Connection = new DB_connection();
        public pet_own_del()
        {
            InitializeComponent();
        }

        private void pet_own_del_Load(object sender, EventArgs e)
        {
            string querystring = "select phone from pet_owner";
            SqlCommand command = new SqlCommand(querystring, dB_Connection.GetConnection());
            dB_Connection.openConnection();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                comboBox1.Items.Add(reader[0].ToString());
            }
            reader.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            object phn= comboBox1.Text;
            DialogResult dr = MessageBox.Show("Вы уверены что хотите удалить данные об этом владельце животного?",
                      "Подтверждение", MessageBoxButtons.YesNo);
            switch (dr)
            {
                case DialogResult.Yes:
                    string querystring = $"delete from pet_owner where phone = '{phn}'";
                    SqlCommand command = new SqlCommand(querystring, dB_Connection.GetConnection());
                    command.ExecuteNonQuery();

                    comboBox1.Items.Clear();
                    comboBox1.Text = null;

                    string querystring1 = "select phone from pet_owner";
                    SqlCommand command1 = new SqlCommand(querystring1, dB_Connection.GetConnection());
                    dB_Connection.openConnection();
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
