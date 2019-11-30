using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LapTrinhHuongDoiTuong.HeThongThongTin.QuanLyChiTiet
{
    class ChiTietHoaDonDungCu
    {
        string MaHoaDonHang;
        string MaDungCu;
        int SoLuong;

        public ChiTietHoaDonDungCu() {
            this.MaHoaDonHang = "";
            this.MaDungCu = "";
            this.SoLuong = 0;
        }

        public ChiTietHoaDonDungCu(string MaHoaDonHang, string MaDungCu, int SoLuong)
        {
            this.MaHoaDonHang = MaHoaDonHang;
            this.MaDungCu = MaDungCu;
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
