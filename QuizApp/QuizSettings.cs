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
    public partial class QuizSettings : Form
    {
        private int _LoaderTime = 0;
        public QuizSettings()
        {
            InitializeComponent();
        }

        private void btnStartQuiz_Click(object sender, EventArgs e)
        {
            if (true)
            {
                clsQuiz.SelectedQuiz    = clsQuiz.GetQuizID(SelectedQuiz.Text);
                clsQuiz.TimePerQuestion = Convert.ToInt32(SelectedTime.Text);

                Loader.Visible = true;
                Loader.Start();

                btnStartQuiz.Text = "Loading";
                btnStartQuiz.TextOffset = new System.Drawing.Point(-8, 0);

                LoaderTimer.Start();
            }
        }

        private void LoaderTimer_Tick(object sender, EventArgs e)
        {
            if (_LoaderTime > 1)
            {
                Loader.Visible = false;
                Loader.Stop();

                btnStartQuiz.Text = "Done !";
                btnStartQuiz.TextOffset = new System.Drawing.Point(0, 0);
            }

            if (_LoaderTime > 2)
            {
                _LoaderTime = 0;
                LoaderTimer.Stop();
                this.Close();
            }

            _LoaderTime++;
        }

        private void QuizSettings_Load(object sender, EventArgs e)
        {
            List<string> Categories = clsQuiz.LoadCategories();

            foreach (string category in Categories)
            {
                SelectedCategory.Items.Add(category);
            }

            SelectedCategory.SelectedIndex = 0;
            SelectedTime.SelectedIndex = 0;
        }

        private void SelectedCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(SelectedQuiz.Items.Count > 0)
                SelectedQuiz.Items.Clear();

            clsQuiz.Category = clsQuiz.GetCategoryID(SelectedCategory.Text);

            List<string> Quiz = clsQuiz.GetQuizByCategory();

            foreach (string quiz in Quiz)
                SelectedQuiz.Items.Add(quiz);

            if (SelectedQuiz.Items.Count > 0)
                SelectedQuiz.SelectedIndex = 0;
        }
    }
}
