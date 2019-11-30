using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LapTrinhHuongDoiTuong.HeThongThongTin.QuanLyChiTiet
{
    class ChiTietPhieuXuatKhoNguyenLieu
    {
        string MaPhieuXuatKho;
        string MaNguyenLieu;
        int SoLuong;

        public ChiTietPhieuXuatKhoNguyenLieu() {
            this.MaNguyenLieu = "";
            this.MaPhieuXuatKho = "";
            this.SoLuong = 0;
        }

        public ChiTietPhieuXuatKhoNguyenLieu(string MaPhieuXuatKho, string MaNguyenLieu, int SoLuong)
        {
            this.MaNguyenLieu = MaPhieuXuatKho;
            this.MaPhieuXuatKho = MaNguyenLieu;
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
