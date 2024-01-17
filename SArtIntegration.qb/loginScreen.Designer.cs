namespace SArtIntegration.qb
{
    partial class loginScreen
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            MaterialSkin.Controls.MaterialTextBox2 txtBoxUserName;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loginScreen));
            MenuCard = new MaterialSkin.Controls.MaterialCard();
            lblUserPassword = new Label();
            lblUserName = new Label();
            txtBoxUserPassword = new MaterialSkin.Controls.MaterialTextBox2();
            lblLoginPage = new Label();
            bttnLogin = new MaterialSkin.Controls.MaterialButton();
            txtBoxUserName = new MaterialSkin.Controls.MaterialTextBox2();
            MenuCard.SuspendLayout();
            SuspendLayout();
            // 
            // txtBoxUserName
            // 
            txtBoxUserName.AnimateReadOnly = false;
            txtBoxUserName.AutoCompleteMode = AutoCompleteMode.None;
            txtBoxUserName.AutoCompleteSource = AutoCompleteSource.None;
            txtBoxUserName.BackgroundImageLayout = ImageLayout.None;
            txtBoxUserName.CharacterCasing = CharacterCasing.Normal;
            txtBoxUserName.Depth = 0;
            txtBoxUserName.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxUserName.HideSelection = false;
            txtBoxUserName.ImeMode = ImeMode.NoControl;
            txtBoxUserName.LeadingIcon = null;
            txtBoxUserName.Location = new Point(204, 82);
            txtBoxUserName.MaxLength = 32767;
            txtBoxUserName.MouseState = MaterialSkin.MouseState.OUT;
            txtBoxUserName.Name = "txtBoxUserName";
            txtBoxUserName.PasswordChar = '\0';
            txtBoxUserName.PrefixSuffixText = null;
            txtBoxUserName.ReadOnly = false;
            txtBoxUserName.RightToLeft = RightToLeft.No;
            txtBoxUserName.SelectedText = "";
            txtBoxUserName.SelectionLength = 0;
            txtBoxUserName.SelectionStart = 0;
            txtBoxUserName.ShortcutsEnabled = true;
            txtBoxUserName.Size = new Size(226, 48);
            txtBoxUserName.TabIndex = 2;
            txtBoxUserName.TabStop = false;
            txtBoxUserName.TextAlign = HorizontalAlignment.Left;
            txtBoxUserName.TrailingIcon = null;
            txtBoxUserName.UseSystemPasswordChar = false;
            // 
            // MenuCard
            // 
            MenuCard.BackColor = Color.FromArgb(255, 255, 255);
            MenuCard.BorderStyle = BorderStyle.FixedSingle;
            MenuCard.Controls.Add(lblUserPassword);
            MenuCard.Controls.Add(lblUserName);
            MenuCard.Controls.Add(txtBoxUserPassword);
            MenuCard.Controls.Add(txtBoxUserName);
            MenuCard.Controls.Add(lblLoginPage);
            MenuCard.Controls.Add(bttnLogin);
            MenuCard.Depth = 0;
            MenuCard.ForeColor = Color.FromArgb(222, 0, 0, 0);
            MenuCard.Location = new Point(23, 40);
            MenuCard.Margin = new Padding(14);
            MenuCard.MouseState = MaterialSkin.MouseState.HOVER;
            MenuCard.Name = "MenuCard";
            MenuCard.Padding = new Padding(14);
            MenuCard.Size = new Size(559, 344);
            MenuCard.TabIndex = 0;
            // 
            // lblUserPassword
            // 
            lblUserPassword.AutoSize = true;
            lblUserPassword.Font = new Font("Segoe UI Semibold", 10.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblUserPassword.Location = new Point(93, 161);
            lblUserPassword.Name = "lblUserPassword";
            lblUserPassword.Size = new Size(107, 19);
            lblUserPassword.TabIndex = 5;
            lblUserPassword.Text = "User Password :";
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Font = new Font("Segoe UI Semibold", 10.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblUserName.Location = new Point(119, 92);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(81, 19);
            lblUserName.TabIndex = 4;
            lblUserName.Text = "UserName :";
            // 
            // txtBoxUserPassword
            // 
            txtBoxUserPassword.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtBoxUserPassword.AnimateReadOnly = false;
            txtBoxUserPassword.AutoCompleteMode = AutoCompleteMode.None;
            txtBoxUserPassword.AutoCompleteSource = AutoCompleteSource.None;
            txtBoxUserPassword.BackgroundImageLayout = ImageLayout.None;
            txtBoxUserPassword.CharacterCasing = CharacterCasing.Normal;
            txtBoxUserPassword.Depth = 0;
            txtBoxUserPassword.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxUserPassword.HideSelection = false;
            txtBoxUserPassword.ImeMode = ImeMode.NoControl;
            txtBoxUserPassword.LeadingIcon = null;
            txtBoxUserPassword.Location = new Point(204, 151);
            txtBoxUserPassword.MaxLength = 32767;
            txtBoxUserPassword.MouseState = MaterialSkin.MouseState.OUT;
            txtBoxUserPassword.Name = "txtBoxUserPassword";
            txtBoxUserPassword.PasswordChar = '*';
            txtBoxUserPassword.PrefixSuffixText = null;
            txtBoxUserPassword.ReadOnly = false;
            txtBoxUserPassword.RightToLeft = RightToLeft.No;
            txtBoxUserPassword.SelectedText = "";
            txtBoxUserPassword.SelectionLength = 0;
            txtBoxUserPassword.SelectionStart = 0;
            txtBoxUserPassword.ShortcutsEnabled = true;
            txtBoxUserPassword.Size = new Size(226, 48);
            txtBoxUserPassword.TabIndex = 3;
            txtBoxUserPassword.TabStop = false;
            txtBoxUserPassword.TextAlign = HorizontalAlignment.Left;
            txtBoxUserPassword.TrailingIcon = null;
            txtBoxUserPassword.UseSystemPasswordChar = false;
            // 
            // lblLoginPage
            // 
            lblLoginPage.AutoSize = true;
            lblLoginPage.Font = new Font("Segoe UI Semibold", 10.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblLoginPage.Location = new Point(-1, 2);
            lblLoginPage.Name = "lblLoginPage";
            lblLoginPage.Size = new Size(78, 19);
            lblLoginPage.TabIndex = 1;
            lblLoginPage.Text = "Login Page";
            lblLoginPage.Click += lblLoginPage_Click;
            // 
            // bttnLogin
            // 
            bttnLogin.AutoSize = false;
            bttnLogin.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            bttnLogin.Depth = 0;
            bttnLogin.HighEmphasis = true;
            bttnLogin.Icon = null;
            bttnLogin.Location = new Point(204, 208);
            bttnLogin.Margin = new Padding(4, 6, 4, 6);
            bttnLogin.MouseState = MaterialSkin.MouseState.HOVER;
            bttnLogin.Name = "bttnLogin";
            bttnLogin.NoAccentTextColor = Color.Empty;
            bttnLogin.Size = new Size(226, 49);
            bttnLogin.TabIndex = 0;
            bttnLogin.Text = "LOGIN";
            bttnLogin.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            bttnLogin.UseAccentColor = false;
            bttnLogin.UseVisualStyleBackColor = true;
            bttnLogin.Click += bttnLogin_Click;
            // 
            // loginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(605, 407);
            Controls.Add(MenuCard);
            Icon = (Icon)resources.GetObject("$this.Icon");
            ImeMode = ImeMode.On;
            Name = "loginForm";
            Text = "SArtIntegration.qb";
            MenuCard.ResumeLayout(false);
            MenuCard.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private MaterialSkin.Controls.MaterialCard MenuCard;
        private MaterialSkin.Controls.MaterialLabel lblLoginTXT;
        private MaterialSkin.Controls.MaterialButton bttnLogin;
        private MaterialSkin.Controls.MaterialLabel lblPassword;
        private MaterialSkin.Controls.MaterialTextBox2 txtBoxPassword;
        private MaterialSkin.Controls.MaterialTextBox2 txtBoxUserName;
        private Label lblLoginPage;
        private Label lblUserPassword;
        private MaterialSkin.Controls.MaterialTextBox2 txtBoxUserPassword;
        private Label lblUserName;
    }
}
