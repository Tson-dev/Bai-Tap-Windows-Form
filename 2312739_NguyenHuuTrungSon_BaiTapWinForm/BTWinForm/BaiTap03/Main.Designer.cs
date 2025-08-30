namespace BaiTap03
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
            btnBai1 = new Button();
            btnBai2 = new Button();
            btnBai3 = new Button();
            SuspendLayout();
            // 
            // btnBai1
            // 
            btnBai1.Location = new Point(16, 59);
            btnBai1.Name = "btnBai1";
            btnBai1.Size = new Size(75, 23);
            btnBai1.TabIndex = 0;
            btnBai1.Text = "Bài1";
            btnBai1.UseVisualStyleBackColor = true;
            btnBai1.Click += btnBai1_Click;
            // 
            // btnBai2
            // 
            btnBai2.Location = new Point(111, 59);
            btnBai2.Name = "btnBai2";
            btnBai2.Size = new Size(75, 23);
            btnBai2.TabIndex = 0;
            btnBai2.Text = "Bài 2";
            btnBai2.UseVisualStyleBackColor = true;
            btnBai2.Click += btnBai2_Click;
            // 
            // btnBai3
            // 
            btnBai3.Location = new Point(210, 59);
            btnBai3.Name = "btnBai3";
            btnBai3.Size = new Size(75, 23);
            btnBai3.TabIndex = 0;
            btnBai3.Text = "Bài 3";
            btnBai3.UseVisualStyleBackColor = true;
            btnBai3.Click += btnBai3_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(308, 136);
            Controls.Add(btnBai3);
            Controls.Add(btnBai2);
            Controls.Add(btnBai1);
            Name = "Main";
            Text = "Main";
            ResumeLayout(false);
        }

        #endregion

        private Button btnBai1;
        private Button btnBai2;
        private Button btnBai3;
    }
}
