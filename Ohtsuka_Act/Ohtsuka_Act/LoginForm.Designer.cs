namespace Ohtsuka_Act
{
    partial class LoginForm
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
            lblTitle = new Label();
            lblWelcome = new Label();
            lblSubtitle = new Label();
            lblUsername = new Label();
            txtUsername = new TextBox();
            lblPassword = new Label();
            txtPassword = new TextBox();
            chkShowPassword = new CheckBox();
            btnLogin = new Button();
            lblNoAccount = new Label();
            linkLabel1 = new LinkLabel();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 18F);
            lblTitle.ForeColor = Color.MidnightBlue;
            lblTitle.Location = new Point(330, 55);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(233, 32);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "INVENTORY SYSTEM";
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWelcome.ForeColor = Color.MidnightBlue;
            lblWelcome.Location = new Point(310, 130);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(280, 45);
            lblWelcome.TabIndex = 1;
            lblWelcome.Text = "WELCOME BACK!";
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.ForeColor = Color.SlateGray;
            lblSubtitle.Location = new Point(350, 175);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(186, 19);
            lblSubtitle.TabIndex = 2;
            lblSubtitle.Text = "Login to access your account";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsername.ForeColor = Color.DarkSlateGray;
            lblUsername.Location = new Point(285, 230);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(73, 17);
            lblUsername.TabIndex = 3;
            lblUsername.Text = "Username:";
            lblUsername.Click += label4_Click;
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.AliceBlue;
            txtUsername.BorderStyle = BorderStyle.FixedSingle;
            txtUsername.Location = new Point(270, 255);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(350, 25);
            txtUsername.TabIndex = 4;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPassword.ForeColor = Color.DarkSlateGray;
            lblPassword.Location = new Point(285, 305);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(66, 17);
            lblPassword.TabIndex = 5;
            lblPassword.Text = "Password";
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.AliceBlue;
            txtPassword.Location = new Point(270, 330);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(350, 25);
            txtPassword.TabIndex = 6;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // chkShowPassword
            // 
            chkShowPassword.AutoSize = true;
            chkShowPassword.ForeColor = Color.DimGray;
            chkShowPassword.Location = new Point(285, 365);
            chkShowPassword.Name = "chkShowPassword";
            chkShowPassword.Size = new Size(122, 23);
            chkShowPassword.TabIndex = 7;
            chkShowPassword.Text = "show password";
            chkShowPassword.UseVisualStyleBackColor = true;
            chkShowPassword.CheckedChanged += chkShowPassword_CheckedChanged;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.MidnightBlue;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(270, 400);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(350, 45);
            btnLogin.TabIndex = 8;
            btnLogin.Text = "LOG IN";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // lblNoAccount
            // 
            lblNoAccount.AutoSize = true;
            lblNoAccount.ForeColor = Color.SlateGray;
            lblNoAccount.Location = new Point(370, 450);
            lblNoAccount.Name = "lblNoAccount";
            lblNoAccount.Size = new Size(150, 19);
            lblNoAccount.TabIndex = 9;
            lblNoAccount.Text = "Dont have an account?";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.LinkColor = Color.RoyalBlue;
            linkLabel1.Location = new Point(415, 475);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(57, 19);
            linkLabel1.TabIndex = 10;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Sign Up";
            linkLabel1.LinkClicked += lnkSignUp_LinkClicked;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 511);
            Controls.Add(linkLabel1);
            Controls.Add(lblNoAccount);
            Controls.Add(btnLogin);
            Controls.Add(chkShowPassword);
            Controls.Add(txtPassword);
            Controls.Add(lblPassword);
            Controls.Add(txtUsername);
            Controls.Add(lblUsername);
            Controls.Add(lblSubtitle);
            Controls.Add(lblWelcome);
            Controls.Add(lblTitle);
            Font = new Font("Segoe UI", 10F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inventory System - Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblWelcome;
        private Label lblSubtitle;
        private Label lblUsername;
        private TextBox txtUsername;
        private Label lblPassword;
        private TextBox txtPassword;
        private CheckBox chkShowPassword;
        private Button btnLogin;
        private Label lblNoAccount;
        private LinkLabel linkLabel1;
    }
}