namespace Client
{
    partial class MainForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbLogin = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.tbText = new System.Windows.Forms.TextBox();
            this.tbMonitor = new System.Windows.Forms.TextBox();
            this.bwMessageLoader = new System.ComponentModel.BackgroundWorker();
            this.lbFriendList = new System.Windows.Forms.ListBox();
            this.bwUsersLoader = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Login";
            // 
            // tbLogin
            // 
            this.tbLogin.Location = new System.Drawing.Point(16, 25);
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Size = new System.Drawing.Size(100, 20);
            this.tbLogin.TabIndex = 2;
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(16, 64);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(100, 20);
            this.tbPassword.TabIndex = 3;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(16, 90);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(100, 23);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(16, 128);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(100, 23);
            this.btnRegister.TabIndex = 5;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnSend
            // 
            this.btnSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSend.Location = new System.Drawing.Point(756, 429);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 6;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // tbText
            // 
            this.tbText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbText.Location = new System.Drawing.Point(16, 429);
            this.tbText.Name = "tbText";
            this.tbText.Size = new System.Drawing.Size(734, 20);
            this.tbText.TabIndex = 7;
            // 
            // tbMonitor
            // 
            this.tbMonitor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbMonitor.Location = new System.Drawing.Point(258, 12);
            this.tbMonitor.Multiline = true;
            this.tbMonitor.Name = "tbMonitor";
            this.tbMonitor.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbMonitor.Size = new System.Drawing.Size(573, 400);
            this.tbMonitor.TabIndex = 8;
            // 
            // bwMessageLoader
            // 
            this.bwMessageLoader.WorkerSupportsCancellation = true;
            this.bwMessageLoader.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bWorker_DoWork);
            // 
            // lbFriendList
            // 
            this.lbFriendList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbFriendList.FormattingEnabled = true;
            this.lbFriendList.Location = new System.Drawing.Point(16, 158);
            this.lbFriendList.Name = "lbFriendList";
            this.lbFriendList.Size = new System.Drawing.Size(236, 251);
            this.lbFriendList.TabIndex = 9;
            this.lbFriendList.DoubleClick += new System.EventHandler(this.lbFriendList_DoubleClick);
            // 
            // bwUsersLoader
            // 
            this.bwUsersLoader.WorkerSupportsCancellation = true;
            this.bwUsersLoader.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwUsersLoader_DoWork);
            // 
            // MainForm
            // 
            this.AcceptButton = this.btnLogin;
            this.ClientSize = new System.Drawing.Size(852, 476);
            this.Controls.Add(this.lbFriendList);
            this.Controls.Add(this.tbMonitor);
            this.Controls.Add(this.tbText);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbLogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbLogin;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox tbText;
        private System.Windows.Forms.TextBox tbMonitor;
        private System.ComponentModel.BackgroundWorker bwMessageLoader;
        private System.Windows.Forms.ListBox lbFriendList;
        private System.ComponentModel.BackgroundWorker bwUsersLoader;
    }
}

