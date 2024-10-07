using Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizzApp
{
    public partial class StartQuiz : Form
    {
        private DataTable _Questions = new DataTable();
        private clsQuestions _Question = new clsQuestions();
        private int _RowsCounter = -1;
        private int _QuestionsCounter = 0;
        private int _Time = 0;
        private int _TimeLeft = 0;
        private int _Xb = 0;
        private int _AnimationValue = 5;

        public StartQuiz()
        {
            InitializeComponent();
        }

        private void _GetQuestion()
        {
            txtQuestion.Text = (string)_Questions.Rows[_RowsCounter]["Question"];
            Option1.Text     = (string)_Questions.Rows[_RowsCounter]["Option1"];
            Option2.Text     = (string)_Questions.Rows[_RowsCounter]["Option2"];
            Option3.Text     = (string)_Questions.Rows[_RowsCounter]["Option3"];
            Option4.Text     = (string)_Questions.Rows[_RowsCounter]["Option4"];
            _Question.Answer = (string)_Questions.Rows[_RowsCounter]["Answer"];
        }
        
        private void _ResetOptionsStyle(Guna.UI2.WinForms.Guna2Button Option)
        {
            Option.BorderThickness = 1;
            Option.BorderColor = Color.FromArgb(64, 64, 64);
        }

        private void _ResetOptions()
        {
            _ResetOptionsStyle(Option1);
            _ResetOptionsStyle(Option2);
            _ResetOptionsStyle(Option3);
            _ResetOptionsStyle(Option4);
        }

        private void _LoadQuestionData()
        {
            TimerPar.Invoke((MethodInvoker)delegate
            {
                TimerPar.Maximum = clsQuiz.TimePerQuestion;
                TimerPar.Value = clsQuiz.TimePerQuestion;
            });

            _RowsCounter++;
            _QuestionsCounter++;

            _ResetOptions();
            _GetQuestion();

            txtTime.Text = clsQuiz.TimePerQuestion.ToString();
            _Time = 0;
            _TimeLeft = clsQuiz.TimePerQuestion;

            TotalQues.Text       = $"/{clsQuiz.NumOfQues}";
            CurrentQuestion.Text = $"Question {_QuestionsCounter}";

            QuestionTimer.Start();
        }

        private void StartQuiz_Load(object sender, EventArgs e)
        {
            _Questions = clsQuestions.LoadQuestions();
            _LoadQuestionData();
        }

        private bool _CheckOption(Guna.UI2.WinForms.Guna2Button Option, bool CheckAnswer, bool IsCorrectAnswer)
        {
            if (Option.Checked)
            {
                if (!CheckAnswer)
                {
                    Option.Checked = false;
                    Option.BorderThickness = 2;

                    if (IsCorrectAnswer)
                    {
                        Option.BorderColor = Color.Green;
                        return true;
                    }
                    else
                        Option.BorderColor = Color.Red;
                }
                else
                {
                    return true;
                }
            }

            return false;
        }

        private string _CheckOptions(bool CheckAnswer = true, bool IsCorrectAnswer = false, string Answer = "z")
        {
            if (_CheckOption(Option1, CheckAnswer, IsCorrectAnswer))
                return "a";
            else if (Answer == Option1.Tag.ToString())
            {
                Option1.BorderColor = Color.Green;
                Option1.BorderThickness = 2;
            }
                
            if (_CheckOption(Option2, CheckAnswer, IsCorrectAnswer))
                return "b";
            else if (Answer == Option2.Tag.ToString())
            {
                Option2.BorderColor = Color.Green;
                Option2.BorderThickness = 2;
            }

            if (_CheckOption(Option3, CheckAnswer, IsCorrectAnswer))
                return "c";
            else if (Answer == Option3.Tag.ToString())
            {
                Option3.BorderColor = Color.Green;
                Option3.BorderThickness = 2;
            }

            if (_CheckOption(Option4, CheckAnswer, IsCorrectAnswer))
                return "d";
            else if (Answer == Option4.Tag.ToString())
            {
                Option4.BorderColor = Color.Green;
                Option4.BorderThickness = 2;
            }

            return "Non";
        }

        private void _CheckAnswer()
        {
            QuestionTimer.Stop();

            if (_CheckOptions() == _Question.Answer)
            {
                _AnimationValue += _Xb;
                XbTimer.Start();

                CurrentUser.CorrectAnswers++;
                _CheckOptions(CheckAnswer: false, IsCorrectAnswer: true);
            }
            else
            {
                CurrentUser.WrongAnswers++;
                _CheckOptions(CheckAnswer: false, Answer: _Question.Answer);
            }
        }

        private void XbTimer_Tick(object sender, EventArgs e)
        {
            if (_Xb != _AnimationValue)
            {
                _Xb++;
                txtXb.Text = _Xb.ToString();
            }
            else
                XbTimer.Stop();
        }

        private void QuestionTimer_Tick(object sender, EventArgs e)
        {
            if (_Time < clsQuiz.TimePerQuestion)
            {
                _Time++;
                _TimeLeft--;
                txtTime.Text = _TimeLeft.ToString();

                TimerPar.Invoke((MethodInvoker)delegate
                {
                    TimerPar.Value = clsQuiz.TimePerQuestion - _Time;
                });
            }
            else
            {
                btnCheck.Visible = false;
                btnNext.Visible = true;

                _CheckAnswer();
            }
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            CurrentUser.User.Xb += _Xb;
            CurrentUser.User.UpdateUserXb();

            CurrentUser.QuizXb = _Xb;
            this.Close();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            btnNext.Visible = false;
            btnCheck.Visible = true;

            _LoadQuestionData();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            btnCheck.Visible = false;
            _CheckAnswer();

            if (_QuestionsCounter != clsQuiz.NumOfQues)
                btnNext.Visible = true;
            else
                btnResult.Visible = true;

        }
    }
}
