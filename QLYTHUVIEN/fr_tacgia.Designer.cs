namespace QLYTHUVIEN
{
    partial class fr_tacgia
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
            this.txt_find_by_name = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_find_by_name = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.cb_TenTG = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_find_by_ma = new System.Windows.Forms.TextBox();
            this.cb_MaTG = new System.Windows.Forms.ComboBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.btn_find_by_ma = new System.Windows.Forms.Button();
            this.Gridview_TacGia = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Quanr = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rtxt_thongtin = new System.Windows.Forms.RichTextBox();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Gridview_TacGia)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_find_by_name
            // 
            this.txt_find_by_name.Location = new System.Drawing.Point(418, 52);
            this.txt_find_by_name.Name = "txt_find_by_name";
            this.txt_find_by_name.Size = new System.Drawing.Size(221, 23);
            this.txt_find_by_name.TabIndex = 7;
            this.txt_find_by_name.Text = "Tên cần tìm";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "Tóm tắt thông tin";
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
            // cb_TenTG
            // 
            this.cb_TenTG.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cb_TenTG.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_TenTG.FormattingEnabled = true;
            this.cb_TenTG.Location = new System.Drawing.Point(512, 60);
            this.cb_TenTG.Name = "cb_TenTG";
            this.cb_TenTG.Size = new System.Drawing.Size(202, 23);
            this.cb_TenTG.TabIndex = 6;
            this.cb_TenTG.SelectedIndexChanged += new System.EventHandler(this.cb_TenTG_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(404, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tên tác giả";
            // 
            // txt_find_by_ma
            // 
            this.txt_find_by_ma.Location = new System.Drawing.Point(418, 13);
            this.txt_find_by_ma.Name = "txt_find_by_ma";
            this.txt_find_by_ma.Size = new System.Drawing.Size(221, 23);
            this.txt_find_by_ma.TabIndex = 6;
            this.txt_find_by_ma.Text = "Mã cần tìm";
            // 
            // cb_MaTG
            // 
            this.cb_MaTG.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cb_MaTG.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_MaTG.FormattingEnabled = true;
            this.cb_MaTG.Location = new System.Drawing.Point(110, 61);
            this.cb_MaTG.Name = "cb_MaTG";
            this.cb_MaTG.Size = new System.Drawing.Size(121, 23);
            this.cb_MaTG.TabIndex = 2;
            this.cb_MaTG.SelectedIndexChanged += new System.EventHandler(this.cb_MaTG_SelectedIndexChanged);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã tác giả";
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
            this.panel3.Size = new System.Drawing.Size(761, 78);
            this.panel3.TabIndex = 5;
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
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
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
            // Gridview_TacGia
            // 
            this.Gridview_TacGia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Gridview_TacGia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Gridview_TacGia.Location = new System.Drawing.Point(0, 0);
            this.Gridview_TacGia.Name = "Gridview_TacGia";
            this.Gridview_TacGia.RowTemplate.Height = 25;
            this.Gridview_TacGia.Size = new System.Drawing.Size(761, 257);
            this.Gridview_TacGia.TabIndex = 0;
            this.Gridview_TacGia.Click += new System.EventHandler(this.Gridview_TacGia_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Gridview_TacGia);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 193);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(761, 257);
            this.panel2.TabIndex = 4;
            // 
            // Quanr
            // 
            this.Quanr.AutoSize = true;
            this.Quanr.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Quanr.Location = new System.Drawing.Point(307, 9);
            this.Quanr.Name = "Quanr";
            this.Quanr.Size = new System.Drawing.Size(143, 21);
            this.Quanr.TabIndex = 0;
            this.Quanr.Text = "QUẢN LÝ TÁC GIẢ";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rtxt_thongtin);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.cb_TenTG);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cb_MaTG);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Quanr);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(761, 193);
            this.panel1.TabIndex = 3;
            // 
            // rtxt_thongtin
            // 
            this.rtxt_thongtin.Location = new System.Drawing.Point(144, 107);
            this.rtxt_thongtin.Name = "rtxt_thongtin";
            this.rtxt_thongtin.Size = new System.Drawing.Size(568, 80);
            this.rtxt_thongtin.TabIndex = 12;
            this.rtxt_thongtin.Text = "";
            // 
            // fr_tacgia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 450);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "fr_tacgia";
            this.Text = "Quản lý tác giả";
            this.Load += new System.EventHandler(this.fr_tacgia_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Gridview_TacGia)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txt_find_by_name;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_find_by_name;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.ComboBox cb_TenTG;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_find_by_ma;
        private System.Windows.Forms.ComboBox cb_MaTG;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.Button btn_find_by_ma;
        private System.Windows.Forms.DataGridView Gridview_TacGia;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label Quanr;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox rtxt_thongtin;
    }
}