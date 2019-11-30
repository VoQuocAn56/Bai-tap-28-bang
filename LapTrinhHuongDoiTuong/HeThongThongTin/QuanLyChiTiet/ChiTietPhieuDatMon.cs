using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LapTrinhHuongDoiTuong.HeThongThongTin.QuanLyChiTiet
{
    class ChiTietPhieuDatMon
    {
        string MaPhieuDatMon;
        string MaMonAn;
        int SoLuong;

        public ChiTietPhieuDatMon() {
            this.MaPhieuDatMon = "";
            this.MaMonAn = "";
            this.SoLuong = 0;
        }

        public ChiTietPhieuDatMon(string MaPhieuDatMon, string MaMonAn, int SoLuong)
        {
            this.MaPhieuDatMon = MaPhieuDatMon;
            this.MaMonAn = MaMonAn;
            this.SoLuong = SoLuong;
        }

        public void Tao() { }
        public void Them() { }
        public void Sua() { }
        public void Xoa() { }
        public void TimKiem() { }
        public void ThongKe() { }
        public void In() { }
    }
}
