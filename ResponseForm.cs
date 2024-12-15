using System;
using System.Windows.Forms;

namespace CanteenInterface
{
    public partial class ResponseForm : Form
    {
        public string ResponseText { get; private set; }

        public ResponseForm()
        {
            InitializeComponent();
        }

        public ResponseForm(Feedback feedback) : this()
        {
            textBoxResponse.Text = feedback.Response;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            ResponseText = textBoxResponse.Text;
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