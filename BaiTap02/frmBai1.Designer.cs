namespace BaiTap02
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
            lbThietBi = new Label();
            SuspendLayout();
            // 
            // lbThietBi
            // 
            lbThietBi.AutoSize = true;
            lbThietBi.Location = new Point(66, 65);
            lbThietBi.Name = "lbThietBi";
            lbThietBi.Size = new Size(87, 15);
            lbThietBi.TabIndex = 0;
            lbThietBi.Text = "lblblblblblblblb";
            // 
            // frmBai1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(279, 176);
            Controls.Add(lbThietBi);
            Name = "frmBai1";
            Text = "Bài Tập 1";
            Load += frmBai1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbThietBi;
    }
}