using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winform_project.GUI.Employee
{
    public partial class EmployeeList : Form
    {
        private TimekeepingDataContext tdc = new TimekeepingDataContext();

        public EmployeeList()
        {
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
                                         Salary = emp.Position.basic_salary
                                     };
        }

        private void dgvEmployee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
