namespace WinForm
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            toolStrip1 = new ToolStrip();
            tsbBai1 = new ToolStripButton();
            tsbBai2 = new ToolStripButton();
            tsbBai3 = new ToolStripButton();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { tsbBai1, tsbBai2, tsbBai3 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(180, 25);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // tsbBai1
            // 
            tsbBai1.Image = (Image)resources.GetObject("Icon.Image");
            tsbBai1.ImageTransparentColor = Color.Magenta;
            tsbBai1.Name = "tsbBai1";
            tsbBai1.Size = new Size(52, 22);
            tsbBai1.Text = "Bài 1";
            tsbBai1.Click += tsbBai1_Click;
            // 
            // tsbBai2
            // 
            tsbBai2.Image = (Image)resources.GetObject("Icon.Image");
            tsbBai2.ImageTransparentColor = Color.Magenta;
            tsbBai2.Name = "tsbBai2";
            tsbBai2.Size = new Size(52, 22);
            tsbBai2.Text = "Bài 2";
            tsbBai2.Click += tsbBai2_Click;
            // 
            // tsbBai3
            // 
            tsbBai3.Image = (Image)resources.GetObject("Icon.Image");
            tsbBai3.ImageTransparentColor = Color.Magenta;
            tsbBai3.Name = "tsbBai3";
            tsbBai3.Size = new Size(52, 22);
            tsbBai3.Text = "Bài 3";
            tsbBai3.Click += tsbBai3_Click;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(180, 92);
            Controls.Add(toolStrip1);
            Name = "frmMain";
            Text = "Main";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton tsbBai1;
        private ToolStripButton tsbBai2;
        private ToolStripButton tsbBai3;
    }
}
