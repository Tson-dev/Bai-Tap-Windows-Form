namespace BaiTap
{
    partial class Main
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
            msMyName = new MenuStrip();
            tsmNHTS = new ToolStripMenuItem();
            tsmiBai1 = new ToolStripMenuItem();
            tsmiBai2 = new ToolStripMenuItem();
            tsmiBai3 = new ToolStripMenuItem();
            tsmiBai4 = new ToolStripMenuItem();
            msMyName.SuspendLayout();
            SuspendLayout();
            // 
            // msMyName
            // 
            msMyName.Items.AddRange(new ToolStripItem[] { tsmNHTS });
            msMyName.Location = new Point(0, 0);
            msMyName.Name = "msMyName";
            msMyName.Size = new Size(236, 24);
            msMyName.TabIndex = 0;
            msMyName.Text = "My Name";
            // 
            // tsmNHTS
            // 
            tsmNHTS.DropDownItems.AddRange(new ToolStripItem[] { tsmiBai1, tsmiBai2, tsmiBai3, tsmiBai4 });
            tsmNHTS.Name = "tsmNHTS";
            tsmNHTS.Size = new Size(144, 20);
            tsmNHTS.Text = "Nguyễn Hữu Trung Sơn";
            // 
            // tsmiBai1
            // 
            tsmiBai1.Name = "tsmiBai1";
            tsmiBai1.Size = new Size(180, 22);
            tsmiBai1.Text = "Bài 1";
            tsmiBai1.Click += tsmiBai1_Click;
            // 
            // tsmiBai2
            // 
            tsmiBai2.Name = "tsmiBai2";
            tsmiBai2.Size = new Size(180, 22);
            tsmiBai2.Text = "Bài 2";
            tsmiBai2.Click += tsmiBai2_Click;
            // 
            // tsmiBai3
            // 
            tsmiBai3.Name = "tsmiBai3";
            tsmiBai3.Size = new Size(180, 22);
            tsmiBai3.Text = "Bài 3";
            tsmiBai3.Click += tsmiBai3_Click;
            // 
            // tsmiBai4
            // 
            tsmiBai4.Name = "tsmiBai4";
            tsmiBai4.Size = new Size(180, 22);
            tsmiBai4.Text = "Bài 4";
            tsmiBai4.Click += tsmiBai4_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(236, 141);
            Controls.Add(msMyName);
            MainMenuStrip = msMyName;
            Name = "Main";
            Text = "Main Form";
            Load += Main_Load;
            msMyName.ResumeLayout(false);
            msMyName.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip msMyName;
        private ToolStripMenuItem tsmNHTS;
        private ToolStripMenuItem tsmiBai1;
        private ToolStripMenuItem tsmiBai2;
        private ToolStripMenuItem tsmiBai3;
        private ToolStripMenuItem tsmiBai4;
    }
}
