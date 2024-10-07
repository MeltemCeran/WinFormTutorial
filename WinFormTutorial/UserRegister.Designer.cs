namespace WinFormTutorial
{
    partial class UserRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserRegister));
            gBoxStep1 = new GroupBox();
            btnNextStep1 = new Button();
            lblBirthDate = new Label();
            lblSurname = new Label();
            lblName = new Label();
            dtpBirthDate = new DateTimePicker();
            txtSurname = new TextBox();
            txtName = new TextBox();
            gBoxStep2 = new GroupBox();
            btnBackStep2 = new Button();
            txtAddress = new TextBox();
            btnNextStep2 = new Button();
            lblPhoneNumber = new Label();
            lblEmail = new Label();
            txtPhoneNumber = new TextBox();
            txtEmail = new TextBox();
            gBoxStep3 = new GroupBox();
            txtOther = new TextBox();
            cBoxOther = new CheckBox();
            lblFavoriteTeam = new Label();
            cmBoxTeams = new ComboBox();
            cBoxSwimming = new CheckBox();
            cBoxWatchTvMovie = new CheckBox();
            cBoxRead = new CheckBox();
            cBoxSport = new CheckBox();
            btnBackStep3 = new Button();
            btnSave = new Button();
            mTxtPhoneNumber = new MaskedTextBox();
            gBoxStep1.SuspendLayout();
            gBoxStep2.SuspendLayout();
            gBoxStep3.SuspendLayout();
            SuspendLayout();
            // 
            // gBoxStep1
            // 
            gBoxStep1.Controls.Add(btnNextStep1);
            gBoxStep1.Controls.Add(lblBirthDate);
            gBoxStep1.Controls.Add(lblSurname);
            gBoxStep1.Controls.Add(lblName);
            gBoxStep1.Controls.Add(dtpBirthDate);
            gBoxStep1.Controls.Add(txtSurname);
            gBoxStep1.Controls.Add(txtName);
            gBoxStep1.Location = new Point(12, 6);
            gBoxStep1.Name = "gBoxStep1";
            gBoxStep1.Size = new Size(310, 175);
            gBoxStep1.TabIndex = 0;
            gBoxStep1.TabStop = false;
            gBoxStep1.Text = "Adım 1 | Kişisel Bilgiler";
            // 
            // btnNextStep1
            // 
            btnNextStep1.BackColor = Color.LightSeaGreen;
            btnNextStep1.FlatStyle = FlatStyle.Flat;
            btnNextStep1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnNextStep1.ForeColor = Color.WhiteSmoke;
            btnNextStep1.Location = new Point(229, 146);
            btnNextStep1.Name = "btnNextStep1";
            btnNextStep1.Size = new Size(75, 23);
            btnNextStep1.TabIndex = 7;
            btnNextStep1.Text = "İLERİ >";
            btnNextStep1.UseVisualStyleBackColor = false;
            btnNextStep1.Click += btnNextStep1_Click;
            // 
            // lblBirthDate
            // 
            lblBirthDate.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblBirthDate.ForeColor = Color.IndianRed;
            lblBirthDate.Location = new Point(140, 87);
            lblBirthDate.Name = "lblBirthDate";
            lblBirthDate.Size = new Size(159, 23);
            lblBirthDate.TabIndex = 6;
            lblBirthDate.Text = "18 Yaşında Olmalısınız.";
            lblBirthDate.TextAlign = ContentAlignment.MiddleLeft;
            lblBirthDate.Visible = false;
            // 
            // lblSurname
            // 
            lblSurname.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblSurname.ForeColor = Color.IndianRed;
            lblSurname.Location = new Point(140, 57);
            lblSurname.Name = "lblSurname";
            lblSurname.Size = new Size(145, 23);
            lblSurname.TabIndex = 4;
            lblSurname.Text = "Bu alan zorunludur *";
            lblSurname.TextAlign = ContentAlignment.MiddleLeft;
            lblSurname.Visible = false;
            // 
            // lblName
            // 
            lblName.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblName.ForeColor = Color.IndianRed;
            lblName.Location = new Point(140, 28);
            lblName.Name = "lblName";
            lblName.Size = new Size(145, 23);
            lblName.TabIndex = 3;
            lblName.Text = "Bu alan zorunludur *";
            lblName.TextAlign = ContentAlignment.MiddleLeft;
            lblName.Visible = false;
            // 
            // dtpBirthDate
            // 
            dtpBirthDate.Format = DateTimePickerFormat.Short;
            dtpBirthDate.Location = new Point(19, 86);
            dtpBirthDate.Name = "dtpBirthDate";
            dtpBirthDate.Size = new Size(115, 23);
            dtpBirthDate.TabIndex = 2;
            dtpBirthDate.Enter += dtpBirthDate_Enter;
            // 
            // txtSurname
            // 
            txtSurname.Location = new Point(19, 57);
            txtSurname.Name = "txtSurname";
            txtSurname.PlaceholderText = "Soyadınız";
            txtSurname.Size = new Size(115, 23);
            txtSurname.TabIndex = 1;
            txtSurname.Enter += txtSurname_Enter;
            // 
            // txtName
            // 
            txtName.Location = new Point(19, 28);
            txtName.Name = "txtName";
            txtName.PlaceholderText = "Adınız ";
            txtName.Size = new Size(115, 23);
            txtName.TabIndex = 0;
            txtName.Enter += txtName_Enter;
            // 
            // gBoxStep2
            // 
            gBoxStep2.Controls.Add(mTxtPhoneNumber);
            gBoxStep2.Controls.Add(btnBackStep2);
            gBoxStep2.Controls.Add(txtAddress);
            gBoxStep2.Controls.Add(btnNextStep2);
            gBoxStep2.Controls.Add(lblPhoneNumber);
            gBoxStep2.Controls.Add(lblEmail);
            gBoxStep2.Controls.Add(txtEmail);
            gBoxStep2.Location = new Point(12, 231);
            gBoxStep2.Name = "gBoxStep2";
            gBoxStep2.Size = new Size(310, 175);
            gBoxStep2.TabIndex = 8;
            gBoxStep2.TabStop = false;
            gBoxStep2.Text = "Adım 2 | İletişim Bilgiler";
            // 
            // btnBackStep2
            // 
            btnBackStep2.BackColor = Color.LightSeaGreen;
            btnBackStep2.FlatStyle = FlatStyle.Flat;
            btnBackStep2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnBackStep2.ForeColor = Color.WhiteSmoke;
            btnBackStep2.Location = new Point(6, 146);
            btnBackStep2.Name = "btnBackStep2";
            btnBackStep2.Size = new Size(75, 23);
            btnBackStep2.TabIndex = 9;
            btnBackStep2.Text = "< GERİ";
            btnBackStep2.UseVisualStyleBackColor = false;
            btnBackStep2.Click += btnBackStep2_Click;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(19, 89);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.PlaceholderText = "Adresiniz";
            txtAddress.Size = new Size(115, 47);
            txtAddress.TabIndex = 8;
            // 
            // btnNextStep2
            // 
            btnNextStep2.BackColor = Color.LightSeaGreen;
            btnNextStep2.FlatStyle = FlatStyle.Flat;
            btnNextStep2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnNextStep2.ForeColor = Color.WhiteSmoke;
            btnNextStep2.Location = new Point(229, 146);
            btnNextStep2.Name = "btnNextStep2";
            btnNextStep2.Size = new Size(75, 23);
            btnNextStep2.TabIndex = 7;
            btnNextStep2.Text = "İLERİ >";
            btnNextStep2.UseVisualStyleBackColor = false;
            btnNextStep2.Click += btnNextStep2_Click;
            // 
            // lblPhoneNumber
            // 
            lblPhoneNumber.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblPhoneNumber.ForeColor = Color.IndianRed;
            lblPhoneNumber.Location = new Point(140, 57);
            lblPhoneNumber.Name = "lblPhoneNumber";
            lblPhoneNumber.Size = new Size(145, 23);
            lblPhoneNumber.TabIndex = 4;
            lblPhoneNumber.Text = "Bu alan zorunludur *";
            lblPhoneNumber.TextAlign = ContentAlignment.MiddleLeft;
            lblPhoneNumber.Visible = false;
            // 
            // lblEmail
            // 
            lblEmail.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblEmail.ForeColor = Color.IndianRed;
            lblEmail.Location = new Point(140, 28);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(145, 23);
            lblEmail.TabIndex = 3;
            lblEmail.Text = "Bu alan zorunludur *";
            lblEmail.TextAlign = ContentAlignment.MiddleLeft;
            lblEmail.Visible = false;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new Point(377, 231);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.PlaceholderText = "Telefon Numarası";
            txtPhoneNumber.Size = new Size(115, 23);
            txtPhoneNumber.TabIndex = 1;
            txtPhoneNumber.Enter += txtPhoneNumber_Enter;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(19, 28);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "E-Posta Adresi";
            txtEmail.Size = new Size(115, 23);
            txtEmail.TabIndex = 0;
            txtEmail.Enter += txtEmail_Enter;
            // 
            // gBoxStep3
            // 
            gBoxStep3.Controls.Add(txtOther);
            gBoxStep3.Controls.Add(cBoxOther);
            gBoxStep3.Controls.Add(lblFavoriteTeam);
            gBoxStep3.Controls.Add(cmBoxTeams);
            gBoxStep3.Controls.Add(cBoxSwimming);
            gBoxStep3.Controls.Add(cBoxWatchTvMovie);
            gBoxStep3.Controls.Add(cBoxRead);
            gBoxStep3.Controls.Add(cBoxSport);
            gBoxStep3.Controls.Add(btnBackStep3);
            gBoxStep3.Controls.Add(btnSave);
            gBoxStep3.Location = new Point(371, 12);
            gBoxStep3.Name = "gBoxStep3";
            gBoxStep3.Size = new Size(310, 175);
            gBoxStep3.TabIndex = 10;
            gBoxStep3.TabStop = false;
            gBoxStep3.Text = "Adım 3 | Hobiler";
            // 
            // txtOther
            // 
            txtOther.Location = new Point(66, 119);
            txtOther.Name = "txtOther";
            txtOther.PlaceholderText = "Diğer Hobiniz";
            txtOther.Size = new Size(144, 23);
            txtOther.TabIndex = 17;
            // 
            // cBoxOther
            // 
            cBoxOther.AutoSize = true;
            cBoxOther.Location = new Point(6, 121);
            cBoxOther.Name = "cBoxOther";
            cBoxOther.Size = new Size(54, 19);
            cBoxOther.TabIndex = 16;
            cBoxOther.Text = "Diğer";
            cBoxOther.UseVisualStyleBackColor = true;
            // 
            // lblFavoriteTeam
            // 
            lblFavoriteTeam.AutoSize = true;
            lblFavoriteTeam.Location = new Point(166, 23);
            lblFavoriteTeam.Name = "lblFavoriteTeam";
            lblFavoriteTeam.Size = new Size(93, 15);
            lblFavoriteTeam.TabIndex = 15;
            lblFavoriteTeam.Text = "Futbol Takımınız";
            // 
            // cmBoxTeams
            // 
            cmBoxTeams.FormattingEnabled = true;
            cmBoxTeams.Items.AddRange(new object[] { "Beşiktaş", "Galatasaray", "Fenerbahçe", "Trabzonspor" });
            cmBoxTeams.Location = new Point(166, 43);
            cmBoxTeams.Name = "cmBoxTeams";
            cmBoxTeams.Size = new Size(121, 23);
            cmBoxTeams.TabIndex = 14;
            // 
            // cBoxSwimming
            // 
            cBoxSwimming.AutoSize = true;
            cBoxSwimming.Location = new Point(6, 97);
            cBoxSwimming.Name = "cBoxSwimming";
            cBoxSwimming.Size = new Size(68, 19);
            cBoxSwimming.TabIndex = 13;
            cBoxSwimming.Text = "Yüzmek";
            cBoxSwimming.UseVisualStyleBackColor = true;
            // 
            // cBoxWatchTvMovie
            // 
            cBoxWatchTvMovie.AutoSize = true;
            cBoxWatchTvMovie.Location = new Point(6, 72);
            cBoxWatchTvMovie.Name = "cBoxWatchTvMovie";
            cBoxWatchTvMovie.Size = new Size(92, 19);
            cBoxWatchTvMovie.TabIndex = 12;
            cBoxWatchTvMovie.Text = "Film İzlemek";
            cBoxWatchTvMovie.UseVisualStyleBackColor = true;
            // 
            // cBoxRead
            // 
            cBoxRead.AutoSize = true;
            cBoxRead.Location = new Point(6, 47);
            cBoxRead.Name = "cBoxRead";
            cBoxRead.Size = new Size(101, 19);
            cBoxRead.TabIndex = 11;
            cBoxRead.Text = "Kitap Okumak";
            cBoxRead.UseVisualStyleBackColor = true;
            // 
            // cBoxSport
            // 
            cBoxSport.AutoSize = true;
            cBoxSport.Location = new Point(6, 22);
            cBoxSport.Name = "cBoxSport";
            cBoxSport.Size = new Size(50, 19);
            cBoxSport.TabIndex = 10;
            cBoxSport.Text = "Spor";
            cBoxSport.UseVisualStyleBackColor = true;
            // 
            // btnBackStep3
            // 
            btnBackStep3.BackColor = Color.LightSeaGreen;
            btnBackStep3.FlatStyle = FlatStyle.Flat;
            btnBackStep3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnBackStep3.ForeColor = Color.WhiteSmoke;
            btnBackStep3.Location = new Point(6, 146);
            btnBackStep3.Name = "btnBackStep3";
            btnBackStep3.Size = new Size(75, 23);
            btnBackStep3.TabIndex = 9;
            btnBackStep3.Text = "< GERİ";
            btnBackStep3.UseVisualStyleBackColor = false;
            btnBackStep3.Click += btnBackStep3_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Green;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnSave.ForeColor = Color.WhiteSmoke;
            btnSave.Location = new Point(229, 146);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 7;
            btnSave.Text = "KAYDET";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // mTxtPhoneNumber
            // 
            mTxtPhoneNumber.Location = new Point(19, 60);
            mTxtPhoneNumber.Mask = "(999) 000-0000";
            mTxtPhoneNumber.Name = "mTxtPhoneNumber";
            mTxtPhoneNumber.Size = new Size(115, 23);
            mTxtPhoneNumber.TabIndex = 10;
            // 
            // UserRegister
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(693, 528);
            Controls.Add(gBoxStep3);
            Controls.Add(gBoxStep2);
            Controls.Add(gBoxStep1);
            Controls.Add(txtPhoneNumber);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "UserRegister";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "User Register Form";
            Load += UserRegister_Load;
            gBoxStep1.ResumeLayout(false);
            gBoxStep1.PerformLayout();
            gBoxStep2.ResumeLayout(false);
            gBoxStep2.PerformLayout();
            gBoxStep3.ResumeLayout(false);
            gBoxStep3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox gBoxStep1;
        private Label lblName;
        private DateTimePicker dtpBirthDate;
        private TextBox txtSurname;
        private TextBox txtName;
        private Button btnNextStep1;
        private Label lblBirthDate;
        private Label lblSurname;
        private GroupBox gBoxStep2;
        private TextBox txtAddress;
        private Button btnNextStep2;
        private Label lblPhoneNumber;
        private Label lblEmail;
        private TextBox txtPhoneNumber;
        private TextBox txtEmail;
        private Button btnBackStep2;
        private GroupBox gBoxStep3;
        private Button btnBackStep3;
        private Button btnSave;
        private ComboBox cmBoxTeams;
        private CheckBox cBoxSwimming;
        private CheckBox cBoxWatchTvMovie;
        private CheckBox cBoxRead;
        private CheckBox cBoxSport;
        private TextBox txtOther;
        private CheckBox cBoxOther;
        private Label lblFavoriteTeam;
        private MaskedTextBox mTxtPhoneNumber;
    }
}