namespace BaiTap03
{
    public partial class frmBai1 : Form
    {
        public frmBai1()
        {
            InitializeComponent();
        }

        private void frmBai1_Load(object sender, EventArgs e)
        {
            NhanVien nv = new("a", DateTime.Now, 2, 3)
            {
                MaNV = 1
            };
            label.Text = string.Format($"{nv}, {nv.TongLuong()}");
        }
    }
}
