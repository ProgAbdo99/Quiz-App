namespace QuizzApp
{
    partial class Signup
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
            this.DataContainer = new System.Windows.Forms.Panel();
            this.btnSignUp = new Guna.UI2.WinForms.Guna2Button();
            this.btnBackToLogin = new Guna.UI2.WinForms.Guna2Button();
            this.tbEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbPhone = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbUserName = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbLastName = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbMidName = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbFirstName = new Guna.UI2.WinForms.Guna2TextBox();
            this.UploadImage = new Guna.UI2.WinForms.Guna2PictureBox();
            this.ImageContainer = new System.Windows.Forms.Panel();
            this.txtMiniUploadText = new System.Windows.Forms.Label();
            this.txtMainUploadText = new System.Windows.Forms.Label();
            this.ProfileImage = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.ProfileImageExplorer = new System.Windows.Forms.OpenFileDialog();
            this.DataContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UploadImage)).BeginInit();
            this.ImageContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProfileImage)).BeginInit();
            this.SuspendLayout();
            // 
            // DataContainer
            // 
            this.DataContainer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DataContainer.BackColor = System.Drawing.Color.White;
            this.DataContainer.Controls.Add(this.btnSignUp);
            this.DataContainer.Controls.Add(this.btnBackToLogin);
            this.DataContainer.Controls.Add(this.tbEmail);
            this.DataContainer.Controls.Add(this.tbPhone);
            this.DataContainer.Controls.Add(this.tbPassword);
            this.DataContainer.Controls.Add(this.tbUserName);
            this.DataContainer.Controls.Add(this.tbLastName);
            this.DataContainer.Controls.Add(this.tbMidName);
            this.DataContainer.Controls.Add(this.tbFirstName);
            this.DataContainer.Location = new System.Drawing.Point(304, 156);
            this.DataContainer.Name = "DataContainer";
            this.DataContainer.Size = new System.Drawing.Size(392, 489);
            this.DataContainer.TabIndex = 0;
            // 
            // btnSignUp
            // 
            this.btnSignUp.Animated = true;
            this.btnSignUp.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSignUp.BorderRadius = 5;
            this.btnSignUp.CheckedState.Parent = this.btnSignUp;
            this.btnSignUp.CustomImages.Parent = this.btnSignUp;
            this.btnSignUp.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSignUp.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnSignUp.ForeColor = System.Drawing.Color.White;
            this.btnSignUp.HoverState.Parent = this.btnSignUp;
            this.btnSignUp.Location = new System.Drawing.Point(13, 431);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.ShadowDecoration.Parent = this.btnSignUp;
            this.btnSignUp.Size = new System.Drawing.Size(366, 45);
            this.btnSignUp.TabIndex = 13;
            this.btnSignUp.Text = "Sign Up";
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // btnBackToLogin
            // 
            this.btnBackToLogin.Animated = true;
            this.btnBackToLogin.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnBackToLogin.BorderRadius = 5;
            this.btnBackToLogin.CheckedState.Parent = this.btnBackToLogin;
            this.btnBackToLogin.CustomImages.Parent = this.btnBackToLogin;
            this.btnBackToLogin.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnBackToLogin.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnBackToLogin.ForeColor = System.Drawing.Color.White;
            this.btnBackToLogin.HoverState.Parent = this.btnBackToLogin;
            this.btnBackToLogin.Location = new System.Drawing.Point(13, 431);
            this.btnBackToLogin.Name = "btnBackToLogin";
            this.btnBackToLogin.ShadowDecoration.Parent = this.btnBackToLogin;
            this.btnBackToLogin.Size = new System.Drawing.Size(366, 45);
            this.btnBackToLogin.TabIndex = 18;
            this.btnBackToLogin.Text = "Back To Login";
            this.btnBackToLogin.Visible = false;
            this.btnBackToLogin.Click += new System.EventHandler(this.btnBackToLogin_Click);
            // 
            // tbEmail
            // 
            this.tbEmail.Animated = true;
            this.tbEmail.BorderColor = System.Drawing.Color.White;
            this.tbEmail.BorderRadius = 4;
            this.tbEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbEmail.DefaultText = "";
            this.tbEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbEmail.DisabledState.Parent = this.tbEmail;
            this.tbEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tbEmail.FillColor = System.Drawing.Color.WhiteSmoke;
            this.tbEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbEmail.FocusedState.Parent = this.tbEmail;
            this.tbEmail.HoverState.BorderColor = System.Drawing.Color.Gray;
            this.tbEmail.HoverState.Parent = this.tbEmail;
            this.tbEmail.Location = new System.Drawing.Point(13, 356);
            this.tbEmail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.PasswordChar = '\0';
            this.tbEmail.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tbEmail.PlaceholderText = "Email";
            this.tbEmail.SelectedText = "";
            this.tbEmail.ShadowDecoration.Parent = this.tbEmail;
            this.tbEmail.Size = new System.Drawing.Size(366, 49);
            this.tbEmail.TabIndex = 11;
            this.tbEmail.Enter += new System.EventHandler(this.HideError);
            this.tbEmail.Leave += new System.EventHandler(this.IsFieldsStillEmpty);
            // 
            // tbPhone
            // 
            this.tbPhone.Animated = true;
            this.tbPhone.BorderColor = System.Drawing.Color.White;
            this.tbPhone.BorderRadius = 4;
            this.tbPhone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbPhone.DefaultText = "";
            this.tbPhone.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbPhone.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbPhone.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbPhone.DisabledState.Parent = this.tbPhone;
            this.tbPhone.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tbPhone.FillColor = System.Drawing.Color.WhiteSmoke;
            this.tbPhone.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbPhone.FocusedState.Parent = this.tbPhone;
            this.tbPhone.HoverState.BorderColor = System.Drawing.Color.Gray;
            this.tbPhone.HoverState.Parent = this.tbPhone;
            this.tbPhone.Location = new System.Drawing.Point(13, 299);
            this.tbPhone.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.PasswordChar = '\0';
            this.tbPhone.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tbPhone.PlaceholderText = "Phone";
            this.tbPhone.SelectedText = "";
            this.tbPhone.ShadowDecoration.Parent = this.tbPhone;
            this.tbPhone.Size = new System.Drawing.Size(366, 49);
            this.tbPhone.TabIndex = 10;
            this.tbPhone.Enter += new System.EventHandler(this.HideError);
            this.tbPhone.Leave += new System.EventHandler(this.IsFieldsStillEmpty);
            // 
            // tbPassword
            // 
            this.tbPassword.Animated = true;
            this.tbPassword.BorderColor = System.Drawing.Color.White;
            this.tbPassword.BorderRadius = 4;
            this.tbPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbPassword.DefaultText = "";
            this.tbPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbPassword.DisabledState.Parent = this.tbPassword;
            this.tbPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tbPassword.FillColor = System.Drawing.Color.WhiteSmoke;
            this.tbPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbPassword.FocusedState.Parent = this.tbPassword;
            this.tbPassword.HoverState.BorderColor = System.Drawing.Color.Gray;
            this.tbPassword.HoverState.Parent = this.tbPassword;
            this.tbPassword.Location = new System.Drawing.Point(13, 242);
            this.tbPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '\0';
            this.tbPassword.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tbPassword.PlaceholderText = "Password";
            this.tbPassword.SelectedText = "";
            this.tbPassword.ShadowDecoration.Parent = this.tbPassword;
            this.tbPassword.Size = new System.Drawing.Size(366, 49);
            this.tbPassword.TabIndex = 9;
            this.tbPassword.Enter += new System.EventHandler(this.HideError);
            this.tbPassword.Leave += new System.EventHandler(this.IsFieldsStillEmpty);
            // 
            // tbUserName
            // 
            this.tbUserName.Animated = true;
            this.tbUserName.BorderColor = System.Drawing.Color.White;
            this.tbUserName.BorderRadius = 4;
            this.tbUserName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbUserName.DefaultText = "";
            this.tbUserName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbUserName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbUserName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbUserName.DisabledState.Parent = this.tbUserName;
            this.tbUserName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tbUserName.FillColor = System.Drawing.Color.WhiteSmoke;
            this.tbUserName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbUserName.FocusedState.Parent = this.tbUserName;
            this.tbUserName.HoverState.BorderColor = System.Drawing.Color.Gray;
            this.tbUserName.HoverState.Parent = this.tbUserName;
            this.tbUserName.Location = new System.Drawing.Point(13, 184);
            this.tbUserName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.PasswordChar = '\0';
            this.tbUserName.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tbUserName.PlaceholderText = "User Name";
            this.tbUserName.SelectedText = "";
            this.tbUserName.ShadowDecoration.Parent = this.tbUserName;
            this.tbUserName.Size = new System.Drawing.Size(366, 49);
            this.tbUserName.TabIndex = 8;
            this.tbUserName.Enter += new System.EventHandler(this.HideError);
            this.tbUserName.Leave += new System.EventHandler(this.IsFieldsStillEmpty);
            // 
            // tbLastName
            // 
            this.tbLastName.Animated = true;
            this.tbLastName.BorderColor = System.Drawing.Color.White;
            this.tbLastName.BorderRadius = 4;
            this.tbLastName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbLastName.DefaultText = "";
            this.tbLastName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbLastName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbLastName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbLastName.DisabledState.Parent = this.tbLastName;
            this.tbLastName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tbLastName.FillColor = System.Drawing.Color.WhiteSmoke;
            this.tbLastName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbLastName.FocusedState.Parent = this.tbLastName;
            this.tbLastName.HoverState.BorderColor = System.Drawing.Color.Gray;
            this.tbLastName.HoverState.Parent = this.tbLastName;
            this.tbLastName.Location = new System.Drawing.Point(13, 127);
            this.tbLastName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.PasswordChar = '\0';
            this.tbLastName.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tbLastName.PlaceholderText = "Last Name";
            this.tbLastName.SelectedText = "";
            this.tbLastName.ShadowDecoration.Parent = this.tbLastName;
            this.tbLastName.Size = new System.Drawing.Size(366, 49);
            this.tbLastName.TabIndex = 7;
            this.tbLastName.Enter += new System.EventHandler(this.HideError);
            this.tbLastName.Leave += new System.EventHandler(this.IsFieldsStillEmpty);
            // 
            // tbMidName
            // 
            this.tbMidName.Animated = true;
            this.tbMidName.BorderColor = System.Drawing.Color.White;
            this.tbMidName.BorderRadius = 4;
            this.tbMidName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbMidName.DefaultText = "";
            this.tbMidName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbMidName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbMidName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbMidName.DisabledState.Parent = this.tbMidName;
            this.tbMidName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tbMidName.FillColor = System.Drawing.Color.WhiteSmoke;
            this.tbMidName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbMidName.FocusedState.Parent = this.tbMidName;
            this.tbMidName.HoverState.BorderColor = System.Drawing.Color.Gray;
            this.tbMidName.HoverState.Parent = this.tbMidName;
            this.tbMidName.Location = new System.Drawing.Point(13, 70);
            this.tbMidName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbMidName.Name = "tbMidName";
            this.tbMidName.PasswordChar = '\0';
            this.tbMidName.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tbMidName.PlaceholderText = "Mid Name (Optional)";
            this.tbMidName.SelectedText = "";
            this.tbMidName.ShadowDecoration.Parent = this.tbMidName;
            this.tbMidName.Size = new System.Drawing.Size(366, 49);
            this.tbMidName.TabIndex = 6;
            // 
            // tbFirstName
            // 
            this.tbFirstName.Animated = true;
            this.tbFirstName.BorderColor = System.Drawing.Color.White;
            this.tbFirstName.BorderRadius = 4;
            this.tbFirstName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbFirstName.DefaultText = "";
            this.tbFirstName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbFirstName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbFirstName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbFirstName.DisabledState.Parent = this.tbFirstName;
            this.tbFirstName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tbFirstName.FillColor = System.Drawing.Color.WhiteSmoke;
            this.tbFirstName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbFirstName.FocusedState.Parent = this.tbFirstName;
            this.tbFirstName.HoverState.BorderColor = System.Drawing.Color.Gray;
            this.tbFirstName.HoverState.Parent = this.tbFirstName;
            this.tbFirstName.Location = new System.Drawing.Point(13, 13);
            this.tbFirstName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.PasswordChar = '\0';
            this.tbFirstName.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tbFirstName.PlaceholderText = "First Name";
            this.tbFirstName.SelectedText = "";
            this.tbFirstName.ShadowDecoration.Parent = this.tbFirstName;
            this.tbFirstName.Size = new System.Drawing.Size(366, 49);
            this.tbFirstName.TabIndex = 5;
            this.tbFirstName.Enter += new System.EventHandler(this.HideError);
            this.tbFirstName.Leave += new System.EventHandler(this.IsFieldsStillEmpty);
            // 
            // UploadImage
            // 
            this.UploadImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UploadImage.Image = global::QuizzApp.Properties.Resources.down_arrow;
            this.UploadImage.Location = new System.Drawing.Point(165, 21);
            this.UploadImage.Name = "UploadImage";
            this.UploadImage.ShadowDecoration.Parent = this.UploadImage;
            this.UploadImage.Size = new System.Drawing.Size(50, 51);
            this.UploadImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.UploadImage.TabIndex = 15;
            this.UploadImage.TabStop = false;
            this.UploadImage.Click += new System.EventHandler(this.UploadProfileImg);
            // 
            // ImageContainer
            // 
            this.ImageContainer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ImageContainer.BackColor = System.Drawing.Color.White;
            this.ImageContainer.Controls.Add(this.txtMiniUploadText);
            this.ImageContainer.Controls.Add(this.UploadImage);
            this.ImageContainer.Controls.Add(this.txtMainUploadText);
            this.ImageContainer.Location = new System.Drawing.Point(304, 12);
            this.ImageContainer.Name = "ImageContainer";
            this.ImageContainer.Size = new System.Drawing.Size(392, 138);
            this.ImageContainer.TabIndex = 16;
            // 
            // txtMiniUploadText
            // 
            this.txtMiniUploadText.AutoSize = true;
            this.txtMiniUploadText.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.txtMiniUploadText.ForeColor = System.Drawing.Color.Gray;
            this.txtMiniUploadText.Location = new System.Drawing.Point(93, 110);
            this.txtMiniUploadText.Name = "txtMiniUploadText";
            this.txtMiniUploadText.Size = new System.Drawing.Size(206, 19);
            this.txtMiniUploadText.TabIndex = 4;
            this.txtMiniUploadText.Text = "To upload your profile image";
            // 
            // txtMainUploadText
            // 
            this.txtMainUploadText.AutoSize = true;
            this.txtMainUploadText.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.txtMainUploadText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtMainUploadText.Location = new System.Drawing.Point(130, 75);
            this.txtMainUploadText.Name = "txtMainUploadText";
            this.txtMainUploadText.Size = new System.Drawing.Size(131, 35);
            this.txtMainUploadText.TabIndex = 3;
            this.txtMainUploadText.Text = "Click here";
            // 
            // ProfileImage
            // 
            this.ProfileImage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ProfileImage.Location = new System.Drawing.Point(12, 12);
            this.ProfileImage.Name = "ProfileImage";
            this.ProfileImage.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.ProfileImage.ShadowDecoration.Parent = this.ProfileImage;
            this.ProfileImage.Size = new System.Drawing.Size(68, 66);
            this.ProfileImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.ProfileImage.TabIndex = 17;
            this.ProfileImage.TabStop = false;
            this.ProfileImage.Visible = false;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 10;
            this.guna2Elipse1.TargetControl = this.DataContainer;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 10;
            this.guna2Elipse2.TargetControl = this.ImageContainer;
            // 
            // ProfileImageExplorer
            // 
            this.ProfileImageExplorer.FileName = "Img";
            this.ProfileImageExplorer.Filter = "JPG |*.jpg|PNG |*.png";
            this.ProfileImageExplorer.InitialDirectory = "D:\\QuizApp\\QuizApp\\Images\\Profile Images";
            this.ProfileImageExplorer.Title = "Upload Profile Image";
            // 
            // Signup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 657);
            this.Controls.Add(this.ProfileImage);
            this.Controls.Add(this.ImageContainer);
            this.Controls.Add(this.DataContainer);
            this.Name = "Signup";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.DataContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.UploadImage)).EndInit();
            this.ImageContainer.ResumeLayout(false);
            this.ImageContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProfileImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel DataContainer;
        private Guna.UI2.WinForms.Guna2TextBox tbFirstName;
        private Guna.UI2.WinForms.Guna2TextBox tbEmail;
        private Guna.UI2.WinForms.Guna2TextBox tbPhone;
        private Guna.UI2.WinForms.Guna2TextBox tbPassword;
        private Guna.UI2.WinForms.Guna2TextBox tbUserName;
        private Guna.UI2.WinForms.Guna2TextBox tbLastName;
        private Guna.UI2.WinForms.Guna2TextBox tbMidName;
        private Guna.UI2.WinForms.Guna2Button btnSignUp;
        private Guna.UI2.WinForms.Guna2PictureBox UploadImage;
        private System.Windows.Forms.Panel ImageContainer;
        private System.Windows.Forms.Label txtMainUploadText;
        private System.Windows.Forms.Label txtMiniUploadText;
        private Guna.UI2.WinForms.Guna2CirclePictureBox ProfileImage;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Guna.UI2.WinForms.Guna2Button btnBackToLogin;
        private System.Windows.Forms.OpenFileDialog ProfileImageExplorer;
    }
}