namespace Selma.UI.Windows
{
    partial class AddOrUpdateForm
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
            this.containerMain = new System.Windows.Forms.SplitContainer();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtNameOfParent = new System.Windows.Forms.TextBox();
            this.lblParentName = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.lblCity = new System.Windows.Forms.Label();
            this.txtPostalCode = new System.Windows.Forms.TextBox();
            this.lblPostalCode = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtCitizenship = new System.Windows.Forms.TextBox();
            this.lblCitizenship = new System.Windows.Forms.Label();
            this.lblExpiresOn = new System.Windows.Forms.Label();
            this.lblissuedOn = new System.Windows.Forms.Label();
            this.dtpIssueOn = new System.Windows.Forms.DateTimePicker();
            this.dtpExpiresOn = new System.Windows.Forms.DateTimePicker();
            this.lblDrivingLicenceId = new System.Windows.Forms.Label();
            this.txtDrivingLicenceId = new System.Windows.Forms.TextBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.txtCategory = new System.Windows.Forms.TextBox();
            this.lblCandidateInfo = new System.Windows.Forms.Label();
            this.lblDrivingLicenceInfo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.containerMain)).BeginInit();
            this.containerMain.Panel1.SuspendLayout();
            this.containerMain.Panel2.SuspendLayout();
            this.containerMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // containerMain
            // 
            this.containerMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.containerMain.Location = new System.Drawing.Point(0, 0);
            this.containerMain.Name = "containerMain";
            this.containerMain.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // containerMain.Panel1
            // 
            this.containerMain.Panel1.Controls.Add(this.lblDrivingLicenceInfo);
            this.containerMain.Panel1.Controls.Add(this.lblCandidateInfo);
            this.containerMain.Panel1.Controls.Add(this.txtCategory);
            this.containerMain.Panel1.Controls.Add(this.lblCategory);
            this.containerMain.Panel1.Controls.Add(this.txtDrivingLicenceId);
            this.containerMain.Panel1.Controls.Add(this.lblDrivingLicenceId);
            this.containerMain.Panel1.Controls.Add(this.dtpExpiresOn);
            this.containerMain.Panel1.Controls.Add(this.dtpIssueOn);
            this.containerMain.Panel1.Controls.Add(this.lblExpiresOn);
            this.containerMain.Panel1.Controls.Add(this.lblissuedOn);
            this.containerMain.Panel1.Controls.Add(this.txtCitizenship);
            this.containerMain.Panel1.Controls.Add(this.lblCitizenship);
            this.containerMain.Panel1.Controls.Add(this.txtPhone);
            this.containerMain.Panel1.Controls.Add(this.lblPhone);
            this.containerMain.Panel1.Controls.Add(this.txtCity);
            this.containerMain.Panel1.Controls.Add(this.lblCity);
            this.containerMain.Panel1.Controls.Add(this.txtPostalCode);
            this.containerMain.Panel1.Controls.Add(this.lblPostalCode);
            this.containerMain.Panel1.Controls.Add(this.txtNameOfParent);
            this.containerMain.Panel1.Controls.Add(this.lblParentName);
            this.containerMain.Panel1.Controls.Add(this.txtAddress);
            this.containerMain.Panel1.Controls.Add(this.lblAddress);
            this.containerMain.Panel1.Controls.Add(this.txtLastName);
            this.containerMain.Panel1.Controls.Add(this.lblLastName);
            this.containerMain.Panel1.Controls.Add(this.txtFirstName);
            this.containerMain.Panel1.Controls.Add(this.lblFirstName);
            // 
            // containerMain.Panel2
            // 
            this.containerMain.Panel2.Controls.Add(this.btnAdd);
            this.containerMain.Panel2.Controls.Add(this.btnEdit);
            this.containerMain.Panel2.Controls.Add(this.btnDelete);
            this.containerMain.Size = new System.Drawing.Size(432, 476);
            this.containerMain.SplitterDistance = 427;
            this.containerMain.TabIndex = 0;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnDelete.Location = new System.Drawing.Point(348, 0);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(84, 45);
            this.btnDelete.TabIndex = 0;
            this.btnDelete.Text = "Obrisi";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.LimeGreen;
            this.btnEdit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnEdit.Location = new System.Drawing.Point(264, 0);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(5);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(84, 45);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "Izmijeni";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.LimeGreen;
            this.btnAdd.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAdd.Location = new System.Drawing.Point(0, 0);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(84, 45);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Spremi";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(26, 52);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(24, 13);
            this.lblFirstName.TabIndex = 0;
            this.lblFirstName.Text = "Ime";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(29, 68);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(100, 20);
            this.txtFirstName.TabIndex = 1;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(135, 68);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(173, 20);
            this.txtLastName.TabIndex = 3;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(132, 52);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(44, 13);
            this.lblLastName.TabIndex = 2;
            this.lblLastName.Text = "Prezime";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(29, 107);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(279, 20);
            this.txtAddress.TabIndex = 5;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(26, 91);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(95, 13);
            this.lblAddress.TabIndex = 4;
            this.lblAddress.Text = "Adresa stanovanja";
            // 
            // txtNameOfParent
            // 
            this.txtNameOfParent.Location = new System.Drawing.Point(317, 68);
            this.txtNameOfParent.Name = "txtNameOfParent";
            this.txtNameOfParent.Size = new System.Drawing.Size(100, 20);
            this.txtNameOfParent.TabIndex = 7;
            // 
            // lblParentName
            // 
            this.lblParentName.AutoSize = true;
            this.lblParentName.Location = new System.Drawing.Point(314, 52);
            this.lblParentName.Name = "lblParentName";
            this.lblParentName.Size = new System.Drawing.Size(63, 13);
            this.lblParentName.TabIndex = 6;
            this.lblParentName.Text = "Ime roditelja";
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(135, 146);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(173, 20);
            this.txtCity.TabIndex = 13;
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(132, 130);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(30, 13);
            this.lblCity.TabIndex = 12;
            this.lblCity.Text = "Grad";
            // 
            // txtPostalCode
            // 
            this.txtPostalCode.Location = new System.Drawing.Point(29, 146);
            this.txtPostalCode.Name = "txtPostalCode";
            this.txtPostalCode.Size = new System.Drawing.Size(100, 20);
            this.txtPostalCode.TabIndex = 11;
            // 
            // lblPostalCode
            // 
            this.lblPostalCode.AutoSize = true;
            this.lblPostalCode.Location = new System.Drawing.Point(26, 130);
            this.lblPostalCode.Name = "lblPostalCode";
            this.lblPostalCode.Size = new System.Drawing.Size(73, 13);
            this.lblPostalCode.TabIndex = 10;
            this.lblPostalCode.Text = "Postanski broj";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(317, 107);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(100, 20);
            this.txtPhone.TabIndex = 15;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(314, 91);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(43, 13);
            this.lblPhone.TabIndex = 14;
            this.lblPhone.Text = "Telefon";
            // 
            // txtCitizenship
            // 
            this.txtCitizenship.Location = new System.Drawing.Point(317, 146);
            this.txtCitizenship.Name = "txtCitizenship";
            this.txtCitizenship.Size = new System.Drawing.Size(100, 20);
            this.txtCitizenship.TabIndex = 19;
            // 
            // lblCitizenship
            // 
            this.lblCitizenship.AutoSize = true;
            this.lblCitizenship.Location = new System.Drawing.Point(314, 130);
            this.lblCitizenship.Name = "lblCitizenship";
            this.lblCitizenship.Size = new System.Drawing.Size(71, 13);
            this.lblCitizenship.TabIndex = 18;
            this.lblCitizenship.Text = "Drzavljanstvo";
            // 
            // lblExpiresOn
            // 
            this.lblExpiresOn.AutoSize = true;
            this.lblExpiresOn.Location = new System.Drawing.Point(171, 276);
            this.lblExpiresOn.Name = "lblExpiresOn";
            this.lblExpiresOn.Size = new System.Drawing.Size(62, 13);
            this.lblExpiresOn.TabIndex = 21;
            this.lblExpiresOn.Text = "Istice dana:";
            // 
            // lblissuedOn
            // 
            this.lblissuedOn.AutoSize = true;
            this.lblissuedOn.Location = new System.Drawing.Point(26, 276);
            this.lblissuedOn.Name = "lblissuedOn";
            this.lblissuedOn.Size = new System.Drawing.Size(66, 13);
            this.lblissuedOn.TabIndex = 20;
            this.lblissuedOn.Text = "Izdata dana:";
            // 
            // dtpIssueOn
            // 
            this.dtpIssueOn.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpIssueOn.Location = new System.Drawing.Point(29, 292);
            this.dtpIssueOn.Name = "dtpIssueOn";
            this.dtpIssueOn.Size = new System.Drawing.Size(100, 20);
            this.dtpIssueOn.TabIndex = 22;
            // 
            // dtpExpiresOn
            // 
            this.dtpExpiresOn.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpExpiresOn.Location = new System.Drawing.Point(174, 292);
            this.dtpExpiresOn.Name = "dtpExpiresOn";
            this.dtpExpiresOn.Size = new System.Drawing.Size(104, 20);
            this.dtpExpiresOn.TabIndex = 23;
            // 
            // lblDrivingLicenceId
            // 
            this.lblDrivingLicenceId.AutoSize = true;
            this.lblDrivingLicenceId.Location = new System.Drawing.Point(26, 237);
            this.lblDrivingLicenceId.Name = "lblDrivingLicenceId";
            this.lblDrivingLicenceId.Size = new System.Drawing.Size(109, 13);
            this.lblDrivingLicenceId.TabIndex = 24;
            this.lblDrivingLicenceId.Text = "Broj vozacke dozvole";
            // 
            // txtDrivingLicenceId
            // 
            this.txtDrivingLicenceId.Location = new System.Drawing.Point(29, 253);
            this.txtDrivingLicenceId.Name = "txtDrivingLicenceId";
            this.txtDrivingLicenceId.Size = new System.Drawing.Size(100, 20);
            this.txtDrivingLicenceId.TabIndex = 25;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(171, 237);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(54, 13);
            this.lblCategory.TabIndex = 26;
            this.lblCategory.Text = "Kategorije";
            // 
            // txtCategory
            // 
            this.txtCategory.Location = new System.Drawing.Point(174, 253);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Size = new System.Drawing.Size(104, 20);
            this.txtCategory.TabIndex = 27;
            // 
            // lblCandidateInfo
            // 
            this.lblCandidateInfo.AutoSize = true;
            this.lblCandidateInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCandidateInfo.Location = new System.Drawing.Point(29, 29);
            this.lblCandidateInfo.Name = "lblCandidateInfo";
            this.lblCandidateInfo.Size = new System.Drawing.Size(178, 13);
            this.lblCandidateInfo.TabIndex = 28;
            this.lblCandidateInfo.Text = "INFORMACIJE O KANDIDATU";
            // 
            // lblDrivingLicenceInfo
            // 
            this.lblDrivingLicenceInfo.AutoSize = true;
            this.lblDrivingLicenceInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDrivingLicenceInfo.Location = new System.Drawing.Point(29, 210);
            this.lblDrivingLicenceInfo.Name = "lblDrivingLicenceInfo";
            this.lblDrivingLicenceInfo.Size = new System.Drawing.Size(228, 13);
            this.lblDrivingLicenceInfo.TabIndex = 29;
            this.lblDrivingLicenceInfo.Text = "INFORMACIJE O VOZACKOJ DOZVOLI";
            // 
            // AddOrUpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 476);
            this.Controls.Add(this.containerMain);
            this.Name = "AddOrUpdateForm";
            this.Text = "AddOrUpdateForm";
            this.Load += new System.EventHandler(this.AddOrUpdateForm_Load);
            this.containerMain.Panel1.ResumeLayout(false);
            this.containerMain.Panel1.PerformLayout();
            this.containerMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.containerMain)).EndInit();
            this.containerMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer containerMain;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtNameOfParent;
        private System.Windows.Forms.Label lblParentName;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.TextBox txtPostalCode;
        private System.Windows.Forms.Label lblPostalCode;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.DateTimePicker dtpExpiresOn;
        private System.Windows.Forms.DateTimePicker dtpIssueOn;
        private System.Windows.Forms.Label lblExpiresOn;
        private System.Windows.Forms.Label lblissuedOn;
        private System.Windows.Forms.TextBox txtCitizenship;
        private System.Windows.Forms.Label lblCitizenship;
        private System.Windows.Forms.Label lblDrivingLicenceId;
        private System.Windows.Forms.TextBox txtCategory;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.TextBox txtDrivingLicenceId;
        private System.Windows.Forms.Label lblDrivingLicenceInfo;
        private System.Windows.Forms.Label lblCandidateInfo;
    }
}