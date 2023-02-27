namespace test_DataBase
{
    partial class pet_owner_table
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
            this.button_upd = new System.Windows.Forms.Button();
            this.button_del = new System.Windows.Forms.Button();
            this.button_insert = new System.Windows.Forms.Button();
            this.button_search = new System.Windows.Forms.Button();
            this.textBox_search = new System.Windows.Forms.TextBox();
            this.dataGridView_pet_own = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_pet_own)).BeginInit();
            this.SuspendLayout();
            // 
            // button_upd
            // 
            this.button_upd.Location = new System.Drawing.Point(509, 82);
            this.button_upd.Name = "button_upd";
            this.button_upd.Size = new System.Drawing.Size(100, 27);
            this.button_upd.TabIndex = 31;
            this.button_upd.Text = "Изменить";
            this.button_upd.UseVisualStyleBackColor = true;
            this.button_upd.Click += new System.EventHandler(this.button_upd_Click);
            // 
            // button_del
            // 
            this.button_del.Location = new System.Drawing.Point(509, 114);
            this.button_del.Name = "button_del";
            this.button_del.Size = new System.Drawing.Size(100, 27);
            this.button_del.TabIndex = 30;
            this.button_del.Text = "Удалить";
            this.button_del.UseVisualStyleBackColor = true;
            this.button_del.Click += new System.EventHandler(this.button_del_Click);
            // 
            // button_insert
            // 
            this.button_insert.Location = new System.Drawing.Point(509, 49);
            this.button_insert.Name = "button_insert";
            this.button_insert.Size = new System.Drawing.Size(100, 27);
            this.button_insert.TabIndex = 29;
            this.button_insert.Text = "Добавить";
            this.button_insert.UseVisualStyleBackColor = true;
            this.button_insert.Click += new System.EventHandler(this.button_insert_Click);
            // 
            // button_search
            // 
            this.button_search.Location = new System.Drawing.Point(393, 114);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(100, 27);
            this.button_search.TabIndex = 28;
            this.button_search.Text = "Поиск";
            this.button_search.UseVisualStyleBackColor = true;
            this.button_search.Click += new System.EventHandler(this.button_search_Click);
            // 
            // textBox_search
            // 
            this.textBox_search.Location = new System.Drawing.Point(69, 118);
            this.textBox_search.Name = "textBox_search";
            this.textBox_search.Size = new System.Drawing.Size(306, 20);
            this.textBox_search.TabIndex = 27;
            // 
            // dataGridView_pet_own
            // 
            this.dataGridView_pet_own.AllowUserToAddRows = false;
            this.dataGridView_pet_own.AllowUserToDeleteRows = false;
            this.dataGridView_pet_own.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_pet_own.Location = new System.Drawing.Point(69, 144);
            this.dataGridView_pet_own.Name = "dataGridView_pet_own";
            this.dataGridView_pet_own.ReadOnly = true;
            this.dataGridView_pet_own.Size = new System.Drawing.Size(668, 258);
            this.dataGridView_pet_own.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(63, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 31);
            this.label1.TabIndex = 25;
            this.label1.Text = "Хозяева животных:";
            // 
            // pet_owner_table
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_upd);
            this.Controls.Add(this.button_del);
            this.Controls.Add(this.button_insert);
            this.Controls.Add(this.button_search);
            this.Controls.Add(this.textBox_search);
            this.Controls.Add(this.dataGridView_pet_own);
            this.Controls.Add(this.label1);
            this.Name = "pet_owner_table";
            this.Text = "pet_owner_table";
            this.Load += new System.EventHandler(this.pet_owner_table_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_pet_own)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_upd;
        private System.Windows.Forms.Button button_del;
        private System.Windows.Forms.Button button_insert;
        private System.Windows.Forms.Button button_search;
        private System.Windows.Forms.TextBox textBox_search;
        private System.Windows.Forms.DataGridView dataGridView_pet_own;
        private System.Windows.Forms.Label label1;
    }
}