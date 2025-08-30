namespace BaiTap04
{
    public class SanPham
    {
        public int MaSanPham { get; set; }
        public string TenSanPham { get; set; }
        public string LoaiSanPham { get; set; }
        public DateTime NgaySanXuat { get; set; }
        public SanPham()
        {
            this.TenSanPham = string.Empty;
            this.LoaiSanPham = string.Empty;
            NgaySanXuat = DateTime.Now;
        }
        public SanPham(string ten, string loai, DateTime nsx)
        {
            this.TenSanPham = ten;
            this.LoaiSanPham = loai;
            this.NgaySanXuat = nsx;
        }
        public int NamHetHan()
        {
            return this.NgaySanXuat.Year + 3;
        }
        public string HienThi()
        {
            return string.Format($"{this.MaSanPham}, {this.TenSanPham}, {this.LoaiSanPham}, {this.NgaySanXuat}, {NamHetHan()}");
        }
    }
}
