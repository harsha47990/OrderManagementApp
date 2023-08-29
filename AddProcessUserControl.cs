using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text.Json;
using System.Windows.Forms;
using static OrderManagementApp.Login;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace OrderManagementApp
{
    public partial class AddProcessUserControl : UserControl
    {
        private List<string> ProcessNames = new List<string>();
        Dictionary<string, List<string>> ProcessSteps = new Dictionary<string, List<string>>();
        DataTable stepsTable = new DataTable();
        Boolean EditProcess = false;
        public AddProcessUserControl()
        {
            InitializeComponent();

            // Set the UserControl to dock as Fill and set the background color to white
            Dock = DockStyle.Fill;
            BackColor = Color.White;
            InitializeDataGridView();
            stepsTable.Columns.Add("Steps", typeof(string));

        }

        private void InitializeDataGridView()
        {

            dataGridViewSteps.AutoGenerateColumns = false;
            dataGridViewSteps.ScrollBars = ScrollBars.Both;
            dataGridViewSteps.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Create DataGridView columns
            DataGridViewTextBoxColumn steps = new DataGridViewTextBoxColumn();
            steps.HeaderText = "Steps";
            steps.DataPropertyName = "Steps";
            steps.Name = "Steps";
            steps.ReadOnly = false;
            // Create Delete button column
            DataGridViewButtonColumn deleteButtonColumn = new DataGridViewButtonColumn
            {
                Name = "DeleteButton",
                HeaderText = "Delete",
                UseColumnTextForButtonValue = true,
                Text = "Delete",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            };

            dataGridViewSteps.Columns.Add(steps);
            dataGridViewSteps.Columns.Add(deleteButtonColumn);

            dataGridViewSteps.ReadOnly = false;
            dataGridViewSteps.AllowUserToDeleteRows = true;

            dataGridViewSteps.EditMode = DataGridViewEditMode.EditOnKeystrokeOrF2;

            dataGridViewSteps.RowsDefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridViewSteps.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;


        }
        private void AssignValuesToDataGridView(List<string> steps)
        {
            stepsTable.Clear();
            foreach (string step in steps)
            {
                stepsTable.Rows.Add(step);
            }
            dataGridViewSteps.DataSource = stepsTable;
        }
        private void ReadProcesses()
        {
            List<ProcessClass> processes = Utils.ReadProcesses();
            if (processes != null)
            {
                foreach (ProcessClass process in processes)
                {
                    ProcessNames.Add(process.Name);
                    ProcessSteps.Add(process.Name, process.Steps);
                }
                combobox_processes.DataSource = null;
                combobox_processes.DataSource = ProcessNames;
                combobox_processes.SelectedIndex = 0;

            }
            else
            {
                MessageBox.Show("Create Process first");
            }
        }
        private void ProcessManagementUserControl_Load(object sender, EventArgs e)
        {  ReadProcesses(); }

        private void btnEditProcess_Click(object sender, EventArgs e)
        {
            txtProcessName.Text = combobox_processes.SelectedItem.ToString();
            if (ProcessSteps.ContainsKey(txtProcessName.Text))
            {
                txtProcessName.Enabled = false;
                AssignValuesToDataGridView(ProcessSteps[txtProcessName.Text]);
                EditProcess = true;
                dataGridViewSteps.BeginEdit(true);
            }

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Handle the delete button click event
            if (e.RowIndex >= 0 && e.ColumnIndex == dataGridViewSteps.Columns["DeleteButton"].Index)
            {
                string step_name = dataGridViewSteps.Rows[e.RowIndex].Cells["Steps"].Value.ToString();
                ProcessSteps[txtProcessName.Text].Remove(step_name);
                AssignValuesToDataGridView(ProcessSteps[txtProcessName.Text]);
            }
        }

        private void btnAddStep_Click(object sender, EventArgs e)
        {
            if (ProcessNames.Contains(txtProcessName.Text) && EditProcess == false)
            {
                MessageBox.Show(string.Format(String.Format("{0} process already exists", txtProcessName.Text)));
                return;
            }
            if (!string.IsNullOrWhiteSpace(txtProcessName.Text) && !string.IsNullOrWhiteSpace(txtSteps.Text))
            {
                if (!ProcessSteps.ContainsKey(txtProcessName.Text))
                {
                    ProcessSteps[txtProcessName.Text] = new List<string>();
                }
                ProcessSteps[txtProcessName.Text].Add(txtSteps.Text);
                txtSteps.Clear();

                AssignValuesToDataGridView(ProcessSteps[txtProcessName.Text]);
            }
            else
            {
                MessageBox.Show("Please enter both process name and steps.");
            }
        }

        private void ClearAllAndRefresh()
        {
            EditProcess = false;
            txtSteps.Clear();
            txtProcessName.Clear();
            txtProcessName.Enabled = true;
            stepsTable.Clear();
            ProcessNames.Clear();
            ProcessSteps.Clear();
            ReadProcesses();
        }

        private void EditSaveData()
        {
            List<string> columnValues = new List<string>();

            // Get the column index based on the column name
            int columnIndex = dataGridViewSteps.Columns["Steps"].Index;

            // Loop through the rows and get the values of the specific column
            foreach (DataGridViewRow row in dataGridViewSteps.Rows)
            {
                if (!row.IsNewRow) // Exclude the new row, if present
                {
                    string cellValue = row.Cells[columnIndex].Value?.ToString();
                    columnValues.Add(cellValue);
                }
            }
            ProcessSteps[txtProcessName.Text] = columnValues;
            AssignValuesToDataGridView(ProcessSteps[txtProcessName.Text]);
        }

        private void SaveData()
        {
            if(EditProcess) { EditSaveData(); }

            List<ProcessClass> SaveProcesses = new List<ProcessClass>();

            foreach (var process in ProcessSteps)
            {
                SaveProcesses.Add(new ProcessClass(process.Key, process.Value));
            }

            string Data = JsonSerializer.Serialize<List<ProcessClass>>(SaveProcesses);
            File.WriteAllText(CodeConfig.process_json_path, Data);
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveData();
            ClearAllAndRefresh();
            if (EditProcess)
            {
                EditProcess = true;
            }
            MessageBox.Show("Process Saved, Successfully");
           

        }

        private void btn_deleteProcess_Click(object sender, EventArgs e)
        {
            if (ProcessSteps.ContainsKey(txtProcessName.Text))
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this item?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    ProcessNames.Remove(txtProcessName.Text);
                    ProcessSteps.Remove(txtProcessName.Text);
                    SaveData();
                    MessageBox.Show("Item deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // User clicked "Cancel" or closed the message box
                    MessageBox.Show("Delete operation canceled.", "Canceled", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                ClearAllAndRefresh();
            }
        }

        private void btn_new_process_Click(object sender, EventArgs e)
        {
            ClearAllAndRefresh();
        }

        private void txtSteps_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btnAddStep.PerformClick();
            }
        }
    }

   
       
}
