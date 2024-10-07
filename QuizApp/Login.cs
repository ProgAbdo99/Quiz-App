using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logic;

namespace QuizzApp
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private bool _CheckIfFiledsEmpty()
        {
            bool Empty = false;

            if (tbUserName.Text == "")
            {
                tbUserName.BorderColor = Color.Red;
                Empty = true;
            }
            else
            {
                tbUserName.BorderColor = Color.White;
            }

            if (tbPassword.Text == "")
            {
                tbPassword.BorderColor = Color.Red;
                
                if(!Empty)
                    Empty = true;
            }
            else
            {
                tbPassword.BorderColor = Color.White;
            }

            return Empty;
        }

        private void _StartApp()
        {
            Main frm = new Main();
            frm.Show();
            this.Close();
        }

        private void _LoginFailed()
        {
            ErrorMessage.Visible = true;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (_CheckIfFiledsEmpty())
                return;

            if (clsUsers.Login(tbUserName.Text, tbPassword.Text))
                _StartApp();
            else
                _LoginFailed();
        }

        private void HideErrorMessage(object sender, EventArgs e)
        {
            if (ErrorMessage.Visible)
                ErrorMessage.Visible = false;
        }

        private void IsFieldsStillEmpty(object sender, EventArgs e)
        {
            Guna.UI2.WinForms.Guna2TextBox Tb = (Guna.UI2.WinForms.Guna2TextBox)sender;
            
            if(Tb.Text == string.Empty)
                Tb.BorderColor = Color.Red;
            else
                Tb.BorderColor = Color.White;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Signup frm = new Signup();
            frm.ShowDialog();
        }
    }
}
