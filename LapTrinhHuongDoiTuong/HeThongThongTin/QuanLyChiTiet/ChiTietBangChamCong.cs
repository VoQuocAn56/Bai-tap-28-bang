using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LapTrinhHuongDoiTuong.HeThongThongTin.QuanLyChiTiet
{
    class ChiTietBangChamCong
    {
        string MaBangChamCong;
        string MaNhanVien;
        DateTime Ngay;

        public ChiTietBangChamCong() {
            this.MaBangChamCong = "";
            this.MaNhanVien = "";
            this.Ngay = DateTime.Now;
        }

        public ChiTietBangChamCong(string MaBangChamCong, string MaNhanVien, DateTime Ngay)
        {
            this.MaBangChamCong = MaBangChamCong;
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
