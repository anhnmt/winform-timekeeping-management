
namespace winform_project.Validates
{
    partial class TextboxValidate
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblError = new System.Windows.Forms.Label();
            this.txtField = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblError
            // 
            this.lblError.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(0, 24);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(283, 22);
            this.lblError.TabIndex = 0;
            // 
            // txtField
            // 
            this.txtField.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtField.Location = new System.Drawing.Point(0, 0);
            this.txtField.Name = "txtField";
            this.txtField.PasswordChar = '*';
            this.txtField.Size = new System.Drawing.Size(283, 20);
            this.txtField.TabIndex = 1;
            this.txtField.Validating += new System.ComponentModel.CancelEventHandler(this.txtField_Validating);
            // 
            // TextboxValidate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtField);
            this.Controls.Add(this.lblError);
            this.Name = "TextboxValidate";
            this.Size = new System.Drawing.Size(283, 46);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.TextBox txtField;
    }
}
