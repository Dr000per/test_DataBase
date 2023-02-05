namespace test_DataBase
{
    partial class empl_update
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(empl_update));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.checkBox_email = new System.Windows.Forms.CheckBox();
            this.checkBox_phone = new System.Windows.Forms.CheckBox();
            this.checkBox_post = new System.Windows.Forms.CheckBox();
            this.comboBox_email = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button_cancel = new System.Windows.Forms.Button();
            this.button_update = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox_post = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_email = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_phone = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.checkBox_email);
            this.panel1.Controls.Add(this.checkBox_phone);
            this.panel1.Controls.Add(this.checkBox_post);
            this.panel1.Controls.Add(this.comboBox_email);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.button_cancel);
            this.panel1.Controls.Add(this.button_update);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.comboBox_post);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.textBox_email);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.textBox_phone);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-1, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(419, 258);
            this.panel1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(362, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(44, 38);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // checkBox_email
            // 
            this.checkBox_email.AutoSize = true;
            this.checkBox_email.Location = new System.Drawing.Point(101, 160);
            this.checkBox_email.Name = "checkBox_email";
            this.checkBox_email.Size = new System.Drawing.Size(15, 14);
            this.checkBox_email.TabIndex = 20;
            this.checkBox_email.UseVisualStyleBackColor = true;
            // 
            // checkBox_phone
            // 
            this.checkBox_phone.AutoSize = true;
            this.checkBox_phone.Location = new System.Drawing.Point(78, 134);
            this.checkBox_phone.Name = "checkBox_phone";
            this.checkBox_phone.Size = new System.Drawing.Size(15, 14);
            this.checkBox_phone.TabIndex = 19;
            this.checkBox_phone.UseVisualStyleBackColor = true;
            // 
            // checkBox_post
            // 
            this.checkBox_post.AutoSize = true;
            this.checkBox_post.Location = new System.Drawing.Point(53, 107);
            this.checkBox_post.Name = "checkBox_post";
            this.checkBox_post.Size = new System.Drawing.Size(15, 14);
            this.checkBox_post.TabIndex = 18;
            this.checkBox_post.UseVisualStyleBackColor = true;
            // 
            // comboBox_email
            // 
            this.comboBox_email.FormattingEnabled = true;
            this.comboBox_email.Location = new System.Drawing.Point(208, 66);
            this.comboBox_email.Name = "comboBox_email";
            this.comboBox_email.Size = new System.Drawing.Size(178, 21);
            this.comboBox_email.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(18, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 22);
            this.label2.TabIndex = 16;
            this.label2.Text = "Email сотрудника:";
            // 
            // button_cancel
            // 
            this.button_cancel.Location = new System.Drawing.Point(208, 210);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(178, 24);
            this.button_cancel.TabIndex = 15;
            this.button_cancel.Text = "Отмена";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // button_update
            // 
            this.button_update.Location = new System.Drawing.Point(208, 180);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(178, 24);
            this.button_update.TabIndex = 14;
            this.button_update.Text = "Обновить";
            this.button_update.UseVisualStyleBackColor = true;
            this.button_update.Click += new System.EventHandler(this.button_insert_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(54, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(297, 22);
            this.label7.TabIndex = 13;
            this.label7.Text = "Обновление данных сотрудника:";
            // 
            // comboBox_post
            // 
            this.comboBox_post.FormattingEnabled = true;
            this.comboBox_post.Location = new System.Drawing.Point(208, 101);
            this.comboBox_post.Name = "comboBox_post";
            this.comboBox_post.Size = new System.Drawing.Size(178, 21);
            this.comboBox_post.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(122, 154);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 22);
            this.label6.TabIndex = 11;
            this.label6.Text = "Email:";
            // 
            // textBox_email
            // 
            this.textBox_email.Location = new System.Drawing.Point(208, 154);
            this.textBox_email.Name = "textBox_email";
            this.textBox_email.Size = new System.Drawing.Size(178, 20);
            this.textBox_email.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(95, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 22);
            this.label5.TabIndex = 9;
            this.label5.Text = "Телефон:";
            // 
            // textBox_phone
            // 
            this.textBox_phone.Location = new System.Drawing.Point(208, 128);
            this.textBox_phone.Name = "textBox_phone";
            this.textBox_phone.Size = new System.Drawing.Size(178, 20);
            this.textBox_phone.TabIndex = 8;
            this.textBox_phone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_phone_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(74, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Должность:";
            // 
            // empl_update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 255);
            this.Controls.Add(this.panel1);
            this.Name = "empl_update";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Изменение сотрудников";
            this.Load += new System.EventHandler(this.empl_update_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.Button button_update;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox_post;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_email;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_phone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_email;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBox_email;
        private System.Windows.Forms.CheckBox checkBox_phone;
        private System.Windows.Forms.CheckBox checkBox_post;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}