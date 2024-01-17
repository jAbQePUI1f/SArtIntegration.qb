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
            bttnTransferCollection = new MaterialSkin.Controls.MaterialButton();
            bttnTransferInvoice = new MaterialSkin.Controls.MaterialButton();
            bttnTransferToItems = new MaterialSkin.Controls.MaterialButton();
            bttnTrsansferToCustomer = new MaterialSkin.Controls.MaterialButton();
            lblQBstatus = new MaterialSkin.Controls.MaterialLabel();
            gboxSalesArtToQB = new GroupBox();
            gboxQbToSalesArt = new GroupBox();
            menuSArtIntegration = new MenuStrip();
            menüToolStripMenuItem = new ToolStripMenuItem();
            geriDönToolStripMenuItem = new ToolStripMenuItem();
            çıkışToolStripMenuItem = new ToolStripMenuItem();
            gboxSalesArtToQB.SuspendLayout();
            gboxQbToSalesArt.SuspendLayout();
            menuSArtIntegration.SuspendLayout();
            SuspendLayout();
            // 
            // bttnTransferCollection
            // 
            bttnTransferCollection.AutoSize = false;
            bttnTransferCollection.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            bttnTransferCollection.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            bttnTransferCollection.Depth = 0;
            bttnTransferCollection.HighEmphasis = true;
            bttnTransferCollection.Icon = null;
            bttnTransferCollection.Location = new Point(216, 30);
            bttnTransferCollection.Margin = new Padding(4);
            bttnTransferCollection.MouseState = MaterialSkin.MouseState.HOVER;
            bttnTransferCollection.Name = "bttnTransferCollection";
            bttnTransferCollection.NoAccentTextColor = Color.Empty;
            bttnTransferCollection.Size = new Size(192, 36);
            bttnTransferCollection.TabIndex = 19;
            bttnTransferCollection.Text = "Transfer Collectıon";
            bttnTransferCollection.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            bttnTransferCollection.UseAccentColor = false;
            bttnTransferCollection.UseVisualStyleBackColor = true;
            bttnTransferCollection.Click += bttnTransferCollection_Click_1;
            // 
            // bttnTransferInvoice
            // 
            bttnTransferInvoice.AutoSize = false;
            bttnTransferInvoice.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            bttnTransferInvoice.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            bttnTransferInvoice.Depth = 0;
            bttnTransferInvoice.HighEmphasis = true;
            bttnTransferInvoice.Icon = null;
            bttnTransferInvoice.Location = new Point(216, 87);
            bttnTransferInvoice.Margin = new Padding(4);
            bttnTransferInvoice.MouseState = MaterialSkin.MouseState.HOVER;
            bttnTransferInvoice.Name = "bttnTransferInvoice";
            bttnTransferInvoice.NoAccentTextColor = Color.Empty;
            bttnTransferInvoice.Size = new Size(192, 36);
            bttnTransferInvoice.TabIndex = 18;
            bttnTransferInvoice.Text = "Transfer Invoıce";
            bttnTransferInvoice.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            bttnTransferInvoice.UseAccentColor = false;
            bttnTransferInvoice.UseVisualStyleBackColor = true;
            // 
            // bttnTransferToItems
            // 
            bttnTransferToItems.AutoSize = false;
            bttnTransferToItems.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            bttnTransferToItems.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            bttnTransferToItems.Depth = 0;
            bttnTransferToItems.HighEmphasis = true;
            bttnTransferToItems.Icon = null;
            bttnTransferToItems.Location = new Point(216, 85);
            bttnTransferToItems.Margin = new Padding(4, 6, 4, 6);
            bttnTransferToItems.MouseState = MaterialSkin.MouseState.HOVER;
            bttnTransferToItems.Name = "bttnTransferToItems";
            bttnTransferToItems.NoAccentTextColor = Color.Empty;
            bttnTransferToItems.Size = new Size(192, 36);
            bttnTransferToItems.TabIndex = 15;
            bttnTransferToItems.Text = "Transfer Items";
            bttnTransferToItems.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            bttnTransferToItems.UseAccentColor = false;
            bttnTransferToItems.UseVisualStyleBackColor = true;
            // 
            // bttnTrsansferToCustomer
            // 
            bttnTrsansferToCustomer.AutoSize = false;
            bttnTrsansferToCustomer.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            bttnTrsansferToCustomer.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            bttnTrsansferToCustomer.Depth = 0;
            bttnTrsansferToCustomer.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            bttnTrsansferToCustomer.HighEmphasis = true;
            bttnTrsansferToCustomer.Icon = null;
            bttnTrsansferToCustomer.Location = new Point(253, 78);
            bttnTrsansferToCustomer.Margin = new Padding(4, 6, 4, 6);
            bttnTrsansferToCustomer.MouseState = MaterialSkin.MouseState.HOVER;
            bttnTrsansferToCustomer.Name = "bttnTrsansferToCustomer";
            bttnTrsansferToCustomer.NoAccentTextColor = Color.Empty;
            bttnTrsansferToCustomer.Size = new Size(192, 36);
            bttnTrsansferToCustomer.TabIndex = 14;
            bttnTrsansferToCustomer.Text = "Transfer Customer";
            bttnTrsansferToCustomer.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            bttnTrsansferToCustomer.UseAccentColor = false;
            bttnTrsansferToCustomer.UseVisualStyleBackColor = true;
            bttnTrsansferToCustomer.Click += bttnTrsansferToCustomer_Click_1;
            // 
            // lblQBstatus
            // 
            lblQBstatus.AutoSize = true;
            lblQBstatus.BackColor = SystemColors.ActiveCaption;
            lblQBstatus.Depth = 0;
            lblQBstatus.FlatStyle = FlatStyle.Popup;
            lblQBstatus.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblQBstatus.ForeColor = Color.Black;
            lblQBstatus.Location = new Point(666, 29);
            lblQBstatus.MouseState = MaterialSkin.MouseState.HOVER;
            lblQBstatus.Name = "lblQBstatus";
            lblQBstatus.Size = new Size(62, 19);
            lblQBstatus.TabIndex = 20;
            lblQBstatus.Text = "Deactive";
            // 
            // gboxSalesArtToQB
            // 
            gboxSalesArtToQB.Controls.Add(bttnTransferToItems);
            gboxSalesArtToQB.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            gboxSalesArtToQB.Location = new Point(37, 45);
            gboxSalesArtToQB.Name = "gboxSalesArtToQB";
            gboxSalesArtToQB.Size = new Size(664, 149);
            gboxSalesArtToQB.TabIndex = 21;
            gboxSalesArtToQB.TabStop = false;
            gboxSalesArtToQB.Text = "SalesArt To QuickBooks";
            // 
            // gboxQbToSalesArt
            // 
            gboxQbToSalesArt.Controls.Add(bttnTransferCollection);
            gboxQbToSalesArt.Controls.Add(bttnTransferInvoice);
            gboxQbToSalesArt.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            gboxQbToSalesArt.Location = new Point(37, 267);
            gboxQbToSalesArt.Name = "gboxQbToSalesArt";
            gboxQbToSalesArt.Size = new Size(664, 156);
            gboxQbToSalesArt.TabIndex = 22;
            gboxQbToSalesArt.TabStop = false;
            gboxQbToSalesArt.Text = "QuickBooks To SalesArt";
            // 
            // menuSArtIntegration
            // 
            menuSArtIntegration.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            menuSArtIntegration.Items.AddRange(new ToolStripItem[] { menüToolStripMenuItem });
            menuSArtIntegration.Location = new Point(0, 0);
            menuSArtIntegration.Name = "menuSArtIntegration";
            menuSArtIntegration.Size = new Size(737, 24);
            menuSArtIntegration.TabIndex = 23;
            menuSArtIntegration.Text = "menuStrip1";
            // 
            // menüToolStripMenuItem
            // 
            menüToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { geriDönToolStripMenuItem, çıkışToolStripMenuItem });
            menüToolStripMenuItem.Name = "menüToolStripMenuItem";
            menüToolStripMenuItem.Size = new Size(50, 20);
            menüToolStripMenuItem.Text = "Menü";
            // 
            // geriDönToolStripMenuItem
            // 
            geriDönToolStripMenuItem.Name = "geriDönToolStripMenuItem";
            geriDönToolStripMenuItem.Size = new Size(180, 22);
            geriDönToolStripMenuItem.Text = "Geri Dön";
            // 
            // çıkışToolStripMenuItem
            // 
            çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            çıkışToolStripMenuItem.Size = new Size(180, 22);
            çıkışToolStripMenuItem.Text = "Çıkış";
            // 
            // mainScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(737, 450);
            Controls.Add(lblQBstatus);
            Controls.Add(bttnTrsansferToCustomer);
            Controls.Add(gboxSalesArtToQB);
            Controls.Add(gboxQbToSalesArt);
            Controls.Add(menuSArtIntegration);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuSArtIntegration;
            Name = "mainScreen";
            Text = "SArtIntegration.qb";
            gboxSalesArtToQB.ResumeLayout(false);
            gboxQbToSalesArt.ResumeLayout(false);
            menuSArtIntegration.ResumeLayout(false);
            menuSArtIntegration.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialButton bttnTransferCollection;
        private MaterialSkin.Controls.MaterialButton bttnTransferInvoice;
        private MaterialSkin.Controls.MaterialLabel SArtToQb;
        private MaterialSkin.Controls.MaterialButton bttnTransferToItems;
        private MaterialSkin.Controls.MaterialButton bttnTrsansferToCustomer;
        private MaterialSkin.Controls.MaterialLabel qbtoSArt;
        private MaterialSkin.Controls.MaterialLabel lblQBstatus;
        private GroupBox gboxSalesArtToQB;
        private GroupBox gboxQbToSalesArt;
        private MenuStrip menuSArtIntegration;
        private ToolStripMenuItem menüToolStripMenuItem;
        private ToolStripMenuItem geriDönToolStripMenuItem;
        private ToolStripMenuItem çıkışToolStripMenuItem;
    }
}