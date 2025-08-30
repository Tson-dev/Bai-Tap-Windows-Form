using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTap
{
    public partial class frmBai1 : Form
    {
        public frmBai1()
        {
            InitializeComponent();
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            string str = txtQuantity.Text.Trim();
            if (string.IsNullOrEmpty(str))
                MessageBox.Show("Please enter a number.", "Nofitication", 0, MessageBoxIcon.Information);
            else if (int.TryParse(str, out int quantity))
                lbTotal.Text = string.Format($"{quantity * int.Parse(txtPrice.Text.Replace(".",""))} $");
            else MessageBox.Show("Can't convert quantity to number.", "Error", 0, MessageBoxIcon.Error);
        }

        private void rbtBlue_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnBlue.Checked)
                txtPrice.Text = "22.000";
        }

        private void rbtnRed_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnRed.Checked)
                txtPrice.Text = "21.000";
        }

        private void rbtnWhite_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnWhite.Checked)
                txtPrice.Text = "20.000";
        }

        private void frmBai1_Load(object sender, EventArgs e)
        {
            rbtnBlue.Checked = true;
        }
    }
}
