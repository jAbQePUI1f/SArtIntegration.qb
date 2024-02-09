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
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // comBoxDocument
            // 
            comBoxDocument.FormattingEnabled = true;
            comBoxDocument.Location = new Point(25, 100);
            comBoxDocument.Margin = new Padding(3, 4, 3, 4);
            comBoxDocument.Name = "comBoxDocument";
            comBoxDocument.Size = new Size(239, 28);
            comBoxDocument.TabIndex = 0;
            comBoxDocument.SelectedIndexChanged += comBoxDocument_SelectedIndexChanged;
            // 
            // lblDocument
            // 
            lblDocument.AutoSize = true;
            lblDocument.Location = new Point(22, 71);
            lblDocument.Name = "lblDocument";
            lblDocument.Size = new Size(166, 20);
            lblDocument.TabIndex = 1;
            lblDocument.Text = "Choose Document Type";
            // 
            // lblBeginDate
            // 
            lblBeginDate.AutoSize = true;
            lblBeginDate.Location = new Point(431, 71);
            lblBeginDate.Name = "lblBeginDate";
            lblBeginDate.Size = new Size(136, 20);
            lblBeginDate.TabIndex = 3;
            lblBeginDate.Text = "Choose Begin Date";
            // 
            // lblEndDate
            // 
            lblEndDate.AutoSize = true;
            lblEndDate.Location = new Point(731, 71);
            lblEndDate.Name = "lblEndDate";
            lblEndDate.Size = new Size(123, 20);
            lblEndDate.TabIndex = 5;
            lblEndDate.Text = "Choose End Date";
            // 
            // pickerBeginDate
            // 
            pickerBeginDate.Location = new Point(431, 100);
            pickerBeginDate.Margin = new Padding(3, 4, 3, 4);
            pickerBeginDate.Name = "pickerBeginDate";
            pickerBeginDate.Size = new Size(228, 27);
            pickerBeginDate.TabIndex = 6;
            // 
            // pickerEndDate
            // 
            pickerEndDate.Location = new Point(731, 100);
            pickerEndDate.Margin = new Padding(3, 4, 3, 4);
            pickerEndDate.Name = "pickerEndDate";
            pickerEndDate.Size = new Size(228, 27);
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
            dataGridView1.Location = new Point(23, 209);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1083, 680);
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
            bttnGetData.Location = new Point(25, 149);
            bttnGetData.Margin = new Padding(5, 8, 5, 8);
            bttnGetData.MouseState = MaterialSkin.MouseState.HOVER;
            bttnGetData.Name = "bttnGetData";
            bttnGetData.NoAccentTextColor = Color.Empty;
            bttnGetData.Size = new Size(240, 48);
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
            chckAll.Location = new Point(25, 208);
            chckAll.Name = "chckAll";
            chckAll.RightToLeft = RightToLeft.Yes;
            chckAll.Size = new Size(18, 17);
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
            btnTransfer.Location = new Point(705, 149);
            btnTransfer.Margin = new Padding(5, 8, 5, 8);
            btnTransfer.MouseState = MaterialSkin.MouseState.HOVER;
            btnTransfer.Name = "btnTransfer";
            btnTransfer.NoAccentTextColor = Color.Empty;
            btnTransfer.Size = new Size(240, 48);
            btnTransfer.TabIndex = 17;
            btnTransfer.Text = "GET DATA";
            btnTransfer.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnTransfer.UseAccentColor = false;
            btnTransfer.UseVisualStyleBackColor = true;
            btnTransfer.Click += btnTransfer_Click;
            // 
            // button1
            // 
            button1.Location = new Point(943, 12);
            button1.Name = "button1";
            button1.Size = new Size(152, 29);
            button1.TabIndex = 18;
            button1.Text = "Return Main Menu";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // formDialogScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1120, 905);
            Controls.Add(button1);
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
            Margin = new Padding(3, 4, 3, 4);
            Name = "formDialogScreen";
            Text = "SArtIntegration.qb";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
        private Button button1;
    }
}