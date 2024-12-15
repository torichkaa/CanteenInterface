using System;
using System.Windows.Forms;

namespace CanteenInterface
{
    public partial class NewFeedbackForm : Form
    {
        public Feedback Feedback { get; private set; }

        public NewFeedbackForm()
        {
            InitializeComponent();
            dateTimePickerDate.Value = DateTime.Now;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            Feedback = new Feedback
            {
                SubmittedBy = textBoxSubmittedBy.Text,
                Content = textBoxContent.Text,
                SubmissionDate = dateTimePickerDate.Value.Date
            };

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