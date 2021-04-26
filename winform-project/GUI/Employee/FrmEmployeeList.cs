using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using winform_project.GUI.Salary;

namespace winform_project.GUI.Employee
{
    public partial class FrmEmployeeList : Form
    {
        private TimekeepingDataContext tdc = new TimekeepingDataContext();
        public winform_project.Employee Employee { get; set; }

        public FrmEmployeeList(winform_project.Employee employee)
        {
            Employee = employee;
            InitializeComponent();
        }

        private void EmployeeList_Load(object sender, EventArgs e)
        {
            loadEmployees();
        }

        private void loadEmployees()
        {
            dgvEmployee.DataSource = from emp in tdc.Employees
                                     select new
                                     {
                                         EmployeeId = emp.employee_id,
                                         EmployeeName = emp.name,
                                         Email = emp.email,
                                         Phone = emp.phone,
                                         Position = emp.Position.name,
                                         Gender = emp.gender == true ? "Nam" : "Nữ",
                                         Address = emp.address,
                                         Birthday = emp.birthday,
                                         Salary = emp.Position.basic_salary * emp.coefficients_salary
                                     };
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            var search = txtSearch.Text.Trim();
            if (search != "")
            {
                dgvEmployee.DataSource = from emp in tdc.Employees
                                         where emp.name.Contains(search) || emp.Position.name.Contains(search)
                                         select new
                                         {
                                             EmployeeId = emp.employee_id,
                                             EmployeeName = emp.name,
                                             Email = emp.email,
                                             Phone = emp.phone,
                                             Position = emp.Position.name,
                                             Gender = emp.gender == true ? "Nam" : "Nữ",
                                             Address = emp.address,
                                             Birthday = emp.birthday,
                                             Salary = emp.Position.basic_salary * emp.coefficients_salary
                                         };
            }
            else
            {
                loadEmployees();
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (dgvEmployee.CurrentRow != null)
            {
                int EmployeeId = (int)dgvEmployee.CurrentRow.Cells["EmployeeId"].Value;
                FrmSalary frmSalary = new FrmSalary(EmployeeId);
                frmSalary.ShowDialog(this);
            }
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (dgvEmployee.CurrentRow != null)
            {
                int EmployeeId = (int) dgvEmployee.CurrentRow.Cells["EmployeeId"].Value;
                FrmEmployeeDetail frmEmployeeDetail = new FrmEmployeeDetail(EmployeeId);
                frmEmployeeDetail.ShowDialog(this);
            }
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            if (dgvEmployee.CurrentRow != null)
            {
                winform_project.Employee selectedEmployee = (winform_project.Employee)dgvEmployee.CurrentRow.DataBoundItem;
                bool? result = null;
                string message = "";

                DialogResult dialogResult = MessageBox.Show("Bạn có chắc muốn xóa nhân viên có tên: " + selectedEmployee.name, "Xóa nhân viên", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dialogResult == DialogResult.Yes)
                {
                    if (selectedEmployee.employee_id == Employee.employee_id)
                    {
                        MessageBox.Show("Tài khoản này hiên đang đăng nhập, không thể xóa", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        tdc.sp_deleteEmployee(selectedEmployee.employee_id, ref result, ref message);

                        if (result == false)
                        {
                            MessageBox.Show(message, "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            MessageBox.Show(message, "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            loadEmployees();
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn nhân viên để xóa!", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            loadEmployees();
        }
    }
}
