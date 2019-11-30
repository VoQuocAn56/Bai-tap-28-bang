using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LapTrinhHuongDoiTuong.HeThongThongTin.QuanLyDanhMuc
{
    class CaLamViec
    {
        string MaCaLamViec;
        string TenCa;
        string TenVietTat;

        public CaLamViec() {
            this.MaCaLamViec = "";
            this.TenCa = "";
            this.TenVietTat = "";
        }

        public CaLamViec(string MaCaLamViec, string TenCa, string TenVietTat)
        {
            this.MaCaLamViec = MaCaLamViec;
            this.TenCa = TenCa;
            this.TenVietTat = TenVietTat;
        }

        public void ThemCaLamViec() { }
        public void SuaCaLamViec() { }
        public void XoaCaLamViec() { }
        public void TimKiemCaLamViec() { }
    }
}
