using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LapTrinhHuongDoiTuong.HeThongThongTin.QuanLyKho.QuanLyNhapKho
{
    class PhieuNhapKho
    {
        string MaPhieuNhapKho;
        DateTime NgayGioNhapHang;
        string MaNhaCungCap;
        double No;//nợ
        double Co;//có
        string DiaDiem;// dia diem nhap kho
        string MaNhanVien;// khoa phu

        public PhieuNhapKho() {
            this.MaPhieuNhapKho = "";
            this.NgayGioNhapHang = DateTime.Now;
            this.MaNhaCungCap = "";
            this.No = 0;
            this.Co = 0;
            this.DiaDiem = "";
            this.MaNhanVien = "";
        }

        public PhieuNhapKho(string MaPhieuNhapKho, DateTime NgayGioNhapHang, string MaNhaCungCap, double No, double Co, string DiaDiem, string MaNhanVien)        {
            this.MaPhieuNhapKho = MaPhieuNhapKho;
            this.NgayGioNhapHang = NgayGioNhapHang;
            this.MaNhaCungCap = MaNhaCungCap;
            this.No = No;
            this.Co = Co;
            this.DiaDiem = DiaDiem;
            this.MaNhanVien = MaNhanVien;
        }

        public void ThemPhieuNhapKho() { }
        public void SuaPhieuNhapKho() { }
        public void XoaPhieuNhapKho() { }
        public void TimKiemPhieuNhapKho() { }
    }
}
