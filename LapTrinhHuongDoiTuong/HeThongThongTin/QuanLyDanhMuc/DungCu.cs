using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LapTrinhHuongDoiTuong.HeThongThongTin.QuanLyDanhMuc
{
    class DungCu
    {
        string MaDungCu;
        string TenDungCu;
        int GiaMua;
        string DonViTinh;
        int SoLuongCon;

        public DungCu() {
            this.MaDungCu = "";
            this.TenDungCu = "";
            this.GiaMua = 0;
            this.DonViTinh = "";
            this.SoLuongCon = 0;
        }

        public DungCu(string MaDungCu, string TenDungCu, int GiaMua, string DonViTinh, int SoLuongCon) {
            this.MaDungCu = MaDungCu;
            this.TenDungCu = TenDungCu;
            this.GiaMua = GiaMua;
            this.DonViTinh = DonViTinh;
            this.SoLuongCon = SoLuongCon;
        }

        public void ThemDungCu() { }
        public void SuaDungCu() { }
        public void XoaDungCu() { }
        public void TimKiemDungCu() { }
    }
}
