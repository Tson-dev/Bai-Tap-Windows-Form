namespace BaiTap03
{
    public class NhanVien
    {
        public int MaNV { get; set; }
        public string HoTen { get; set; }
        public DateTime NgaySinh { get; set; }
        public int HeSoLuong { get; set; }
        public int HeSoPhuCap { get; set; }
        public NhanVien()
        {
            this.HoTen = string.Empty;
            this.NgaySinh = DateTime.Now;
            this.HeSoLuong = 0;
            this.HeSoPhuCap = 0;
        }
        public NhanVien(string hoten, DateTime ns, int hsl, int hspc)
        {
            this.HoTen = hoten;
            this.NgaySinh = ns;
            this.HeSoLuong = hsl;
            this.HeSoPhuCap = hspc;
        }
        public int TongLuong()
        {
            return (this.HeSoLuong + this.HeSoPhuCap) * 1150000;
        }
        public string HienThi()
        {
            return string.Format("{0}, {1}, {2}, {3}, {4}, {5}", this.MaNV, this.HoTen, this.NgaySinh.ToShortDateString(), this.HeSoLuong, this.HeSoPhuCap);
        }
    }
}
