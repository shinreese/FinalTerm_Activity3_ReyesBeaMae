namespace Inventory
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
            this.lblWelcomeBack = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelRight = new System.Windows.Forms.Panel();
            this.lnkCreateAccount = new System.Windows.Forms.LinkLabel();
            this.btnSignIn = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.lblTagline = new System.Windows.Forms.Label();
            this.lblSystemName3 = new System.Windows.Forms.Label();
            this.lblSystemName2 = new System.Windows.Forms.Label();
            this.lblSystemName1 = new System.Windows.Forms.Label();
            this.panelRight.SuspendLayout();
            this.panelLeft.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblWelcomeBack
            // 
            this.lblWelcomeBack.AutoSize = true;
            this.lblWelcomeBack.Font = new System.Drawing.Font("Showcard Gothic", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcomeBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(98)))), ((int)(((byte)(146)))));
            this.lblWelcomeBack.Location = new System.Drawing.Point(65, 15);
            this.lblWelcomeBack.Name = "lblWelcomeBack";
            this.lblWelcomeBack.Size = new System.Drawing.Size(414, 59);
            this.lblWelcomeBack.TabIndex = 1;
            this.lblWelcomeBack.Text = "WELCOME BACK!";
            this.lblWelcomeBack.Click += new System.EventHandler(this.lblWelcomeBack_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(24)))), ((int)(((byte)(91)))));
            this.label1.Location = new System.Drawing.Point(70, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(408, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "Please Sign In to your account.";
            // 
            // panelRight
            // 
            this.panelRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(240)))), ((int)(((byte)(246)))));
            this.panelRight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelRight.Controls.Add(this.lnkCreateAccount);
            this.panelRight.Controls.Add(this.btnSignIn);
            this.panelRight.Controls.Add(this.txtPassword);
            this.panelRight.Controls.Add(this.lblPassword);
            this.panelRight.Controls.Add(this.txtUsername);
            this.panelRight.Controls.Add(this.lblUsername);
            this.panelRight.Controls.Add(this.lblWelcomeBack);
            this.panelRight.Controls.Add(this.label1);
            this.panelRight.Location = new System.Drawing.Point(495, 23);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(541, 486);
            this.panelRight.TabIndex = 5;
            // 
            // lnkCreateAccount
            // 
            this.lnkCreateAccount.AutoSize = true;
            this.lnkCreateAccount.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkCreateAccount.Location = new System.Drawing.Point(124, 450);
            this.lnkCreateAccount.Name = "lnkCreateAccount";
            this.lnkCreateAccount.Size = new System.Drawing.Size(292, 18);
            this.lnkCreateAccount.TabIndex = 8;
            this.lnkCreateAccount.TabStop = true;
            this.lnkCreateAccount.Text = "Don\'t have an account? Register here.";
            // 
            // btnSignIn
            // 
            this.btnSignIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(98)))), ((int)(((byte)(146)))));
            this.btnSignIn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(24)))), ((int)(((byte)(91)))));
            this.btnSignIn.FlatAppearance.BorderSize = 2;
            this.btnSignIn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(24)))), ((int)(((byte)(91)))));
            this.btnSignIn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(20)))), ((int)(((byte)(87)))));
            this.btnSignIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignIn.Font = new System.Drawing.Font("MS PGothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignIn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(235)))));
            this.btnSignIn.Location = new System.Drawing.Point(95, 362);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Size = new System.Drawing.Size(354, 50);
            this.btnSignIn.TabIndex = 7;
            this.btnSignIn.Text = "SIGN IN";
            this.btnSignIn.UseVisualStyleBackColor = false;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(34, 297);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(477, 22);
            this.txtPassword.TabIndex = 6;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("MS Reference Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(51)))), ((int)(((byte)(132)))));
            this.lblPassword.Location = new System.Drawing.Point(29, 256);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(140, 28);
            this.lblPassword.TabIndex = 5;
            this.lblPassword.Text = "Password:";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(34, 189);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(477, 22);
            this.txtUsername.TabIndex = 4;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("MS Reference Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(51)))), ((int)(((byte)(132)))));
            this.lblUsername.Location = new System.Drawing.Point(29, 147);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(149, 28);
            this.lblUsername.TabIndex = 3;
            this.lblUsername.Text = "Username:";
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(24)))), ((int)(((byte)(91)))));
            this.panelLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelLeft.Controls.Add(this.lblTagline);
            this.panelLeft.Controls.Add(this.lblSystemName3);
            this.panelLeft.Controls.Add(this.lblSystemName2);
            this.panelLeft.Controls.Add(this.lblSystemName1);
            this.panelLeft.Location = new System.Drawing.Point(22, 23);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(458, 486);
            this.panelLeft.TabIndex = 6;
            // 
            // lblTagline
            // 
            this.lblTagline.AutoSize = true;
            this.lblTagline.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblTagline.Font = new System.Drawing.Font("Franklin Gothic Demi", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTagline.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(228)))), ((int)(((byte)(236)))));
            this.lblTagline.Location = new System.Drawing.Point(62, 383);
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
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1063, 557);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.panelRight);
            this.Name = "RegisterForm";
            this.Text = "Form1";
            this.panelRight.ResumeLayout(false);
            this.panelRight.PerformLayout();
            this.panelLeft.ResumeLayout(false);
            this.panelLeft.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblWelcomeBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Label lblTagline;
        private System.Windows.Forms.Label lblSystemName3;
        private System.Windows.Forms.Label lblSystemName2;
        private System.Windows.Forms.Label lblSystemName1;
        private System.Windows.Forms.Button btnSignIn;
        private System.Windows.Forms.LinkLabel lnkCreateAccount;
    }
}

