using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winform_project
{
    public partial class FrmLogin : Form
    {
        static TimekeepingDataContext tdc = new TimekeepingDataContext();
        FrmMain formOut;

        public FrmLogin(FrmMain formIn)
        {
            formOut = formIn;
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var email = txtAccount.TextBox.Text.Trim();
            var password = txtPassword.TextBox.Text.Trim();

            var Employee = tdc.Employees.FirstOrDefault(x => x.email == email);

            if (Employee != null)
            {
                if (Employee.password.Equals(password))
                {
                    Console.WriteLine("UserId : " + Employee.employee_id);
                    formOut.Employee = Employee;
                    this.Close();
                }
                else txtPassword.Label = "Mật khẩu không chính xác";
            }
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            //txtAccount.TextBox.Text = "sa@gmail.com";
            txtAccount.TextBox.Text = "admin@gmail.com";
            txtPassword.TextBox.Text = "123456";
        }
    }
}
