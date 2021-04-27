
namespace winform_project.GUI.Position
{
    partial class FrmPositionList
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvPosition = new System.Windows.Forms.DataGridView();
            this.PositionId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PositionName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BasicSalary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnAddPosition = new System.Windows.Forms.Button();
            this.txtSalary = new winform_project.Validates.TextboxValidate();
            this.txtName = new winform_project.Validates.TextboxValidate();
            this.contextMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPosition)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem3});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(146, 48);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(145, 22);
            this.toolStripMenuItem2.Text = "Sửa thông tin";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(145, 22);
            this.toolStripMenuItem3.Text = "Xoá chức vụ";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // dgvPosition
            // 
            this.dgvPosition.AllowUserToAddRows = false;
            this.dgvPosition.AllowUserToDeleteRows = false;
            this.dgvPosition.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPosition.BackgroundColor = System.Drawing.Color.White;
            this.dgvPosition.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPosition.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PositionId,
            this.PositionName,
            this.BasicSalary});
            this.dgvPosition.ContextMenuStrip = this.contextMenuStrip;
            this.dgvPosition.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPosition.GridColor = System.Drawing.Color.White;
            this.dgvPosition.Location = new System.Drawing.Point(0, 95);
            this.dgvPosition.MultiSelect = false;
            this.dgvPosition.Name = "dgvPosition";
            this.dgvPosition.ReadOnly = true;
            this.dgvPosition.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPosition.Size = new System.Drawing.Size(800, 355);
            this.dgvPosition.TabIndex = 2;
            // 
            // PositionId
            // 
            this.PositionId.DataPropertyName = "PositionId";
            this.PositionId.HeaderText = "Mã chức vụ";
            this.PositionId.Name = "PositionId";
            this.PositionId.ReadOnly = true;
            // 
            // PositionName
            // 
            this.PositionName.DataPropertyName = "PositionName";
            this.PositionName.HeaderText = "Tên chức vụ";
            this.PositionName.Name = "PositionName";
            this.PositionName.ReadOnly = true;
            // 
            // BasicSalary
            // 
            this.BasicSalary.DataPropertyName = "BasicSalary";
            this.BasicSalary.HeaderText = "Lương cơ bản";
            this.BasicSalary.Name = "BasicSalary";
            this.BasicSalary.ReadOnly = true;
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Location = new System.Drawing.Point(593, 17);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(195, 20);
            this.txtSearch.TabIndex = 2;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // lblSearch
            // 
            this.lblSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(538, 20);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(49, 13);
            this.lblSearch.TabIndex = 3;
            this.lblSearch.Text = "Tìm kiếm";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(675, 54);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(113, 23);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Tên chức vụ";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnRefresh);
            this.panel1.Controls.Add(this.btnAddPosition);
            this.panel1.Controls.Add(this.txtSalary);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.lblSearch);
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 95);
            this.panel1.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(356, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Lương cơ bản";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRefresh.Location = new System.Drawing.Point(155, 15);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(111, 23);
            this.btnRefresh.TabIndex = 13;
            this.btnRefresh.Text = "Làm Mới";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click_1);
            // 
            // btnAddPosition
            // 
            this.btnAddPosition.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAddPosition.BackColor = System.Drawing.Color.Lime;
            this.btnAddPosition.Location = new System.Drawing.Point(12, 15);
            this.btnAddPosition.Name = "btnAddPosition";
            this.btnAddPosition.Size = new System.Drawing.Size(111, 23);
            this.btnAddPosition.TabIndex = 12;
            this.btnAddPosition.Text = "Thêm Chức Vụ";
            this.btnAddPosition.UseVisualStyleBackColor = false;
            this.btnAddPosition.Click += new System.EventHandler(this.btnAddPosition_Click_1);
            // 
            // txtSalary
            // 
            this.txtSalary.FieldName = null;
            this.txtSalary.Location = new System.Drawing.Point(451, 54);
            this.txtSalary.MaxLength = 0;
            this.txtSalary.MinLength = 0;
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.PasswordChar = '\0';
            this.txtSalary.Pattern = null;
            this.txtSalary.Size = new System.Drawing.Size(185, 46);
            this.txtSalary.TabIndex = 11;
            this.txtSalary.TextContent = "";
            // 
            // txtName
            // 
            this.txtName.FieldName = null;
            this.txtName.Location = new System.Drawing.Point(145, 54);
            this.txtName.MaxLength = 0;
            this.txtName.MinLength = 0;
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.Pattern = null;
            this.txtName.Size = new System.Drawing.Size(185, 46);
            this.txtName.TabIndex = 10;
            this.txtName.TextContent = "";
            // 
            // FrmPositionList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvPosition);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPositionList";
            this.Text = "FrmPositionList";
            this.Load += new System.EventHandler(this.FrmPositionList_Load);
            this.contextMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPosition)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.DataGridView dgvPosition;
        private System.Windows.Forms.DataGridViewTextBoxColumn PositionId;
        private System.Windows.Forms.DataGridViewTextBoxColumn PositionName;
        private System.Windows.Forms.DataGridViewTextBoxColumn BasicSalary;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnAddPosition;
        private Validates.TextboxValidate txtSalary;
        private Validates.TextboxValidate txtName;
        private System.Windows.Forms.Label label3;
    }
}