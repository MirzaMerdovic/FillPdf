namespace Selma.UI.Windows
{
    partial class SettingsForm
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
            this.lblDataPath = new System.Windows.Forms.Label();
            this.txtDataLocation = new System.Windows.Forms.TextBox();
            this.lblPdfTemplatePath = new System.Windows.Forms.Label();
            this.txtExamTemplatePath = new System.Windows.Forms.TextBox();
            this.fbdDataLocation = new System.Windows.Forms.FolderBrowserDialog();
            this.fbdExamTemplate = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // lblDataPath
            // 
            this.lblDataPath.AutoSize = true;
            this.lblDataPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDataPath.Location = new System.Drawing.Point(16, 25);
            this.lblDataPath.Name = "lblDataPath";
            this.lblDataPath.Size = new System.Drawing.Size(122, 13);
            this.lblDataPath.TabIndex = 0;
            this.lblDataPath.Text = "Putanja do Data foldera:";
            // 
            // txtDataLocation
            // 
            this.txtDataLocation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDataLocation.HideSelection = false;
            this.txtDataLocation.Location = new System.Drawing.Point(29, 41);
            this.txtDataLocation.Name = "txtDataLocation";
            this.txtDataLocation.ReadOnly = true;
            this.txtDataLocation.Size = new System.Drawing.Size(430, 20);
            this.txtDataLocation.TabIndex = 1;
            // 
            // lblPdfTemplatePath
            // 
            this.lblPdfTemplatePath.AutoSize = true;
            this.lblPdfTemplatePath.Location = new System.Drawing.Point(16, 73);
            this.lblPdfTemplatePath.Name = "lblPdfTemplatePath";
            this.lblPdfTemplatePath.Size = new System.Drawing.Size(218, 13);
            this.lblPdfTemplatePath.TabIndex = 2;
            this.lblPdfTemplatePath.Text = "Putanje do prazne PDF Prijave za polaganje:";
            // 
            // txtExamTemplatePath
            // 
            this.txtExamTemplatePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtExamTemplatePath.HideSelection = false;
            this.txtExamTemplatePath.Location = new System.Drawing.Point(29, 89);
            this.txtExamTemplatePath.Name = "txtExamTemplatePath";
            this.txtExamTemplatePath.ReadOnly = true;
            this.txtExamTemplatePath.Size = new System.Drawing.Size(430, 20);
            this.txtExamTemplatePath.TabIndex = 3;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 127);
            this.Controls.Add(this.txtExamTemplatePath);
            this.Controls.Add(this.lblPdfTemplatePath);
            this.Controls.Add(this.txtDataLocation);
            this.Controls.Add(this.lblDataPath);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Postavke";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDataPath;
        private System.Windows.Forms.TextBox txtDataLocation;
        private System.Windows.Forms.Label lblPdfTemplatePath;
        private System.Windows.Forms.TextBox txtExamTemplatePath;
        private System.Windows.Forms.FolderBrowserDialog fbdDataLocation;
        private System.Windows.Forms.FolderBrowserDialog fbdExamTemplate;
    }
}