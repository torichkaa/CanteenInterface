using System;
using System.Windows.Forms;

namespace CanteenInterface
{
    public partial class StaffDetailsForm : Form
    {
        public CafeteriaStaff Staff { get; private set; }

        public StaffDetailsForm()
        {
            InitializeComponent();
            comboBoxRole.SelectedIndex = 0;
        }

        public StaffDetailsForm(CafeteriaStaff staff) : this()
        {
            Staff = staff;
            textBoxFirstName.Text = Staff.FirstName;
            textBoxLastName.Text = Staff.LastName;
            comboBoxRole.SelectedItem = Staff.Role;
            textBoxPhone.Text = Staff.Phone;
            textBoxEmail.Text = Staff.Email;
            dateTimePickerHireDate.Value = Staff.HireDate;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (Staff == null)
                Staff = new CafeteriaStaff();

            Staff.FirstName = textBoxFirstName.Text;
            Staff.LastName = textBoxLastName.Text;
            Staff.Role = comboBoxRole.SelectedItem.ToString();
            Staff.Phone = textBoxPhone.Text;
            Staff.Email = textBoxEmail.Text;
            Staff.HireDate = dateTimePickerHireDate.Value.Date;

            DialogResult = DialogResult.OK;
            Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}