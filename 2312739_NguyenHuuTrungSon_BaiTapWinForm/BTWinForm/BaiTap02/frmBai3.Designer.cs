namespace BaiTap02
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
            txtLeft = new TextBox();
            txtRight = new TextBox();
            btnMerge = new Button();
            btnFactor = new Button();
            txtN = new TextBox();
            lbResultTilte = new Label();
            lbResult = new Label();
            lbLeft = new Label();
            lbRight = new Label();
            lbN = new Label();
            SuspendLayout();
            // 
            // txtLeft
            // 
            txtLeft.Location = new Point(76, 22);
            txtLeft.Name = "txtLeft";
            txtLeft.Size = new Size(100, 23);
            txtLeft.TabIndex = 0;
            // 
            // txtRight
            // 
            txtRight.Location = new Point(76, 63);
            txtRight.Name = "txtRight";
            txtRight.Size = new Size(100, 23);
            txtRight.TabIndex = 1;
            // 
            // btnMerge
            // 
            btnMerge.Location = new Point(76, 106);
            btnMerge.Name = "btnMerge";
            btnMerge.Size = new Size(75, 23);
            btnMerge.TabIndex = 2;
            btnMerge.Text = "Merge";
            btnMerge.UseVisualStyleBackColor = true;
            btnMerge.Click += btnMerge_Click;
            // 
            // btnFactor
            // 
            btnFactor.Location = new Point(248, 106);
            btnFactor.Name = "btnFactor";
            btnFactor.Size = new Size(75, 23);
            btnFactor.TabIndex = 3;
            btnFactor.Text = "Fartor N";
            btnFactor.UseVisualStyleBackColor = true;
            btnFactor.Click += btnFactor_Click;
            // 
            // txtN
            // 
            txtN.Location = new Point(248, 22);
            txtN.Name = "txtN";
            txtN.Size = new Size(56, 23);
            txtN.TabIndex = 4;
            // 
            // lbResultTilte
            // 
            lbResultTilte.AutoSize = true;
            lbResultTilte.Location = new Point(19, 158);
            lbResultTilte.Name = "lbResultTilte";
            lbResultTilte.Size = new Size(42, 15);
            lbResultTilte.TabIndex = 5;
            lbResultTilte.Text = "Result:";
            // 
            // lbResult
            // 
            lbResult.AutoSize = true;
            lbResult.Location = new Point(76, 158);
            lbResult.Name = "lbResult";
            lbResult.Size = new Size(0, 15);
            lbResult.TabIndex = 6;
            // 
            // lbLeft
            // 
            lbLeft.AutoSize = true;
            lbLeft.Location = new Point(19, 30);
            lbLeft.Name = "lbLeft";
            lbLeft.Size = new Size(27, 15);
            lbLeft.TabIndex = 7;
            lbLeft.Text = "Left";
            // 
            // lbRight
            // 
            lbRight.AutoSize = true;
            lbRight.Location = new Point(19, 71);
            lbRight.Name = "lbRight";
            lbRight.Size = new Size(35, 15);
            lbRight.TabIndex = 7;
            lbRight.Text = "Right";
            // 
            // lbN
            // 
            lbN.AutoSize = true;
            lbN.Location = new Point(214, 30);
            lbN.Name = "lbN";
            lbN.Size = new Size(16, 15);
            lbN.TabIndex = 7;
            lbN.Text = "N";
            // 
            // frmBai3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(447, 311);
            Controls.Add(lbN);
            Controls.Add(lbRight);
            Controls.Add(lbLeft);
            Controls.Add(lbResult);
            Controls.Add(lbResultTilte);
            Controls.Add(txtN);
            Controls.Add(btnFactor);
            Controls.Add(btnMerge);
            Controls.Add(txtRight);
            Controls.Add(txtLeft);
            Name = "frmBai3";
            Text = "Bài Tập 3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtLeft;
        private TextBox txtRight;
        private Button btnMerge;
        private Button btnFactor;
        private TextBox txtN;
        private Label lbResultTilte;
        private Label lbResult;
        private Label lbLeft;
        private Label lbRight;
        private Label lbN;
    }
}