using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace OrderManagementApp
{
    public partial class Form1 : Form
    {
        private List<ProcessStep> processSteps = new List<ProcessStep>();
        private int selectedRowIndex = -1;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Initialize the DataGridView with the necessary columns
            dataGridView1.Columns.Add("ProcessName", "Process Name");
            dataGridView1.Columns.Add("Step", "Step");
            dataGridView1.Columns.Add("Progress", "Progress");

            // Set the DataGridView to allow row reordering (drag-and-drop)
            dataGridView1.AllowUserToOrderColumns = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.EnableHeadersVisualStyles = false;

            // Enable full row selection for easier drag-and-drop
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // Disable sorting for better drag-and-drop experience
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }

        private void btnAddStep_Click(object sender, EventArgs e)
        {
            // Get the process name and step input from the TextBoxes
            string processName = txtProcessName.Text;
            string step = txtStep.Text;

            // Check if both inputs are not empty
            if (!string.IsNullOrWhiteSpace(processName) && !string.IsNullOrWhiteSpace(step))
            {
                // Add the process name and step to the processSteps list
                processSteps.Add(new ProcessStep(processName, step));

                // Update the DataGridView
                UpdateDataGridView();

                // Clear the TextBoxes for new input
                txtProcessName.Clear();
                txtStep.Clear();
            }
        }

        private void btnEditStep_Click(object sender, EventArgs e)
        {
            // Check if a row is selected
            if (selectedRowIndex >= 0 && selectedRowIndex < processSteps.Count)
            {
                // Get the selected process step
                ProcessStep selectedStep = processSteps[selectedRowIndex];

                // Open the EditStepForm to modify the step
                using (EditStepForm editStepForm = new EditStepForm(selectedStep.ProcessName, selectedStep.StepName))
                {
                    if (editStepForm.ShowDialog() == DialogResult.OK)
                    {
                        // Update the process step with the edited values
                        selectedStep.ProcessName = editStepForm.ProcessName;
                        selectedStep.StepName = editStepForm.StepName;

                        // Update the DataGridView
                        UpdateDataGridView();
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a step to edit.");
            }
        }

        private void dataGridView1_MouseMove(object sender, MouseEventArgs e)
        {
            // Start the drag-and-drop operation when the mouse is moved with the left button pressed
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left && dataGridView1.SelectedRows.Count > 0)
            {
                // Get the selected row and its bounds
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                Rectangle rowBounds = dataGridView1.GetRowDisplayRectangle(selectedRow.Index, false);

                // Check if the mouse is within the row bounds
                if (rowBounds.Contains(e.Location))
                {
                    // Initiate the drag-and-drop operation with the selected row
                    dataGridView1.DoDragDrop(selectedRow, DragDropEffects.Move);
                }
            }
        }

        private void btnDeleteStep_Click(object sender, EventArgs e)
        {
            // Check if a row is selected
            if (selectedRowIndex >= 0 && selectedRowIndex < processSteps.Count)
            {
                // Remove the selected step from the processSteps list
                processSteps.RemoveAt(selectedRowIndex);

                // Update the DataGridView
                UpdateDataGridView();
            }
            else
            {
                MessageBox.Show("Please select a step to delete.");
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            // Get the selected row index
            if (dataGridView1.SelectedRows.Count > 0)
            {
                selectedRowIndex = dataGridView1.SelectedRows[0].Index;
            }
            else
            {
                selectedRowIndex = -1;
            }
        }

        private void dataGridView1_DragEnter(object sender, DragEventArgs e)
        {
            // Allow moving the row when dragging over the DataGridView
            e.Effect = DragDropEffects.Move;
        }

        private void dataGridView1_DragDrop(object sender, DragEventArgs e)
        {
            // Get the target row index
            Point clientPoint = dataGridView1.PointToClient(new Point(e.X, e.Y));
            DataGridView.HitTestInfo hitTestInfo = dataGridView1.HitTest(clientPoint.X, clientPoint.Y);
            int targetRowIndex = hitTestInfo.RowIndex;

            // Check if the target row is valid and not the same as the source row
            if (targetRowIndex >= 0 && targetRowIndex < dataGridView1.Rows.Count)
            {
                // Get the selected row and the target row
                DataGridViewRow selectedRow = e.Data.GetData(typeof(DataGridViewRow)) as DataGridViewRow;
                DataGridViewRow targetRow = dataGridView1.Rows[targetRowIndex];

                // Move the selected row to the target row index
                dataGridView1.Rows.Remove(selectedRow);
                dataGridView1.Rows.Insert(targetRowIndex, selectedRow);

                // Update the processSteps list to reflect the new order
                processSteps.RemoveAt(selectedRow.Index);
                processSteps.Insert(targetRowIndex, selectedRow.DataBoundItem as ProcessStep);
            }
        }

        private void UpdateDataGridView()
        {
            // Clear existing rows
            dataGridView1.Rows.Clear();

            // Populate DataGridView with process steps
            foreach (ProcessStep step in processSteps)
            {
                dataGridView1.Rows.Add(step.ProcessName, step.StepName, 0);
            }
        }
    }

    // Class to represent a process step
    public class ProcessStep
    {
        public string ProcessName { get; set; }
        public string StepName { get; set; }

        public ProcessStep(string processName, string stepName)
        {
            ProcessName = processName;
            StepName = stepName;
        }
    }
}
