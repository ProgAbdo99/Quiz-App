using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logic;

namespace QuizzApp
{
    public partial class Main : Form
    {
        private bool _Removed = false;

        public Main()
        {
            InitializeComponent();
        }

        private Image _ResizeImage(Image img, Size size)
        {
            return (Image)(new Bitmap(img, size));
        }

        private void Main_Load(object sender, EventArgs e)
        {
            OpenSection(btnStartQuiz);

            btnStartQuiz.Checked = true;
            btnStartQuiz.Image = Image.FromFile("D:\\QuizApp\\QuizApp\\Images\\MainIcons\\Quiz Icon Selected.png");

            Image ProgileImage = Image.FromFile(CurrentUser.User.ProfileImage);
            Size NewSize = new Size((int)(ProgileImage.Width * 0.2), (int)(ProgileImage.Height * 0.2));
            ProfileImg.Image = _ResizeImage(ProgileImage, NewSize);

            txtUserName.Text = CurrentUser.User.UserName;

            if (CurrentUser.User.Xb > 0)
                txtXb.Text = $"{CurrentUser.User.Xb.ToString()} Xb";
            else
                txtXb.Text = "0 Xb";
        }

        private void _ChangeBtnImage(Guna.UI2.WinForms.Guna2Button btn, string Mode)
        {
            switch (btn.Tag.ToString())
            {
                case "Quiz":
                    btn.Image = Image.FromFile($"D:\\QuizApp\\QuizApp\\Images\\MainIcons\\Quiz Icon {Mode}.png");
                    break;
                default:
                    btn.Image = Image.FromFile($"D:\\QuizApp\\QuizApp\\Images\\MainIcons\\Add Quiz {Mode}.png");
                    break;
            }
        }

        private void CheckedState(object sender, EventArgs e)
        {
            Guna.UI2.WinForms.Guna2Button SectionBtn = (Guna.UI2.WinForms.Guna2Button)sender;
            SectionBtn.Checked = true;

            _ChangeBtnImage(SectionBtn, "Selected");

            OpenSection(SectionBtn);
        }

        private void UnCheckedState(object sender, EventArgs e)
        {
            Guna.UI2.WinForms.Guna2Button SectionBtn = (Guna.UI2.WinForms.Guna2Button)sender;

            if (!SectionBtn.Checked)
                _ChangeBtnImage(SectionBtn, "Unselected");
        }

        public void LoadForm(object form)
        {
            if (this.SectionsContainer.Controls.Count > 0)
                this.SectionsContainer.Controls.RemoveAt(0);

            Form frm = form as Form;

            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            this.SectionsContainer.Controls.Add(frm);
            this.SectionsContainer.Tag = frm;

            frm.Show();
        }

        public async Task LoadFormTask(object form)
        {
            var Task = new TaskCompletionSource<object>();

            if (this.SectionsContainer.Controls.Count > 0)
                this.SectionsContainer.Controls.RemoveAt(0);

            Form frm = form as Form;

            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            this.SectionsContainer.Controls.Add(frm);
            this.SectionsContainer.Tag = frm;

            frm.FormClosed += (sender, e) =>
            {
                Task.SetResult(null);
            };

            frm.Show();

            await Task.Task;
        }

        private async void OpenSection(Guna.UI2.WinForms.Guna2Button Section)
        {
            switch (Section.Tag)
            {
                case "Quiz":
                    await LoadFormTask(new QuizSettings());
                    await LoadFormTask(new StartQuiz());
                    await LoadFormTask(new Result(this));
                    OpenSection(btnStartQuiz);
                    break;
                case "AddQuiz":
                    LoadForm(new AddQuiz());
                    break;
            }
        }
    
        public void UpdateUserXb(string NewXb)
        {
            txtXb.Text = $"{NewXb} Xb";
        }
    }
}
