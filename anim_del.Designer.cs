namespace test_DataBase
{
    partial class anim_del
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
            this.comboBox_name = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_own_phn = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // comboBox_name
            // 
            this.comboBox_name.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_name.FormattingEnabled = true;
            this.comboBox_name.Location = new System.Drawing.Point(37, 47);
            this.comboBox_name.Name = "comboBox_name";
            this.comboBox_name.Size = new System.Drawing.Size(145, 21);
            this.comboBox_name.TabIndex = 12;
            this.comboBox_name.SelectedIndexChanged += new System.EventHandler(this.comboBox_name_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(33, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Кличка животного:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(152, 150);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Отмена";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(141, 91);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 32);
            this.button1.TabIndex = 9;
            this.button1.Text = "Удалить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(202, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Номер хозяина:";
            // 
            // comboBox_own_phn
            // 
            this.comboBox_own_phn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_own_phn.FormattingEnabled = true;
            this.comboBox_own_phn.Location = new System.Drawing.Point(206, 47);
            this.comboBox_own_phn.Name = "comboBox_own_phn";
            this.comboBox_own_phn.Size = new System.Drawing.Size(145, 21);
            this.comboBox_own_phn.TabIndex = 14;
            // 
            // anim_del
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 185);
            this.Controls.Add(this.comboBox_own_phn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox_name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "anim_del";
            this.Text = "anim_del";
            this.Load += new System.EventHandler(this.anim_del_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_own_phn;
    }
}