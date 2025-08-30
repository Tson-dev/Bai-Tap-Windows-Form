namespace BaiTap04
{
    public partial class frmBai1: Form
    {
        public frmBai1()
        {
            InitializeComponent();
        }
        public void frmBai1_Load(object sender, EventArgs e)
        {
            SanPham sp = new("a", "b", DateTime.Now)
            {
                MaSanPham = 1
            };
            lbText.Text = sp.HienThi();
        }
    }
}
