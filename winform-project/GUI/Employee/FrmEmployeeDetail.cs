﻿using System;
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
        public winform_project.Employee Employee { get; set; }
        public FrmEmployeeDetail(winform_project.Employee employee)
        {
            Employee = employee;
            InitializeComponent();
        }
    }
}
