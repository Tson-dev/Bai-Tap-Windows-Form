namespace BaiTap
{
    partial class frmBai4
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
            lbxNumber = new ListBox();
            lbNumber = new Label();
            txtNumber = new TextBox();
            btnFind = new Button();
            lbResultTitle = new Label();
            lbResult = new Label();
            SuspendLayout();
            // 
            // lbxNumber
            // 
            lbxNumber.FormattingEnabled = true;
            lbxNumber.Location = new Point(12, 12);
            lbxNumber.Name = "lbxNumber";
            lbxNumber.Size = new Size(120, 184);
            lbxNumber.TabIndex = 0;
            // 
            // lbNumber
            // 
            lbNumber.AutoSize = true;
            lbNumber.Location = new Point(150, 15);
            lbNumber.Name = "lbNumber";
            lbNumber.Size = new Size(51, 15);
            lbNumber.TabIndex = 1;
            lbNumber.Text = "Number";
            // 
            // txtNumber
            // 
            txtNumber.Location = new Point(208, 12);
            txtNumber.Name = "txtNumber";
            txtNumber.Size = new Size(100, 23);
            txtNumber.TabIndex = 2;
            // 
            // btnFind
            // 
            btnFind.Location = new Point(233, 41);
            btnFind.Name = "btnFind";
            btnFind.Size = new Size(75, 23);
            btnFind.TabIndex = 3;
            btnFind.Text = "Find";
            btnFind.UseVisualStyleBackColor = true;
            btnFind.Click += btnFind_Click;
            // 
            // lbResultTitle
            // 
            lbResultTitle.AutoSize = true;
            lbResultTitle.Location = new Point(150, 74);
            lbResultTitle.Name = "lbResultTitle";
            lbResultTitle.Size = new Size(39, 15);
            lbResultTitle.TabIndex = 1;
            lbResultTitle.Text = "Result";
            // 
            // lbResult
            // 
            lbResult.AutoSize = true;
            lbResult.Location = new Point(208, 74);
            lbResult.Name = "lbResult";
            lbResult.Size = new Size(25, 15);
            lbResult.TabIndex = 1;
            lbResult.Text = "n/a";
            // 
            // frmBai4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(328, 218);
            Controls.Add(btnFind);
            Controls.Add(txtNumber);
            Controls.Add(lbResult);
            Controls.Add(lbResultTitle);
            Controls.Add(lbNumber);
            Controls.Add(lbxNumber);
            Name = "frmBai4";
            Text = "Find Number";
            Load += frmBai4_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lbxNumber;
        private Label lbNumber;
        private TextBox txtNumber;
        private Button btnFind;
        private Label lbResultTitle;
        private Label lbResult;
    }
}