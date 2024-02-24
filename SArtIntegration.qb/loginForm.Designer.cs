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
            lblLoginPage = new Label();
            txtPassword = new MaterialSkin.Controls.MaterialMaskedTextBox();
            txtUserName = new MaterialSkin.Controls.MaterialMaskedTextBox();
            lblUserPassword = new Label();
            lblUserName = new Label();
            bttnLogin = new MaterialSkin.Controls.MaterialButton();
            pictureBox1 = new PictureBox();
            MenuCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // MenuCard
            // 
            MenuCard.BackColor = Color.FromArgb(255, 255, 255);
            MenuCard.BorderStyle = BorderStyle.FixedSingle;
            MenuCard.Controls.Add(lblLoginPage);
            MenuCard.Controls.Add(txtPassword);
            MenuCard.Controls.Add(txtUserName);
            MenuCard.Controls.Add(lblUserPassword);
            MenuCard.Controls.Add(lblUserName);
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
            // lblLoginPage
            // 
            lblLoginPage.AutoSize = true;
            lblLoginPage.Font = new Font("Segoe UI Semibold", 10.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblLoginPage.Location = new Point(-1, -1);
            lblLoginPage.Name = "lblLoginPage";
            lblLoginPage.Size = new Size(78, 19);
            lblLoginPage.TabIndex = 1;
            lblLoginPage.Text = "Login Page";
            lblLoginPage.Click += lblLoginPage_Click;
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
            txtPassword.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtPassword.HidePromptOnLeave = false;
            txtPassword.HideSelection = true;
            txtPassword.InsertKeyMode = InsertKeyMode.Default;
            txtPassword.LeadingIcon = null;
            txtPassword.Location = new Point(204, 155);
            txtPassword.Margin = new Padding(3, 2, 3, 2);
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
            txtPassword.Size = new Size(273, 36);
            txtPassword.SkipLiterals = true;
            txtPassword.TabIndex = 7;
            txtPassword.TabStop = false;
            txtPassword.TextAlign = HorizontalAlignment.Left;
            txtPassword.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtPassword.TrailingIcon = null;
            txtPassword.UseSystemPasswordChar = false;
            txtPassword.UseTallSize = false;
            txtPassword.ValidatingType = null;
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
            txtUserName.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtUserName.HidePromptOnLeave = false;
            txtUserName.HideSelection = true;
            txtUserName.InsertKeyMode = InsertKeyMode.Default;
            txtUserName.LeadingIcon = null;
            txtUserName.Location = new Point(204, 100);
            txtUserName.Margin = new Padding(3, 2, 3, 2);
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
            txtUserName.Size = new Size(273, 36);
            txtUserName.SkipLiterals = true;
            txtUserName.TabIndex = 6;
            txtUserName.TabStop = false;
            txtUserName.TextAlign = HorizontalAlignment.Left;
            txtUserName.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtUserName.TrailingIcon = null;
            txtUserName.UseSystemPasswordChar = false;
            txtUserName.UseTallSize = false;
            txtUserName.ValidatingType = null;
            // 
            // lblUserPassword
            // 
            lblUserPassword.AutoSize = true;
            lblUserPassword.Font = new Font("Segoe UI Semibold", 10.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblUserPassword.Location = new Point(71, 155);
            lblUserPassword.Name = "lblUserPassword";
            lblUserPassword.Size = new Size(107, 19);
            lblUserPassword.TabIndex = 5;
            lblUserPassword.Text = "User password :";
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Font = new Font("Segoe UI Semibold", 10.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblUserName.Location = new Point(100, 100);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(78, 19);
            lblUserName.TabIndex = 4;
            lblUserName.Text = "Username :";
            // 
            // bttnLogin
            // 
            bttnLogin.AutoSize = false;
            bttnLogin.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            bttnLogin.BackColor = Color.FromArgb(255, 255, 192);
            bttnLogin.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            bttnLogin.Depth = 0;
            bttnLogin.DrawShadows = false;
            bttnLogin.HighEmphasis = true;
            bttnLogin.Icon = Properties.Resources.fp;
            bttnLogin.Location = new Point(204, 208);
            bttnLogin.Margin = new Padding(4, 6, 4, 6);
            bttnLogin.MouseState = MaterialSkin.MouseState.HOVER;
            bttnLogin.Name = "bttnLogin";
            bttnLogin.NoAccentTextColor = Color.Empty;
            bttnLogin.Size = new Size(273, 55);
            bttnLogin.TabIndex = 0;
            bttnLogin.Text = "Login UP";
            bttnLogin.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            bttnLogin.UseAccentColor = false;
            bttnLogin.UseVisualStyleBackColor = false;
            bttnLogin.Click += bttnLogin_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo_1920;
            pictureBox1.Location = new Point(23, 401);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(559, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // loginScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(605, 475);
            Controls.Add(pictureBox1);
            Controls.Add(MenuCard);
            Icon = (Icon)resources.GetObject("$this.Icon");
            ImeMode = ImeMode.On;
            MaximizeBox = false;
            Name = "loginScreen";
            Text = "SArtIntegration.qb";
            MenuCard.ResumeLayout(false);
            MenuCard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private PictureBox pictureBox1;
    }
}
