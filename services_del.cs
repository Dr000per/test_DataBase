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
    public partial class services_del : Form
    {
        DB_connection dB_Connection = new DB_connection();
        public services_del()
        {
            InitializeComponent();
        }

        private void services_del_Load(object sender, EventArgs e)
        {
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;

            string querystring = "select name from Vet_services;";
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
            object name = comboBox1.Text;
            DialogResult dr = MessageBox.Show("Вы уверены что хотите удалить данные об этом сотруднике?",
                      "Подтверждение", MessageBoxButtons.YesNo);
            switch (dr)
            {
                case DialogResult.Yes:
                    string querystring = $"delete from Vet_services where name = '{name}'";
                    SqlCommand command = new SqlCommand(querystring, dB_Connection.GetConnection());
                    command.ExecuteNonQuery();

                    comboBox1.Items.Clear();
                    comboBox1.Text = null;

                    string querystring1 = "select name from Vet_services;";
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
