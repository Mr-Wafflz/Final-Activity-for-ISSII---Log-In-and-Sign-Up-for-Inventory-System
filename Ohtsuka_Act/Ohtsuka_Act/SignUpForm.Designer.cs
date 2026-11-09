namespace Ohtsuka_Act
{
    partial class SignUpForm
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
            lnkLogin = new LinkLabel();
            lblFullname = new Label();
            lblUsername = new Label();
            lblEmail = new Label();
            lblPassword = new Label();
            lblConfirmPassword = new Label();
            lblHaveAccount = new Label();
            txtUsername = new TextBox();
            txtFullName = new TextBox();
            txtEmail = new TextBox();
            txtConfirmPassword = new TextBox();
            txtPassword = new TextBox();
            chkShowPassword = new CheckBox();
            btnRegister = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.MidnightBlue;
            lblTitle.Location = new Point(350, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(213, 32);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Inventory System";
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWelcome.ForeColor = Color.MidnightBlue;
            lblWelcome.Location = new Point(295, 55);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(330, 45);
            lblWelcome.TabIndex = 1;
            lblWelcome.Text = "Create your account!";
            lblWelcome.Click += label2_Click;
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.ForeColor = Color.SlateGray;
            lblSubtitle.Location = new Point(385, 110);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(143, 17);
            lblSubtitle.TabIndex = 2;
            lblSubtitle.Text = "Register to get started.";
            // 
            // lnkLogin
            // 
            lnkLogin.AutoSize = true;
            lnkLogin.LinkColor = Color.RoyalBlue;
            lnkLogin.Location = new Point(435, 475);
            lnkLogin.Name = "lnkLogin";
            lnkLogin.Size = new Size(44, 17);
            lnkLogin.TabIndex = 3;
            lnkLogin.TabStop = true;
            lnkLogin.Text = "Log In";
            lnkLogin.LinkClicked += lnkLogin_LinkClicked;
            // 
            // lblFullname
            // 
            lblFullname.AutoSize = true;
            lblFullname.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            lblFullname.ForeColor = Color.DarkSlateGray;
            lblFullname.Location = new Point(285, 120);
            lblFullname.Name = "lblFullname";
            lblFullname.Size = new Size(69, 17);
            lblFullname.TabIndex = 4;
            lblFullname.Text = "Fullname:";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            lblUsername.ForeColor = Color.DarkSlateGray;
            lblUsername.Location = new Point(285, 170);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(73, 17);
            lblUsername.TabIndex = 5;
            lblUsername.Text = "Username:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            lblEmail.ForeColor = Color.DarkSlateGray;
            lblEmail.Location = new Point(285, 220);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(46, 17);
            lblEmail.TabIndex = 6;
            lblEmail.Text = "Email:";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            lblPassword.ForeColor = Color.DarkSlateGray;
            lblPassword.Location = new Point(285, 270);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(70, 17);
            lblPassword.TabIndex = 7;
            lblPassword.Text = "Password:";
            // 
            // lblConfirmPassword
            // 
            lblConfirmPassword.AutoSize = true;
            lblConfirmPassword.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            lblConfirmPassword.ForeColor = Color.DarkSlateGray;
            lblConfirmPassword.Location = new Point(285, 320);
            lblConfirmPassword.Name = "lblConfirmPassword";
            lblConfirmPassword.Size = new Size(124, 17);
            lblConfirmPassword.TabIndex = 8;
            lblConfirmPassword.Text = "Confirm Password:";
            // 
            // lblHaveAccount
            // 
            lblHaveAccount.AutoSize = true;
            lblHaveAccount.ForeColor = Color.SlateGray;
            lblHaveAccount.Location = new Point(380, 455);
            lblHaveAccount.Name = "lblHaveAccount";
            lblHaveAccount.Size = new Size(156, 17);
            lblHaveAccount.TabIndex = 9;
            lblHaveAccount.Text = "Already have an account?";
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.AliceBlue;
            txtUsername.BorderStyle = BorderStyle.FixedSingle;
            txtUsername.Font = new Font("Segoe UI", 11.25F);
            txtUsername.Location = new Point(280, 190);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(350, 27);
            txtUsername.TabIndex = 10;
            // 
            // txtFullName
            // 
            txtFullName.BackColor = Color.AliceBlue;
            txtFullName.BorderStyle = BorderStyle.FixedSingle;
            txtFullName.Font = new Font("Segoe UI", 11.25F);
            txtFullName.Location = new Point(280, 140);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(350, 27);
            txtFullName.TabIndex = 11;
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.AliceBlue;
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Font = new Font("Segoe UI", 11.25F);
            txtEmail.Location = new Point(280, 240);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(350, 27);
            txtEmail.TabIndex = 12;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.BackColor = Color.AliceBlue;
            txtConfirmPassword.BorderStyle = BorderStyle.FixedSingle;
            txtConfirmPassword.Font = new Font("Segoe UI", 11.25F);
            txtConfirmPassword.Location = new Point(280, 340);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.Size = new Size(350, 27);
            txtConfirmPassword.TabIndex = 13;
            txtConfirmPassword.UseSystemPasswordChar = true;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.AliceBlue;
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Font = new Font("Segoe UI", 11.25F);
            txtPassword.Location = new Point(280, 290);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(350, 27);
            txtPassword.TabIndex = 14;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // chkShowPassword
            // 
            chkShowPassword.AutoSize = true;
            chkShowPassword.ForeColor = Color.DimGray;
            chkShowPassword.Location = new Point(285, 373);
            chkShowPassword.Name = "chkShowPassword";
            chkShowPassword.Size = new Size(118, 21);
            chkShowPassword.TabIndex = 15;
            chkShowPassword.Text = "show password";
            chkShowPassword.UseVisualStyleBackColor = true;
            chkShowPassword.CheckedChanged += chkShowPassword_CheckedChanged;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.MidnightBlue;
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegister.ForeColor = Color.White;
            btnRegister.Location = new Point(305, 405);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(300, 40);
            btnRegister.TabIndex = 16;
            btnRegister.Text = "REGISTER";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // SignUpForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 511);
            Controls.Add(btnRegister);
            Controls.Add(chkShowPassword);
            Controls.Add(txtPassword);
            Controls.Add(txtConfirmPassword);
            Controls.Add(txtEmail);
            Controls.Add(txtFullName);
            Controls.Add(txtUsername);
            Controls.Add(lblHaveAccount);
            Controls.Add(lblConfirmPassword);
            Controls.Add(lblPassword);
            Controls.Add(lblEmail);
            Controls.Add(lblUsername);
            Controls.Add(lblFullname);
            Controls.Add(lnkLogin);
            Controls.Add(lblSubtitle);
            Controls.Add(lblWelcome);
            Controls.Add(lblTitle);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "SignUpForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inventory System - Sign Up";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblWelcome;
        private Label lblSubtitle;
        private LinkLabel lnkLogin;
        private Label lblFullname;
        private Label lblUsername;
        private Label lblEmail;
        private Label lblPassword;
        private Label lblConfirmPassword;
        private Label lblHaveAccount;
        private TextBox txtUsername;
        private TextBox txtFullName;
        private TextBox txtEmail;
        private TextBox txtConfirmPassword;
        private TextBox txtPassword;
        private CheckBox chkShowPassword;
        private Button btnRegister;
    }
}