using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LapTrinhHuongDoiTuong.HeThongThongTin.QuanLyChiTiet
{
    class ChiTietPhieuNhapKhoNguyenLieu
    {
        string MaPhieuNhapKho;
        string MaNguyenLieu;
        int SoLuong;

        public ChiTietPhieuNhapKhoNguyenLieu() {
            this.MaPhieuNhapKho = "";
            this.MaNguyenLieu = "";
            this.SoLuong = 0;
        }

        public ChiTietPhieuNhapKhoNguyenLieu(string MaPhieuNhapKho, string MaNguyenLieu, int SoLuong)
        {
            this.MaPhieuNhapKho = MaPhieuNhapKho;
            this.MaNguyenLieu = MaNguyenLieu;
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
