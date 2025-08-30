namespace WinForm
{
    partial class frmBai3
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
            txtA = new TextBox();
            txtB = new TextBox();
            txtN = new TextBox();
            btnSum = new Button();
            btnAPlusB = new Button();
            lbA = new Label();
            lbB = new Label();
            lbN = new Label();
            lbResultTitle = new Label();
            lbResult = new Label();
            SuspendLayout();
            // 
            // txtA
            // 
            txtA.Location = new Point(67, 35);
            txtA.Name = "txtA";
            txtA.Size = new Size(61, 23);
            txtA.TabIndex = 0;
            // 
            // txtB
            // 
            txtB.Location = new Point(176, 35);
            txtB.Name = "txtB";
            txtB.Size = new Size(64, 23);
            txtB.TabIndex = 1;
            // 
            // txtN
            // 
            txtN.Location = new Point(67, 90);
            txtN.Name = "txtN";
            txtN.Size = new Size(61, 23);
            txtN.TabIndex = 3;
            // 
            // btnSum
            // 
            btnSum.Location = new Point(259, 89);
            btnSum.Name = "btnSum";
            btnSum.Size = new Size(88, 23);
            btnSum.TabIndex = 5;
            btnSum.Text = "Sum(n,1)(k)";
            btnSum.UseVisualStyleBackColor = true;
            btnSum.Click += btnSum_Click;
            // 
            // btnAPlusB
            // 
            btnAPlusB.Location = new Point(272, 35);
            btnAPlusB.Name = "btnAPlusB";
            btnAPlusB.Size = new Size(75, 23);
            btnAPlusB.TabIndex = 6;
            btnAPlusB.Text = "A+B";
            btnAPlusB.UseVisualStyleBackColor = true;
            btnAPlusB.Click += btnAPlusB_Click;
            // 
            // lbA
            // 
            lbA.AutoSize = true;
            lbA.Location = new Point(23, 43);
            lbA.Name = "lbA";
            lbA.Size = new Size(15, 15);
            lbA.TabIndex = 7;
            lbA.Text = "A";
            // 
            // lbB
            // 
            lbB.AutoSize = true;
            lbB.Location = new Point(146, 38);
            lbB.Name = "lbB";
            lbB.Size = new Size(14, 15);
            lbB.TabIndex = 8;
            lbB.Text = "B";
            // 
            // lbN
            // 
            lbN.AutoSize = true;
            lbN.Location = new Point(23, 98);
            lbN.Name = "lbN";
            lbN.Size = new Size(16, 15);
            lbN.TabIndex = 9;
            lbN.Text = "N";
            // 
            // lbResultTitle
            // 
            lbResultTitle.AutoSize = true;
            lbResultTitle.Location = new Point(12, 145);
            lbResultTitle.Name = "lbResultTitle";
            lbResultTitle.Size = new Size(42, 15);
            lbResultTitle.TabIndex = 10;
            lbResultTitle.Text = "Result:";
            // 
            // lbResult
            // 
            lbResult.AutoSize = true;
            lbResult.Location = new Point(67, 145);
            lbResult.Name = "lbResult";
            lbResult.Size = new Size(13, 15);
            lbResult.TabIndex = 11;
            lbResult.Text = "0";
            // 
            // frmBai3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(369, 187);
            Controls.Add(lbResult);
            Controls.Add(lbResultTitle);
            Controls.Add(lbN);
            Controls.Add(lbB);
            Controls.Add(lbA);
            Controls.Add(btnAPlusB);
            Controls.Add(btnSum);
            Controls.Add(txtN);
            Controls.Add(txtB);
            Controls.Add(txtA);
            Name = "frmBai3";
            Text = "Bai 03";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtA;
        private TextBox txtB;
        private TextBox txtN;
        private Button btnSum;
        private Button btnAPlusB;
        private Label lbA;
        private Label lbB;
        private Label lbN;
        private Label lbResultTitle;
        private Label lbResult;
    }
}