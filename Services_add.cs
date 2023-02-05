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
using System.Xml.Linq;

namespace test_DataBase
{
    public partial class Services_add : Form
    {
        DB_connection dB_Connection = new DB_connection();
        public Services_add()
        {
            InitializeComponent();
        }

        private void button_insert_Click(object sender, EventArgs e)
        {
            string namepost = textBox_name.Text;
            string price = textBox_price.Text;

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            string querystring = $"insert into vet_services values ('{namepost}', {price})";                 // Добавление данных
            SqlCommand command = new SqlCommand(querystring, dB_Connection.GetConnection());
            MessageBox.Show("Новая запись добавлена.", "Добавление новой записи");
            adapter.SelectCommand = command;
            adapter.Fill(table);
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            textBox_name.Text = null; 
            textBox_price.Text = null;
        }
    }
}
