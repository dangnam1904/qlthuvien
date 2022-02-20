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
    public partial class QuanLyDocGia : Form
    {
        DataTable DocGia;

        public QuanLyDocGia()
        {
            InitializeComponent();
        }
        private void QuanLyDocGia_Load(object sender, EventArgs e)
        {
            LoadDataGridView();
            display_maDG();
            display_TenDG();
        }
        private void LoadDataGridView()
        {
            String sql = " select * from NguoiMuon";
            DocGia = Functions.GetDataTable(sql); //Đọc dữ liệu từ bảng
            Gridview_docgia.DataSource = DocGia; //Nguồn dữ liệu            
            Gridview_docgia.Columns[0].HeaderText = "Mã độc giả";
            Gridview_docgia.Columns[1].HeaderText = " Họ tên";
            Gridview_docgia.Columns[2].HeaderText = "Ngày Sinh";
            Gridview_docgia.Columns[2].DefaultCellStyle.Format = "dd/MM/yyyy";
            Gridview_docgia.Columns[3].HeaderText = "Giới tính ";
            Gridview_docgia.Columns[4].HeaderText = "Số điện thoại ";
            Gridview_docgia.Columns[5].HeaderText = "Địa chỉ";
            Gridview_docgia.AllowUserToAddRows = false; //Không cho người dùng thêm dữ liệu trực tiếp
            Gridview_docgia.EditMode = DataGridViewEditMode.EditProgrammatically; //Không cho sửa dữ liệu trực tiếp
        }

        private void display_maDG()
        {
            string sql = " select* from NguoiMuon";
            Functions.FillCombo(sql, cb_Madg, "MaDG", "MaDG");
            cb_Madg.SelectedIndex = -1;
        }

        private void display_TenDG()
        {
            string sql = " select * from NguoiMuon";
            Functions.FillCombo(sql, cb_ten, "MaDG", "TenDG");
           cb_ten.SelectedIndex = -1;

        }
       

        private void Gridview_docgia_Click(object sender, EventArgs e)
        {
            if (btn_add.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
               cb_Madg.Focus();
                return;
            }
            if (DocGia.Rows.Count == 0) //Nếu không có dữ liệu
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            cb_Madg.Text = Gridview_docgia.CurrentRow.Cells["MaDG"].Value.ToString();
            cb_ten.Text = Gridview_docgia.CurrentRow.Cells["TenDG"].Value.ToString();

            date_ngaysinh.Value = (DateTime)Gridview_docgia.CurrentRow.Cells["NgaySinh"].Value;
            txt_diachi.Text = Gridview_docgia.CurrentRow.Cells["DiaChi"].Value.ToString();

            string sex = Gridview_docgia.CurrentRow.Cells["Gioitinh"].Value.ToString();
            if (sex == "Nam")
            {
                checkbox_nam.Checked = true;
                checkbox_nu.Checked = false;
            }
            else
            {
                checkbox_nu.Checked = true;
                checkbox_nam.Checked = false;
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            Resetvalues();
            cb_Madg.Enabled = true;
            btn_add.Enabled = false;

        }

        private void Resetvalues()
        {
            cb_Madg.Text = "";
            cb_ten.Text = "";
            txt_diachi.Text = "";
            txt_sdt.Text = "";
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            string sql; //Lưu lệnh sql
            if (cb_Madg.Text.Trim().Length == 0) //Nếu chưa nhập mã chất liệu
            {
                MessageBox.Show("Bạn phải nhập mã độc giả", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cb_Madg.Focus();
                return;
            }


            if (cb_ten.Text.Trim().Length == 0) //Nếu chưa nhập tên chất liệu
            {
                MessageBox.Show("Bạn phải nhập tên độc giả", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cb_ten.Focus();
                return;
            }

            sql = "Select MaDG From NguoiMuon where MaDG=N'" + cb_Madg.Text.Trim() + "'";
            if (Functions.CheckKey(sql) == false)
            {
                if (checkbox_nam.Checked == true)
                {
                    string gioitinh = "Nam";

                    String sql_addDocGia = "insert into NguoiMuon values(N'" + cb_Madg.Text.Trim() + "',N'" + cb_ten.Text.Trim() + "','" + date_ngaysinh.Value + "',N'" + gioitinh + "','" + txt_sdt.Text.Trim() + "',N'"+txt_diachi.Text.Trim()+"')";
                    Functions.RunSql(sql_addDocGia);
                }
                else if (checkbox_nu.Checked == true)
                {
                    string gioitinh = "Nữ";
                    String sql_addDocGia = "insert into NguoiMuon values(N'" + cb_Madg.Text.Trim() + "',N'" + cb_ten.Text.Trim() + "','" + date_ngaysinh.Value + "',N'" + gioitinh + "','" + txt_sdt.Text.Trim() + "',N'" + txt_diachi.Text.Trim() + "')";
                    Functions.RunSql(sql_addDocGia);
                }
            }
            else
            {

                MessageBox.Show("Mã độc giả đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cb_Madg.Focus();
                return;
            }
            LoadDataGridView(); //Nạp lại DataGridView
            btn_add.Enabled = true;

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (DocGia.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (cb_Madg.Text == "") //nếu chưa chọn bản ghi nào
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xoá " + cb_ten.Text + " không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string check_fk ="select madg from muonsach where madg=N'"+cb_Madg.Text.Trim()+"'" ;
                if (Functions.CheckKey(check_fk))
                {

                    MessageBox.Show("Người này đang mượn sách không thể xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    string sql = "DELETE NguoiMuon WHERE MaDG='" + cb_Madg.Text.Trim() + " '";
                    Functions.RunSql(sql);
                }
            }
            LoadDataGridView();
            Resetvalues();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            cb_Madg.Enabled = false;
            btn_add.Enabled = false;
            btn_save.Enabled = false;


            if (DocGia.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (cb_Madg.Text == "") //nếu chưa chọn bản ghi nào
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            string gioitinh;

            if (checkbox_nam.Checked == true)
            {
                gioitinh = "Nam";
                string sql_1 = "Update NguoiMuon set MaDG='" + cb_Madg.Text.Trim() + "', TenDG=N'" + cb_ten.Text.Trim() + "',NgaySinh='" + date_ngaysinh.Value + "', GioiTinh='" + gioitinh + "', Sdt='" + txt_sdt.Text.Trim() + "', DiaChi=N'"+txt_diachi.Text.Trim()+"' Where MaDG='" + cb_Madg.Text.Trim() + "' ";
                Functions.RunSql(sql_1);
            }
            if (checkbox_nu.Checked == true)
            {
                gioitinh = "Nữ";
                string sql_1 = "Update NguoiMuon set MaDG='" + cb_Madg.Text.Trim() + "', TenDG=N'" + cb_ten.Text.Trim() + "',NgaySinh='" + date_ngaysinh.Value + "', GioiTinh='" + gioitinh + "', Sdt='" + txt_sdt.Text.Trim() + "', DiaChi=N'" + txt_diachi.Text.Trim() + "' Where MaDG='" + cb_Madg.Text.Trim() + "' ";
                Functions.RunSql(sql_1);
            }
            if (checkbox_nam.Checked == true && checkbox_nu.Checked == true)
            {
                MessageBox.Show("Bạn chỉ được chọn một giới tính", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            LoadDataGridView(); //Nạp lại DataGridView
            btn_add.Enabled = true;
            btn_save.Enabled = true;
            cb_Madg.Enabled = true;
        }

        private void bt_find_name_Click(object sender, EventArgs e)
        {
            if ((txt_find_by_name.Text == ""))
            {
                MessageBox.Show("Bạn hãy nhập điều kiện tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string sql = " select * from NguoiMuon where TenDG like N'%" + txt_find_by_name.Text.Trim() + "%'";

            DocGia = Functions.GetDataTable(sql);
            if (DocGia.Rows.Count == 0)
                MessageBox.Show("Không có bản ghi thoả mãn điều kiện tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else MessageBox.Show("Có " + DocGia.Rows.Count + "  bản ghi thoả mãn điều kiện!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Gridview_docgia.DataSource = DocGia;
        }

        private void btn_find_ma_Click(object sender, EventArgs e)
        {

            if ((txt_find_by_ma.Text == ""))
            {
                MessageBox.Show("Bạn hãy nhập điều kiện tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string sql = " select *from NguoiMuon  where MaDG like N'%" + txt_find_by_ma.Text.Trim() + "%'";

            DocGia = Functions.GetDataTable(sql);
            if (DocGia.Rows.Count == 0)
                MessageBox.Show("Không có bản ghi thoả mãn điều kiện tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else MessageBox.Show("Có " + DocGia.Rows.Count + "  bản ghi thoả mãn điều kiện!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Gridview_docgia.DataSource = DocGia;
        }

       

        private void refresh_Click(object sender, EventArgs e)
        {
            LoadDataGridView();
        }

       

        private void cb_Ten_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str;
            str = "select MaDG from NguoiMuon where TenDG=N'" + cb_ten.Text + "' ";
            cb_Madg.Text = Functions.GetFieldValues(str);
            string st3 = "select GioiTinh from NguoiMuon where MaDG ='" + cb_Madg.Text + "'";
            string gioitinh = Functions.GetFieldValues(st3);
            if (gioitinh == "Nam")
            {
                checkbox_nam.Checked = true;
                checkbox_nu.Checked = false;
            }
            else
            {
                checkbox_nam.Checked = false;
                checkbox_nu.Checked = true;
            }
            str = "Select NgaySinh from NguoiMuon where MaDG = N'" + cb_Madg.Text + "'";
            date_ngaysinh.Text = Functions.GetFieldValues(str);
            date_ngaysinh.Value = Convert.ToDateTime(date_ngaysinh.Text);
            str = "select Sdt from NguoiMuon where MaDG='" + cb_Madg.Text + "'";
            txt_sdt.Text=Functions.GetFieldValues(str);
            str = "select DiaChi from NguoiMuon where MaDG='" + cb_Madg.Text + "'";
            txt_diachi.Text = Functions.GetFieldValues(str);

        }
    }

}
