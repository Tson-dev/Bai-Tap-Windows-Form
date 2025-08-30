namespace BaiTap04
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
            btnGreeting = new Button();
            txtName = new TextBox();
            cbMale = new CheckBox();
            lbName = new Label();
            txtA = new TextBox();
            txtB = new TextBox();
            lbA = new Label();
            lbB = new Label();
            lbResultTitle = new Label();
            lbResult = new Label();
            btnGCD = new Button();
            SuspendLayout();
            // 
            // btnGreeting
            // 
            btnGreeting.Location = new Point(15, 75);
            btnGreeting.Name = "btnGreeting";
            btnGreeting.Size = new Size(75, 23);
            btnGreeting.TabIndex = 0;
            btnGreeting.Text = "Greeting";
            btnGreeting.UseVisualStyleBackColor = true;
            btnGreeting.Click += btnGreeting_Click;
            // 
            // txtName
            // 
            txtName.Location = new Point(60, 12);
            txtName.Name = "txtName";
            txtName.Size = new Size(100, 23);
            txtName.TabIndex = 1;
            // 
            // cbMale
            // 
            cbMale.AutoSize = true;
            cbMale.Location = new Point(12, 50);
            cbMale.Name = "cbMale";
            cbMale.Size = new Size(57, 19);
            cbMale.TabIndex = 2;
            cbMale.Text = "Male?";
            cbMale.UseVisualStyleBackColor = true;
            cbMale.CheckedChanged += cbMale_CheckedChanged;
            // 
            // lbName
            // 
            lbName.AutoSize = true;
            lbName.Location = new Point(12, 20);
            lbName.Name = "lbName";
            lbName.Size = new Size(42, 15);
            lbName.TabIndex = 3;
            lbName.Text = "Name:";
            // 
            // txtA
            // 
            txtA.Location = new Point(60, 126);
            txtA.Name = "txtA";
            txtA.Size = new Size(100, 23);
            txtA.TabIndex = 4;
            // 
            // txtB
            // 
            txtB.Location = new Point(60, 155);
            txtB.Name = "txtB";
            txtB.Size = new Size(100, 23);
            txtB.TabIndex = 5;
            // 
            // lbA
            // 
            lbA.AutoSize = true;
            lbA.Location = new Point(12, 129);
            lbA.Name = "lbA";
            lbA.Size = new Size(18, 15);
            lbA.TabIndex = 6;
            lbA.Text = "A:";
            // 
            // lbB
            // 
            lbB.AutoSize = true;
            lbB.Location = new Point(12, 158);
            lbB.Name = "lbB";
            lbB.Size = new Size(17, 15);
            lbB.TabIndex = 6;
            lbB.Text = "B:";
            // 
            // lbResultTitle
            // 
            lbResultTitle.AutoSize = true;
            lbResultTitle.Location = new Point(15, 219);
            lbResultTitle.Name = "lbResultTitle";
            lbResultTitle.Size = new Size(42, 15);
            lbResultTitle.TabIndex = 7;
            lbResultTitle.Text = "Result:";
            // 
            // lbResult
            // 
            lbResult.AutoSize = true;
            lbResult.Location = new Point(60, 219);
            lbResult.Name = "lbResult";
            lbResult.Size = new Size(13, 15);
            lbResult.TabIndex = 8;
            lbResult.Text = "0";
            // 
            // btnGCD
            // 
            btnGCD.Location = new Point(15, 184);
            btnGCD.Name = "btnGCD";
            btnGCD.Size = new Size(75, 23);
            btnGCD.TabIndex = 9;
            btnGCD.Text = "GCD";
            btnGCD.UseVisualStyleBackColor = true;
            btnGCD.Click += btnGCD_Click;
            // 
            // frmBai3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(182, 268);
            Controls.Add(btnGCD);
            Controls.Add(lbResult);
            Controls.Add(lbResultTitle);
            Controls.Add(lbB);
            Controls.Add(lbA);
            Controls.Add(txtB);
            Controls.Add(txtA);
            Controls.Add(lbName);
            Controls.Add(cbMale);
            Controls.Add(txtName);
            Controls.Add(btnGreeting);
            Name = "frmBai3";
            Text = "frmBai3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGreeting;
        private TextBox txtName;
        private CheckBox cbMale;
        private Label lbName;
        private TextBox txtA;
        private TextBox txtB;
        private Label lbA;
        private Label lbB;
        private Label lbResultTitle;
        private Label lbResult;
        private Button btnGCD;
    }
}