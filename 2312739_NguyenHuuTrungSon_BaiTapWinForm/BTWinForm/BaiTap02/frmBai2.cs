using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTap02
{
    public partial class frmBai2 : Form
    {
        public frmBai2()
        {
            InitializeComponent();
        }
        private int Calular(int a, int b)
        {
            if (rbtnPlus.Checked) return a + b;
            if (rbtnMinus.Checked) return a - b;
            if (rbtnMulti.Checked) return a * b;
            if (rbtnDiv.Checked)
            {
                if (b != 0) return a / b;
                else MessageBox.Show("Can't divine A (B = 0)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return 0;
        }
        private void btnApply_Click(object sender, EventArgs e)
        {
            string a = txtA.Text.Trim();
            string b = txtB.Text.Trim();
            if (a.All(char.IsDigit) & b.All(char.IsDigit))
                lbResult.Text = Calular(int.Parse(a), int.Parse(b)).ToString();
            else
                MessageBox.Show("Input A or B have non-digit charater.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
