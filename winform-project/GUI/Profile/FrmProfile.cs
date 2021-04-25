using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winform_project.GUI.Profile
{
    public partial class FrmProfile : Form
    {
        static TimekeepingDataContext tdc = new TimekeepingDataContext();
        public winform_project.Employee Employee { get; set; }
        public FrmProfile(winform_project.Employee employee)
        {
            Employee = employee;
            InitializeComponent();
        }
    }
}
