namespace SArtIntegration.qb
{
    partial class dataSendScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dataSendScreen));
            lblDataSendInfo = new Label();
            progressBar1 = new ProgressBar();
            SuspendLayout();
            // 
            // lblDataSendInfo
            // 
            lblDataSendInfo.AutoSize = true;
            lblDataSendInfo.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblDataSendInfo.Location = new Point(121, 96);
            lblDataSendInfo.Name = "lblDataSendInfo";
            lblDataSendInfo.Size = new Size(89, 15);
            lblDataSendInfo.TabIndex = 0;
            lblDataSendInfo.Text = "Datas loading...";
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(121, 135);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(405, 23);
            progressBar1.TabIndex = 1;
            // 
            // dataSendScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(657, 300);
            Controls.Add(progressBar1);
            Controls.Add(lblDataSendInfo);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "dataSendScreen";
            Text = "SArtIntegration.qb";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDataSendInfo;
        private ProgressBar progressBar1;
    }
}