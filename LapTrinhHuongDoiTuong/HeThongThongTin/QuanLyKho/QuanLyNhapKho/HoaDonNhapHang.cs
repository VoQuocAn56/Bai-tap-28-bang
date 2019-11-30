using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LapTrinhHuongDoiTuong.HeThongThongTin.QuanLyKho.QuanLyNhapKho
{
    class HoaDonNhapHang
    {
        string MaHoaDonNhapHang;
        string MaNhaCungCap;
        DateTime NgayHoaLap;
        string MaNhanVien;

        public HoaDonNhapHang() {
            this.MaHoaDonNhapHang = "";   
            this.NgayHoaLap = DateTime.Now;
            this.MaNhaCungCap = "";
            this.MaNhanVien = "";
        }

        public HoaDonNhapHang(string MaHoaDonNhapHang, string MaNhaCungCap, DateTime NgayHoaLap, string MaNhanVien)
        {
            this.MaHoaDonNhapHang = MaHoaDonNhapHang;
            this.MaNhaCungCap = MaNhaCungCap;
            this.NgayHoaLap = NgayHoaLap;
            this.MaNhanVien = MaNhanVien;
        }

        public void ThemHoaDonNhapHang() { }
        public void SuaHoaDonNhapHang() { }
        public void XoaHoaDonNhapHang() { }
        public void TimKiemHoaDonNhapHang() { }
    }
}
