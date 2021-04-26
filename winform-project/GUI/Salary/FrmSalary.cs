using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winform_project.GUI.Salary
{
    public partial class FrmSalary : Form
    {
        private TimekeepingDataContext tdc = new TimekeepingDataContext();
        public int EmployeeId { get; set; }
        public FrmSalary(int employeeId)
        {
            EmployeeId = employeeId;
            InitializeComponent();
        }
    }
}
