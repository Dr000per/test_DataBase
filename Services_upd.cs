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
    public partial class Services_upd : Form
    {
        DB_connection dB_Connection = new DB_connection();
        public Services_upd()
        {
            InitializeComponent();
        }

        private void Services_upd_Load(object sender, EventArgs e)
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
            string name_serv = comboBox1.Text;
            double price = Convert.ToDouble(textBox_price.Text);
            string querystring = $"update Vet_services set price = {price} where name = '{name_serv}';";
            SqlCommand command = new SqlCommand(querystring, dB_Connection.GetConnection());
            dB_Connection.openConnection();
            command.ExecuteNonQuery();

            MessageBox.Show("Данные обновлены!", "Оповещение");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
