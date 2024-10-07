namespace QuizzApp
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.ProfileImg = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.txtUserName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtXb = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtHeader = new System.Windows.Forms.Label();
            this.btnAddNewExam = new Guna.UI2.WinForms.Guna2Button();
            this.btnStartQuiz = new Guna.UI2.WinForms.Guna2Button();
            this.SectionsContainer = new System.Windows.Forms.Panel();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProfileImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.White;
            this.guna2Panel1.Controls.Add(this.ProfileImg);
            this.guna2Panel1.Controls.Add(this.txtUserName);
            this.guna2Panel1.Controls.Add(this.label3);
            this.guna2Panel1.Controls.Add(this.txtXb);
            this.guna2Panel1.Controls.Add(this.label2);
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Controls.Add(this.pictureBox1);
            this.guna2Panel1.Controls.Add(this.txtHeader);
            this.guna2Panel1.Controls.Add(this.btnAddNewExam);
            this.guna2Panel1.Controls.Add(this.btnStartQuiz);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(294, 749);
            this.guna2Panel1.TabIndex = 0;
            // 
            // ProfileImg
            // 
            this.ProfileImg.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ProfileImg.Image = ((System.Drawing.Image)(resources.GetObject("ProfileImg.Image")));
            this.ProfileImg.Location = new System.Drawing.Point(12, 12);
            this.ProfileImg.Name = "ProfileImg";
            this.ProfileImg.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.ProfileImg.ShadowDecoration.Parent = this.ProfileImg;
            this.ProfileImg.Size = new System.Drawing.Size(68, 66);
            this.ProfileImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.ProfileImg.TabIndex = 1;
            this.ProfileImg.TabStop = false;
            // 
            // txtUserName
            // 
            this.txtUserName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtUserName.AutoSize = true;
            this.txtUserName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.txtUserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtUserName.Location = new System.Drawing.Point(83, 23);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(97, 23);
            this.txtUserName.TabIndex = 4;
            this.txtUserName.Text = "User Name";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(92, 722);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "All rights reserved (2024)";
            // 
            // txtXb
            // 
            this.txtXb.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtXb.AutoSize = true;
            this.txtXb.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Bold);
            this.txtXb.ForeColor = System.Drawing.Color.Gray;
            this.txtXb.Location = new System.Drawing.Point(86, 46);
            this.txtXb.Name = "txtXb";
            this.txtXb.Size = new System.Drawing.Size(22, 15);
            this.txtXb.TabIndex = 5;
            this.txtXb.Text = "Xb";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(92, 707);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "© Questa v1.1";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(91, 688);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "Is the best quiz app !";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 662);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(68, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // txtHeader
            // 
            this.txtHeader.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtHeader.AutoSize = true;
            this.txtHeader.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.txtHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtHeader.Location = new System.Drawing.Point(81, 653);
            this.txtHeader.Name = "txtHeader";
            this.txtHeader.Size = new System.Drawing.Size(97, 35);
            this.txtHeader.TabIndex = 5;
            this.txtHeader.Text = "Questa";
            // 
            // btnAddNewExam
            // 
            this.btnAddNewExam.Animated = true;
            this.btnAddNewExam.BorderRadius = 20;
            this.btnAddNewExam.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnAddNewExam.CheckedState.FillColor = System.Drawing.Color.LightCyan;
            this.btnAddNewExam.CheckedState.ForeColor = System.Drawing.Color.CadetBlue;
            this.btnAddNewExam.CheckedState.Parent = this.btnAddNewExam;
            this.btnAddNewExam.CustomImages.Parent = this.btnAddNewExam;
            this.btnAddNewExam.FillColor = System.Drawing.Color.White;
            this.btnAddNewExam.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnAddNewExam.ForeColor = System.Drawing.Color.Gray;
            this.btnAddNewExam.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnAddNewExam.HoverState.Parent = this.btnAddNewExam;
            this.btnAddNewExam.Image = ((System.Drawing.Image)(resources.GetObject("btnAddNewExam.Image")));
            this.btnAddNewExam.ImageOffset = new System.Drawing.Point(-30, 0);
            this.btnAddNewExam.ImageSize = new System.Drawing.Size(30, 30);
            this.btnAddNewExam.Location = new System.Drawing.Point(5, 318);
            this.btnAddNewExam.Name = "btnAddNewExam";
            this.btnAddNewExam.PressedColor = System.Drawing.Color.Azure;
            this.btnAddNewExam.ShadowDecoration.Parent = this.btnAddNewExam;
            this.btnAddNewExam.Size = new System.Drawing.Size(268, 54);
            this.btnAddNewExam.TabIndex = 3;
            this.btnAddNewExam.Tag = "AddQuiz";
            this.btnAddNewExam.Text = "Add Quiz";
            this.btnAddNewExam.TextOffset = new System.Drawing.Point(-26, 0);
            this.btnAddNewExam.CheckedChanged += new System.EventHandler(this.UnCheckedState);
            this.btnAddNewExam.Click += new System.EventHandler(this.CheckedState);
            // 
            // btnStartQuiz
            // 
            this.btnStartQuiz.Animated = true;
            this.btnStartQuiz.BorderRadius = 20;
            this.btnStartQuiz.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnStartQuiz.CheckedState.FillColor = System.Drawing.Color.LightCyan;
            this.btnStartQuiz.CheckedState.ForeColor = System.Drawing.Color.CadetBlue;
            this.btnStartQuiz.CheckedState.Parent = this.btnStartQuiz;
            this.btnStartQuiz.CustomImages.Parent = this.btnStartQuiz;
            this.btnStartQuiz.FillColor = System.Drawing.Color.White;
            this.btnStartQuiz.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnStartQuiz.ForeColor = System.Drawing.Color.Gray;
            this.btnStartQuiz.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnStartQuiz.HoverState.Parent = this.btnStartQuiz;
            this.btnStartQuiz.Image = ((System.Drawing.Image)(resources.GetObject("btnStartQuiz.Image")));
            this.btnStartQuiz.ImageOffset = new System.Drawing.Point(-40, 0);
            this.btnStartQuiz.ImageSize = new System.Drawing.Size(30, 30);
            this.btnStartQuiz.Location = new System.Drawing.Point(5, 258);
            this.btnStartQuiz.Name = "btnStartQuiz";
            this.btnStartQuiz.PressedColor = System.Drawing.Color.Azure;
            this.btnStartQuiz.ShadowDecoration.Parent = this.btnStartQuiz;
            this.btnStartQuiz.Size = new System.Drawing.Size(268, 54);
            this.btnStartQuiz.TabIndex = 1;
            this.btnStartQuiz.Tag = "Quiz";
            this.btnStartQuiz.Text = "Quiz";
            this.btnStartQuiz.TextOffset = new System.Drawing.Point(-38, 0);
            this.btnStartQuiz.CheckedChanged += new System.EventHandler(this.UnCheckedState);
            this.btnStartQuiz.Click += new System.EventHandler(this.CheckedState);
            // 
            // SectionsContainer
            // 
            this.SectionsContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SectionsContainer.BackColor = System.Drawing.Color.WhiteSmoke;
            this.SectionsContainer.Location = new System.Drawing.Point(286, 0);
            this.SectionsContainer.Name = "SectionsContainer";
            this.SectionsContainer.Size = new System.Drawing.Size(1143, 749);
            this.SectionsContainer.TabIndex = 3;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1428, 749);
            this.Controls.Add(this.SectionsContainer);
            this.Controls.Add(this.guna2Panel1);
            this.Name = "Main";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Main_Load);
            this.Click += new System.EventHandler(this.CheckedState);
            this.Leave += new System.EventHandler(this.UnCheckedState);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProfileImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button btnStartQuiz;
        private Guna.UI2.WinForms.Guna2Button btnAddNewExam;
        private Guna.UI2.WinForms.Guna2CirclePictureBox ProfileImg;
        private System.Windows.Forms.Label txtUserName;
        private System.Windows.Forms.Label txtHeader;
        private System.Windows.Forms.Panel SectionsContainer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label txtXb;
    }
}