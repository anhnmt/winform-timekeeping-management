using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using winform_project.GUI.Employee;
using winform_project.GUI.Schedule;

namespace winform_project
{
    public partial class FrmMain : Form
    {
        public Employee Employee { get; set; }

        public FrmMain()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.WindowState = FormWindowState.Maximized;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn muốn chắc muốn đăng xuất?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            panelRight.Controls.Clear();
            EmployeeList employeeList = new EmployeeList();
            employeeList.TopLevel = false;
            employeeList.Dock = DockStyle.Fill;
            employeeList.Show();
            panelRight.Controls.Add(employeeList);
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {

        }

        private void btnScheduler_Click(object sender, EventArgs e)
        {
            panelRight.Controls.Clear();
            EmployeeSchedule emlpoyeeSchedule = new EmployeeSchedule(Employee);
            emlpoyeeSchedule.TopLevel = false;
            emlpoyeeSchedule.Dock = DockStyle.Fill;
            emlpoyeeSchedule.Show();
            panelRight.Controls.Add(emlpoyeeSchedule);
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {

        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            if (Employee is null)
            {
                FrmLogin frmLogin = new FrmLogin(this);
                frmLogin.ShowDialog(this);
            }
        }
    }
}
