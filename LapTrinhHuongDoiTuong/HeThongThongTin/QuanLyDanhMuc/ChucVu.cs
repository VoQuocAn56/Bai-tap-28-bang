using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LapTrinhHuongDoiTuong.HeThongThongTin.QuanLyDanhMuc
{
    class ChucVu
    {
        string MaChucVu;
        string TenChucVu;
        int MucLuong;

        public ChucVu() {
            this.MaChucVu = "";
            this.TenChucVu = "";
            this.MucLuong = 0;
        }

        public ChucVu(string MaChucVu, string TenChucVu, int MucLuong)
        {
            this.MaChucVu = MaChucVu;
            this.TenChucVu = TenChucVu;
            this.MucLuong = MucLuong;
        }

        public void ThemChucVu() { }
        public void SuaChucVu() { }
        public void XoaChucVu() { }
        public void TimKiemChucVu() { }
    }
}
