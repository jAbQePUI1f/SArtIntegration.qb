namespace SArtIntegration.qb
{
    partial class formDialogScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formDialogScreen));
            comBoxDocument = new ComboBox();
            lblDocument = new Label();
            lblBeginDate = new Label();
            lblEndDate = new Label();
            pickerBeginDate = new DateTimePicker();
            pickerEndDate = new DateTimePicker();
            dataGridView1 = new DataGridView();
            chk = new DataGridViewCheckBoxColumn();
            bttnGetData = new MaterialSkin.Controls.MaterialButton();
            chckAll = new CheckBox();
            btnTransfer = new MaterialSkin.Controls.MaterialButton();
            menuSArtIntegration = new MenuStrip();
            menüToolStripMenuItem = new ToolStripMenuItem();
            geriDönToolStripMenuItem = new ToolStripMenuItem();
            çıkışToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            menuSArtIntegration.SuspendLayout();
            SuspendLayout();
            // 
            // comBoxDocument
            // 
            comBoxDocument.FormattingEnabled = true;
            comBoxDocument.Location = new Point(22, 52);
            comBoxDocument.Name = "comBoxDocument";
            comBoxDocument.Size = new Size(219, 23);
            comBoxDocument.TabIndex = 0;
            comBoxDocument.SelectedIndexChanged += comBoxDocument_SelectedIndexChanged;
            // 
            // lblDocument
            // 
            lblDocument.AutoSize = true;
            lblDocument.Location = new Point(24, 30);
            lblDocument.Name = "lblDocument";
            lblDocument.Size = new Size(133, 15);
            lblDocument.TabIndex = 1;
            lblDocument.Text = "Choose Document Type";
            // 
            // lblBeginDate
            // 
            lblBeginDate.AutoSize = true;
            lblBeginDate.Location = new Point(505, 30);
            lblBeginDate.Name = "lblBeginDate";
            lblBeginDate.Size = new Size(107, 15);
            lblBeginDate.TabIndex = 3;
            lblBeginDate.Text = "Choose Begin Date";
            // 
            // lblEndDate
            // 
            lblEndDate.AutoSize = true;
            lblEndDate.Location = new Point(753, 30);
            lblEndDate.Name = "lblEndDate";
            lblEndDate.Size = new Size(97, 15);
            lblEndDate.TabIndex = 5;
            lblEndDate.Text = "Choose End Date";
            // 
            // pickerBeginDate
            // 
            pickerBeginDate.Location = new Point(505, 52);
            pickerBeginDate.Name = "pickerBeginDate";
            pickerBeginDate.Size = new Size(215, 23);
            pickerBeginDate.TabIndex = 6;
            // 
            // pickerEndDate
            // 
            pickerEndDate.Location = new Point(753, 52);
            pickerEndDate.Name = "pickerEndDate";
            pickerEndDate.Size = new Size(210, 23);
            pickerEndDate.TabIndex = 7;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.BorderStyle = BorderStyle.Fixed3D;
            dataGridView1.ClipboardCopyMode = DataGridViewClipboardCopyMode.Disable;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { chk });
            dataGridView1.Location = new Point(20, 144);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(948, 523);
            dataGridView1.TabIndex = 8;
            // 
            // chk
            // 
            chk.FillWeight = 45F;
            chk.HeaderText = "";
            chk.MinimumWidth = 6;
            chk.Name = "chk";
            chk.ToolTipText = "Select All...";
            chk.Visible = false;
            chk.Width = 25;
            // 
            // bttnGetData
            // 
            bttnGetData.AutoSize = false;
            bttnGetData.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            bttnGetData.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            bttnGetData.Depth = 0;
            bttnGetData.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            bttnGetData.HighEmphasis = true;
            bttnGetData.Icon = null;
            bttnGetData.Location = new Point(22, 85);
            bttnGetData.Margin = new Padding(4, 6, 4, 6);
            bttnGetData.MouseState = MaterialSkin.MouseState.HOVER;
            bttnGetData.Name = "bttnGetData";
            bttnGetData.NoAccentTextColor = Color.Empty;
            bttnGetData.Size = new Size(219, 36);
            bttnGetData.TabIndex = 15;
            bttnGetData.Text = "GET DATA";
            bttnGetData.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            bttnGetData.UseAccentColor = false;
            bttnGetData.UseVisualStyleBackColor = true;
            bttnGetData.Click += bttnGetData_Click;
            // 
            // chckAll
            // 
            chckAll.AutoSize = true;
            chckAll.Location = new Point(23, 149);
            chckAll.Margin = new Padding(3, 2, 3, 2);
            chckAll.Name = "chckAll";
            chckAll.RightToLeft = RightToLeft.Yes;
            chckAll.Size = new Size(15, 14);
            chckAll.TabIndex = 16;
            chckAll.UseVisualStyleBackColor = true;
            chckAll.Visible = false;
            chckAll.CheckedChanged += chckAll_CheckedChanged;
            // 
            // btnTransfer
            // 
            btnTransfer.AutoSize = false;
            btnTransfer.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnTransfer.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnTransfer.Depth = 0;
            btnTransfer.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnTransfer.HighEmphasis = true;
            btnTransfer.Icon = null;
            btnTransfer.Location = new Point(753, 85);
            btnTransfer.Margin = new Padding(4, 6, 4, 6);
            btnTransfer.MouseState = MaterialSkin.MouseState.HOVER;
            btnTransfer.Name = "btnTransfer";
            btnTransfer.NoAccentTextColor = Color.Empty;
            btnTransfer.Size = new Size(210, 36);
            btnTransfer.TabIndex = 17;
            btnTransfer.Text = "SEND DATA";
            btnTransfer.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnTransfer.UseAccentColor = false;
            btnTransfer.UseVisualStyleBackColor = true;
            btnTransfer.Click += btnTransfer_Click;
            // 
            // menuSArtIntegration
            // 
            menuSArtIntegration.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            menuSArtIntegration.ImageScalingSize = new Size(20, 20);
            menuSArtIntegration.Items.AddRange(new ToolStripItem[] { menüToolStripMenuItem });
            menuSArtIntegration.Location = new Point(0, 0);
            menuSArtIntegration.Name = "menuSArtIntegration";
            menuSArtIntegration.Size = new Size(990, 24);
            menuSArtIntegration.TabIndex = 24;
            menuSArtIntegration.Text = "menuStrip1";
            // 
            // menüToolStripMenuItem
            // 
            menüToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { geriDönToolStripMenuItem, çıkışToolStripMenuItem });
            menüToolStripMenuItem.Name = "menüToolStripMenuItem";
            menüToolStripMenuItem.Size = new Size(50, 20);
            menüToolStripMenuItem.Text = "Menu";
            // 
            // geriDönToolStripMenuItem
            // 
            geriDönToolStripMenuItem.Name = "geriDönToolStripMenuItem";
            geriDönToolStripMenuItem.Size = new Size(180, 22);
            geriDönToolStripMenuItem.Text = "Back Return";
            geriDönToolStripMenuItem.Click += geriDönToolStripMenuItem_Click;
            // 
            // çıkışToolStripMenuItem
            // 
            çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            çıkışToolStripMenuItem.Size = new Size(180, 22);
            çıkışToolStripMenuItem.Text = "Exit";
            çıkışToolStripMenuItem.Click += çıkışToolStripMenuItem_Click;
            // 
            // formDialogScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(990, 698);
            Controls.Add(menuSArtIntegration);
            Controls.Add(btnTransfer);
            Controls.Add(chckAll);
            Controls.Add(bttnGetData);
            Controls.Add(dataGridView1);
            Controls.Add(pickerEndDate);
            Controls.Add(pickerBeginDate);
            Controls.Add(lblEndDate);
            Controls.Add(lblBeginDate);
            Controls.Add(lblDocument);
            Controls.Add(comBoxDocument);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "formDialogScreen";
            Text = "SArtIntegration.qb";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            menuSArtIntegration.ResumeLayout(false);
            menuSArtIntegration.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comBoxDocument;
        private Label lblDocument;
        private Label lblBeginDate;
        private Label lblEndDate;
        private DateTimePicker pickerBeginDate;
        private DateTimePicker pickerEndDate;
        private DataGridView dataGridView1;
        private MaterialSkin.Controls.MaterialButton bttnGetData;
        private CheckBox chckAll;
        private MaterialSkin.Controls.MaterialButton btnTransfer;
        private DataGridViewCheckBoxColumn chk;
        private MenuStrip menuSArtIntegration;
        private ToolStripMenuItem menüToolStripMenuItem;
        private ToolStripMenuItem geriDönToolStripMenuItem;
        private ToolStripMenuItem çıkışToolStripMenuItem;
    }
}