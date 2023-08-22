namespace OrderManagementApp
{
    partial class OrderPlacingControl
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
            this.textBoxCustomerName = new System.Windows.Forms.TextBox();
            this.comboBoxAvailableItems = new System.Windows.Forms.ComboBox();
            this.labelCustomerName = new System.Windows.Forms.Label();
            this.labelAvailableItems = new System.Windows.Forms.Label();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.labelPrice = new System.Windows.Forms.Label();
            this.numericUpDownQuantity = new System.Windows.Forms.NumericUpDown();
            this.labelQuantity = new System.Windows.Forms.Label();
            this.buttonAddToOrder = new System.Windows.Forms.Button();
            this.dataGridViewOrderItems = new System.Windows.Forms.DataGridView();
            this.buttonSaveOrder = new System.Windows.Forms.Button();
            this.txt_comments = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.combobox_process_type = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_total_amount = new System.Windows.Forms.RichTextBox();
            this.txtAvailableItems = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrderItems)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxCustomerName
            // 
            this.textBoxCustomerName.Location = new System.Drawing.Point(211, 54);
            this.textBoxCustomerName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxCustomerName.Name = "textBoxCustomerName";
            this.textBoxCustomerName.Size = new System.Drawing.Size(297, 30);
            this.textBoxCustomerName.TabIndex = 0;
            // 
            // comboBoxAvailableItems
            // 
            this.comboBoxAvailableItems.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAvailableItems.FormattingEnabled = true;
            this.comboBoxAvailableItems.Location = new System.Drawing.Point(747, 239);
            this.comboBoxAvailableItems.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxAvailableItems.Name = "comboBoxAvailableItems";
            this.comboBoxAvailableItems.Size = new System.Drawing.Size(297, 33);
            this.comboBoxAvailableItems.TabIndex = 1;
            this.comboBoxAvailableItems.Visible = false;
            this.comboBoxAvailableItems.SelectedIndexChanged += new System.EventHandler(this.comboBoxAvailableItems_SelectedIndexChanged);
            // 
            // labelCustomerName
            // 
            this.labelCustomerName.AutoSize = true;
            this.labelCustomerName.Location = new System.Drawing.Point(45, 59);
            this.labelCustomerName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCustomerName.Name = "labelCustomerName";
            this.labelCustomerName.Size = new System.Drawing.Size(154, 25);
            this.labelCustomerName.TabIndex = 2;
            this.labelCustomerName.Text = "Customer Name";
            // 
            // labelAvailableItems
            // 
            this.labelAvailableItems.AutoSize = true;
            this.labelAvailableItems.Location = new System.Drawing.Point(45, 116);
            this.labelAvailableItems.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAvailableItems.Name = "labelAvailableItems";
            this.labelAvailableItems.Size = new System.Drawing.Size(144, 25);
            this.labelAvailableItems.TabIndex = 3;
            this.labelAvailableItems.Text = "Available Items";
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(212, 172);
            this.textBoxPrice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.ReadOnly = true;
            this.textBoxPrice.Size = new System.Drawing.Size(199, 30);
            this.textBoxPrice.TabIndex = 4;
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(47, 178);
            this.labelPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(56, 25);
            this.labelPrice.TabIndex = 5;
            this.labelPrice.Text = "Price";
            // 
            // numericUpDownQuantity
            // 
            this.numericUpDownQuantity.Location = new System.Drawing.Point(212, 232);
            this.numericUpDownQuantity.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numericUpDownQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownQuantity.Name = "numericUpDownQuantity";
            this.numericUpDownQuantity.Size = new System.Drawing.Size(149, 30);
            this.numericUpDownQuantity.TabIndex = 6;
            this.numericUpDownQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // labelQuantity
            // 
            this.labelQuantity.AutoSize = true;
            this.labelQuantity.Location = new System.Drawing.Point(47, 238);
            this.labelQuantity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelQuantity.Name = "labelQuantity";
            this.labelQuantity.Size = new System.Drawing.Size(85, 25);
            this.labelQuantity.TabIndex = 7;
            this.labelQuantity.Text = "Quantity";
            // 
            // buttonAddToOrder
            // 
            this.buttonAddToOrder.Location = new System.Drawing.Point(408, 222);
            this.buttonAddToOrder.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonAddToOrder.Name = "buttonAddToOrder";
            this.buttonAddToOrder.Size = new System.Drawing.Size(149, 48);
            this.buttonAddToOrder.TabIndex = 8;
            this.buttonAddToOrder.Text = "Add to Order";
            this.buttonAddToOrder.UseVisualStyleBackColor = true;
            this.buttonAddToOrder.Click += new System.EventHandler(this.buttonAddToOrder_Click);
            // 
            // dataGridViewOrderItems
            // 
            this.dataGridViewOrderItems.AllowUserToAddRows = false;
            this.dataGridViewOrderItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewOrderItems.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridViewOrderItems.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewOrderItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrderItems.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewOrderItems.Location = new System.Drawing.Point(52, 293);
            this.dataGridViewOrderItems.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridViewOrderItems.Name = "dataGridViewOrderItems";
            this.dataGridViewOrderItems.RowHeadersVisible = false;
            this.dataGridViewOrderItems.RowHeadersWidth = 51;
            this.dataGridViewOrderItems.RowTemplate.Height = 24;
            this.dataGridViewOrderItems.Size = new System.Drawing.Size(1169, 252);
            this.dataGridViewOrderItems.TabIndex = 9;
            // 
            // buttonSaveOrder
            // 
            this.buttonSaveOrder.Location = new System.Drawing.Point(1072, 581);
            this.buttonSaveOrder.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonSaveOrder.Name = "buttonSaveOrder";
            this.buttonSaveOrder.Size = new System.Drawing.Size(149, 48);
            this.buttonSaveOrder.TabIndex = 10;
            this.buttonSaveOrder.Text = "Save Order";
            this.buttonSaveOrder.UseVisualStyleBackColor = true;
            this.buttonSaveOrder.Click += new System.EventHandler(this.buttonSaveOrder_Click);
            // 
            // txt_comments
            // 
            this.txt_comments.Location = new System.Drawing.Point(747, 111);
            this.txt_comments.Margin = new System.Windows.Forms.Padding(4);
            this.txt_comments.Name = "txt_comments";
            this.txt_comments.Size = new System.Drawing.Size(473, 119);
            this.txt_comments.TabIndex = 11;
            this.txt_comments.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(582, 157);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "Comments";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(580, 59);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 25);
            this.label2.TabIndex = 14;
            this.label2.Text = "Process Type";
            // 
            // combobox_process_type
            // 
            this.combobox_process_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combobox_process_type.FormattingEnabled = true;
            this.combobox_process_type.Location = new System.Drawing.Point(745, 54);
            this.combobox_process_type.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.combobox_process_type.Name = "combobox_process_type";
            this.combobox_process_type.Size = new System.Drawing.Size(297, 33);
            this.combobox_process_type.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(671, 589);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 32);
            this.label3.TabIndex = 16;
            this.label3.Text = "TOTAL : ";
            // 
            // txt_total_amount
            // 
            this.txt_total_amount.Enabled = false;
            this.txt_total_amount.Location = new System.Drawing.Point(805, 583);
            this.txt_total_amount.Name = "txt_total_amount";
            this.txt_total_amount.Size = new System.Drawing.Size(215, 46);
            this.txt_total_amount.TabIndex = 17;
            this.txt_total_amount.Text = "";
            // 
            // txtAvailableItems
            // 
            this.txtAvailableItems.Location = new System.Drawing.Point(211, 113);
            this.txtAvailableItems.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAvailableItems.Name = "txtAvailableItems";
            this.txtAvailableItems.Size = new System.Drawing.Size(297, 30);
            this.txtAvailableItems.TabIndex = 18;
            this.txtAvailableItems.TextChanged += new System.EventHandler(this.txtAvailableItems_TextChanged);
            // 
            // OrderPlacingControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.txtAvailableItems);
            this.Controls.Add(this.txt_total_amount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.combobox_process_type);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_comments);
            this.Controls.Add(this.buttonSaveOrder);
            this.Controls.Add(this.dataGridViewOrderItems);
            this.Controls.Add(this.buttonAddToOrder);
            this.Controls.Add(this.labelQuantity);
            this.Controls.Add(this.numericUpDownQuantity);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.labelAvailableItems);
            this.Controls.Add(this.labelCustomerName);
            this.Controls.Add(this.comboBoxAvailableItems);
            this.Controls.Add(this.textBoxCustomerName);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "OrderPlacingControl";
            this.Size = new System.Drawing.Size(1287, 665);
            this.Load += new System.EventHandler(this.OrderPlacingControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrderItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxCustomerName;
        private System.Windows.Forms.ComboBox comboBoxAvailableItems;
        private System.Windows.Forms.Label labelCustomerName;
        private System.Windows.Forms.Label labelAvailableItems;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.NumericUpDown numericUpDownQuantity;
        private System.Windows.Forms.Label labelQuantity;
        private System.Windows.Forms.Button buttonAddToOrder;
        private System.Windows.Forms.DataGridView dataGridViewOrderItems;
        private System.Windows.Forms.Button buttonSaveOrder;
        private System.Windows.Forms.RichTextBox txt_comments;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox combobox_process_type;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox txt_total_amount;
        private System.Windows.Forms.TextBox txtAvailableItems;
    }
}
