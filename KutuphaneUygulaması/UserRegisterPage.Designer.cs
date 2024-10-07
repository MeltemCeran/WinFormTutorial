namespace KutuphaneUygulaması
{
    partial class UserRegisterPage
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
            gBoxSignUp = new GroupBox();
            btnSave = new Button();
            lblName = new Label();
            txtPassword = new TextBox();
            txtPasswordAgain = new TextBox();
            txtEmail = new TextBox();
            txtSurname = new TextBox();
            txtName = new TextBox();
            gBoxSignUp.SuspendLayout();
            SuspendLayout();
            // 
            // gBoxSignUp
            // 
            gBoxSignUp.Controls.Add(btnSave);
            gBoxSignUp.Controls.Add(lblName);
            gBoxSignUp.Controls.Add(txtPassword);
            gBoxSignUp.Controls.Add(txtPasswordAgain);
            gBoxSignUp.Controls.Add(txtEmail);
            gBoxSignUp.Controls.Add(txtSurname);
            gBoxSignUp.Controls.Add(txtName);
            gBoxSignUp.Location = new Point(6, 6);
            gBoxSignUp.Name = "gBoxSignUp";
            gBoxSignUp.Size = new Size(296, 233);
            gBoxSignUp.TabIndex = 0;
            gBoxSignUp.TabStop = false;
            gBoxSignUp.Text = "Sign Up";
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.ForestGreen;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.ForeColor = Color.WhiteSmoke;
            btnSave.Location = new Point(15, 172);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 6;
            btnSave.Text = "SAVE";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // lblName
            // 
            lblName.BackColor = Color.Transparent;
            lblName.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblName.ForeColor = Color.IndianRed;
            lblName.Location = new Point(145, 28);
            lblName.Name = "lblName";
            lblName.Size = new Size(132, 23);
            lblName.TabIndex = 5;
            lblName.Text = "Bu alan zorunludur.";
            lblName.Visible = false;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(15, 114);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.PlaceholderText = "Password";
            txtPassword.Size = new Size(124, 23);
            txtPassword.TabIndex = 4;
            // 
            // txtPasswordAgain
            // 
            txtPasswordAgain.Location = new Point(15, 143);
            txtPasswordAgain.Name = "txtPasswordAgain";
            txtPasswordAgain.PasswordChar = '*';
            txtPasswordAgain.PlaceholderText = "Password Again";
            txtPasswordAgain.Size = new Size(124, 23);
            txtPasswordAgain.TabIndex = 5;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(15, 85);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "E-mail";
            txtEmail.Size = new Size(124, 23);
            txtEmail.TabIndex = 3;
            // 
            // txtSurname
            // 
            txtSurname.Location = new Point(15, 56);
            txtSurname.Name = "txtSurname";
            txtSurname.PlaceholderText = "Surname";
            txtSurname.Size = new Size(124, 23);
            txtSurname.TabIndex = 2;
            // 
            // txtName
            // 
            txtName.Location = new Point(15, 27);
            txtName.Name = "txtName";
            txtName.PlaceholderText = "Name";
            txtName.Size = new Size(124, 23);
            txtName.TabIndex = 1;
            txtName.Enter += txtName_Enter;
            // 
            // UserRegisterPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(314, 251);
            Controls.Add(gBoxSignUp);
            Name = "UserRegisterPage";
            Text = "UserRegisterPage";
            gBoxSignUp.ResumeLayout(false);
            gBoxSignUp.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gBoxSignUp;
        private TextBox txtPasswordAgain;
        private TextBox txtPassword;
        private TextBox txtEmail;
        private TextBox txtSurname;
        private TextBox txtName;
        private Button btnSave;
        private Label lblName;
    }
}