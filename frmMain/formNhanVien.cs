using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS_QLBanHang;
using DTO_QLBanHang;

namespace frmMain
{
    public partial class formNhanVien : Form
    {
        
        public formNhanVien()
        {
            InitializeComponent();
        }


        BUS_NhanVien busNV = new BUS_NhanVien();
        private void formNhanVien_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = busNV.getNhanVien(); //Lấy phương thức getNhanVien từ BUS gán vào DataGridView.
        }

        private void btLuu_Click(object sender, EventArgs e)
        {
            DTO_NhanVien nv = new DTO_NhanVien();
            nv.email = txtEmail.Text;
            nv.tenNV = txtTenNhanVien.Text;
            nv.diaChi = txtDiaChi.Text;
            int active;
            int role;
            if (rdHoatDong.Checked)
            {
                active = 1;
            }
            else
            {
                active = 0;
            }
            if (rdNhanVien.Checked)
            {
                role = 0;
            }
            else
            {
                role = 1;
            }
            nv.vaiTro = role;
            nv.tinhTrang = active;
            busNV.ThemNhanVien(nv);
            MessageBox.Show("Đã thêm nhân viên thành công!");
            btXoa.Enabled = true;
            btSua.Enabled = true;
            btBoQua.Enabled = true;
            btDanhSach.Enabled = true;
        }

        private void btDanhSach_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = busNV.getNhanVien();
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            busNV.XoaNhanVien(txtEmail.Text);
            MessageBox.Show("Đã xóa nhân viên thành công");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dataGridView1.CurrentRow.Index;
            txtEmail.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            txtTenNhanVien.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            txtDiaChi.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            string active = dataGridView1.Rows[i].Cells[4].Value.ToString();
            string role = dataGridView1.Rows[i].Cells[3].Value.ToString();
            if (active == "1")
            {
                rdHoatDong.Checked = true;
            }
            else rdNgungHoatDong.Checked = true;
            if (role == "1")
            {
                rdQuanTri.Checked = true;
            }
            else rdNhanVien.Checked = true;
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            DialogResult thongbao;
            thongbao = (MessageBox.Show("Bạn có muốn thoát ?", "Chú ý",
                 MessageBoxButtons.YesNo, MessageBoxIcon.Warning));
            if (thongbao == DialogResult.Yes)
            {
                Close();
            }
        }
        private void btTimKiem_Click(object sender, EventArgs e)
        {
            if (txtTimKiem.Text == "")
            {
                MessageBox.Show("Chưa nhập tên nhân viên!");
            }
            else
            {
                dataGridView1.DataSource = busNV.TimKiemNhanVien(txtTimKiem.Text);
            }
        }

        private void btBoQua_Click(object sender, EventArgs e)
        {

        }

        private void btThem_Click(object sender, EventArgs e)
        {
            btXoa.Enabled = false;
            btBoQua.Enabled = false;
            btDanhSach.Enabled = false;
            btSua.Enabled = false;
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            int active; int role;
            if (rdHoatDong.Checked)
            {
                active = 1;
            }
            else active = 0;
            if (rdQuanTri.Checked)
            {
                role = 1;
            } else role = 0;
            busNV.SuaThongTinNhanVien(txtEmail.Text, txtTenNhanVien.Text, txtDiaChi.Text, role, active);
            MessageBox.Show("Đã chỉnh sửa thông tin nhân viên!");
        }
    }
}
