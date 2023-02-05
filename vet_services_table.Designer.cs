namespace test_DataBase
{
    partial class vet_services_table
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
            this.button_del = new System.Windows.Forms.Button();
            this.button_upd = new System.Windows.Forms.Button();
            this.button_insert = new System.Windows.Forms.Button();
            this.button_search = new System.Windows.Forms.Button();
            this.textBox_search = new System.Windows.Forms.TextBox();
            this.dataGridView_services = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_services)).BeginInit();
            this.SuspendLayout();
            // 
            // button_del
            // 
            this.button_del.Location = new System.Drawing.Point(347, 92);
            this.button_del.Name = "button_del";
            this.button_del.Size = new System.Drawing.Size(100, 27);
            this.button_del.TabIndex = 17;
            this.button_del.Text = "Удалить";
            this.button_del.UseVisualStyleBackColor = true;
            this.button_del.Click += new System.EventHandler(this.button_del_Click);
            // 
            // button_upd
            // 
            this.button_upd.Location = new System.Drawing.Point(347, 59);
            this.button_upd.Name = "button_upd";
            this.button_upd.Size = new System.Drawing.Size(100, 27);
            this.button_upd.TabIndex = 16;
            this.button_upd.Text = "Изменить";
            this.button_upd.UseVisualStyleBackColor = true;
            this.button_upd.Click += new System.EventHandler(this.button_upd_Click);
            // 
            // button_insert
            // 
            this.button_insert.Location = new System.Drawing.Point(347, 26);
            this.button_insert.Name = "button_insert";
            this.button_insert.Size = new System.Drawing.Size(100, 27);
            this.button_insert.TabIndex = 15;
            this.button_insert.Text = "Добавить";
            this.button_insert.UseVisualStyleBackColor = true;
            this.button_insert.Click += new System.EventHandler(this.button_insert_Click);
            // 
            // button_search
            // 
            this.button_search.Location = new System.Drawing.Point(241, 92);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(100, 27);
            this.button_search.TabIndex = 14;
            this.button_search.Text = "Поиск";
            this.button_search.UseVisualStyleBackColor = true;
            this.button_search.Click += new System.EventHandler(this.button_search_Click);
            // 
            // textBox_search
            // 
            this.textBox_search.Location = new System.Drawing.Point(36, 96);
            this.textBox_search.Name = "textBox_search";
            this.textBox_search.Size = new System.Drawing.Size(199, 20);
            this.textBox_search.TabIndex = 13;
            // 
            // dataGridView_services
            // 
            this.dataGridView_services.AllowUserToAddRows = false;
            this.dataGridView_services.AllowUserToDeleteRows = false;
            this.dataGridView_services.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_services.Location = new System.Drawing.Point(36, 122);
            this.dataGridView_services.Name = "dataGridView_services";
            this.dataGridView_services.ReadOnly = true;
            this.dataGridView_services.Size = new System.Drawing.Size(411, 163);
            this.dataGridView_services.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(30, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 31);
            this.label1.TabIndex = 11;
            this.label1.Text = "Услуги";
            // 
            // vet_services_table
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 295);
            this.Controls.Add(this.button_del);
            this.Controls.Add(this.button_upd);
            this.Controls.Add(this.button_insert);
            this.Controls.Add(this.button_search);
            this.Controls.Add(this.textBox_search);
            this.Controls.Add(this.dataGridView_services);
            this.Controls.Add(this.label1);
            this.Name = "vet_services_table";
            this.Text = "Услуги";
            this.Load += new System.EventHandler(this.vet_srevices_table_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_services)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_del;
        private System.Windows.Forms.Button button_upd;
        private System.Windows.Forms.Button button_insert;
        private System.Windows.Forms.Button button_search;
        private System.Windows.Forms.TextBox textBox_search;
        private System.Windows.Forms.DataGridView dataGridView_services;
        private System.Windows.Forms.Label label1;
    }
}