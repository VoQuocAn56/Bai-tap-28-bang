using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LapTrinhHuongDoiTuong.HeThongThongTin.QuanLyBanHang
{
    class PhieuDatMon
    {
        string MaPhieuDatMon;
        string MaNhanVien;
        string MaBanAn;
        DateTime NgayLap;

        public PhieuDatMon() {
            this.MaPhieuDatMon = "";
            this.MaNhanVien = "";
            this.MaBanAn = "";
            this.NgayLap = DateTime.Now;
        }

        public PhieuDatMon(string MaPhieuDatMon, string MaNhanVien, string MaBanAn, DateTime NgayLap)
        {
            this.MaPhieuDatMon = MaPhieuDatMon;
            this.MaNhanVien = MaNhanVien;
            this.MaBanAn = MaBanAn;
            this.NgayLap = NgayLap;
        }

        public void Tao() { }
        public void Them() { }
        public void Sua() { }
        public void Xoa() { }
        public void TimKiem() { }
        public void ThongKe() { }
    }
}
