namespace BaiTap03
{
    public partial class frmBai3 : Form
    {
        public frmBai3()
        {
            InitializeComponent();
        }

        private void btnCut_Click(object sender, EventArgs e)
        {
            string str = txtStr.Text.Trim();
            if (str == string.Empty)
            {
                MessageBox.Show("Enter a string", "Note", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtStr.Text = string.Empty;
            }
            else
            {
                int pos;
                if (rdFirst.Checked) pos = -1;
                else if (rdMid.Checked) pos = 0;
                else pos = 1;

                Func.CutString(str, out string left, out string right, pos);
                lbResultStr1.Text = left != string.Empty ? left.Trim() : "n/a";
                lbResultStr2.Text = right != string.Empty ? right.Trim() : "n/a";
            }
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtN1.Text.Trim(), out int n1) && int.TryParse(txtN2.Text.Trim(), out int n2))
                lbResult.Text = Func.CheckClose(n1, n2) ? "True" : "False";
            else MessageBox.Show("N1 or N2 can\'t convert to number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
