using BUS_QLBanHang;
using DTO_QLBanHang;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmMain
{
    public partial class formLogin : Form
    {
        BUS_NhanVien busNhanVien = new BUS_NhanVien();
        public string vaitro { get; set; }
        public string matkhau { get; set; }
        public string status { get; set; }
        public formLogin()
        {
            InitializeComponent();
        }

        private void btDangNhap_Click(object sender, EventArgs e)
        {
            DTO_NhanVien nv = new DTO_NhanVien();
            nv.email = txtEmail.Text;
            nv.matKhau = Encryption(txtPwd.Text);
            DataTable dt1 = busNhanVien.TrangThaiTaiKhoan(nv.email);
            status = dt1.Rows[0][0].ToString();
            if (status == "0")
            {
                MessageBox.Show("Tài khoản này đã dừng hoạt động.");
            }
            else
            {
                if (busNhanVien.NhanVienDangNhap(nv))
                {
                    // login = true
                    formMain.mail = nv.email;
                    DataTable dt = busNhanVien.VaiTroNhanVien(nv.email);
                    vaitro = dt.Rows[0][0].ToString();
                    MessageBox.Show("Đăng nhập thành công!");
                    formMain.session = 1;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Kiểm tra lại email hoặc mật khẩu!");
                    txtEmail.Text = null;
                    txtPwd.Text = null;
                    txtEmail.Focus();
                }
            }
        }

        public string Encryption(string password)
        {
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            byte[] encrypt;
            UTF8Encoding encode = new UTF8Encoding();
            encrypt = md5.ComputeHash(encode.GetBytes(password));
            StringBuilder encryptdata = new StringBuilder();
            for (int i = 0; i < encrypt.Length; i++)
            {
                encryptdata.Append(encrypt[i].ToString());
            }
            return encryptdata.ToString();
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

        private void formLogin_Load(object sender, EventArgs e)
        {

        }
        public string RandomString(int size, bool lowerCase)
        {
            StringBuilder builder = new StringBuilder();
            Random random = new Random();
            char ch;
            for (int i = 0; i < size; i++)
            {
                ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65)));
                builder.Append(ch);
            }
            if (lowerCase)
                return builder.ToString().ToLower();
            return builder.ToString();
        }
        //Tạo số ngẫu nhiên
        public int RandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }
        public void SendMail(string email, string matkhau)
        {
            try
            {
                SmtpClient client = new SmtpClient("smtp.gmail.com", 25);
                NetworkCredential cred = new NetworkCredential("pthien390@gmail.com", "ngocthien");
                MailMessage msg = new MailMessage();
                msg.From = new MailAddress("pthien390@gmail.com");
                msg.To.Add(email);
                msg.Subject = "Bạn đã sử dụng tính năng quên mật khẩu";
                msg.Body = "Chào anh/chị, mật khẩu mới để truy cập phần mềm là " + matkhau;
                client.Credentials = cred;
                client.EnableSsl = true;
                client.Send(msg);
                MessageBox.Show("Một email khôi phục mật khẩu được gửi về mail của bạn!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Một lỗi đã xảy ra khi gửi mail. Vui lòng thử lại sau!\n" + ex);
            }
        }

        private void lblQuenMK_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text != "")
            {
                if (busNhanVien.NhanVienQuenMatKhau(txtEmail.Text))
                {
                    StringBuilder builder = new StringBuilder();
                    builder.Append(RandomString(4, true));
                    builder.Append(RandomNumber(1000, 9999));
                    builder.Append(RandomString(2, false));
                    MessageBox.Show(builder.ToString());
                    string matkhaumoi = Encryption(builder.ToString());
                    busNhanVien.TaoMatKhau(txtEmail.Text, matkhaumoi);
                    SendMail(txtEmail.Text, builder.ToString());
                }
            }
        }
    }
}
