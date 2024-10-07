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
    public partial class AddQuiz : Form
    {
        private int _QuizID = -1;
        private int _NumOfQuestions = 1;
        private int _CurrentQues = 0;
        private int _LoaderTime = 0;

        public AddQuiz()
        {
            InitializeComponent();
        }

        private void _LoadCategories()
        {
            List<string> Categories = clsQuiz.LoadCategories();

            foreach (string Categori in Categories)
            {
                cbCategorie.Items.Add(Categori);
            }

            cbCategorie.SelectedIndex = 0;
        }

        private void AddQuiz_Load(object sender, EventArgs e)
        {
            NumofQues.BorderRadius = 5;

            _LoadCategories();
        }

        private bool _CheckIfQuizInfoFiledsEmpty()
        {
            bool IsEmpty = false;

            if (tbQuizName.Text == string.Empty)
            {
                tbQuizName.BorderColor = Color.Red;
                tbQuizName.PlaceholderText = "Write The Quiz Name !";

                IsEmpty = true;
            }

            return IsEmpty;
        }

        private bool _SaveQuizData()
        {
            _NumOfQuestions = Convert.ToInt32(NumofQues.Value);

            return clsQuiz.SaveQuizData(ref _QuizID, tbQuizName.Text, cbCategorie.Text, _NumOfQuestions);
        }

        private void btnSaveQuizInfo_Click(object sender, EventArgs e)
        {
            if (_CheckIfQuizInfoFiledsEmpty())
                return;

            if (_SaveQuizData())
            {
                Loader1.Visible = true;
                Loader1.Start();

                LoaderTimer1.Start();
            }
        }

        private void IsFailedStillEmpty(object sender, EventArgs e)
        {
            Guna.UI2.WinForms.Guna2TextBox Tb = (Guna.UI2.WinForms.Guna2TextBox)sender;

            if (Tb.Text != string.Empty)
                Tb.BorderColor = Color.FromArgb(213, 218, 223);
            else
                Tb.BorderColor = Color.Red;
        }

        private void btnAddCategori_Click(object sender, EventArgs e)
        {
            btnAddCategori.Visible = false;

            AddCategoriConrainer.Location = btnAddCategori.Location;
            AddCategoriConrainer.Visible = true;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            AddCategoriConrainer.Visible = false;

            btnAddCategori.Visible = true;
        }

        private bool _CheckIfAddCategoriFiledEmpty()
        {
            bool IsEmpty = false;

            if (tbNewCategori.Text == string.Empty)
            {
                tbNewCategori.BorderColor = Color.Red;
                IsEmpty = true;
            }

            return IsEmpty;
        }

        private bool _SaveCategori()
        {
            return clsQuiz.SaveCategory(tbNewCategori.Text);
        }

        private void btnSaveCategori_Click(object sender, EventArgs e)
        {
            if (_CheckIfAddCategoriFiledEmpty())
                return;

            if (_SaveCategori())
            {
                Loader3.Visible = true;
                Loader3.Start();

                LoaderTimer3.Start();
            }
        }

        private bool _CheckIfQuestionsInfoFiledsEmpty()
        {
            bool IsEmpty = false;

            if (tbQuestion.Text == string.Empty)
            {
                tbQuestion.BorderColor = Color.Red;
                tbQuestion.PlaceholderText = "Write The Question !";

                IsEmpty = true;
            }

            if (tbOption1.Text == string.Empty)
            {
                tbOption1.BorderColor = Color.Red;
                tbOption1.PlaceholderText = "Write The First Option !";

                if(!IsEmpty)
                    IsEmpty = true;
            }

            if (tbOption2.Text == string.Empty)
            {
                tbOption2.BorderColor = Color.Red;
                tbOption2.PlaceholderText = "Write The Second Option !";

                if (!IsEmpty)
                    IsEmpty = true;
            }

            if (tbOption3.Text == string.Empty)
            {
                tbOption3.BorderColor = Color.Red;
                tbOption3.PlaceholderText = "Write The Third Option !";

                if (!IsEmpty)
                    IsEmpty = true;
            }

            if (tbOption4.Text == string.Empty)
            {
                tbOption4.BorderColor = Color.Red;
                tbOption4.PlaceholderText = "Write The Fourth Option !";

                if (!IsEmpty)
                    IsEmpty = true;
            }

            if (tbAnswer.Text == string.Empty)
            {
                tbAnswer.BorderColor = Color.Red;
                tbAnswer.PlaceholderText = "Write The Correct Answer !";

                if (!IsEmpty)
                    IsEmpty = true;
            }

            return IsEmpty;
        }

        private bool _SaveQuestion()
        {
            clsQuestions Question = new clsQuestions();

            Question.Question = tbQuestion.Text;
            Question.Option1  = tbOption1.Text;
            Question.Option2  = tbOption2.Text;
            Question.Option3  = tbOption3.Text;
            Question.Option4  = tbOption4.Text;
            Question.Answer   = tbAnswer.Text;
            Question.ConnectedQuiz = _QuizID;

            return Question.Save();
        }

        private void _Reset()
        {
            _CurrentQues = 0;
            _NumOfQuestions = 0;
            txtQuestion.Text = "Question";
            OptionsInfoContainer.Enabled = false;
            QuestionInfoContainer.Enabled = false;

            QuizInfoContainer.Enabled = true;
            btnAddCategori.Enabled = true;
            tbQuizName.Text = "";
            cbCategorie.SelectedIndex = 0;
            NumofQues.Value = 1;

            btnSaveQuizInfo.Image = null;
            btnSaveQuizInfo.Text = "Save";
            btnSaveQuizInfo.TextOffset = new System.Drawing.Point(0, 0);
        }

        private void btnSaveQuestionsInfo_Click(object sender, EventArgs e)
        {
            _CurrentQues++;

            if (_CheckIfQuestionsInfoFiledsEmpty())
                return;

            if (_SaveQuestion())
            {
                Loader2.Visible = true;
                Loader2.Start();

                LoaderTimer2.Start();
            }
        }

        private void LoaderTimer1_Tick(object sender, EventArgs e)
        {
            if (_LoaderTime > 1)
            {
                btnSaveQuizInfo.Image = Image.FromFile(@"D:\QuizApp\QuizApp\Images\Saved.png");
                btnSaveQuizInfo.TextOffset = new System.Drawing.Point(-8, 0);
                btnSaveQuizInfo.Text = "Saved";

                Loader1.Stop();
                Loader1.Visible = false;
            }

            if (_LoaderTime > 2)
            {
                QuizInfoContainer.Enabled = false;
                btnAddCategori.Enabled = false;

                QuestionInfoContainer.Enabled = true;
                _CurrentQues++;
                txtQuestion.Text = $"Question {_CurrentQues} / {_NumOfQuestions}";

                OptionsInfoContainer.Enabled = true;

                _LoaderTime = 0;
                LoaderTimer1.Stop();
                return;
            }

            _LoaderTime++;
        }

        private void _FilterFields()
        {
            tbQuestion.Text = "";
            tbOption1.Text = "";
            tbOption2.Text = "";
            tbOption3.Text = "";
            tbOption4.Text = "";
            tbAnswer.Text = "";
        }

        private void LoaderTimer2_Tick(object sender, EventArgs e)
        {
            if (_LoaderTime > 1)
            {
                btnSaveQuestionsInfo.Image = Image.FromFile(@"D:\QuizApp\QuizApp\Images\Saved.png");
                btnSaveQuestionsInfo.TextOffset = new System.Drawing.Point(-8, 0);
                btnSaveQuestionsInfo.Text = "Saved";

                Loader2.Stop();
                Loader2.Visible = false;
            }

            if (_LoaderTime > 2)
            {
                btnSaveQuestionsInfo.Image = null;
                btnSaveQuestionsInfo.Text = "Save";
                btnSaveQuestionsInfo.TextOffset = new System.Drawing.Point(0, 0);

                tbQuestion.Focus();
                _FilterFields();

                _LoaderTime = 0;
                LoaderTimer2.Stop();

                if (_CurrentQues > _NumOfQuestions)
                {
                    MessageBox.Show("Questions have been added successfully Click OK to add more!", "Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _Reset();
                }
                else
                {
                    txtQuestion.Text = $"Question {_CurrentQues} / {_NumOfQuestions}";
                }

                return;
            }

            _LoaderTime++;
        }

        private void LoaderTimer3_Tick(object sender, EventArgs e)
        {
            if (_LoaderTime > 1)
            {
                btnSaveCategori.Image = Image.FromFile(@"D:\QuizApp\QuizApp\Images\Saved.png");
                btnSaveCategori.TextOffset = new System.Drawing.Point(-8, 0);
                btnSaveCategori.Text = "Saved";

                Loader3.Stop();
                Loader3.Visible = false;
            }

            if (_LoaderTime > 2)
            {
                tbNewCategori.Text = "";
                cbCategorie.Items.Clear();
                _LoadCategories();

                _LoaderTime = 0;
                LoaderTimer3.Stop();
                return;
            }

            _LoaderTime++;
        }

        private void tbNewCategori_Enter(object sender, EventArgs e)
        {
            if (btnSaveCategori.Image != null)
            {
                btnSaveCategori.Image = null;
                btnSaveCategori.Text = "Save";
                btnSaveCategori.TextOffset = new System.Drawing.Point(0, 0);
            }
        }
    }
}
