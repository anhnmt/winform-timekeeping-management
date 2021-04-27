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
    public partial class FrmPositionDetail : Form
    {
        private TimekeepingDataContext tdc = new TimekeepingDataContext();
        public int? PositionId { get; set; }
        public FrmPositionDetail(int? positionId)
        {
            PositionId = positionId;
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            winform_project.Position Position = new winform_project.Position();
            Position.name = txtName.TextContent;
            Position.basic_salary = Convert.ToDouble(txtSalary.TextContent);
            bool? result = null;
            string message = "";

            if (PositionId != null)
            {
                tdc.sp_updatePosition(PositionId, Position.name, Position.basic_salary, ref result, ref message);

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
            else
            {
                tdc.sp_createPosition(Position.name, Position.basic_salary, ref result, ref message);

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

        private void FrmPositionDetail_Load(object sender, EventArgs e)
        {
            txtName.TextContent = "";
            txtSalary.TextContent = "";

            if (PositionId != null)
            {
                this.Text = "Sửa đổi nhân viên";
                btnSave.Text = "Sửa";

                var Position = tdc.Positions.FirstOrDefault(x => x.position_id == PositionId);

                if (Position != null)
                {
                    //pbEmpPicture.Image = Image.FromStream(new MemoryStream(Employee.avatar.ToArray()));

                    txtName.TextContent = Position.name.ToString();
                    txtSalary.TextContent = Position.basic_salary.ToString();
                }
            } else
            {
                this.Text = "Thêm nhân viên";
                btnSave.Text = "Thêm";
            }
        }
    }
}
