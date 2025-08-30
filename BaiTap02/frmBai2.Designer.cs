namespace BaiTap02
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
            txtA = new TextBox();
            txtB = new TextBox();
            lbA = new Label();
            lbB = new Label();
            lbResultTilte = new Label();
            lbResult = new Label();
            gbMathOp = new GroupBox();
            rbtnDiv = new RadioButton();
            rbtnMulti = new RadioButton();
            rbtnMinus = new RadioButton();
            rbtnPlus = new RadioButton();
            btnApply = new Button();
            gbMathOp.SuspendLayout();
            SuspendLayout();
            // 
            // txtA
            // 
            txtA.Location = new Point(67, 12);
            txtA.Name = "txtA";
            txtA.Size = new Size(100, 23);
            txtA.TabIndex = 0;
            // 
            // txtB
            // 
            txtB.Location = new Point(67, 41);
            txtB.Name = "txtB";
            txtB.Size = new Size(100, 23);
            txtB.TabIndex = 1;
            // 
            // lbA
            // 
            lbA.AutoSize = true;
            lbA.Location = new Point(29, 19);
            lbA.Name = "lbA";
            lbA.Size = new Size(15, 15);
            lbA.TabIndex = 2;
            lbA.Text = "A";
            // 
            // lbB
            // 
            lbB.AutoSize = true;
            lbB.Location = new Point(29, 49);
            lbB.Name = "lbB";
            lbB.Size = new Size(14, 15);
            lbB.TabIndex = 3;
            lbB.Text = "B";
            // 
            // lbResultTilte
            // 
            lbResultTilte.AutoSize = true;
            lbResultTilte.Location = new Point(46, 255);
            lbResultTilte.Name = "lbResultTilte";
            lbResultTilte.Size = new Size(42, 15);
            lbResultTilte.TabIndex = 4;
            lbResultTilte.Text = "Result:";
            // 
            // lbResult
            // 
            lbResult.AutoSize = true;
            lbResult.Location = new Point(91, 255);
            lbResult.Name = "lbResult";
            lbResult.Size = new Size(13, 15);
            lbResult.TabIndex = 5;
            lbResult.Text = "0";
            // 
            // gbMathOp
            // 
            gbMathOp.Controls.Add(rbtnDiv);
            gbMathOp.Controls.Add(rbtnMulti);
            gbMathOp.Controls.Add(rbtnMinus);
            gbMathOp.Controls.Add(rbtnPlus);
            gbMathOp.Location = new Point(29, 70);
            gbMathOp.Name = "gbMathOp";
            gbMathOp.Size = new Size(155, 133);
            gbMathOp.TabIndex = 6;
            gbMathOp.TabStop = false;
            gbMathOp.Text = "Select a Math operation";
            // 
            // rbtnDiv
            // 
            rbtnDiv.AutoSize = true;
            rbtnDiv.Location = new Point(15, 99);
            rbtnDiv.Name = "rbtnDiv";
            rbtnDiv.Size = new Size(58, 19);
            rbtnDiv.TabIndex = 0;
            rbtnDiv.TabStop = true;
            rbtnDiv.Text = "Divine";
            rbtnDiv.UseVisualStyleBackColor = true;
            // 
            // rbtnMulti
            // 
            rbtnMulti.AutoSize = true;
            rbtnMulti.Location = new Point(15, 74);
            rbtnMulti.Name = "rbtnMulti";
            rbtnMulti.Size = new Size(53, 19);
            rbtnMulti.TabIndex = 0;
            rbtnMulti.TabStop = true;
            rbtnMulti.Text = "Multi";
            rbtnMulti.UseVisualStyleBackColor = true;
            // 
            // rbtnMinus
            // 
            rbtnMinus.AutoSize = true;
            rbtnMinus.Location = new Point(15, 49);
            rbtnMinus.Name = "rbtnMinus";
            rbtnMinus.Size = new Size(58, 19);
            rbtnMinus.TabIndex = 0;
            rbtnMinus.TabStop = true;
            rbtnMinus.Text = "Minus";
            rbtnMinus.UseVisualStyleBackColor = true;
            // 
            // rbtnPlus
            // 
            rbtnPlus.AutoSize = true;
            rbtnPlus.Checked = true;
            rbtnPlus.Location = new Point(15, 24);
            rbtnPlus.Name = "rbtnPlus";
            rbtnPlus.Size = new Size(47, 19);
            rbtnPlus.TabIndex = 0;
            rbtnPlus.TabStop = true;
            rbtnPlus.Text = "Plus";
            rbtnPlus.UseVisualStyleBackColor = true;
            // 
            // btnApply
            // 
            btnApply.Location = new Point(67, 209);
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
            ClientSize = new Size(208, 293);
            Controls.Add(btnApply);
            Controls.Add(gbMathOp);
            Controls.Add(lbResult);
            Controls.Add(lbResultTilte);
            Controls.Add(lbB);
            Controls.Add(lbA);
            Controls.Add(txtB);
            Controls.Add(txtA);
            Name = "frmBai2";
            Text = "Bài Tập 2";
            gbMathOp.ResumeLayout(false);
            gbMathOp.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtA;
        private TextBox txtB;
        private Label lbA;
        private Label lbB;
        private Label lbResultTilte;
        private Label lbResult;
        private GroupBox gbMathOp;
        private RadioButton rbtnDiv;
        private RadioButton rbtnMulti;
        private RadioButton rbtnMinus;
        private RadioButton rbtnPlus;
        private Button btnApply;
    }
}