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
    public partial class EmployeeSchedule : Form
    {
        private TimekeepingDataContext tdc = new TimekeepingDataContext();
        public winform_project.Employee Employee { get; set; }
        //FrmMain formOut;

        public EmployeeSchedule(winform_project.Employee employee)
        {
            Employee = employee;
            InitializeComponent();
        }

        private void loadSchedules()
        {
            var working_date = Convert.ToDateTime(dtpMonth.Text);
            Console.WriteLine(working_date);

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

        private void btnSchedule_Click(object sender, EventArgs e)
        {

        }

        private void EmployeeSchedule_Load(object sender, EventArgs e)
        {
            Console.WriteLine("UserId : " + Employee.employee_id);
            loadSchedules();
        }

        private void dtpMonth_ValueChanged(object sender, EventArgs e)
        {
            loadSchedules();
        }
    }
}
