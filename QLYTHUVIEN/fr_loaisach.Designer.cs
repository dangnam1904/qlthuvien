namespace QLYTHUVIEN
{
    partial class fr_loaisach
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
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Gridview_loaisach = new System.Windows.Forms.DataGridView();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.btn_find_by_ma = new System.Windows.Forms.Button();
            this.cb_TenLoai = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txt_find_by_name = new System.Windows.Forms.TextBox();
            this.txt_find_by_ma = new System.Windows.Forms.TextBox();
            this.btn_find_by_name = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.cb_MaLoai = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Quanr = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_kieusach = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Gridview_loaisach)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "Kiểu sách";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Gridview_loaisach);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 158);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 214);
            this.panel2.TabIndex = 7;
            // 
            // Gridview_loaisach
            // 
            this.Gridview_loaisach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Gridview_loaisach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Gridview_loaisach.Location = new System.Drawing.Point(0, 0);
            this.Gridview_loaisach.Name = "Gridview_loaisach";
            this.Gridview_loaisach.RowTemplate.Height = 25;
            this.Gridview_loaisach.Size = new System.Drawing.Size(800, 214);
            this.Gridview_loaisach.TabIndex = 0;
            this.Gridview_loaisach.Click += new System.EventHandler(this.Gridview_loaisach_Click);
            // 
            // btn_refresh
            // 
            this.btn_refresh.BackColor = System.Drawing.SystemColors.Control;
            this.btn_refresh.Location = new System.Drawing.Point(663, 13);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(75, 23);
            this.btn_refresh.TabIndex = 8;
            this.btn_refresh.Text = "Refresh";
            this.btn_refresh.UseVisualStyleBackColor = false;
            this.btn_refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // btn_find_by_ma
            // 
            this.btn_find_by_ma.Location = new System.Drawing.Point(260, 12);
            this.btn_find_by_ma.Name = "btn_find_by_ma";
            this.btn_find_by_ma.Size = new System.Drawing.Size(136, 23);
            this.btn_find_by_ma.TabIndex = 1;
            this.btn_find_by_ma.Text = "Tìm kiếm theo mã";
            this.btn_find_by_ma.UseVisualStyleBackColor = true;
            this.btn_find_by_ma.Click += new System.EventHandler(this.btn_find_ma_Click);
            // 
            // cb_TenLoai
            // 
            this.cb_TenLoai.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cb_TenLoai.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_TenLoai.FormattingEnabled = true;
            this.cb_TenLoai.Location = new System.Drawing.Point(512, 60);
            this.cb_TenLoai.Name = "cb_TenLoai";
            this.cb_TenLoai.Size = new System.Drawing.Size(202, 23);
            this.cb_TenLoai.TabIndex = 6;
            this.cb_TenLoai.SelectedIndexChanged += new System.EventHandler(this.cb_TenLoai_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(404, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tên loại sách";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btn_refresh);
            this.panel3.Controls.Add(this.txt_find_by_name);
            this.panel3.Controls.Add(this.txt_find_by_ma);
            this.panel3.Controls.Add(this.btn_find_by_name);
            this.panel3.Controls.Add(this.btn_save);
            this.panel3.Controls.Add(this.btn_delete);
            this.panel3.Controls.Add(this.btn_edit);
            this.panel3.Controls.Add(this.btn_find_by_ma);
            this.panel3.Controls.Add(this.btn_add);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 372);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(800, 78);
            this.panel3.TabIndex = 8;
            this.panel3.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // txt_find_by_name
            // 
            this.txt_find_by_name.Location = new System.Drawing.Point(418, 52);
            this.txt_find_by_name.Name = "txt_find_by_name";
            this.txt_find_by_name.Size = new System.Drawing.Size(221, 23);
            this.txt_find_by_name.TabIndex = 7;
            this.txt_find_by_name.Text = "Tên cần tìm";
            // 
            // txt_find_by_ma
            // 
            this.txt_find_by_ma.Location = new System.Drawing.Point(418, 13);
            this.txt_find_by_ma.Name = "txt_find_by_ma";
            this.txt_find_by_ma.Size = new System.Drawing.Size(221, 23);
            this.txt_find_by_ma.TabIndex = 6;
            this.txt_find_by_ma.Text = "Mã cần tìm";
            // 
            // btn_find_by_name
            // 
            this.btn_find_by_name.Location = new System.Drawing.Point(260, 51);
            this.btn_find_by_name.Name = "btn_find_by_name";
            this.btn_find_by_name.Size = new System.Drawing.Size(136, 23);
            this.btn_find_by_name.TabIndex = 5;
            this.btn_find_by_name.Text = "Tìm kiếm theo tên";
            this.btn_find_by_name.UseVisualStyleBackColor = true;
            this.btn_find_by_name.Click += new System.EventHandler(this.bt_find_name_Click);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(29, 52);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 4;
            this.btn_save.Text = "Lưu";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.SystemColors.Control;
            this.btn_delete.Location = new System.Drawing.Point(144, 12);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 23);
            this.btn_delete.TabIndex = 3;
            this.btn_delete.Text = "Xóa";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.Location = new System.Drawing.Point(144, 51);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(75, 23);
            this.btn_edit.TabIndex = 2;
            this.btn_edit.Text = "Sửa";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(29, 13);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 0;
            this.btn_add.Text = "Thêm";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // cb_MaLoai
            // 
            this.cb_MaLoai.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cb_MaLoai.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_MaLoai.FormattingEnabled = true;
            this.cb_MaLoai.Location = new System.Drawing.Point(110, 61);
            this.cb_MaLoai.Name = "cb_MaLoai";
            this.cb_MaLoai.Size = new System.Drawing.Size(121, 23);
            this.cb_MaLoai.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã loại sách";
            // 
            // Quanr
            // 
            this.Quanr.AutoSize = true;
            this.Quanr.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Quanr.Location = new System.Drawing.Point(307, 9);
            this.Quanr.Name = "Quanr";
            this.Quanr.Size = new System.Drawing.Size(169, 21);
            this.Quanr.TabIndex = 0;
            this.Quanr.Text = "QUẢN LÝ  LOẠI SÁCH";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txt_kieusach);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.cb_TenLoai);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cb_MaLoai);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Quanr);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 158);
            this.panel1.TabIndex = 6;
            // 
            // txt_kieusach
            // 
            this.txt_kieusach.Location = new System.Drawing.Point(110, 110);
            this.txt_kieusach.Name = "txt_kieusach";
            this.txt_kieusach.Size = new System.Drawing.Size(257, 23);
            this.txt_kieusach.TabIndex = 12;
            // 
            // fr_loaisach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "fr_loaisach";
            this.Text = "Quản lý loại sách";
            this.Load += new System.EventHandler(this.fr_loaisach_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Gridview_loaisach)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView Gridview_loaisach;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.Button btn_find_by_ma;
        private System.Windows.Forms.ComboBox cb_TenLoai;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txt_find_by_name;
        private System.Windows.Forms.TextBox txt_find_by_ma;
        private System.Windows.Forms.Button btn_find_by_name;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.ComboBox cb_MaLoai;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Quanr;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_kieusach;
    }
}