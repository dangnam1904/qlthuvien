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
    public partial class fr_tacgia : Form
    {
        DataTable TacGia;
        public fr_tacgia()
        {
            InitializeComponent();
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            LoadDataGridView();
           
        }

        private void fr_tacgia_Load(object sender, EventArgs e)
        {
            LoadDataGridView();
            display_maTG();
            display_TenTG();
        }
        private void LoadDataGridView()
        {
            String sql = " select * from TacGia";
            TacGia = Functions.GetDataTable(sql); //Đọc dữ liệu từ bảng
           Gridview_TacGia.DataSource = TacGia; //Nguồn dữ liệu            
           Gridview_TacGia.Columns[0].HeaderText = "Mã tác giả";
           Gridview_TacGia.Columns[1].HeaderText = " Họ tên";
           Gridview_TacGia.Columns[2].HeaderText = "Tóm tắt thông tin";
            Gridview_TacGia.Columns[2].Width = 400;
        
           Gridview_TacGia.AllowUserToAddRows = false; //Không cho người dùng thêm dữ liệu trực tiếp
           Gridview_TacGia.EditMode = DataGridViewEditMode.EditProgrammatically; //Không cho sửa dữ liệu trực tiếp
        }

        private void display_maTG()
        {
            string sql = " select* from TacGia";
            Functions.FillCombo(sql, cb_MaTG, "MaTG", "MaTG");
           cb_MaTG.SelectedIndex = -1;
        }

        private void display_TenTG()
        {
            string sql = " select* from TacGia";
            Functions.FillCombo(sql,cb_TenTG, "MaTG", "TenTG");
            cb_TenTG.SelectedIndex = -1;

        }

        private void Gridview_TacGia_Click(object sender, EventArgs e)
        {
            if (btn_add.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cb_MaTG.Focus();
                return;

            }
            if (TacGia.Rows.Count == 0) //Nếu không có dữ liệu
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            cb_MaTG.Text = Gridview_TacGia.CurrentRow.Cells["MaTG"].Value.ToString();
            cb_TenTG.Text = Gridview_TacGia.CurrentRow.Cells["TenTG"].Value.ToString();
            rtxt_thongtin.Text = Gridview_TacGia.CurrentRow.Cells["TomTatThongTin"].Value.ToString();
        }
        private void btn_add_Click(object sender, EventArgs e)
        {
            Resetvalues();
            cb_MaTG.Enabled = true;
            btn_add.Enabled = false;

        }

        private void Resetvalues()
        {
            cb_MaTG.Text = "";
            cb_TenTG.Text = "";
            rtxt_thongtin.Text = "";
            
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            string sql; //Lưu lệnh sql
            if (cb_MaTG.Text.Trim().Length == 0) //Nếu chưa nhập mã chất liệu
            {
                MessageBox.Show("Bạn phải nhập mã tác giả", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cb_MaTG.Focus();
                return;
            }


            if (cb_TenTG.Text.Trim().Length == 0) //Nếu chưa nhập tên chất liệu
            {
                MessageBox.Show("Bạn phải nhập tên tác giả", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cb_TenTG.Focus();
                return;
            }

            sql = "Select MaTG From TacGia where MaTG=N'" + cb_MaTG.Text.Trim() + "'";
            if (Functions.CheckKey(sql) == false)
            {
                    sql = "insert into TacGia values(N'" + cb_MaTG.Text.Trim() + "',N'" + cb_TenTG.Text.Trim() + "',N'" + rtxt_thongtin.Text.Trim() + "')";
                    Functions.RunSql(sql);
            }
            else
            {
                MessageBox.Show("Mã tác giả đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cb_MaTG.Focus();
                return;
            }
            LoadDataGridView(); //Nạp lại DataGridView
            btn_add.Enabled = true;

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (TacGia.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (cb_MaTG.Text == "") //nếu chưa chọn bản ghi nào
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xoá " + cb_TenTG.Text + " không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string chek_fk = "select matg from sach where matg= N'" + cb_MaTG.Text.Trim() + "' ";
                if (Functions.CheckKey(chek_fk))
                {
                    MessageBox.Show("Tác giả này đã sáng tác sách, không thể xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    string sql = "DELETE TacGia WHERE MaTG=N'" + cb_MaTG.Text.Trim() + " '";
                    Functions.RunSql(sql);
                }
            }
            LoadDataGridView();
            Resetvalues();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            cb_MaTG.Enabled = false;
            btn_add.Enabled = false;
            btn_save.Enabled = false;


            if (TacGia.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (cb_MaTG.Text == "") //nếu chưa chọn bản ghi nào
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                string sql_1 = "Update TacGia set MaTG=N'" + cb_MaTG.Text.Trim() + "', TenTG=N'" + cb_TenTG.Text.Trim() + "',TomTatThongTin=N'" + rtxt_thongtin.Text.Trim() + "' Where MaTG=N'" + cb_MaTG.Text.Trim() + "' ";
                Functions.RunSql(sql_1);
                LoadDataGridView(); //Nạp lại DataGridView
                btn_add.Enabled = true;
                btn_save.Enabled = true;
                cb_MaTG.Enabled = true;
            }
            
        }

        private void bt_find_name_Click(object sender, EventArgs e)
        {
            if ((txt_find_by_name.Text == ""))
            {
                MessageBox.Show("Bạn hãy nhập điều kiện tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string sql = " select * from TacGia where TenTG like N'%" + txt_find_by_name.Text.Trim() + "%'";

           TacGia = Functions.GetDataTable(sql);
            if (TacGia.Rows.Count == 0)
                MessageBox.Show("Không có bản ghi thoả mãn điều kiện tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else MessageBox.Show("Có " + TacGia.Rows.Count + "  bản ghi thoả mãn điều kiện!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
           Gridview_TacGia.DataSource = TacGia;
        }

        private void btn_find_ma_Click(object sender, EventArgs e)
        {

            if ((txt_find_by_ma.Text == ""))
            {
                MessageBox.Show("Bạn hãy nhập điều kiện tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string sql = " select *from TacGia  where MaTG like N'%" + txt_find_by_ma.Text.Trim() + "%'";

            TacGia = Functions.GetDataTable(sql);
            if (TacGia.Rows.Count == 0)
                MessageBox.Show("Không có bản ghi thoả mãn điều kiện tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else MessageBox.Show("Có " + TacGia.Rows.Count + "  bản ghi thoả mãn điều kiện!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
           Gridview_TacGia.DataSource = TacGia;
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            LoadDataGridView();
        }

        private void cb_TenTG_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str;
            str = "select MaTG from TacGia where TenTG=N'" + cb_TenTG.Text + "' ";
            cb_MaTG.Text = Functions.GetFieldValues(str);
            string st3 = "select TomTatThongTin from TacGia where MaTG ='" + cb_MaTG.Text + "'";
            rtxt_thongtin.Text = Functions.GetFieldValues(st3);
        }

        private void cb_MaTG_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }

}
