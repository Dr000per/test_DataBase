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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace test_DataBase
{
    public partial class anim_del : Form
    {
        DB_connection dB_Connection = new DB_connection();
        public anim_del()
        {
            InitializeComponent();
        }

        private void anim_del_Load(object sender, EventArgs e)
        {
            string querystring = $"select name from animal";
            SqlCommand command = new SqlCommand(querystring, dB_Connection.GetConnection());
            dB_Connection.openConnection();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                comboBox_name.Items.Add(reader[0].ToString());
            }
            reader.Close();
        }

        private void comboBox_name_SelectedIndexChanged(object sender, EventArgs e)
        {
            string name = comboBox_name.Text;

            string querystring1 = $"select pet_owner.phone from pet_owner where pet_owner.id = (select id_pet_owner from animal where name = '{name}');";
            SqlCommand command1 = new SqlCommand(querystring1, dB_Connection.GetConnection());
            dB_Connection.openConnection();
            SqlDataReader reader1 = command1.ExecuteReader();
            while (reader1.Read())
            {
                comboBox_own_phn.Items.Add(reader1[0].ToString());
            }
            reader1.Close();

            if (comboBox_own_phn.Items.Count > 1)
            {
                comboBox_own_phn.Items.RemoveAt(0);
            }
            else
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = (string)comboBox_name.SelectedItem;
            string phone = (string)comboBox_own_phn.SelectedItem;

            DialogResult dr = MessageBox.Show("Вы уверены что хотите удалить данные об этом животном?",
                      "Подтверждение", MessageBoxButtons.YesNo);
            switch (dr)
            {
                case DialogResult.Yes:
                    string querystring2 = $"delete from animal where name = '{name}' and id_pet_owner = (select id from pet_owner where phone = '{phone}') ";
                    SqlCommand command2 = new SqlCommand(querystring2, dB_Connection.GetConnection());
                    command2.ExecuteNonQuery();

                    comboBox_name.Items.Clear();
                    comboBox_name.Text = null;
                    comboBox_own_phn.Items.Clear();
                    comboBox_own_phn.Text = null;

                    string querystring3 = $"select name from animal";
                    SqlCommand command3 = new SqlCommand(querystring3, dB_Connection.GetConnection());
                    dB_Connection.openConnection();
                    SqlDataReader reader2 = command3.ExecuteReader();
                    while (reader2.Read())
                    {
                        comboBox_name.Items.Add(reader2[0].ToString());
                    }
                    reader2.Close();

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
