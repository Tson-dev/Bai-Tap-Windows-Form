using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm
{
    public partial class frmBai3 : Form
    {
        public frmBai3()
        {
            InitializeComponent();
        }

        private void btnAPlusB_Click(object sender, EventArgs e)
        {
            //Chưa tính trường hợp txtA hoặc txtB đang chứa dữ liệu khác chữ số
            ToanHoc.Plus(int.Parse(txtA.Text), int.Parse(txtB.Text), out int s);
            lbResult.Text = s.ToString();
            Reset();
        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            //Chưa tính trường hợp txtN đang chứa dữ liệu khác chữ số
            lbResult.Text = ToanHoc.Sum(int.Parse(txtN.Text)).ToString();
            Reset();
        }
        private void Reset()
        {
            txtA.Text = string.Empty;
            txtB.Text = string.Empty;
            txtN.Text = string.Empty;
        }
    }
}
