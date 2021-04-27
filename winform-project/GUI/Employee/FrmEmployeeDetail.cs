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
            this.Text = "Thêm đổi nhân viên";
            btnSave.Text = "Thêm";
            txtName.TextContent = "";
            txtEmail.TextContent = "";
            txtPhone.TextContent = "";
            txtAddress.TextContent = "";
            txtPassword.TextContent = "";
            txtSalary.TextContent = "";
            //cboPosition.SelectedValue = Employee.position_id;
            radMale.Checked = true;
            radFemale.Checked = false;
            txtBirthday.Value = DateTime.Now;

            if (EmployeeId != null)
            {
                this.Text = "Sửa đổi nhân viên";
                btnSave.Text = "Sửa";

                var Employee = tdc.Employees.FirstOrDefault(x => x.employee_id == EmployeeId);

                if (Employee != null)
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
                                          PositionId = p.position_id,
                                          Name = p.name,
                                      }).ToList();

            cboPosition.DisplayMember = "Name";
            cboPosition.ValueMember = "PositionId";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bool? result = null;
            string message = "";

            winform_project.Employee Employee = new winform_project.Employee();
            Employee.name = txtName.TextContent;
            Employee.email = txtEmail.TextContent;
            Employee.phone = txtPhone.TextContent;
            Employee.address = txtAddress.TextContent;
            Employee.password = txtPassword.TextContent;
            Employee.coefficients_salary = Double.Parse(txtSalary.TextContent);
            Employee.position_id = (int)cboPosition.SelectedValue;
            Employee.gender = radMale.Checked;
            Employee.birthday = txtBirthday.Value;

            if (EmployeeId != null)
            {
                tdc.sp_updateEmployee(EmployeeId, Employee.name, Employee.email, Employee.phone, Employee.password, Employee.address, Employee.birthday, Employee.gender, Employee.coefficients_salary, Employee.position_id,  ref result, ref message);

                if (result == false)
                {
                    MessageBox.Show(message, "Có lỗi xảy ra", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    this.Close();
                }
            }
            else
            {
                tdc.sp_createEmployee(Employee.name, Employee.email, Employee.password, Employee.phone, Employee.address, Employee.birthday, Employee.gender, Employee.coefficients_salary, null, Employee.position_id, ref result, ref message);

                if (result == false)
                {
                    MessageBox.Show(message, "Có lỗi xảy ra", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show(message, "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
        }
    }
}
