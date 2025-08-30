using BaiTap02.Properties;
using System.Reflection;

namespace BaiTap02
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            msKT = new MenuStrip();
            tsmKT = new ToolStripMenuItem();
            tsmiBT1 = new ToolStripMenuItem();
            tsmiBT2 = new ToolStripMenuItem();
            tsmiBT3 = new ToolStripMenuItem();
            msKT.SuspendLayout();
            SuspendLayout();
            // 
            // msKT
            // 
            msKT.Items.AddRange(new ToolStripItem[] { tsmKT });
            msKT.Location = new Point(0, 0);
            msKT.Name = "msKT";
            msKT.Size = new Size(371, 24);
            msKT.TabIndex = 0;
            msKT.Text = "menuStrip1";
            // 
            // tsmKT
            // 
            tsmKT.DropDownItems.AddRange(new ToolStripItem[] { tsmiBT1, tsmiBT2, tsmiBT3 });
            tsmKT.Name = "tsmKT";
            tsmKT.Size = new Size(84, 20);
            tsmKT.Text = "Bài Kiểm Tra";
            // 
            // tsmiBT1
            // 
            tsmiBT1.Image = (Image)resources.GetObject("tsmiBT1.Image");
            tsmiBT1.Name = "tsmiBT1";
            tsmiBT1.Size = new Size(180, 22);
            tsmiBT1.Text = "Bài Tập 01";
            tsmiBT1.Click += tsmiBT1_Click;
            // 
            // tsmiBT2
            // 
            tsmiBT2.Image = (Image)resources.GetObject("tsmiBT2.Image");
            tsmiBT2.Name = "tsmiBT2";
            tsmiBT2.Size = new Size(180, 22);
            tsmiBT2.Text = "Bài Tập 02";
            tsmiBT2.Click += tsmiBT2_Click;
            // 
            // tsmiBT3
            // 
            tsmiBT3.Image = (Image)resources.GetObject("tsmiBT3.Image");
            tsmiBT3.Name = "tsmiBT3";
            tsmiBT3.Size = new Size(180, 22);
            tsmiBT3.Text = "Bài Tập 03";
            tsmiBT3.Click += tsmiBT3_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(371, 244);
            Controls.Add(msKT);
            MainMenuStrip = msKT;
            Name = "Main";
            Text = "Main";
            msKT.ResumeLayout(false);
            msKT.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip msKT;
        private ToolStripMenuItem tsmKT;
        private ToolStripMenuItem tsmiBT1;
        private ToolStripMenuItem tsmiBT2;
        private ToolStripMenuItem tsmiBT3;
    }
}
