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
    public partial class frmBai2 : Form
    {
        public frmBai2()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (lbxGoods.SelectedItem != null)
                lbxCart.Items.Add(lbxGoods.SelectedItem);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if(lbxCart.SelectedItem != null)
                lbxCart.Items.Remove(lbxCart.SelectedItem);
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            int total = 0;
            foreach(var item in lbxCart.Items)
            {
                switch (item)
                {
                    case "Mouse":
                        total += 70000;
                        break;
                    case "Key Board":
                        total += 250000;
                        break;
                    case "Printer":
                        total += 1250000;
                        break;
                    case "USB Kingmax":
                        total += 200000;
                        break;
                    default:
                        break;
                }
            }
            string str = total.ToString();
            for (int i = str.Length - 3; i > 0; i -= 3)
                str = str.Insert(i, ".");
            lbTotal.Text = string.Format($"{str} VND");
        }
    }
}
