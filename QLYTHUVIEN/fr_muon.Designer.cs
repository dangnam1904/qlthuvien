namespace QLYTHUVIEN
{
    partial class fr_muon
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
            this.txt_slgsach = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cb_tenloai = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_MaLoaiSach = new System.Windows.Forms.ComboBox();
            this.Quanr = new System.Windows.Forms.Label();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.btn_find_by_ma = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txt_find_by_name = new System.Windows.Forms.TextBox();
            this.txt_find_by_ma = new System.Windows.Forms.TextBox();
            this.btn_find_by_name = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.cb_masach = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.GridView_muon = new System.Windows.Forms.DataGridView();
            this.cb_tensach = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.cb_tenTG = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cb_maTG = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.date_ngayhentra = new System.Windows.Forms.DateTimePicker();
            this.date_NgayMuon = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.cb_madocgia = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_tendocgia = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cb_mamuon = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_sl_muon = new System.Windows.Forms.TextBox();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridView_muon)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_slgsach
            // 
            this.txt_slgsach.Location = new System.Drawing.Point(142, 184);
            this.txt_slgsach.Name = "txt_slgsach";
            this.txt_slgsach.Size = new System.Drawing.Size(94, 23);
            this.txt_slgsach.TabIndex = 26;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(28, 184);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 15);
            this.label9.TabIndex = 25;
            this.label9.Text = "Số  lượng sách có";
            // 
            // cb_tenloai
            // 
            this.cb_tenloai.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cb_tenloai.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_tenloai.FormattingEnabled = true;
            this.cb_tenloai.Location = new System.Drawing.Point(573, 111);
            this.cb_tenloai.Name = "cb_tenloai";
            this.cb_tenloai.Size = new System.Drawing.Size(183, 23);
            this.cb_tenloai.TabIndex = 20;
            this.cb_tenloai.SelectedIndexChanged += new System.EventHandler(this.cb_tenloai_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(484, 115);
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
            this.cb_MaLoaiSach.Location = new System.Drawing.Point(573, 70);
            this.cb_MaLoaiSach.Name = "cb_MaLoaiSach";
            this.cb_MaLoaiSach.Size = new System.Drawing.Size(121, 23);
            this.cb_MaLoaiSach.TabIndex = 18;
            this.cb_MaLoaiSach.SelectedIndexChanged += new System.EventHandler(this.cb_MaLoaiSach_SelectedIndexChanged);
            // 
            // Quanr
            // 
            this.Quanr.AutoSize = true;
            this.Quanr.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Quanr.Location = new System.Drawing.Point(528, 20);
            this.Quanr.Name = "Quanr";
            this.Quanr.Size = new System.Drawing.Size(186, 21);
            this.Quanr.TabIndex = 0;
            this.Quanr.Text = "QUẢN LÝ  MƯỢN SÁCH";
            // 
            // btn_refresh
            // 
            this.btn_refresh.BackColor = System.Drawing.SystemColors.Control;
            this.btn_refresh.Location = new System.Drawing.Point(967, 14);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(75, 23);
            this.btn_refresh.TabIndex = 8;
            this.btn_refresh.Text = "Refresh";
            this.btn_refresh.UseVisualStyleBackColor = false;
            this.btn_refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // btn_find_by_ma
            // 
            this.btn_find_by_ma.Location = new System.Drawing.Point(528, 14);
            this.btn_find_by_ma.Name = "btn_find_by_ma";
            this.btn_find_by_ma.Size = new System.Drawing.Size(136, 23);
            this.btn_find_by_ma.TabIndex = 1;
            this.btn_find_by_ma.Text = "Tìm kiếm theo mã";
            this.btn_find_by_ma.UseVisualStyleBackColor = true;
            this.btn_find_by_ma.Click += new System.EventHandler(this.btn_find_ma_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(485, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 15);
            this.label6.TabIndex = 17;
            this.label6.Text = "Mã loại sách";
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
            this.panel3.Location = new System.Drawing.Point(0, 546);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1209, 78);
            this.panel3.TabIndex = 8;
            // 
            // txt_find_by_name
            // 
            this.txt_find_by_name.Location = new System.Drawing.Point(710, 53);
            this.txt_find_by_name.Name = "txt_find_by_name";
            this.txt_find_by_name.Size = new System.Drawing.Size(221, 23);
            this.txt_find_by_name.TabIndex = 7;
            this.txt_find_by_name.Text = "Tên sách cần tìm";
            // 
            // txt_find_by_ma
            // 
            this.txt_find_by_ma.Location = new System.Drawing.Point(710, 14);
            this.txt_find_by_ma.Name = "txt_find_by_ma";
            this.txt_find_by_ma.Size = new System.Drawing.Size(221, 23);
            this.txt_find_by_ma.TabIndex = 6;
            this.txt_find_by_ma.Text = "Mã mượn cần tìm";
            // 
            // btn_find_by_name
            // 
            this.btn_find_by_name.Location = new System.Drawing.Point(528, 53);
            this.btn_find_by_name.Name = "btn_find_by_name";
            this.btn_find_by_name.Size = new System.Drawing.Size(136, 23);
            this.btn_find_by_name.TabIndex = 5;
            this.btn_find_by_name.Text = "Tìm kiếm theo tên";
            this.btn_find_by_name.UseVisualStyleBackColor = true;
            this.btn_find_by_name.Click += new System.EventHandler(this.bt_find_name_Click);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(292, 53);
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
            this.btn_delete.Location = new System.Drawing.Point(412, 14);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 23);
            this.btn_delete.TabIndex = 3;
            this.btn_delete.Text = "Xóa";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.Location = new System.Drawing.Point(412, 53);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(75, 23);
            this.btn_edit.TabIndex = 2;
            this.btn_edit.Text = "Sửa";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(292, 14);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 0;
            this.btn_add.Text = "Thêm";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // cb_masach
            // 
            this.cb_masach.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cb_masach.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_masach.FormattingEnabled = true;
            this.cb_masach.Location = new System.Drawing.Point(142, 105);
            this.cb_masach.Name = "cb_masach";
            this.cb_masach.Size = new System.Drawing.Size(121, 23);
            this.cb_masach.TabIndex = 2;
            this.cb_masach.SelectedIndexChanged += new System.EventHandler(this.cb_masach_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.GridView_muon);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 255);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1209, 369);
            this.panel2.TabIndex = 7;
            // 
            // GridView_muon
            // 
            this.GridView_muon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridView_muon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridView_muon.Location = new System.Drawing.Point(0, 0);
            this.GridView_muon.Name = "GridView_muon";
            this.GridView_muon.RowTemplate.Height = 25;
            this.GridView_muon.Size = new System.Drawing.Size(1209, 369);
            this.GridView_muon.TabIndex = 0;
            this.GridView_muon.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridView_muon_CellContentClick);
            this.GridView_muon.Click += new System.EventHandler(this.GridView_muon_Click);
            // 
            // cb_tensach
            // 
            this.cb_tensach.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cb_tensach.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_tensach.FormattingEnabled = true;
            this.cb_tensach.Location = new System.Drawing.Point(142, 146);
            this.cb_tensach.Name = "cb_tensach";
            this.cb_tensach.Size = new System.Drawing.Size(183, 23);
            this.cb_tensach.TabIndex = 6;
            this.cb_tensach.SelectedIndexChanged += new System.EventHandler(this.cb_tensach_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tên sách";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã sách";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txt_sl_muon);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.cb_tenTG);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.cb_maTG);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.date_ngayhentra);
            this.panel1.Controls.Add(this.date_NgayMuon);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.cb_madocgia);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.cb_tendocgia);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.cb_mamuon);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.txt_slgsach);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.cb_tenloai);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cb_MaLoaiSach);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.cb_tensach);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cb_masach);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Quanr);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1209, 255);
            this.panel1.TabIndex = 6;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(28, 213);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(92, 15);
            this.label13.TabIndex = 42;
            this.label13.Text = "Số  lượng mượn";
            // 
            // cb_tenTG
            // 
            this.cb_tenTG.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cb_tenTG.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_tenTG.FormattingEnabled = true;
            this.cb_tenTG.Location = new System.Drawing.Point(572, 195);
            this.cb_tenTG.Name = "cb_tenTG";
            this.cb_tenTG.Size = new System.Drawing.Size(183, 23);
            this.cb_tenTG.TabIndex = 41;
            this.cb_tenTG.SelectedIndexChanged += new System.EventHandler(this.cb_TenTG_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(483, 199);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 15);
            this.label8.TabIndex = 40;
            this.label8.Text = "Tên tác giả";
            // 
            // cb_maTG
            // 
            this.cb_maTG.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cb_maTG.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_maTG.FormattingEnabled = true;
            this.cb_maTG.Location = new System.Drawing.Point(572, 154);
            this.cb_maTG.Name = "cb_maTG";
            this.cb_maTG.Size = new System.Drawing.Size(121, 23);
            this.cb_maTG.TabIndex = 39;
            this.cb_maTG.SelectedIndexChanged += new System.EventHandler(this.cb_matacgia_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(484, 154);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 15);
            this.label11.TabIndex = 38;
            this.label11.Text = "Mã tác giả";
            // 
            // date_ngayhentra
            // 
            this.date_ngayhentra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_ngayhentra.Location = new System.Drawing.Point(961, 204);
            this.date_ngayhentra.Name = "date_ngayhentra";
            this.date_ngayhentra.Size = new System.Drawing.Size(113, 23);
            this.date_ngayhentra.TabIndex = 37;
            // 
            // date_NgayMuon
            // 
            this.date_NgayMuon.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_NgayMuon.Location = new System.Drawing.Point(961, 157);
            this.date_NgayMuon.Name = "date_NgayMuon";
            this.date_NgayMuon.Size = new System.Drawing.Size(113, 23);
            this.date_NgayMuon.TabIndex = 36;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(860, 204);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 15);
            this.label7.TabIndex = 34;
            this.label7.Text = "Ngày hẹn trả";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(860, 157);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(70, 15);
            this.label12.TabIndex = 33;
            this.label12.Text = "Ngày mượn";
            // 
            // cb_madocgia
            // 
            this.cb_madocgia.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cb_madocgia.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_madocgia.FormattingEnabled = true;
            this.cb_madocgia.Location = new System.Drawing.Point(944, 76);
            this.cb_madocgia.Name = "cb_madocgia";
            this.cb_madocgia.Size = new System.Drawing.Size(141, 23);
            this.cb_madocgia.TabIndex = 32;
            this.cb_madocgia.SelectedIndexChanged += new System.EventHandler(this.cb_madocgia_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(860, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 15);
            this.label4.TabIndex = 31;
            this.label4.Text = "Mã độc giả";
            // 
            // cb_tendocgia
            // 
            this.cb_tendocgia.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cb_tendocgia.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_tendocgia.FormattingEnabled = true;
            this.cb_tendocgia.Location = new System.Drawing.Point(944, 108);
            this.cb_tendocgia.Name = "cb_tendocgia";
            this.cb_tendocgia.Size = new System.Drawing.Size(183, 23);
            this.cb_tendocgia.TabIndex = 30;
            this.cb_tendocgia.SelectedIndexChanged += new System.EventHandler(this.cb_tendocgia_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(860, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 15);
            this.label5.TabIndex = 29;
            this.label5.Text = "Tên độc giả";
            // 
            // cb_mamuon
            // 
            this.cb_mamuon.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cb_mamuon.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_mamuon.FormattingEnabled = true;
            this.cb_mamuon.Location = new System.Drawing.Point(142, 73);
            this.cb_mamuon.Name = "cb_mamuon";
            this.cb_mamuon.Size = new System.Drawing.Size(121, 23);
            this.cb_mamuon.TabIndex = 28;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(38, 73);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 15);
            this.label10.TabIndex = 27;
            this.label10.Text = "Mã mượn";
            // 
            // txt_sl_muon
            // 
            this.txt_sl_muon.Location = new System.Drawing.Point(142, 213);
            this.txt_sl_muon.Name = "txt_sl_muon";
            this.txt_sl_muon.Size = new System.Drawing.Size(94, 23);
            this.txt_sl_muon.TabIndex = 43;
            // 
            // fr_muon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1209, 624);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "fr_muon";
            this.Text = "Quản lý mượn sách";
            this.Load += new System.EventHandler(this.fr_muon_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridView_muon)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txt_slgsach;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cb_tenloai;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_MaLoaiSach;
        private System.Windows.Forms.Label Quanr;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.Button btn_find_by_ma;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txt_find_by_name;
        private System.Windows.Forms.TextBox txt_find_by_ma;
        private System.Windows.Forms.Button btn_find_by_name;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.ComboBox cb_masach;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView GridView_muon;
        private System.Windows.Forms.ComboBox cb_tensach;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cb_madocgia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cb_tendocgia;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cb_mamuon;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker date_ngayhentra;
        private System.Windows.Forms.DateTimePicker date_NgayMuon;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cb_tenTG;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cb_maTG;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_sl_muon;
    }
}