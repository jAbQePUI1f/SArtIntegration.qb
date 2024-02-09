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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loginScreen));
            MenuCard = new MaterialSkin.Controls.MaterialCard();
            txtUserName = new MaterialSkin.Controls.MaterialMaskedTextBox();
            lblUserPassword = new Label();
            lblUserName = new Label();
            lblLoginPage = new Label();
            bttnLogin = new MaterialSkin.Controls.MaterialButton();
            txtPassword = new MaterialSkin.Controls.MaterialMaskedTextBox();
            MenuCard.SuspendLayout();
            SuspendLayout();
            // 
            // MenuCard
            // 
            MenuCard.BackColor = Color.FromArgb(255, 255, 255);
            MenuCard.BorderStyle = BorderStyle.FixedSingle;
            MenuCard.Controls.Add(txtPassword);
            MenuCard.Controls.Add(txtUserName);
            MenuCard.Controls.Add(lblUserPassword);
            MenuCard.Controls.Add(lblUserName);
            MenuCard.Controls.Add(lblLoginPage);
            MenuCard.Controls.Add(bttnLogin);
            MenuCard.Depth = 0;
            MenuCard.ForeColor = Color.FromArgb(222, 0, 0, 0);
            MenuCard.Location = new Point(26, 53);
            MenuCard.Margin = new Padding(16, 19, 16, 19);
            MenuCard.MouseState = MaterialSkin.MouseState.HOVER;
            MenuCard.Name = "MenuCard";
            MenuCard.Padding = new Padding(16, 19, 16, 19);
            MenuCard.Size = new Size(639, 458);
            MenuCard.TabIndex = 0;
            // 
            // txtUserName
            // 
            txtUserName.AllowPromptAsInput = true;
            txtUserName.AnimateReadOnly = false;
            txtUserName.AsciiOnly = false;
            txtUserName.BackgroundImageLayout = ImageLayout.None;
            txtUserName.BeepOnError = false;
            txtUserName.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            txtUserName.Depth = 0;
            txtUserName.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtUserName.HidePromptOnLeave = false;
            txtUserName.HideSelection = true;
            txtUserName.InsertKeyMode = InsertKeyMode.Default;
            txtUserName.LeadingIcon = null;
            txtUserName.Location = new Point(233, 114);
            txtUserName.Mask = "";
            txtUserName.MaxLength = 32767;
            txtUserName.MouseState = MaterialSkin.MouseState.OUT;
            txtUserName.Name = "txtUserName";
            txtUserName.PasswordChar = '\0';
            txtUserName.PrefixSuffixText = null;
            txtUserName.PromptChar = '_';
            txtUserName.ReadOnly = false;
            txtUserName.RejectInputOnFirstFailure = false;
            txtUserName.ResetOnPrompt = true;
            txtUserName.ResetOnSpace = true;
            txtUserName.RightToLeft = RightToLeft.No;
            txtUserName.SelectedText = "";
            txtUserName.SelectionLength = 0;
            txtUserName.SelectionStart = 0;
            txtUserName.ShortcutsEnabled = true;
            txtUserName.Size = new Size(312, 48);
            txtUserName.SkipLiterals = true;
            txtUserName.TabIndex = 6;
            txtUserName.TabStop = false;
            txtUserName.TextAlign = HorizontalAlignment.Left;
            txtUserName.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtUserName.TrailingIcon = null;
            txtUserName.UseSystemPasswordChar = false;
            txtUserName.ValidatingType = null;
            // 
            // lblUserPassword
            // 
            lblUserPassword.AutoSize = true;
            lblUserPassword.Font = new Font("Segoe UI Semibold", 10.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblUserPassword.Location = new Point(106, 215);
            lblUserPassword.Name = "lblUserPassword";
            lblUserPassword.Size = new Size(142, 25);
            lblUserPassword.TabIndex = 5;
            lblUserPassword.Text = "User Password :";
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Font = new Font("Segoe UI Semibold", 10.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblUserName.Location = new Point(136, 123);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(108, 25);
            lblUserName.TabIndex = 4;
            lblUserName.Text = "UserName :";
            // 
            // lblLoginPage
            // 
            lblLoginPage.AutoSize = true;
            lblLoginPage.Font = new Font("Segoe UI Semibold", 10.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblLoginPage.Location = new Point(-1, 3);
            lblLoginPage.Name = "lblLoginPage";
            lblLoginPage.Size = new Size(104, 25);
            lblLoginPage.TabIndex = 1;
            lblLoginPage.Text = "Login Page";
            lblLoginPage.Click += lblLoginPage_Click;
            // 
            // bttnLogin
            // 
            bttnLogin.AutoSize = false;
            bttnLogin.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            bttnLogin.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            bttnLogin.Depth = 0;
            bttnLogin.HighEmphasis = true;
            bttnLogin.Icon = null;
            bttnLogin.Location = new Point(233, 277);
            bttnLogin.Margin = new Padding(5, 8, 5, 8);
            bttnLogin.MouseState = MaterialSkin.MouseState.HOVER;
            bttnLogin.Name = "bttnLogin";
            bttnLogin.NoAccentTextColor = Color.Empty;
            bttnLogin.Size = new Size(258, 65);
            bttnLogin.TabIndex = 0;
            bttnLogin.Text = "LOGIN";
            bttnLogin.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            bttnLogin.UseAccentColor = false;
            bttnLogin.UseVisualStyleBackColor = true;
            bttnLogin.Click += bttnLogin_Click;
            // 
            // txtPassword
            // 
            txtPassword.AllowPromptAsInput = true;
            txtPassword.AnimateReadOnly = false;
            txtPassword.AsciiOnly = false;
            txtPassword.BackgroundImageLayout = ImageLayout.None;
            txtPassword.BeepOnError = false;
            txtPassword.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            txtPassword.Depth = 0;
            txtPassword.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtPassword.HidePromptOnLeave = false;
            txtPassword.HideSelection = true;
            txtPassword.InsertKeyMode = InsertKeyMode.Default;
            txtPassword.LeadingIcon = null;
            txtPassword.Location = new Point(242, 206);
            txtPassword.Mask = "";
            txtPassword.MaxLength = 32767;
            txtPassword.MouseState = MaterialSkin.MouseState.OUT;
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.PrefixSuffixText = null;
            txtPassword.PromptChar = '_';
            txtPassword.ReadOnly = false;
            txtPassword.RejectInputOnFirstFailure = false;
            txtPassword.ResetOnPrompt = true;
            txtPassword.ResetOnSpace = true;
            txtPassword.RightToLeft = RightToLeft.No;
            txtPassword.SelectedText = "";
            txtPassword.SelectionLength = 0;
            txtPassword.SelectionStart = 0;
            txtPassword.ShortcutsEnabled = true;
            txtPassword.Size = new Size(303, 48);
            txtPassword.SkipLiterals = true;
            txtPassword.TabIndex = 7;
            txtPassword.TabStop = false;
            txtPassword.TextAlign = HorizontalAlignment.Left;
            txtPassword.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtPassword.TrailingIcon = null;
            txtPassword.UseSystemPasswordChar = false;
            txtPassword.ValidatingType = null;
            // 
            // loginScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(691, 543);
            Controls.Add(MenuCard);
            Icon = (Icon)resources.GetObject("$this.Icon");
            ImeMode = ImeMode.On;
            Margin = new Padding(3, 4, 3, 4);
            Name = "loginScreen";
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
        private Label lblLoginPage;
        private Label lblUserPassword;
        private Label lblUserName;
        private MaterialSkin.Controls.MaterialMaskedTextBox txtUserName;
        private MaterialSkin.Controls.MaterialMaskedTextBox txtPassword;
    }
}
