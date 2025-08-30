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
    public partial class frmBai1 : Form
    {
        public frmBai1()
        {
            InitializeComponent();
        }

        private void frmBai1_Load(object sender, EventArgs e)
        {
            ThietBi temp = new ThietBi("May Lanh", "Chị Na", 3500000, 97);
            temp.MaThietBi = 1;
            lbThietBi.Text = temp.HienThi() + ", " + temp.ThanhTien();
        }
    }
}
