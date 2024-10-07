namespace QuizzApp
{
    partial class QuizSettings
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
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.SelectedCategory = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.SelectedQuiz = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.btnStartQuiz = new Guna.UI2.WinForms.Guna2Button();
            this.LoaderTimer = new System.Windows.Forms.Timer(this.components);
            this.Loader = new Guna.UI2.WinForms.Guna2ProgressIndicator();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.SelectedTime = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.guna2Panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(284, 13);
            this.guna2HtmlLabel1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(301, 43);
            this.guna2HtmlLabel1.TabIndex = 15;
            this.guna2HtmlLabel1.Text = "Choose Quiz Settings";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(246, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(383, 19);
            this.label1.TabIndex = 17;
            this.label1.Text = "Select the category and then choose the quiz you want !";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guna2Panel1.BackColor = System.Drawing.Color.White;
            this.guna2Panel1.Controls.Add(this.SelectedCategory);
            this.guna2Panel1.Controls.Add(this.label2);
            this.guna2Panel1.Location = new System.Drawing.Point(250, 121);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(379, 111);
            this.guna2Panel1.TabIndex = 18;
            // 
            // SelectedCategory
            // 
            this.SelectedCategory.Animated = true;
            this.SelectedCategory.BackColor = System.Drawing.Color.Transparent;
            this.SelectedCategory.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.SelectedCategory.DropDownHeight = 300;
            this.SelectedCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SelectedCategory.FocusedColor = System.Drawing.Color.Empty;
            this.SelectedCategory.FocusedState.Parent = this.SelectedCategory;
            this.SelectedCategory.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.SelectedCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.SelectedCategory.FormattingEnabled = true;
            this.SelectedCategory.HoverState.Parent = this.SelectedCategory;
            this.SelectedCategory.IntegralHeight = false;
            this.SelectedCategory.ItemHeight = 30;
            this.SelectedCategory.ItemsAppearance.Parent = this.SelectedCategory;
            this.SelectedCategory.Location = new System.Drawing.Point(21, 63);
            this.SelectedCategory.MaxDropDownItems = 100;
            this.SelectedCategory.Name = "SelectedCategory";
            this.SelectedCategory.ShadowDecoration.Parent = this.SelectedCategory;
            this.SelectedCategory.Size = new System.Drawing.Size(339, 36);
            this.SelectedCategory.TabIndex = 19;
            this.SelectedCategory.SelectedIndexChanged += new System.EventHandler(this.SelectedCategory_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(19, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 23);
            this.label2.TabIndex = 18;
            this.label2.Text = "Select Category";
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guna2Panel2.BackColor = System.Drawing.Color.White;
            this.guna2Panel2.Controls.Add(this.SelectedQuiz);
            this.guna2Panel2.Controls.Add(this.label3);
            this.guna2Panel2.Location = new System.Drawing.Point(250, 269);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.ShadowDecoration.Parent = this.guna2Panel2;
            this.guna2Panel2.Size = new System.Drawing.Size(379, 111);
            this.guna2Panel2.TabIndex = 19;
            // 
            // SelectedQuiz
            // 
            this.SelectedQuiz.Animated = true;
            this.SelectedQuiz.BackColor = System.Drawing.Color.Transparent;
            this.SelectedQuiz.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.SelectedQuiz.DropDownHeight = 300;
            this.SelectedQuiz.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SelectedQuiz.FocusedColor = System.Drawing.Color.Empty;
            this.SelectedQuiz.FocusedState.Parent = this.SelectedQuiz;
            this.SelectedQuiz.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.SelectedQuiz.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.SelectedQuiz.FormattingEnabled = true;
            this.SelectedQuiz.HoverState.Parent = this.SelectedQuiz;
            this.SelectedQuiz.IntegralHeight = false;
            this.SelectedQuiz.ItemHeight = 30;
            this.SelectedQuiz.ItemsAppearance.Parent = this.SelectedQuiz;
            this.SelectedQuiz.Location = new System.Drawing.Point(21, 63);
            this.SelectedQuiz.MaxDropDownItems = 100;
            this.SelectedQuiz.Name = "SelectedQuiz";
            this.SelectedQuiz.ShadowDecoration.Parent = this.SelectedQuiz;
            this.SelectedQuiz.Size = new System.Drawing.Size(339, 36);
            this.SelectedQuiz.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(19, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 23);
            this.label3.TabIndex = 18;
            this.label3.Text = "Select Quiz";
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 10;
            this.guna2Elipse1.TargetControl = this.guna2Panel1;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 10;
            this.guna2Elipse2.TargetControl = this.guna2Panel2;
            // 
            // btnStartQuiz
            // 
            this.btnStartQuiz.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnStartQuiz.Animated = true;
            this.btnStartQuiz.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnStartQuiz.BorderRadius = 5;
            this.btnStartQuiz.CheckedState.Parent = this.btnStartQuiz;
            this.btnStartQuiz.CustomImages.Parent = this.btnStartQuiz;
            this.btnStartQuiz.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnStartQuiz.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnStartQuiz.ForeColor = System.Drawing.Color.White;
            this.btnStartQuiz.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnStartQuiz.HoverState.Parent = this.btnStartQuiz;
            this.btnStartQuiz.ImageOffset = new System.Drawing.Point(27, 0);
            this.btnStartQuiz.Location = new System.Drawing.Point(250, 555);
            this.btnStartQuiz.Name = "btnStartQuiz";
            this.btnStartQuiz.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnStartQuiz.PressedDepth = 10;
            this.btnStartQuiz.ShadowDecoration.Parent = this.btnStartQuiz;
            this.btnStartQuiz.Size = new System.Drawing.Size(379, 45);
            this.btnStartQuiz.TabIndex = 20;
            this.btnStartQuiz.Text = "Start";
            this.btnStartQuiz.Click += new System.EventHandler(this.btnStartQuiz_Click);
            // 
            // LoaderTimer
            // 
            this.LoaderTimer.Interval = 1000;
            this.LoaderTimer.Tick += new System.EventHandler(this.LoaderTimer_Tick);
            // 
            // Loader
            // 
            this.Loader.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Loader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Loader.CircleSize = 1F;
            this.Loader.Location = new System.Drawing.Point(460, 562);
            this.Loader.Name = "Loader";
            this.Loader.ProgressColor = System.Drawing.Color.White;
            this.Loader.Size = new System.Drawing.Size(30, 30);
            this.Loader.TabIndex = 22;
            this.Loader.Visible = false;
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guna2Panel3.BackColor = System.Drawing.Color.White;
            this.guna2Panel3.Controls.Add(this.SelectedTime);
            this.guna2Panel3.Controls.Add(this.label4);
            this.guna2Panel3.Location = new System.Drawing.Point(250, 413);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.ShadowDecoration.Parent = this.guna2Panel3;
            this.guna2Panel3.Size = new System.Drawing.Size(379, 111);
            this.guna2Panel3.TabIndex = 23;
            // 
            // SelectedTime
            // 
            this.SelectedTime.Animated = true;
            this.SelectedTime.BackColor = System.Drawing.Color.Transparent;
            this.SelectedTime.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.SelectedTime.DropDownHeight = 300;
            this.SelectedTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SelectedTime.FocusedColor = System.Drawing.Color.Empty;
            this.SelectedTime.FocusedState.Parent = this.SelectedTime;
            this.SelectedTime.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.SelectedTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.SelectedTime.FormattingEnabled = true;
            this.SelectedTime.HoverState.Parent = this.SelectedTime;
            this.SelectedTime.IntegralHeight = false;
            this.SelectedTime.ItemHeight = 30;
            this.SelectedTime.Items.AddRange(new object[] {
            "10",
            "20",
            "30",
            "40",
            "50",
            "60"});
            this.SelectedTime.ItemsAppearance.Parent = this.SelectedTime;
            this.SelectedTime.Location = new System.Drawing.Point(21, 63);
            this.SelectedTime.MaxDropDownItems = 100;
            this.SelectedTime.Name = "SelectedTime";
            this.SelectedTime.ShadowDecoration.Parent = this.SelectedTime;
            this.SelectedTime.Size = new System.Drawing.Size(339, 36);
            this.SelectedTime.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(19, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(209, 23);
            this.label4.TabIndex = 18;
            this.label4.Text = "Select Time Per Question";
            // 
            // QuizSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 612);
            this.Controls.Add(this.guna2Panel3);
            this.Controls.Add(this.Loader);
            this.Controls.Add(this.btnStartQuiz);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "QuizSettings";
            this.Text = "QuizSettings";
            this.Load += new System.EventHandler(this.QuizSettings_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            this.guna2Panel3.ResumeLayout(false);
            this.guna2Panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2ComboBox SelectedCategory;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2ComboBox SelectedQuiz;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Guna.UI2.WinForms.Guna2Button btnStartQuiz;
        private System.Windows.Forms.Timer LoaderTimer;
        private Guna.UI2.WinForms.Guna2ProgressIndicator Loader;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private Guna.UI2.WinForms.Guna2ComboBox SelectedTime;
        private System.Windows.Forms.Label label4;
    }
}