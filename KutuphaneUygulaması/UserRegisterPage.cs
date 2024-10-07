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
    public partial class UserRegisterPage : Form
    {
        public UserRegisterPage()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string surname = txtSurname.Text;
            string email = txtEmail.Text;

            string username = email.Split('@')[0];

            string password = txtPasswordAgain.Text;
            string passwordAgain = txtPassword.Text;

            bool isValid = true;

            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Lütfen zorunlu alanı giriniz.");
                lblName.Visible = true;
                isValid = false;
            }

            if (isValid)
            {
                User user = new User();

                user.Id = Guid.NewGuid();
                user.Name = name;
                user.Surname = surname;
                user.Email = email;
                user.Password = password;

                Program.AddUser(username, user);

                MessageBox.Show("Kayıt Yapılmıştır");
                this.Close();
            }
            else
            {
                MessageBox.Show("Hata var.");
            }

            if (password != passwordAgain)
            {
                MessageBox.Show("Şifreler farklıdır lütfen kontrol ediniz.");
                isValid = false;
            }

        }

        private void txtName_Enter(object sender, EventArgs e)
        {
            lblName.Visible = false;
        }

    
    }
}
