
namespace winform_project.GUI.Position
{
    partial class FrmPositionDetail
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
            this.btnSave = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtName = new winform_project.Validates.TextboxValidate();
            this.txtSalary = new winform_project.Validates.TextboxValidate();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(226, 173);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(151, 23);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên chức vụ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Lương cơ bản";
            // 
            // txtName
            // 
            this.txtName.FieldName = null;
            this.txtName.Location = new System.Drawing.Point(130, 50);
            this.txtName.MaxLength = 0;
            this.txtName.MinLength = 0;
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.Pattern = null;
            this.txtName.Size = new System.Drawing.Size(283, 46);
            this.txtName.TabIndex = 5;
            this.txtName.TextContent = "";
            // 
            // txtSalary
            // 
            this.txtSalary.FieldName = null;
            this.txtSalary.Location = new System.Drawing.Point(130, 102);
            this.txtSalary.MaxLength = 0;
            this.txtSalary.MinLength = 0;
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.PasswordChar = '\0';
            this.txtSalary.Pattern = null;
            this.txtSalary.Size = new System.Drawing.Size(283, 46);
            this.txtSalary.TabIndex = 6;
            this.txtSalary.TextContent = "";
            // 
            // FrmPositionDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 227);
            this.Controls.Add(this.txtSalary);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmPositionDetail";
            this.Text = "FrmPositionDetail";
            this.Load += new System.EventHandler(this.FrmPositionDetail_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Validates.TextboxValidate txtName;
        private Validates.TextboxValidate txtSalary;
    }
}