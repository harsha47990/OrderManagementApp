using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static OrderManagementApp.MasterPage;

namespace OrderManagementApp
{
    public partial class ProgressUserControl : UserControl, IRefreshable
    {

        List<string> StatusOptions = new List<string>();

        public ProgressUserControl()
        {
            InitializeComponent();
            InitializeDatagrid();
            GetStatusOptions("album.json");
        }

        private void GetStatusOptions(string OptionType)
        {
            string filePath = OptionType;// CodeConfig.ProcessOptionTypes;

            // Check if the file exists before reading
            if (File.Exists(filePath))
            {
                string[] lines = File.ReadAllLines(filePath);

                foreach (string line in lines)
                {
                    StatusOptions.Add(line); 
                }
            }
            else
            {
                MessageBox.Show("Create Process first");
            }
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

            DataGridViewProgressBarColumn colProgress = new DataGridViewProgressBarColumn();
            colProgress.HeaderText = "Progress";
            colProgress.DataPropertyName = "Progress";
            colProgress.ReadOnly = true;

            DataGridViewComboBoxColumn colOptions = new DataGridViewComboBoxColumn();
            colOptions.HeaderText = "Status";
            colOptions.DataPropertyName = "Status";
            colOptions.Name = "Status";
            //colOptions.Items.AddRange("print", "binding", "completed");
            colOptions.DataSource = StatusOptions;
            colOptions.AutoComplete = true;

           


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
            dataGridView1.Columns.Add(colProgress);
            dataGridView1.Columns.Add(colOptions);
            dataGridView1.Columns.Add(colUpdate);

            List<ProgressDataGridItems> dataItems = new List<ProgressDataGridItems>
            {
                new ProgressDataGridItems { OrderID = 1, Name = "Item 1",Description="Demo" ,Options = "print", Progress = 25, Status = "printing"},
                new ProgressDataGridItems { OrderID = 2, Name = "Item 2",Description="Demo" ,Options = "print",Progress = 75,Status = "printing" },
                new ProgressDataGridItems { OrderID = 3, Name = "Item 3",Description="Demo" , Options = "print",Progress = 50,Status = "printing" },
                // Add more data items as needed
                new ProgressDataGridItems { OrderID = 1, Name = "Item 1",Description="Demo" ,Options = "print", Progress = 25, Status = "printing"},
                new ProgressDataGridItems { OrderID = 2, Name = "Item 2",Description="Demo" ,Options = "print",Progress = 75,Status = "printing" },
                new ProgressDataGridItems { OrderID = 3, Name = "Item 3",Description="Demo" , Options = "print",Progress = 50,Status = "printing" },

                new ProgressDataGridItems { OrderID = 1, Name = "Item 1",Description="Demo" ,Options = "print", Progress = 25, Status = "printing"},
                new ProgressDataGridItems { OrderID = 2, Name = "Item 2",Description="Demo" ,Options = "print",Progress = 75,Status = "printing" },
                new ProgressDataGridItems { OrderID = 3, Name = "Item 3",Description="Demo" , Options = "print",Progress = 50,Status = "printing" },

                new ProgressDataGridItems { OrderID = 1, Name = "Item 1",Description="Demo" ,Options = "print", Progress = 25, Status = "printing"},
                new ProgressDataGridItems { OrderID = 2, Name = "Item 2",Description="Demo" ,Options = "print",Progress = 75,Status = "printing" },
                new ProgressDataGridItems { OrderID = 3, Name = "Item 3",Description="Demo" , Options = "print",Progress = 50,Status = "printing" },

                new ProgressDataGridItems { OrderID = 1, Name = "Item 1",Description="Demo" ,Options = "print", Progress = 25, Status = "printing"},
                new ProgressDataGridItems { OrderID = 2, Name = "Item 2",Description="Demo" ,Options = "print",Progress = 75,Status = "printing" },
                new ProgressDataGridItems { OrderID = 3, Name = "Item 3",Description="Demo" , Options = "print",Progress = 50,Status = "printing" },

                new ProgressDataGridItems { OrderID = 1, Name = "Item 1",Description="Demo" ,Options = "print", Progress = 25, Status = "printing"},
                new ProgressDataGridItems { OrderID = 2, Name = "Item 2",Description="Demo" ,Options = "print",Progress = 75,Status = "printing" },
                new ProgressDataGridItems { OrderID = 3, Name = "Item 3",Description="Demo" , Options = "print",Progress = 50,Status = "printing" },
                new ProgressDataGridItems { OrderID = 1, Name = "Item 1",Description="Demo" ,Options = "print", Progress = 25, Status = "printing"},
                new ProgressDataGridItems { OrderID = 2, Name = "Item 2",Description="Demo" ,Options = "print",Progress = 75,Status = "printing" },
                new ProgressDataGridItems { OrderID = 3, Name = "Item 3",Description="Demo" , Options = "print",Progress = 50,Status = "printing" },



            };
            dataGridView1.DataSource = dataItems;

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dataGridView1.Columns.Count - 1)
            {
                DataGridViewButtonCell buttonCell = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex] as DataGridViewButtonCell;

