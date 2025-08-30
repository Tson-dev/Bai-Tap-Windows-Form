namespace BaiTap04
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
            lbText = new Label();
            SuspendLayout();
            // 
            // lbText
            // 
            lbText.AutoSize = true;
            lbText.Location = new Point(72, 83);
            lbText.Name = "lbText";
            lbText.Size = new Size(71, 15);
            lbText.TabIndex = 0;
            lbText.Text = "kdgbjwashd";
            // 
            // frmBai1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(423, 268);
            Controls.Add(lbText);
            Name = "frmBai1";
            Text = "frmBai1";
            Load += this.frmBai1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbText;
    }
}