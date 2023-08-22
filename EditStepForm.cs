using System;
using System.Windows.Forms;

namespace OrderManagementApp
{
    public partial class EditStepForm : Form
    {
        public string ProcessName { get; private set; }
        public string StepName { get; private set; }

        public EditStepForm(string currentProcessName, string currentStepName)
        {
            InitializeComponent();

            // Set the TextBoxes with the current values
            txtProcessName.Text = currentProcessName;
            txtStepName.Text = currentStepName;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Get the edited process name and step name from the TextBoxes
            ProcessName = txtProcessName.Text;
            StepName = txtStepName.Text;

            // Validate if the inputs are not empty
            if (string.IsNullOrWhiteSpace(ProcessName) || string.IsNullOrWhiteSpace(StepName))
            {
                MessageBox.Show("Please enter both process name and step name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Close the form with DialogResult OK to indicate successful editing
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
