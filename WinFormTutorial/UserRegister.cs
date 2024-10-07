using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormTutorial
{
    public partial class UserRegister : Form
    {
        public UserRegister()
        {
            InitializeComponent();
        }

        private void UserRegister_Load(object sender, EventArgs e)
        {
            this.Width = 350;
            this.Height = 240;
        }

        private void btnNextStep1_Click(object sender, EventArgs e)
        {
            bool isValid = true;

            if (txtName.Text == string.Empty)
            {
                lblName.Visible = true;
                isValid = false;
            }
            if (txtSurname.Text == string.Empty)
            {
                lblSurname.Visible = true;
                isValid = false;
            }
            if (DateTime.Now.Year - dtpBirthDate.Value.Year < 18)
            {
                lblBirthDate.Visible = true;
                isValid = false;
            }

            if (isValid)
            {
                gBoxStep1.Visible = false;
                gBoxStep2.Visible = true;
                gBoxStep2.Location = gBoxStep1.Location;
            }
            else
            {
                MessageBox.Show("Lütfen zorunlu alanları doldurunuz.");
            }
        }


        private void btnNextStep2_Click(object sender, EventArgs e)
        {
            bool isValid = true;

            if (string.IsNullOrWhiteSpace(txtEmail.Text) || !EmailValid(txtEmail.Text))
            {
                lblEmail.Visible = true;
                isValid = false;
            }
            if (string.IsNullOrWhiteSpace(mTxtPhoneNumber.Text) || 
                mTxtPhoneNumber.Text.Length != mTxtPhoneNumber.Mask.Length)
            {
                lblPhoneNumber.Visible = true;
                isValid = false;
            }

            if (isValid)
            {
                gBoxStep2.Visible = false;
                gBoxStep3.Visible = true;
                gBoxStep3.Location = gBoxStep2.Location;
            }
            else
            {
                MessageBox.Show("Lütfen zorunlu alanları doldurunuz.");
            }

        }

        private bool EmailValid(string email)
        {
            if (!email.Contains("@"))
                return false;

            string[] emailSection = email.Split('@');

            if(emailSection.Length != 2 ) 
                return false;
            if (emailSection[0] == string.Empty)
                return false;

            string[] domainSection = emailSection[1].Split(".");
            if(domainSection.Length < 2 || domainSection.Length > 3) 
                return false;

            return true;
        }

        private void btnBackStep2_Click(object sender, EventArgs e)
        {
            gBoxStep1.Visible = true;
            gBoxStep2.Visible = false;
            gBoxStep1.Location = gBoxStep2.Location;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kayıt Yapıldı.");
        }

        private void btnBackStep3_Click(object sender, EventArgs e)
        {
            gBoxStep2.Visible = true;
            gBoxStep3.Visible = false;
            gBoxStep2.Location = gBoxStep3.Location;
        }

        private void txtName_Enter(object sender, EventArgs e)
        {
            lblName.Visible = false;
        }

        private void txtSurname_Enter(object sender, EventArgs e)
        {
            lblSurname.Visible = false;
        }

        private void dtpBirthDate_Enter(object sender, EventArgs e)
        {
            lblBirthDate.Visible = false;
        }

        private void txtEmail_Enter(object sender, EventArgs e)
        {
            lblEmail.Visible = false;
        }
    }
}
