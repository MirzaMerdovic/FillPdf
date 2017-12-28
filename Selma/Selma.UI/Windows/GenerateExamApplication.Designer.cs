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
            this.cbxExamDay = new System.Windows.Forms.ComboBox();
            this.lblLocation = new System.Windows.Forms.Label();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.lblInstructor = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
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
            this.btnGenerate.Location = new System.Drawing.Point(250, 256);
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
            this.chxIncludesTrafficRegulationTest.Location = new System.Drawing.Point(40, 79);
            this.chxIncludesTrafficRegulationTest.Name = "chxIncludesTrafficRegulationTest";
            this.chxIncludesTrafficRegulationTest.Size = new System.Drawing.Size(291, 17);
            this.chxIncludesTrafficRegulationTest.TabIndex = 10;
            this.chxIncludesTrafficRegulationTest.Text = "Poznavanje propisa o sigurnosti saobracaja na putevima";
            this.chxIncludesTrafficRegulationTest.UseVisualStyleBackColor = true;
            // 
            // chxIncludesFirstAidTest
            // 
            this.chxIncludesFirstAidTest.AutoSize = true;
            this.chxIncludesFirstAidTest.Location = new System.Drawing.Point(40, 102);
            this.chxIncludesFirstAidTest.Name = "chxIncludesFirstAidTest";
            this.chxIncludesFirstAidTest.Size = new System.Drawing.Size(126, 17);
            this.chxIncludesFirstAidTest.TabIndex = 11;
            this.chxIncludesFirstAidTest.Text = "Program prve pomoci";
            this.chxIncludesFirstAidTest.UseVisualStyleBackColor = true;
            // 
            // chxIncludesDrivingTest
            // 
            this.chxIncludesDrivingTest.AutoSize = true;
            this.chxIncludesDrivingTest.Location = new System.Drawing.Point(40, 125);
            this.chxIncludesDrivingTest.Name = "chxIncludesDrivingTest";
            this.chxIncludesDrivingTest.Size = new System.Drawing.Size(162, 17);
            this.chxIncludesDrivingTest.TabIndex = 12;
            this.chxIncludesDrivingTest.Text = "Upravljanje motornim vozilom";
            this.chxIncludesDrivingTest.UseVisualStyleBackColor = true;
            // 
            // cbxExamDay
            // 
            this.cbxExamDay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxExamDay.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbxExamDay.FormattingEnabled = true;
            this.cbxExamDay.Items.AddRange(new object[] {
            "Pondjeljak",
            "Utorak",
            "Srijeda",
            "Četvrtak",
            "Petak",
            "Subota",
            "Nedjelja"});
            this.cbxExamDay.Location = new System.Drawing.Point(208, 218);
            this.cbxExamDay.Name = "cbxExamDay";
            this.cbxExamDay.Size = new System.Drawing.Size(112, 21);
            this.cbxExamDay.TabIndex = 13;
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Location = new System.Drawing.Point(37, 221);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(50, 13);
            this.lblLocation.TabIndex = 14;
            this.lblLocation.Text = "Lokacija:";
            // 
            // txtLocation
            // 
            this.txtLocation.Location = new System.Drawing.Point(93, 218);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(109, 20);
            this.txtLocation.TabIndex = 15;
            // 
            // lblInstructor
            // 
            this.lblInstructor.AutoSize = true;
            this.lblInstructor.Location = new System.Drawing.Point(37, 194);
            this.lblInstructor.Name = "lblInstructor";
            this.lblInstructor.Size = new System.Drawing.Size(54, 13);
            this.lblInstructor.TabIndex = 16;
            this.lblInstructor.Text = "Instruktor:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(93, 191);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(227, 21);
            this.comboBox1.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Informacije o instruktoru: ";
            // 
            // GenerateExamApplication
            // 
            this.AcceptButton = this.btnGenerate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 291);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblInstructor);
            this.Controls.Add(this.txtLocation);
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.cbxExamDay);
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
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.ComboBox cbxExamDay;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.Label lblInstructor;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
    }
}