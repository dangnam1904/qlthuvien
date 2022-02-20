namespace QLYTHUVIEN
{
    partial class quanlysach
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
            this.txt_soluong = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_find_by_name = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.cb_tensach = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_find_by_ma = new System.Windows.Forms.TextBox();
            this.cb_masach = new System.Windows.Forms.ComboBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.btn_find_by_ma = new System.Windows.Forms.Button();
            this.Gridview_sach = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Quanr = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_dachomuon = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbo_tenTG = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cb_matacgia = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cb_tenloai = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_MaLoaiSach = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.rtxt_mota = new System.Windows.Forms.RichTextBox();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Gridview_sach)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_find_by_name
            // 
            this.txt_find_by_name.Location = new System.Drawing.Point(473, 52);
            this.txt_find_by_name.Name = "txt_find_by_name";
            this.txt_find_by_name.Size = new System.Drawing.Size(221, 23);
            this.txt_find_by_name.TabIndex = 7;
            this.txt_find_by_name.Text = "Tên cần tìm";
            // 
            // txt_soluong
            // 
            this.txt_soluong.Location = new System.Drawing.Point(110, 146);
            this.txt_soluong.Name = "txt_soluong";
            this.txt_soluong.Size = new System.Drawing.Size(88, 23);
            this.txt_soluong.TabIndex = 12;
            this.txt_soluong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_soluong_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "Mô tả";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Số  lượng sách";
            // 
            // btn_find_by_name
            // 
            this.btn_find_by_name.Location = new System.Drawing.Point(291, 52);
            this.btn_find_by_name.Name = "btn_find_by_name";
            this.btn_find_by_name.Size = new System.Drawing.Size(136, 23);
            this.btn_find_by_name.TabIndex = 5;
            this.btn_find_by_name.Text = "Tìm kiếm theo tên";
            this.btn_find_by_name.UseVisualStyleBackColor = true;
            this.btn_find_by_name.Click += new System.EventHandler(this.bt_find_name_Click);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(55, 52);
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
            this.btn_delete.Location = new System.Drawing.Point(175, 13);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 23);
            this.btn_delete.TabIndex = 3;
            this.btn_delete.Text = "Xóa";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.Location = new System.Drawing.Point(175, 52);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(75, 23);
            this.btn_edit.TabIndex = 2;
            this.btn_edit.Text = "Sửa";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // cb_tensach
            // 
            this.cb_tensach.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cb_tensach.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_tensach.FormattingEnabled = true;
            this.cb_tensach.Location = new System.Drawing.Point(110, 102);
            this.cb_tensach.Name = "cb_tensach";
            this.cb_tensach.Size = new System.Drawing.Size(183, 23);
            this.cb_tensach.TabIndex = 6;
            this.cb_tensach.SelectedIndexChanged += new System.EventHandler(this.cb_tensach_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tên sách";
            // 
            // txt_find_by_ma
            // 
            this.txt_find_by_ma.Location = new System.Drawing.Point(473, 13);
            this.txt_find_by_ma.Name = "txt_find_by_ma";
            this.txt_find_by_ma.Size = new System.Drawing.Size(221, 23);
            this.txt_find_by_ma.TabIndex = 6;
            this.txt_find_by_ma.Text = "Mã cần tìm";
            // 
            // cb_masach
            // 
            this.cb_masach.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cb_masach.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_masach.FormattingEnabled = true;
            this.cb_masach.Location = new System.Drawing.Point(110, 61);
            this.cb_masach.Name = "cb_masach";
            this.cb_masach.Size = new System.Drawing.Size(121, 23);
            this.cb_masach.TabIndex = 2;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(55, 13);
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
            this.label1.Size = new System.Drawing.Size(51, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã sách";
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
            this.panel3.Location = new System.Drawing.Point(0, 523);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(954, 78);
            this.panel3.TabIndex = 5;
            // 
            // btn_refresh
            // 
            this.btn_refresh.BackColor = System.Drawing.SystemColors.Control;
            this.btn_refresh.Location = new System.Drawing.Point(730, 13);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(75, 23);
            this.btn_refresh.TabIndex = 8;
            this.btn_refresh.Text = "Refresh";
            this.btn_refresh.UseVisualStyleBackColor = false;
            this.btn_refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // btn_find_by_ma
            // 
            this.btn_find_by_ma.Location = new System.Drawing.Point(291, 13);
            this.btn_find_by_ma.Name = "btn_find_by_ma";
            this.btn_find_by_ma.Size = new System.Drawing.Size(136, 23);
            this.btn_find_by_ma.TabIndex = 1;
            this.btn_find_by_ma.Text = "Tìm kiếm theo mã";
            this.btn_find_by_ma.UseVisualStyleBackColor = true;
            this.btn_find_by_ma.Click += new System.EventHandler(this.btn_find_ma_Click);
            // 
            // Gridview_sach
            // 
            this.Gridview_sach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Gridview_sach.Location = new System.Drawing.Point(3, 6);
            this.Gridview_sach.Name = "Gridview_sach";
            this.Gridview_sach.RowTemplate.Height = 25;
            this.Gridview_sach.Size = new System.Drawing.Size(948, 262);
            this.Gridview_sach.TabIndex = 0;
            this.Gridview_sach.Click += new System.EventHandler(this.Gridview_sach_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Gridview_sach);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 255);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(954, 346);
            this.panel2.TabIndex = 4;
            // 
            // Quanr
            // 
            this.Quanr.AutoSize = true;
            this.Quanr.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Quanr.Location = new System.Drawing.Point(387, 21);
            this.Quanr.Name = "Quanr";
            this.Quanr.Size = new System.Drawing.Size(125, 21);
            this.Quanr.TabIndex = 0;
            this.Quanr.Text = "QUẢN LÝ SÁCH";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txt_dachomuon);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.cbo_tenTG);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.cb_matacgia);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.cb_tenloai);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cb_MaLoaiSach);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.rtxt_mota);
            this.panel1.Controls.Add(this.txt_soluong);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.cb_tensach);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cb_masach);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Quanr);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(954, 255);
            this.panel1.TabIndex = 3;
            // 
            // txt_dachomuon
            // 
            this.txt_dachomuon.Location = new System.Drawing.Point(346, 146);
            this.txt_dachomuon.Name = "txt_dachomuon";
            this.txt_dachomuon.Size = new System.Drawing.Size(94, 23);
            this.txt_dachomuon.TabIndex = 26;
            this.txt_dachomuon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_dachomuon_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(232, 146);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(108, 15);
            this.label9.TabIndex = 25;
            this.label9.Text = "Số  lượng đã mượn";
            // 
            // cbo_tenTG
            // 
            this.cbo_tenTG.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbo_tenTG.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbo_tenTG.FormattingEnabled = true;
            this.cbo_tenTG.Location = new System.Drawing.Point(718, 205);
            this.cbo_tenTG.Name = "cbo_tenTG";
            this.cbo_tenTG.Size = new System.Drawing.Size(183, 23);
            this.cbo_tenTG.TabIndex = 24;
            this.cbo_tenTG.SelectedIndexChanged += new System.EventHandler(this.cb_TenTG_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(629, 209);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 15);
            this.label7.TabIndex = 23;
            this.label7.Text = "Tên tác giả";
            // 
            // cb_matacgia
            // 
            this.cb_matacgia.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cb_matacgia.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_matacgia.FormattingEnabled = true;
            this.cb_matacgia.Location = new System.Drawing.Point(718, 164);
            this.cb_matacgia.Name = "cb_matacgia";
            this.cb_matacgia.Size = new System.Drawing.Size(121, 23);
            this.cb_matacgia.TabIndex = 22;
            this.cb_matacgia.SelectedIndexChanged += new System.EventHandler(this.cb_matacgia_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(630, 164);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 15);
            this.label8.TabIndex = 21;
            this.label8.Text = "Mã tác giả";
            // 
            // cb_tenloai
            // 
            this.cb_tenloai.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cb_tenloai.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_tenloai.FormattingEnabled = true;
            this.cb_tenloai.Location = new System.Drawing.Point(718, 101);
            this.cb_tenloai.Name = "cb_tenloai";
            this.cb_tenloai.Size = new System.Drawing.Size(183, 23);
            this.cb_tenloai.TabIndex = 20;
            this.cb_tenloai.SelectedIndexChanged += new System.EventHandler(this.cb_tenloai_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(629, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 15);
            this.label2.TabIndex = 19;
            this.label2.Text = "Tên Loại";
            // 
            // cb_MaLoaiSach
            // 
            this.cb_MaLoaiSach.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cb_MaLoaiSach.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_MaLoaiSach.FormattingEnabled = true;
            this.cb_MaLoaiSach.Location = new System.Drawing.Point(718, 60);
            this.cb_MaLoaiSach.Name = "cb_MaLoaiSach";
            this.cb_MaLoaiSach.Size = new System.Drawing.Size(121, 23);
            this.cb_MaLoaiSach.TabIndex = 18;
            this.cb_MaLoaiSach.SelectedIndexChanged += new System.EventHandler(this.cb_MaLoaiSach_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(630, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 15);
            this.label6.TabIndex = 17;
            this.label6.Text = "Mã loại sách";
            // 
            // rtxt_mota
            // 
            this.rtxt_mota.Location = new System.Drawing.Point(110, 187);
            this.rtxt_mota.Name = "rtxt_mota";
            this.rtxt_mota.Size = new System.Drawing.Size(330, 62);
            this.rtxt_mota.TabIndex = 16;
            this.rtxt_mota.Text = "";
            // 
            // quanlysach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 601);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "quanlysach";
            this.Text = "Quản lý sách";
            this.Load += new System.EventHandler(this.quanlysach_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Gridview_sach)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txt_find_by_name;
        private System.Windows.Forms.TextBox txt_soluong;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_find_by_name;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.ComboBox cb_tensach;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_find_by_ma;
        private System.Windows.Forms.ComboBox cb_masach;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.Button btn_find_by_ma;
        private System.Windows.Forms.DataGridView Gridview_sach;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label Quanr;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_dachomuon;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbo_tenTG;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cb_matacgia;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cb_tenloai;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_MaLoaiSach;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox rtxt_mota;
    }
}