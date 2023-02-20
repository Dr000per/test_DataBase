using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test_DataBase
{
    public partial class worksheet : Form
    {
        private Form active;
        public worksheet()
        {
            InitializeComponent();
        }

        public int Userrole = 5;

        private void main_pnl_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PanelForm(Form frm)
        {
            if (active != null)
            {
                active.Close();
            }
            active = frm;
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            this.main_pnl.Controls.Add(frm);
            this.main_pnl.Tag = frm;
            frm.BringToFront();
            frm.Show();
        }

        public void worksheet_Load(object sender, EventArgs e)
        {
            this.Hide();
            new auth(this).Show();
            treeView1.Enabled = false;
            
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            switch (e.Node.Text)
            {
                case "Пользователи":
                    if (Userrole == 1)
                    {
                        PanelForm(new Users_table());
                    }
                    break;

                case "Сотрудники":
                    if (Userrole == 1 || Userrole == 2)
                    {
                        PanelForm(new empl_table());
                    }
                    break;

                case "Должности":
                    if (Userrole == 1 || Userrole == 2)
                    {
                        PanelForm(new Post_table());
                    }
                    break;

                case "Услуги":
                    if(Userrole == 1 || Userrole == 2)
                    {
                        PanelForm(new vet_services_table());
                    }
                    break;

                case "Диагнозы":
                    if (Userrole == 1 || Userrole == 2 || Userrole == 3)
                    {
                        PanelForm(new disease_table());
                    }
                    break;

            }
        }
    }
}

