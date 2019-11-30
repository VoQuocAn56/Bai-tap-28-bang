using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LapTrinhHuongDoiTuong.HeThongThongTin.QuanLyChiTiet
{
    class ChiTietNguyenLieuMonAn
    {
        string MaNguyenLieu;
        string MaMonAn;
        int SoLuong;

        public ChiTietNguyenLieuMonAn() {
            this.MaNguyenLieu = "";
            this.MaMonAn = "";
            this.SoLuong = 0;
        }

        public ChiTietNguyenLieuMonAn(string MaNguyenLieu, string MaMonAn, int SoLuong)
        {
            this.MaNguyenLieu = MaNguyenLieu;
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
