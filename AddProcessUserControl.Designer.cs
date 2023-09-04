namespace OrderManagementApp
{
    partial class AddProcessUserControl
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
            this.btnSelectProcess = new System.Windows.Forms.Button();
            this.btnAddStep = new System.Windows.Forms.Button();
            this.lblProcessName = new System.Windows.Forms.Label();
            this.lblSteps = new System.Windows.Forms.Label();
            this.txtProcessName = new System.Windows.Forms.TextBox();
            this.txtSteps = new System.Windows.Forms.TextBox();
            this.combobox_processes = new System.Windows.Forms.ComboBox();
            this.dataGridViewSteps = new System.Windows.Forms.DataGridView();
            this.btnSave = new System.Windows.Forms.Button();
            this.btn_new_process = new System.Windows.Forms.Button();
            this.btn_deleteProcess = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSteps)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSelectProcess
            // 
            this.btnSelectProcess.BackColor = System.Drawing.SystemColors.Info;
            this.btnSelectProcess.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectProcess.Location = new System.Drawing.Point(497, 23);
            this.btnSelectProcess.Margin = new System.Windows.Forms.Padding(4);
            this.btnSelectProcess.Name = "btnSelectProcess";
            this.btnSelectProcess.Size = new System.Drawing.Size(194, 40);
            this.btnSelectProcess.TabIndex = 1;
            this.btnSelectProcess.Text = "Edit Process";
            this.btnSelectProcess.UseVisualStyleBackColor = false;
            this.btnSelectProcess.Click += new System.EventHandler(this.btnEditProcess_Click);
            // 
            // btnAddStep
            // 
            this.btnAddStep.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddStep.Location = new System.Drawing.Point(328, 293);
            this.btnAddStep.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddStep.Name = "btnAddStep";
            this.btnAddStep.Size = new System.Drawing.Size(129, 40);
            this.btnAddStep.TabIndex = 2;
            this.btnAddStep.Text = "Add Step";
            this.btnAddStep.UseVisualStyleBackColor = true;
            this.btnAddStep.Click += new System.EventHandler(this.btnAddStep_Click);
            // 
            // lblProcessName
            // 
            this.lblProcessName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblProcessName.AutoSize = true;
            this.lblProcessName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProcessName.Location = new System.Drawing.Point(47, 177);
            this.lblProcessName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProcessName.Name = "lblProcessName";
            this.lblProcessName.Size = new System.Drawing.Size(146, 25);
            this.lblProcessName.TabIndex = 3;
            this.lblProcessName.Text = "Process Name:";
            // 
            // lblSteps
            // 
            this.lblSteps.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblSteps.AutoSize = true;
            this.lblSteps.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSteps.Location = new System.Drawing.Point(124, 236);
            this.lblSteps.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSteps.Name = "lblSteps";
            this.lblSteps.Size = new System.Drawing.Size(69, 25);
            this.lblSteps.TabIndex = 4;
            this.lblSteps.Text = "Steps:";
            // 
            // txtProcessName
            // 
            this.txtProcessName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtProcessName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProcessName.Location = new System.Drawing.Point(201, 174);
            this.txtProcessName.Margin = new System.Windows.Forms.Padding(4);
            this.txtProcessName.Name = "txtProcessName";
            this.txtProcessName.Size = new System.Drawing.Size(256, 30);
            this.txtProcessName.TabIndex = 5;
            // 
            // txtSteps
            // 
            this.txtSteps.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtSteps.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSteps.Location = new System.Drawing.Point(201, 231);
            this.txtSteps.Margin = new System.Windows.Forms.Padding(4);
            this.txtSteps.Name = "txtSteps";
            this.txtSteps.Size = new System.Drawing.Size(256, 30);
            this.txtSteps.TabIndex = 6;
            this.txtSteps.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSteps_KeyDown);
            // 
            // combobox_processes
            // 
            this.combobox_processes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combobox_processes.FormattingEnabled = true;
            this.combobox_processes.Location = new System.Drawing.Point(137, 26);
            this.combobox_processes.Name = "combobox_processes";
            this.combobox_processes.Size = new System.Drawing.Size(308, 37);
            this.combobox_processes.TabIndex = 7;
            // 
            // dataGridViewSteps
            // 
            this.dataGridViewSteps.AllowUserToAddRows = false;
            this.dataGridViewSteps.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridViewSteps.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSteps.Location = new System.Drawing.Point(509, 113);
            this.dataGridViewSteps.MultiSelect = false;
            this.dataGridViewSteps.Name = "dataGridViewSteps";
            this.dataGridViewSteps.RowHeadersWidth = 62;
            this.dataGridViewSteps.RowTemplate.Height = 28;
            this.dataGridViewSteps.Size = new System.Drawing.Size(401, 427);
            this.dataGridViewSteps.TabIndex = 8;
            this.dataGridViewSteps.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(177, 293);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(129, 40);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btn_new_process
            // 
            this.btn_new_process.BackColor = System.Drawing.SystemColors.Info;
            this.btn_new_process.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_new_process.Location = new System.Drawing.Point(251, 363);
            this.btn_new_process.Margin = new System.Windows.Forms.Padding(4);
            this.btn_new_process.Name = "btn_new_process";
            this.btn_new_process.Size = new System.Drawing.Size(194, 40);
            this.btn_new_process.TabIndex = 10;
            this.btn_new_process.Text = "Clear All";
            this.btn_new_process.UseVisualStyleBackColor = false;
            this.btn_new_process.Click += new System.EventHandler(this.btn_new_process_Click);
            // 
            // btn_deleteProcess
            // 
            this.btn_deleteProcess.BackColor = System.Drawing.SystemColors.Info;
            this.btn_deleteProcess.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_deleteProcess.Location = new System.Drawing.Point(709, 23);
            this.btn_deleteProcess.Margin = new System.Windows.Forms.Padding(4);
            this.btn_deleteProcess.Name = "btn_deleteProcess";
            this.btn_deleteProcess.Size = new System.Drawing.Size(194, 40);
            this.btn_deleteProcess.TabIndex = 11;
            this.btn_deleteProcess.Text = "Delete Process";
            this.btn_deleteProcess.UseVisualStyleBackColor = false;
            this.btn_deleteProcess.Click += new System.EventHandler(this.btn_deleteProcess_Click);
            // 
            // AddProcessUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.btn_deleteProcess);
            this.Controls.Add(this.btn_new_process);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dataGridViewSteps);
            this.Controls.Add(this.combobox_processes);
            this.Controls.Add(this.txtSteps);
            this.Controls.Add(this.txtProcessName);
            this.Controls.Add(this.lblSteps);
            this.Controls.Add(this.lblProcessName);
            this.Controls.Add(this.btnAddStep);
            this.Controls.Add(this.btnSelectProcess);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddProcessUserControl";
            this.Size = new System.Drawing.Size(970, 587);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSteps)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSelectProcess;
        private System.Windows.Forms.Button btnAddStep;
        private System.Windows.Forms.Label lblProcessName;
        private System.Windows.Forms.Label lblSteps;
        private System.Windows.Forms.TextBox txtProcessName;
        private System.Windows.Forms.TextBox txtSteps;
        private System.Windows.Forms.ComboBox combobox_processes;
        private System.Windows.Forms.DataGridView dataGridViewSteps;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btn_new_process;
        private System.Windows.Forms.Button btn_deleteProcess;
    }
}
