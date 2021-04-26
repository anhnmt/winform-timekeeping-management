using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winform_project.GUI.Schedule
{
    public partial class FrmSchedule : Form
    {
        private TimekeepingDataContext tdc = new TimekeepingDataContext();
        public winform_project.Employee Employee { get; set; }

        DateTime working_date;
        //FrmMain formOut;

        public FrmSchedule(winform_project.Employee employee)
        {
            Employee = employee;
            InitializeComponent();
        }

        private void btnSchedule_Click(object sender, EventArgs e)
        {
            bool? result = null;
            string message = "";

            working_date = Convert.ToDateTime(dtpMonth.Text);

            tdc.sp_loadSchedule(Employee.employee_id, working_date, working_date, working_date, ref result, ref message);

            if (result == true)
                MessageBox.Show(message, "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show(message, "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);

            // load lại dữ liệu mới
            btnRefresh_Click(sender, e);
        }

        private void EmployeeSchedule_Load(object sender, EventArgs e)
        {
            Console.WriteLine("UserId : " + Employee.employee_id);
            dtpMonth.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
            btnRefresh_Click(sender, e);
        }

        private void dtpMonth_ValueChanged(object sender, EventArgs e)
        {
            btnRefresh_Click(sender, e);
        }

        private void loadAllSchedules()
        {
            working_date = Convert.ToDateTime(dtpMonth.Text);

            dgvLeft.DataSource = (from sch in tdc.sp_getAllSchedulesByEmployeeId(Employee.employee_id, working_date)
                                  select new
                                  {
                                      WorkingDate = sch.working_date,
                                      Holiday = sch.is_holiday == true ? "Ngày nghỉ, lễ" : "Không",
                                      Weekend = sch.is_weekend == true ? "Ngày cuối tuần" : "Không",
                                      StartWorkHour = sch.start_work_hour,
                                      EndWorkHour = sch.end_work_hour,
                                      HourWorkLate = sch.hour_work_late,
                                      HourLeaveEarly = sch.hour_leave_early,
                                      Workday = sch.workday,
                                  }
            ).ToList();
        }

        private void loadStatusSchedule()
        {
            btnSchedule.Enabled = true;
            working_date = Convert.ToDateTime(dtpMonth.Text);

            winform_project.Schedule schedule = tdc.Schedules.FirstOrDefault(sch => sch.employee_id == Employee.employee_id && sch.working_date == working_date);

            if (schedule != null)
            {
                if (schedule.end_work_hour is null)
                {
                    btnSchedule.BackColor = System.Drawing.Color.Orange;
                    btnSchedule.Text = "Checkout ra về";
                }
                else
                    btnSchedule.Enabled = false;
            }
            else
            {
                btnSchedule.BackColor = System.Drawing.Color.Green;
                btnSchedule.Text = "Checkin vào làm";
            }
        }

        private void countAllSchedules()
        {
            working_date = Convert.ToDateTime(dtpMonth.Text);

            sp_countAllSchedulesByEmployeeIdResult schedule = tdc.sp_countAllSchedulesByEmployeeId(Employee.employee_id, working_date).FirstOrDefault();

            if (schedule != null)
            {
                listView.Items[0].SubItems[1].Text = schedule.total_workday.ToString();
                listView.Items[1].SubItems[1].Text = schedule.total_hour_work_late.ToString();
                listView.Items[2].SubItems[1].Text = schedule.total_hour_leave_early.ToString();
                listView.Items[3].SubItems[1].Text = schedule.total_holiday.ToString();
                listView.Items[4].SubItems[1].Text = schedule.total_weekend.ToString();
            }

        }

        private void timer_Tick(object sender, EventArgs e)
        {
            dtpMonth.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
            Console.WriteLine(dtpMonth.Text);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            loadAllSchedules();
            loadStatusSchedule();
            countAllSchedules();
        }
    }
}
