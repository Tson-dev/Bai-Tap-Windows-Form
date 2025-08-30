namespace BaiTap03
{
    public partial class frmBai2: Form
    {
        public frmBai2()
        {
            InitializeComponent();
        }
        private static int Sum(int n)
        {
            int sum = 0, i = 0;
            while(n > 0)
            {
                i++;
                sum += i;
                n--;
            }
            return sum;
        }
        public static long Fractorial(int n)
        {
            if (n == 0) return 1;
            long prod = 1;
            int i = 0;
            while(n > 0)
            {
                i++;
                prod *= i;
                n--;
            }
            return prod;
        }
        public void btnApply_Click(object sender, EventArgs e)
        {
            string str = txtN.Text.Trim();
            if (str == null)
            {
                MessageBox.Show("Please enter a number at N.", "Nofication", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (str.All(char.IsDigit))
            {
                int n = int.Parse(str);
                if (rdSum.Checked)
                {
                    if (n < 1) MessageBox.Show("N must gearter than zero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else lbResult.Text = Sum(n).ToString();
                }
                if (rdFractor.Checked)
                    lbResult.Text = Fractorial(n).ToString();
            }
            else MessageBox.Show("N contact non-digit charater", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
