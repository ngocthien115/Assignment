using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using DAL_QLBanHang;
using DTO_QLBanHang;

namespace BUS_QLBanHang
{
    public class BUS_NhanVien
    {
        DAL_NhanVien dalNhanVien = new DAL_NhanVien();
        public DataTable getNhanVien()
        {
            return dalNhanVien.getNhanVien(); //Lấy dữ liệu từ DAL về, xử lý rồi trả về lại cho GUI sử dụng
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
        public bool NhanVienDangNhap(DTO_NhanVien nv)
        {
            return dalNhanVien.NhanVienDangNhap(nv);
        }
        public bool NhanVienQuenMatKhau(string email)
        {
            return dalNhanVien.NhanVienQuenMatKhau(email);
        }
        public bool TaoMatKhau(string email, string matkhauMoi)
        {
            return dalNhanVien.TaoMatKhau(email, matkhauMoi); 
        }
        public bool ThemNhanVien(DTO_NhanVien nv)
        {
            return dalNhanVien.ThemNhanVien(nv);
        }
        public bool XoaNhanVien(string email)
        {
            return dalNhanVien.XoaNhanVien(email);
        }
        public DataTable TimKiemNhanVien(string tennv)
        {
            return dalNhanVien.TimKiemNhanVien(tennv);
        }
        public DataTable VaiTroNhanVien(string email)
        {
            return dalNhanVien.VaiTroNhanVien(email);
        }
        public bool SuaThongTinNhanVien(string email, string tennv, string diachi, int vaitro, int tinhtrang)
        {
            return dalNhanVien.SuaThongTinNhanVien(email, tennv, diachi, vaitro, tinhtrang);
        }
        public bool UpdatePassword(string email, string matKhauCu, string matKhauMoi)
        {
            return dalNhanVien.UpdatePassword(email, matKhauCu, matKhauMoi);
        }
        public DataTable TrangThaiTaiKhoan(string email)
        {
            return dalNhanVien.TrangThaiTaiKhoan(email);
        }
    }
}
