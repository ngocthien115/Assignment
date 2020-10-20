using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Threading;

namespace frmMain
{
    public partial class formMain : Form
    {
        public static int session = 0; // Kiểm tra tình trạng login
        public static int profile = 0;
        public static string mail; //truyền email từ formMain cho các form khác
        Thread th;
        formLogin dn;
        public formMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ResetValue();
            if (profile == 1)
            {
                thôngTinToolStripMenuItem.Text = null;
                profile = 0;
            }
            this.IsMdiContainer = true;
        }
        private void VaiTroNV()
        {
            NhanVienToolStripMenuItem.Visible = false;
            thốngKêToolStripMenuItem.Visible = false;
        }
        private void ResetValue()
        {
            if (session == 1)
            {
                thôngTinToolStripMenuItem.Text = "Chào " + formMain.mail;
                NhanVienToolStripMenuItem.Visible = true;
                DanhMụcToolStripMenuItem.Visible = true;
                dangxuatToolStripMenuItem.Enabled = true;
                thốngKêToolStripMenuItem.Visible = true;
                thốngKêSảnPhẩmToolStripMenuItem.Visible = true;
                hosonhanvineToolStripMenuItem1.Visible = true;
                đăngNhậpToolStripMenuItem.Enabled = false;
                if (int.Parse(dn.vaitro) == 0)
                {
                    VaiTroNV();
                }
            }
            else
            {
                NhanVienToolStripMenuItem.Visible = false;
                DanhMụcToolStripMenuItem.Visible = false;
                dangxuatToolStripMenuItem.Enabled = false;
                hosonhanvineToolStripMenuItem1.Visible = false;
                thốngKêSảnPhẩmToolStripMenuItem.Visible = false;
                thốngKêToolStripMenuItem.Visible = false;
                đăngNhậpToolStripMenuItem.Enabled = true;

            }
        }

        private void thoátToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            DialogResult thongbao;
            thongbao = (MessageBox.Show("Bạn có muốn thoát ?", "Chú ý",
                 MessageBoxButtons.YesNo, MessageBoxIcon.Warning));
            if (thongbao == DialogResult.Yes)
            {
                Close();
            }
        }
        public bool CheckExistForm(string name)
        {
            bool check = false;
            foreach (Form frm in this.MdiChildren)
            {
                if (frm.Name == name)
                {
                    check = true;
                    break;
                }
            }
            return check;
        }
        private void ActiveChildForm(string name)
        {
            foreach (Form frm in this.MdiChildren)
            {
                if (frm.Name == name)
                {
                    frm.Activate();
                    break;
                }
            }
        }
        void FormLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Khi form đăng nhập đóng thì refresh formMain
            this.Refresh();
            Form1_Load(sender, e);
        }
        public void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dn = new formLogin();
            if (!CheckExistForm("formLogin"))
            {
                dn.MdiParent = this;
                dn.Show();
                dn.FormClosed += new FormClosedEventHandler(FormLogin_FormClosed);
            }
            else
            {
                ActiveChildForm("formLogin");
            }
        }

        private void sanphamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new formSanPham();
            frm.ShowDialog();
        }

        private void NhanVienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new formNhanVien();
            frm.ShowDialog();
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmKhachHang = new formKhachHang(formMain.mail);
            frmKhachHang.Show();
        }
        public void FormThongTinNV_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Refresh();
            Form1_Load(sender, e);
        }
        private void hosonhanvineToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            formDoiMatKhau hosonv = new formDoiMatKhau(formMain.mail);
            if (!CheckExistForm("formDoiMatKhau"))
            {
                hosonv.MdiParent = this;
                hosonv.FormClosed += new FormClosedEventHandler(FormThongTinNV_FormClosed);
                hosonv.Show();
            }
            else
            {
                ActiveChildForm("formDoiMatKhau");
            }
        }

        private void hướngDẫnSửDụngToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                var path = Path.Combine(Directory.GetCurrentDirectory(), "Tai lieu huong dan su dung phan mem.pdf");
                System.Diagnostics.Process.Start(path);
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("Không tìm thấy file!");
            }
        }

        private void dangxuatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            session = 0;
            ResetValue();
            thôngTinToolStripMenuItem.Text = "";
            MessageBox.Show("Bạn đã đăng xuất!");
        }
    }
}
