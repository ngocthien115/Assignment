using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QLBanHang
{
    public class DTO_NhanVien
    {
        private string MaNV;
        private string Email;
        private string TenNV;
        private string DiaChi;
        private int VaiTro;
        private int TinhTrang;
        private string MatKhau;

        public string maNV
        {
            get
            {
                return MaNV;
            }
            set
            {
                MaNV = value;
            }
        }

        public string email
        {
            get
            {
                return Email;
            }
            set
            {
                Email = value;
            }
        }

        public string tenNV
        {
            get
            {
                return TenNV;
            }
            set
            {
                TenNV = value;
            }
        }
        public string diaChi
        {
            get
            {
                return DiaChi;
            }
            set
            {
                DiaChi = value;
            }
        }

        public int vaiTro
        {
            get
            {
                return VaiTro;
            }
            set
            {
                VaiTro = value;
            }
        }

        public int tinhTrang
        {
            get
            {
                return TinhTrang;
            }
            set
            {
                TinhTrang = value;
            }
        }

        public string matKhau
        {
            get
            {
                return MatKhau;
            }
            set
            {
                MatKhau = value;
            }
        }
        // Constructor
        public DTO_NhanVien()
        {

        }
        public DTO_NhanVien(string tenNV, int tinhTrang, int vaiTro)
        {
            this.TenNV = tenNV;
            this.TinhTrang = tinhTrang;
            this.VaiTro = vaiTro;
        }
    }
}
