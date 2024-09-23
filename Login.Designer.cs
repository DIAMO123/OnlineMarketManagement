namespace OnlineMarketManagmnetSystem
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            pictureBox2 = new PictureBox();
            guna2CircleButton1 = new Guna.UI2.WinForms.Guna2CircleButton();
            label1 = new Label();
            comboboxLogin = new ComboBox();
            pictureBox1 = new PictureBox();
            txtUserName = new Guna.UI2.WinForms.Guna2TextBox();
            txtPassword = new Guna.UI2.WinForms.Guna2TextBox();
            buttonLogin = new Guna.UI2.WinForms.Guna2Button();
            buttonReset = new Guna.UI2.WinForms.Guna2Button();
            buttonLinkRegister = new LinkLabel();
            AssignAdmin = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(890, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(44, 34);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // guna2CircleButton1
            // 
            guna2CircleButton1.Animated = true;
            guna2CircleButton1.BorderColor = Color.Transparent;
            guna2CircleButton1.DisabledState.BorderColor = Color.DarkGray;
            guna2CircleButton1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2CircleButton1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2CircleButton1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2CircleButton1.FillColor = Color.Gold;
            guna2CircleButton1.FocusedColor = Color.Blue;
            guna2CircleButton1.Font = new Font("Segoe UI", 9F);
            guna2CircleButton1.ForeColor = Color.White;
            guna2CircleButton1.Location = new Point(-221, 0);
            guna2CircleButton1.Name = "guna2CircleButton1";
            guna2CircleButton1.ShadowDecoration.CustomizableEdges = customizableEdges1;
            guna2CircleButton1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            guna2CircleButton1.Size = new Size(457, 480);
            guna2CircleButton1.TabIndex = 9;
            guna2CircleButton1.Text = "                                                  Online Market";
            guna2CircleButton1.Click += guna2CircleButton1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.AntiqueWhite;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Gold;
            label1.Location = new Point(272, 0);
            label1.Name = "label1";
            label1.Size = new Size(479, 39);
            label1.TabIndex = 10;
            label1.Text = "Online Market Management System";
            // 
            // comboboxLogin
            // 
            comboboxLogin.BackColor = SystemColors.ButtonHighlight;
            comboboxLogin.ForeColor = Color.Blue;
            comboboxLogin.FormattingEnabled = true;
            comboboxLogin.Items.AddRange(new object[] { "Admin", "Customer" });
            comboboxLogin.Location = new Point(449, 191);
            comboboxLogin.Name = "comboboxLogin";
            comboboxLogin.Size = new Size(200, 23);
            comboboxLogin.TabIndex = 12;
            comboboxLogin.Text = "Select Role";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(421, 51);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(262, 118);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // txtUserName
            // 
            txtUserName.CustomizableEdges = customizableEdges2;
            txtUserName.DefaultText = "";
            txtUserName.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtUserName.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtUserName.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtUserName.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtUserName.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtUserName.Font = new Font("Segoe UI", 9F);
            txtUserName.ForeColor = Color.Blue;
            txtUserName.HideSelection = false;
            txtUserName.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtUserName.Location = new Point(449, 237);
            txtUserName.Name = "txtUserName";
            txtUserName.PasswordChar = '\0';
            txtUserName.PlaceholderForeColor = Color.Blue;
            txtUserName.PlaceholderText = "User Name";
            txtUserName.SelectedText = "";
            txtUserName.ShadowDecoration.CustomizableEdges = customizableEdges3;
            txtUserName.Size = new Size(200, 25);
            txtUserName.TabIndex = 14;
            // 
            // txtPassword
            // 
            txtPassword.CustomizableEdges = customizableEdges4;
            txtPassword.DefaultText = "";
            txtPassword.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtPassword.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtPassword.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtPassword.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtPassword.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtPassword.Font = new Font("Segoe UI", 9F);
            txtPassword.ForeColor = Color.Blue;
            txtPassword.HideSelection = false;
            txtPassword.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtPassword.Location = new Point(449, 289);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.PlaceholderForeColor = Color.Blue;
            txtPassword.PlaceholderText = "Password";
            txtPassword.SelectedText = "";
            txtPassword.ShadowDecoration.CustomizableEdges = customizableEdges5;
            txtPassword.Size = new Size(200, 25);
            txtPassword.TabIndex = 15;
            // 
            // buttonLogin
            // 
            buttonLogin.BorderColor = Color.Transparent;
            buttonLogin.CustomizableEdges = customizableEdges6;
            buttonLogin.DisabledState.BorderColor = Color.DarkGray;
            buttonLogin.DisabledState.CustomBorderColor = Color.DarkGray;
            buttonLogin.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            buttonLogin.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            buttonLogin.FillColor = Color.Lime;
            buttonLogin.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonLogin.ForeColor = Color.White;
            buttonLogin.HoverState.ForeColor = Color.FromArgb(0, 192, 0);
            buttonLogin.Location = new Point(449, 342);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.ShadowDecoration.CustomizableEdges = customizableEdges7;
            buttonLogin.Size = new Size(84, 30);
            buttonLogin.TabIndex = 16;
            buttonLogin.Text = "LOGIN";
            buttonLogin.Click += buttonLogin_Click;
            // 
            // buttonReset
            // 
            buttonReset.BorderColor = Color.Transparent;
            buttonReset.CustomizableEdges = customizableEdges8;
            buttonReset.DisabledState.BorderColor = Color.DarkGray;
            buttonReset.DisabledState.CustomBorderColor = Color.DarkGray;
            buttonReset.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            buttonReset.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            buttonReset.FillColor = Color.Turquoise;
            buttonReset.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonReset.ForeColor = Color.White;
            buttonReset.HoverState.ForeColor = Color.FromArgb(0, 192, 0);
            buttonReset.Location = new Point(591, 342);
            buttonReset.Name = "buttonReset";
            buttonReset.ShadowDecoration.CustomizableEdges = customizableEdges9;
            buttonReset.Size = new Size(92, 30);
            buttonReset.TabIndex = 17;
            buttonReset.Text = "RESET";
            buttonReset.Click += buttonReset_Click;
            // 
            // buttonLinkRegister
            // 
            buttonLinkRegister.AutoSize = true;
            buttonLinkRegister.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonLinkRegister.Location = new Point(350, 400);
            buttonLinkRegister.Name = "buttonLinkRegister";
            buttonLinkRegister.Size = new Size(444, 17);
            buttonLinkRegister.TabIndex = 18;
            buttonLinkRegister.TabStop = true;
            buttonLinkRegister.Text = "If you don't have an account as a customer,please click here to registration";
            buttonLinkRegister.LinkClicked += buttonLinkRegister_LinkClicked;
            // 
            // AssignAdmin
            // 
            AssignAdmin.AutoSize = true;
            AssignAdmin.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AssignAdmin.Location = new Point(481, 444);
            AssignAdmin.Name = "AssignAdmin";
            AssignAdmin.Size = new Size(141, 17);
            AssignAdmin.TabIndex = 19;
            AssignAdmin.TabStop = true;
            AssignAdmin.Text = "Reset Admin Password";
            AssignAdmin.LinkClicked += AssignAdmin_LinkClicked;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(934, 481);
            Controls.Add(AssignAdmin);
            Controls.Add(buttonLinkRegister);
            Controls.Add(buttonReset);
            Controls.Add(buttonLogin);
            Controls.Add(txtPassword);
            Controls.Add(txtUserName);
            Controls.Add(pictureBox1);
            Controls.Add(comboboxLogin);
            Controls.Add(label1);
            Controls.Add(guna2CircleButton1);
            Controls.Add(pictureBox2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Login_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox2;
        private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton1;
        private Label label1;
        private ComboBox comboboxLogin;
        private PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2TextBox txtUserName;
        private Guna.UI2.WinForms.Guna2TextBox txtPassword;
        private Guna.UI2.WinForms.Guna2Button buttonLogin;
        private Guna.UI2.WinForms.Guna2Button buttonReset;
        private LinkLabel buttonLinkRegister;
        private LinkLabel AssignAdmin;
    }
}