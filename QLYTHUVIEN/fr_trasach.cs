using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLYTHUVIEN
{
    public partial class fr_trasach : Form
    {
        DataTable trasach;
        public fr_trasach()
        {
            InitializeComponent();
        }

        private void fr_trasach_Load(object sender, EventArgs e)
        {
            LoadDataGridView();
            display_MaDG();
            display_TenDG();
            display_MaTG();
            display_TenTG();
            display_TenLoai();
            display_MaloaiSach();
            display_maMuon();
            display_MaTra();
            display_TenSach();
            display_masach();
        }
        private void LoadDataGridView()
        {
            String sql = "select MaTraSach, nm.MaDG, nm.TenDG, s.MaSach, s.TenSach,tg.MaTG,tg.TenTG,ls.MaLoaiSach, ls.TenLoai, ts.SoLuongTra,ms.ngaymuon,ts.NgayTra, ms.MaMuon" +
                " from TraSach ts join Sach s on s.MaSach=ts.MaSach join TacGia tg on tg.MaTG=s.MaTG join NguoiMuon nm on nm.MaDG=ts.MaDG join LoaiSach ls " +
                "on ls.MaLoaiSach=s.MaLoaiSach join MuonSach ms on ms.MaMuon=ts.Mamuon";
            trasach = Functions.GetDataTable(sql); //Đọc dữ liệu từ bảng
            GridView_tra.DataSource = trasach; //Nguồn dữ liệu            
            GridView_tra.Columns[0].HeaderText = "Mã trả sách";
            GridView_tra.Columns[1].HeaderText = "Mã độc giả";
            GridView_tra.Columns[2].HeaderText = "Tên độc giả";
            GridView_tra.Columns[3].HeaderText = "Mã sách";
            GridView_tra.Columns[4].HeaderText = "Tên sách";
            GridView_tra.Columns[5].HeaderText = "Mã tác giả";
            GridView_tra.Columns[6].HeaderText = "Tên tác giả";
            GridView_tra.Columns[7].HeaderText = "Mã loại sách";
            GridView_tra.Columns[8].HeaderText = "Tên Loại Sách";
            GridView_tra.Columns[9].HeaderText = "Số lượng trả";
            GridView_tra.Columns[10].HeaderText = "Ngày mượn";
            GridView_tra.Columns[11].HeaderText = "Ngày trả";
            GridView_tra.Columns[12].HeaderText = "Mã mượn";

            GridView_tra.AllowUserToAddRows = false; //Không cho người dùng thêm dữ liệu trực tiếp
            GridView_tra.EditMode = DataGridViewEditMode.EditProgrammatically; //Không cho sửa dữ liệu trực tiếp
        }


        private void display_MaloaiSach()
        {
            string sql = " select* from LoaiSach";
            Functions.FillCombo(sql, cb_MaLoaiSach, "MaLoaiSach", "MaLoaiSach");
            cb_MaLoaiSach.SelectedIndex = -1;

        }

        private void display_TenLoai()
        {
            string sql = " select* from LoaiSach";
            Functions.FillCombo(sql, cb_tenloai, "MaLoaiSach", "TenLoai");
            cb_tenloai.SelectedIndex = -1;
        }

        private void display_masach()
        {
            string sql = " select* from sach";
            Functions.FillCombo(sql, cb_masach, "MaSach", "MaSach");
            cb_masach.SelectedIndex = -1;
        }

        private void display_TenSach()
        {
            string sql = " select* from sach";
            Functions.FillCombo(sql, cb_tensach, "MaSach", "TenSach");
            cb_tensach.SelectedIndex = -1;
        }
        private void display_maMuon()
        {
            string sql = "select *from trasach ";
            Functions.FillCombo(sql, cb_mamuon, "MaMuon", "MaMuon");
            cb_mamuon.SelectedIndex = -1;
        }
        private void display_MaDG()
        {
            string sql = "select *from NguoiMuon ";
            Functions.FillCombo(sql, cb_madocgia, "MaDG", "MaDG");
            cb_madocgia.SelectedIndex = -1;
        }
        private void display_TenDG()
        {
            string sql = "select *from NguoiMuon ";
            Functions.FillCombo(sql, cb_tendocgia, "MaDG", "TenDG");
            cb_tendocgia.SelectedIndex = -1;
        }
        private void display_TenTG()
        {
            string sql = "select *from TacGia ";
            Functions.FillCombo(sql, cb_tenTG, "MaTG", "TenTG");
            cb_tenTG.SelectedIndex = -1;
        }
        private void display_MaTG()
        {
            string sql = "select *from TacGia ";
            Functions.FillCombo(sql, cb_maTG, "MaTG", "MaTG");
            cb_maTG.SelectedIndex = -1;
        }
        private void display_MaTra()
        {
            string sql = "select *from TraSach ";
            Functions.FillCombo(sql, cb_matra, "MaTraSach", "MaTraSach");
            cb_matra.SelectedIndex = -1;
        }
        private void GridView_tra_Click(object sender, EventArgs e)
        {
            if (btn_add.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cb_MaLoaiSach.Focus();
                return;
            }
            if (trasach.Rows.Count == 0) //Nếu không có dữ liệu
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            cb_masach.Text = GridView_tra.CurrentRow.Cells["MaSach"].Value.ToString();
            cb_tensach.Text = GridView_tra.CurrentRow.Cells["TenSach"].Value.ToString();
            cb_mamuon.Text = GridView_tra.CurrentRow.Cells["MaMuon"].Value.ToString();
            txt_slgtra.Text = GridView_tra.CurrentRow.Cells["SoLuongTra"].Value.ToString();
            cb_tendocgia.Text = GridView_tra.CurrentRow.Cells["TenDG"].Value.ToString();
            cb_madocgia.Text = GridView_tra.CurrentRow.Cells["MaDG"].Value.ToString();
            cb_MaLoaiSach.Text = GridView_tra.CurrentRow.Cells["MaLoaiSach"].Value.ToString();
            cb_tenloai.Text = GridView_tra.CurrentRow.Cells["TenLoai"].Value.ToString();
            date_Ngaytra.Value = (DateTime)GridView_tra.CurrentRow.Cells["NgayTra"].Value;
            date_ngaymuon.Value = (DateTime)GridView_tra.CurrentRow.Cells["NgayMuon"].Value;
            cb_matra.Text = GridView_tra.CurrentRow.Cells["MaTraSach"].Value.ToString();
            cb_maTG.Text = GridView_tra.CurrentRow.Cells["MaTG"].Value.ToString();
            cb_tenTG.Text = GridView_tra.CurrentRow.Cells["TenTG"].Value.ToString();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            Resetvalues();
            cb_matra.Enabled = true;
            btn_add.Enabled = false;
            btn_save.Enabled = true;

        }

        private void Resetvalues()
        {

            cb_madocgia.Text = "";
            cb_MaLoaiSach.Text = "";
            cb_tenloai.Text = "";
            cb_masach.Text = "";
            cb_tensach.Text = "";
            cb_madocgia.Text = "";
            cb_tendocgia.Text = "";
            txt_slgtra.Text = "";
            cb_tenTG.Text = "";
            cb_maTG.Text = "";
            cb_mamuon.Text = "";
            cb_matra.Text = "";
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            string sql; //Lưu lệnh sql
            if (cb_matra.Text.Trim().Length == 0) //Nếu chưa nhập mã chất liệu
            {
                MessageBox.Show("Bạn phải nhập mã trả", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cb_mamuon.Focus();
                return;
            }

            
            if (cb_masach.Text.Trim().Length == 0) //Nếu chưa nhập tên chất liệu
            {
                MessageBox.Show("Bạn phải nhập mã sách", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cb_tensach.Focus();
                return;
            }
            if (cb_tensach.Text.Trim().Length == 0) //Nếu chưa nhập tên chất liệu
            {
                MessageBox.Show("Bạn phải nhập tên sách trả", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cb_tensach.Focus();
                return;
            }
            sql = "Select MaLoaiSach From loaisach where maloaisach=N'" + cb_MaLoaiSach.Text.Trim() + "'";
            if (Functions.CheckKey(sql) == false)
            {
                MessageBox.Show("Mã loại sách không có trong thư viện sách", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cb_MaLoaiSach.Focus();
                return;
            }
            sql = "Select TenLoai From loaisach where TenLoai=N'" + cb_tenloai.Text.Trim() + "'";
            if (Functions.CheckKey(sql) == false)
            {
                MessageBox.Show("Loại sách không có trong thư viện sách", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cb_tenloai.Focus();
                return;
            }
            sql = "Select TenSach From sach where TenSach=N'" + cb_tensach.Text.Trim() + "'";
            if (Functions.CheckKey(sql) == false)
            {

                MessageBox.Show("Sách này không có trong thư viện sách", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cb_MaLoaiSach.Focus();
                return;
            }
            sql = "Select masach From sach where masach=N'" + cb_masach.Text.Trim() + "'";
            if (Functions.CheckKey(sql) == false)
            {

                MessageBox.Show("Mã sách này không có trong thư viện sách", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cb_masach.Focus();
                return;
            }
            sql = "Select MaTG  From tacgia where MaTg=N'" + cb_maTG.Text.Trim() + "'";
            if (Functions.CheckKey(sql) == false)
            {
                MessageBox.Show("Mã tác giả  không tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cb_maTG.Focus();
                return;
            }
            sql = "Select TenTG  From tacgia where TenTG=N'" + cb_tenTG.Text.Trim() + "'";
            if (Functions.CheckKey(sql) == false)
            {
                MessageBox.Show("Tác giả  không tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cb_tenTG.Focus();
                return;
            }
            sql = "Select Mamuon  From muonsach where mamuon=N'" + cb_mamuon.Text.Trim() + "'";
            if (Functions.CheckKey(sql) == false)
            {
                MessageBox.Show("Mã mượn không tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cb_tenTG.Focus();
                return;
            }
            string check_matra = "Select MaTraSach From trasach where Matrasach=N'" + cb_matra.Text.Trim() + "'";
            string tongmuon = "select sum(soluongmuon) from MuonSach where MaSach='"+cb_masach.Text.Trim()+"' group by MaDG";
            int tongmuon_moinguoi = int.Parse(Functions.GetFieldValues(tongmuon));
            if(tongmuon_moinguoi < int.Parse(txt_slgtra.Text))
            {
                MessageBox.Show("Bạn trả sách có số lượng lớn hơn bạn đã mượn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cb_masach.Focus();
                return;
            }
            if (Functions.CheckKey(check_matra) == false)
            {
                sql = "insert into trasach values(N'" + cb_matra.Text.Trim() + "',N'" + cb_madocgia.Text.Trim() + "',N'" + cb_masach.Text.Trim() + "','" + txt_slgtra.Text.Trim() + "','" + date_Ngaytra.Value + "',N'"+cb_mamuon.Text.Trim()+"')";
                Functions.RunSql(sql);
            }
            else
            {
                MessageBox.Show("Mã trả đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cb_matra.Focus();
                return;
            }
            
            string sqlslgmuon = "select soluongchomuon from sach where masach ='" + cb_masach.Text.Trim() + "'";
            int sachdachomuon = int.Parse(Functions.GetFieldValues(sqlslgmuon));
            int sach_tra = sachdachomuon - int.Parse(txt_slgtra.Text);
            sql = "update sach set soluongchomuon=" + sach_tra + "  where masach= '" + cb_masach.Text.Trim() + "'";
            Functions.RunSql(sql);
            string sql_sum_muon = "select soluongmuon from muonsach where mamuon=N'"+cb_mamuon.Text.Trim()+"'";
            int sum_muon=int.Parse(Functions.GetFieldValues(sql_sum_muon));
            int slg_saukhi_tra = sum_muon - int.Parse(txt_slgtra.Text);
           string update_solg_muon="update muonsach set soluongmuon ='"+slg_saukhi_tra+"' where mamuon='"+cb_mamuon.Text.Trim()+"'";
            Functions.RunSql(update_solg_muon);
            LoadDataGridView(); //Nạp lại DataGridView
            btn_add.Enabled = true;

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (trasach.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (cb_matra.Text == "") //nếu chưa chọn bản ghi nào
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xoá  mã trả : " + cb_matra.Text + " không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string sqlslgmuon = "select soluongchomuon from sach where masach ='" + cb_masach.Text.Trim() + "'";
                int sachdachomuon = int.Parse(Functions.GetFieldValues(sqlslgmuon));
                int sach_chomuon = sachdachomuon - int.Parse(txt_slgtra.Text);
                string update_sl = "update sach set soluongchomuon=" + sach_chomuon + " where masach ='" + cb_masach.Text.Trim() + "'";
                Functions.RunSql(update_sl);
                string soluong = "select  soluongmuon from muonsach where mamuon='"+cb_mamuon.Text.Trim()+"' ";
                int sl_muon = int.Parse(Functions.GetFieldValues(soluong));
                int sach_saukhi_update = sl_muon - int.Parse(txt_slgtra.Text);
                string update_sl_muon = "update muonsach set soluongmuon='"+sach_saukhi_update+"' where mamuon=N'"+cb_mamuon.Text.Trim()+"'";
                Functions.RunSql(update_sl_muon);
                string sql = "DELETE trasach WHERE Matrasach=N'" + cb_matra.Text.Trim() + " '";
                Functions.RunSql(sql);
                LoadDataGridView();
                Resetvalues();
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            string sql;
            cb_matra.Enabled = false;

            btn_save.Enabled = false;

           
            if (trasach.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (cb_mamuon.Text == "") //nếu chưa chọn bản ghi nào
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            sql = "Select MaLoaiSach From loaisach where maloaisach=N'" + cb_MaLoaiSach.Text.Trim() + "'";
            if (Functions.CheckKey(sql) == false)
            {
                MessageBox.Show("Mã loại sách không có trong thư viện sách", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cb_MaLoaiSach.Focus();
                return;
            }
            sql = "Select TenLoai From loaisach where TenLoai=N'" + cb_tenloai.Text.Trim() + "'";
            if (Functions.CheckKey(sql) == false)
            {
                MessageBox.Show("Loại sách không có trong thư viện sách", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cb_tenloai.Focus();
                return;
            }
            sql = "Select TenSach From sach where TenSach=N'" + cb_tensach.Text.Trim() + "'";
            if (Functions.CheckKey(sql) == false)
            {

                MessageBox.Show("Sách này không có trong thư viện sách", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cb_MaLoaiSach.Focus();
                return;
            }
            sql = "Select masach From sach where masach=N'" + cb_masach.Text.Trim() + "'";
            if (Functions.CheckKey(sql) == false)
            {

                MessageBox.Show("Mã sách này không có trong thư viện sách", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cb_masach.Focus();
                return;
            }
            sql = "Select MaTG  From tacgia where MaTg=N'" + cb_maTG.Text.Trim() + "'";
            if (Functions.CheckKey(sql) == false)
            {
                MessageBox.Show("Mã tác giả  không tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cb_maTG.Focus();
                return;
            }
            sql = "Select TenTG  From tacgia where TenTG=N'" + cb_tenTG.Text.Trim() + "'";
            if (Functions.CheckKey(sql) == false)
            {
                MessageBox.Show("Tác giả  không tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cb_tenTG.Focus();
                return;
            }

            string slg = "select soluongchomuon from sach where masach= N'" + cb_masach.Text.Trim() + "' ";
            int slg_cho_muon = int.Parse(Functions.GetFieldValues(slg));

            string sql_sum_slgsach = "select sum (soluongtra) from trasach where masach=N'" + cb_masach.Text.Trim() + "' group by masach";
            int sum_sach_da_tra = int.Parse(Functions.GetFieldValues(sql_sum_slgsach));

            string sql_muon = "select soluongmuon from muonsach where mamuon='"+cb_mamuon.Text.Trim()+"' ";
            int sach_muon = int.Parse(Functions.GetFieldValues(sql_muon));
            int sach_tra_trc = int.Parse(GridView_tra.CurrentRow.Cells["SoLuongTra"].Value.ToString());

            int sach_muon_trong_bang_muon_sach= sach_muon - int.Parse(txt_slgtra.Text) ;
            int tong_muon_con_lai = slg_cho_muon - int.Parse(txt_slgtra.Text) - sum_sach_da_tra;
           

            if (int.Parse(txt_slgtra.Text) - sach_tra_trc >= 0)
            {
                if (tong_muon_con_lai >= 0)
                {
                    sql = "update trasach set matrasach=N'"+cb_matra.Text.Trim()+"', mamuon=N'" + cb_mamuon.Text.Trim() + "'" +
                        ",MaDG= N'" + cb_madocgia.Text.Trim() + "',MaSach=  N'" + cb_masach.Text.Trim() + "'," +
                        "soluongtra=" + txt_slgtra.Text.Trim() + ",Ngaytra='" + date_Ngaytra.Value + " where matrasach=N'" + cb_matra.Text.Trim() + "'";
                    Functions.RunSql(sql);
                }

                else if (tong_muon_con_lai < 0)
                {
                    MessageBox.Show("Sách này đã trả hết", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
               
                int sach_tra = tong_muon_con_lai - (int.Parse(txt_slgtra.Text) - sach_tra_trc);
                sql = "update sach set soluongchomuon=" + sach_tra + "  where masach= '" + cb_masach.Text.Trim() + "'";
                Functions.RunSql(sql);
                string update_muonsach = "update muonsach set soluongmuon="+sach_muon_trong_bang_muon_sach+" where mamuon=N'"+cb_mamuon.Text.Trim()+"'";
                Functions.RunSql(update_muonsach);
                LoadDataGridView(); //Nạp lại DataGridView
            }
            else
            {
                if (tong_muon_con_lai >= 0)
                {
                 sql = "update trasach set matrasach=N'" + cb_matra.Text.Trim() + "', mamuon=N'" + cb_mamuon.Text.Trim() + "'" +
                ",MaDG= N'" + cb_madocgia.Text.Trim() + "',MaSach=  N'" + cb_masach.Text.Trim() + "'," +
                "soluongtra='" + txt_slgtra.Text.Trim() + "',Ngaytra='" + date_Ngaytra.Value + " where matrasach=N'" + cb_matra.Text.Trim() + "'";
                    Functions.RunSql(sql);
                }

                else if (tong_muon_con_lai < 0)
                {
                    MessageBox.Show("Sách đã trả hết", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                int sach_tra = tong_muon_con_lai - (sach_tra_trc-  int.Parse(txt_slgtra.Text) );
                sql = "update sach set soluongchomuon=" + sach_tra + "  where masach= '" + cb_masach.Text.Trim() + "'";
                Functions.RunSql(sql);
                string update_muonsach = "update muonsach set soluongmuon=" + sach_muon_trong_bang_muon_sach + " where mamuon=N'" + cb_mamuon.Text.Trim() + "'";
                Functions.RunSql(update_muonsach);
                LoadDataGridView(); //Nạp lại DataGridView
            }

        }

        private void bt_find_name_Click(object sender, EventArgs e)
        {
            if ((txt_find_by_name.Text == ""))
            {
                MessageBox.Show("Bạn hãy nhập điều kiện tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string sql = "select MaTraSach, nm.MaDG, nm.TenDG, s.MaSach, s.TenSach,tg.MaTG,tg.TenTG,ls.MaLoaiSach, ls.TenLoai, ts.SoLuongTra,ms.ngaymuon ,ts.NgayTra, ms.MaMuon" +
                " from TraSach ts join Sach s on s.MaSach=ts.MaSach join TacGia tg on tg.MaTG=s.MaTG join NguoiMuon nm on nm.MaDG=ts.MaDG join LoaiSach ls " +
                "on ls.MaLoaiSach=s.MaLoaiSach join MuonSach ms on ms.MaMuon=ts.Mamuon where TenSach like N'%" + txt_find_by_name.Text.Trim() + "%'";

            trasach = Functions.GetDataTable(sql);
            if (trasach.Rows.Count == 0)
                MessageBox.Show("Không có bản ghi thoả mãn điều kiện tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else MessageBox.Show("Có " + trasach.Rows.Count + "  bản ghi thoả mãn điều kiện!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            GridView_tra.DataSource = trasach;
        }

        private void btn_find_ma_Click(object sender, EventArgs e)
        {

            if ((txt_find_by_ma.Text == ""))
            {
                MessageBox.Show("Bạn hãy nhập điều kiện tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string sql = " select MaTraSach, nm.MaDG, nm.TenDG, s.MaSach, s.TenSach,tg.MaTG,tg.TenTG,ls.MaLoaiSach, ls.TenLoai, ts.SoLuongTra, ms.ngaymuon ,ts.NgayTra, ms.MaMuon" +
                " from TraSach ts join Sach s on s.MaSach=ts.MaSach join TacGia tg on tg.MaTG=s.MaTG join NguoiMuon nm on nm.MaDG=ts.MaDG join LoaiSach ls " +
                "on ls.MaLoaiSach=s.MaLoaiSach join MuonSach ms on ms.MaMuon=ts.Mamuon where Matrasach like N'%" + txt_find_by_ma.Text.Trim() + "%'";

            trasach = Functions.GetDataTable(sql);
            if (trasach.Rows.Count == 0)
                MessageBox.Show("Không có bản ghi thoả mãn điều kiện tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else MessageBox.Show("Có " + trasach.Rows.Count + "  bản ghi thoả mãn điều kiện!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            GridView_tra.DataSource = trasach;
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            LoadDataGridView();
            btn_add.Enabled = true;
            btn_delete.Enabled = true;
            btn_save.Enabled = true;
            btn_edit.Enabled = true;
        }
// tiếp phần dưới
        private void txt_slgtra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
        private void cb_TenTG_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str;
            str = "select MaTG from TacGia where TenTG=N'" + cb_tenTG.Text.Trim() + "' ";
            cb_maTG.Text = Functions.GetFieldValues(str);

        }

        private void cb_matacgia_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str;
            str = "select TenTG from TacGia where MaTG=N'" + cb_maTG.Text.Trim() + "' ";
            cb_tenTG.Text = Functions.GetFieldValues(str);
        }

        private void cb_tenloai_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str;
            str = "select MaLoaiSach from LoaiSach  where TenLoai=N'" + cb_tenloai.Text.Trim() + "' ";
            cb_MaLoaiSach.Text = Functions.GetFieldValues(str);
        }

        private void cb_MaLoaiSach_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str;
            str = "select TenLoai from LoaiSach  where MaLoaiSach=N'" + cb_MaLoaiSach.Text.Trim() + "' ";
            cb_tenloai.Text = Functions.GetFieldValues(str);
        }

        private void cb_tensach_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str;
            str = "select MaSach from Sach  where TenSach=N'" + cb_tensach.Text.Trim() + "' ";
            cb_masach.Text = Functions.GetFieldValues(str);
            str = "select tg.MaTG from tacgia tg join sach s on s.MaTG=tg.MaTG where TenSach=N'" + cb_tensach.Text.Trim() + "'";
            cb_maTG.Text = Functions.GetFieldValues(str);
            str = "select tg.TenTG from tacgia tg join sach s on s.MaTG=tg.MaTG where TenSach=N'" + cb_tensach.Text.Trim() + "'";
            cb_tenTG.Text = Functions.GetFieldValues(str);
            str = "select ls.maloaisach from loaisach ls join sach s on s.maloaisach=ls.maloaisach where masach =N'" + cb_masach.Text.Trim() + "'";
            cb_MaLoaiSach.Text = Functions.GetFieldValues(str);
            str = "select ls.tenloai from loaisach ls join sach s on s.maloaisach=ls.maloaisach where masach =N'" + cb_masach.Text.Trim() + "'";
            cb_tenloai.Text = Functions.GetFieldValues(str);
        }
        private void cb_masach_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str;
            str = "select TenSach from Sach  where MaSach=N'" + cb_masach.Text.Trim() + "' ";
            cb_tensach.Text = Functions.GetFieldValues(str);
            str = "select tg.MaTG from tacgia tg join sach s on s.MaTG=tg.MaTG where TenSach=N'" + cb_tensach.Text.Trim() + "'";
            cb_maTG.Text = Functions.GetFieldValues(str);
            str = "select tg.TenTG from tacgia tg join sach s on s.MaTG=tg.MaTG where TenSach=N'" + cb_tensach.Text.Trim() + "'";
            cb_tenTG.Text = Functions.GetFieldValues(str);
            str = "select ls.maloaisach from loaisach ls join sach s on s.maloaisach=ls.maloaisach where masach =N'" + cb_masach.Text.Trim() + "'";
            cb_MaLoaiSach.Text = Functions.GetFieldValues(str);
            str = "select ls.tenloai from loaisach ls join sach s on s.maloaisach=ls.maloaisach where masach =N'" + cb_masach.Text.Trim() + "'";
            cb_tenloai.Text = Functions.GetFieldValues(str);
        }

        private void cb_madocgia_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str;
            str = "select TenDG from NguoiMuon  where MaDG=N'" + cb_madocgia.Text.Trim() + "' ";
            cb_tendocgia.Text = Functions.GetFieldValues(str);
        }

        private void cb_tendocgia_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str;
            str = "select MaDG from NguoiMuon  where TenDG=N'" + cb_tendocgia.Text.Trim() + "' ";
            cb_madocgia.Text = Functions.GetFieldValues(str);
        }

        private void cb_mamuon_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str;
            str = "select MaDG from trasach where mamuon=N'" + cb_mamuon.Text.Trim() + "' ";
            cb_madocgia.Text=Functions.GetFieldValues(str);
            str = "select MaSach from trasach where mamuon=N'" + cb_mamuon.Text.Trim() + "' ";
            cb_masach.Text = Functions.GetFieldValues(str);
            str = "select ngaymuon from muonsach where  mamuon=N'" + cb_mamuon.Text.Trim() + "'";
            string kq= (Functions.GetFieldValues(str));
            if (kq == "")
            {
                date_ngaymuon.Value = DateTime.Now;
            }
            else if (kq!=null)
            {
                DateTime ngaymuon = DateTime.Parse(kq);
                date_ngaymuon.Value = ngaymuon;
            }
           
        }
    }
}
