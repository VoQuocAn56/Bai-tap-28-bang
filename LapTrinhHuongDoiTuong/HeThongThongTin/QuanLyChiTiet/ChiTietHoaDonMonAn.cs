using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LapTrinhHuongDoiTuong.HeThongThongTin.QuanLyChiTiet
{
    class ChiTietHoaDonMonAn
    {
        string MaHoaDon;
        string MaMonAn;
        int SoLuong;

        public ChiTietHoaDonMonAn() {
            this.MaMonAn = "";
            this.MaHoaDon = "";
            this.SoLuong = 0;
        }

        public ChiTietHoaDonMonAn(string MaMonAn, string MaHoaDon, int SoLuong)
        {
            this.MaMonAn = MaMonAn;
            this.MaHoaDon = MaHoaDon;
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
