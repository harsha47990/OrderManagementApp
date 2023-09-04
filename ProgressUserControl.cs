using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text.Json;
using System.Windows.Forms;
using System.Xml.Linq;
using static OrderManagementApp.MasterPage;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace OrderManagementApp
{
    public partial class ProgressUserControl : UserControl, IRefreshable
    {

        List<string> ProcessNames = new List<string>();
        List<ProcessClass> processes = new List<ProcessClass>();
        BindingList<string> StatusProcessSteps = new BindingList<string>();
        BindingList<string> FilterProcessSteps = new BindingList<string>();
        BindingList<ProgressDataGridItems> dataItems = new BindingList<ProgressDataGridItems>();
        public ProgressUserControl()
        {
            InitializeComponent();
            InitializeDatagrid();
            LoadNeccessaryData();
        }
        private void LoadNeccessaryData()
        {
            processes = Utils.ReadProcesses();
            ProcessNames = processes.Select(obj => obj.Name).ToList();
            combo_processes.DataSource = ProcessNames;
            combo_processes.SelectedIndex = 0;
            FilterProcessSteps.Clear();
            foreach (var step in processes.FirstOrDefault(obj => obj.Name == ProcessNames[0]).Steps)
            {
                FilterProcessSteps.Add(step);
            }
            ReadProcessProgress(ProcessNames[0], "all");

        }
     
        private void InitializeDatagrid()
        {
            // Set up DataGridView properties
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ScrollBars = ScrollBars.Both;

            // Create DataGridView columns
            DataGridViewTextBoxColumn colID = new DataGridViewTextBoxColumn();
            colID.HeaderText = "OrderID";
            colID.DataPropertyName = "OrderID";
            colID.Name = "OrderID";
            colID.ReadOnly = true;

            DataGridViewTextBoxColumn colName = new DataGridViewTextBoxColumn();
            colName.HeaderText = "Name";
            colName.DataPropertyName = "Name";
            colName.Name = "Name";      
            colName.ReadOnly = true;

            DataGridViewTextBoxColumn colDis = new DataGridViewTextBoxColumn();
            colDis.HeaderText = "Description";
            colDis.DataPropertyName = "Description";
            colDis.Name = "Description";
            colDis.ReadOnly = true;

            DataGridViewTextBoxColumn colProcessType = new DataGridViewTextBoxColumn();
            colProcessType.HeaderText = "Process Type";
            colProcessType.DataPropertyName = "Process_Type";
            colProcessType.ReadOnly = true;

            //DataGridViewProgressBarColumn colProgress = new DataGridViewProgressBarColumn();
            DataGridViewProgressColumn colProgress = new DataGridViewProgressColumn();
            colProgress.HeaderText = "Progress";
            colProgress.DataPropertyName = "Progress";
            colProgress.ReadOnly = true;

            DataGridViewComboBoxColumn colStatus = new DataGridViewComboBoxColumn();
            colStatus.HeaderText = "Status";
            colStatus.DataPropertyName = "Status";
            colStatus.Name = "Status";
            //colStatus.Items.AddRange("order placed","print", "binding", "completed");
            colStatus.DataSource = StatusProcessSteps;
            colStatus.AutoComplete = true;
          
            DataGridViewButtonColumn colUpdate = new DataGridViewButtonColumn();
            colUpdate.HeaderText = "Update";
            colUpdate.Text = "Update";
            colUpdate.UseColumnTextForButtonValue = true;
            colUpdate.DefaultCellStyle.BackColor = System.Drawing.Color.LightGreen;

            dataGridView1.RowTemplate.Height = 30;
            // Add columns to DataGridView
            dataGridView1.Columns.Add(colID);
            dataGridView1.Columns.Add(colName);
            dataGridView1.Columns.Add(colDis);
            dataGridView1.Columns.Add(colProcessType);
            dataGridView1.Columns.Add(colProgress);
            dataGridView1.Columns.Add(colStatus);
            dataGridView1.Columns.Add(colUpdate);
           
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dataGridView1.Columns.Count - 1)
            {
                DataGridViewButtonCell buttonCell = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex] as DataGridViewButtonCell;

                if (buttonCell != null && buttonCell.Value.ToString() == "Update")
                {
                    // Get the selected values  
                    string OrderId = dataGridView1.Rows[e.RowIndex].Cells["OrderID"].Value.ToString();
                    string selectedOption = dataGridView1.Rows[e.RowIndex].Cells["Status"].Value.ToString();

                    // Perform update logic here
                    // For demonstration, we just show a message
                    Utils.UpdateOrderStatus(OrderId, selectedOption); 
                    MessageBox.Show($"Order status update succesfull");
                    LoadNeccessaryData();
                }
                
            }
        }

        public void RefreshData()
        {
            LoadNeccessaryData();
        }

        private void combo_processes_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterProcessSteps.Clear();
            StatusProcessSteps.Clear();
            string processName = combo_processes.SelectedItem.ToString();
            foreach (var step in processes.FirstOrDefault(obj => obj.Name == processName).Steps)
            {
                FilterProcessSteps.Add(step);
                StatusProcessSteps.Add(step);
            }
            List<string> filter_list = new List<string>();
            filter_list = processes.Find(obj => obj.Name == processName).Steps;
            filter_list.Insert(0, "All");
            combo_filters.DataSource = filter_list;
            combo_filters.SelectedIndex = 0;

        }

        private void ReadProcessProgress(string processName,string StageName)
        {
            List<string> filtered_orders = new List<string>();
            if (StageName.ToLower() == "all")
            {
                StageName = string.Empty;
            }

            var OrderProcessData = Utils.ReadOrderProcessData();
            foreach (var order in OrderProcessData.Keys)
            {
                Tuple<string, string> values = OrderProcessData[order];
                if (values.Item1.Contains(processName) && values.Item2.Contains(StageName))
                {
                    filtered_orders.Add(order);
                }
            }
            DisplaySeletedOrders(filtered_orders);

        }

        private void DisplaySeletedOrders(List<string> orders)
        {
            dataItems.Clear();
            foreach (var order in orders)
            {
                string order_path = Path.Combine(CodeConfig.DataStorageFolder, CodeConfig.OrdersPath, order + ".json");
                if (File.Exists(order_path))
                {
                    string jsonString = File.ReadAllText(order_path);
                    Order order_item = JsonSerializer.Deserialize<Order>(jsonString);
                    //string name = s = String.Format("{}-{}", order_item.C);
                    var Customer = Utils.GetCustomerDataFromID(order_item.CustomerId);
                    string name = String.Format("{0}-{1}", Customer.Name, Customer.StudioName);
                    var all_stages = Utils.GetStagesOftheProcess(order_item.ProcessType);
                    string Current_Stage = order_item.StatusProgress.Last();
                    int progress_percent = (all_stages.IndexOf(Current_Stage) + 1) * 100 / all_stages.Count;
                    dataItems.Add(new ProgressDataGridItems { OrderID = order_item.ID, Name = name, Description = order_item.Comments, Process_Type = order_item.ProcessType, Progress = progress_percent, Status = Current_Stage });

                }
            }
            dataGridView1.DataSource = dataItems;
            //dataGridView1.Refresh();
        }

        private void btn_apply_filter_Click(object sender, EventArgs e)
        {
            ReadProcessProgress(combo_processes.SelectedItem.ToString(), combo_filters.SelectedItem.ToString());
        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show(e.Exception.ToString());
        }
    }


    // Custom DataGridViewColumn for ProgressBar
    public class DataGridViewProgressColumn : DataGridViewImageColumn
    {
        public DataGridViewProgressColumn()
        {
            CellTemplate = new DataGridViewProgressCell();
        }
    }
  
    // Custom DataGridViewCell for ProgressBar
    class DataGridViewProgressCell : DataGridViewImageCell
    {
        // Used to make custom cell consistent with a DataGridViewImageCell
        static Image emptyImage;
        static DataGridViewProgressCell()
        {
            emptyImage = new Bitmap(1, 1, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
        }
        public DataGridViewProgressCell()
        {
            this.ValueType = typeof(int);
        }
        // Method required to make the Progress Cell consistent with the default Image Cell. 
        // The default Image Cell assumes an Image as a value, although the value of the Progress Cell is an int.
        protected override object GetFormattedValue(object value,
                            int rowIndex, ref DataGridViewCellStyle cellStyle,
                            TypeConverter valueTypeConverter,
                            TypeConverter formattedValueTypeConverter,
                            DataGridViewDataErrorContexts context)
        {
            return emptyImage;
        }
        protected override void Paint(System.Drawing.Graphics g, System.Drawing.Rectangle clipBounds, System.Drawing.Rectangle cellBounds, int rowIndex, DataGridViewElementStates cellState, object value, object formattedValue, string errorText, DataGridViewCellStyle cellStyle, DataGridViewAdvancedBorderStyle advancedBorderStyle, DataGridViewPaintParts paintParts)
        {
            try
            {
                int progressVal = (int)value;
                float percentage = ((float)progressVal / 100.0f); // Need to convert to float before division; otherwise C# returns int which is 0 for anything but 100%.
                Brush backColorBrush = new SolidBrush(cellStyle.BackColor);
                Brush foreColorBrush = new SolidBrush(cellStyle.ForeColor);
                // Draws the cell grid
                base.Paint(g, clipBounds, cellBounds,
                 rowIndex, cellState, value, formattedValue, errorText,
                 cellStyle, advancedBorderStyle, (paintParts & ~DataGridViewPaintParts.ContentForeground));
                if (percentage > 0.0)
                {
                    // Draw the progress bar and the text
                    g.FillRectangle(new SolidBrush(Color.FromArgb(203, 235, 108)), cellBounds.X + 2, cellBounds.Y + 2, Convert.ToInt32((percentage * cellBounds.Width - 4)), cellBounds.Height - 4);
                    g.DrawString(progressVal.ToString() + "%", cellStyle.Font, foreColorBrush, cellBounds.X + (cellBounds.Width / 2) - 5, cellBounds.Y + 2);

                }
                else
                {
                    // draw the text
                    if (this.DataGridView.CurrentRow.Index == rowIndex)
                        g.DrawString(progressVal.ToString() + "%", cellStyle.Font, new SolidBrush(cellStyle.SelectionForeColor), cellBounds.X + 6, cellBounds.Y + 2);
                    else
                        g.DrawString(progressVal.ToString() + "%", cellStyle.Font, foreColorBrush, cellBounds.X + 6, cellBounds.Y + 2);
                }
            }
            catch (Exception e) { }

        }
    }

 
}
