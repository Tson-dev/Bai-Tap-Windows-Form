namespace BaiTap04
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
            menuStrip1 = new MenuStrip();
            bàiThiToolStripMenuItem = new ToolStripMenuItem();
            bài01ToolStripMenuItem = new ToolStripMenuItem();
            bài02ToolStripMenuItem = new ToolStripMenuItem();
            bài03ToolStripMenuItem = new ToolStripMenuItem();
            trợGiúpToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { bàiThiToolStripMenuItem, trợGiúpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(437, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // bàiThiToolStripMenuItem
            // 
            bàiThiToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { bài01ToolStripMenuItem, bài02ToolStripMenuItem, bài03ToolStripMenuItem });
            bàiThiToolStripMenuItem.Name = "bàiThiToolStripMenuItem";
            bàiThiToolStripMenuItem.Size = new Size(55, 20);
            bàiThiToolStripMenuItem.Text = "Bài Thi";
            // 
            // bài01ToolStripMenuItem
            // 
            bài01ToolStripMenuItem.Name = "bài01ToolStripMenuItem";
            bài01ToolStripMenuItem.Size = new Size(180, 22);
            bài01ToolStripMenuItem.Text = "Bài 01";
            bài01ToolStripMenuItem.Click += bài01ToolStripMenuItem_Click;
            // 
            // bài02ToolStripMenuItem
            // 
            bài02ToolStripMenuItem.Name = "bài02ToolStripMenuItem";
            bài02ToolStripMenuItem.Size = new Size(180, 22);
            bài02ToolStripMenuItem.Text = "Bài 02";
            bài02ToolStripMenuItem.Click += bài02ToolStripMenuItem_Click;
            // 
            // bài03ToolStripMenuItem
            // 
            bài03ToolStripMenuItem.Name = "bài03ToolStripMenuItem";
            bài03ToolStripMenuItem.Size = new Size(180, 22);
            bài03ToolStripMenuItem.Text = "Bài 03";
            bài03ToolStripMenuItem.Click += bài03ToolStripMenuItem_Click;
            // 
            // trợGiúpToolStripMenuItem
            // 
            trợGiúpToolStripMenuItem.Name = "trợGiúpToolStripMenuItem";
            trợGiúpToolStripMenuItem.Size = new Size(64, 20);
            trợGiúpToolStripMenuItem.Text = "Trợ Giúp";
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(437, 289);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Main";
            Text = "KT Kết Thúc Môn yeeeeeee";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem bàiThiToolStripMenuItem;
        private ToolStripMenuItem bài01ToolStripMenuItem;
        private ToolStripMenuItem bài02ToolStripMenuItem;
        private ToolStripMenuItem bài03ToolStripMenuItem;
        private ToolStripMenuItem trợGiúpToolStripMenuItem;
    }
}
