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
using winform_project.GUI.Position;
using winform_project.GUI.Profile;
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


            if (Employee is null)
            {
                FrmLogin frmLogin = new FrmLogin(this);
                frmLogin.ShowDialog(this);
            }
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
            btnEmployee.Select();
            panelRight.Controls.Clear();
            FrmEmployeeList employeeList = new FrmEmployeeList(Employee)
            {
                TopLevel = false,
                Dock = DockStyle.Fill
            };
            employeeList.Show();
            panelRight.Controls.Add(employeeList);
        }

        private void btnScheduler_Click(object sender, EventArgs e)
        {
            btnScheduler.Select();
            panelRight.Controls.Clear();
            FrmSchedule emlpoyeeSchedule = new FrmSchedule(Employee)
            {
                TopLevel = false,
                Dock = DockStyle.Fill
            };
            emlpoyeeSchedule.Show();
            panelRight.Controls.Add(emlpoyeeSchedule);
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            //btnProfile_Click(sender, e);
            if (Employee.position_id == 1)
            {
                btnEmployee_Click(sender, e);
            }
            else
            {
                btnScheduler_Click(sender, e);
                btnEmployee.Visible = false;
                btnPosition.Visible = false;
            }
        }

        private void btnPosition_Click(object sender, EventArgs e)
        {
            btnPosition.Select();
            panelRight.Controls.Clear();
            FrmPositionList frmPositionList = new FrmPositionList(Employee)
            {
                TopLevel = false,
                Dock = DockStyle.Fill
            };
            frmPositionList.Show();
            panelRight.Controls.Add(frmPositionList);
        }
    }
}
