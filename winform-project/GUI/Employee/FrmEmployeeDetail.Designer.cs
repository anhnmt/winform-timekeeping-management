namespace winform_project.GUI.Employee
{
    partial class FrmEmployeeDetail
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
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new winform_project.Validates.TextboxValidate();
            this.txtEmail = new winform_project.Validates.TextboxValidate();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtPhone = new winform_project.Validates.TextboxValidate();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtAddress = new winform_project.Validates.TextboxValidate();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtBirthday = new winform_project.Validates.TextboxValidate();
            this.lblBrithday = new System.Windows.Forms.Label();
            this.txtSalary = new winform_project.Validates.TextboxValidate();
            this.lblSalary = new System.Windows.Forms.Label();
            this.radFemale = new System.Windows.Forms.RadioButton();
            this.radMale = new System.Windows.Forms.RadioButton();
            this.lblGender = new System.Windows.Forms.Label();
            this.txtPassword = new winform_project.Validates.TextboxValidate();
            this.lblPassword = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(158, 49);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(57, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Họ và tên:";
            // 
            // txtName
            // 
            this.txtName.FieldName = null;
            this.txtName.Location = new System.Drawing.Point(218, 49);
            this.txtName.MaxLength = 0;
            this.txtName.MinLength = 0;
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.Pattern = null;
            this.txtName.Size = new System.Drawing.Size(247, 41);
            this.txtName.TabIndex = 1;
            // 
            // txtEmail
            // 
            this.txtEmail.FieldName = null;
            this.txtEmail.Location = new System.Drawing.Point(218, 96);
            this.txtEmail.MaxLength = 0;
            this.txtEmail.MinLength = 0;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.Pattern = null;
            this.txtEmail.Size = new System.Drawing.Size(247, 41);
            this.txtEmail.TabIndex = 3;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(158, 96);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.TabIndex = 2;
            this.lblEmail.Text = "Email:";
            // 
            // txtPhone
            // 
            this.txtPhone.FieldName = null;
            this.txtPhone.Location = new System.Drawing.Point(234, 143);
            this.txtPhone.MaxLength = 0;
            this.txtPhone.MinLength = 0;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.PasswordChar = '\0';
            this.txtPhone.Pattern = null;
            this.txtPhone.Size = new System.Drawing.Size(247, 41);
            this.txtPhone.TabIndex = 5;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(158, 143);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(73, 13);
            this.lblPhone.TabIndex = 4;
            this.lblPhone.Text = "Số điện thoại:";
            // 
            // txtAddress
            // 
            this.txtAddress.FieldName = null;
            this.txtAddress.Location = new System.Drawing.Point(234, 190);
            this.txtAddress.MaxLength = 0;
            this.txtAddress.MinLength = 0;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.PasswordChar = '\0';
            this.txtAddress.Pattern = null;
            this.txtAddress.Size = new System.Drawing.Size(247, 41);
            this.txtAddress.TabIndex = 7;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(158, 190);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(43, 13);
            this.lblAddress.TabIndex = 6;
            this.lblAddress.Text = "Địa chỉ:";
            // 
            // txtBirthday
            // 
            this.txtBirthday.FieldName = null;
            this.txtBirthday.Location = new System.Drawing.Point(234, 237);
            this.txtBirthday.MaxLength = 0;
            this.txtBirthday.MinLength = 0;
            this.txtBirthday.Name = "txtBirthday";
            this.txtBirthday.PasswordChar = '\0';
            this.txtBirthday.Pattern = null;
            this.txtBirthday.Size = new System.Drawing.Size(247, 41);
            this.txtBirthday.TabIndex = 9;
            // 
            // lblBrithday
            // 
            this.lblBrithday.AutoSize = true;
            this.lblBrithday.Location = new System.Drawing.Point(158, 237);
            this.lblBrithday.Name = "lblBrithday";
            this.lblBrithday.Size = new System.Drawing.Size(57, 13);
            this.lblBrithday.TabIndex = 8;
            this.lblBrithday.Text = "Ngày sinh:";
            // 
            // txtSalary
            // 
            this.txtSalary.FieldName = null;
            this.txtSalary.Location = new System.Drawing.Point(571, 38);
            this.txtSalary.MaxLength = 0;
            this.txtSalary.MinLength = 0;
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.PasswordChar = '\0';
            this.txtSalary.Pattern = null;
            this.txtSalary.Size = new System.Drawing.Size(169, 41);
            this.txtSalary.TabIndex = 11;
            // 
            // lblSalary
            // 
            this.lblSalary.AutoSize = true;
            this.lblSalary.Location = new System.Drawing.Point(495, 38);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(67, 13);
            this.lblSalary.TabIndex = 10;
            this.lblSalary.Text = "Hệ số lương:";
            // 
            // radFemale
            // 
            this.radFemale.AutoSize = true;
            this.radFemale.Checked = true;
            this.radFemale.Location = new System.Drawing.Point(573, 162);
            this.radFemale.Name = "radFemale";
            this.radFemale.Size = new System.Drawing.Size(47, 17);
            this.radFemale.TabIndex = 12;
            this.radFemale.TabStop = true;
            this.radFemale.Text = "Nam";
            this.radFemale.UseVisualStyleBackColor = true;
            // 
            // radMale
            // 
            this.radMale.AutoSize = true;
            this.radMale.Location = new System.Drawing.Point(626, 162);
            this.radMale.Name = "radMale";
            this.radMale.Size = new System.Drawing.Size(39, 17);
            this.radMale.TabIndex = 13;
            this.radMale.Text = "Nữ";
            this.radMale.UseVisualStyleBackColor = true;
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(500, 164);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(50, 13);
            this.lblGender.TabIndex = 14;
            this.lblGender.Text = "Giới tính:";
            // 
            // txtPassword
            // 
            this.txtPassword.FieldName = null;
            this.txtPassword.Location = new System.Drawing.Point(571, 115);
            this.txtPassword.MaxLength = 0;
            this.txtPassword.MinLength = 0;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '\0';
            this.txtPassword.Pattern = null;
            this.txtPassword.Size = new System.Drawing.Size(169, 41);
            this.txtPassword.TabIndex = 16;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(495, 115);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(67, 13);
            this.lblPassword.TabIndex = 15;
            this.lblPassword.Text = "Hệ số lương:";
            // 
            // FrmEmployeeDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.radMale);
            this.Controls.Add(this.radFemale);
            this.Controls.Add(this.txtSalary);
            this.Controls.Add(this.lblSalary);
            this.Controls.Add(this.txtBirthday);
            this.Controls.Add(this.lblBrithday);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmEmployeeDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EmployeeDetail";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private Validates.TextboxValidate txtName;
        private Validates.TextboxValidate txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private Validates.TextboxValidate txtPhone;
        private System.Windows.Forms.Label lblPhone;
        private Validates.TextboxValidate txtAddress;
        private System.Windows.Forms.Label lblAddress;
        private Validates.TextboxValidate txtBirthday;
        private System.Windows.Forms.Label lblBrithday;
        private Validates.TextboxValidate txtSalary;
        private System.Windows.Forms.Label lblSalary;
        private System.Windows.Forms.RadioButton radFemale;
        private System.Windows.Forms.RadioButton radMale;
        private System.Windows.Forms.Label lblGender;
        private Validates.TextboxValidate txtPassword;
        private System.Windows.Forms.Label lblPassword;
    }
}