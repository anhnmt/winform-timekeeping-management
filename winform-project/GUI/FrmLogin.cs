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

        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var email = txtAccount.TextBox.Text.Trim();
            var password = txtPassword.TextBox.Text.Trim();

            var Employee = tdc.Employees.FirstOrDefault(x => x.email == email);

            if (Employee != null)
            {
                MessageBox.Show(Employee.password);
                if (Employee.password.Equals(password))
                {
                    FrmMain frmMain = new FrmMain();
                    frmMain.Show();
                    this.Hide();
                }
                else txtPassword.Label = "Mật khẩu không chính xác";
            }
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
