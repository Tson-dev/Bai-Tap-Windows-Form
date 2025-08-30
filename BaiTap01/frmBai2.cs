using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm
{
    public partial class frmBai2 : Form
    {
        public frmBai2()
        {
            InitializeComponent();
        }

        private void cbxTenHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbxTenHang.SelectedIndex)
            {
                case 0:
                    txtPrice.Text = "200000";
                    break;
                case 1:
                    txtPrice.Text = "100000";
                    break;
                case 2:
                    txtPrice.Text = "4500000";
                    break;
                case 3:
                    txtPrice.Text = "6000000";
                    break;
                default:
                    break;
            }
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            string str = (int.Parse(txtPrice.Text) * int.Parse(txtQuantity.Text) * (rbtnTransfer.Checked ? .95 : 1)).ToString();
            for (int i = str.Length - 3; i > 0; i -= 3)
                str = str.Insert(i, ".");
            lbTotal.Text = str;
        }
    }
}
