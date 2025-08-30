namespace BaiTap03
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
        public void btnBai1_Click(object sender, EventArgs e)
        {
            var form = new frmBai1();
            form.ShowDialog();
        }
        public void btnBai2_Click(object sender, EventArgs e)
        {
            var form = new frmBai2();
            form.ShowDialog();
        }
        public void btnBai3_Click(object sender, EventArgs e)
        {
            var form = new frmBai3();
            form.ShowDialog();
        }
    }
}
