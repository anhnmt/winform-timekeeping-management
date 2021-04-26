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
    public partial class FrmEmployeeDetail : Form
    {
        private TimekeepingDataContext tdc = new TimekeepingDataContext();
        public int? EmployeeId { get; set; }
        public FrmEmployeeDetail(int? employeeId)
        {
            EmployeeId = employeeId;
            InitializeComponent();
            Load_Position();
        }

        private void FrmEmployeeDetail_Load(object sender, EventArgs e)
        {
            if (EmployeeId != null)
            {
                this.Text = "Sửa đổi nhân viên";
                btnSave.Text = "";

                var Employee = tdc.Employees.FirstOrDefault(x => x.employee_id == EmployeeId);

                if (Employee.avatar != null)
                {
                    //pbEmpPicture.Image = Image.FromStream(new MemoryStream(Employee.avatar.ToArray()));

                    txtName.TextContent = Employee.name.ToString();
                    txtEmail.TextContent = Employee.email.ToString();
                    txtPhone.TextContent = Employee.phone.ToString();
                    txtAddress.TextContent = Employee.address.ToString();
                    txtPassword.TextContent = Employee.password.ToString();
                    txtSalary.TextContent = Employee.coefficients_salary.ToString();
                    cboPosition.SelectedValue = Employee.position_id;
                    radMale.Checked = Employee.gender;
                    radFemale.Checked = !Employee.gender;
                    txtBirthday.Value = Employee.birthday;
                }
            }
        }

        private void Load_Position()
        {
            cboPosition.DataSource = (from p in tdc.Positions
                                      select new
                                      {
                                          PosId = p.position_id,
                                          Name = p.name,
                                      }).ToList();

            cboPosition.DisplayMember = "Name";
            cboPosition.ValueMember = "PosId";
        }
    }
}
