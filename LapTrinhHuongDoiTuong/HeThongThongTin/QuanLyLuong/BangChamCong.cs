using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LapTrinhHuongDoiTuong.HeThongThongTin.QuanLyLuong
{
    class BangChamCong
    {
        string MaBangChamCong;
        int SoNgayLam;

        public BangChamCong() {
            this.MaBangChamCong = "";
            this.SoNgayLam = 0;
        }

        public BangChamCong(string MaBangChamCong, int SoNgayLam) {
            this.MaBangChamCong = MaBangChamCong;
            this.SoNgayLam = SoNgayLam;
        }

        public void Tao() { }
        public void Them() { }
        public void Sua() { }
        public void Xoa() { }
        public void TimKiem() { }
        public void ThongKe() { }
    }
}
