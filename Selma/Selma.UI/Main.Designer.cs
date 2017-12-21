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
            this.containerMain = new System.Windows.Forms.SplitContainer();
            this.treeViewCandidates = new System.Windows.Forms.TreeView();
            this.dgvCandidates = new System.Windows.Forms.DataGridView();
            this.clmFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.containerCandidates = new System.Windows.Forms.SplitContainer();
            this.btnAddCandidate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.containerMain)).BeginInit();
            this.containerMain.Panel1.SuspendLayout();
            this.containerMain.Panel2.SuspendLayout();
            this.containerMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCandidates)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.containerCandidates)).BeginInit();
            this.containerCandidates.Panel1.SuspendLayout();
            this.containerCandidates.Panel2.SuspendLayout();
            this.containerCandidates.SuspendLayout();
            this.SuspendLayout();
            // 
            // containerMain
            // 
            this.containerMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.containerMain.Location = new System.Drawing.Point(0, 0);
            this.containerMain.Name = "containerMain";
            // 
            // containerMain.Panel1
            // 
            this.containerMain.Panel1.Controls.Add(this.containerCandidates);
            // 
            // containerMain.Panel2
            // 
            this.containerMain.Panel2.Controls.Add(this.dgvCandidates);
            this.containerMain.Size = new System.Drawing.Size(1022, 774);
            this.containerMain.SplitterDistance = 283;
            this.containerMain.TabIndex = 0;
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
            this.treeViewCandidates.Size = new System.Drawing.Size(283, 724);
            this.treeViewCandidates.TabIndex = 0;
            this.treeViewCandidates.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.TreeViewCandidates_NodeMouseClick);
            // 
            // dgvCandidates
            // 
            this.dgvCandidates.AllowUserToAddRows = false;
            this.dgvCandidates.AllowUserToDeleteRows = false;
            this.dgvCandidates.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCandidates.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmFirstName,
            this.clmLastName});
            this.dgvCandidates.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCandidates.Location = new System.Drawing.Point(0, 0);
            this.dgvCandidates.Name = "dgvCandidates";
            this.dgvCandidates.ReadOnly = true;
            this.dgvCandidates.RowHeadersVisible = false;
            this.dgvCandidates.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCandidates.Size = new System.Drawing.Size(735, 774);
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
            this.containerCandidates.Size = new System.Drawing.Size(283, 774);
            this.containerCandidates.SplitterDistance = 46;
            this.containerCandidates.TabIndex = 0;
            // 
            // btnAddCandidate
            // 
            this.btnAddCandidate.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnAddCandidate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddCandidate.Location = new System.Drawing.Point(0, 0);
            this.btnAddCandidate.Margin = new System.Windows.Forms.Padding(5);
            this.btnAddCandidate.Name = "btnAddCandidate";
            this.btnAddCandidate.Size = new System.Drawing.Size(283, 46);
            this.btnAddCandidate.TabIndex = 0;
            this.btnAddCandidate.Text = "Dodaj kandidata";
            this.btnAddCandidate.UseVisualStyleBackColor = false;
            this.btnAddCandidate.Click += new System.EventHandler(this.BtnAddCandidate_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 774);
            this.Controls.Add(this.containerMain);
            this.Name = "FrmMain";
            this.Text = "Auto Skola - Selma";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.containerMain.Panel1.ResumeLayout(false);
            this.containerMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.containerMain)).EndInit();
            this.containerMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCandidates)).EndInit();
            this.containerCandidates.Panel1.ResumeLayout(false);
            this.containerCandidates.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.containerCandidates)).EndInit();
            this.containerCandidates.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer containerMain;
        private System.Windows.Forms.TreeView treeViewCandidates;
        private System.Windows.Forms.DataGridView dgvCandidates;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmLastName;
        private System.Windows.Forms.SplitContainer containerCandidates;
        private System.Windows.Forms.Button btnAddCandidate;
    }
}

