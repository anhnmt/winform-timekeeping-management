using System;
using System.ComponentModel;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace winform_project.Validates
{
    public partial class TextboxValidate : UserControl
    {
        public string PasswordChar { get; set; }
        public string FieldName { get; set; }
        public int MinLength { get; set; }
        public int MaxLength { get; set; }
        public string Pattern { get; set; }

        public TextboxValidate()
        {
            InitializeComponent();
            if (!String.IsNullOrEmpty(PasswordChar))
            {
                txtField.PasswordChar = '•';
            }
        }

        private void txtField_Validating(object sender, CancelEventArgs e)
        {
            lblError.Text = "";
            var text = txtField.Text.Trim();

            // Validate Null or Empty 
            if (String.IsNullOrEmpty(text))
            {
                lblError.Text = $"{FieldName} không được để trống!";
                e.Cancel = true;
                return;
            }

            // Validate MinLenght
            if (MinLength != 0)
            {
                lblError.Text = $"{FieldName} không phải nhỏ hơn {MinLength}!";
                e.Cancel = true;
                return;
            }

            // Validate MaxLenght
            if (MaxLength != 0)
            {
                lblError.Text = $"{FieldName} không phải lớn hơn {MaxLength}!";
                e.Cancel = true;
                return;
            }

            // Validate Regex
            if (!String.IsNullOrEmpty(Pattern) && !Regex.IsMatch(text, Pattern))
            {
                lblError.Text = $"{FieldName} không hợp lệ!";
                e.Cancel = true;
                return;
            }
        }
    }
}
