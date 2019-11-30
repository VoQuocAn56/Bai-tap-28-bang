using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LapTrinhHuongDoiTuong.HeThongThongTin.QuanLyDanhMuc
{
    class LoaiMonAn
    {
        string MaLoaiMonAn;
        string TenLoaiMonAn;

        public LoaiMonAn() {
            this.MaLoaiMonAn = "";
            this.TenLoaiMonAn = "";
        }

        public LoaiMonAn(string MaLoaiMonAn, string TenLoaiMonAn) {
            this.MaLoaiMonAn = MaLoaiMonAn;
            this.TenLoaiMonAn = TenLoaiMonAn;
        }


        public void ThemLoaiMonAn() { }
        public void SuaLoaiMonAn() { }
        public void XoaLoaiMonAn() { }
        public void TimKiemLoaiMonAn() { }
    }
}
