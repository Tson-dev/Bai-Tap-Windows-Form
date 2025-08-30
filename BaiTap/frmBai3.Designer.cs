namespace BaiTap
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
            label1 = new Label();
            lbMeant = new Label();
            txtMEANNIG = new TextBox();
            btnAdd = new Button();
            lbxWord = new ListBox();
            lbLONW = new Label();
            txtMeant = new TextBox();
            txtWord = new TextBox();
            lbMEANNING = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 15);
            label1.Name = "label1";
            label1.Size = new Size(66, 15);
            label1.TabIndex = 1;
            label1.Text = "New Word:";
            // 
            // lbMeant
            // 
            lbMeant.AutoSize = true;
            lbMeant.Location = new Point(20, 44);
            lbMeant.Name = "lbMeant";
            lbMeant.Size = new Size(57, 15);
            lbMeant.TabIndex = 1;
            lbMeant.Text = "Meaning:";
            // 
            // txtMEANNIG
            // 
            txtMEANNIG.Location = new Point(225, 149);
            txtMEANNIG.Multiline = true;
            txtMEANNIG.Name = "txtMEANNIG";
            txtMEANNIG.Size = new Size(164, 94);
            txtMEANNIG.TabIndex = 2;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(99, 70);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // lbxWord
            // 
            lbxWord.FormattingEnabled = true;
            lbxWord.Location = new Point(54, 149);
            lbxWord.Name = "lbxWord";
            lbxWord.Size = new Size(138, 94);
            lbxWord.TabIndex = 4;
            lbxWord.SelectedIndexChanged += lbxWord_SelectedIndexChanged;
            // 
            // lbLONW
            // 
            lbLONW.AutoSize = true;
            lbLONW.Location = new Point(54, 121);
            lbLONW.Name = "lbLONW";
            lbLONW.Size = new Size(114, 15);
            lbLONW.TabIndex = 5;
            lbLONW.Text = "LIST OF NEW WORD";
            // 
            // txtMeant
            // 
            txtMeant.Location = new Point(92, 41);
            txtMeant.Name = "txtMeant";
            txtMeant.Size = new Size(100, 23);
            txtMeant.TabIndex = 2;
            // 
            // txtWord
            // 
            txtWord.Location = new Point(92, 12);
            txtWord.Name = "txtWord";
            txtWord.Size = new Size(100, 23);
            txtWord.TabIndex = 2;
            // 
            // lbMEANNING
            // 
            lbMEANNING.AutoSize = true;
            lbMEANNING.Location = new Point(225, 121);
            lbMEANNING.Name = "lbMEANNING";
            lbMEANNING.Size = new Size(61, 15);
            lbMEANNING.TabIndex = 6;
            lbMEANNING.Text = "MEANING";
            // 
            // frmBai3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(436, 267);
            Controls.Add(lbMEANNING);
            Controls.Add(lbLONW);
            Controls.Add(lbxWord);
            Controls.Add(btnAdd);
            Controls.Add(txtWord);
            Controls.Add(txtMeant);
            Controls.Add(txtMEANNIG);
            Controls.Add(lbMeant);
            Controls.Add(label1);
            Name = "frmBai3";
            Text = "Vinlish Dictionary";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lbMeant;
        private TextBox txtMEANNIG;
        private Button btnAdd;
        private ListBox lbxWord;
        private Label lbLONW;
        private TextBox txtMeant;
        private TextBox txtWord;
        private Label lbMEANNING;
    }
}