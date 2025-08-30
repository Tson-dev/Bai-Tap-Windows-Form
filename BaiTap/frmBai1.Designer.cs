namespace BaiTap
{
    partial class frmBai1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBai1));
            gbxColor = new GroupBox();
            rbtnWhite = new RadioButton();
            rbtnRed = new RadioButton();
            rbtnBlue = new RadioButton();
            txtPrice = new TextBox();
            txtQuantity = new TextBox();
            lbPrice = new Label();
            lbDollar = new Label();
            lbQuantity = new Label();
            lbTotal = new Label();
            lbTotalTitle = new Label();
            btnApply = new Button();
            pbxCar = new PictureBox();
            gbxColor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbxCar).BeginInit();
            SuspendLayout();
            // 
            // gbxColor
            // 
            gbxColor.Controls.Add(rbtnWhite);
            gbxColor.Controls.Add(rbtnRed);
            gbxColor.Controls.Add(rbtnBlue);
            gbxColor.Location = new Point(317, 16);
            gbxColor.Name = "gbxColor";
            gbxColor.Size = new Size(142, 108);
            gbxColor.TabIndex = 0;
            gbxColor.TabStop = false;
            gbxColor.Text = "Select a color";
            // 
            // rbtnWhite
            // 
            rbtnWhite.AutoSize = true;
            rbtnWhite.Location = new Point(13, 76);
            rbtnWhite.Name = "rbtnWhite";
            rbtnWhite.Size = new Size(56, 19);
            rbtnWhite.TabIndex = 0;
            rbtnWhite.Text = "White";
            rbtnWhite.UseVisualStyleBackColor = true;
            rbtnWhite.CheckedChanged += rbtnWhite_CheckedChanged;
            // 
            // rbtnRed
            // 
            rbtnRed.AutoSize = true;
            rbtnRed.Location = new Point(13, 51);
            rbtnRed.Name = "rbtnRed";
            rbtnRed.Size = new Size(45, 19);
            rbtnRed.TabIndex = 0;
            rbtnRed.Text = "Red";
            rbtnRed.UseVisualStyleBackColor = true;
            rbtnRed.CheckedChanged += rbtnRed_CheckedChanged;
            // 
            // rbtnBlue
            // 
            rbtnBlue.AutoSize = true;
            rbtnBlue.Location = new Point(13, 26);
            rbtnBlue.Name = "rbtnBlue";
            rbtnBlue.Size = new Size(48, 19);
            rbtnBlue.TabIndex = 0;
            rbtnBlue.Text = "Blue";
            rbtnBlue.UseVisualStyleBackColor = true;
            rbtnBlue.CheckedChanged += rbtBlue_CheckedChanged;
            // 
            // txtPrice
            // 
            txtPrice.Enabled = false;
            txtPrice.Location = new Point(359, 130);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(100, 23);
            txtPrice.TabIndex = 1;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(359, 159);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(36, 23);
            txtQuantity.TabIndex = 1;
            // 
            // lbPrice
            // 
            lbPrice.AutoSize = true;
            lbPrice.Location = new Point(317, 133);
            lbPrice.Name = "lbPrice";
            lbPrice.Size = new Size(36, 15);
            lbPrice.TabIndex = 2;
            lbPrice.Text = "Price:";
            // 
            // lbDollar
            // 
            lbDollar.AutoSize = true;
            lbDollar.Location = new Point(465, 133);
            lbDollar.Name = "lbDollar";
            lbDollar.Size = new Size(13, 15);
            lbDollar.TabIndex = 2;
            lbDollar.Text = "$";
            // 
            // lbQuantity
            // 
            lbQuantity.AutoSize = true;
            lbQuantity.Location = new Point(297, 167);
            lbQuantity.Name = "lbQuantity";
            lbQuantity.Size = new Size(56, 15);
            lbQuantity.TabIndex = 2;
            lbQuantity.Text = "Quantity:";
            // 
            // lbTotal
            // 
            lbTotal.AutoSize = true;
            lbTotal.Location = new Point(362, 248);
            lbTotal.Name = "lbTotal";
            lbTotal.Size = new Size(22, 15);
            lbTotal.TabIndex = 2;
            lbTotal.Text = "0 $";
            // 
            // lbTotalTitle
            // 
            lbTotalTitle.AutoSize = true;
            lbTotalTitle.Location = new Point(317, 248);
            lbTotalTitle.Name = "lbTotalTitle";
            lbTotalTitle.Size = new Size(36, 15);
            lbTotalTitle.TabIndex = 2;
            lbTotalTitle.Text = "Total:";
            // 
            // btnApply
            // 
            btnApply.Location = new Point(359, 197);
            btnApply.Name = "btnApply";
            btnApply.Size = new Size(75, 23);
            btnApply.TabIndex = 3;
            btnApply.Text = "Apply";
            btnApply.UseVisualStyleBackColor = true;
            btnApply.Click += btnApply_Click;
            // 
            // pbxCar
            // 
            pbxCar.BackgroundImage = (Image)resources.GetObject("pbxCar.BackgroundImage");
            pbxCar.BackgroundImageLayout = ImageLayout.Zoom;
            pbxCar.Location = new Point(12, 12);
            pbxCar.Name = "pbxCar";
            pbxCar.Size = new Size(260, 254);
            pbxCar.TabIndex = 4;
            pbxCar.TabStop = false;
            // 
            // frmBai1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(489, 283);
            Controls.Add(pbxCar);
            Controls.Add(btnApply);
            Controls.Add(lbTotalTitle);
            Controls.Add(lbTotal);
            Controls.Add(lbQuantity);
            Controls.Add(lbDollar);
            Controls.Add(lbPrice);
            Controls.Add(txtQuantity);
            Controls.Add(txtPrice);
            Controls.Add(gbxColor);
            Name = "frmBai1";
            Text = "frmBai1";
            Load += frmBai1_Load;
            gbxColor.ResumeLayout(false);
            gbxColor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbxCar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox gbxColor;
        private RadioButton rbtnWhite;
        private RadioButton rbtnRed;
        private RadioButton rbtnBlue;
        private TextBox txtPrice;
        private TextBox txtQuantity;
        private Label lbPrice;
        private Label lbDollar;
        private Label lbQuantity;
        private Label lbTotal;
        private Label lbTotalTitle;
        private Button btnApply;
        private PictureBox pbxCar;
    }
}