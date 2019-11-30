using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LapTrinhHuongDoiTuong.HeThongThongTin.QuanLyChiTiet
{
    class ChiTietPhieuNhapKhoDungCu
    {
        string MaPhieuNhapKho;
        string MaDungCu;
        int SoLuong;

        public ChiTietPhieuNhapKhoDungCu() {
            this.MaPhieuNhapKho = "";
            this.MaDungCu = "";
            this.SoLuong = 0;
        }

        public ChiTietPhieuNhapKhoDungCu(string MaPhieuNhapKho, string MaDungCu, int SoLuong)
        {
            this.MaPhieuNhapKho = MaPhieuNhapKho;
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
