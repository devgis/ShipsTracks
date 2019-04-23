namespace SimulatorProgram
{
    partial class ShipsManager
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsAdd = new System.Windows.Forms.ToolStripButton();
            this.tsEdit = new System.Windows.Forms.ToolStripButton();
            this.tsDel = new System.Windows.Forms.ToolStripButton();
            this.dgvList = new System.Windows.Forms.DataGridView();
            this.CID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CNAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COWNER = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CCOMPANY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CCONTACT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CLON = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CLAT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsAdd,
            this.tsEdit,
            this.tsDel});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(675, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsAdd
            // 
            this.tsAdd.Image = global::SimulatorProgram.Properties.Resources.add;
            this.tsAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsAdd.Name = "tsAdd";
            this.tsAdd.Size = new System.Drawing.Size(52, 22);
            this.tsAdd.Text = "添加";
            this.tsAdd.Click += new System.EventHandler(this.tsAdd_Click);
            // 
            // tsEdit
            // 
            this.tsEdit.Image = global::SimulatorProgram.Properties.Resources.edit;
            this.tsEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsEdit.Name = "tsEdit";
            this.tsEdit.Size = new System.Drawing.Size(52, 22);
            this.tsEdit.Text = "编辑";
            this.tsEdit.Click += new System.EventHandler(this.tsEdit_Click);
            // 
            // tsDel
            // 
            this.tsDel.Image = global::SimulatorProgram.Properties.Resources.del;
            this.tsDel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsDel.Name = "tsDel";
            this.tsDel.Size = new System.Drawing.Size(52, 22);
            this.tsDel.Text = "删除";
            this.tsDel.Click += new System.EventHandler(this.tsDel_Click);
            // 
            // dgvList
            // 
            this.dgvList.AllowUserToAddRows = false;
            this.dgvList.AllowUserToDeleteRows = false;
            this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CID,
            this.CNO,
            this.CNAME,
            this.COWNER,
            this.CCOMPANY,
            this.CCONTACT,
            this.CLON,
            this.CLAT});
            this.dgvList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvList.Location = new System.Drawing.Point(0, 25);
            this.dgvList.MultiSelect = false;
            this.dgvList.Name = "dgvList";
            this.dgvList.ReadOnly = true;
            this.dgvList.RowTemplate.Height = 23;
            this.dgvList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvList.Size = new System.Drawing.Size(675, 297);
            this.dgvList.TabIndex = 1;
            // 
            // CID
            // 
            this.CID.DataPropertyName = "ShipID";
            this.CID.HeaderText = "ID";
            this.CID.Name = "CID";
            this.CID.ReadOnly = true;
            this.CID.Visible = false;
            // 
            // CNO
            // 
            this.CNO.DataPropertyName = "ShipNO";
            this.CNO.HeaderText = "编号";
            this.CNO.Name = "CNO";
            this.CNO.ReadOnly = true;
            // 
            // CNAME
            // 
            this.CNAME.DataPropertyName = "ShipName";
            this.CNAME.HeaderText = "名称";
            this.CNAME.Name = "CNAME";
            this.CNAME.ReadOnly = true;
            // 
            // COWNER
            // 
            this.COWNER.DataPropertyName = "Owner";
            this.COWNER.HeaderText = "拥有者";
            this.COWNER.Name = "COWNER";
            this.COWNER.ReadOnly = true;
            // 
            // CCOMPANY
            // 
            this.CCOMPANY.DataPropertyName = "OwnerCompany";
            this.CCOMPANY.HeaderText = "所属公司";
            this.CCOMPANY.Name = "CCOMPANY";
            this.CCOMPANY.ReadOnly = true;
            // 
            // CCONTACT
            // 
            this.CCONTACT.DataPropertyName = "Contact";
            this.CCONTACT.HeaderText = "联系方式";
            this.CCONTACT.Name = "CCONTACT";
            this.CCONTACT.ReadOnly = true;
            // 
            // CLON
            // 
            this.CLON.DataPropertyName = "Lon";
            this.CLON.HeaderText = "经度";
            this.CLON.Name = "CLON";
            this.CLON.ReadOnly = true;
            // 
            // CLAT
            // 
            this.CLAT.DataPropertyName = "Lat";
            this.CLAT.HeaderText = "纬度";
            this.CLAT.Name = "CLAT";
            this.CLAT.ReadOnly = true;
            // 
            // ShipsManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 322);
            this.Controls.Add(this.dgvList);
            this.Controls.Add(this.toolStrip1);
            this.Name = "ShipsManager";
            this.Text = "管理";
            this.Load += new System.EventHandler(this.ShipsManager_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsAdd;
        private System.Windows.Forms.ToolStripButton tsEdit;
        private System.Windows.Forms.ToolStripButton tsDel;
        private System.Windows.Forms.DataGridView dgvList;
        private System.Windows.Forms.DataGridViewTextBoxColumn CID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CNAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn COWNER;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCOMPANY;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCONTACT;
        private System.Windows.Forms.DataGridViewTextBoxColumn CLON;
        private System.Windows.Forms.DataGridViewTextBoxColumn CLAT;
    }
}