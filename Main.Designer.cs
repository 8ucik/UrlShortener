namespace UrlShortener
{
    partial class Main
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabTinyApi = new System.Windows.Forms.TabPage();
            this.outputBox = new System.Windows.Forms.TextBox();
            this.urlBox = new System.Windows.Forms.TextBox();
            this.outputLbl = new System.Windows.Forms.Label();
            this.urlLbl = new System.Windows.Forms.Label();
            this.copyBtn = new System.Windows.Forms.Button();
            this.processBtn = new System.Windows.Forms.Button();
            this.tabBitlyApi = new System.Windows.Forms.TabPage();
            this.outputBox2 = new System.Windows.Forms.TextBox();
            this.outputLbl2 = new System.Windows.Forms.Label();
            this.copyBtn2 = new System.Windows.Forms.Button();
            this.processBtn2 = new System.Windows.Forms.Button();
            this.urlBox2 = new System.Windows.Forms.TextBox();
            this.urlLbl2 = new System.Windows.Forms.Label();
            this.tabAbout = new System.Windows.Forms.TabPage();
            this.tyLbl = new System.Windows.Forms.Label();
            this.tyBtn = new System.Windows.Forms.Button();
            this.linkAuthorLbl = new System.Windows.Forms.LinkLabel();
            this.emailLbl = new System.Windows.Forms.Label();
            this.linkEmailLbl = new System.Windows.Forms.LinkLabel();
            this.authorLbl = new System.Windows.Forms.Label();
            this.aboutLbl = new System.Windows.Forms.Label();
            this.urlListBox = new System.Windows.Forms.ListBox();
            this.clearClipboardBtn = new System.Windows.Forms.Button();
            this.saveFileBtn = new System.Windows.Forms.Button();
            this.clearListBtn = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.tabTinyApi.SuspendLayout();
            this.tabBitlyApi.SuspendLayout();
            this.tabAbout.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabTinyApi);
            this.tabControl.Controls.Add(this.tabBitlyApi);
            this.tabControl.Controls.Add(this.tabAbout);
            this.tabControl.Location = new System.Drawing.Point(12, 4);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(387, 307);
            this.tabControl.TabIndex = 0;
            // 
            // tabTinyApi
            // 
            this.tabTinyApi.Controls.Add(this.outputBox);
            this.tabTinyApi.Controls.Add(this.urlBox);
            this.tabTinyApi.Controls.Add(this.outputLbl);
            this.tabTinyApi.Controls.Add(this.urlLbl);
            this.tabTinyApi.Controls.Add(this.copyBtn);
            this.tabTinyApi.Controls.Add(this.processBtn);
            this.tabTinyApi.Location = new System.Drawing.Point(4, 22);
            this.tabTinyApi.Name = "tabTinyApi";
            this.tabTinyApi.Padding = new System.Windows.Forms.Padding(3);
            this.tabTinyApi.Size = new System.Drawing.Size(379, 281);
            this.tabTinyApi.TabIndex = 1;
            this.tabTinyApi.Text = "Tiny Url";
            this.tabTinyApi.UseVisualStyleBackColor = true;
            // 
            // outputBox
            // 
            this.outputBox.Location = new System.Drawing.Point(54, 62);
            this.outputBox.Name = "outputBox";
            this.outputBox.ReadOnly = true;
            this.outputBox.Size = new System.Drawing.Size(207, 20);
            this.outputBox.TabIndex = 11;
            // 
            // urlBox
            // 
            this.urlBox.Location = new System.Drawing.Point(54, 3);
            this.urlBox.Name = "urlBox";
            this.urlBox.Size = new System.Drawing.Size(207, 20);
            this.urlBox.TabIndex = 10;
            // 
            // outputLbl
            // 
            this.outputLbl.AutoSize = true;
            this.outputLbl.Location = new System.Drawing.Point(6, 65);
            this.outputLbl.Name = "outputLbl";
            this.outputLbl.Size = new System.Drawing.Size(42, 13);
            this.outputLbl.TabIndex = 9;
            this.outputLbl.Text = "Output:";
            // 
            // urlLbl
            // 
            this.urlLbl.AutoSize = true;
            this.urlLbl.Location = new System.Drawing.Point(6, 6);
            this.urlLbl.Name = "urlLbl";
            this.urlLbl.Size = new System.Drawing.Size(32, 13);
            this.urlLbl.TabIndex = 8;
            this.urlLbl.Text = "URL:";
            // 
            // copyBtn
            // 
            this.copyBtn.Location = new System.Drawing.Point(9, 88);
            this.copyBtn.Name = "copyBtn";
            this.copyBtn.Size = new System.Drawing.Size(75, 23);
            this.copyBtn.TabIndex = 7;
            this.copyBtn.Text = "Copy Link";
            this.copyBtn.UseVisualStyleBackColor = true;
            this.copyBtn.Click += new System.EventHandler(this.CopyBtn_Click);
            // 
            // processBtn
            // 
            this.processBtn.Location = new System.Drawing.Point(9, 29);
            this.processBtn.Name = "processBtn";
            this.processBtn.Size = new System.Drawing.Size(75, 23);
            this.processBtn.TabIndex = 6;
            this.processBtn.Text = "Process";
            this.processBtn.UseVisualStyleBackColor = true;
            this.processBtn.Click += new System.EventHandler(this.ProcessBtn_Click);
            // 
            // tabBitlyApi
            // 
            this.tabBitlyApi.Controls.Add(this.outputBox2);
            this.tabBitlyApi.Controls.Add(this.outputLbl2);
            this.tabBitlyApi.Controls.Add(this.copyBtn2);
            this.tabBitlyApi.Controls.Add(this.processBtn2);
            this.tabBitlyApi.Controls.Add(this.urlBox2);
            this.tabBitlyApi.Controls.Add(this.urlLbl2);
            this.tabBitlyApi.Location = new System.Drawing.Point(4, 22);
            this.tabBitlyApi.Name = "tabBitlyApi";
            this.tabBitlyApi.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabBitlyApi.Size = new System.Drawing.Size(379, 281);
            this.tabBitlyApi.TabIndex = 2;
            this.tabBitlyApi.Text = "Bitly";
            this.tabBitlyApi.UseVisualStyleBackColor = true;
            // 
            // outputBox2
            // 
            this.outputBox2.Location = new System.Drawing.Point(54, 63);
            this.outputBox2.Name = "outputBox2";
            this.outputBox2.ReadOnly = true;
            this.outputBox2.Size = new System.Drawing.Size(207, 20);
            this.outputBox2.TabIndex = 16;
            // 
            // outputLbl2
            // 
            this.outputLbl2.AutoSize = true;
            this.outputLbl2.Location = new System.Drawing.Point(6, 66);
            this.outputLbl2.Name = "outputLbl2";
            this.outputLbl2.Size = new System.Drawing.Size(42, 13);
            this.outputLbl2.TabIndex = 15;
            this.outputLbl2.Text = "Output:";
            // 
            // copyBtn2
            // 
            this.copyBtn2.Location = new System.Drawing.Point(9, 89);
            this.copyBtn2.Name = "copyBtn2";
            this.copyBtn2.Size = new System.Drawing.Size(75, 23);
            this.copyBtn2.TabIndex = 14;
            this.copyBtn2.Text = "Copy Link";
            this.copyBtn2.UseVisualStyleBackColor = true;
            this.copyBtn2.Click += new System.EventHandler(this.CopyBtn2_Click);
            // 
            // processBtn2
            // 
            this.processBtn2.Location = new System.Drawing.Point(9, 29);
            this.processBtn2.Name = "processBtn2";
            this.processBtn2.Size = new System.Drawing.Size(75, 23);
            this.processBtn2.TabIndex = 13;
            this.processBtn2.Text = "Process";
            this.processBtn2.UseVisualStyleBackColor = true;
            this.processBtn2.Click += new System.EventHandler(this.ProcessBtn2_Click);
            // 
            // urlBox2
            // 
            this.urlBox2.Location = new System.Drawing.Point(54, 3);
            this.urlBox2.Name = "urlBox2";
            this.urlBox2.Size = new System.Drawing.Size(207, 20);
            this.urlBox2.TabIndex = 12;
            // 
            // urlLbl2
            // 
            this.urlLbl2.AutoSize = true;
            this.urlLbl2.Location = new System.Drawing.Point(6, 6);
            this.urlLbl2.Name = "urlLbl2";
            this.urlLbl2.Size = new System.Drawing.Size(32, 13);
            this.urlLbl2.TabIndex = 11;
            this.urlLbl2.Text = "URL:";
            // 
            // tabAbout
            // 
            this.tabAbout.Controls.Add(this.tyLbl);
            this.tabAbout.Controls.Add(this.tyBtn);
            this.tabAbout.Controls.Add(this.linkAuthorLbl);
            this.tabAbout.Controls.Add(this.emailLbl);
            this.tabAbout.Controls.Add(this.linkEmailLbl);
            this.tabAbout.Controls.Add(this.authorLbl);
            this.tabAbout.Controls.Add(this.aboutLbl);
            this.tabAbout.Location = new System.Drawing.Point(4, 22);
            this.tabAbout.Name = "tabAbout";
            this.tabAbout.Padding = new System.Windows.Forms.Padding(3);
            this.tabAbout.Size = new System.Drawing.Size(379, 281);
            this.tabAbout.TabIndex = 0;
            this.tabAbout.Text = "About";
            this.tabAbout.UseVisualStyleBackColor = true;
            // 
            // tyLbl
            // 
            this.tyLbl.AutoSize = true;
            this.tyLbl.Location = new System.Drawing.Point(15, 140);
            this.tyLbl.Name = "tyLbl";
            this.tyLbl.Size = new System.Drawing.Size(0, 13);
            this.tyLbl.TabIndex = 6;
            // 
            // tyBtn
            // 
            this.tyBtn.Location = new System.Drawing.Point(15, 110);
            this.tyBtn.Name = "tyBtn";
            this.tyBtn.Size = new System.Drawing.Size(75, 23);
            this.tyBtn.TabIndex = 5;
            this.tyBtn.Text = "Thank you";
            this.tyBtn.UseVisualStyleBackColor = true;
            this.tyBtn.Click += new System.EventHandler(this.TyBtn_Click);
            // 
            // linkAuthorLbl
            // 
            this.linkAuthorLbl.AutoSize = true;
            this.linkAuthorLbl.Location = new System.Drawing.Point(56, 41);
            this.linkAuthorLbl.Name = "linkAuthorLbl";
            this.linkAuthorLbl.Size = new System.Drawing.Size(33, 13);
            this.linkAuthorLbl.TabIndex = 4;
            this.linkAuthorLbl.TabStop = true;
            this.linkAuthorLbl.Text = "8ucik";
            this.linkAuthorLbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkAuthorLbl_LinkClicked);
            // 
            // emailLbl
            // 
            this.emailLbl.AutoSize = true;
            this.emailLbl.Location = new System.Drawing.Point(12, 66);
            this.emailLbl.Name = "emailLbl";
            this.emailLbl.Size = new System.Drawing.Size(35, 13);
            this.emailLbl.TabIndex = 3;
            this.emailLbl.Text = "Email:";
            // 
            // linkEmailLbl
            // 
            this.linkEmailLbl.AutoSize = true;
            this.linkEmailLbl.Location = new System.Drawing.Point(56, 66);
            this.linkEmailLbl.Name = "linkEmailLbl";
            this.linkEmailLbl.Size = new System.Drawing.Size(67, 13);
            this.linkEmailLbl.TabIndex = 2;
            this.linkEmailLbl.TabStop = true;
            this.linkEmailLbl.Text = "8ucik\'s email";
            this.linkEmailLbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkEmailLbl_LinkClicked);
            // 
            // authorLbl
            // 
            this.authorLbl.AutoSize = true;
            this.authorLbl.Location = new System.Drawing.Point(6, 41);
            this.authorLbl.Name = "authorLbl";
            this.authorLbl.Size = new System.Drawing.Size(41, 13);
            this.authorLbl.TabIndex = 1;
            this.authorLbl.Text = "Author:";
            // 
            // aboutLbl
            // 
            this.aboutLbl.AutoSize = true;
            this.aboutLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.aboutLbl.Location = new System.Drawing.Point(6, 14);
            this.aboutLbl.Name = "aboutLbl";
            this.aboutLbl.Size = new System.Drawing.Size(114, 17);
            this.aboutLbl.TabIndex = 0;
            this.aboutLbl.Text = "About the author";
            // 
            // urlListBox
            // 
            this.urlListBox.FormattingEnabled = true;
            this.urlListBox.HorizontalScrollbar = true;
            this.urlListBox.Location = new System.Drawing.Point(405, 26);
            this.urlListBox.MultiColumn = true;
            this.urlListBox.Name = "urlListBox";
            this.urlListBox.Size = new System.Drawing.Size(387, 238);
            this.urlListBox.TabIndex = 1;
            this.urlListBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.UrlListBox_KeyDown);
            // 
            // clearClipboardBtn
            // 
            this.clearClipboardBtn.Location = new System.Drawing.Point(406, 271);
            this.clearClipboardBtn.Name = "clearClipboardBtn";
            this.clearClipboardBtn.Size = new System.Drawing.Size(75, 40);
            this.clearClipboardBtn.TabIndex = 2;
            this.clearClipboardBtn.Text = "Clear clipboard";
            this.clearClipboardBtn.UseVisualStyleBackColor = true;
            this.clearClipboardBtn.Click += new System.EventHandler(this.ClearClipboardBtn_Click);
            // 
            // saveFileBtn
            // 
            this.saveFileBtn.Location = new System.Drawing.Point(568, 271);
            this.saveFileBtn.Name = "saveFileBtn";
            this.saveFileBtn.Size = new System.Drawing.Size(75, 40);
            this.saveFileBtn.TabIndex = 3;
            this.saveFileBtn.Text = "Save list to file";
            this.saveFileBtn.UseVisualStyleBackColor = true;
            this.saveFileBtn.Click += new System.EventHandler(this.SaveFileBtn_Click);
            // 
            // clearListBtn
            // 
            this.clearListBtn.Location = new System.Drawing.Point(487, 271);
            this.clearListBtn.Name = "clearListBtn";
            this.clearListBtn.Size = new System.Drawing.Size(75, 40);
            this.clearListBtn.TabIndex = 4;
            this.clearListBtn.Text = "Clear list";
            this.clearListBtn.UseVisualStyleBackColor = true;
            this.clearListBtn.Click += new System.EventHandler(this.ClearListBtn_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 330);
            this.Controls.Add(this.clearListBtn);
            this.Controls.Add(this.saveFileBtn);
            this.Controls.Add(this.clearClipboardBtn);
            this.Controls.Add(this.urlListBox);
            this.Controls.Add(this.tabControl);
            this.Name = "Main";
            this.Text = "Main";
            this.tabControl.ResumeLayout(false);
            this.tabTinyApi.ResumeLayout(false);
            this.tabTinyApi.PerformLayout();
            this.tabBitlyApi.ResumeLayout(false);
            this.tabBitlyApi.PerformLayout();
            this.tabAbout.ResumeLayout(false);
            this.tabAbout.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabAbout;
        private System.Windows.Forms.TabPage tabBitlyApi;
        private System.Windows.Forms.TabPage tabTinyApi;
        private System.Windows.Forms.TextBox outputBox;
        private System.Windows.Forms.TextBox urlBox;
        private System.Windows.Forms.Label outputLbl;
        private System.Windows.Forms.Label urlLbl;
        private System.Windows.Forms.Button copyBtn;
        private System.Windows.Forms.Button processBtn;
        private System.Windows.Forms.Label aboutLbl;
        private System.Windows.Forms.LinkLabel linkEmailLbl;
        private System.Windows.Forms.Label emailLbl;
        private System.Windows.Forms.Label authorLbl;
        private System.Windows.Forms.LinkLabel linkAuthorLbl;
        private System.Windows.Forms.Button tyBtn;
        private System.Windows.Forms.Label tyLbl;
        private System.Windows.Forms.TextBox urlBox2;
        private System.Windows.Forms.Label urlLbl2;
        private System.Windows.Forms.TextBox outputBox2;
        private System.Windows.Forms.Label outputLbl2;
        private System.Windows.Forms.Button copyBtn2;
        private System.Windows.Forms.Button processBtn2;
        private System.Windows.Forms.ListBox urlListBox;
        private System.Windows.Forms.Button clearClipboardBtn;
        private System.Windows.Forms.Button saveFileBtn;
        private System.Windows.Forms.Button clearListBtn;
    }
}