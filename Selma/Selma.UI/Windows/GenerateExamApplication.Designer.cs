namespace Selma.UI.Windows
{
    partial class GenerateExamApplication
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
            this.lblCategory = new System.Windows.Forms.Label();
            this.txtCategory = new System.Windows.Forms.TextBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.lblCandidateInfo = new System.Windows.Forms.Label();
            this.dtpTakenOn = new System.Windows.Forms.DateTimePicker();
            this.lblTakenOn = new System.Windows.Forms.Label();
            this.chxIncludesTrafficRegulationTest = new System.Windows.Forms.CheckBox();
            this.chxIncludesFirstAidTest = new System.Windows.Forms.CheckBox();
            this.chxIncludesDrivingTest = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(209, 47);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(72, 13);
            this.lblCategory.TabIndex = 0;
            this.lblCategory.Text = "Za kategoriju:";
            // 
            // txtCategory
            // 
            this.txtCategory.Location = new System.Drawing.Point(287, 44);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Size = new System.Drawing.Size(71, 20);
            this.txtCategory.TabIndex = 1;
            // 
            // btnGenerate
            // 
            this.btnGenerate.BackColor = System.Drawing.Color.LimeGreen;
            this.btnGenerate.Location = new System.Drawing.Point(246, 168);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(112, 23);
            this.btnGenerate.TabIndex = 2;
            this.btnGenerate.Text = "Kreiraj";
            this.btnGenerate.UseVisualStyleBackColor = false;
            this.btnGenerate.Click += new System.EventHandler(this.BtnGenerate_Click);
            // 
            // lblCandidateInfo
            // 
            this.lblCandidateInfo.AutoSize = true;
            this.lblCandidateInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCandidateInfo.Location = new System.Drawing.Point(16, 13);
            this.lblCandidateInfo.Name = "lblCandidateInfo";
            this.lblCandidateInfo.Size = new System.Drawing.Size(131, 13);
            this.lblCandidateInfo.TabIndex = 3;
            this.lblCandidateInfo.Text = "Prijava za kandidata: ";
            // 
            // dtpTakenOn
            // 
            this.dtpTakenOn.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTakenOn.Location = new System.Drawing.Point(103, 44);
            this.dtpTakenOn.Name = "dtpTakenOn";
            this.dtpTakenOn.Size = new System.Drawing.Size(100, 20);
            this.dtpTakenOn.TabIndex = 5;
            // 
            // lblTakenOn
            // 
            this.lblTakenOn.AutoSize = true;
            this.lblTakenOn.Location = new System.Drawing.Point(16, 47);
            this.lblTakenOn.Name = "lblTakenOn";
            this.lblTakenOn.Size = new System.Drawing.Size(82, 13);
            this.lblTakenOn.TabIndex = 6;
            this.lblTakenOn.Text = "Polagano dana:";
            // 
            // chxIncludesTrafficRegulationTest
            // 
            this.chxIncludesTrafficRegulationTest.AutoSize = true;
            this.chxIncludesTrafficRegulationTest.Location = new System.Drawing.Point(40, 87);
            this.chxIncludesTrafficRegulationTest.Name = "chxIncludesTrafficRegulationTest";
            this.chxIncludesTrafficRegulationTest.Size = new System.Drawing.Size(291, 17);
            this.chxIncludesTrafficRegulationTest.TabIndex = 10;
            this.chxIncludesTrafficRegulationTest.Text = "Poznavanje propisa o sigurnosti saobracaja na putevima";
            this.chxIncludesTrafficRegulationTest.UseVisualStyleBackColor = true;
            // 
            // chxIncludesFirstAidTest
            // 
            this.chxIncludesFirstAidTest.AutoSize = true;
            this.chxIncludesFirstAidTest.Location = new System.Drawing.Point(40, 110);
            this.chxIncludesFirstAidTest.Name = "chxIncludesFirstAidTest";
            this.chxIncludesFirstAidTest.Size = new System.Drawing.Size(126, 17);
            this.chxIncludesFirstAidTest.TabIndex = 11;
            this.chxIncludesFirstAidTest.Text = "Program prve pomoci";
            this.chxIncludesFirstAidTest.UseVisualStyleBackColor = true;
            // 
            // chxIncludesDrivingTest
            // 
            this.chxIncludesDrivingTest.AutoSize = true;
            this.chxIncludesDrivingTest.Location = new System.Drawing.Point(40, 133);
            this.chxIncludesDrivingTest.Name = "chxIncludesDrivingTest";
            this.chxIncludesDrivingTest.Size = new System.Drawing.Size(162, 17);
            this.chxIncludesDrivingTest.TabIndex = 12;
            this.chxIncludesDrivingTest.Text = "Upravljanje motornim vozilom";
            this.chxIncludesDrivingTest.UseVisualStyleBackColor = true;
            // 
            // GenerateExamApplication
            // 
            this.AcceptButton = this.btnGenerate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 203);
            this.Controls.Add(this.chxIncludesDrivingTest);
            this.Controls.Add(this.chxIncludesFirstAidTest);
            this.Controls.Add(this.chxIncludesTrafficRegulationTest);
            this.Controls.Add(this.lblTakenOn);
            this.Controls.Add(this.dtpTakenOn);
            this.Controls.Add(this.lblCandidateInfo);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.txtCategory);
            this.Controls.Add(this.lblCategory);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GenerateExamApplication";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Kreiraj prijavu";
            this.Load += new System.EventHandler(this.GenerateExamApplication_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.TextBox txtCategory;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Label lblCandidateInfo;
        private System.Windows.Forms.DateTimePicker dtpTakenOn;
        private System.Windows.Forms.Label lblTakenOn;
        private System.Windows.Forms.CheckBox chxIncludesTrafficRegulationTest;
        private System.Windows.Forms.CheckBox chxIncludesFirstAidTest;
        private System.Windows.Forms.CheckBox chxIncludesDrivingTest;
    }
}