namespace BaiTap04
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void b�i01ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new frmBai1();
            form.ShowDialog();
        }

        private void b�i02ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new frmBai2();
            form.ShowDialog();
        }

        private void b�i03ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new frmBai3();
            form.ShowDialog();
        }
    }
}
