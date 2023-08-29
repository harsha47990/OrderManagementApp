namespace OrderManagementApp
{
    partial class CustomDataGridViewUserControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.customdatagrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.customdatagrid)).BeginInit();
            this.SuspendLayout();
            // 
            // customdatagrid
            // 
            this.customdatagrid.AllowUserToAddRows = false;
            this.customdatagrid.AllowUserToDeleteRows = false;
            this.customdatagrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.customdatagrid.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.customdatagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customdatagrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customdatagrid.GridColor = System.Drawing.SystemColors.Control;
            this.customdatagrid.Location = new System.Drawing.Point(0, 0);
            this.customdatagrid.MultiSelect = false;
            this.customdatagrid.Name = "customdatagrid";
            this.customdatagrid.ReadOnly = true;
            this.customdatagrid.RowHeadersWidth = 62;
            this.customdatagrid.RowTemplate.Height = 28;
            this.customdatagrid.Size = new System.Drawing.Size(1108, 416);
            this.customdatagrid.TabIndex = 0;
            this.customdatagrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.customdatagrid_CellClick);
            // 
            // CustomDataGridViewUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Controls.Add(this.customdatagrid);
            this.Name = "CustomDataGridViewUserControl";
            this.Size = new System.Drawing.Size(1108, 416);
            ((System.ComponentModel.ISupportInitialize)(this.customdatagrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView customdatagrid;
    }
}
