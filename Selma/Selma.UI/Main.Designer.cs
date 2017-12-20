namespace Selma.UI
{
    partial class frmMain
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
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Kandidati");
            this.containerMain = new System.Windows.Forms.SplitContainer();
            this.treeViewCandidates = new System.Windows.Forms.TreeView();
            this.dgvCandidates = new System.Windows.Forms.DataGridView();
            this.clmFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.containerMain)).BeginInit();
            this.containerMain.Panel1.SuspendLayout();
            this.containerMain.Panel2.SuspendLayout();
            this.containerMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCandidates)).BeginInit();
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
            this.containerMain.Panel1.Controls.Add(this.treeViewCandidates);
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
            treeNode2.Name = "nodeCandidates";
            treeNode2.Text = "Kandidati";
            this.treeViewCandidates.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode2});
            this.treeViewCandidates.Size = new System.Drawing.Size(283, 774);
            this.treeViewCandidates.TabIndex = 0;
            this.treeViewCandidates.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeViewCandidates_NodeMouseClick);
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
            this.dgvCandidates.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCandidates_CellDoubleClick);
            this.dgvCandidates.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvCandidates_MouseDoubleClick);
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
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 774);
            this.Controls.Add(this.containerMain);
            this.Name = "frmMain";
            this.Text = "Auto Skola - Selma";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.containerMain.Panel1.ResumeLayout(false);
            this.containerMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.containerMain)).EndInit();
            this.containerMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCandidates)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer containerMain;
        private System.Windows.Forms.TreeView treeViewCandidates;
        private System.Windows.Forms.DataGridView dgvCandidates;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmLastName;
    }
}

