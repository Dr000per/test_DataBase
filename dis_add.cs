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
using System.Xml.Linq;

namespace test_DataBase
{
    public partial class dis_add : Form
    {
        DB_connection dB_Connection = new DB_connection();
        public dis_add()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string dis = textBox1.Text;

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            string querystring = $"insert into disease values ('{dis}')";                 // Добавление данных
            SqlCommand command = new SqlCommand(querystring, dB_Connection.GetConnection());
            MessageBox.Show("Новая запись добавлена.", "Добавление новой записи");
            adapter.SelectCommand = command;
            adapter.Fill(table);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dis_add_Load(object sender, EventArgs e)
        {
        
        }
    }
}
