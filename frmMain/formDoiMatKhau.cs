using BUS_QLBanHang;
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
    public partial class formDoiMatKhau : Form
    {
        BUS_NhanVien busNhanVien = new BUS_NhanVien();
        string stremail;
        #region Encryp - Sendmail
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
        #endregion
        public formDoiMatKhau(string email)
        {
            InitializeComponent();
            stremail = email;
            txtEmail.Text = stremail;
            txtEmail.Enabled = false;
        }
        public formDoiMatKhau()
        {
            InitializeComponent();
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

        private void formDoiMatKhau_Load(object sender, EventArgs e)
        {

        }
        private void btDoiMatKhau_Click(object sender, EventArgs e)
        {
            if (txtOldPwd.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mật khẩu cũ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtOldPwd.Focus();
                return;
            }
            else if (txtNewPwd.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mật khẩu mới", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNewPwd.Focus();
                return;
            }
            else if (txtCheckPwd.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mật khẩu xác nhận mật khẩu mới", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCheckPwd.Focus();
                return;
            }
            else if (txtNewPwd.Text.Trim() != txtCheckPwd.Text.Trim())
            {
                MessageBox.Show("Mật khẩu mới không trùng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNewPwd.Focus();
                return;
            }
            else
            {
                if (MessageBox.Show("Bạn có chắc muốn cập nhật mật khẩu", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string matkhaumoi = Encryption(txtNewPwd.Text);
                    string matkhaucu = Encryption(txtOldPwd.Text);
                    if (busNhanVien.UpdatePassword(txtEmail.Text, matkhaucu, matkhaumoi))
                    {
                        formMain.profile = 1;
                        formMain.session = 0;
                        SendMail(stremail, txtCheckPwd.Text);
                        MessageBox.Show("Cập nhật mật khẩu thành công! Vui lòng đăng nhập lại");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Mật khẩu cũ không đúng! Cập nhật mật khẩu không thành công");
                        txtOldPwd.Text = "";
                        txtNewPwd.Text = "";
                        txtCheckPwd.Text = "";
                    }
                }
                else
                {
                    
                }
            }
        }
    }
}
