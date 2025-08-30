namespace BaiTap03
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
            txtStr = new TextBox();
            txtN1 = new TextBox();
            txtN2 = new TextBox();
            lbStr = new Label();
            lbN1 = new Label();
            lbN2 = new Label();
            lbResultStr1 = new Label();
            lbResult = new Label();
            lbResultTitle = new Label();
            btnCut = new Button();
            btnCheck = new Button();
            lbResultStr2 = new Label();
            gbPos = new GroupBox();
            rdLast = new RadioButton();
            rdMid = new RadioButton();
            rdFirst = new RadioButton();
            gbPos.SuspendLayout();
            SuspendLayout();
            // 
            // txtStr
            // 
            txtStr.Location = new Point(78, 21);
            txtStr.Name = "txtStr";
            txtStr.Size = new Size(100, 23);
            txtStr.TabIndex = 0;
            // 
            // txtN1
            // 
            txtN1.Location = new Point(227, 16);
            txtN1.Name = "txtN1";
            txtN1.Size = new Size(100, 23);
            txtN1.TabIndex = 1;
            // 
            // txtN2
            // 
            txtN2.Location = new Point(227, 67);
            txtN2.Name = "txtN2";
            txtN2.Size = new Size(100, 23);
            txtN2.TabIndex = 2;
            // 
            // lbStr
            // 
            lbStr.AutoSize = true;
            lbStr.Location = new Point(21, 24);
            lbStr.Name = "lbStr";
            lbStr.Size = new Size(41, 15);
            lbStr.TabIndex = 3;
            lbStr.Text = "String:";
            // 
            // lbN1
            // 
            lbN1.AutoSize = true;
            lbN1.Location = new Point(196, 24);
            lbN1.Name = "lbN1";
            lbN1.Size = new Size(25, 15);
            lbN1.TabIndex = 3;
            lbN1.Text = "N1:";
            // 
            // lbN2
            // 
            lbN2.AutoSize = true;
            lbN2.Location = new Point(196, 75);
            lbN2.Name = "lbN2";
            lbN2.Size = new Size(25, 15);
            lbN2.TabIndex = 3;
            lbN2.Text = "N2:";
            // 
            // lbResultStr1
            // 
            lbResultStr1.AutoSize = true;
            lbResultStr1.Location = new Point(77, 203);
            lbResultStr1.Name = "lbResultStr1";
            lbResultStr1.Size = new Size(26, 15);
            lbResultStr1.TabIndex = 4;
            lbResultStr1.Text = "str1";
            // 
            // lbResult
            // 
            lbResult.AutoSize = true;
            lbResult.Location = new Point(226, 203);
            lbResult.Name = "lbResult";
            lbResult.Size = new Size(25, 15);
            lbResult.TabIndex = 5;
            lbResult.Text = "n/a";
            // 
            // lbResultTitle
            // 
            lbResultTitle.AutoSize = true;
            lbResultTitle.Location = new Point(20, 203);
            lbResultTitle.Name = "lbResultTitle";
            lbResultTitle.Size = new Size(42, 15);
            lbResultTitle.TabIndex = 6;
            lbResultTitle.Text = "Result:";
            // 
            // btnCut
            // 
            btnCut.Location = new Point(77, 154);
            btnCut.Name = "btnCut";
            btnCut.Size = new Size(75, 23);
            btnCut.TabIndex = 7;
            btnCut.Text = "Cut String";
            btnCut.UseVisualStyleBackColor = true;
            btnCut.Click += btnCut_Click;
            // 
            // btnCheck
            // 
            btnCheck.Location = new Point(227, 154);
            btnCheck.Name = "btnCheck";
            btnCheck.Size = new Size(100, 23);
            btnCheck.TabIndex = 8;
            btnCheck.Text = "CheckCloseby";
            btnCheck.UseVisualStyleBackColor = true;
            btnCheck.Click += btnCheck_Click;
            // 
            // lbResultStr2
            // 
            lbResultStr2.AutoSize = true;
            lbResultStr2.Location = new Point(77, 232);
            lbResultStr2.Name = "lbResultStr2";
            lbResultStr2.Size = new Size(26, 15);
            lbResultStr2.TabIndex = 4;
            lbResultStr2.Text = "str2";
            // 
            // gbPos
            // 
            gbPos.Controls.Add(rdLast);
            gbPos.Controls.Add(rdMid);
            gbPos.Controls.Add(rdFirst);
            gbPos.Location = new Point(48, 50);
            gbPos.Name = "gbPos";
            gbPos.Size = new Size(105, 98);
            gbPos.TabIndex = 9;
            gbPos.TabStop = false;
            gbPos.Text = "Position to Cut";
            // 
            // rdLast
            // 
            rdLast.AutoSize = true;
            rdLast.Location = new Point(6, 73);
            rdLast.Name = "rdLast";
            rdLast.Size = new Size(46, 19);
            rdLast.TabIndex = 2;
            rdLast.TabStop = true;
            rdLast.Text = "Last";
            rdLast.UseVisualStyleBackColor = true;
            // 
            // rdMid
            // 
            rdMid.AutoSize = true;
            rdMid.Location = new Point(6, 50);
            rdMid.Name = "rdMid";
            rdMid.Size = new Size(55, 19);
            rdMid.TabIndex = 1;
            rdMid.TabStop = true;
            rdMid.Text = "Midle";
            rdMid.UseVisualStyleBackColor = true;
            // 
            // rdFirst
            // 
            rdFirst.AutoSize = true;
            rdFirst.Checked = true;
            rdFirst.Location = new Point(6, 25);
            rdFirst.Name = "rdFirst";
            rdFirst.Size = new Size(47, 19);
            rdFirst.TabIndex = 0;
            rdFirst.TabStop = true;
            rdFirst.Text = "First";
            rdFirst.UseVisualStyleBackColor = true;
            // 
            // frmBai3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(367, 343);
            Controls.Add(gbPos);
            Controls.Add(btnCheck);
            Controls.Add(btnCut);
            Controls.Add(lbResultTitle);
            Controls.Add(lbResult);
            Controls.Add(lbResultStr2);
            Controls.Add(lbResultStr1);
            Controls.Add(lbN2);
            Controls.Add(lbN1);
            Controls.Add(lbStr);
            Controls.Add(txtN2);
            Controls.Add(txtN1);
            Controls.Add(txtStr);
            Name = "frmBai3";
            Text = "Bài Tập 3";
            gbPos.ResumeLayout(false);
            gbPos.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtStr;
        private TextBox txtN1;
        private TextBox txtN2;
        private Label lbStr;
        private Label lbN1;
        private Label lbN2;
        private Label lbResultStr1;
        private Label lbResult;
        private Label lbResultTitle;
        private Button btnCut;
        private Button btnCheck;
        private Label lbResultStr2;
        private GroupBox gbPos;
        private RadioButton rdLast;
        private RadioButton rdMid;
        private RadioButton rdFirst;
    }
}