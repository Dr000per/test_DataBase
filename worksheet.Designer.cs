namespace test_DataBase
{
    partial class worksheet
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Пользователи", 2, 14);
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Для администратора", 1, 1, new System.Windows.Forms.TreeNode[] {
            treeNode1});
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Сотрудники", 3, 14);
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Должности", 12, 14);
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Услуги", 5, 14);
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Для директора", 6, 6, new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode4,
            treeNode5});
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Диагнозы", 4, 14);
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Курс лечения", 7, 14);
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Животные", 8, 14);
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Для глав. врача", 10, 10, new System.Windows.Forms.TreeNode[] {
            treeNode7,
            treeNode8,
            treeNode9});
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Животные", 8, 14);
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Хозяева", 13, 14);
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Для врача общего приёма", 11, 11, new System.Windows.Forms.TreeNode[] {
            treeNode11,
            treeNode12});
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Животные", 8, 14);
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Курс лечения", 7, 14);
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("Для вет. врача", 9, 9, new System.Windows.Forms.TreeNode[] {
            treeNode14,
            treeNode15});
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("Главное меню", new System.Windows.Forms.TreeNode[] {
            treeNode2,
            treeNode6,
            treeNode10,
            treeNode13,
            treeNode16});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(worksheet));
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.main_pnl = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.BackColor = System.Drawing.SystemColors.Control;
            this.treeView1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.treeView1.ImageIndex = 0;
            this.treeView1.ImageList = this.imageList1;
            this.treeView1.Location = new System.Drawing.Point(12, 12);
            this.treeView1.Name = "treeView1";
            treeNode1.ImageIndex = 2;
            treeNode1.Name = "fr_admin_users";
            treeNode1.SelectedImageIndex = 14;
            treeNode1.Text = "Пользователи";
            treeNode2.ImageIndex = 1;
            treeNode2.Name = "for_admin";
            treeNode2.SelectedImageIndex = 1;
            treeNode2.Text = "Для администратора";
            treeNode3.ImageIndex = 3;
            treeNode3.Name = "fr_director_emp";
            treeNode3.SelectedImageIndex = 14;
            treeNode3.Text = "Сотрудники";
            treeNode4.ImageIndex = 12;
            treeNode4.Name = "fr_director_posts";
            treeNode4.SelectedImageIndex = 14;
            treeNode4.Text = "Должности";
            treeNode5.ImageIndex = 5;
            treeNode5.Name = "fr_director_servs";
            treeNode5.SelectedImageIndex = 14;
            treeNode5.Text = "Услуги";
            treeNode6.ImageIndex = 6;
            treeNode6.Name = "for_director";
            treeNode6.SelectedImageIndex = 6;
            treeNode6.Text = "Для директора";
            treeNode7.ImageIndex = 4;
            treeNode7.Name = "fr_main_doc_disease";
            treeNode7.SelectedImageIndex = 14;
            treeNode7.Text = "Диагнозы";
            treeNode8.ImageIndex = 7;
            treeNode8.Name = "fr_main_doc_thrp";
            treeNode8.SelectedImageIndex = 14;
            treeNode8.Text = "Курс лечения";
            treeNode9.ImageIndex = 8;
            treeNode9.Name = "fr_main_doc_anim";
            treeNode9.SelectedImageIndex = 14;
            treeNode9.Text = "Животные";
            treeNode10.ImageIndex = 10;
            treeNode10.Name = "for_main_doc";
            treeNode10.SelectedImageIndex = 10;
            treeNode10.Text = "Для глав. врача";
            treeNode11.ImageIndex = 8;
            treeNode11.Name = "fr_doc_mngr_animal";
            treeNode11.SelectedImageIndex = 14;
            treeNode11.Text = "Животные";
            treeNode12.ImageIndex = 13;
            treeNode12.Name = "fr_doc_mngr_owners";
            treeNode12.SelectedImageIndex = 14;
            treeNode12.Text = "Хозяева";
            treeNode13.ImageIndex = 11;
            treeNode13.Name = "for_doc_manager";
            treeNode13.SelectedImageIndex = 11;
            treeNode13.Text = "Для врача общего приёма";
            treeNode14.ImageIndex = 8;
            treeNode14.Name = "fr_smpl_doc_animal";
            treeNode14.SelectedImageIndex = 14;
            treeNode14.Text = "Животные";
            treeNode15.ImageIndex = 7;
            treeNode15.Name = "fr_smpl_doc_thrp";
            treeNode15.SelectedImageIndex = 14;
            treeNode15.Text = "Курс лечения";
            treeNode16.ImageIndex = 9;
            treeNode16.Name = "for_simple_doc";
            treeNode16.SelectedImageIndex = 9;
            treeNode16.Text = "Для вет. врача";
            treeNode17.ImageIndex = 0;
            treeNode17.Name = "main_menu";
            treeNode17.Text = "Главное меню";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode17});
            this.treeView1.SelectedImageIndex = 0;
            this.treeView1.Size = new System.Drawing.Size(393, 625);
            this.treeView1.TabIndex = 3;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "icons8-больница-48 (1).png");
            this.imageList1.Images.SetKeyName(1, "icons8-medical-48.png");
            this.imageList1.Images.SetKeyName(2, "icons8-группа-пользователей-2-48.png");
            this.imageList1.Images.SetKeyName(3, "icons8-врач-48.png");
            this.imageList1.Images.SetKeyName(4, "icons8-медицинский-термометр-48.png");
            this.imageList1.Images.SetKeyName(5, "icons8-tonometer-100.png");
            this.imageList1.Images.SetKeyName(6, "icons8-business-85.png");
            this.imageList1.Images.SetKeyName(7, "icons8-medical-48 (1).png");
            this.imageList1.Images.SetKeyName(8, "icons8-профиль-кошки-48.png");
            this.imageList1.Images.SetKeyName(9, "icons8-ветеринар-мужчина-96.png");
            this.imageList1.Images.SetKeyName(10, "icons8-ветеринар-мужчина-48.png");
            this.imageList1.Images.SetKeyName(11, "icons8-медицинская-карта-100.png");
            this.imageList1.Images.SetKeyName(12, "1589130.png");
            this.imageList1.Images.SetKeyName(13, "53143.png");
            this.imageList1.Images.SetKeyName(14, "icons8-отмеченный-чекбокс-2-96.png");
            // 
            // main_pnl
            // 
            this.main_pnl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.main_pnl.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.main_pnl.Location = new System.Drawing.Point(411, 12);
            this.main_pnl.Name = "main_pnl";
            this.main_pnl.Size = new System.Drawing.Size(769, 625);
            this.main_pnl.TabIndex = 4;
            this.main_pnl.Paint += new System.Windows.Forms.PaintEventHandler(this.main_pnl_Paint);
            // 
            // worksheet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1201, 654);
            this.Controls.Add(this.main_pnl);
            this.Controls.Add(this.treeView1);
            this.Name = "worksheet";
            this.Text = "Основное окно программы";
            this.Load += new System.EventHandler(this.worksheet_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Panel main_pnl;
    }
}