using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LapTrinhHuongDoiTuong.HeThongThongTin.QuanLyDanhMuc
{
    class NguyenLieu
    {
        string MaNguyenLieu;
        string TenNguyenLieu;
        int GiaMua;
        string DonViTinh;
        int SoLuongCon;

        public NguyenLieu() {
            this.MaNguyenLieu = "";
            this.TenNguyenLieu = "";
            this.GiaMua = 0;
            this.DonViTinh = "";
            this.SoLuongCon = 0;
        }

        public NguyenLieu(string MaNguyenLieu, string TenNguyenLieu, int GiaMua, string DonViTinh, int SoLuongCon)
        {
            this.MaNguyenLieu = MaNguyenLieu;
            this.TenNguyenLieu = TenNguyenLieu;
            this.GiaMua = GiaMua;
            this.DonViTinh = DonViTinh;
            this.SoLuongCon = SoLuongCon;
        }

        public void ThemNguyenLieu() { }
        public void SuaNguyenLieu() { }
        public void XoaNguyenLieu() { }
        public void TimKiemNguyenLieu() { }
    }
}
