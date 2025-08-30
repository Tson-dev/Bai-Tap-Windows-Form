namespace BaiTap
{
    partial class frmBai2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            splitContainer1 = new SplitContainer();
            lbGoods = new Label();
            btnAdd = new Button();
            lbxGoods = new ListBox();
            lbCart = new Label();
            lbTotal = new Label();
            lbTotalTitle = new Label();
            btnApply = new Button();
            btnRemove = new Button();
            lbxCart = new ListBox();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(lbGoods);
            splitContainer1.Panel1.Controls.Add(btnAdd);
            splitContainer1.Panel1.Controls.Add(lbxGoods);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(lbCart);
            splitContainer1.Panel2.Controls.Add(lbTotal);
            splitContainer1.Panel2.Controls.Add(lbxCart);
            splitContainer1.Panel2.Controls.Add(lbTotalTitle);
            splitContainer1.Panel2.Controls.Add(btnApply);
            splitContainer1.Panel2.Controls.Add(btnRemove);
            splitContainer1.Size = new Size(470, 264);
            splitContainer1.SplitterDistance = 228;
            splitContainer1.TabIndex = 0;
            // 
            // lbGoods
            // 
            lbGoods.AutoSize = true;
            lbGoods.Location = new Point(23, 17);
            lbGoods.Name = "lbGoods";
            lbGoods.Size = new Size(41, 15);
            lbGoods.TabIndex = 6;
            lbGoods.Text = "Goods";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(108, 192);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(88, 23);
            btnAdd.TabIndex = 5;
            btnAdd.Text = "Add to Cart";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // lbxGoods
            // 
            lbxGoods.FormattingEnabled = true;
            lbxGoods.Items.AddRange(new object[] { "Mouse", "Key Board", "Printer", "USB Kingmax" });
            lbxGoods.Location = new Point(23, 35);
            lbxGoods.Name = "lbxGoods";
            lbxGoods.Size = new Size(173, 139);
            lbxGoods.TabIndex = 4;
            // 
            // lbCart
            // 
            lbCart.AutoSize = true;
            lbCart.Location = new Point(28, 17);
            lbCart.Name = "lbCart";
            lbCart.Size = new Size(29, 15);
            lbCart.TabIndex = 7;
            lbCart.Text = "Cart";
            // 
            // lbTotal
            // 
            lbTotal.AutoSize = true;
            lbTotal.BackColor = SystemColors.Control;
            lbTotal.ForeColor = Color.DodgerBlue;
            lbTotal.Location = new Point(124, 231);
            lbTotal.Name = "lbTotal";
            lbTotal.Size = new Size(40, 15);
            lbTotal.TabIndex = 8;
            lbTotal.Text = "0 VND";
            // 
            // lbTotalTitle
            // 
            lbTotalTitle.AutoSize = true;
            lbTotalTitle.Location = new Point(65, 231);
            lbTotalTitle.Name = "lbTotalTitle";
            lbTotalTitle.Size = new Size(36, 15);
            lbTotalTitle.TabIndex = 9;
            lbTotalTitle.Text = "Total:";
            // 
            // btnApply
            // 
            btnApply.Location = new Point(124, 192);
            btnApply.Name = "btnApply";
            btnApply.Size = new Size(75, 23);
            btnApply.TabIndex = 6;
            btnApply.Text = "Apply";
            btnApply.UseVisualStyleBackColor = true;
            btnApply.Click += btnApply_Click;
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(28, 192);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(73, 23);
            btnRemove.TabIndex = 5;
            btnRemove.Text = "Remove";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // lbxCart
            // 
            lbxCart.FormattingEnabled = true;
            lbxCart.Location = new Point(28, 35);
            lbxCart.Name = "lbxCart";
            lbxCart.Size = new Size(173, 139);
            lbxCart.TabIndex = 4;
            // 
            // frmBai2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(470, 264);
            Controls.Add(splitContainer1);
            Name = "frmBai2";
            Text = "Shop";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private Label lbCart;
        private Label lbTotal;
        private Label lbTotalTitle;
        private Button btnApply;
        private Button btnRemove;
        private Label lbGoods;
        private Button btnAdd;
        private ListBox lbxGoods;
        private ListBox lbxCart;
    }
}