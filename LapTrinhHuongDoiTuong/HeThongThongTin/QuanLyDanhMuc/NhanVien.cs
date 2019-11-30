using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LapTrinhHuongDoiTuong.HeThongThongTin.QuanLyDanhMuc
{
    class NhanVien
    {
        string MaNhanVien;
        string TenNhanVien;
        string DiaChi;
        bool GioiTinh;
        DateTime NgaySinh;
        string SoDienThoai;

        string MaChuVu;

        public NhanVien() {
            this.MaNhanVien = "";
            this.TenNhanVien = "";
            this.DiaChi = "";
            this.GioiTinh = true;
            this.NgaySinh = DateTime.Now;
            this.SoDienThoai = "";
        }

        public NhanVien(string MaNhanVien, string TenNhanVien, string DiaChi, bool GioiTinh, DateTime NgaySinh,string SoDienThoai, string MaChucVu)
        {
            this.MaNhanVien = MaNhanVien;
            this.TenNhanVien = TenNhanVien;
            this.DiaChi = DiaChi;
            this.GioiTinh = GioiTinh;
            this.NgaySinh = NgaySinh;
            this.SoDienThoai = SoDienThoai;
            this.MaChuVu = MaChucVu;
        }

        public void ThemNhanVien() { }
        public void SuaNhanVien() { }
        public void XoaNhanVien() { }
        public void TimKiemNhanVien() { }
    }
}
