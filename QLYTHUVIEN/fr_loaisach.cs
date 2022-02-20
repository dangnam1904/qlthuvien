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
    public partial class fr_loaisach : Form
    {
        DataTable loaisach;
        public fr_loaisach()
        {
            InitializeComponent();
        }

       
        private void fr_loaisach_Load(object sender, EventArgs e)
        {
            LoadDataGridView();
            display_maLoại();
            display_TenLoai();
        }
        private void LoadDataGridView()
        {
            String sql = " select * from loaisach";
            loaisach = Functions.GetDataTable(sql); //Đọc dữ liệu từ bảng
            Gridview_loaisach.DataSource = loaisach; //Nguồn dữ liệu            
            Gridview_loaisach.Columns[0].HeaderText = "Mã loại sách";
            Gridview_loaisach.Columns[1].HeaderText = "Tên Loại";
            Gridview_loaisach.Columns[2].HeaderText = "Kiểu sách";
            Gridview_loaisach.Columns[1].Width = 250;

            Gridview_loaisach.AllowUserToAddRows = false; //Không cho người dùng thêm dữ liệu trực tiếp
            Gridview_loaisach.EditMode = DataGridViewEditMode.EditProgrammatically; //Không cho sửa dữ liệu trực tiếp
        }

        private void display_maLoại()
        {
            string sql = " select* from loaisach";
            Functions.FillCombo(sql, cb_MaLoai, "MaLoaiSach", "MaLoaiSach");
            cb_MaLoai.SelectedIndex = -1;
        }

        private void display_TenLoai()
        {
            string sql = " select* from loaisach";
            Functions.FillCombo(sql, cb_TenLoai, "MaLoaiSach", "TenLoai");
            cb_TenLoai.SelectedIndex = -1;

        }

        private void Gridview_loaisach_Click(object sender, EventArgs e)
        {
            if (btn_add.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cb_MaLoai.Focus();
                return;

            }
            if (loaisach.Rows.Count == 0) //Nếu không có dữ liệu
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            cb_MaLoai.Text = Gridview_loaisach.CurrentRow.Cells["MaLoaiSach"].Value.ToString();
            cb_TenLoai.Text = Gridview_loaisach.CurrentRow.Cells["TenLoai"].Value.ToString();
            txt_kieusach.Text = Gridview_loaisach.CurrentRow.Cells["KieuSach"].Value.ToString();
        }
        private void btn_add_Click(object sender, EventArgs e)
        {
            Resetvalues();
            cb_MaLoai.Enabled = true;
            btn_add.Enabled = false;

        }

        private void Resetvalues()
        {
            cb_MaLoai.Text = "";
            cb_TenLoai.Text = "";
           txt_kieusach.Text = "";

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            string sql; //Lưu lệnh sql
            if (cb_MaLoai.Text.Trim().Length == 0) //Nếu chưa nhập mã chất liệu
            {
                MessageBox.Show("Bạn phải nhập mã loại sách", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cb_MaLoai.Focus();
                return;
            }


            if (cb_TenLoai.Text.Trim().Length == 0) //Nếu chưa nhập tên chất liệu
            {
                MessageBox.Show("Bạn phải nhập tên loại sách", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cb_TenLoai.Focus();
                return;
            }

            sql = "Select MaLoaiSach From loaisach where MaLoaiSach=N'" + cb_MaLoai.Text.Trim() + "'";
            if (Functions.CheckKey(sql) == false)
            {
                sql = "insert into loaisach values(N'" + cb_MaLoai.Text.Trim() + "',N'" + cb_TenLoai.Text.Trim() + "',N'" + txt_kieusach.Text.Trim() + "')";
                Functions.RunSql(sql);
            }
            else
            {
                MessageBox.Show("Mã loại sách đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cb_MaLoai.Focus();
                return;
            }
            LoadDataGridView(); //Nạp lại DataGridView
            btn_add.Enabled = true;

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (loaisach.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (cb_MaLoai.Text == "") //nếu chưa chọn bản ghi nào
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xoá " + cb_TenLoai.Text + " không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string check_fk = "select maloaisach from sach where maloaisach=N'"+cb_MaLoai.Text.Trim()+"'";
                if(Functions.CheckKey(check_fk))
                {
                    MessageBox.Show("Loại sách này đang chưa sách không thể xóa, vui lòng xóa sách thuộc loại sách này trước", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }    
                string sql = "DELETE loaisach WHERE MaLoaiSach=N'" + cb_MaLoai.Text.Trim() + " '";
                Functions.RunSql(sql);

            }
            LoadDataGridView();
            Resetvalues();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            cb_MaLoai.Enabled = false;
            btn_add.Enabled = false;
            btn_save.Enabled = false;


            if (loaisach.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (cb_MaLoai.Text == "") //nếu chưa chọn bản ghi nào
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                string sql_1 = "Update loaisach set MaLoaiSach=N'" + cb_MaLoai.Text.Trim() + "', TenLoai=N'" + cb_TenLoai.Text.Trim() + "', KieuSach=N'" + txt_kieusach.Text.Trim() + "' Where MaLoaiSach=N'" + cb_MaLoai.Text.Trim() + "' ";
                Functions.RunSql(sql_1);
                LoadDataGridView(); //Nạp lại DataGridView
                btn_add.Enabled = true;
                btn_save.Enabled = true;
                cb_MaLoai.Enabled = true;
            }

        }

        private void bt_find_name_Click(object sender, EventArgs e)
        {
            if ((txt_find_by_name.Text == ""))
            {
                MessageBox.Show("Bạn hãy nhập điều kiện tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string sql = " select * from loaisach where TenLoai like N'%" + txt_find_by_name.Text.Trim() + "%'";

            loaisach = Functions.GetDataTable(sql);
            if (loaisach.Rows.Count == 0)
                MessageBox.Show("Không có bản ghi thoả mãn điều kiện tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else MessageBox.Show("Có " + loaisach.Rows.Count + "  bản ghi thoả mãn điều kiện!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Gridview_loaisach.DataSource = loaisach;
        }

        private void btn_find_ma_Click(object sender, EventArgs e)
        {

            if ((txt_find_by_ma.Text == ""))
            {
                MessageBox.Show("Bạn hãy nhập điều kiện tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string sql = " select *from loaisach  where MaLoaiSach like N'%" + txt_find_by_ma.Text.Trim() + "%'";

            loaisach = Functions.GetDataTable(sql);
            if (loaisach.Rows.Count == 0)
                MessageBox.Show("Không có bản ghi thoả mãn điều kiện tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else MessageBox.Show("Có " + loaisach.Rows.Count + "  bản ghi thoả mãn điều kiện!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Gridview_loaisach.DataSource = loaisach;
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            LoadDataGridView();
        }

        private void cb_TenLoai_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str;
            str = "select MaLoaiSach from loaisach where TenLoai=N'" + cb_TenLoai.Text + "' ";
            cb_MaLoai.Text = Functions.GetFieldValues(str);
            string st3 = "select kieusach from loaisach where MaLoaiSach ='" + cb_MaLoai.Text + "'";
            txt_kieusach.Text = Functions.GetFieldValues(st3);
        }

       
    }
}
