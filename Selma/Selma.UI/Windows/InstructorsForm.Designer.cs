namespace Selma.UI.Windows
{
    partial class InstructorsForm
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
            this.dgvInstructors = new System.Windows.Forms.DataGridView();
            this.clmFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.containerMain = new System.Windows.Forms.SplitContainer();
            this.btnAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInstructors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.containerMain)).BeginInit();
            this.containerMain.Panel1.SuspendLayout();
            this.containerMain.Panel2.SuspendLayout();
            this.containerMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvInstructors
            // 
            this.dgvInstructors.AllowUserToAddRows = false;
            this.dgvInstructors.AllowUserToDeleteRows = false;
            this.dgvInstructors.AllowUserToResizeRows = false;
            this.dgvInstructors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInstructors.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmFirstName,
            this.clmLastName,
            this.clmPhone});
            this.dgvInstructors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvInstructors.Location = new System.Drawing.Point(0, 0);
            this.dgvInstructors.Name = "dgvInstructors";
            this.dgvInstructors.ReadOnly = true;
            this.dgvInstructors.RowHeadersVisible = false;
            this.dgvInstructors.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInstructors.Size = new System.Drawing.Size(436, 216);
            this.dgvInstructors.TabIndex = 0;
            this.dgvInstructors.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvInstructors_CellDoubleClick);
            // 
            // clmFirstName
            // 
            this.clmFirstName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmFirstName.HeaderText = "Ime";
            this.clmFirstName.Name = "clmFirstName";
            this.clmFirstName.ReadOnly = true;
            // 
            // clmLastName
            // 
            this.clmLastName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmLastName.HeaderText = "Prezime";
            this.clmLastName.Name = "clmLastName";
            this.clmLastName.ReadOnly = true;
            // 
            // clmPhone
            // 
            this.clmPhone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmPhone.HeaderText = "Telefon";
            this.clmPhone.Name = "clmPhone";
            this.clmPhone.ReadOnly = true;
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
            this.containerMain.Panel1.Controls.Add(this.dgvInstructors);
            // 
            // containerMain.Panel2
            // 
            this.containerMain.Panel2.Controls.Add(this.btnAdd);
            this.containerMain.Size = new System.Drawing.Size(436, 261);
            this.containerMain.SplitterDistance = 216;
            this.containerMain.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.LimeGreen;
            this.btnAdd.Location = new System.Drawing.Point(317, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(116, 35);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Dodaj instruktora";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // InstructorsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 261);
            this.Controls.Add(this.containerMain);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InstructorsForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InstructorsForm";
            this.Load += new System.EventHandler(this.InstructorsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInstructors)).EndInit();
            this.containerMain.Panel1.ResumeLayout(false);
            this.containerMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.containerMain)).EndInit();
            this.containerMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvInstructors;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPhone;
        private System.Windows.Forms.SplitContainer containerMain;
        private System.Windows.Forms.Button btnAdd;
    }
}