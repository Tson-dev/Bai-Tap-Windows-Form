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
    public partial class frmBai4 : Form
    {
        public frmBai4()
        {
            InitializeComponent();
        }

        private void frmBai4_Load(object sender, EventArgs e)
        {
            Random random = new Random();
            for (int i = 0; i < 10; i++)
                lbxNumber.Items.Add(random.Next(-100, 100));
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            string str = txtNumber.Text;
            if (string.IsNullOrEmpty(str))
                MessageBox.Show("Pls enter a number.", "Nofitication", 0, MessageBoxIcon.Information);
            else
            {
                if (int.TryParse(str, out _))
                {
                    for (int i = 0; i < lbxNumber.Items.Count - 1; i++)
                    {
                        if (lbxNumber.Items[i].ToString() == str)
                        {
                            lbResult.Text = "Founded.";
                            return;
                        }

                    }
                    lbResult.Text = "Not found.";
                }
                else MessageBox.Show("You didn\'t enter a number.", "Error", 0, MessageBoxIcon.Error);
            }
        }
    }
}
