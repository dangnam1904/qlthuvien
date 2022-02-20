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
    public partial class fr_muon : Form
    {
        DataTable muonsach;
        public fr_muon()
        {
            InitializeComponent();
        }

        private void fr_muon_Load(object sender, EventArgs e)
        {
            LoadDataGridView();
            display_MaDG();
            display_TenDG();
            display_MaloaiSach();
            display_TenLoai();
            display_MaTG();
            display_TenTG();
            display_maMuon();
            display_masach();
            display_TenSach();
        }
        private void LoadDataGridView()
        {
            String sql = "select MaMuon,ms.MaDG,nm.TenDG,s.MaSach,TenSach ,s.Soluong, tg.MaTG,tg.TenTG ,ls.MaLoaiSach,ls.TenLoai,ms.SoLuongMuon,Ngaymuon,ngayhentra" +
                " from MuonSach ms join NguoiMuon nm on nm.MaDG=ms.MaDG join Sach s on s.MaSach = ms.MaSach join LoaiSach ls on ls.MaLoaiSach = s.MaLoaiSach join TacGia tg on tg.MaTG=s.MaTG";
            muonsach= Functions.GetDataTable(sql); //Đọc dữ liệu từ bảng
            GridView_muon.DataSource = muonsach; //Nguồn dữ liệu            
            GridView_muon.Columns[0].HeaderText = "Mã mượn";
            GridView_muon.Columns[1].HeaderText = "Mã độc giả";
            GridView_muon.Columns[2].HeaderText = "Tên độc giả";
            GridView_muon.Columns[3].HeaderText = "Mã sách";
            GridView_muon.Columns[4].HeaderText = "Tên sách";
            GridView_muon.Columns[5].HeaderText = "Số lượng sách có";
            GridView_muon.Columns[6].HeaderText = "Mã tác giả";
            GridView_muon.Columns[7].HeaderText = "Tên tác giả";
            GridView_muon.Columns[8].HeaderText = "Mã loại sách";
            GridView_muon.Columns[9].HeaderText = "Tên Loại Sách";
            GridView_muon.Columns[10].HeaderText = "Số lượng mượn";
            GridView_muon.Columns[11].HeaderText = "Ngày mượn";
            GridView_muon.Columns[12].HeaderText = "Ngày hẹn trả";
            GridView_muon.AllowUserToAddRows = false; //Không cho người dùng thêm dữ liệu trực tiếp
            GridView_muon.EditMode = DataGridViewEditMode.EditProgrammatically; //Không cho sửa dữ liệu trực tiếp
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
            string sql = "select *from MuonSach ";
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
        private void GridView_muon_Click(object sender, EventArgs e)
        {
            if (btn_add.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cb_MaLoaiSach.Focus();
                return;
            }
            if (muonsach.Rows.Count == 0) //Nếu không có dữ liệu
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            cb_masach.Text = GridView_muon.CurrentRow.Cells["MaSach"].Value.ToString();
            cb_tensach.Text = GridView_muon.CurrentRow.Cells["TenSach"].Value.ToString();
            cb_mamuon.Text= GridView_muon.CurrentRow.Cells["MaMuon"].Value.ToString();
            txt_sl_muon.Text = GridView_muon.CurrentRow.Cells["SoLuong"].Value.ToString();
            txt_sl_muon.Text= GridView_muon.CurrentRow.Cells["SoLuongMuon"].Value.ToString();
            cb_tendocgia.Text = GridView_muon.CurrentRow.Cells["TenDG"].Value.ToString();
           cb_madocgia.Text = GridView_muon.CurrentRow.Cells["MaDG"].Value.ToString();
            cb_MaLoaiSach.Text = GridView_muon.CurrentRow.Cells["MaLoaiSach"].Value.ToString();
            cb_tenloai.Text = GridView_muon.CurrentRow.Cells["TenLoai"].Value.ToString();
            date_NgayMuon.Value =(DateTime) GridView_muon.CurrentRow.Cells["NgayMuon"].Value;
            date_ngayhentra.Value=(DateTime)GridView_muon.CurrentRow.Cells["NgayHenTra"].Value;
            cb_maTG.Text = GridView_muon.CurrentRow.Cells["MaTG"].Value.ToString();
            cb_tenTG.Text = GridView_muon.CurrentRow.Cells["TenTG"].Value.ToString();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            Resetvalues();
           cb_mamuon.Enabled = true;
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
            txt_sl_muon.Text = "";
            cb_tenTG.Text = "";
            cb_maTG.Text = "";
            cb_mamuon.Text = "";
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            string sql; //Lưu lệnh sql
            if (cb_mamuon.Text.Trim().Length == 0) //Nếu chưa nhập mã chất liệu
            {
                MessageBox.Show("Bạn phải nhập mã mượn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cb_mamuon.Focus();
                return;
            }

            TimeSpan time = date_ngayhentra.Value - date_NgayMuon.Value;
            int day = time.Days;
            if (day < 0)
            {
                MessageBox.Show("Ngày hẹn trả không được nhỏ hơn ngày ngày mượn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
                return;
            }
            if (cb_masach.Text.Trim().Length == 0) //Nếu chưa nhập tên chất liệu
            {
                MessageBox.Show("Bạn phải nhập mã sách", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cb_tensach.Focus();
                return;
            }
            sql = "Select MaLoaiSach From loaisach where maloaisach=N'" + cb_MaLoaiSach.Text.Trim() + "'";
            if (Functions.CheckKey(sql)==false)
            {
                MessageBox.Show("Mã loại sách không có trong thư viện sách", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cb_MaLoaiSach.Focus();
                return;
            }
            sql = "Select TenLoai From loaisach where TenLoai=N'" +cb_tenloai.Text.Trim() + "'";
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
            sql = "Select masach From sach where masach=N'" +cb_masach.Text.Trim() + "'";
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

           string check_mamuon = "Select MaMuon From MuonSach where MaMuon=N'" + cb_mamuon.Text.Trim() + "'";
            string slg = "select soluong from sach where masach= N'"+cb_masach.Text.Trim()+"' ";
            int slg_cosan = int.Parse(Functions.GetFieldValues(slg));
            string slg_dachomuon = "select soluongchomuon from sach where masach= N'" + cb_masach.Text.Trim() + "' ";
            int slgdachomuon = int.Parse(Functions.GetFieldValues(slg_dachomuon));
            int a = slg_cosan - int.Parse(txt_sl_muon.Text)-slgdachomuon;
            if (Functions.CheckKey(check_mamuon) == false && a >= 0)
            {
                sql = "insert into MuonSach values(N'" +cb_mamuon.Text.Trim() + "',N'" + cb_madocgia.Text.Trim() + "',N'" +cb_masach.Text.Trim() + "','" + txt_sl_muon.Text.Trim() + "','" +date_NgayMuon.Value + "', '" + date_ngayhentra.Value + "')";
                Functions.RunSql(sql);

                string sqlslgmuon = "select soluongchomuon from sach where masach ='" + cb_masach.Text.Trim() + "'";
                int sachdachomuon = int.Parse(Functions.GetFieldValues(sqlslgmuon));
                int sach_chomuon = sachdachomuon + int.Parse(txt_sl_muon.Text);
                sql = "update sach set soluongchomuon=" + sach_chomuon + "  where masach= '" + cb_masach.Text.Trim() + "'";
                Functions.RunSql(sql);
            }
            else if (Functions.CheckKey(check_mamuon) == true)
            {

                MessageBox.Show("Mã mượn đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cb_masach.Focus();
                return;
            }
            else if (a < 0)
            {
                MessageBox.Show("Sách đã mượn hết", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            
            LoadDataGridView(); //Nạp lại DataGridView
            btn_add.Enabled = true;

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (muonsach.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (cb_mamuon.Text == "") //nếu chưa chọn bản ghi nào
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xoá  mã mượn : " + cb_mamuon.Text + " không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                
                string sqlslgmuon = "select soluongchomuon from sach where masach ='" + cb_masach.Text.Trim() + "'";
                int sachdachomuon = int.Parse(Functions.GetFieldValues(sqlslgmuon));
                int sach_chomuon = sachdachomuon - int.Parse(txt_sl_muon.Text);
                string update_sl = "update sach set soluongchomuon="+sach_chomuon+" where masach ='"+cb_masach.Text.Trim()+"'";
                Functions.RunSql(update_sl);
                string sql = "DELETE MuonSach WHERE MaMuon=N'" + cb_mamuon.Text.Trim() + " '";
                Functions.RunSql(sql);
             
            }
            LoadDataGridView();
            Resetvalues();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            string sql;
            cb_mamuon.Enabled = false;
           
            btn_save.Enabled = false;

            TimeSpan time = date_ngayhentra.Value - date_NgayMuon.Value;
            int day = time.Days;
            if (day < 0)
            {
                MessageBox.Show("Ngày hẹn trả không được nhỏ hơn ngày ngày mượn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return;
            }
            if (muonsach.Rows.Count == 0)
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

            string slg = "select soluong from sach where masach= N'" + cb_masach.Text.Trim() + "' ";
            int slg_cosan = int.Parse(Functions.GetFieldValues(slg));

            string sql_sum_slgsach_muon = "select sum (soluongmuon) from muonsach where masach=N'"+cb_masach.Text.Trim()+"' group by masach";
            int sum_sach_chomuon = int.Parse(Functions.GetFieldValues(sql_sum_slgsach_muon));

            int a = slg_cosan - int.Parse(txt_sl_muon.Text) - sum_sach_chomuon;
            int sachmuontrc = int.Parse(GridView_muon.CurrentRow.Cells["SoLuongmuon"].Value.ToString());

            if (int.Parse(txt_sl_muon.Text) - sachmuontrc >= 0)
            {
                if ( a >= 0)
                {
                    sql = "update MuonSach set mamuon=N'" + cb_mamuon.Text.Trim() + "',MaDG= N'" + cb_madocgia.Text.Trim() + "',MaSach=  N'" + cb_masach.Text.Trim() + "',soluongmuon='" + txt_sl_muon.Text.Trim() + "',NgayMuon='" + date_NgayMuon.Value + "',NgayHenTra= '" + date_ngayhentra.Value + "' where mamuon='" + cb_mamuon.Text.Trim() + "'";
                    Functions.RunSql(sql);

                    string sqlslgmuon = "select soluongchomuon from sach where masach ='" + cb_masach.Text.Trim() + "'";
                    int sachdachomuon = int.Parse(Functions.GetFieldValues(sqlslgmuon));
                    int sach_chomuon = sachdachomuon + (int.Parse(txt_sl_muon.Text) - sachmuontrc);
                    sql = "update sach set soluongchomuon=" + sach_chomuon + "  where masach= '" + cb_masach.Text.Trim() + "'";
                    Functions.RunSql(sql);
                }
           
                else if (a < 0)
                {
                    MessageBox.Show("Sách đã mượn hết", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
              
               
            }
            else
            {
                if ( a >= 0)
                {

                    sql = "update MuonSach set mamuon=N'" + cb_mamuon.Text.Trim() + "',MaDG= N'" + cb_madocgia.Text.Trim() + "',MaSach=  N'" + cb_masach.Text.Trim() + "',soluongmuon='" + txt_sl_muon.Text.Trim() + "',NgayMuon='" + date_NgayMuon.Value + "',NgayHenTra= '" + date_ngayhentra.Value + "' where mamuon='" + cb_mamuon.Text.Trim() + "'";
                    Functions.RunSql(sql);

                    string sqlslgmuon = "select soluongchomuon from sach where masach ='" + cb_masach.Text.Trim() + "'";
                    int sachdachomuon = int.Parse(Functions.GetFieldValues(sqlslgmuon));
                    int sach_chomuon = sachdachomuon - (sachmuontrc - int.Parse(txt_sl_muon.Text));
                    sql = "update sach set soluongchomuon=" + sach_chomuon + "  where masach= '" + cb_masach.Text.Trim() + "'";
                    Functions.RunSql(sql);

                }
              
                else if (a < 0)
                {
                    MessageBox.Show("Sách đã mượn hết", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
               
              
            }
            LoadDataGridView(); //Nạp lại DataGridView
        }

        private void bt_find_name_Click(object sender, EventArgs e)
        {
            if ((txt_find_by_name.Text == ""))
            {
                MessageBox.Show("Bạn hãy nhập điều kiện tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string sql = "select MaMuon,ms.MaDG,nm.TenDG,s.MaSach,TenSach ,s.Soluong, tg.MaTG,tg.TenTG ,ls.MaLoaiSach,ls.TenLoai,ms.SoLuongMuon,Ngaymuon,ngayhentra" +
                " from MuonSach ms join NguoiMuon nm on nm.MaDG=ms.MaDG join Sach s on s.MaSach = ms.MaSach join LoaiSach ls on ls.MaLoaiSach = s.MaLoaiSach join TacGia tg on tg.MaTG=s.MaTG where TenSach like N'%" + txt_find_by_name.Text.Trim() + "%'";

            muonsach = Functions.GetDataTable(sql);
            if (muonsach.Rows.Count == 0)
                MessageBox.Show("Không có bản ghi thoả mãn điều kiện tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else MessageBox.Show("Có " + muonsach.Rows.Count + "  bản ghi thoả mãn điều kiện!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            GridView_muon.DataSource = muonsach;
        }

        private void btn_find_ma_Click(object sender, EventArgs e)
        {

            if ((txt_find_by_ma.Text == ""))
            {
                MessageBox.Show("Bạn hãy nhập điều kiện tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string sql = " select MaMuon,ms.MaDG,nm.TenDG,s.MaSach,TenSach ,s.Soluong, tg.MaTG,tg.TenTG ,ls.MaLoaiSach,ls.TenLoai,ms.SoLuongMuon,Ngaymuon,ngayhentra" +
                " from MuonSach ms join NguoiMuon nm on nm.MaDG=ms.MaDG join Sach s on s.MaSach = ms.MaSach join LoaiSach ls on ls.MaLoaiSach = s.MaLoaiSach join TacGia tg on tg.MaTG=s.MaTG where Mamuon like N'%" + txt_find_by_ma.Text.Trim() + "%'";

            muonsach = Functions.GetDataTable(sql);
            if (muonsach.Rows.Count == 0)
                MessageBox.Show("Không có bản ghi thoả mãn điều kiện tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else MessageBox.Show("Có " + muonsach.Rows.Count + "  bản ghi thoả mãn điều kiện!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            GridView_muon.DataSource = muonsach;
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            LoadDataGridView();
        }

  

        private void txt_slgmuon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
        private void cb_TenTG_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str;
            str = "select MaTG from TacGia where TenTG=N'" +cb_tenTG.Text.Trim() + "' ";
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
            str = "select tg.MaTG from tacgia tg join sach s on s.MaTG=tg.MaTG where TenSach=N'"+cb_tensach.Text.Trim()+"'";
            cb_maTG.Text = Functions.GetFieldValues(str);
            str = "select tg.TenTG from tacgia tg join sach s on s.MaTG=tg.MaTG where TenSach=N'" + cb_tensach.Text.Trim() + "'";
            cb_tenTG.Text = Functions.GetFieldValues(str);
            str = "select ls.maloaisach from loaisach ls join sach s on s.maloaisach=ls.maloaisach where masach =N'"+cb_masach.Text.Trim()+"'";
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
            str = "select soluong from sach where Masach=N'" + cb_masach.Text.Trim() + "'";
            txt_slgsach.Text=Functions.GetFieldValues(str);
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

        private void GridView_muon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
