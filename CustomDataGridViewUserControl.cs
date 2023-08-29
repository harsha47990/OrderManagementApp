using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderManagementApp
{
    public partial class CustomDataGridViewUserControl : UserControl
    {
        public int SeletedRow { get; private set; }
        public int SeletedColumn { get; private set; }
        public bool Result = false;
        private DataTable dataTable = new DataTable();
        public CustomDataGridViewUserControl()
        {
            InitializeComponent();
           
        }

        public void LoadDataTable(DataTable dt)
        {
            dataTable = dt;
            customdatagrid.DataSource = dataTable;
        }

        private void customdatagrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0) // Ignore header clicks
            {
                SeletedRow = e.RowIndex;
                SeletedColumn = e.ColumnIndex;
                Result = true;
                this.ParentForm.Close();
            }
        }
    }
}
