
namespace winform_project.GUI.Schedule
{
    partial class FrmSchedule
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "Công làm việc",
            "0"}, -1);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "Số giờ đi muộn",
            "0"}, -1);
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem(new string[] {
            "Số giờ về sớm",
            "0"}, -1);
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem(new string[] {
            "Số ngày nghỉ lễ trong tháng",
            "0"}, -1);
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem(new string[] {
            "Số ngày nghỉ cuối tuần trong tháng",
            "0"}, -1);
            this.panelTop = new System.Windows.Forms.Panel();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnSchedule = new System.Windows.Forms.Button();
            this.dtpMonth = new System.Windows.Forms.DateTimePicker();
            this.lblTitle = new System.Windows.Forms.Label();
            this.dgvLeft = new System.Windows.Forms.DataGridView();
            this.WorkingDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Holiday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Weekend = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartWorkHour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndWorkHour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HourWorkLate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HourLeaveEarly = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ScheduleId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLeft)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelTop.BackColor = System.Drawing.Color.White;
            this.panelTop.Controls.Add(this.btnRefresh);
            this.panelTop.Controls.Add(this.btnSchedule);
            this.panelTop.Controls.Add(this.dtpMonth);
            this.panelTop.Controls.Add(this.lblTitle);
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(950, 50);
            this.panelTop.TabIndex = 1;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.Location = new System.Drawing.Point(722, 14);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(105, 23);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.Text = "Làm mới";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnSchedule
            // 
            this.btnSchedule.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSchedule.Location = new System.Drawing.Point(833, 14);
            this.btnSchedule.Name = "btnSchedule";
            this.btnSchedule.Size = new System.Drawing.Size(105, 23);
            this.btnSchedule.TabIndex = 2;
            this.btnSchedule.Text = "Checkin vào làm";
            this.btnSchedule.UseVisualStyleBackColor = true;
            this.btnSchedule.Click += new System.EventHandler(this.btnSchedule_Click);
            // 
            // dtpMonth
            // 
            this.dtpMonth.CalendarMonthBackground = System.Drawing.Color.White;
            this.dtpMonth.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dtpMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dtpMonth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpMonth.Location = new System.Drawing.Point(148, 14);
            this.dtpMonth.Name = "dtpMonth";
            this.dtpMonth.Size = new System.Drawing.Size(151, 21);
            this.dtpMonth.TabIndex = 1;
            this.dtpMonth.ValueChanged += new System.EventHandler(this.dtpMonth_ValueChanged);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTitle.Location = new System.Drawing.Point(12, 17);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(130, 15);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "BẢNG CHẤM CÔNG";
            // 
            // dgvLeft
            // 
            this.dgvLeft.AllowUserToAddRows = false;
            this.dgvLeft.AllowUserToDeleteRows = false;
            this.dgvLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvLeft.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLeft.BackgroundColor = System.Drawing.Color.White;
            this.dgvLeft.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLeft.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.WorkingDate,
            this.Holiday,
            this.Weekend,
            this.StartWorkHour,
            this.EndWorkHour,
            this.HourWorkLate,
            this.HourLeaveEarly,
            this.EmployeeId,
            this.ScheduleId});
            this.dgvLeft.GridColor = System.Drawing.Color.White;
            this.dgvLeft.Location = new System.Drawing.Point(0, 50);
            this.dgvLeft.MultiSelect = false;
            this.dgvLeft.Name = "dgvLeft";
            this.dgvLeft.ReadOnly = true;
            this.dgvLeft.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvLeft.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLeft.Size = new System.Drawing.Size(662, 469);
            this.dgvLeft.TabIndex = 3;
            // 
            // WorkingDate
            // 
            this.WorkingDate.DataPropertyName = "WorkingDate";
            this.WorkingDate.HeaderText = "Ngày làm";
            this.WorkingDate.Name = "WorkingDate";
            this.WorkingDate.ReadOnly = true;
            // 
            // Holiday
            // 
            this.Holiday.DataPropertyName = "Holiday";
            this.Holiday.HeaderText = "Ngày nghỉ lễ";
            this.Holiday.Name = "Holiday";
            this.Holiday.ReadOnly = true;
            // 
            // Weekend
            // 
            this.Weekend.DataPropertyName = "Weekend";
            this.Weekend.HeaderText = "Ngày cuối tuần";
            this.Weekend.Name = "Weekend";
            this.Weekend.ReadOnly = true;
            // 
            // StartWorkHour
            // 
            this.StartWorkHour.DataPropertyName = "StartWorkHour";
            this.StartWorkHour.HeaderText = "Giờ bắt đầu";
            this.StartWorkHour.Name = "StartWorkHour";
            this.StartWorkHour.ReadOnly = true;
            // 
            // EndWorkHour
            // 
            this.EndWorkHour.DataPropertyName = "EndWorkHour";
            this.EndWorkHour.HeaderText = "Giờ ra về";
            this.EndWorkHour.Name = "EndWorkHour";
            this.EndWorkHour.ReadOnly = true;
            // 
            // HourWorkLate
            // 
            this.HourWorkLate.DataPropertyName = "HourWorkLate";
            this.HourWorkLate.HeaderText = "Số giờ đi muộn";
            this.HourWorkLate.Name = "HourWorkLate";
            this.HourWorkLate.ReadOnly = true;
            // 
            // HourLeaveEarly
            // 
            this.HourLeaveEarly.DataPropertyName = "HourLeaveEarly";
            this.HourLeaveEarly.HeaderText = "Số giờ về sớm";
            this.HourLeaveEarly.Name = "HourLeaveEarly";
            this.HourLeaveEarly.ReadOnly = true;
            // 
            // EmployeeId
            // 
            this.EmployeeId.DataPropertyName = "EmployeeId";
            this.EmployeeId.HeaderText = "Mã nhân viên";
            this.EmployeeId.Name = "EmployeeId";
            this.EmployeeId.ReadOnly = true;
            this.EmployeeId.Visible = false;
            // 
            // ScheduleId
            // 
            this.ScheduleId.DataPropertyName = "ScheduleId";
            this.ScheduleId.HeaderText = "Mã chấm công";
            this.ScheduleId.Name = "ScheduleId";
            this.ScheduleId.ReadOnly = true;
            this.ScheduleId.Visible = false;
            // 
            // listView
            // 
            this.listView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listView.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.listView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.listView.HideSelection = false;
            this.listView.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4,
            listViewItem5});
            this.listView.LabelWrap = false;
            this.listView.Location = new System.Drawing.Point(668, 50);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(282, 469);
            this.listView.TabIndex = 0;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "";
            this.columnHeader1.Width = 216;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader2.Width = 45;
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // EmployeeSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 518);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.dgvLeft);
            this.Controls.Add(this.listView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EmployeeSchedule";
            this.Text = "EmlpoyeeSchedule";
            this.Load += new System.EventHandler(this.EmployeeSchedule_Load);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLeft)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.DataGridView dgvLeft;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DateTimePicker dtpMonth;
        private System.Windows.Forms.Button btnSchedule;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.DataGridViewTextBoxColumn WorkingDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Holiday;
        private System.Windows.Forms.DataGridViewTextBoxColumn Weekend;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartWorkHour;
        private System.Windows.Forms.DataGridViewTextBoxColumn EndWorkHour;
        private System.Windows.Forms.DataGridViewTextBoxColumn HourWorkLate;
        private System.Windows.Forms.DataGridViewTextBoxColumn HourLeaveEarly;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ScheduleId;
        private System.Windows.Forms.Timer timer;
    }
}