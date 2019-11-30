using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LapTrinhHuongDoiTuong.HeThongThongTin.QuanLyBanHang
{
    class HoaDon
    {
        string MaHoaDon;
        DateTime GioVao;
        DateTime GioRa;
        int SoLuong;
        double GiamGia;

        public HoaDon() {
            this.MaHoaDon = "";
            this.GioRa = DateTime.Now;
            this.GioVao = DateTime.Now;
            this.SoLuong = 0;
            this.GiamGia = 0;
        }

        public HoaDon(string MaHoaDon, DateTime GioVao, DateTime GioRa, int SoLuong, double GiamGias)
        {
            this.MaHoaDon = "";
            this.GioRa = DateTime.Now;
            this.GioVao = DateTime.Now;
            this.SoLuong = 0;
            this.GiamGia = 0;
        }

        public void Tao() { }
        public void Them() { }
        public void Sua() { }
        public void Xoa() { }
        public void TimKiem() { }
        public void ThongKe() { }
    }
}
