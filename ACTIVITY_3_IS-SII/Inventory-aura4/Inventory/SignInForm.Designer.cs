namespace Inventory
{
    partial class SignInForm
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
            this.v = new System.Windows.Forms.Panel();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.lblReEnterPass = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lnkSignIn = new System.Windows.Forms.LinkLabel();
            this.btnRegister = new System.Windows.Forms.Button();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtFullname = new System.Windows.Forms.TextBox();
            this.lblFullname = new System.Windows.Forms.Label();
            this.lblCreateAccount = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.lblTagline = new System.Windows.Forms.Label();
            this.lblSystemName3 = new System.Windows.Forms.Label();
            this.lblSystemName2 = new System.Windows.Forms.Label();
            this.lblSystemName1 = new System.Windows.Forms.Label();
            this.v.SuspendLayout();
            this.panelLeft.SuspendLayout();
            this.SuspendLayout();
            // 
            // v
            // 
            this.v.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(240)))), ((int)(((byte)(246)))));
            this.v.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.v.Controls.Add(this.txtConfirmPassword);
            this.v.Controls.Add(this.lblReEnterPass);
            this.v.Controls.Add(this.txtPassword);
            this.v.Controls.Add(this.lblPassword);
            this.v.Controls.Add(this.lnkSignIn);
            this.v.Controls.Add(this.btnRegister);
            this.v.Controls.Add(this.txtUsername);
            this.v.Controls.Add(this.lblUsername);
            this.v.Controls.Add(this.txtFullname);
            this.v.Controls.Add(this.lblFullname);
            this.v.Controls.Add(this.lblCreateAccount);
            this.v.Controls.Add(this.label1);
            this.v.Location = new System.Drawing.Point(30, 39);
            this.v.Name = "v";
            this.v.Size = new System.Drawing.Size(541, 572);
            this.v.TabIndex = 6;
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Location = new System.Drawing.Point(34, 412);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.Size = new System.Drawing.Size(477, 22);
            this.txtConfirmPassword.TabIndex = 12;
            // 
            // lblReEnterPass
            // 
            this.lblReEnterPass.AutoSize = true;
            this.lblReEnterPass.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReEnterPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(51)))), ((int)(((byte)(132)))));
            this.lblReEnterPass.Location = new System.Drawing.Point(30, 383);
            this.lblReEnterPass.Name = "lblReEnterPass";
            this.lblReEnterPass.Size = new System.Drawing.Size(228, 26);
            this.lblReEnterPass.TabIndex = 11;
            this.lblReEnterPass.Text = "Re-enter Password:";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(34, 336);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(477, 22);
            this.txtPassword.TabIndex = 10;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(51)))), ((int)(((byte)(132)))));
            this.lblPassword.Location = new System.Drawing.Point(29, 307);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(123, 26);
            this.lblPassword.TabIndex = 9;
            this.lblPassword.Text = "Password:";
            // 
            // lnkSignIn
            // 
            this.lnkSignIn.AutoSize = true;
            this.lnkSignIn.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkSignIn.LinkColor = System.Drawing.Color.Blue;
            this.lnkSignIn.Location = new System.Drawing.Point(118, 534);
            this.lnkSignIn.Name = "lnkSignIn";
            this.lnkSignIn.Size = new System.Drawing.Size(295, 18);
            this.lnkSignIn.TabIndex = 8;
            this.lnkSignIn.TabStop = true;
            this.lnkSignIn.Text = "Already have an account? Sign in here.";
            this.lnkSignIn.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkCreateAccount_LinkClicked);
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(98)))), ((int)(((byte)(146)))));
            this.btnRegister.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(24)))), ((int)(((byte)(91)))));
            this.btnRegister.FlatAppearance.BorderSize = 2;
            this.btnRegister.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(24)))), ((int)(((byte)(91)))));
            this.btnRegister.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(20)))), ((int)(((byte)(87)))));
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.Font = new System.Drawing.Font("MS PGothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(235)))));
            this.btnRegister.Location = new System.Drawing.Point(90, 462);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(354, 50);
            this.btnRegister.TabIndex = 7;
            this.btnRegister.Text = "REGISTER";
            this.btnRegister.UseVisualStyleBackColor = false;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(34, 256);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(477, 22);
            this.txtUsername.TabIndex = 6;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(51)))), ((int)(((byte)(132)))));
            this.lblUsername.Location = new System.Drawing.Point(29, 227);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(132, 26);
            this.lblUsername.TabIndex = 5;
            this.lblUsername.Text = "Username:";
            // 
            // txtFullname
            // 
            this.txtFullname.Location = new System.Drawing.Point(35, 176);
            this.txtFullname.Name = "txtFullname";
            this.txtFullname.Size = new System.Drawing.Size(477, 22);
            this.txtFullname.TabIndex = 4;
            // 
            // lblFullname
            // 
            this.lblFullname.AutoSize = true;
            this.lblFullname.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFullname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(51)))), ((int)(((byte)(132)))));
            this.lblFullname.Location = new System.Drawing.Point(29, 147);
            this.lblFullname.Name = "lblFullname";
            this.lblFullname.Size = new System.Drawing.Size(133, 26);
            this.lblFullname.TabIndex = 3;
            this.lblFullname.Text = "Full Name:";
            // 
            // lblCreateAccount
            // 
            this.lblCreateAccount.AutoSize = true;
            this.lblCreateAccount.Font = new System.Drawing.Font("Showcard Gothic", 22.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreateAccount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(98)))), ((int)(((byte)(146)))));
            this.lblCreateAccount.Location = new System.Drawing.Point(28, 15);
            this.lblCreateAccount.Name = "lblCreateAccount";
            this.lblCreateAccount.Size = new System.Drawing.Size(483, 49);
            this.lblCreateAccount.TabIndex = 1;
            this.lblCreateAccount.Text = "Create Your Account";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(24)))), ((int)(((byte)(91)))));
            this.label1.Location = new System.Drawing.Point(76, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(380, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "Please register your account.";
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(24)))), ((int)(((byte)(91)))));
            this.panelLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelLeft.Controls.Add(this.lblTagline);
            this.panelLeft.Controls.Add(this.lblSystemName3);
            this.panelLeft.Controls.Add(this.lblSystemName2);
            this.panelLeft.Controls.Add(this.lblSystemName1);
            this.panelLeft.Location = new System.Drawing.Point(590, 39);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(458, 572);
            this.panelLeft.TabIndex = 7;
            // 
            // lblTagline
            // 
            this.lblTagline.AutoSize = true;
            this.lblTagline.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblTagline.Font = new System.Drawing.Font("Franklin Gothic Demi", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTagline.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(228)))), ((int)(((byte)(236)))));
            this.lblTagline.Location = new System.Drawing.Point(65, 405);
            this.lblTagline.Name = "lblTagline";
            this.lblTagline.Size = new System.Drawing.Size(323, 29);
            this.lblTagline.TabIndex = 3;
            this.lblTagline.Text = "Manage. Organize. Keep Track.";
            this.lblTagline.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSystemName3
            // 
            this.lblSystemName3.AutoSize = true;
            this.lblSystemName3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblSystemName3.Font = new System.Drawing.Font("Forte", 34.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSystemName3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(228)))), ((int)(((byte)(240)))));
            this.lblSystemName3.Location = new System.Drawing.Point(123, 247);
            this.lblSystemName3.Name = "lblSystemName3";
            this.lblSystemName3.Size = new System.Drawing.Size(208, 63);
            this.lblSystemName3.TabIndex = 2;
            this.lblSystemName3.Text = "System";
            this.lblSystemName3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSystemName2
            // 
            this.lblSystemName2.AutoSize = true;
            this.lblSystemName2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblSystemName2.Font = new System.Drawing.Font("Forte", 34.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSystemName2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(228)))), ((int)(((byte)(240)))));
            this.lblSystemName2.Location = new System.Drawing.Point(43, 159);
            this.lblSystemName2.Name = "lblSystemName2";
            this.lblSystemName2.Size = new System.Drawing.Size(371, 63);
            this.lblSystemName2.TabIndex = 1;
            this.lblSystemName2.Text = "Management";
            this.lblSystemName2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSystemName1
            // 
            this.lblSystemName1.AutoSize = true;
            this.lblSystemName1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblSystemName1.Font = new System.Drawing.Font("Forte", 34.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSystemName1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(228)))), ((int)(((byte)(240)))));
            this.lblSystemName1.Location = new System.Drawing.Point(88, 85);
            this.lblSystemName1.Name = "lblSystemName1";
            this.lblSystemName1.Size = new System.Drawing.Size(279, 63);
            this.lblSystemName1.TabIndex = 0;
            this.lblSystemName1.Text = "Inventory";
            this.lblSystemName1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSystemName1.Click += new System.EventHandler(this.lblSystemName1_Click);
            // 
            // SignInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1081, 646);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.v);
            this.Name = "SignInForm";
            this.Text = "SignInForm";
            this.Load += new System.EventHandler(this.SignInForm_Load);
            this.v.ResumeLayout(false);
            this.v.PerformLayout();
            this.panelLeft.ResumeLayout(false);
            this.panelLeft.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel v;
        private System.Windows.Forms.LinkLabel lnkSignIn;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtFullname;
        private System.Windows.Forms.Label lblFullname;
        private System.Windows.Forms.Label lblCreateAccount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Label lblTagline;
        private System.Windows.Forms.Label lblSystemName3;
        private System.Windows.Forms.Label lblSystemName2;
        private System.Windows.Forms.Label lblSystemName1;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblReEnterPass;
        private System.Windows.Forms.TextBox txtConfirmPassword;
    }
}