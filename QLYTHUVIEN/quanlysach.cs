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
    public partial class quanlysach : Form
    {
        DataTable sach;
        public quanlysach()
        {
            InitializeComponent();
        }

        private void quanlysach_Load(object sender, EventArgs e)
        {
            LoadDataGridView();
            display_masach();
            display_maTG();
            display_TenLoai();
            display_MaloaiSach();
            display_TenTG();
            display_TenSach();
        }
       
        private void LoadDataGridView()
        {
            String sql = " select sach.MaSach, TenSach, Mota,soluong, soluongchomuon,Loaisach.maloaisach, tenloai,TacGia.MaTG, TenTG from sach left join tacgia on sach.MaTG = tacgia.MaTG join loaisach on loaisach.maloaisach=sach.maloaisach";
            sach = Functions.GetDataTable(sql); //Đọc dữ liệu từ bảng
            Gridview_sach.DataSource = sach; //Nguồn dữ liệu            
            Gridview_sach.Columns[0].HeaderText = "Mã sách";
            Gridview_sach.Columns[1].HeaderText = "Tên sách";
            Gridview_sach.Columns[2].HeaderText = "Mô tả ";
            Gridview_sach.Columns[3].HeaderText = "Số lượng sách ";
            Gridview_sach.Columns[4].HeaderText = "Số sách  cho mượn ";
            Gridview_sach.Columns[5].HeaderText = "Mã loại sách";
            Gridview_sach.Columns[6].HeaderText = "Tên Loại Sách";
            Gridview_sach.Columns[7].HeaderText = "Mã tác giả";
            Gridview_sach.Columns[8].HeaderText = "Tên tác giả";
            Gridview_sach.AllowUserToAddRows = false; //Không cho người dùng thêm dữ liệu trực tiếp
            Gridview_sach.EditMode = DataGridViewEditMode.EditProgrammatically; //Không cho sửa dữ liệu trực tiếp
        }

        private void display_maTG()
        {
            string sql = " select* from tacgia";
            Functions.FillCombo(sql, cb_matacgia, "MaTG", "MaTG");
            cb_matacgia.SelectedIndex = -1;
        }

        private void display_TenTG()
        {
            string sql = " select* from tacgia";
            Functions.FillCombo(sql, cbo_tenTG, "MaTG", "TenTG");
          cbo_tenTG.SelectedIndex = -1;

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
        private void Gridview_sach_Click(object sender, EventArgs e)
        {
            if (btn_add.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cb_MaLoaiSach.Focus();
                return;
            }
            if (sach.Rows.Count == 0) //Nếu không có dữ liệu
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
              cb_masach.Text = Gridview_sach.CurrentRow.Cells["MaSach"].Value.ToString();
              cb_tensach.Text = Gridview_sach.CurrentRow.Cells["TenSach"].Value.ToString();
              rtxt_mota.Text = Gridview_sach.CurrentRow.Cells["MoTa"].Value.ToString();
              txt_soluong.Text= Gridview_sach.CurrentRow.Cells["SoLuong"].Value.ToString();
              txt_dachomuon.Text= Gridview_sach.CurrentRow.Cells["SoLuongChoMuon"].Value.ToString();
            cbo_tenTG.Text= Gridview_sach.CurrentRow.Cells["TenTG"].Value.ToString();
            cb_matacgia.Text= Gridview_sach.CurrentRow.Cells["MaTG"].Value.ToString();
            cb_MaLoaiSach.Text= Gridview_sach.CurrentRow.Cells["MaLoaiSach"].Value.ToString();
            cb_tenloai.Text= Gridview_sach.CurrentRow.Cells["TenLoai"].Value.ToString();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            Resetvalues();
           cb_masach.Enabled = true;
            btn_add.Enabled = false;

        }

        private void Resetvalues()
        {
           
            cbo_tenTG.Text = "";
            cb_matacgia.Text = "";
            cb_MaLoaiSach.Text = "";
            cb_tenloai.Text = "";
            cb_masach.Text = "";
            cb_tensach.Text = "";
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            string sql; //Lưu lệnh sql
            if (cb_masach.Text.Trim().Length == 0) //Nếu chưa nhập mã chất liệu
            {
                MessageBox.Show("Bạn phải nhập mã sách", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
               cb_masach.Focus();
                return;
            }

            if (cb_tensach.Text.Trim().Length == 0) //Nếu chưa nhập tên chất liệu
            {
                MessageBox.Show("Bạn phải nhập tên sách", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cb_tensach.Focus();
                return;
            }
            sql = "Select MaLoaiSach From loaisach where maloaisach=N'" + cb_MaLoaiSach.Text.Trim() + "'";
            if (Functions.CheckKey(sql) == false)
            {
                sql = "insert into loaisach(MaLoaiSach,TenLoai) values(N'" + cb_MaLoaiSach.Text.Trim() + "', N'" + cb_tenloai.Text.Trim() + "')";
                Functions.RunSql(sql);
            }
            sql = "Select MaTG  From tacgia where MaTg=N'" + cb_matacgia.Text.Trim() + "'";
            if (Functions.CheckKey(sql) == false)
            {
                sql = "insert into TacGia(MaTG,TenTG) values(N'" + cb_matacgia.Text.Trim() + "', N'" + cbo_tenTG.Text.Trim() + "')";
                Functions.RunSql(sql);
            }
            sql = "Select MaSach From Sach where MaSach=N'" + cb_masach.Text.Trim() + "'";
            int a = int.Parse(txt_soluong.Text) - int.Parse(txt_dachomuon.Text);
            if (Functions.CheckKey(sql) == false && a>=0)
            {
                sql = "insert into sach values(N'" + cb_masach.Text.Trim() + "',N'" + cb_tensach.Text.Trim() + "',N'" + rtxt_mota.Text.Trim() + "',N'" + cb_MaLoaiSach.Text.Trim() + "','" + txt_soluong.Text.Trim() + "', '" + txt_dachomuon.Text.Trim() + "', N'" + cb_matacgia.Text.Trim() + "')";
                Functions.RunSql(sql);
            }
            else if(Functions.CheckKey(sql) == true)
            {

                MessageBox.Show("Mã sách đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cb_masach.Focus();
                return;
            }
            else if (a < 0)
            {
                MessageBox.Show("Số sách cho mượn không thể lớn hơn sách trong thư viện", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                return;
            }
                LoadDataGridView(); //Nạp lại DataGridView
            btn_add.Enabled = true;

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (sach.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (cb_MaLoaiSach.Text == "") //nếu chưa chọn bản ghi nào
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xoá " +cb_tensach.Text + " không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string check_slgmuon = "select Soluongchomuon from sach where masach =N'"+cb_masach.Text.Trim()+"'";
              
                if(int.Parse(Functions.GetFieldValues(check_slgmuon))>0)
                {
                    MessageBox.Show("Sách này đang cho mượn không thể xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    string sql = "DELETE Sach WHERE MaSach=N'" + cb_masach.Text.Trim() + " '";
                    Functions.RunSql(sql);
                }

            }
            LoadDataGridView();
            Resetvalues();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            string sql;
            cb_MaLoaiSach.Enabled = false;
            btn_add.Enabled = false;
            btn_save.Enabled = false;


            if (sach.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
           if (cb_masach.Text == "") //nếu chưa chọn bản ghi nào
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            sql = "Select MaLoaiSach  From loaisach where maloaisach=N'" + cb_MaLoaiSach.Text.Trim() + "'";
            if (Functions.CheckKey(sql) == false)
            {
                sql = "insert into loaisach values(N'" + cb_MaLoaiSach.Text.Trim() + "', N'" + cb_tenloai.Text.Trim() + "')";
                Functions.RunSql(sql);
            }
            sql = "Select MaTG  From tacgia where MaTG=N'" + cb_matacgia.Text.Trim() + "'";
            if (Functions.CheckKey(sql) == false)
            {
                sql = "insert into TacGia values(N'" + cb_matacgia.Text.Trim() + "', N'" + cbo_tenTG.Text.Trim() + "')";
                Functions.RunSql(sql);
            }
         int a=   int.Parse(txt_soluong.Text) - int.Parse(txt_dachomuon.Text);
            if (a >= 0)
            {
                sql = "update sach set Tensach =N'" + cb_tensach.Text.Trim() + "', mota=N'" + rtxt_mota.Text + "', MaLoaiSach=N'" + cb_MaLoaiSach.Text.Trim() + "', soluong='" + txt_soluong.Text.Trim() + "', soluongchomuon='" + txt_dachomuon.Text.Trim() + "', matg=N'" + cb_matacgia.Text.Trim() + "' where masach=N'" + cb_masach.Text.Trim() + "'";
                Functions.RunSql(sql);
                LoadDataGridView(); //Nạp lại DataGridView
                btn_add.Enabled = true;
                btn_save.Enabled = true;
                cb_MaLoaiSach.Enabled = true;
            }
            else
            {
                MessageBox.Show("Số lượng cho mượn không thể lớn hơn số lượng sách hiện có", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void bt_find_name_Click(object sender, EventArgs e)
        {
            if ((txt_find_by_name.Text == ""))
            {
                MessageBox.Show("Bạn hãy nhập điều kiện tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string sql = " select sach.MaSach, TenSach, Mota,soluong, soluongchomuon,Loaisach.maloaisach, tenloai,TacGia.MaTG, TenTG" +
                " from sach left join tacgia on sach.MaTG = tacgia.MaTG join loaisach on loaisach.maloaisach=sach.maloaisach where TenSach like N'%" + txt_find_by_name.Text.Trim() + "%'";

            sach = Functions.GetDataTable(sql);
            if (sach.Rows.Count == 0)
                MessageBox.Show("Không có bản ghi thoả mãn điều kiện tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else MessageBox.Show("Có " + sach.Rows.Count + "  bản ghi thoả mãn điều kiện!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Gridview_sach.DataSource = sach;
        }

        private void btn_find_ma_Click(object sender, EventArgs e)
        {

            if ((txt_find_by_ma.Text == ""))
            {
                MessageBox.Show("Bạn hãy nhập điều kiện tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string sql = " select sach.MaSach, TenSach, Mota,soluong, soluongchomuon,Loaisach.maloaisach, tenloai,TacGia.MaTG, TenTG from sach left join tacgia on sach.MaTG = tacgia.MaTG" +
                " join loaisach on loaisach.maloaisach=sach.maloaisach where Sach.Masach like N'%" + txt_find_by_ma.Text.Trim() + "%'";

            sach = Functions.GetDataTable(sql);
            if (sach.Rows.Count == 0)
                MessageBox.Show("Không có bản ghi thoả mãn điều kiện tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else MessageBox.Show("Có " + sach.Rows.Count + "  bản ghi thoả mãn điều kiện!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Gridview_sach.DataSource = sach;
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            LoadDataGridView();
        }

        private void txt_soluong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txt_dachomuon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
        private void cb_TenTG_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str;
            str = "select MaTG from TacGia where TenTG=N'" + cbo_tenTG.Text.Trim() + "' ";
            cb_matacgia.Text = Functions.GetFieldValues(str);
           
        }

        private void cb_matacgia_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str;
            str = "select TenTG from TacGia where MaTG=N'" + cb_matacgia.Text.Trim() + "' ";
           cbo_tenTG.Text = Functions.GetFieldValues(str);
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
            str = "select tg.TenTG from TacGia tg join Sach s on s.MaTG = tg.MaTG  where TenSach=N'" + cb_tensach.Text.Trim() + "' ";
            cbo_tenTG.Text = Functions.GetFieldValues(str);
            str = "select tg.MaTG from TacGia tg join Sach s on s.MaTG = tg.MaTG where TenSach=N'" + cb_tensach.Text.Trim() + "' ";
            cb_matacgia.Text = Functions.GetFieldValues(str);
        }

        private void cb_tensach_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str;
            str = "select MaSach from Sach  where TenSach=N'" + cb_tensach.Text.Trim() + "' ";
           cb_masach.Text = Functions.GetFieldValues(str);
            str = "select tg.TenTG from TacGia tg join Sach s on s.MaTG = tg.MaTG where TenSach=N'" + cb_tensach.Text.Trim() + "' ";
            cbo_tenTG.Text = Functions.GetFieldValues(str);
            str = "select tg.MaTG from TacGia tg join Sach s on s.MaTG = tg.MaTG  where TenSach=N'" + cb_tensach.Text.Trim() + "' ";
            cb_matacgia.Text = Functions.GetFieldValues(str);
        }
    }
}
