namespace Client
{
    partial class RegisterForm
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
            this.btnOkReg = new System.Windows.Forms.Button();
            this.tbPasswordReg = new System.Windows.Forms.TextBox();
            this.tbNameReg = new System.Windows.Forms.TextBox();
            this.tbLoginReg = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOkReg
            // 
            this.btnOkReg.Location = new System.Drawing.Point(142, 112);
            this.btnOkReg.Name = "btnOkReg";
            this.btnOkReg.Size = new System.Drawing.Size(100, 23);
            this.btnOkReg.TabIndex = 0;
            this.btnOkReg.Text = "Ok";
            this.btnOkReg.UseVisualStyleBackColor = true;
            this.btnOkReg.Click += new System.EventHandler(this.btnOkReg_Click);
            // 
            // tbPasswordReg
            // 
            this.tbPasswordReg.Location = new System.Drawing.Point(71, 73);
            this.tbPasswordReg.Name = "tbPasswordReg";
            this.tbPasswordReg.PasswordChar = '*';
            this.tbPasswordReg.Size = new System.Drawing.Size(171, 20);
            this.tbPasswordReg.TabIndex = 2;
            this.tbPasswordReg.UseSystemPasswordChar = true;
            // 
            // tbNameReg
            // 
            this.tbNameReg.Location = new System.Drawing.Point(71, 46);
            this.tbNameReg.Name = "tbNameReg";
            this.tbNameReg.Size = new System.Drawing.Size(171, 20);
            this.tbNameReg.TabIndex = 3;
            // 
            // tbLoginReg
            // 
            this.tbLoginReg.Location = new System.Drawing.Point(71, 18);
            this.tbLoginReg.Name = "tbLoginReg";
            this.tbLoginReg.Size = new System.Drawing.Size(171, 20);
            this.tbLoginReg.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Password";
            // 
            // RegisterForm
            // 
            this.AcceptButton = this.btnOkReg;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 147);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbLoginReg);
            this.Controls.Add(this.tbNameReg);
            this.Controls.Add(this.tbPasswordReg);
            this.Controls.Add(this.btnOkReg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(270, 185);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(270, 185);
            this.Name = "RegisterForm";
            this.Text = "RegisterForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOkReg;
        private System.Windows.Forms.TextBox tbPasswordReg;
        private System.Windows.Forms.TextBox tbNameReg;
        private System.Windows.Forms.TextBox tbLoginReg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}