using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LapTrinhHuongDoiTuong.HeThongThongTin.QuanLyChiTiet
{
    class ChiTietCaLamViec
    {
        string MaNhanVien;
        string MaCalamViec;
        DateTime NgayLam;

        public ChiTietCaLamViec() {
            this.MaNhanVien = "";
            this.MaCalamViec = "";
            this.NgayLam = DateTime.Now;
        }

        public ChiTietCaLamViec(string MaNhanVien, string MaCaLamViec, DateTime NgayLam)
        {
            this.MaNhanVien = MaNhanVien;
            this.MaCalamViec = MaCaLamViec;
            this.NgayLam = NgayLam;
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
