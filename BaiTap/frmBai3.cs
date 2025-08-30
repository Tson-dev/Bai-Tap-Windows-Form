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
    public partial class frmBai3 : Form
    {
        List<string> list = new List<string>();
        public frmBai3()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string str1 = txtWord.Text;
            string str2 = txtMeant.Text;
            if (string.IsNullOrEmpty(str1))
                MessageBox.Show("Pls Enter a Word", "Nofitication", 0, MessageBoxIcon.Information);
            else
            {
                if (string.IsNullOrEmpty(str2))
                    MessageBox.Show("Pls Enter a Meaning", "Nofitication", 0, MessageBoxIcon.Information);
                else
                {
                    lbxWord.Items.Add(str1);
                    list.Add(str2);

                    txtWord.Focus();
                    txtWord.Text = string.Empty;
                    txtMeant.Text = string.Empty;
                    lbxWord.SelectedIndex = lbxWord.Items.Count - 1;
                    txtMEANNIG.Text = list.Last();
                }
            }
        }

        private void lbxWord_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtMEANNIG.Text = list[lbxWord.SelectedIndex];
        }
    }
}
