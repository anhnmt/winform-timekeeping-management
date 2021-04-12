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
            var email = txtAccount.Text;
            var password = txtPassword.Text;

            var Employee = tdc.Employees.FirstOrDefault(x => x.email == email);

            if (Employee != null)
            {
                if (Employee.password == password)
                {
                    FrmMain frmMain = new FrmMain();
                    frmMain.Show();
                    this.Hide();
                }
                //else txtPassword.Label = "Mật khẩu không chính xác";
            }
                //if (String.IsNullOrEmpty(email) || String.IsNullOrEmpty(password))
                //{
                //    MessageBox.Show("Tài khoản hoặc mật khẩu không được để trống!");
                //}
            }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
