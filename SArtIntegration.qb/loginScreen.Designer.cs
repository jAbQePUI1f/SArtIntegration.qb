namespace SArtIntegration.qb
{
    partial class loginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loginForm));
            MenuCard = new MaterialSkin.Controls.MaterialCard();
            lblPassword = new MaterialSkin.Controls.MaterialLabel();
            lblUserName = new MaterialSkin.Controls.MaterialLabel();
            txtBoxPassword = new MaterialSkin.Controls.MaterialTextBox2();
            txtBoxUserName = new MaterialSkin.Controls.MaterialTextBox2();
            bttnLogin = new MaterialSkin.Controls.MaterialButton();
            lblLoginTXT = new MaterialSkin.Controls.MaterialLabel();
            MenuCard.SuspendLayout();
            SuspendLayout();
            // 
            // MenuCard
            // 
            MenuCard.BackColor = Color.FromArgb(255, 255, 255);
            MenuCard.BorderStyle = BorderStyle.FixedSingle;
            MenuCard.Controls.Add(lblPassword);
            MenuCard.Controls.Add(lblUserName);
            MenuCard.Controls.Add(txtBoxPassword);
            MenuCard.Controls.Add(txtBoxUserName);
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
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Depth = 0;
            lblPassword.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblPassword.Location = new Point(131, 209);
            lblPassword.MouseState = MaterialSkin.MouseState.HOVER;
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(83, 19);
            lblPassword.TabIndex = 3;
            lblPassword.Text = "Password  :";
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Depth = 0;
            lblUserName.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblUserName.Location = new Point(131, 139);
            lblUserName.MouseState = MaterialSkin.MouseState.HOVER;
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(84, 19);
            lblUserName.TabIndex = 2;
            lblUserName.Text = "Username  :";
            // 
            // txtBoxPassword
            // 
            txtBoxPassword.AnimateReadOnly = false;
            txtBoxPassword.AutoCompleteMode = AutoCompleteMode.None;
            txtBoxPassword.AutoCompleteSource = AutoCompleteSource.None;
            txtBoxPassword.BackgroundImageLayout = ImageLayout.None;
            txtBoxPassword.CharacterCasing = CharacterCasing.Normal;
            txtBoxPassword.Depth = 0;
            txtBoxPassword.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtBoxPassword.HideSelection = true;
            txtBoxPassword.LeadingIcon = null;
            txtBoxPassword.Location = new Point(237, 197);
            txtBoxPassword.Margin = new Padding(3, 4, 3, 4);
            txtBoxPassword.MaxLength = 32767;
            txtBoxPassword.MouseState = MaterialSkin.MouseState.OUT;
            txtBoxPassword.Name = "txtBoxPassword";
            txtBoxPassword.PasswordChar = '*';
            txtBoxPassword.PrefixSuffixText = null;
            txtBoxPassword.ReadOnly = false;
            txtBoxPassword.RightToLeft = RightToLeft.No;
            txtBoxPassword.SelectedText = "";
            txtBoxPassword.SelectionLength = 0;
            txtBoxPassword.SelectionStart = 0;
            txtBoxPassword.ShortcutsEnabled = true;
            txtBoxPassword.Size = new Size(286, 36);
            txtBoxPassword.TabIndex = 2;
            txtBoxPassword.TabStop = false;
            txtBoxPassword.TextAlign = HorizontalAlignment.Left;
            txtBoxPassword.TrailingIcon = null;
            txtBoxPassword.UseAccent = false;
            txtBoxPassword.UseSystemPasswordChar = false;
            txtBoxPassword.UseTallSize = false;
            // 
            // txtBoxUserName
            // 
            txtBoxUserName.AnimateReadOnly = false;
            txtBoxUserName.AutoCompleteMode = AutoCompleteMode.None;
            txtBoxUserName.AutoCompleteSource = AutoCompleteSource.None;
            txtBoxUserName.BackgroundImageLayout = ImageLayout.None;
            txtBoxUserName.CharacterCasing = CharacterCasing.Normal;
            txtBoxUserName.Depth = 0;
            txtBoxUserName.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtBoxUserName.HideSelection = true;
            txtBoxUserName.LeadingIcon = null;
            txtBoxUserName.Location = new Point(237, 129);
            txtBoxUserName.Margin = new Padding(3, 4, 3, 4);
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
            txtBoxUserName.Size = new Size(286, 36);
            txtBoxUserName.TabIndex = 1;
            txtBoxUserName.TabStop = false;
            txtBoxUserName.TextAlign = HorizontalAlignment.Left;
            txtBoxUserName.TrailingIcon = null;
            txtBoxUserName.UseAccent = false;
            txtBoxUserName.UseSystemPasswordChar = false;
            txtBoxUserName.UseTallSize = false;
            // 
            // bttnLogin
            // 
            bttnLogin.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            bttnLogin.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            bttnLogin.Depth = 0;
            bttnLogin.HighEmphasis = true;
            bttnLogin.Icon = null;
            bttnLogin.Location = new Point(442, 277);
            bttnLogin.Margin = new Padding(5, 8, 5, 8);
            bttnLogin.MouseState = MaterialSkin.MouseState.HOVER;
            bttnLogin.Name = "bttnLogin";
            bttnLogin.NoAccentTextColor = Color.Empty;
            bttnLogin.Size = new Size(70, 36);
            bttnLogin.TabIndex = 0;
            bttnLogin.Text = "Logon";
            bttnLogin.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            bttnLogin.UseAccentColor = false;
            bttnLogin.UseVisualStyleBackColor = true;
            bttnLogin.Click += bttnLogin_Click;
            // 
            // lblLoginTXT
            // 
            lblLoginTXT.AutoSize = true;
            lblLoginTXT.Depth = 0;
            lblLoginTXT.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblLoginTXT.Location = new Point(32, 41);
            lblLoginTXT.MouseState = MaterialSkin.MouseState.HOVER;
            lblLoginTXT.Name = "lblLoginTXT";
            lblLoginTXT.Size = new Size(81, 19);
            lblLoginTXT.TabIndex = 1;
            lblLoginTXT.Text = "Login Page";
            // 
            // loginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(691, 543);
            Controls.Add(lblLoginTXT);
            Controls.Add(MenuCard);
            Icon = (Icon)resources.GetObject("$this.Icon");
            ImeMode = ImeMode.On;
            Margin = new Padding(3, 4, 3, 4);
            Name = "loginForm";
            Text = "SArtIntegration.qb";
            MenuCard.ResumeLayout(false);
            MenuCard.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialCard MenuCard;
        private MaterialSkin.Controls.MaterialLabel lblLoginTXT;
        private MaterialSkin.Controls.MaterialButton bttnLogin;
        private MaterialSkin.Controls.MaterialLabel lblPassword;
        private MaterialSkin.Controls.MaterialLabel lblUserName;
        private MaterialSkin.Controls.MaterialTextBox2 txtBoxPassword;
        private MaterialSkin.Controls.MaterialTextBox2 txtBoxUserName;
    }
}
