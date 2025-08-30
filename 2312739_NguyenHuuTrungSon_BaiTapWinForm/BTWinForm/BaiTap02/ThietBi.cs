using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap02
{
    public class ThietBi
    {
        public int MaThietBi { get; set; }
        public string TenThietBi { get; set; }
        public string  NuocXanXuat { get; set; }
        public int DonGia { get; set; }
        public int SoLuong { get; set; }
        public ThietBi()
        {
            this.TenThietBi = string.Empty;
            this.NuocXanXuat = string.Empty;
            this.DonGia = 0;
            this.SoLuong = 0;
        }
        public ThietBi(string ten, string nxs, int gia, int soluong)
        {
            this.TenThietBi = ten;
            this.NuocXanXuat = nxs;
            this.DonGia = gia;
            this.SoLuong = soluong;
        }
        public int ThanhTien()
        {
            return this.DonGia * this.SoLuong;
        }
        public string HienThi()
        {
            return string.Format("{0}, {1}, {2}, {3}, {4}", this.MaThietBi, this.TenThietBi, this.NuocXanXuat, this.DonGia, this.SoLuong);
        }
    }
}
