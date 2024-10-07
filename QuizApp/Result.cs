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
    public partial class Result : Form
    {
        private Main _MainScreen;
        private int _XbCounter = 0;
        public Result(Main form)
        {
            InitializeComponent();
            this._MainScreen = form;
        }

        private void _LoadData()
        {
            txtCategoreName.Text   = clsQuiz.CategoryName;
            txtQuizName.Text       = clsQuiz.Quiz;

            txtCorrectAnswers.Text = CurrentUser.CorrectAnswers.ToString();
            txtWrongAnswers.Text   = CurrentUser.WrongAnswers.ToString();
            txtQuizXb.Text         = CurrentUser.QuizXb.ToString();

            TotalXbTime.Start();
        }

        private void Result_Load(object sender, EventArgs e)
        {
            _LoadData();
        }

        private void TotalXbTime_Tick(object sender, EventArgs e)
        {
            if (_XbCounter <= CurrentUser.User.Xb)
                txtTotalXb.Text = _XbCounter.ToString();
            else
                TotalXbTime.Stop();

            _XbCounter++;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            CurrentUser.CorrectAnswers = 0;
            CurrentUser.WrongAnswers = 0;

            _MainScreen.UpdateUserXb(txtTotalXb.Text);
            this.Close();
        }
    }
}
