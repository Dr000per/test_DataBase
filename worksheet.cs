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

        private void main_pnl_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void PanelForm (Form frm)
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

        private void worksheet_Load(object sender, EventArgs e)
        {
            PanelForm(new reg());
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            switch (e.Node.Text)
            {
                case "Пользователи":
                    PanelForm(new Users_table());
                    break;

                case "Сотрудники":
                    PanelForm(new empl_table());
                    break;
            }
        }
    }
}
