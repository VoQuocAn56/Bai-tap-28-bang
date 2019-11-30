using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LapTrinhHuongDoiTuong.HeThongThongTin.QuanLyDanhMuc
{
    class MonAn
    {
        string MaMonAn;
        int Gia;
        string DonViTinh;
        string LoaiMonAn; //khóa phụ

        public MonAn() {
            this.MaMonAn = "";
            this.Gia = 0;
            this.DonViTinh = "";
            this.LoaiMonAn = "";
        }

        public MonAn(string MaMonAn, int Gia, string DonViTinh, string LoaiMonAn) {
            this.MaMonAn = MaMonAn;
            this.Gia = Gia;
            this.DonViTinh = DonViTinh;
            this.LoaiMonAn = LoaiMonAn;
        }

        public void ThemMonAn() { }
        public void SuaMonAn() { }
        public void XoaMonAn() { }
        public void TimKiemMonAn() { }
    }
}
