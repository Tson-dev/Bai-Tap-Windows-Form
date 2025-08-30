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
    public partial class frmBai1 : Form
    {
        public frmBai1()
        {
            InitializeComponent();
        }

        private void frmBai1_Load(object sender, EventArgs e)
        {
            HangHoa temp = new HangHoa();
            temp.MaHang = 1;
            temp.TenHang = "a";
            temp.DVT = "b";
            temp.SoLuong = 2;
            temp.DonGia = 3.333f;

            lbThongTin.Text = temp.HienThi();
        }
    }
}
