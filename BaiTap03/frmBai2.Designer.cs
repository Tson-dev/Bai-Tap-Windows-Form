namespace BaiTap03
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
            txtN = new TextBox();
            lbN = new Label();
            gbFunc = new GroupBox();
            rdFractor = new RadioButton();
            rdSum = new RadioButton();
            btnApply = new Button();
            lbResultTitle = new Label();
            lbResult = new Label();
            gbFunc.SuspendLayout();
            SuspendLayout();
            // 
            // txtN
            // 
            txtN.Location = new Point(53, 12);
            txtN.Name = "txtN";
            txtN.Size = new Size(100, 23);
            txtN.TabIndex = 0;
            // 
            // lbN
            // 
            lbN.AutoSize = true;
            lbN.Location = new Point(18, 20);
            lbN.Name = "lbN";
            lbN.Size = new Size(19, 15);
            lbN.TabIndex = 1;
            lbN.Text = "N:";
            // 
            // gbFunc
            // 
            gbFunc.Controls.Add(rdFractor);
            gbFunc.Controls.Add(rdSum);
            gbFunc.Location = new Point(18, 51);
            gbFunc.Name = "gbFunc";
            gbFunc.Size = new Size(135, 78);
            gbFunc.TabIndex = 2;
            gbFunc.TabStop = false;
            gbFunc.Text = "Function";
            // 
            // rdFractor
            // 
            rdFractor.AutoSize = true;
            rdFractor.Location = new Point(16, 47);
            rdFractor.Name = "rdFractor";
            rdFractor.Size = new Size(74, 19);
            rdFractor.TabIndex = 1;
            rdFractor.Text = "Fractor N";
            rdFractor.UseVisualStyleBackColor = true;
            // 
            // rdSum
            // 
            rdSum.AutoSize = true;
            rdSum.Checked = true;
            rdSum.Location = new Point(16, 22);
            rdSum.Name = "rdSum";
            rdSum.Size = new Size(90, 19);
            rdSum.TabIndex = 0;
            rdSum.TabStop = true;
            rdSum.Text = "Sum(n,1) (k)";
            rdSum.UseVisualStyleBackColor = true;
            // 
            // btnApply
            // 
            btnApply.Location = new Point(53, 144);
            btnApply.Name = "btnApply";
            btnApply.Size = new Size(75, 23);
            btnApply.TabIndex = 3;
            btnApply.Text = "Apply";
            btnApply.UseVisualStyleBackColor = true;
            btnApply.Click += btnApply_Click;
            // 
            // lbResultTitle
            // 
            lbResultTitle.AutoSize = true;
            lbResultTitle.Location = new Point(34, 187);
            lbResultTitle.Name = "lbResultTitle";
            lbResultTitle.Size = new Size(42, 15);
            lbResultTitle.TabIndex = 4;
            lbResultTitle.Text = "Result:";
            // 
            // lbResult
            // 
            lbResult.AutoSize = true;
            lbResult.Location = new Point(82, 187);
            lbResult.Name = "lbResult";
            lbResult.Size = new Size(32, 15);
            lbResult.TabIndex = 5;
            lbResult.Text = "label";
            // 
            // frmBai2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(178, 218);
            Controls.Add(lbResult);
            Controls.Add(lbResultTitle);
            Controls.Add(btnApply);
            Controls.Add(gbFunc);
            Controls.Add(lbN);
            Controls.Add(txtN);
            Name = "frmBai2";
            Text = "Bài Tập 2";
            gbFunc.ResumeLayout(false);
            gbFunc.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtN;
        private Label lbN;
        private GroupBox gbFunc;
        private RadioButton rdFractor;
        private RadioButton rdSum;
        private Button btnApply;
        private Label lbResultTitle;
        private Label lbResult;
    }
}