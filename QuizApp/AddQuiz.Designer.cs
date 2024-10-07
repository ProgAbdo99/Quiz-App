namespace QuizzApp
{
    partial class AddQuiz
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddQuiz));
            this.tbQuestion = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbOption1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.OptionsInfoContainer = new System.Windows.Forms.Panel();
            this.Loader2 = new Guna.UI2.WinForms.Guna2ProgressIndicator();
            this.btnSaveQuestionsInfo = new Guna.UI2.WinForms.Guna2Button();
            this.label13 = new System.Windows.Forms.Label();
            this.tbAnswer = new Guna.UI2.WinForms.Guna2TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tbOption4 = new Guna.UI2.WinForms.Guna2TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbOption3 = new Guna.UI2.WinForms.Guna2TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbOption2 = new Guna.UI2.WinForms.Guna2TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.QuizInfoContainer = new System.Windows.Forms.Panel();
            this.Loader1 = new Guna.UI2.WinForms.Guna2ProgressIndicator();
            this.btnSaveQuizInfo = new Guna.UI2.WinForms.Guna2Button();
            this.label6 = new System.Windows.Forms.Label();
            this.NumofQues = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbCategorie = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbQuizName = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.txtQuestion = new System.Windows.Forms.Label();
            this.QuestionInfoContainer = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse4 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.AddCategoriConrainer = new Guna.UI2.WinForms.Guna2Panel();
            this.Loader3 = new Guna.UI2.WinForms.Guna2ProgressIndicator();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.btnSaveCategori = new Guna.UI2.WinForms.Guna2Button();
            this.tbNewCategori = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnAddCategori = new Guna.UI2.WinForms.Guna2Button();
            this.LoaderTimer1 = new System.Windows.Forms.Timer(this.components);
            this.LoaderTimer2 = new System.Windows.Forms.Timer(this.components);
            this.LoaderTimer3 = new System.Windows.Forms.Timer(this.components);
            this.OptionsInfoContainer.SuspendLayout();
            this.QuizInfoContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumofQues)).BeginInit();
            this.QuestionInfoContainer.SuspendLayout();
            this.AddCategoriConrainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbQuestion
            // 
            this.tbQuestion.Animated = true;
            this.tbQuestion.BorderRadius = 5;
            this.tbQuestion.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbQuestion.DefaultText = "";
            this.tbQuestion.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbQuestion.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbQuestion.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbQuestion.DisabledState.Parent = this.tbQuestion;
            this.tbQuestion.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbQuestion.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbQuestion.FocusedState.Parent = this.tbQuestion;
            this.tbQuestion.HoverState.BorderColor = System.Drawing.Color.Gray;
            this.tbQuestion.HoverState.Parent = this.tbQuestion;
            this.tbQuestion.Location = new System.Drawing.Point(33, 96);
            this.tbQuestion.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tbQuestion.Name = "tbQuestion";
            this.tbQuestion.PasswordChar = '\0';
            this.tbQuestion.PlaceholderText = "";
            this.tbQuestion.SelectedText = "";
            this.tbQuestion.ShadowDecoration.Parent = this.tbQuestion;
            this.tbQuestion.Size = new System.Drawing.Size(375, 88);
            this.tbQuestion.TabIndex = 0;
            this.tbQuestion.TextOffset = new System.Drawing.Point(0, -25);
            this.tbQuestion.Leave += new System.EventHandler(this.IsFailedStillEmpty);
            // 
            // tbOption1
            // 
            this.tbOption1.Animated = true;
            this.tbOption1.BorderRadius = 5;
            this.tbOption1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbOption1.DefaultText = "";
            this.tbOption1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbOption1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbOption1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbOption1.DisabledState.Parent = this.tbOption1;
            this.tbOption1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbOption1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbOption1.FocusedState.Parent = this.tbOption1;
            this.tbOption1.Font = new System.Drawing.Font("Tahoma", 9F);
            this.tbOption1.HoverState.BorderColor = System.Drawing.Color.Gray;
            this.tbOption1.HoverState.Parent = this.tbOption1;
            this.tbOption1.Location = new System.Drawing.Point(32, 110);
            this.tbOption1.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.tbOption1.Name = "tbOption1";
            this.tbOption1.PasswordChar = '\0';
            this.tbOption1.PlaceholderText = "";
            this.tbOption1.SelectedText = "";
            this.tbOption1.ShadowDecoration.Parent = this.tbOption1;
            this.tbOption1.Size = new System.Drawing.Size(371, 49);
            this.tbOption1.TabIndex = 2;
            this.tbOption1.Leave += new System.EventHandler(this.IsFailedStillEmpty);
            // 
            // OptionsInfoContainer
            // 
            this.OptionsInfoContainer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.OptionsInfoContainer.BackColor = System.Drawing.Color.White;
            this.OptionsInfoContainer.Controls.Add(this.Loader2);
            this.OptionsInfoContainer.Controls.Add(this.btnSaveQuestionsInfo);
            this.OptionsInfoContainer.Controls.Add(this.label13);
            this.OptionsInfoContainer.Controls.Add(this.tbAnswer);
            this.OptionsInfoContainer.Controls.Add(this.label11);
            this.OptionsInfoContainer.Controls.Add(this.tbOption4);
            this.OptionsInfoContainer.Controls.Add(this.label10);
            this.OptionsInfoContainer.Controls.Add(this.tbOption3);
            this.OptionsInfoContainer.Controls.Add(this.label9);
            this.OptionsInfoContainer.Controls.Add(this.tbOption2);
            this.OptionsInfoContainer.Controls.Add(this.label8);
            this.OptionsInfoContainer.Controls.Add(this.label1);
            this.OptionsInfoContainer.Controls.Add(this.tbOption1);
            this.OptionsInfoContainer.Enabled = false;
            this.OptionsInfoContainer.Location = new System.Drawing.Point(737, 77);
            this.OptionsInfoContainer.Name = "OptionsInfoContainer";
            this.OptionsInfoContainer.Size = new System.Drawing.Size(430, 629);
            this.OptionsInfoContainer.TabIndex = 7;
            // 
            // Loader2
            // 
            this.Loader2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Loader2.CircleSize = 1F;
            this.Loader2.Location = new System.Drawing.Point(244, 580);
            this.Loader2.Name = "Loader2";
            this.Loader2.ProgressColor = System.Drawing.Color.White;
            this.Loader2.Size = new System.Drawing.Size(30, 30);
            this.Loader2.TabIndex = 21;
            this.Loader2.Visible = false;
            // 
            // btnSaveQuestionsInfo
            // 
            this.btnSaveQuestionsInfo.Animated = true;
            this.btnSaveQuestionsInfo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSaveQuestionsInfo.BorderRadius = 5;
            this.btnSaveQuestionsInfo.CheckedState.Parent = this.btnSaveQuestionsInfo;
            this.btnSaveQuestionsInfo.CustomImages.Parent = this.btnSaveQuestionsInfo;
            this.btnSaveQuestionsInfo.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSaveQuestionsInfo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnSaveQuestionsInfo.ForeColor = System.Drawing.Color.White;
            this.btnSaveQuestionsInfo.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSaveQuestionsInfo.HoverState.Parent = this.btnSaveQuestionsInfo;
            this.btnSaveQuestionsInfo.ImageOffset = new System.Drawing.Point(27, 0);
            this.btnSaveQuestionsInfo.Location = new System.Drawing.Point(32, 573);
            this.btnSaveQuestionsInfo.Name = "btnSaveQuestionsInfo";
            this.btnSaveQuestionsInfo.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSaveQuestionsInfo.PressedDepth = 10;
            this.btnSaveQuestionsInfo.ShadowDecoration.Parent = this.btnSaveQuestionsInfo;
            this.btnSaveQuestionsInfo.Size = new System.Drawing.Size(375, 45);
            this.btnSaveQuestionsInfo.TabIndex = 22;
            this.btnSaveQuestionsInfo.Text = "Save";
            this.btnSaveQuestionsInfo.Click += new System.EventHandler(this.btnSaveQuestionsInfo_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label13.ForeColor = System.Drawing.Color.Gray;
            this.label13.Location = new System.Drawing.Point(28, 441);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(69, 23);
            this.label13.TabIndex = 21;
            this.label13.Text = "Answer";
            // 
            // tbAnswer
            // 
            this.tbAnswer.Animated = true;
            this.tbAnswer.BorderRadius = 5;
            this.tbAnswer.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbAnswer.DefaultText = "";
            this.tbAnswer.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbAnswer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbAnswer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbAnswer.DisabledState.Parent = this.tbAnswer;
            this.tbAnswer.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbAnswer.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbAnswer.FocusedState.Parent = this.tbAnswer;
            this.tbAnswer.HoverState.BorderColor = System.Drawing.Color.Gray;
            this.tbAnswer.HoverState.Parent = this.tbAnswer;
            this.tbAnswer.Location = new System.Drawing.Point(32, 468);
            this.tbAnswer.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tbAnswer.Name = "tbAnswer";
            this.tbAnswer.PasswordChar = '\0';
            this.tbAnswer.PlaceholderText = "";
            this.tbAnswer.SelectedText = "";
            this.tbAnswer.ShadowDecoration.Parent = this.tbAnswer;
            this.tbAnswer.Size = new System.Drawing.Size(371, 49);
            this.tbAnswer.TabIndex = 20;
            this.tbAnswer.Leave += new System.EventHandler(this.IsFailedStillEmpty);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.Gray;
            this.label11.Location = new System.Drawing.Point(28, 342);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(81, 23);
            this.label11.TabIndex = 19;
            this.label11.Text = "Option 4";
            // 
            // tbOption4
            // 
            this.tbOption4.Animated = true;
            this.tbOption4.BorderRadius = 5;
            this.tbOption4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbOption4.DefaultText = "";
            this.tbOption4.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbOption4.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbOption4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbOption4.DisabledState.Parent = this.tbOption4;
            this.tbOption4.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbOption4.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbOption4.FocusedState.Parent = this.tbOption4;
            this.tbOption4.HoverState.BorderColor = System.Drawing.Color.Gray;
            this.tbOption4.HoverState.Parent = this.tbOption4;
            this.tbOption4.Location = new System.Drawing.Point(32, 371);
            this.tbOption4.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tbOption4.Name = "tbOption4";
            this.tbOption4.PasswordChar = '\0';
            this.tbOption4.PlaceholderText = "";
            this.tbOption4.SelectedText = "";
            this.tbOption4.ShadowDecoration.Parent = this.tbOption4;
            this.tbOption4.Size = new System.Drawing.Size(371, 49);
            this.tbOption4.TabIndex = 18;
            this.tbOption4.Leave += new System.EventHandler(this.IsFailedStillEmpty);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.Gray;
            this.label10.Location = new System.Drawing.Point(32, 252);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 23);
            this.label10.TabIndex = 17;
            this.label10.Text = "Option 3";
            // 
            // tbOption3
            // 
            this.tbOption3.Animated = true;
            this.tbOption3.BorderRadius = 5;
            this.tbOption3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbOption3.DefaultText = "";
            this.tbOption3.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbOption3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbOption3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbOption3.DisabledState.Parent = this.tbOption3;
            this.tbOption3.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbOption3.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbOption3.FocusedState.Parent = this.tbOption3;
            this.tbOption3.HoverState.BorderColor = System.Drawing.Color.Gray;
            this.tbOption3.HoverState.Parent = this.tbOption3;
            this.tbOption3.Location = new System.Drawing.Point(32, 287);
            this.tbOption3.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tbOption3.Name = "tbOption3";
            this.tbOption3.PasswordChar = '\0';
            this.tbOption3.PlaceholderText = "";
            this.tbOption3.SelectedText = "";
            this.tbOption3.ShadowDecoration.Parent = this.tbOption3;
            this.tbOption3.Size = new System.Drawing.Size(371, 49);
            this.tbOption3.TabIndex = 16;
            this.tbOption3.Leave += new System.EventHandler(this.IsFailedStillEmpty);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.Gray;
            this.label9.Location = new System.Drawing.Point(28, 165);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 23);
            this.label9.TabIndex = 15;
            this.label9.Text = "Option 2";
            // 
            // tbOption2
            // 
            this.tbOption2.Animated = true;
            this.tbOption2.BorderRadius = 5;
            this.tbOption2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbOption2.DefaultText = "";
            this.tbOption2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbOption2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbOption2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbOption2.DisabledState.Parent = this.tbOption2;
            this.tbOption2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbOption2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbOption2.FocusedState.Parent = this.tbOption2;
            this.tbOption2.HoverState.BorderColor = System.Drawing.Color.Gray;
            this.tbOption2.HoverState.Parent = this.tbOption2;
            this.tbOption2.Location = new System.Drawing.Point(32, 197);
            this.tbOption2.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tbOption2.Name = "tbOption2";
            this.tbOption2.PasswordChar = '\0';
            this.tbOption2.PlaceholderText = "";
            this.tbOption2.SelectedText = "";
            this.tbOption2.ShadowDecoration.Parent = this.tbOption2;
            this.tbOption2.Size = new System.Drawing.Size(371, 49);
            this.tbOption2.TabIndex = 14;
            this.tbOption2.Leave += new System.EventHandler(this.IsFailedStillEmpty);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.Gray;
            this.label8.Location = new System.Drawing.Point(28, 79);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 23);
            this.label8.TabIndex = 13;
            this.label8.Text = "Option 1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(22, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 35);
            this.label1.TabIndex = 8;
            this.label1.Text = "Options Info";
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 10;
            this.guna2Elipse1.TargetControl = this.OptionsInfoContainer;
            // 
            // QuizInfoContainer
            // 
            this.QuizInfoContainer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.QuizInfoContainer.BackColor = System.Drawing.Color.White;
            this.QuizInfoContainer.Controls.Add(this.Loader1);
            this.QuizInfoContainer.Controls.Add(this.btnSaveQuizInfo);
            this.QuizInfoContainer.Controls.Add(this.label6);
            this.QuizInfoContainer.Controls.Add(this.NumofQues);
            this.QuizInfoContainer.Controls.Add(this.label5);
            this.QuizInfoContainer.Controls.Add(this.label4);
            this.QuizInfoContainer.Controls.Add(this.cbCategorie);
            this.QuizInfoContainer.Controls.Add(this.label2);
            this.QuizInfoContainer.Controls.Add(this.tbQuizName);
            this.QuizInfoContainer.Location = new System.Drawing.Point(48, 77);
            this.QuizInfoContainer.Name = "QuizInfoContainer";
            this.QuizInfoContainer.Size = new System.Drawing.Size(439, 409);
            this.QuizInfoContainer.TabIndex = 8;
            // 
            // Loader1
            // 
            this.Loader1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Loader1.CircleSize = 1F;
            this.Loader1.Location = new System.Drawing.Point(244, 359);
            this.Loader1.Name = "Loader1";
            this.Loader1.ProgressColor = System.Drawing.Color.White;
            this.Loader1.Size = new System.Drawing.Size(30, 30);
            this.Loader1.TabIndex = 19;
            this.Loader1.Visible = false;
            // 
            // btnSaveQuizInfo
            // 
            this.btnSaveQuizInfo.Animated = true;
            this.btnSaveQuizInfo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSaveQuizInfo.BorderRadius = 5;
            this.btnSaveQuizInfo.CheckedState.Parent = this.btnSaveQuizInfo;
            this.btnSaveQuizInfo.CustomImages.Parent = this.btnSaveQuizInfo;
            this.btnSaveQuizInfo.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSaveQuizInfo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnSaveQuizInfo.ForeColor = System.Drawing.Color.White;
            this.btnSaveQuizInfo.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSaveQuizInfo.HoverState.Parent = this.btnSaveQuizInfo;
            this.btnSaveQuizInfo.ImageOffset = new System.Drawing.Point(27, 0);
            this.btnSaveQuizInfo.Location = new System.Drawing.Point(33, 352);
            this.btnSaveQuizInfo.Name = "btnSaveQuizInfo";
            this.btnSaveQuizInfo.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSaveQuizInfo.PressedDepth = 10;
            this.btnSaveQuizInfo.ShadowDecoration.Parent = this.btnSaveQuizInfo;
            this.btnSaveQuizInfo.Size = new System.Drawing.Size(375, 45);
            this.btnSaveQuizInfo.TabIndex = 16;
            this.btnSaveQuizInfo.Text = "Save";
            this.btnSaveQuizInfo.Click += new System.EventHandler(this.btnSaveQuizInfo_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.Gray;
            this.label6.Location = new System.Drawing.Point(33, 242);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(157, 23);
            this.label6.TabIndex = 14;
            this.label6.Text = "Num Of Questions";
            // 
            // NumofQues
            // 
            this.NumofQues.AutoRoundedCorners = true;
            this.NumofQues.BackColor = System.Drawing.Color.Transparent;
            this.NumofQues.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.NumofQues.BorderRadius = 21;
            this.NumofQues.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NumofQues.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.NumofQues.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.NumofQues.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.NumofQues.DisabledState.Parent = this.NumofQues;
            this.NumofQues.DisabledState.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(177)))), ((int)(((byte)(177)))));
            this.NumofQues.DisabledState.UpDownButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.NumofQues.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.NumofQues.FocusedState.Parent = this.NumofQues;
            this.NumofQues.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumofQues.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.NumofQues.Location = new System.Drawing.Point(33, 268);
            this.NumofQues.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.NumofQues.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumofQues.Name = "NumofQues";
            this.NumofQues.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.NumofQues.ShadowDecoration.Parent = this.NumofQues;
            this.NumofQues.Size = new System.Drawing.Size(375, 45);
            this.NumofQues.TabIndex = 13;
            this.NumofQues.ThousandsSeparator = true;
            this.NumofQues.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.NumofQues.UpDownButtonForeColor = System.Drawing.Color.Gray;
            this.NumofQues.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Gray;
            this.label5.Location = new System.Drawing.Point(33, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 23);
            this.label5.TabIndex = 12;
            this.label5.Text = "Quiz Categorie";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(33, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 23);
            this.label4.TabIndex = 11;
            this.label4.Text = "Quiz Name";
            // 
            // cbCategorie
            // 
            this.cbCategorie.Animated = true;
            this.cbCategorie.BackColor = System.Drawing.Color.Transparent;
            this.cbCategorie.BorderRadius = 5;
            this.cbCategorie.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbCategorie.DropDownHeight = 300;
            this.cbCategorie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategorie.FocusedColor = System.Drawing.Color.Empty;
            this.cbCategorie.FocusedState.Parent = this.cbCategorie;
            this.cbCategorie.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbCategorie.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbCategorie.FormattingEnabled = true;
            this.cbCategorie.HoverState.Parent = this.cbCategorie;
            this.cbCategorie.IntegralHeight = false;
            this.cbCategorie.ItemHeight = 30;
            this.cbCategorie.ItemsAppearance.Parent = this.cbCategorie;
            this.cbCategorie.Location = new System.Drawing.Point(33, 189);
            this.cbCategorie.MaxDropDownItems = 100;
            this.cbCategorie.Name = "cbCategorie";
            this.cbCategorie.ShadowDecoration.Parent = this.cbCategorie;
            this.cbCategorie.Size = new System.Drawing.Size(375, 36);
            this.cbCategorie.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(27, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 35);
            this.label2.TabIndex = 8;
            this.label2.Text = "Quiz Info";
            // 
            // tbQuizName
            // 
            this.tbQuizName.Animated = true;
            this.tbQuizName.BorderRadius = 5;
            this.tbQuizName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbQuizName.DefaultText = "";
            this.tbQuizName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbQuizName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbQuizName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbQuizName.DisabledState.Parent = this.tbQuizName;
            this.tbQuizName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbQuizName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbQuizName.FocusedState.Parent = this.tbQuizName;
            this.tbQuizName.HoverState.BorderColor = System.Drawing.Color.Gray;
            this.tbQuizName.HoverState.Parent = this.tbQuizName;
            this.tbQuizName.Location = new System.Drawing.Point(33, 106);
            this.tbQuizName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbQuizName.Name = "tbQuizName";
            this.tbQuizName.PasswordChar = '\0';
            this.tbQuizName.PlaceholderText = "";
            this.tbQuizName.SelectedText = "";
            this.tbQuizName.ShadowDecoration.Parent = this.tbQuizName;
            this.tbQuizName.Size = new System.Drawing.Size(375, 49);
            this.tbQuizName.TabIndex = 0;
            this.tbQuizName.Leave += new System.EventHandler(this.IsFailedStillEmpty);
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 10;
            this.guna2Elipse2.TargetControl = this.QuizInfoContainer;
            // 
            // txtQuestion
            // 
            this.txtQuestion.AutoSize = true;
            this.txtQuestion.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.txtQuestion.ForeColor = System.Drawing.Color.Gray;
            this.txtQuestion.Location = new System.Drawing.Point(33, 69);
            this.txtQuestion.Name = "txtQuestion";
            this.txtQuestion.Size = new System.Drawing.Size(81, 23);
            this.txtQuestion.TabIndex = 12;
            this.txtQuestion.Text = "Question";
            // 
            // QuestionInfoContainer
            // 
            this.QuestionInfoContainer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.QuestionInfoContainer.BackColor = System.Drawing.Color.White;
            this.QuestionInfoContainer.Controls.Add(this.label12);
            this.QuestionInfoContainer.Controls.Add(this.tbQuestion);
            this.QuestionInfoContainer.Controls.Add(this.txtQuestion);
            this.QuestionInfoContainer.Enabled = false;
            this.QuestionInfoContainer.Location = new System.Drawing.Point(48, 502);
            this.QuestionInfoContainer.Name = "QuestionInfoContainer";
            this.QuestionInfoContainer.Size = new System.Drawing.Size(439, 204);
            this.QuestionInfoContainer.TabIndex = 15;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label12.Location = new System.Drawing.Point(27, 16);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(176, 35);
            this.label12.TabIndex = 9;
            this.label12.Text = "Question Info";
            // 
            // guna2Elipse3
            // 
            this.guna2Elipse3.BorderRadius = 10;
            this.guna2Elipse3.TargetControl = this.QuestionInfoContainer;
            // 
            // guna2Elipse4
            // 
            this.guna2Elipse4.BorderRadius = 10;
            this.guna2Elipse4.TargetControl = this.AddCategoriConrainer;
            // 
            // AddCategoriConrainer
            // 
            this.AddCategoriConrainer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AddCategoriConrainer.BackColor = System.Drawing.Color.White;
            this.AddCategoriConrainer.Controls.Add(this.Loader3);
            this.AddCategoriConrainer.Controls.Add(this.btnClose);
            this.AddCategoriConrainer.Controls.Add(this.btnSaveCategori);
            this.AddCategoriConrainer.Controls.Add(this.tbNewCategori);
            this.AddCategoriConrainer.Location = new System.Drawing.Point(639, 24);
            this.AddCategoriConrainer.Name = "AddCategoriConrainer";
            this.AddCategoriConrainer.ShadowDecoration.Parent = this.AddCategoriConrainer;
            this.AddCategoriConrainer.Size = new System.Drawing.Size(528, 46);
            this.AddCategoriConrainer.TabIndex = 18;
            this.AddCategoriConrainer.Visible = false;
            // 
            // Loader3
            // 
            this.Loader3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Loader3.CircleSize = 1F;
            this.Loader3.Location = new System.Drawing.Point(357, 7);
            this.Loader3.Name = "Loader3";
            this.Loader3.ProgressColor = System.Drawing.Color.White;
            this.Loader3.Size = new System.Drawing.Size(30, 30);
            this.Loader3.TabIndex = 20;
            this.Loader3.Visible = false;
            // 
            // btnClose
            // 
            this.btnClose.Animated = true;
            this.btnClose.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnClose.BorderRadius = 5;
            this.btnClose.BorderThickness = 1;
            this.btnClose.CheckedState.Parent = this.btnClose;
            this.btnClose.CustomImages.Parent = this.btnClose;
            this.btnClose.FillColor = System.Drawing.Color.White;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnClose.HoverState.Parent = this.btnClose;
            this.btnClose.Location = new System.Drawing.Point(402, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.ShadowDecoration.Parent = this.btnClose;
            this.btnClose.Size = new System.Drawing.Size(118, 35);
            this.btnClose.TabIndex = 20;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSaveCategori
            // 
            this.btnSaveCategori.Animated = true;
            this.btnSaveCategori.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSaveCategori.BorderRadius = 5;
            this.btnSaveCategori.CheckedState.Parent = this.btnSaveCategori;
            this.btnSaveCategori.CustomImages.Parent = this.btnSaveCategori;
            this.btnSaveCategori.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSaveCategori.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnSaveCategori.ForeColor = System.Drawing.Color.White;
            this.btnSaveCategori.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSaveCategori.HoverState.Parent = this.btnSaveCategori;
            this.btnSaveCategori.ImageOffset = new System.Drawing.Point(30, 0);
            this.btnSaveCategori.Location = new System.Drawing.Point(278, 5);
            this.btnSaveCategori.Name = "btnSaveCategori";
            this.btnSaveCategori.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSaveCategori.PressedDepth = 10;
            this.btnSaveCategori.ShadowDecoration.Parent = this.btnSaveCategori;
            this.btnSaveCategori.Size = new System.Drawing.Size(118, 35);
            this.btnSaveCategori.TabIndex = 19;
            this.btnSaveCategori.Text = "Save";
            this.btnSaveCategori.Click += new System.EventHandler(this.btnSaveCategori_Click);
            // 
            // tbNewCategori
            // 
            this.tbNewCategori.Animated = true;
            this.tbNewCategori.BorderRadius = 8;
            this.tbNewCategori.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbNewCategori.DefaultText = "";
            this.tbNewCategori.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbNewCategori.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbNewCategori.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbNewCategori.DisabledState.Parent = this.tbNewCategori;
            this.tbNewCategori.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbNewCategori.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbNewCategori.FocusedState.Parent = this.tbNewCategori;
            this.tbNewCategori.Font = new System.Drawing.Font("Tahoma", 9F);
            this.tbNewCategori.HoverState.BorderColor = System.Drawing.Color.Gray;
            this.tbNewCategori.HoverState.Parent = this.tbNewCategori;
            this.tbNewCategori.Location = new System.Drawing.Point(6, 5);
            this.tbNewCategori.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.tbNewCategori.Name = "tbNewCategori";
            this.tbNewCategori.PasswordChar = '\0';
            this.tbNewCategori.PlaceholderText = "Add New Categori";
            this.tbNewCategori.SelectedText = "";
            this.tbNewCategori.ShadowDecoration.Parent = this.tbNewCategori;
            this.tbNewCategori.Size = new System.Drawing.Size(263, 35);
            this.tbNewCategori.TabIndex = 19;
            this.tbNewCategori.Enter += new System.EventHandler(this.tbNewCategori_Enter);
            this.tbNewCategori.Leave += new System.EventHandler(this.IsFailedStillEmpty);
            // 
            // btnAddCategori
            // 
            this.btnAddCategori.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddCategori.Animated = true;
            this.btnAddCategori.BorderRadius = 10;
            this.btnAddCategori.CheckedState.Parent = this.btnAddCategori;
            this.btnAddCategori.CustomImages.Parent = this.btnAddCategori;
            this.btnAddCategori.FillColor = System.Drawing.Color.White;
            this.btnAddCategori.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnAddCategori.ForeColor = System.Drawing.Color.Gray;
            this.btnAddCategori.HoverState.Parent = this.btnAddCategori;
            this.btnAddCategori.Image = ((System.Drawing.Image)(resources.GetObject("btnAddCategori.Image")));
            this.btnAddCategori.ImageSize = new System.Drawing.Size(30, 30);
            this.btnAddCategori.Location = new System.Drawing.Point(48, 24);
            this.btnAddCategori.Name = "btnAddCategori";
            this.btnAddCategori.ShadowDecoration.Parent = this.btnAddCategori;
            this.btnAddCategori.Size = new System.Drawing.Size(179, 47);
            this.btnAddCategori.TabIndex = 17;
            this.btnAddCategori.Text = "Add Categorie";
            this.btnAddCategori.TextOffset = new System.Drawing.Point(2, 0);
            this.btnAddCategori.Click += new System.EventHandler(this.btnAddCategori_Click);
            // 
            // LoaderTimer1
            // 
            this.LoaderTimer1.Interval = 1000;
            this.LoaderTimer1.Tick += new System.EventHandler(this.LoaderTimer1_Tick);
            // 
            // LoaderTimer2
            // 
            this.LoaderTimer2.Interval = 1000;
            this.LoaderTimer2.Tick += new System.EventHandler(this.LoaderTimer2_Tick);
            // 
            // LoaderTimer3
            // 
            this.LoaderTimer3.Interval = 1000;
            this.LoaderTimer3.Tick += new System.EventHandler(this.LoaderTimer3_Tick);
            // 
            // AddQuiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1210, 719);
            this.Controls.Add(this.AddCategoriConrainer);
            this.Controls.Add(this.btnAddCategori);
            this.Controls.Add(this.QuestionInfoContainer);
            this.Controls.Add(this.QuizInfoContainer);
            this.Controls.Add(this.OptionsInfoContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddQuiz";
            this.Text = "AddQuiz";
            this.Load += new System.EventHandler(this.AddQuiz_Load);
            this.OptionsInfoContainer.ResumeLayout(false);
            this.OptionsInfoContainer.PerformLayout();
            this.QuizInfoContainer.ResumeLayout(false);
            this.QuizInfoContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumofQues)).EndInit();
            this.QuestionInfoContainer.ResumeLayout(false);
            this.QuestionInfoContainer.PerformLayout();
            this.AddCategoriConrainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox tbQuestion;
        private Guna.UI2.WinForms.Guna2TextBox tbOption1;
        private System.Windows.Forms.Panel OptionsInfoContainer;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel QuizInfoContainer;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox tbQuizName;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2ComboBox cbCategorie;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2NumericUpDown NumofQues;
        private System.Windows.Forms.Label txtQuestion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label11;
        private Guna.UI2.WinForms.Guna2TextBox tbOption4;
        private System.Windows.Forms.Label label10;
        private Guna.UI2.WinForms.Guna2TextBox tbOption3;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2TextBox tbOption2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel QuestionInfoContainer;
        private System.Windows.Forms.Label label12;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
        private System.Windows.Forms.Label label13;
        private Guna.UI2.WinForms.Guna2TextBox tbAnswer;
        private Guna.UI2.WinForms.Guna2Button btnSaveQuestionsInfo;
        private Guna.UI2.WinForms.Guna2Button btnSaveQuizInfo;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse4;
        private Guna.UI2.WinForms.Guna2Button btnAddCategori;
        private Guna.UI2.WinForms.Guna2Panel AddCategoriConrainer;
        private Guna.UI2.WinForms.Guna2Button btnSaveCategori;
        private Guna.UI2.WinForms.Guna2TextBox tbNewCategori;
        private Guna.UI2.WinForms.Guna2Button btnClose;
        private Guna.UI2.WinForms.Guna2ProgressIndicator Loader1;
        private Guna.UI2.WinForms.Guna2ProgressIndicator Loader3;
        private System.Windows.Forms.Timer LoaderTimer1;
        private System.Windows.Forms.Timer LoaderTimer2;
        private Guna.UI2.WinForms.Guna2ProgressIndicator Loader2;
        private System.Windows.Forms.Timer LoaderTimer3;
    }
}