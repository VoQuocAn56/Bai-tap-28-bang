using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LapTrinhHuongDoiTuong.HeThongThongTin.QuanLyLuong
{
    class BangLuong
    {
        string MaBangLuong;
        int ThangTraLuong;
        int MucLuong;
        int TongNgayLam;
        double Thuong;
        double Phat;

        public BangLuong() {
            this.MaBangLuong = "";
            this.ThangTraLuong = 0;
            this.MucLuong = 0;
            this.TongNgayLam = 0;
            this.Thuong = 0;
            this.Phat = 0;
        }

        public BangLuong(string MaBangLuong, int ThangTraLuong, int MucLuong, int TongNgayLam, double Thuong, double Phat)
        {
            this.MaBangLuong = MaBangLuong;
            this.ThangTraLuong = ThangTraLuong;
            this.MucLuong = MucLuong;
            this.TongNgayLam = TongNgayLam;
            this.Thuong = Thuong;
            this.Phat = Phat;
        }

        public void Tao() { }
        public void Them() { }
        public void Sua() { }
        public void Xoa() { }
        public void TimKiem() { }
        public void ThongKe() { }
    }
}
