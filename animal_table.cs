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
    public partial class animal_table : Form
    {
        DB_connection dB_Connection = new DB_connection();
        worksheet wrksheet;
        public animal_table(worksheet owner)
        {
            InitializeComponent();
            wrksheet = owner;
        }

        public animal_table()
        {
        }

        private void animal_table_Load(object sender, EventArgs e)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            string querystring = $"select employee.surname as Фамилия_врача, employee.firstname as Имя_Врача, post.name as Должность_Врача,\r\npet_owner.surname as Фамилия_Владельца, pet_owner.firstname as Имя_Владельца,\r\nanimal.name as Кличка, animal.age as Возраст, animal.sex as Пол, animal.kind_of_animal as Вид,\r\nanimal.breed as Порода \r\nfrom employee, pet_owner, animal, post \r\nwhere animal.ID_employee = employee.id and animal.ID_pet_owner = pet_owner.id and employee.id_post = post.id;";

            SqlCommand command = new SqlCommand(querystring, dB_Connection.GetConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);

            dataGridView_anim.DataSource = table;

            if (wrksheet.Userrole == 5)
            {
                button_del.Enabled = false;
                button_upd.Enabled = false;
            }
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            if (textBox_search.Text != "")
            {
                string value = textBox_search.Text;
                string querystring = $"select employee.surname as Фамилия_врача, employee.firstname as Имя_Врача, post.name as Должность_Врача,\r\npet_owner.surname as Фамилия_Владельца, pet_owner.firstname as Имя_Владельца,\r\nanimal.name as Кличка, animal.age as Возраст, animal.sex as Пол, animal.kind_of_animal as Вид,\r\nanimal.breed as Порода \r\nfrom employee, pet_owner, animal, post \r\nwhere animal.ID_employee = employee.id and animal.ID_pet_owner = pet_owner.id and employee.id_post = post.id and (employee.surname = '{value}' or employee.firstname = '{value}' or animal.name = '{value}' or animal.Sex = '{value}' or animal.kind_of_animal = '{value}' or pet_owner.firstname = '{value}' or pet_owner.surname = '{value}');";

                SqlCommand command = new SqlCommand(querystring, dB_Connection.GetConnection());

                adapter.SelectCommand = command;
                adapter.Fill(table);

                dataGridView_anim.DataSource = table;
            }
            else
            {
                string querystring = $"select employee.surname as Фамилия_врача, employee.firstname as Имя_Врача, post.name as Должность_Врача,\r\npet_owner.surname as Фамилия_Владельца, pet_owner.firstname as Имя_Владельца,\r\nanimal.name as Кличка, animal.age as Возраст, animal.sex as Пол, animal.kind_of_animal as Вид,\r\nanimal.breed as Порода \r\nfrom employee, pet_owner, animal, post \r\nwhere animal.ID_employee = employee.id and animal.ID_pet_owner = pet_owner.id and employee.id_post = post.id;";

                SqlCommand command = new SqlCommand(querystring, dB_Connection.GetConnection());

                adapter.SelectCommand = command;
                adapter.Fill(table);

                dataGridView_anim.DataSource = table;
            }
        }

        private void button_insert_Click(object sender, EventArgs e)
        {
            anim_add anim_Add = new anim_add();
            anim_Add.Show();
            this.Show();
        }

        private void button_del_Click(object sender, EventArgs e)
        {
            anim_del anim_Del = new anim_del();
            anim_Del.Show();
            this.Show();
        }

        private void button_upd_Click(object sender, EventArgs e)
        {

        }
    }
}
