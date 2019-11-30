using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LapTrinhHuongDoiTuong.HeThongThongTin.QuanLyHeThong
{
    class TaiKhoan
    {
        string TenTaiKhoan;
        string MatKhau;
        string ChucVu;
        string MaNhanVien; //khoa phu

        public TaiKhoan()
        {
            this.TenTaiKhoan = "";
            this.MatKhau = "";
            this.ChucVu = "";
            this.MaNhanVien = "";
        }
        public TaiKhoan(string TenTaiKhoan, string MatKhau, string ChucVu, string MaNhanVien)
        {
            this.TenTaiKhoan = TenTaiKhoan;
            this.MatKhau = MatKhau;
            this.ChucVu = ChucVu;
            this.MaNhanVien = MaNhanVien;
        }

        public void ThemTaiKhoan() { }
        public void SuaTaiKhoan() { }
        public void XoaTaiKhoan() { }
        public void TimKiemTaiKhoan() { }
    }
}
