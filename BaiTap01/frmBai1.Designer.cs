namespace WinForm
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
            lbThongTin = new Label();
            SuspendLayout();
            // 
            // lbThongTin
            // 
            lbThongTin.AutoSize = true;
            lbThongTin.Location = new Point(55, 44);
            lbThongTin.Name = "lbThongTin";
            lbThongTin.Size = new Size(50, 15);
            lbThongTin.TabIndex = 0;
            lbThongTin.Text = "Brrrrrrrrr";
            // 
            // frmBai1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(291, 106);
            Controls.Add(lbThongTin);
            Name = "frmBai1";
            Text = "Bài 01";
            Load += frmBai1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbThongTin;
    }
}