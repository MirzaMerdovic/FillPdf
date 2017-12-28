namespace Selma.UI
{
    partial class FrmMain
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Kandidati");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.containerMain = new System.Windows.Forms.SplitContainer();
            this.containerCandidates = new System.Windows.Forms.SplitContainer();
            this.btnAddCandidate = new System.Windows.Forms.Button();
            this.treeViewCandidates = new System.Windows.Forms.TreeView();
            this.dgvCandidates = new System.Windows.Forms.DataGridView();
            this.clmFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStripMain = new System.Windows.Forms.ToolStrip();
            this.toolBtnInstructors = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolBtnSettings = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.containerMain)).BeginInit();
            this.containerMain.Panel1.SuspendLayout();
            this.containerMain.Panel2.SuspendLayout();
            this.containerMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.containerCandidates)).BeginInit();
            this.containerCandidates.Panel1.SuspendLayout();
            this.containerCandidates.Panel2.SuspendLayout();
            this.containerCandidates.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCandidates)).BeginInit();
            this.toolStripMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // containerMain
            // 
            this.containerMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.containerMain.Location = new System.Drawing.Point(0, 28);
            this.containerMain.Name = "containerMain";
            // 
            // containerMain.Panel1
            // 
            this.containerMain.Panel1.Controls.Add(this.containerCandidates);
            // 
            // containerMain.Panel2
            // 
            this.containerMain.Panel2.Controls.Add(this.dgvCandidates);
            this.containerMain.Size = new System.Drawing.Size(1022, 746);
            this.containerMain.SplitterDistance = 283;
            this.containerMain.TabIndex = 0;
            // 
            // containerCandidates
            // 
            this.containerCandidates.Dock = System.Windows.Forms.DockStyle.Fill;
            this.containerCandidates.Location = new System.Drawing.Point(0, 0);
            this.containerCandidates.Name = "containerCandidates";
            this.containerCandidates.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // containerCandidates.Panel1
            // 
            this.containerCandidates.Panel1.Controls.Add(this.btnAddCandidate);
            // 
            // containerCandidates.Panel2
            // 
            this.containerCandidates.Panel2.Controls.Add(this.treeViewCandidates);
            this.containerCandidates.Size = new System.Drawing.Size(283, 746);
            this.containerCandidates.SplitterDistance = 44;
            this.containerCandidates.TabIndex = 0;
            // 
            // btnAddCandidate
            // 
            this.btnAddCandidate.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnAddCandidate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddCandidate.Location = new System.Drawing.Point(0, 0);
            this.btnAddCandidate.Margin = new System.Windows.Forms.Padding(5);
            this.btnAddCandidate.Name = "btnAddCandidate";
            this.btnAddCandidate.Size = new System.Drawing.Size(283, 44);
            this.btnAddCandidate.TabIndex = 0;
            this.btnAddCandidate.Text = "Dodaj kandidata";
            this.btnAddCandidate.UseVisualStyleBackColor = false;
            this.btnAddCandidate.Click += new System.EventHandler(this.BtnAddCandidate_Click);
            // 
            // treeViewCandidates
            // 
            this.treeViewCandidates.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeViewCandidates.Location = new System.Drawing.Point(0, 0);
            this.treeViewCandidates.Name = "treeViewCandidates";
            treeNode1.Name = "nodeCandidates";
            treeNode1.Text = "Kandidati";
            this.treeViewCandidates.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1});
            this.treeViewCandidates.Size = new System.Drawing.Size(283, 698);
            this.treeViewCandidates.TabIndex = 0;
            this.treeViewCandidates.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.TreeViewCandidates_NodeMouseClick);
            // 
            // dgvCandidates
            // 
            this.dgvCandidates.AllowUserToAddRows = false;
            this.dgvCandidates.AllowUserToDeleteRows = false;
            this.dgvCandidates.AllowUserToResizeRows = false;
            this.dgvCandidates.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCandidates.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmFirstName,
            this.clmLastName});
            this.dgvCandidates.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCandidates.Location = new System.Drawing.Point(0, 0);
            this.dgvCandidates.MultiSelect = false;
            this.dgvCandidates.Name = "dgvCandidates";
            this.dgvCandidates.ReadOnly = true;
            this.dgvCandidates.RowHeadersVisible = false;
            this.dgvCandidates.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCandidates.Size = new System.Drawing.Size(735, 746);
            this.dgvCandidates.TabIndex = 0;
            this.dgvCandidates.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvCandidates_CellDoubleClick);
            // 
            // clmFirstName
            // 
            this.clmFirstName.HeaderText = "Ime";
            this.clmFirstName.Name = "clmFirstName";
            this.clmFirstName.ReadOnly = true;
            // 
            // clmLastName
            // 
            this.clmLastName.HeaderText = "Prezime";
            this.clmLastName.Name = "clmLastName";
            this.clmLastName.ReadOnly = true;
            // 
            // toolStripMain
            // 
            this.toolStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolBtnInstructors,
            this.toolStripSeparator1,
            this.toolBtnSettings});
            this.toolStripMain.Location = new System.Drawing.Point(0, 0);
            this.toolStripMain.Name = "toolStripMain";
            this.toolStripMain.Size = new System.Drawing.Size(1022, 25);
            this.toolStripMain.TabIndex = 1;
            this.toolStripMain.Text = "toolStrip1";
            // 
            // toolBtnInstructors
            // 
            this.toolBtnInstructors.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolBtnInstructors.Image = ((System.Drawing.Image)(resources.GetObject("toolBtnInstructors.Image")));
            this.toolBtnInstructors.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnInstructors.Name = "toolBtnInstructors";
            this.toolBtnInstructors.Size = new System.Drawing.Size(65, 22);
            this.toolBtnInstructors.Text = "Instruktori";
            this.toolBtnInstructors.ToolTipText = "Dodavanje, brisanje i izmjena informacija o instruktoriima.";
            this.toolBtnInstructors.Click += new System.EventHandler(this.ToolBtnInstructors_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolBtnSettings
            // 
            this.toolBtnSettings.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolBtnSettings.Image = ((System.Drawing.Image)(resources.GetObject("toolBtnSettings.Image")));
            this.toolBtnSettings.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnSettings.Name = "toolBtnSettings";
            this.toolBtnSettings.Size = new System.Drawing.Size(58, 22);
            this.toolBtnSettings.Text = "Postavke";
            this.toolBtnSettings.ToolTipText = "Informacije vezane za konfigurisanje aplikacije";
            this.toolBtnSettings.Click += new System.EventHandler(this.ToolBtnSettings_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 774);
            this.Controls.Add(this.toolStripMain);
            this.Controls.Add(this.containerMain);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Auto Skola - Selma";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.containerMain.Panel1.ResumeLayout(false);
            this.containerMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.containerMain)).EndInit();
            this.containerMain.ResumeLayout(false);
            this.containerCandidates.Panel1.ResumeLayout(false);
            this.containerCandidates.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.containerCandidates)).EndInit();
            this.containerCandidates.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCandidates)).EndInit();
            this.toolStripMain.ResumeLayout(false);
            this.toolStripMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer containerMain;
        private System.Windows.Forms.TreeView treeViewCandidates;
        private System.Windows.Forms.DataGridView dgvCandidates;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmLastName;
        private System.Windows.Forms.SplitContainer containerCandidates;
        private System.Windows.Forms.Button btnAddCandidate;
        private System.Windows.Forms.ToolStrip toolStripMain;
        private System.Windows.Forms.ToolStripButton toolBtnInstructors;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolBtnSettings;
    }
}

