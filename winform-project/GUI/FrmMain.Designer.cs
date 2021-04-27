
namespace winform_project
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.panelLeft = new System.Windows.Forms.Panel();
            this.btnPosition = new System.Windows.Forms.Button();
            this.btnScheduler = new System.Windows.Forms.Button();
            this.picBoxAvatar = new System.Windows.Forms.PictureBox();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnEmployee = new System.Windows.Forms.Button();
            this.panelRight = new System.Windows.Forms.Panel();
            this.panelLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.White;
            this.panelLeft.Controls.Add(this.btnPosition);
            this.panelLeft.Controls.Add(this.btnScheduler);
            this.panelLeft.Controls.Add(this.picBoxAvatar);
            this.panelLeft.Controls.Add(this.btnLogout);
            this.panelLeft.Controls.Add(this.btnEmployee);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(229, 592);
            this.panelLeft.TabIndex = 0;
            // 
            // btnPosition
            // 
            this.btnPosition.Image = global::winform_project.Properties.Resources.icons8_user_shield_30;
            this.btnPosition.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPosition.Location = new System.Drawing.Point(4, 199);
            this.btnPosition.Name = "btnPosition";
            this.btnPosition.Size = new System.Drawing.Size(219, 37);
            this.btnPosition.TabIndex = 13;
            this.btnPosition.Text = "Chức vụ";
            this.btnPosition.UseVisualStyleBackColor = true;
            this.btnPosition.Click += new System.EventHandler(this.btnPosition_Click);
            // 
            // btnScheduler
            // 
            this.btnScheduler.Image = global::winform_project.Properties.Resources.icons8_schedule_30;
            this.btnScheduler.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnScheduler.Location = new System.Drawing.Point(4, 156);
            this.btnScheduler.Name = "btnScheduler";
            this.btnScheduler.Size = new System.Drawing.Size(219, 37);
            this.btnScheduler.TabIndex = 12;
            this.btnScheduler.Text = "Chấm công";
            this.btnScheduler.UseVisualStyleBackColor = true;
            this.btnScheduler.Click += new System.EventHandler(this.btnScheduler_Click);
            // 
            // picBoxAvatar
            // 
            this.picBoxAvatar.Cursor = System.Windows.Forms.Cursors.Default;
            this.picBoxAvatar.Image = global::winform_project.Properties.Resources.icons8_window_search_96;
            this.picBoxAvatar.Location = new System.Drawing.Point(4, 11);
            this.picBoxAvatar.Name = "picBoxAvatar";
            this.picBoxAvatar.Size = new System.Drawing.Size(219, 96);
            this.picBoxAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picBoxAvatar.TabIndex = 11;
            this.picBoxAvatar.TabStop = false;
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogout.Image = global::winform_project.Properties.Resources.icons8_sign_out_30;
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(4, 543);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(219, 37);
            this.btnLogout.TabIndex = 9;
            this.btnLogout.Text = "Đăng xuất";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnEmployee
            // 
            this.btnEmployee.Image = global::winform_project.Properties.Resources.icons8_staff_30;
            this.btnEmployee.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmployee.Location = new System.Drawing.Point(4, 113);
            this.btnEmployee.Name = "btnEmployee";
            this.btnEmployee.Size = new System.Drawing.Size(219, 37);
            this.btnEmployee.TabIndex = 8;
            this.btnEmployee.Text = "Danh sách nhân viên";
            this.btnEmployee.UseVisualStyleBackColor = true;
            this.btnEmployee.Click += new System.EventHandler(this.btnEmployee_Click);
            // 
            // panelRight
            // 
            this.panelRight.BackColor = System.Drawing.Color.White;
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRight.Location = new System.Drawing.Point(229, 0);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(747, 592);
            this.panelRight.TabIndex = 1;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(976, 592);
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.panelLeft);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMain";
            this.Text = "PHẦN MỀM CHẤM CÔNG";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.panelLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxAvatar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Button btnScheduler;
        private System.Windows.Forms.PictureBox picBoxAvatar;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnEmployee;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.Button btnPosition;
    }
}

