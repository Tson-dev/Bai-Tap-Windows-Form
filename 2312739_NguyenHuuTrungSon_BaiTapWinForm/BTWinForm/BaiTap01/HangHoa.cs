using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForm
{
    public class HangHoa
    {
        public int MaHang {  get; set; }
        public string TenHang { get; set; }
        public string DVT { get; set; }
        public uint SoLuong {  get; set; }
        public float DonGia {  get; set; }

        public HangHoa()
        {
            TenHang = string.Empty; 
            DVT = string.Empty;
            SoLuong = 0;
            DonGia = 0;
        }
        public string HienThi()
        {
            return string.Format("{0}, {1}, {2}, {3}, {4}", MaHang, TenHang, DVT, SoLuong, DonGia);
        }
    }
}
