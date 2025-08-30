namespace BaiTap04
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
            lbResult = new Label();
            lbResultTitle = new Label();
            btnCheck = new Button();
            lbPratice = new Label();
            lbTheory = new Label();
            txtPratice = new TextBox();
            txtTheory = new TextBox();
            SuspendLayout();
            // 
            // lbResult
            // 
            lbResult.AutoSize = true;
            lbResult.Location = new Point(81, 139);
            lbResult.Name = "lbResult";
            lbResult.Size = new Size(26, 15);
            lbResult.TabIndex = 12;
            lbResult.Text = "text";
            // 
            // lbResultTitle
            // 
            lbResultTitle.AutoSize = true;
            lbResultTitle.Location = new Point(20, 139);
            lbResultTitle.Name = "lbResultTitle";
            lbResultTitle.Size = new Size(42, 15);
            lbResultTitle.TabIndex = 11;
            lbResultTitle.Text = "Result:";
            // 
            // btnCheck
            // 
            btnCheck.Location = new Point(81, 91);
            btnCheck.Name = "btnCheck";
            btnCheck.Size = new Size(75, 23);
            btnCheck.TabIndex = 10;
            btnCheck.Text = "Check";
            btnCheck.UseVisualStyleBackColor = true;
            btnCheck.Click += btnCheck_Click;
            // 
            // lbPratice
            // 
            lbPratice.AutoSize = true;
            lbPratice.Location = new Point(20, 55);
            lbPratice.Name = "lbPratice";
            lbPratice.Size = new Size(43, 15);
            lbPratice.TabIndex = 9;
            lbPratice.Text = "Pratice";
            // 
            // lbTheory
            // 
            lbTheory.AutoSize = true;
            lbTheory.Location = new Point(20, 26);
            lbTheory.Name = "lbTheory";
            lbTheory.Size = new Size(44, 15);
            lbTheory.TabIndex = 8;
            lbTheory.Text = "Theory";
            // 
            // txtPratice
            // 
            txtPratice.Location = new Point(81, 52);
            txtPratice.Name = "txtPratice";
            txtPratice.Size = new Size(100, 23);
            txtPratice.TabIndex = 6;
            // 
            // txtTheory
            // 
            txtTheory.Location = new Point(81, 23);
            txtTheory.Name = "txtTheory";
            txtTheory.Size = new Size(100, 23);
            txtTheory.TabIndex = 7;
            // 
            // frmBai2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(201, 187);
            Controls.Add(lbResult);
            Controls.Add(lbResultTitle);
            Controls.Add(btnCheck);
            Controls.Add(lbPratice);
            Controls.Add(lbTheory);
            Controls.Add(txtPratice);
            Controls.Add(txtTheory);
            Name = "frmBai2";
            Text = "frmBai2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbResult;
        private Label lbResultTitle;
        private Button btnCheck;
        private Label lbPratice;
        private Label lbTheory;
        private TextBox txtPratice;
        private TextBox txtTheory;
    }
}