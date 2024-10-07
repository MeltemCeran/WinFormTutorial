namespace KutuphaneUygulaması
{
    partial class LoginPage
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
            gBoxLoginPage = new GroupBox();
            btnClose = new Button();
            btnSingUp = new Button();
            btnLogin = new Button();
            btnShowHidePassword = new Button();
            txtPassword = new TextBox();
            txtUserName = new TextBox();
            gBoxLoginPage.SuspendLayout();
            SuspendLayout();
            // 
            // gBoxLoginPage
            // 
            gBoxLoginPage.BackColor = Color.Transparent;
            gBoxLoginPage.Controls.Add(btnClose);
            gBoxLoginPage.Controls.Add(btnSingUp);
            gBoxLoginPage.Controls.Add(btnLogin);
            gBoxLoginPage.Controls.Add(btnShowHidePassword);
            gBoxLoginPage.Controls.Add(txtPassword);
            gBoxLoginPage.Controls.Add(txtUserName);
            gBoxLoginPage.Location = new Point(12, 12);
            gBoxLoginPage.Name = "gBoxLoginPage";
            gBoxLoginPage.Size = new Size(390, 127);
            gBoxLoginPage.TabIndex = 0;
            gBoxLoginPage.TabStop = false;
            gBoxLoginPage.Text = "Login Page";
            // 
            // btnClose
            // 
            btnClose.Image = Properties.Resources.close;
            btnClose.Location = new Point(366, 9);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(24, 24);
            btnClose.TabIndex = 5;
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnSingUp
            // 
            btnSingUp.BackColor = Color.LightSeaGreen;
            btnSingUp.FlatStyle = FlatStyle.Flat;
            btnSingUp.ForeColor = Color.WhiteSmoke;
            btnSingUp.Location = new Point(86, 80);
            btnSingUp.Name = "btnSingUp";
            btnSingUp.Size = new Size(75, 23);
            btnSingUp.TabIndex = 4;
            btnSingUp.Text = "SING UP";
            btnSingUp.UseVisualStyleBackColor = false;
            btnSingUp.Click += btnSingUp_Click;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.YellowGreen;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.ForeColor = Color.WhiteSmoke;
            btnLogin.Location = new Point(8, 80);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(75, 23);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "LOGIN";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnShowHidePassword
            // 
            btnShowHidePassword.Image = Properties.Resources.visible1;
            btnShowHidePassword.Location = new Point(196, 51);
            btnShowHidePassword.Name = "btnShowHidePassword";
            btnShowHidePassword.Size = new Size(32, 23);
            btnShowHidePassword.TabIndex = 2;
            btnShowHidePassword.UseVisualStyleBackColor = true;
            btnShowHidePassword.Click += btnShowHidePassword_Click;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(6, 51);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.PlaceholderText = "Password";
            txtPassword.Size = new Size(184, 23);
            txtPassword.TabIndex = 1;
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(6, 22);
            txtUserName.Name = "txtUserName";
            txtUserName.PlaceholderText = "User Name";
            txtUserName.Size = new Size(184, 23);
            txtUserName.TabIndex = 0;
            // 
            // LoginPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(414, 151);
            Controls.Add(gBoxLoginPage);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginPage";
            gBoxLoginPage.ResumeLayout(false);
            gBoxLoginPage.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gBoxLoginPage;
        private TextBox txtPassword;
        private TextBox txtUserName;
        private Button btnShowHidePassword;
        private Button btnClose;
        private Button btnSingUp;
        private Button btnLogin;
    }
}