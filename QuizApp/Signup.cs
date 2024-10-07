using Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizzApp
{
    public partial class Signup : Form
    {
        public Signup()
        {
            InitializeComponent();
        }
        string ImagePath = "";

        private void _ShowProfileImage()
        {
            UploadImage.Visible = false;
            txtMainUploadText.Visible = false;
            txtMiniUploadText.Visible = false;

            ProfileImage.Location = new System.Drawing.Point(918, 250);
            ProfileImage.Visible = true;
            ProfileImage.BackColor = Color.White;
        }

        private Image _ResizeImage(Image img, Size size)
        {
            return (Image)(new Bitmap(img, size));
        }

        private void _UploadProfileImage()
        {
            if (ProfileImageExplorer.ShowDialog() == DialogResult.OK)
            {
                Image CurrentImage = Image.FromFile(ProfileImageExplorer.FileName);
                Size NewSize = new Size((int)(CurrentImage.Width * 0.2), (int)(CurrentImage.Height * 0.2));
                ProfileImage.Image = _ResizeImage(CurrentImage, NewSize);
                ImagePath = ProfileImageExplorer.FileName;

                _ShowProfileImage();
            }    
        }

        private void UploadProfileImg(object sender, EventArgs e)
        {
            _UploadProfileImage();
        }

        private bool _CheckIfFiledsEmpty()
        {
            bool IsEmpty = false;

            if(!ProfileImage.Visible)
            {
                txtMainUploadText.ForeColor = Color.Red;
                IsEmpty = true;
            }

            if (tbFirstName.Text == string.Empty)
            {
                tbFirstName.BorderColor = Color.Red;
                IsEmpty = true;
            }

            if (tbLastName.Text == string.Empty)
            {
                tbLastName.BorderColor = Color.Red;
                IsEmpty = true;
            }

            if (tbUserName.Text == string.Empty)
            {
                tbUserName.BorderColor = Color.Red;
                IsEmpty = true;
            }

            if (tbPassword.Text == string.Empty)
            {
                tbPassword.BorderColor = Color.Red;
                IsEmpty = true;
            }

            if (tbPhone.Text == string.Empty)
            {
                tbPhone.BorderColor = Color.Red;
                IsEmpty = true;
            }

            if (tbEmail.Text == string.Empty)
            {
                tbEmail.BorderColor = Color.Red;
                IsEmpty = true;
            }

            return IsEmpty;
        }

        private void _RemoveData()
        {
            ProfileImage.Visible = false;
            ProfileImage.Image = null;
            ImagePath = "";

            UploadImage.Visible = true;
            txtMainUploadText.Visible = true;
            txtMiniUploadText.Visible = true;

            tbFirstName.Text = "";
            tbMidName.Text = "";
            tbLastName.Text = "";
            tbUserName.Text = "";
            tbPassword.Text = "";
            tbPhone.Text = "";
            tbEmail.Text = "";
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            if (_CheckIfFiledsEmpty())
                return;

            clsUsers NewUser = new clsUsers();

            NewUser.UserName = tbUserName.Text;
            NewUser.Password = tbPassword.Text;
            NewUser.FirstName = tbFirstName.Text;
            NewUser.LastName = tbLastName.Text;
            NewUser.Phone = tbPhone.Text;
            NewUser.Email = tbEmail.Text;
            NewUser.ProfileImage = ImagePath;

            if(tbMidName.Text != string.Empty)
                NewUser.MidName = tbMidName.Text;

            if (NewUser.SignUp())
            {
                btnSignUp.Visible = false;
                btnBackToLogin.Visible = true;
                _RemoveData();
            }
        }

        private void HideError(object sender, EventArgs e)
        {
            Guna.UI2.WinForms.Guna2TextBox Tb = (Guna.UI2.WinForms.Guna2TextBox)sender;
            Tb.BorderColor = Color.White;
        }

        private void IsFieldsStillEmpty(object sender, EventArgs e)
        {
            Guna.UI2.WinForms.Guna2TextBox Tb = (Guna.UI2.WinForms.Guna2TextBox)sender;

            if (Tb.Text == string.Empty)
                Tb.BorderColor = Color.Red;
            else
                Tb.BorderColor = Color.White;
        }

        private void btnBackToLogin_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
