namespace BaiTap04
{
    public partial class frmBai2 : Form
    {
        public frmBai2()
        {
            InitializeComponent();
        }
        private void btnCheck_Click(object sender, EventArgs e)
        {
            string str1 = txtTheory.Text.Trim();
            string str2 = txtPratice.Text.Trim();
            if (float.TryParse(str1, out float a) && float.TryParse(str2, out float b))
            {
                if (a > 10 || b > 10)
                    MessageBox.Show("The score can\'t be greater than 10.", "Warning", 0, MessageBoxIcon.Warning);
                else if (a < 0 || b < 0)
                    MessageBox.Show("The score can\'t be negative.", "Warning", 0, MessageBoxIcon.Warning);
                else if (a < 5 || b < 5)
                    lbResult.Text = "Bad.";
                else
                {
                    float m = (a + b) / 2;
                    if (m >= 9)
                        lbResult.Text = "Excellent.";
                    else if (m >= 8)
                        lbResult.Text = "Good.";
                    else if (m >= 7)
                        lbResult.Text = "Great.";
                    else lbResult.Text = "Not Bad.";
                }
            }
            else MessageBox.Show("Can\'t convert to number.", "Error", 0, MessageBoxIcon.Error);
        }
    }
}
