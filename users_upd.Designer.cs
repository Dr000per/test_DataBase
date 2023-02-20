namespace test_DataBase
{
    partial class users_upd
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_log = new System.Windows.Forms.ComboBox();
            this.textBox_pass = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox_roles = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBox_pass = new System.Windows.Forms.CheckBox();
            this.checkBox_roles = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(403, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Обновление данных пользователя (пароль и роль):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(52, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 18);
            this.label2.TabIndex = 12;
            this.label2.Text = "Пароль (новый):";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(121, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 18);
            this.label1.TabIndex = 11;
            this.label1.Text = "Логин:";
            // 
            // comboBox_log
            // 
            this.comboBox_log.FormattingEnabled = true;
            this.comboBox_log.Location = new System.Drawing.Point(182, 117);
            this.comboBox_log.Name = "comboBox_log";
            this.comboBox_log.Size = new System.Drawing.Size(151, 21);
            this.comboBox_log.TabIndex = 10;
            // 
            // textBox_pass
            // 
            this.textBox_pass.Location = new System.Drawing.Point(182, 153);
            this.textBox_pass.Name = "textBox_pass";
            this.textBox_pass.Size = new System.Drawing.Size(151, 20);
            this.textBox_pass.TabIndex = 9;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(200, 271);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(111, 27);
            this.button2.TabIndex = 8;
            this.button2.Text = "Отмена";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(200, 238);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 27);
            this.button1.TabIndex = 7;
            this.button1.Text = "Обновить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox_roles
            // 
            this.comboBox_roles.FormattingEnabled = true;
            this.comboBox_roles.Location = new System.Drawing.Point(182, 195);
            this.comboBox_roles.Name = "comboBox_roles";
            this.comboBox_roles.Size = new System.Drawing.Size(151, 21);
            this.comboBox_roles.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(121, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 18);
            this.label4.TabIndex = 15;
            this.label4.Text = "Роль:";
            // 
            // checkBox_pass
            // 
            this.checkBox_pass.AutoSize = true;
            this.checkBox_pass.Location = new System.Drawing.Point(339, 155);
            this.checkBox_pass.Name = "checkBox_pass";
            this.checkBox_pass.Size = new System.Drawing.Size(83, 17);
            this.checkBox_pass.TabIndex = 16;
            this.checkBox_pass.Text = "Изменить?";
            this.checkBox_pass.UseVisualStyleBackColor = true;
            // 
            // checkBox_roles
            // 
            this.checkBox_roles.AutoSize = true;
            this.checkBox_roles.Location = new System.Drawing.Point(339, 197);
            this.checkBox_roles.Name = "checkBox_roles";
            this.checkBox_roles.Size = new System.Drawing.Size(83, 17);
            this.checkBox_roles.TabIndex = 17;
            this.checkBox_roles.Text = "Изменить?";
            this.checkBox_roles.UseVisualStyleBackColor = true;
            // 
            // users_upd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 315);
            this.Controls.Add(this.checkBox_roles);
            this.Controls.Add(this.checkBox_pass);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox_roles);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox_log);
            this.Controls.Add(this.textBox_pass);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "users_upd";
            this.Text = "users_upd";
            this.Load += new System.EventHandler(this.users_upd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_log;
        private System.Windows.Forms.TextBox textBox_pass;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox_roles;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBox_pass;
        private System.Windows.Forms.CheckBox checkBox_roles;
    }
}