                if (buttonCell != null && buttonCell.Value.ToString() == "Update")
                {
                    // Get the selected values  
                    int rowID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["OrderID"].Value);
                    string selectedOption = dataGridView1.Rows[e.RowIndex].Cells["Status"].Value.ToString();

                    // Perform update logic here
                    // For demonstration, we just show a message
                    MessageBox.Show($"Updating Row ID: {rowID} with Option: {selectedOption}");
                }
            }
        }

        public void RefreshData()
        {
           
        }

    }


    // Custom DataGridViewColumn for ProgressBar
    public class DataGridViewProgressBarColumn : DataGridViewColumn
    {
        public DataGridViewProgressBarColumn()
        {
            this.CellTemplate = new DataGridViewProgressBarCell();
        }
    }


    // Custom DataGridViewCell for ProgressBar
    public class DataGridViewProgressBarCell : DataGridViewTextBoxCell
    {
        protected override void Paint(Graphics graphics, Rectangle clipBounds, Rectangle cellBounds, int rowIndex, DataGridViewElementStates cellState, object value, object formattedValue, string errorText, DataGridViewCellStyle cellStyle, DataGridViewAdvancedBorderStyle advancedBorderStyle, DataGridViewPaintParts paintParts)
        {
            if (value != null && value is int progressValue)
            {
                // Calculate the ProgressBar width based on the progress percentage
                int progressBarWidth = (int)Math.Round((double)(cellBounds.Width - 6) * progressValue / 100);

                // Draw the green ProgressBar
                Rectangle progressBarBounds = new Rectangle(cellBounds.X + 3, cellBounds.Y + 3, progressBarWidth, cellBounds.Height - 6);
                graphics.FillRectangle(Brushes.LightGreen, progressBarBounds);

                // Draw the ProgressBar border
                graphics.DrawRectangle(Pens.Black, cellBounds.X + 2, cellBounds.Y + 2, cellBounds.Width - 5, cellBounds.Height - 5);

                // Draw the percentage text
                string progressText = progressValue.ToString() + "%";
                SizeF textSize = graphics.MeasureString(progressText, cellStyle.Font);
                Point textLocation = new Point(cellBounds.X + (cellBounds.Width - (int)textSize.Width) / 2, cellBounds.Y + (cellBounds.Height - (int)textSize.Height) / 2);
                graphics.DrawString(progressText, cellStyle.Font, Brushes.Black, textLocation);
            }
            else
            {
                base.Paint(graphics, clipBounds, cellBounds, rowIndex, cellState, value, formattedValue, errorText, cellStyle, advancedBorderStyle, paintParts);
            }
        }
    }

  

}
