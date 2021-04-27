using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winform_project.GUI.Position
{
    public partial class FrmPositionList : Form
    {
        private TimekeepingDataContext tdc = new TimekeepingDataContext();
        public winform_project.Employee Employee { get; set; }
        public FrmPositionList(winform_project.Employee employee)
        {
            Employee = employee;
            InitializeComponent();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            var search = txtSearch.Text.Trim();
            if (search != "")
            {
                dgvPosition.DataSource = from pos in tdc.Positions
                                         where pos.name.Contains(search) || pos.basic_salary.ToString().Contains(search)
                                         select new
                                         {
                                             PositionId = pos.position_id,
                                             PositionName = pos.name,
                                             BasicSalary = pos.basic_salary
                                         };
            }
            else
            {
                loadPositions();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {

        }

        private void btnAddPosition_Click(object sender, EventArgs e)
        {
            FrmPositionDetail frmPositionDetail = new FrmPositionDetail(null);
            frmPositionDetail.ShowDialog();
            loadPositions();
        }

        private void FrmPositionList_Load(object sender, EventArgs e)
        {
            loadPositions();
        }

        private void loadPositions()
        {
            dgvPosition.DataSource = from pos in tdc.Positions
                                     select new
                                     {
                                         PositionId = pos.position_id,
                                         PositionName = pos.name,
                                         BasicSalary = pos.basic_salary
                                     };
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (dgvPosition.CurrentRow != null)
            {
                int EmployeeId = (int)dgvPosition.CurrentRow.Cells["PositionId"].Value;
                FrmPositionDetail frmPositionDetail = new FrmPositionDetail(EmployeeId);
                frmPositionDetail.ShowDialog(this);

                loadPositions();
            }
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            if (dgvPosition.CurrentRow != null)
            {
                int EmployeeId = (int)dgvPosition.CurrentRow.Cells["PositionId"].Value;
                bool? result = null;
                string message = "";

                DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn chức vụ: " + dgvPosition.CurrentRow.Cells["PositionName"].Value, "Xóa chức vụ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    tdc.sp_deletePosition(EmployeeId, ref result, ref message);

                    if (result == false)
                    {
                        MessageBox.Show(message, "Có lỗi xảy ra", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    } else
                    {
                        MessageBox.Show(message, "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    loadPositions();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn chức vụ để xóa!", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void btnAddPosition_Click_1(object sender, EventArgs e)
        {
            FrmPositionDetail frmPositionDetail = new FrmPositionDetail(null);
            frmPositionDetail.ShowDialog();
            loadPositions();
        }

        private void btnRefresh_Click_1(object sender, EventArgs e)
        {
            loadPositions();
        }
    }
}
