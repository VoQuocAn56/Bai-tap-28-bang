using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LapTrinhHuongDoiTuong.HeThongThongTin.QuanLyDanhMuc
{
    class Ban
    {
        string MaBan;
        string LoaiBan;
        string TinhTrang;
        //khóa phụ
        string MaHoaDon;
        string MaPhieuDatMon;

        public Ban() {
            this.MaBan = "";
            this.LoaiBan = "";
            this.TinhTrang = "";
            this.MaHoaDon = "";
            this.MaPhieuDatMon = "";
        }

        public Ban(string MaBan, string LoaiBan, string TinhTrang, string MaHoaDon, string MaPhieuDatMon)
        {
            this.MaBan = MaBan;
            this.LoaiBan = LoaiBan;
            this.TinhTrang = TinhTrang;
            this.MaHoaDon = MaHoaDon;
            this.MaPhieuDatMon = MaPhieuDatMon;
        }

        public void ThemBan() { }
        public void SuaBan() { }
        public void XoaBan() { }
        public void TimKiemBan() { }
    }
}
