namespace BaiTap
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
        public void tsmiBai1_Click(object sender, EventArgs e)
        {
            var form = new frmBai1();
            form.ShowDialog();
        }
        public void tsmiBai2_Click(object sender, EventArgs e)
        {
            var form = new frmBai2();
            form.ShowDialog();
        }
        public void tsmiBai3_Click(object sender, EventArgs e)
        {
            var form = new frmBai3();
            form.ShowDialog();
        }
        private void tsmiBai4_Click(object sender, EventArgs e)
        {
            var form = new frmBai4();
            form.ShowDialog();
        }
        public void Main_Load(object sender, EventArgs e)
        {

        }
    }
}
