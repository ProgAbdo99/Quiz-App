namespace QuizzApp
{
    partial class Result
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
            this.txtHeader = new System.Windows.Forms.Label();
            this.txtMiniUploadText = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTotalXb = new System.Windows.Forms.Label();
            this.txtCategoreName = new System.Windows.Forms.Label();
            this.txtQuizName = new System.Windows.Forms.Label();
            this.txtCorrectAnswers = new System.Windows.Forms.Label();
            this.txtWrongAnswers = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtQuizXb = new System.Windows.Forms.Label();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.TotalXbTime = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // txtHeader
            // 
            this.txtHeader.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtHeader.AutoSize = true;
            this.txtHeader.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold);
            this.txtHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtHeader.Location = new System.Drawing.Point(377, 65);
            this.txtHeader.Name = "txtHeader";
            this.txtHeader.Size = new System.Drawing.Size(291, 67);
            this.txtHeader.TabIndex = 6;
            this.txtHeader.Text = "Game Over";
            // 
            // txtMiniUploadText
            // 
            this.txtMiniUploadText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMiniUploadText.AutoSize = true;
            this.txtMiniUploadText.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.txtMiniUploadText.ForeColor = System.Drawing.Color.Gray;
            this.txtMiniUploadText.Location = new System.Drawing.Point(311, 132);
            this.txtMiniUploadText.Name = "txtMiniUploadText";
            this.txtMiniUploadText.Size = new System.Drawing.Size(428, 19);
            this.txtMiniUploadText.TabIndex = 7;
            this.txtMiniUploadText.Text = "Here is the display of all information about the previous round";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(205, 288);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Quiz Name :";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(157, 326);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Correct Answers :";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(160, 367);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "Wrong Answers :";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(221, 253);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "Categore :";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Gray;
            this.label5.Location = new System.Drawing.Point(624, 253);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 25);
            this.label5.TabIndex = 12;
            this.label5.Text = "Total Xb";
            // 
            // txtTotalXb
            // 
            this.txtTotalXb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTotalXb.AutoSize = true;
            this.txtTotalXb.Font = new System.Drawing.Font("Segoe UI", 80F, System.Drawing.FontStyle.Bold);
            this.txtTotalXb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTotalXb.Location = new System.Drawing.Point(660, 274);
            this.txtTotalXb.Name = "txtTotalXb";
            this.txtTotalXb.Size = new System.Drawing.Size(152, 177);
            this.txtTotalXb.TabIndex = 13;
            this.txtTotalXb.Text = "0";
            // 
            // txtCategoreName
            // 
            this.txtCategoreName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCategoreName.AutoSize = true;
            this.txtCategoreName.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.txtCategoreName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCategoreName.Location = new System.Drawing.Point(330, 253);
            this.txtCategoreName.Name = "txtCategoreName";
            this.txtCategoreName.Size = new System.Drawing.Size(150, 25);
            this.txtCategoreName.TabIndex = 15;
            this.txtCategoreName.Text = "Categore Name";
            // 
            // txtQuizName
            // 
            this.txtQuizName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtQuizName.AutoSize = true;
            this.txtQuizName.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.txtQuizName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtQuizName.Location = new System.Drawing.Point(330, 288);
            this.txtQuizName.Name = "txtQuizName";
            this.txtQuizName.Size = new System.Drawing.Size(109, 25);
            this.txtQuizName.TabIndex = 16;
            this.txtQuizName.Text = "Quiz Name";
            // 
            // txtCorrectAnswers
            // 
            this.txtCorrectAnswers.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCorrectAnswers.AutoSize = true;
            this.txtCorrectAnswers.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.txtCorrectAnswers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCorrectAnswers.Location = new System.Drawing.Point(330, 326);
            this.txtCorrectAnswers.Name = "txtCorrectAnswers";
            this.txtCorrectAnswers.Size = new System.Drawing.Size(157, 25);
            this.txtCorrectAnswers.TabIndex = 17;
            this.txtCorrectAnswers.Text = "Correct Answers";
            // 
            // txtWrongAnswers
            // 
            this.txtWrongAnswers.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtWrongAnswers.AutoSize = true;
            this.txtWrongAnswers.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.txtWrongAnswers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtWrongAnswers.Location = new System.Drawing.Point(330, 367);
            this.txtWrongAnswers.Name = "txtWrongAnswers";
            this.txtWrongAnswers.Size = new System.Drawing.Size(154, 25);
            this.txtWrongAnswers.TabIndex = 18;
            this.txtWrongAnswers.Text = "Wrong Answers";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.Gray;
            this.label8.Location = new System.Drawing.Point(278, 406);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 25);
            this.label8.TabIndex = 19;
            this.label8.Text = "Xb :";
            // 
            // txtQuizXb
            // 
            this.txtQuizXb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtQuizXb.AutoSize = true;
            this.txtQuizXb.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.txtQuizXb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtQuizXb.Location = new System.Drawing.Point(330, 406);
            this.txtQuizXb.Name = "txtQuizXb";
            this.txtQuizXb.Size = new System.Drawing.Size(52, 25);
            this.txtQuizXb.TabIndex = 20;
            this.txtQuizXb.Text = "0 Xb";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnClose.Animated = true;
            this.btnClose.BackColor = System.Drawing.Color.White;
            this.btnClose.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnClose.BorderRadius = 5;
            this.btnClose.BorderThickness = 1;
            this.btnClose.CheckedState.Parent = this.btnClose;
            this.btnClose.CustomImages.Parent = this.btnClose;
            this.btnClose.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnClose.HoverState.FillColor = System.Drawing.SystemColors.Control;
            this.btnClose.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnClose.HoverState.Parent = this.btnClose;
            this.btnClose.Location = new System.Drawing.Point(297, 542);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.ShadowDecoration.Parent = this.btnClose;
            this.btnClose.Size = new System.Drawing.Size(470, 47);
            this.btnClose.TabIndex = 70;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // TotalXbTime
            // 
            this.TotalXbTime.Interval = 40;
            this.TotalXbTime.Tick += new System.EventHandler(this.TotalXbTime_Tick);
            // 
            // Result
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 616);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txtQuizXb);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtWrongAnswers);
            this.Controls.Add(this.txtCorrectAnswers);
            this.Controls.Add(this.txtQuizName);
            this.Controls.Add(this.txtCategoreName);
            this.Controls.Add(this.txtTotalXb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMiniUploadText);
            this.Controls.Add(this.txtHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Result";
            this.Text = "Result";
            this.Load += new System.EventHandler(this.Result_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtHeader;
        private System.Windows.Forms.Label txtMiniUploadText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label txtTotalXb;
        private System.Windows.Forms.Label txtCategoreName;
        private System.Windows.Forms.Label txtQuizName;
        private System.Windows.Forms.Label txtCorrectAnswers;
        private System.Windows.Forms.Label txtWrongAnswers;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label txtQuizXb;
        private Guna.UI2.WinForms.Guna2Button btnClose;
        private System.Windows.Forms.Timer TotalXbTime;
    }
}