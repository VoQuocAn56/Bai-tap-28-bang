using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LapTrinhHuongDoiTuong.HeThongThongTin.QuanLyDanhMuc
{
    class NhaCungCap
    {
        string MaNhaCungCap;
        string TenNhaCungCap;
        string DiaChi;
        string SoDienThoai;
        string MaThue;
        int fax;

        public NhaCungCap() {
            this.MaNhaCungCap = "";
            this.TenNhaCungCap = "";
            this.DiaChi = "";
            this.SoDienThoai = "";
            this.MaThue = "";
            this.fax = 0;
        }

        public NhaCungCap(string MaNhaCungCap, string TenNhaCungCap, string DiaChi, string SoDienThoai, string MaThue, int fax)
        {
            this.MaNhaCungCap = MaNhaCungCap;
            this.TenNhaCungCap = TenNhaCungCap;
            this.DiaChi = DiaChi;
            this.SoDienThoai = SoDienThoai;
            this.MaThue = MaThue;
            this.fax = fax;
        }

        public void ThemNhaCungCap() { }
        public void SuaNhaCungCap() { }
        public void XoaNhaCungCap() { }
        public void TimKiemNhaCungCap() { }
    }
}
