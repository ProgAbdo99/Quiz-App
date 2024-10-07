namespace QuizzApp
{
    partial class StartQuiz
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartQuiz));
            this.txtXb = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnResult = new Guna.UI2.WinForms.Guna2Button();
            this.btnNext = new Guna.UI2.WinForms.Guna2Button();
            this.btnCheck = new Guna.UI2.WinForms.Guna2Button();
            this.Option4 = new Guna.UI2.WinForms.Guna2Button();
            this.Option3 = new Guna.UI2.WinForms.Guna2Button();
            this.Option2 = new Guna.UI2.WinForms.Guna2Button();
            this.Option1 = new Guna.UI2.WinForms.Guna2Button();
            this.txtQuestion = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.TotalQues = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.CurrentQuestion = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtTime = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.TimerPar = new Guna.UI2.WinForms.Guna2ProgressBar();
            this.QuestionTimer = new System.Windows.Forms.Timer(this.components);
            this.XbTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtXb
            // 
            this.txtXb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtXb.BackColor = System.Drawing.Color.Transparent;
            this.txtXb.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.txtXb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtXb.Location = new System.Drawing.Point(836, 86);
            this.txtXb.Margin = new System.Windows.Forms.Padding(4);
            this.txtXb.Name = "txtXb";
            this.txtXb.Size = new System.Drawing.Size(15, 30);
            this.txtXb.TabIndex = 71;
            this.txtXb.Text = "0";
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.Location = new System.Drawing.Point(859, 92);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.ShadowDecoration.Parent = this.guna2PictureBox1;
            this.guna2PictureBox1.Size = new System.Drawing.Size(27, 24);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 70;
            this.guna2PictureBox1.TabStop = false;
            // 
            // btnResult
            // 
            this.btnResult.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnResult.Animated = true;
            this.btnResult.BackColor = System.Drawing.Color.White;
            this.btnResult.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnResult.BorderRadius = 5;
            this.btnResult.BorderThickness = 1;
            this.btnResult.CheckedState.Parent = this.btnResult;
            this.btnResult.CustomImages.Parent = this.btnResult;
            this.btnResult.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnResult.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnResult.ForeColor = System.Drawing.Color.White;
            this.btnResult.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnResult.HoverState.FillColor = System.Drawing.SystemColors.Control;
            this.btnResult.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnResult.HoverState.Parent = this.btnResult;
            this.btnResult.Location = new System.Drawing.Point(278, 549);
            this.btnResult.Margin = new System.Windows.Forms.Padding(4);
            this.btnResult.Name = "btnResult";
            this.btnResult.ShadowDecoration.Parent = this.btnResult;
            this.btnResult.Size = new System.Drawing.Size(470, 47);
            this.btnResult.TabIndex = 69;
            this.btnResult.Text = "See Result !";
            this.btnResult.Visible = false;
            this.btnResult.Click += new System.EventHandler(this.btnResult_Click);
            // 
            // btnNext
            // 
            this.btnNext.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnNext.Animated = true;
            this.btnNext.BackColor = System.Drawing.Color.White;
            this.btnNext.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnNext.BorderRadius = 5;
            this.btnNext.BorderThickness = 1;
            this.btnNext.CheckedState.Parent = this.btnNext;
            this.btnNext.CustomImages.Parent = this.btnNext;
            this.btnNext.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnNext.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnNext.HoverState.FillColor = System.Drawing.SystemColors.Control;
            this.btnNext.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnNext.HoverState.Parent = this.btnNext;
            this.btnNext.Location = new System.Drawing.Point(278, 549);
            this.btnNext.Margin = new System.Windows.Forms.Padding(4);
            this.btnNext.Name = "btnNext";
            this.btnNext.ShadowDecoration.Parent = this.btnNext;
            this.btnNext.Size = new System.Drawing.Size(470, 47);
            this.btnNext.TabIndex = 68;
            this.btnNext.Text = "Next";
            this.btnNext.Visible = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnCheck
            // 
            this.btnCheck.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCheck.Animated = true;
            this.btnCheck.BackColor = System.Drawing.Color.White;
            this.btnCheck.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCheck.BorderRadius = 5;
            this.btnCheck.BorderThickness = 1;
            this.btnCheck.CheckedState.Parent = this.btnCheck;
            this.btnCheck.CustomImages.Parent = this.btnCheck;
            this.btnCheck.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCheck.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnCheck.ForeColor = System.Drawing.Color.White;
            this.btnCheck.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCheck.HoverState.FillColor = System.Drawing.SystemColors.Control;
            this.btnCheck.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCheck.HoverState.Parent = this.btnCheck;
            this.btnCheck.Location = new System.Drawing.Point(278, 549);
            this.btnCheck.Margin = new System.Windows.Forms.Padding(4);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.ShadowDecoration.Parent = this.btnCheck;
            this.btnCheck.Size = new System.Drawing.Size(470, 47);
            this.btnCheck.TabIndex = 67;
            this.btnCheck.Text = "Check";
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // Option4
            // 
            this.Option4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Option4.Animated = true;
            this.Option4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Option4.BorderRadius = 8;
            this.Option4.BorderThickness = 1;
            this.Option4.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.Option4.CheckedState.BorderColor = System.Drawing.Color.Silver;
            this.Option4.CheckedState.FillColor = System.Drawing.Color.Gray;
            this.Option4.CheckedState.Parent = this.Option4;
            this.Option4.CustomImages.Parent = this.Option4;
            this.Option4.FillColor = System.Drawing.Color.White;
            this.Option4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.Option4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Option4.HoverState.BorderColor = System.Drawing.Color.White;
            this.Option4.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Option4.HoverState.ForeColor = System.Drawing.Color.White;
            this.Option4.HoverState.Parent = this.Option4;
            this.Option4.ImageOffset = new System.Drawing.Point(133, 0);
            this.Option4.Location = new System.Drawing.Point(125, 461);
            this.Option4.Margin = new System.Windows.Forms.Padding(4);
            this.Option4.Name = "Option4";
            this.Option4.ShadowDecoration.Color = System.Drawing.Color.Maroon;
            this.Option4.ShadowDecoration.Parent = this.Option4;
            this.Option4.Size = new System.Drawing.Size(762, 59);
            this.Option4.TabIndex = 66;
            this.Option4.Tag = "d";
            this.Option4.Text = "Option 4";
            this.Option4.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Option3
            // 
            this.Option3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Option3.Animated = true;
            this.Option3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Option3.BorderRadius = 8;
            this.Option3.BorderThickness = 1;
            this.Option3.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.Option3.CheckedState.BorderColor = System.Drawing.Color.Silver;
            this.Option3.CheckedState.FillColor = System.Drawing.Color.Gray;
            this.Option3.CheckedState.Parent = this.Option3;
            this.Option3.CustomImages.Parent = this.Option3;
            this.Option3.FillColor = System.Drawing.Color.White;
            this.Option3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.Option3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Option3.HoverState.BorderColor = System.Drawing.Color.White;
            this.Option3.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Option3.HoverState.ForeColor = System.Drawing.Color.White;
            this.Option3.HoverState.Parent = this.Option3;
            this.Option3.ImageOffset = new System.Drawing.Point(133, 0);
            this.Option3.Location = new System.Drawing.Point(125, 395);
            this.Option3.Margin = new System.Windows.Forms.Padding(4);
            this.Option3.Name = "Option3";
            this.Option3.ShadowDecoration.Color = System.Drawing.Color.Maroon;
            this.Option3.ShadowDecoration.Parent = this.Option3;
            this.Option3.Size = new System.Drawing.Size(762, 59);
            this.Option3.TabIndex = 65;
            this.Option3.Tag = "c";
            this.Option3.Text = "Option 3";
            this.Option3.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Option2
            // 
            this.Option2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Option2.Animated = true;
            this.Option2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Option2.BorderRadius = 8;
            this.Option2.BorderThickness = 1;
            this.Option2.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.Option2.CheckedState.BorderColor = System.Drawing.Color.Silver;
            this.Option2.CheckedState.FillColor = System.Drawing.Color.Gray;
            this.Option2.CheckedState.Parent = this.Option2;
            this.Option2.CustomImages.Parent = this.Option2;
            this.Option2.FillColor = System.Drawing.Color.White;
            this.Option2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.Option2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Option2.HoverState.BorderColor = System.Drawing.Color.White;
            this.Option2.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Option2.HoverState.ForeColor = System.Drawing.Color.White;
            this.Option2.HoverState.Parent = this.Option2;
            this.Option2.ImageOffset = new System.Drawing.Point(133, 0);
            this.Option2.Location = new System.Drawing.Point(125, 328);
            this.Option2.Margin = new System.Windows.Forms.Padding(4);
            this.Option2.Name = "Option2";
            this.Option2.ShadowDecoration.Color = System.Drawing.Color.Maroon;
            this.Option2.ShadowDecoration.Parent = this.Option2;
            this.Option2.Size = new System.Drawing.Size(762, 59);
            this.Option2.TabIndex = 64;
            this.Option2.Tag = "b";
            this.Option2.Text = "Option 2";
            this.Option2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Option1
            // 
            this.Option1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Option1.Animated = true;
            this.Option1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Option1.BorderRadius = 8;
            this.Option1.BorderThickness = 1;
            this.Option1.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.Option1.CheckedState.BorderColor = System.Drawing.Color.Silver;
            this.Option1.CheckedState.FillColor = System.Drawing.Color.Gray;
            this.Option1.CheckedState.Parent = this.Option1;
            this.Option1.CustomImages.Parent = this.Option1;
            this.Option1.FillColor = System.Drawing.Color.White;
            this.Option1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.Option1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Option1.HoverState.BorderColor = System.Drawing.Color.White;
            this.Option1.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Option1.HoverState.ForeColor = System.Drawing.Color.White;
            this.Option1.HoverState.Parent = this.Option1;
            this.Option1.ImageOffset = new System.Drawing.Point(133, 0);
            this.Option1.Location = new System.Drawing.Point(124, 262);
            this.Option1.Margin = new System.Windows.Forms.Padding(4);
            this.Option1.Name = "Option1";
            this.Option1.ShadowDecoration.Color = System.Drawing.Color.Maroon;
            this.Option1.ShadowDecoration.Parent = this.Option1;
            this.Option1.Size = new System.Drawing.Size(762, 59);
            this.Option1.TabIndex = 63;
            this.Option1.Tag = "a";
            this.Option1.Text = "Option 1";
            this.Option1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtQuestion
            // 
            this.txtQuestion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtQuestion.AutoSize = false;
            this.txtQuestion.BackColor = System.Drawing.Color.Transparent;
            this.txtQuestion.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.txtQuestion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtQuestion.Location = new System.Drawing.Point(125, 147);
            this.txtQuestion.Margin = new System.Windows.Forms.Padding(4);
            this.txtQuestion.Name = "txtQuestion";
            this.txtQuestion.Size = new System.Drawing.Size(762, 107);
            this.txtQuestion.TabIndex = 62;
            this.txtQuestion.Text = "Here The Question";
            // 
            // TotalQues
            // 
            this.TotalQues.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TotalQues.BackColor = System.Drawing.Color.Transparent;
            this.TotalQues.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.TotalQues.ForeColor = System.Drawing.Color.Silver;
            this.TotalQues.Location = new System.Drawing.Point(255, 92);
            this.TotalQues.Margin = new System.Windows.Forms.Padding(4);
            this.TotalQues.Name = "TotalQues";
            this.TotalQues.Size = new System.Drawing.Size(21, 27);
            this.TotalQues.TabIndex = 61;
            this.TotalQues.Text = "/5";
            // 
            // CurrentQuestion
            // 
            this.CurrentQuestion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CurrentQuestion.BackColor = System.Drawing.Color.Transparent;
            this.CurrentQuestion.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.CurrentQuestion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CurrentQuestion.Location = new System.Drawing.Point(125, 83);
            this.CurrentQuestion.Margin = new System.Windows.Forms.Padding(4);
            this.CurrentQuestion.Name = "CurrentQuestion";
            this.CurrentQuestion.Size = new System.Drawing.Size(130, 37);
            this.CurrentQuestion.TabIndex = 60;
            this.CurrentQuestion.Text = "Question 1";
            // 
            // txtTime
            // 
            this.txtTime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTime.BackColor = System.Drawing.Color.Transparent;
            this.txtTime.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.txtTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTime.Location = new System.Drawing.Point(495, 4);
            this.txtTime.Margin = new System.Windows.Forms.Padding(4);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(27, 30);
            this.txtTime.TabIndex = 59;
            this.txtTime.Text = "60";
            // 
            // TimerPar
            // 
            this.TimerPar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TimerPar.BackColor = System.Drawing.Color.White;
            this.TimerPar.BorderRadius = 5;
            this.TimerPar.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.TimerPar.Location = new System.Drawing.Point(125, 42);
            this.TimerPar.Margin = new System.Windows.Forms.Padding(4);
            this.TimerPar.Name = "TimerPar";
            this.TimerPar.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TimerPar.ProgressColor2 = System.Drawing.Color.Gray;
            this.TimerPar.ShadowDecoration.Parent = this.TimerPar;
            this.TimerPar.Size = new System.Drawing.Size(762, 33);
            this.TimerPar.TabIndex = 58;
            this.TimerPar.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.TimerPar.Value = 100;
            // 
            // QuestionTimer
            // 
            this.QuestionTimer.Interval = 1000;
            this.QuestionTimer.Tick += new System.EventHandler(this.QuestionTimer_Tick);
            // 
            // XbTimer
            // 
            this.XbTimer.Interval = 90;
            this.XbTimer.Tick += new System.EventHandler(this.XbTimer_Tick);
            // 
            // StartQuiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 609);
            this.Controls.Add(this.txtXb);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.btnResult);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.Option4);
            this.Controls.Add(this.Option3);
            this.Controls.Add(this.Option2);
            this.Controls.Add(this.Option1);
            this.Controls.Add(this.txtQuestion);
            this.Controls.Add(this.TotalQues);
            this.Controls.Add(this.CurrentQuestion);
            this.Controls.Add(this.txtTime);
            this.Controls.Add(this.TimerPar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StartQuiz";
            this.Text = "StartQuiz";
            this.Load += new System.EventHandler(this.StartQuiz_Load);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel txtXb;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2Button btnResult;
        private Guna.UI2.WinForms.Guna2Button btnNext;
        private Guna.UI2.WinForms.Guna2Button btnCheck;
        private Guna.UI2.WinForms.Guna2Button Option4;
        private Guna.UI2.WinForms.Guna2Button Option3;
        private Guna.UI2.WinForms.Guna2Button Option2;
        private Guna.UI2.WinForms.Guna2Button Option1;
        private Guna.UI2.WinForms.Guna2HtmlLabel txtQuestion;
        private Guna.UI2.WinForms.Guna2HtmlLabel TotalQues;
        private Guna.UI2.WinForms.Guna2HtmlLabel CurrentQuestion;
        private Guna.UI2.WinForms.Guna2HtmlLabel txtTime;
        private Guna.UI2.WinForms.Guna2ProgressBar TimerPar;
        private System.Windows.Forms.Timer QuestionTimer;
        private System.Windows.Forms.Timer XbTimer;
    }
}