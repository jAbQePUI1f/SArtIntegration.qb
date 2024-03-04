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
            gboxQuickBooks = new GroupBox();
            gboxSalesArt = new GroupBox();
            menuSArtIntegration = new MenuStrip();
            menüToolStripMenuItem = new ToolStripMenuItem();
            geriDönToolStripMenuItem = new ToolStripMenuItem();
            çıkışToolStripMenuItem = new ToolStripMenuItem();
            gboxQuickBooks.SuspendLayout();
            gboxSalesArt.SuspendLayout();
            menuSArtIntegration.SuspendLayout();
            SuspendLayout();
            // 
            // bttnTransferCollection
            // 
            resources.ApplyResources(bttnTransferCollection, "bttnTransferCollection");
            bttnTransferCollection.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            bttnTransferCollection.Depth = 0;
            bttnTransferCollection.HighEmphasis = true;
            bttnTransferCollection.Icon = Properties.Resources._2343805;
            bttnTransferCollection.MouseState = MaterialSkin.MouseState.HOVER;
            bttnTransferCollection.Name = "bttnTransferCollection";
            bttnTransferCollection.NoAccentTextColor = Color.Empty;
            bttnTransferCollection.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            bttnTransferCollection.UseAccentColor = false;
            bttnTransferCollection.UseVisualStyleBackColor = true;
            bttnTransferCollection.Click += bttnTransferCollection_Click;
            // 
            // bttnTransferInvoice
            // 
            resources.ApplyResources(bttnTransferInvoice, "bttnTransferInvoice");
            bttnTransferInvoice.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            bttnTransferInvoice.Depth = 0;
            bttnTransferInvoice.HighEmphasis = true;
            bttnTransferInvoice.Icon = Properties.Resources._2343805;
            bttnTransferInvoice.MouseState = MaterialSkin.MouseState.HOVER;
            bttnTransferInvoice.Name = "bttnTransferInvoice";
            bttnTransferInvoice.NoAccentTextColor = Color.Empty;
            bttnTransferInvoice.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            bttnTransferInvoice.UseAccentColor = false;
            bttnTransferInvoice.UseVisualStyleBackColor = true;
            bttnTransferInvoice.Click += bttnTransferInvoice_Click;
            // 
            // bttnTransferToItems
            // 
            resources.ApplyResources(bttnTransferToItems, "bttnTransferToItems");
            bttnTransferToItems.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            bttnTransferToItems.Depth = 0;
            bttnTransferToItems.HighEmphasis = true;
            bttnTransferToItems.Icon = Properties.Resources._2343805;
            bttnTransferToItems.MouseState = MaterialSkin.MouseState.HOVER;
            bttnTransferToItems.Name = "bttnTransferToItems";
            bttnTransferToItems.NoAccentTextColor = Color.Empty;
            bttnTransferToItems.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            bttnTransferToItems.UseAccentColor = false;
            bttnTransferToItems.UseVisualStyleBackColor = true;
            bttnTransferToItems.Click += bttnTransferToItems_Click;
            // 
            // bttnTrsansferToCustomer
            // 
            resources.ApplyResources(bttnTrsansferToCustomer, "bttnTrsansferToCustomer");
            bttnTrsansferToCustomer.BackColor = Color.White;
            bttnTrsansferToCustomer.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            bttnTrsansferToCustomer.Depth = 0;
            bttnTrsansferToCustomer.ForeColor = SystemColors.ActiveCaption;
            bttnTrsansferToCustomer.HighEmphasis = true;
            bttnTrsansferToCustomer.Icon = Properties.Resources._2343805;
            bttnTrsansferToCustomer.MouseState = MaterialSkin.MouseState.HOVER;
            bttnTrsansferToCustomer.Name = "bttnTrsansferToCustomer";
            bttnTrsansferToCustomer.NoAccentTextColor = Color.Empty;
            bttnTrsansferToCustomer.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            bttnTrsansferToCustomer.UseAccentColor = false;
            bttnTrsansferToCustomer.UseVisualStyleBackColor = false;
            bttnTrsansferToCustomer.Click += bttnTrsansferToCustomer_Click;
            // 
            // gboxQuickBooks
            // 
            resources.ApplyResources(gboxQuickBooks, "gboxQuickBooks");
            gboxQuickBooks.Controls.Add(bttnTransferToItems);
            gboxQuickBooks.Name = "gboxQuickBooks";
            gboxQuickBooks.TabStop = false;
            // 
            // gboxSalesArt
            // 
            resources.ApplyResources(gboxSalesArt, "gboxSalesArt");
            gboxSalesArt.Controls.Add(bttnTransferCollection);
            gboxSalesArt.Controls.Add(bttnTransferInvoice);
            gboxSalesArt.Name = "gboxSalesArt";
            gboxSalesArt.TabStop = false;
            // 
            // menuSArtIntegration
            // 
            resources.ApplyResources(menuSArtIntegration, "menuSArtIntegration");
            menuSArtIntegration.ImageScalingSize = new Size(20, 20);
            menuSArtIntegration.Items.AddRange(new ToolStripItem[] { menüToolStripMenuItem });
            menuSArtIntegration.Name = "menuSArtIntegration";
            // 
            // menüToolStripMenuItem
            // 
            resources.ApplyResources(menüToolStripMenuItem, "menüToolStripMenuItem");
            menüToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { geriDönToolStripMenuItem, çıkışToolStripMenuItem });
            menüToolStripMenuItem.Name = "menüToolStripMenuItem";
            // 
            // geriDönToolStripMenuItem
            // 
            resources.ApplyResources(geriDönToolStripMenuItem, "geriDönToolStripMenuItem");
            geriDönToolStripMenuItem.Name = "geriDönToolStripMenuItem";
            // 
            // çıkışToolStripMenuItem
            // 
            resources.ApplyResources(çıkışToolStripMenuItem, "çıkışToolStripMenuItem");
            çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            çıkışToolStripMenuItem.Click += çıkışToolStripMenuItem_Click;
            // 
            // mainScreen
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(bttnTrsansferToCustomer);
            Controls.Add(gboxQuickBooks);
            Controls.Add(gboxSalesArt);
            Controls.Add(menuSArtIntegration);
            MainMenuStrip = menuSArtIntegration;
            MaximizeBox = false;
            Name = "mainScreen";
            gboxQuickBooks.ResumeLayout(false);
            gboxSalesArt.ResumeLayout(false);
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
        private GroupBox gboxQuickBooks;
        private GroupBox gboxSalesArt;
        private MenuStrip menuSArtIntegration;
        private ToolStripMenuItem menüToolStripMenuItem;
        private ToolStripMenuItem geriDönToolStripMenuItem;
        private ToolStripMenuItem çıkışToolStripMenuItem;
    }
}