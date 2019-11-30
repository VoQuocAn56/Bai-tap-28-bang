using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LapTrinhHuongDoiTuong.HeThongThongTin.QuanLyDanhMuc
{
    class LoaiNguyenLieu
    {
        string MaLoaiNguyenLieu;
        string TenLoaiNguyenLieu;

        public LoaiNguyenLieu() {
            this.MaLoaiNguyenLieu = "";
            this.TenLoaiNguyenLieu = "";
        }

        public LoaiNguyenLieu(string MaLoaiNguyenLieu, string TenLoaiNguyenLieu) {
            this.MaLoaiNguyenLieu = MaLoaiNguyenLieu;
            this.TenLoaiNguyenLieu = TenLoaiNguyenLieu;
        }


        public void ThemLoaiNguyenLieu() { }
        public void SuaLoaiNguyenLieu() { }
        public void XoaLoaiNguyenLieu() { }
        public void TimKiemLoaiNguyenLieu() { }
    }
}
