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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace test_DataBase
{
    public partial class empl_update : Form
    {
        DB_connection db_Connection = new DB_connection();
        public empl_update()
        {
            InitializeComponent();
        }

        private void empl_update_Load(object sender, EventArgs e)
        {
            comboBox_post.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_email.DropDownStyle = ComboBoxStyle.DropDownList;

            string querystring = "select name from post where id != 1;";
            SqlCommand command = new SqlCommand(querystring, db_Connection.GetConnection());
            db_Connection.openConnection();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                comboBox_post.Items.Add(reader[0].ToString());
            }
            reader.Close();

            string querystring1 = "select Employee.email from Employee;";
            SqlCommand command1 = new SqlCommand(querystring1, db_Connection.GetConnection());
            SqlDataReader reader1 = command1.ExecuteReader();
            while (reader1.Read())
            {
                comboBox_email.Items.Add(reader1[0].ToString()); 
            }
            reader1.Close();
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_insert_Click(object sender, EventArgs e)
        {
            string empl_email_now = comboBox_email.Text;
            string empl_post = comboBox_post.Text;
            string empl_email_new= textBox_email.Text;
            string empl_phone = textBox_phone.Text;
            try
            {
                if(checkBox_post.Checked)
                {
                    string querystring = $"update Employee\r\nset Post = '{empl_post}', Email = Email, Phone = Phone\r\nwhere Email = '{empl_email_now}';";
                    SqlCommand command = new SqlCommand(querystring, db_Connection.GetConnection());
                }
                else if (checkBox_email.Checked) {

                }
            }
            catch(Exception ex)
            {

            }
        }
    }
}
