namespace WinForm
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
            lbName = new Label();
            lbPrice = new Label();
            lbQuantity = new Label();
            txtQuantity = new TextBox();
            txtPrice = new TextBox();
            cbxTenHang = new ComboBox();
            gbxPayment = new GroupBox();
            rbtnCash = new RadioButton();
            rbtnTransfer = new RadioButton();
            lbTotalTitle = new Label();
            lbTotal = new Label();
            btnApply = new Button();
            gbxPayment.SuspendLayout();
            SuspendLayout();
            // 
            // lbName
            // 
            lbName.AutoSize = true;
            lbName.Location = new Point(36, 26);
            lbName.Name = "lbName";
            lbName.Size = new Size(39, 15);
            lbName.TabIndex = 0;
            lbName.Text = "Name";
            // 
            // lbPrice
            // 
            lbPrice.AutoSize = true;
            lbPrice.Location = new Point(36, 55);
            lbPrice.Name = "lbPrice";
            lbPrice.Size = new Size(33, 15);
            lbPrice.TabIndex = 0;
            lbPrice.Text = "Price";
            // 
            // lbQuantity
            // 
            lbQuantity.AutoSize = true;
            lbQuantity.Location = new Point(34, 88);
            lbQuantity.Name = "lbQuantity";
            lbQuantity.Size = new Size(53, 15);
            lbQuantity.TabIndex = 0;
            lbQuantity.Text = "Quantity";
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(93, 80);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(121, 23);
            txtQuantity.TabIndex = 1;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(93, 47);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(121, 23);
            txtPrice.TabIndex = 2;
            // 
            // cbxTenHang
            // 
            cbxTenHang.FormattingEnabled = true;
            cbxTenHang.Items.AddRange(new object[] { "Key Board", "Ratatouille", "CPU", "VGA" });
            cbxTenHang.Location = new Point(93, 18);
            cbxTenHang.Name = "cbxTenHang";
            cbxTenHang.Size = new Size(121, 23);
            cbxTenHang.TabIndex = 3;
            cbxTenHang.SelectedIndexChanged += cbxTenHang_SelectedIndexChanged;
            // 
            // gbxPayment
            // 
            gbxPayment.Controls.Add(rbtnCash);
            gbxPayment.Controls.Add(rbtnTransfer);
            gbxPayment.Location = new Point(59, 128);
            gbxPayment.Name = "gbxPayment";
            gbxPayment.Size = new Size(155, 100);
            gbxPayment.TabIndex = 4;
            gbxPayment.TabStop = false;
            gbxPayment.Text = "Payment method";
            // 
            // rbtnCash
            // 
            rbtnCash.AutoSize = true;
            rbtnCash.Location = new Point(10, 56);
            rbtnCash.Name = "rbtnCash";
            rbtnCash.Size = new Size(51, 19);
            rbtnCash.TabIndex = 1;
            rbtnCash.TabStop = true;
            rbtnCash.Text = "Cash";
            rbtnCash.UseVisualStyleBackColor = true;
            // 
            // rbtnTransfer
            // 
            rbtnTransfer.AutoSize = true;
            rbtnTransfer.Location = new Point(10, 31);
            rbtnTransfer.Name = "rbtnTransfer";
            rbtnTransfer.Size = new Size(67, 19);
            rbtnTransfer.TabIndex = 0;
            rbtnTransfer.TabStop = true;
            rbtnTransfer.Text = "Transfer";
            rbtnTransfer.UseVisualStyleBackColor = true;
            // 
            // lbTotalTitle
            // 
            lbTotalTitle.AutoSize = true;
            lbTotalTitle.Location = new Point(12, 315);
            lbTotalTitle.Name = "lbTotalTitle";
            lbTotalTitle.Size = new Size(36, 15);
            lbTotalTitle.TabIndex = 5;
            lbTotalTitle.Text = "Total:";
            // 
            // lbTotal
            // 
            lbTotal.AutoSize = true;
            lbTotal.Location = new Point(54, 315);
            lbTotal.Name = "lbTotal";
            lbTotal.Size = new Size(13, 15);
            lbTotal.TabIndex = 6;
            lbTotal.Text = "0";
            // 
            // btnApply
            // 
            btnApply.Location = new Point(139, 243);
            btnApply.Name = "btnApply";
            btnApply.Size = new Size(75, 23);
            btnApply.TabIndex = 7;
            btnApply.Text = "Apply";
            btnApply.UseVisualStyleBackColor = true;
            btnApply.Click += btnApply_Click;
            // 
            // frmBai2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(285, 339);
            Controls.Add(btnApply);
            Controls.Add(lbTotal);
            Controls.Add(lbTotalTitle);
            Controls.Add(gbxPayment);
            Controls.Add(cbxTenHang);
            Controls.Add(txtPrice);
            Controls.Add(txtQuantity);
            Controls.Add(lbQuantity);
            Controls.Add(lbPrice);
            Controls.Add(lbName);
            Name = "frmBai2";
            Text = "Bài 02";
            gbxPayment.ResumeLayout(false);
            gbxPayment.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbName;
        private Label lbPrice;
        private Label lbQuantity;
        private TextBox txtQuantity;
        private TextBox txtPrice;
        private ComboBox cbxTenHang;
        private GroupBox gbxPayment;
        private RadioButton rbtnCash;
        private RadioButton rbtnTransfer;
        private Label lbTotalTitle;
        private Label lbTotal;
        private Button btnApply;
    }
}