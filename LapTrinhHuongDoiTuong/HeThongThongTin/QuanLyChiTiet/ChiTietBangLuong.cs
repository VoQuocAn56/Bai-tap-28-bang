using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LapTrinhHuongDoiTuong.HeThongThongTin.QuanLyChiTiet
{
    class ChiTietBangLuong
    {
        string MaBangLuong;
        string MaNhanVien;
        DateTime Ngay;

        public ChiTietBangLuong() {
            this.MaBangLuong = "";
            this.MaNhanVien = "";
            this.Ngay = DateTime.Now;
        }

        public ChiTietBangLuong(string MaBangLuong, string MaNhanVien, DateTime Ngay)
        {
            this.MaBangLuong = MaBangLuong;
            this.MaNhanVien = MaNhanVien;
            this.Ngay = Ngay;
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
