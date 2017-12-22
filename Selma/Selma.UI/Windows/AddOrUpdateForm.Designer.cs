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
            this.containerCandidateInfo = new System.Windows.Forms.SplitContainer();
            this.btnPrintExam = new System.Windows.Forms.Button();
            this.lblCandidateInfo = new System.Windows.Forms.Label();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblNotes = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtJmbg = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblJmbg = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtOccupancy = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblOccupancy = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblParentName = new System.Windows.Forms.Label();
            this.lblDrivingLicenceInfo = new System.Windows.Forms.Label();
            this.txtNameOfParent = new System.Windows.Forms.TextBox();
            this.lblPostalCode = new System.Windows.Forms.Label();
            this.txtCategory = new System.Windows.Forms.TextBox();
            this.txtPostalCode = new System.Windows.Forms.TextBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.txtDrivingLicenceId = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.lblDrivingLicenceId = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.dtpExpiresOn = new System.Windows.Forms.DateTimePicker();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.dtpIssueOn = new System.Windows.Forms.DateTimePicker();
            this.lblCitizenship = new System.Windows.Forms.Label();
            this.lblExpiresOn = new System.Windows.Forms.Label();
            this.txtCitizenship = new System.Windows.Forms.TextBox();
            this.lblissuedOn = new System.Windows.Forms.Label();
            this.dgvExamHistory = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.clmCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTakenOn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmIncludesTrafficRegulation = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.clmIncludesFirstAid = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.clmIncludesDriving = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.clmPrint = new System.Windows.Forms.DataGridViewButtonColumn();
            this.clmDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.containerMain)).BeginInit();
            this.containerMain.Panel1.SuspendLayout();
            this.containerMain.Panel2.SuspendLayout();
            this.containerMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.containerCandidateInfo)).BeginInit();
            this.containerCandidateInfo.Panel1.SuspendLayout();
            this.containerCandidateInfo.Panel2.SuspendLayout();
            this.containerCandidateInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExamHistory)).BeginInit();
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
            this.containerMain.Panel1.Controls.Add(this.containerCandidateInfo);
            // 
            // containerMain.Panel2
            // 
            this.containerMain.Panel2.Controls.Add(this.btnAdd);
            this.containerMain.Panel2.Controls.Add(this.btnEdit);
            this.containerMain.Panel2.Controls.Add(this.btnDelete);
            this.containerMain.Size = new System.Drawing.Size(888, 469);
            this.containerMain.SplitterDistance = 420;
            this.containerMain.TabIndex = 0;
            // 
            // containerCandidateInfo
            // 
            this.containerCandidateInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.containerCandidateInfo.Location = new System.Drawing.Point(0, 0);
            this.containerCandidateInfo.Name = "containerCandidateInfo";
            // 
            // containerCandidateInfo.Panel1
            // 
            this.containerCandidateInfo.Panel1.Controls.Add(this.btnPrintExam);
            this.containerCandidateInfo.Panel1.Controls.Add(this.lblCandidateInfo);
            this.containerCandidateInfo.Panel1.Controls.Add(this.txtNotes);
            this.containerCandidateInfo.Panel1.Controls.Add(this.lblFirstName);
            this.containerCandidateInfo.Panel1.Controls.Add(this.lblNotes);
            this.containerCandidateInfo.Panel1.Controls.Add(this.txtFirstName);
            this.containerCandidateInfo.Panel1.Controls.Add(this.txtJmbg);
            this.containerCandidateInfo.Panel1.Controls.Add(this.lblLastName);
            this.containerCandidateInfo.Panel1.Controls.Add(this.lblJmbg);
            this.containerCandidateInfo.Panel1.Controls.Add(this.txtLastName);
            this.containerCandidateInfo.Panel1.Controls.Add(this.txtOccupancy);
            this.containerCandidateInfo.Panel1.Controls.Add(this.lblAddress);
            this.containerCandidateInfo.Panel1.Controls.Add(this.lblOccupancy);
            this.containerCandidateInfo.Panel1.Controls.Add(this.txtAddress);
            this.containerCandidateInfo.Panel1.Controls.Add(this.lblParentName);
            this.containerCandidateInfo.Panel1.Controls.Add(this.lblDrivingLicenceInfo);
            this.containerCandidateInfo.Panel1.Controls.Add(this.txtNameOfParent);
            this.containerCandidateInfo.Panel1.Controls.Add(this.lblPostalCode);
            this.containerCandidateInfo.Panel1.Controls.Add(this.txtCategory);
            this.containerCandidateInfo.Panel1.Controls.Add(this.txtPostalCode);
            this.containerCandidateInfo.Panel1.Controls.Add(this.lblCategory);
            this.containerCandidateInfo.Panel1.Controls.Add(this.lblCity);
            this.containerCandidateInfo.Panel1.Controls.Add(this.txtDrivingLicenceId);
            this.containerCandidateInfo.Panel1.Controls.Add(this.txtCity);
            this.containerCandidateInfo.Panel1.Controls.Add(this.lblDrivingLicenceId);
            this.containerCandidateInfo.Panel1.Controls.Add(this.lblPhone);
            this.containerCandidateInfo.Panel1.Controls.Add(this.dtpExpiresOn);
            this.containerCandidateInfo.Panel1.Controls.Add(this.txtPhone);
            this.containerCandidateInfo.Panel1.Controls.Add(this.dtpIssueOn);
            this.containerCandidateInfo.Panel1.Controls.Add(this.lblCitizenship);
            this.containerCandidateInfo.Panel1.Controls.Add(this.lblExpiresOn);
            this.containerCandidateInfo.Panel1.Controls.Add(this.txtCitizenship);
            this.containerCandidateInfo.Panel1.Controls.Add(this.lblissuedOn);
            // 
            // containerCandidateInfo.Panel2
            // 
            this.containerCandidateInfo.Panel2.Controls.Add(this.dgvExamHistory);
            this.containerCandidateInfo.Size = new System.Drawing.Size(888, 420);
            this.containerCandidateInfo.SplitterDistance = 419;
            this.containerCandidateInfo.TabIndex = 37;
            // 
            // btnPrintExam
            // 
            this.btnPrintExam.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnPrintExam.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPrintExam.Location = new System.Drawing.Point(12, 378);
            this.btnPrintExam.Name = "btnPrintExam";
            this.btnPrintExam.Size = new System.Drawing.Size(165, 32);
            this.btnPrintExam.TabIndex = 30;
            this.btnPrintExam.Text = "Kreiraj prijavu";
            this.btnPrintExam.UseVisualStyleBackColor = false;
            this.btnPrintExam.Click += new System.EventHandler(this.BtnPrintExam_Click);
            // 
            // lblCandidateInfo
            // 
            this.lblCandidateInfo.AutoSize = true;
            this.lblCandidateInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCandidateInfo.Location = new System.Drawing.Point(16, 14);
            this.lblCandidateInfo.Name = "lblCandidateInfo";
            this.lblCandidateInfo.Size = new System.Drawing.Size(178, 13);
            this.lblCandidateInfo.TabIndex = 28;
            this.lblCandidateInfo.Text = "INFORMACIJE O KANDIDATU";
            // 
            // txtNotes
            // 
            this.txtNotes.Location = new System.Drawing.Point(16, 341);
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(388, 20);
            this.txtNotes.TabIndex = 36;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(13, 37);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(24, 13);
            this.lblFirstName.TabIndex = 0;
            this.lblFirstName.Text = "Ime";
            // 
            // lblNotes
            // 
            this.lblNotes.AutoSize = true;
            this.lblNotes.Location = new System.Drawing.Point(13, 325);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(317, 13);
            this.lblNotes.TabIndex = 35;
            this.lblNotes.Text = "Izrecena mjera zabrane izdavanja, oduzimanja dozvole (ko i kada)";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(16, 53);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(100, 20);
            this.txtFirstName.TabIndex = 1;
            // 
            // txtJmbg
            // 
            this.txtJmbg.Location = new System.Drawing.Point(16, 170);
            this.txtJmbg.Name = "txtJmbg";
            this.txtJmbg.Size = new System.Drawing.Size(100, 20);
            this.txtJmbg.TabIndex = 34;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(119, 37);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(44, 13);
            this.lblLastName.TabIndex = 2;
            this.lblLastName.Text = "Prezime";
            // 
            // lblJmbg
            // 
            this.lblJmbg.AutoSize = true;
            this.lblJmbg.Location = new System.Drawing.Point(16, 154);
            this.lblJmbg.Name = "lblJmbg";
            this.lblJmbg.Size = new System.Drawing.Size(36, 13);
            this.lblJmbg.TabIndex = 33;
            this.lblJmbg.Text = "JMBG";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(122, 53);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(173, 20);
            this.txtLastName.TabIndex = 3;
            // 
            // txtOccupancy
            // 
            this.txtOccupancy.Location = new System.Drawing.Point(304, 170);
            this.txtOccupancy.Name = "txtOccupancy";
            this.txtOccupancy.Size = new System.Drawing.Size(100, 20);
            this.txtOccupancy.TabIndex = 32;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(13, 76);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(95, 13);
            this.lblAddress.TabIndex = 4;
            this.lblAddress.Text = "Adresa stanovanja";
            // 
            // lblOccupancy
            // 
            this.lblOccupancy.AutoSize = true;
            this.lblOccupancy.Location = new System.Drawing.Point(301, 154);
            this.lblOccupancy.Name = "lblOccupancy";
            this.lblOccupancy.Size = new System.Drawing.Size(56, 13);
            this.lblOccupancy.TabIndex = 31;
            this.lblOccupancy.Text = "Zanimanje";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(16, 92);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(279, 20);
            this.txtAddress.TabIndex = 5;
            // 
            // lblParentName
            // 
            this.lblParentName.AutoSize = true;
            this.lblParentName.Location = new System.Drawing.Point(301, 37);
            this.lblParentName.Name = "lblParentName";
            this.lblParentName.Size = new System.Drawing.Size(63, 13);
            this.lblParentName.TabIndex = 6;
            this.lblParentName.Text = "Ime roditelja";
            // 
            // lblDrivingLicenceInfo
            // 
            this.lblDrivingLicenceInfo.AutoSize = true;
            this.lblDrivingLicenceInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDrivingLicenceInfo.Location = new System.Drawing.Point(16, 215);
            this.lblDrivingLicenceInfo.Name = "lblDrivingLicenceInfo";
            this.lblDrivingLicenceInfo.Size = new System.Drawing.Size(228, 13);
            this.lblDrivingLicenceInfo.TabIndex = 29;
            this.lblDrivingLicenceInfo.Text = "INFORMACIJE O VOZACKOJ DOZVOLI";
            // 
            // txtNameOfParent
            // 
            this.txtNameOfParent.Location = new System.Drawing.Point(304, 53);
            this.txtNameOfParent.Name = "txtNameOfParent";
            this.txtNameOfParent.Size = new System.Drawing.Size(100, 20);
            this.txtNameOfParent.TabIndex = 7;
            // 
            // lblPostalCode
            // 
            this.lblPostalCode.AutoSize = true;
            this.lblPostalCode.Location = new System.Drawing.Point(13, 115);
            this.lblPostalCode.Name = "lblPostalCode";
            this.lblPostalCode.Size = new System.Drawing.Size(73, 13);
            this.lblPostalCode.TabIndex = 10;
            this.lblPostalCode.Text = "Postanski broj";
            // 
            // txtCategory
            // 
            this.txtCategory.Location = new System.Drawing.Point(161, 258);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Size = new System.Drawing.Size(104, 20);
            this.txtCategory.TabIndex = 27;
            // 
            // txtPostalCode
            // 
            this.txtPostalCode.Location = new System.Drawing.Point(16, 131);
            this.txtPostalCode.Name = "txtPostalCode";
            this.txtPostalCode.Size = new System.Drawing.Size(100, 20);
            this.txtPostalCode.TabIndex = 11;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(158, 242);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(54, 13);
            this.lblCategory.TabIndex = 26;
            this.lblCategory.Text = "Kategorije";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(119, 115);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(30, 13);
            this.lblCity.TabIndex = 12;
            this.lblCity.Text = "Grad";
            // 
            // txtDrivingLicenceId
            // 
            this.txtDrivingLicenceId.Location = new System.Drawing.Point(16, 258);
            this.txtDrivingLicenceId.Name = "txtDrivingLicenceId";
            this.txtDrivingLicenceId.Size = new System.Drawing.Size(100, 20);
            this.txtDrivingLicenceId.TabIndex = 25;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(122, 131);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(173, 20);
            this.txtCity.TabIndex = 13;
            // 
            // lblDrivingLicenceId
            // 
            this.lblDrivingLicenceId.AutoSize = true;
            this.lblDrivingLicenceId.Location = new System.Drawing.Point(13, 242);
            this.lblDrivingLicenceId.Name = "lblDrivingLicenceId";
            this.lblDrivingLicenceId.Size = new System.Drawing.Size(109, 13);
            this.lblDrivingLicenceId.TabIndex = 24;
            this.lblDrivingLicenceId.Text = "Broj vozacke dozvole";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(301, 76);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(43, 13);
            this.lblPhone.TabIndex = 14;
            this.lblPhone.Text = "Telefon";
            // 
            // dtpExpiresOn
            // 
            this.dtpExpiresOn.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpExpiresOn.Location = new System.Drawing.Point(161, 297);
            this.dtpExpiresOn.Name = "dtpExpiresOn";
            this.dtpExpiresOn.Size = new System.Drawing.Size(104, 20);
            this.dtpExpiresOn.TabIndex = 23;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(304, 92);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(100, 20);
            this.txtPhone.TabIndex = 15;
            // 
            // dtpIssueOn
            // 
            this.dtpIssueOn.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpIssueOn.Location = new System.Drawing.Point(16, 297);
            this.dtpIssueOn.Name = "dtpIssueOn";
            this.dtpIssueOn.Size = new System.Drawing.Size(100, 20);
            this.dtpIssueOn.TabIndex = 22;
            // 
            // lblCitizenship
            // 
            this.lblCitizenship.AutoSize = true;
            this.lblCitizenship.Location = new System.Drawing.Point(301, 115);
            this.lblCitizenship.Name = "lblCitizenship";
            this.lblCitizenship.Size = new System.Drawing.Size(71, 13);
            this.lblCitizenship.TabIndex = 18;
            this.lblCitizenship.Text = "Drzavljanstvo";
            // 
            // lblExpiresOn
            // 
            this.lblExpiresOn.AutoSize = true;
            this.lblExpiresOn.Location = new System.Drawing.Point(158, 281);
            this.lblExpiresOn.Name = "lblExpiresOn";
            this.lblExpiresOn.Size = new System.Drawing.Size(62, 13);
            this.lblExpiresOn.TabIndex = 21;
            this.lblExpiresOn.Text = "Istice dana:";
            // 
            // txtCitizenship
            // 
            this.txtCitizenship.Location = new System.Drawing.Point(304, 131);
            this.txtCitizenship.Name = "txtCitizenship";
            this.txtCitizenship.Size = new System.Drawing.Size(100, 20);
            this.txtCitizenship.TabIndex = 19;
            // 
            // lblissuedOn
            // 
            this.lblissuedOn.AutoSize = true;
            this.lblissuedOn.Location = new System.Drawing.Point(13, 281);
            this.lblissuedOn.Name = "lblissuedOn";
            this.lblissuedOn.Size = new System.Drawing.Size(66, 13);
            this.lblissuedOn.TabIndex = 20;
            this.lblissuedOn.Text = "Izdata dana:";
            // 
            // dgvExamHistory
            // 
            this.dgvExamHistory.AllowUserToAddRows = false;
            this.dgvExamHistory.AllowUserToDeleteRows = false;
            this.dgvExamHistory.AllowUserToResizeRows = false;
            this.dgvExamHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvExamHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExamHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmCategory,
            this.clmTakenOn,
            this.clmIncludesTrafficRegulation,
            this.clmIncludesFirstAid,
            this.clmIncludesDriving,
            this.clmPrint,
            this.clmDelete});
            this.dgvExamHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvExamHistory.Location = new System.Drawing.Point(0, 0);
            this.dgvExamHistory.MultiSelect = false;
            this.dgvExamHistory.Name = "dgvExamHistory";
            this.dgvExamHistory.ReadOnly = true;
            this.dgvExamHistory.RowHeadersVisible = false;
            this.dgvExamHistory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvExamHistory.Size = new System.Drawing.Size(465, 420);
            this.dgvExamHistory.TabIndex = 0;
            this.dgvExamHistory.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvExamHistory_CellContentClick);
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
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.LimeGreen;
            this.btnEdit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnEdit.Location = new System.Drawing.Point(720, 0);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(5);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(84, 45);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "Izmijeni";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnDelete.Location = new System.Drawing.Point(804, 0);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(84, 45);
            this.btnDelete.TabIndex = 0;
            this.btnDelete.Text = "Obrisi";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // clmCategory
            // 
            this.clmCategory.HeaderText = "Kategorija";
            this.clmCategory.Name = "clmCategory";
            this.clmCategory.ReadOnly = true;
            // 
            // clmTakenOn
            // 
            this.clmTakenOn.HeaderText = "Polagano dana";
            this.clmTakenOn.Name = "clmTakenOn";
            this.clmTakenOn.ReadOnly = true;
            // 
            // clmIncludesTrafficRegulation
            // 
            this.clmIncludesTrafficRegulation.HeaderText = "Poznavanje pravila saobracaja";
            this.clmIncludesTrafficRegulation.Name = "clmIncludesTrafficRegulation";
            this.clmIncludesTrafficRegulation.ReadOnly = true;
            // 
            // clmIncludesFirstAid
            // 
            this.clmIncludesFirstAid.HeaderText = "Prva pomoc";
            this.clmIncludesFirstAid.Name = "clmIncludesFirstAid";
            this.clmIncludesFirstAid.ReadOnly = true;
            // 
            // clmIncludesDriving
            // 
            this.clmIncludesDriving.HeaderText = "Upravljanje vozilom";
            this.clmIncludesDriving.Name = "clmIncludesDriving";
            this.clmIncludesDriving.ReadOnly = true;
            // 
            // clmPrint
            // 
            this.clmPrint.HeaderText = "Print";
            this.clmPrint.Name = "clmPrint";
            this.clmPrint.ReadOnly = true;
            this.clmPrint.Text = "Print";
            // 
            // clmDelete
            // 
            this.clmDelete.HeaderText = "Obrisi";
            this.clmDelete.Name = "clmDelete";
            this.clmDelete.ReadOnly = true;
            this.clmDelete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clmDelete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // AddOrUpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 469);
            this.Controls.Add(this.containerMain);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddOrUpdateForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddOrUpdateForm";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddOrUpdateForm_FormClosing);
            this.Load += new System.EventHandler(this.AddOrUpdateForm_Load);
            this.containerMain.Panel1.ResumeLayout(false);
            this.containerMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.containerMain)).EndInit();
            this.containerMain.ResumeLayout(false);
            this.containerCandidateInfo.Panel1.ResumeLayout(false);
            this.containerCandidateInfo.Panel1.PerformLayout();
            this.containerCandidateInfo.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.containerCandidateInfo)).EndInit();
            this.containerCandidateInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvExamHistory)).EndInit();
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
        private System.Windows.Forms.Button btnPrintExam;
        private System.Windows.Forms.TextBox txtOccupancy;
        private System.Windows.Forms.Label lblOccupancy;
        private System.Windows.Forms.TextBox txtJmbg;
        private System.Windows.Forms.Label lblJmbg;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.SplitContainer containerCandidateInfo;
        private System.Windows.Forms.DataGridView dgvExamHistory;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTakenOn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clmIncludesTrafficRegulation;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clmIncludesFirstAid;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clmIncludesDriving;
        private System.Windows.Forms.DataGridViewButtonColumn clmPrint;
        private System.Windows.Forms.DataGridViewButtonColumn clmDelete;
    }
}