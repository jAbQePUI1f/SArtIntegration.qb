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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // comBoxDocument
            // 
            comBoxDocument.FormattingEnabled = true;
            comBoxDocument.Location = new Point(22, 75);
            comBoxDocument.Name = "comBoxDocument";
            comBoxDocument.Size = new Size(210, 23);
            comBoxDocument.TabIndex = 0;
            comBoxDocument.SelectedIndexChanged += comBoxDocument_SelectedIndexChanged;
            // 
            // lblDocument
            // 
            lblDocument.AutoSize = true;
            lblDocument.Location = new Point(19, 53);
            lblDocument.Name = "lblDocument";
            lblDocument.Size = new Size(133, 15);
            lblDocument.TabIndex = 1;
            lblDocument.Text = "Choose Document Type";
            // 
            // lblBeginDate
            // 
            lblBeginDate.AutoSize = true;
            lblBeginDate.Location = new Point(312, 53);
            lblBeginDate.Name = "lblBeginDate";
            lblBeginDate.Size = new Size(107, 15);
            lblBeginDate.TabIndex = 3;
            lblBeginDate.Text = "Choose Begin Date";
            // 
            // lblEndDate
            // 
            lblEndDate.AutoSize = true;
            lblEndDate.Location = new Point(575, 53);
            lblEndDate.Name = "lblEndDate";
            lblEndDate.Size = new Size(97, 15);
            lblEndDate.TabIndex = 5;
            lblEndDate.Text = "Choose End Date";
            // 
            // pickerBeginDate
            // 
            pickerBeginDate.Location = new Point(312, 75);
            pickerBeginDate.Name = "pickerBeginDate";
            pickerBeginDate.Size = new Size(200, 23);
            pickerBeginDate.TabIndex = 6;
            // 
            // pickerEndDate
            // 
            pickerEndDate.Location = new Point(575, 75);
            pickerEndDate.Name = "pickerEndDate";
            pickerEndDate.Size = new Size(200, 23);
            pickerEndDate.TabIndex = 7;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(20, 157);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(805, 510);
            dataGridView1.TabIndex = 8;
            // 
            // formDialogScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(837, 679);
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
    }
}