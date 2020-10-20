using BUS_QLBanHang;
using DTO_QLBanHang;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmMain
{
    public partial class formKhachHang : Form
    {
        BUS_KhachHang busKH = new BUS_KhachHang();
        string stremail;
        public formKhachHang()
        {
            InitializeComponent();
        }
        public formKhachHang(string email)
        {
            stremail = email;
            InitializeComponent();
        }

        private void formKhachHang_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = busKH.getKhachHang();
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dataGridView1.CurrentRow.Index;
            txtDienThoai.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            txtHoTen.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            txtDiaChi.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            string gender = dataGridView1.Rows[i].Cells[3].Value.ToString();
            if (gender == "1")
            {
                rdNam.Checked = true;
            }
            else rdNu.Checked = true;
        }

        private void btTimKiem_Click(object sender, EventArgs e)
        {
            if (txtTimKiem.Text == "")
            {
                MessageBox.Show("Chưa nhập số điện thoại khách hàng!");
            }
            else
            {
                dataGridView1.DataSource = busKH.TimKiemKhachHang(txtTimKiem.Text);
            }
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            btXoa.Enabled = false;
            btBoQua.Enabled = false;
            btDanhSach.Enabled = false;
            btSua.Enabled = false;
        }

        private void btLuu_Click(object sender, EventArgs e)
        {
            DTO_KhachHang kh = new DTO_KhachHang();
            kh.dienThoai = txtDienThoai.Text;
            kh.tenKH = txtHoTen.Text;
            kh.diaChi = txtDiaChi.Text;
            string gender;
            if (rdNam.Checked)
            {
                gender = "1";
            }
            else
            {
                gender = "0";
            }
            kh.phai = gender;
            busKH.ThemKhachHang(kh, stremail);
            MessageBox.Show("Đã thêm khách hàng thành công!");
            btXoa.Enabled = true;
            btSua.Enabled = true;
            btBoQua.Enabled = true;
            btDanhSach.Enabled = true;
        }

        private void btDanhSach_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = busKH.getKhachHang();
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            busKH.XoaKhachHang(txtDienThoai.Text);
            MessageBox.Show("Đã xóa khách hàng");
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            string gender;
            if (rdNam.Checked)
            {
                gender = "1";
            }
            else gender = "0";
            busKH.SuaThongTinKhachHang(txtDienThoai.Text, txtHoTen.Text, txtDiaChi.Text, gender);
            MessageBox.Show("Đã sửa thông tin khách hàng");
        }
    }
}
