using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LapTrinhHuongDoiTuong.HeThongThongTin.QuanLyKho.QuanLyXuatKho
{
    class PhieuXuatKho
    {
        string MaPhieuXuatKho;
        DateTime NgayXuatKho;
        string MaNhanVien;// khoa phu
        string LyDoXuatKho;
        string DiaDiem;//địa điểm kho
        string DiaChi;//bộ phận

        public PhieuXuatKho() {
            this.MaPhieuXuatKho = "";
            this.NgayXuatKho = DateTime.Now;
            this.MaNhanVien = "";
            this.LyDoXuatKho = "";
            this.DiaDiem = "";
            this.DiaChi = "";
        }

        public PhieuXuatKho(string MaPhieuXuatKho, DateTime NgayXuatKho, string MaNhanVien, string LyDoXuatKho, string DiaDiem, this.DiaChi)
        {
            this.MaPhieuXuatKho = "";
            this.NgayXuatKho = DateTime.Now;
            this.MaNhanVien = "";
            this.LyDoXuatKho = "";
            this.DiaDiem = "";
            this.DiaChi = "";
        }

        public void ThemPhieuXuatKho() { }
        public void SuaPhieuXuatKho() { }
        public void XoaPhieuXuatKho() { }
        public void TimKiemPhieuXuatKho() { }
    }
}
