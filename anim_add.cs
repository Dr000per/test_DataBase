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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace test_DataBase
{
    public partial class anim_add : Form
    {
        DB_connection dB_Connection = new DB_connection();
        public anim_add()
        {
            InitializeComponent();
        }

        private void comboBox_Sname_doc_SelectedIndexChanged(object sender, EventArgs e)
        {
            var surname = comboBox_Sname_doc.Text;
            string querystring = $"select employee.firstname, employee.middlename, post.name  from employee, post where employee.surname = '{surname}' and employee.id_post = post.id;";
            SqlCommand command = new SqlCommand(querystring, dB_Connection.GetConnection());
            dB_Connection.openConnection();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                comboBox_Fname.Items.Add(reader[0].ToString());
                comboBox_Mname.Items.Add(reader[1].ToString());
                comboBox_post.Items.Add(reader[2].ToString());
            }
            reader.Close();
            if (comboBox_Fname.Items.Count > 1 && comboBox_Mname.Items.Count > 1 && comboBox_post.Items.Count > 1)
            {
                comboBox_Fname.Items.RemoveAt(0);
                comboBox_Mname.Items.RemoveAt(0);
                comboBox_post.Items.RemoveAt(0);
            }
            else
            {
                
            }
        }

        private void anim_add_Load(object sender, EventArgs e)
        {
            string querystring = "select surname from employee where id_post != 1;";
            SqlCommand command = new SqlCommand(querystring, dB_Connection.GetConnection());
            dB_Connection.openConnection();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                comboBox_Sname_doc.Items.Add(reader[0].ToString());
            }
            reader.Close();


            string querystring1 = "select surname from pet_owner;";
            SqlCommand command1 = new SqlCommand(querystring1, dB_Connection.GetConnection());
            dB_Connection.openConnection();
            SqlDataReader reader1 = command1.ExecuteReader();
            while (reader1.Read())
            {
                comboBox_Sname_own.Items.Add(reader1[0].ToString());
            }
            reader1.Close();

            comboBox_sex.Items.Add("Самец");
            comboBox_sex.Items.Add("Самка");
        }

        private void comboBox_Sname_own_SelectedIndexChanged(object sender, EventArgs e)
        {
            var surname = comboBox_Sname_own.Text;
            string querystring = $"select firstname, phone  from pet_owner where surname = '{surname}';";
            SqlCommand command = new SqlCommand(querystring, dB_Connection.GetConnection());
            dB_Connection.openConnection();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                comboBox_Fname_own.Items.Add(reader[0].ToString());
                comboBox_own_phn.Items.Add(reader[1].ToString());
            }
            reader.Close();

            if (comboBox_Fname_own.Items.Count > 1 && comboBox_own_phn.Items.Count > 1)
            {
                comboBox_Fname_own.Items.RemoveAt(0);
                comboBox_own_phn.Items.RemoveAt(0);
            }
            else
            {

            }

        }

        private void button_insert_Click(object sender, EventArgs e)
        {
            string sname_doc = comboBox_Sname_doc.Text;
            string sname_own = comboBox_Sname_own.Text;
            string fname_doc = comboBox_Fname.Text;
            string fname_own = comboBox_Fname_own.Text;
            string mname_doc = comboBox_Mname.Text;
            string post = comboBox_post.Text;
            string phone = comboBox_own_phn.Text;
            string anim_name = textBox_name.Text;
            string anim_age = textBox_age.Text;
            string anim_sex = comboBox_sex.Text;
            string anim_kind = textBox_kind.Text;
            string anim_breed = textBox_breed.Text;

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            
            try
            {
                if (comboBox_Fname.Text != null && comboBox_Fname_own.Text != null && comboBox_Mname.Text != null && comboBox_own_phn.Text != null && comboBox_post.Text != null && comboBox_sex.Text != null && comboBox_Sname_doc.Text != null && comboBox_Sname_own.Text != null && textBox_age.Text != null && textBox_breed.Text != null && textBox_kind.Text != null && textBox_name.Text != null)
                {
                    int id_empl = 0;
                    int id_own = 0;

                    string querystring = $"select employee.id from employee, post where employee.surname = '{sname_doc}' and employee.firstname = '{fname_doc}' and employee.middlename = '{mname_doc}' and employee.id_post = (select id from post where name = '{post}');";
                    SqlCommand command = new SqlCommand(querystring, dB_Connection.GetConnection());
                    adapter.SelectCommand = command;                                                                               // Поиск employee.id по sname_doc, fname_doc, mname_doc и post
                    dB_Connection.openConnection();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        id_empl = int.Parse(reader[0].ToString());
                    }
                    reader.Close();

                    string querystring1 = $"select id from pet_owner where surname = '{sname_own}' and firstname = '{fname_own}' and phone = '{phone}';";
                    SqlCommand command1 = new SqlCommand(querystring1, dB_Connection.GetConnection());
                    adapter.SelectCommand = command1;                                                                               // Поиск pet_owner.id по sname_own, fname_own и phone
                    dB_Connection.openConnection();
                    SqlDataReader reader1 = command1.ExecuteReader();
                    while (reader1.Read())
                    {
                        id_own = int.Parse(reader1[0].ToString());
                    }
                    reader1.Close();

                    string querystring2 = $"insert into animal values ({id_empl}, {id_own}, '{anim_name}', '{anim_age}', '{anim_sex}', '{anim_kind}', '{anim_breed}');";                 // Добавление данных
                    SqlCommand command2 = new SqlCommand(querystring2, dB_Connection.GetConnection());
                    adapter.SelectCommand = command2;
                    adapter.Fill(table);
                    MessageBox.Show("Новая запись добавлена.", "Добавление новой записи");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Вы заполнили не все данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            textBox_age.Text = null;
            textBox_breed.Text = null;
            textBox_kind.Text = null;
            textBox_name.Text = null;
            comboBox_sex.Text = null;
            comboBox_Fname_own.Text = null;
            comboBox_Mname.Text = null;
            comboBox_Fname.Text = null;
            comboBox_own_phn.Text = null;
            comboBox_Sname_doc.Text = null;
            comboBox_Sname_own.Text = null;
            comboBox_post.Text = null;
        }
    }
}
