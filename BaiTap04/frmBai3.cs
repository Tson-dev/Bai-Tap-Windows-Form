namespace BaiTap04
{
    public partial class frmBai3 : Form
    {
        public frmBai3()
        {
            InitializeComponent();
        }
        private void cbMale_CheckedChanged(object sender, EventArgs e)
        {
            if (cbMale.Checked)
                cbMale.Text = "Male";
            else cbMale.Text = "Male?";
        }
        private void btnGCD_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtA.Text.Trim(), out int a) && int.TryParse(txtB.Text.Trim(), out int b))
            {
                int result = Func.GCD(a, b);
                switch (result)
                {
                    case -1:
                        MessageBox.Show("A or B is negative.", "Warning", 0, MessageBoxIcon.Warning);
                        break;
                    case 0:
                        MessageBox.Show("A or B is zero.", "Warning", 0, MessageBoxIcon.Warning);
                        break;
                    default:
                        lbResult.Text = result.ToString();
                        break;
                }
            }
            else MessageBox.Show("Can\'t convert to number.", "Error", 0, MessageBoxIcon.Error);
        }

        private void btnGreeting_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            if (string.IsNullOrEmpty(name))
                MessageBox.Show("Enter a name.", "Notification", 0, MessageBoxIcon.Information);
            else
                Func.Greeting(name,cbMale.Checked);
        }
    }
}
