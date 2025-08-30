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
    public partial class frmBai3: Form
    {
        public frmBai3()
        {
            InitializeComponent();
        }
        private void btnMerge_Click(object sender, EventArgs e)
        {
            Func.ConnectString(txtLeft.Text, txtRight.Text, out string temp);
            lbResult.Text = temp;
        }
        private void btnFactor_Click(object sender, EventArgs e)
        {
            string str = txtN.Text.Trim();
            if (str.All(char.IsDigit))
                lbResult.Text = Func.Factorial(int.Parse(str)).ToString();
            else
                MessageBox.Show("The input N have non-digit charater.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
