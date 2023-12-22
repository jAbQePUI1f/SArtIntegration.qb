namespace SArtIntegration.qb
{
    partial class mainScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainScreen));
            materialCard1 = new MaterialSkin.Controls.MaterialCard();
            SArtToQb = new MaterialSkin.Controls.MaterialLabel();
            materialTabSelector2 = new MaterialSkin.Controls.MaterialTabSelector();
            bttnTransferToStocks = new MaterialSkin.Controls.MaterialButton();
            bttnTransferToItems = new MaterialSkin.Controls.MaterialButton();
            bttnTrsansferToCustomer = new MaterialSkin.Controls.MaterialButton();
            qbtoSArt = new MaterialSkin.Controls.MaterialLabel();
            materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            infoConnectQb = new MaterialSkin.Controls.MaterialLabel();
            connectqb = new MaterialSkin.Controls.MaterialSwitch();
            materialCard1.SuspendLayout();
            SuspendLayout();
            // 
            // materialCard1
            // 
            materialCard1.BackColor = Color.FromArgb(255, 255, 255);
            materialCard1.Controls.Add(SArtToQb);
            materialCard1.Controls.Add(materialTabSelector2);
            materialCard1.Controls.Add(bttnTransferToStocks);
            materialCard1.Controls.Add(bttnTransferToItems);
            materialCard1.Controls.Add(bttnTrsansferToCustomer);
            materialCard1.Controls.Add(qbtoSArt);
            materialCard1.Controls.Add(materialTabSelector1);
            materialCard1.Controls.Add(infoConnectQb);
            materialCard1.Controls.Add(connectqb);
            materialCard1.Depth = 0;
            materialCard1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard1.Location = new Point(13, 40);
            materialCard1.Margin = new Padding(14);
            materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard1.Name = "materialCard1";
            materialCard1.Padding = new Padding(14);
            materialCard1.Size = new Size(719, 400);
            materialCard1.TabIndex = 0;
            // 
            // SArtToQb
            // 
            SArtToQb.AutoSize = true;
            SArtToQb.Depth = 0;
            SArtToQb.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            SArtToQb.Location = new Point(253, 218);
            SArtToQb.MouseState = MaterialSkin.MouseState.HOVER;
            SArtToQb.Name = "SArtToQb";
            SArtToQb.Size = new Size(166, 19);
            SArtToQb.TabIndex = 9;
            SArtToQb.Text = "SalesArt to QuickBooks";
            // 
            // materialTabSelector2
            // 
            materialTabSelector2.BackColor = Color.Black;
            materialTabSelector2.BaseTabControl = null;
            materialTabSelector2.CharacterCasing = MaterialSkin.Controls.MaterialTabSelector.CustomCharacterCasing.Normal;
            materialTabSelector2.Depth = 0;
            materialTabSelector2.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialTabSelector2.ForeColor = Color.Black;
            materialTabSelector2.Location = new Point(-1, 219);
            materialTabSelector2.MouseState = MaterialSkin.MouseState.HOVER;
            materialTabSelector2.Name = "materialTabSelector2";
            materialTabSelector2.Size = new Size(720, 18);
            materialTabSelector2.TabIndex = 8;
            materialTabSelector2.Text = "materialTabSelector2";
            // 
            // bttnTransferToStocks
            // 
            bttnTransferToStocks.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            bttnTransferToStocks.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            bttnTransferToStocks.Depth = 0;
            bttnTransferToStocks.HighEmphasis = true;
            bttnTransferToStocks.Icon = null;
            bttnTransferToStocks.Location = new Point(486, 147);
            bttnTransferToStocks.Margin = new Padding(4, 6, 4, 6);
            bttnTransferToStocks.MouseState = MaterialSkin.MouseState.HOVER;
            bttnTransferToStocks.Name = "bttnTransferToStocks";
            bttnTransferToStocks.NoAccentTextColor = Color.Empty;
            bttnTransferToStocks.Size = new Size(154, 36);
            bttnTransferToStocks.TabIndex = 7;
            bttnTransferToStocks.Text = "Transfer Stocks";
            bttnTransferToStocks.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            bttnTransferToStocks.UseAccentColor = false;
            bttnTransferToStocks.UseVisualStyleBackColor = true;
            // 
            // bttnTransferToItems
            // 
            bttnTransferToItems.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            bttnTransferToItems.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            bttnTransferToItems.Depth = 0;
            bttnTransferToItems.HighEmphasis = true;
            bttnTransferToItems.Icon = null;
            bttnTransferToItems.Location = new Point(299, 147);
            bttnTransferToItems.Margin = new Padding(4, 6, 4, 6);
            bttnTransferToItems.MouseState = MaterialSkin.MouseState.HOVER;
            bttnTransferToItems.Name = "bttnTransferToItems";
            bttnTransferToItems.NoAccentTextColor = Color.Empty;
            bttnTransferToItems.Size = new Size(141, 36);
            bttnTransferToItems.TabIndex = 6;
            bttnTransferToItems.Text = "Transfer Items";
            bttnTransferToItems.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            bttnTransferToItems.UseAccentColor = false;
            bttnTransferToItems.UseVisualStyleBackColor = true;
            // 
            // bttnTrsansferToCustomer
            // 
            bttnTrsansferToCustomer.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            bttnTrsansferToCustomer.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            bttnTrsansferToCustomer.Depth = 0;
            bttnTrsansferToCustomer.HighEmphasis = true;
            bttnTrsansferToCustomer.Icon = null;
            bttnTrsansferToCustomer.Location = new Point(79, 147);
            bttnTrsansferToCustomer.Margin = new Padding(4, 6, 4, 6);
            bttnTrsansferToCustomer.MouseState = MaterialSkin.MouseState.HOVER;
            bttnTrsansferToCustomer.Name = "bttnTrsansferToCustomer";
            bttnTrsansferToCustomer.NoAccentTextColor = Color.Empty;
            bttnTrsansferToCustomer.Size = new Size(176, 36);
            bttnTrsansferToCustomer.TabIndex = 5;
            bttnTrsansferToCustomer.Text = "Transfer Customer";
            bttnTrsansferToCustomer.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            bttnTrsansferToCustomer.UseAccentColor = false;
            bttnTrsansferToCustomer.UseVisualStyleBackColor = true;
            // 
            // qbtoSArt
            // 
            qbtoSArt.AutoSize = true;
            qbtoSArt.Depth = 0;
            qbtoSArt.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            qbtoSArt.Location = new Point(253, 87);
            qbtoSArt.MouseState = MaterialSkin.MouseState.HOVER;
            qbtoSArt.Name = "qbtoSArt";
            qbtoSArt.Size = new Size(171, 19);
            qbtoSArt.TabIndex = 4;
            qbtoSArt.Text = "QuickBooks To SalesArt";
            // 
            // materialTabSelector1
            // 
            materialTabSelector1.BackColor = Color.Black;
            materialTabSelector1.BaseTabControl = null;
            materialTabSelector1.CharacterCasing = MaterialSkin.Controls.MaterialTabSelector.CustomCharacterCasing.Normal;
            materialTabSelector1.Depth = 0;
            materialTabSelector1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialTabSelector1.ForeColor = Color.Black;
            materialTabSelector1.Location = new Point(-1, 88);
            materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            materialTabSelector1.Name = "materialTabSelector1";
            materialTabSelector1.Size = new Size(720, 18);
            materialTabSelector1.TabIndex = 3;
            materialTabSelector1.Text = "materialTabSelector1";
            // 
            // infoConnectQb
            // 
            infoConnectQb.AutoSize = true;
            infoConnectQb.Depth = 0;
            infoConnectQb.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Pixel);
            infoConnectQb.FontType = MaterialSkin.MaterialSkinManager.fontType.Caption;
            infoConnectQb.Location = new Point(219, 32);
            infoConnectQb.MouseState = MaterialSkin.MouseState.HOVER;
            infoConnectQb.Name = "infoConnectQb";
            infoConnectQb.Size = new Size(36, 14);
            infoConnectQb.TabIndex = 2;
            infoConnectQb.Text = "Status";
            // 
            // connectqb
            // 
            connectqb.AutoSize = true;
            connectqb.Depth = 0;
            connectqb.Location = new Point(14, 22);
            connectqb.Margin = new Padding(0);
            connectqb.MouseLocation = new Point(-1, -1);
            connectqb.MouseState = MaterialSkin.MouseState.HOVER;
            connectqb.Name = "connectqb";
            connectqb.RightToLeft = RightToLeft.Yes;
            connectqb.Ripple = true;
            connectqb.Size = new Size(197, 37);
            connectqb.TabIndex = 1;
            connectqb.Text = "Connect QuickBooks ";
            connectqb.ThreeState = true;
            connectqb.UseVisualStyleBackColor = true;
            // 
            // mainScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(737, 450);
            Controls.Add(materialCard1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "mainScreen";
            Text = "SArtIntegration.qb";
            materialCard1.ResumeLayout(false);
            materialCard1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialSwitch connectqb;
        private MaterialSkin.Controls.MaterialLabel infoConnectQb;
        private MaterialSkin.Controls.MaterialLabel qbtoSArt;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private MaterialSkin.Controls.MaterialLabel SArtToQb;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector2;
        private MaterialSkin.Controls.MaterialButton bttnTransferToStocks;
        private MaterialSkin.Controls.MaterialButton bttnTransferToItems;
        private MaterialSkin.Controls.MaterialButton bttnTrsansferToCustomer;
    }
}