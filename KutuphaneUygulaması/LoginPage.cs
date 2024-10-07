using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneUygulaması
{
    public partial class LoginPage : Form
    {
        private bool isVisiablePassword = true;
        public LoginPage()
        {
            InitializeComponent();
        }

        private void btnShowHidePassword_Click(object sender, EventArgs e)
        {
            if (isVisiablePassword)
            {
                txtPassword.PasswordChar = '\0'; //yazıyı görünür hale getirir
                isVisiablePassword = false;
                btnShowHidePassword.Image = KutuphaneUygulaması.Properties.Resources.invisible1;
            }
            else
            {
                txtPassword.PasswordChar = '*'; //yazıyı görünür hale getirir
                isVisiablePassword = true;
                btnShowHidePassword.Image = KutuphaneUygulaması.Properties.Resources.visible1;
            }


        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userName = txtUserName.Text;
            string password = txtPassword.Text;

            if(Program.userList[userName].Password == password)
            {
                Program.activeUser = Program.userList[userName];

                MainPage mainPage = new MainPage();
                mainPage.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre yanlıştır.");
            }
        }

        private void btnSingUp_Click(object sender, EventArgs e)
        {
            UserRegisterPage userRegisterPage = new UserRegisterPage();
            userRegisterPage.ShowDialog();
            userRegisterPage.StartPosition = FormStartPosition.CenterScreen;
        }
    }
}
