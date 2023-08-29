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
            this.comboBoxAvailableItems = new System.Windows.Forms.ComboBox();
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
            this.label3 = new System.Windows.Forms.Label();
            this.txt_total_amount = new System.Windows.Forms.RichTextBox();
            this.txtAvailableItems = new System.Windows.Forms.TextBox();
            this.textBoxCustomerName = new System.Windows.Forms.TextBox();
            this.labelCustomerName = new System.Windows.Forms.Label();
            this.combobox_process_type = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.combo_customer_type = new System.Windows.Forms.ComboBox();
            this.combo_paymenttype = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_amountPaid = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrderItems)).BeginInit();
            this.SuspendLayout();
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
            this.textBoxPrice.Location = new System.Drawing.Point(194, 173);
            this.textBoxPrice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.ReadOnly = true;
            this.textBoxPrice.Size = new System.Drawing.Size(199, 30);
            this.textBoxPrice.TabIndex = 4;
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(130, 178);
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
            this.labelQuantity.Location = new System.Drawing.Point(104, 237);
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
            this.dataGridViewOrderItems.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridViewOrderItems.Location = new System.Drawing.Point(52, 293);
            this.dataGridViewOrderItems.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridViewOrderItems.MultiSelect = false;
            this.dataGridViewOrderItems.Name = "dataGridViewOrderItems";
            this.dataGridViewOrderItems.ReadOnly = true;
            this.dataGridViewOrderItems.RowHeadersVisible = false;
            this.dataGridViewOrderItems.RowHeadersWidth = 51;
            this.dataGridViewOrderItems.RowTemplate.Height = 24;
            this.dataGridViewOrderItems.Size = new System.Drawing.Size(1169, 252);
            this.dataGridViewOrderItems.TabIndex = 9;
            this.dataGridViewOrderItems.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dataGridViewOrderItems_UserDeletingRow);
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
            this.txt_comments.Size = new System.Drawing.Size(474, 119);
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(753, 587);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 32);
            this.label3.TabIndex = 16;
            this.label3.Text = "TOTAL : ";
            // 
            // txt_total_amount
            // 
            this.txt_total_amount.Enabled = false;
            this.txt_total_amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_total_amount.Location = new System.Drawing.Point(895, 587);
            this.txt_total_amount.Name = "txt_total_amount";
            this.txt_total_amount.Size = new System.Drawing.Size(170, 36);
            this.txt_total_amount.TabIndex = 17;
            this.txt_total_amount.Text = "";
            // 
            // txtAvailableItems
            // 
            this.txtAvailableItems.Location = new System.Drawing.Point(194, 111);
            this.txtAvailableItems.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAvailableItems.Name = "txtAvailableItems";
            this.txtAvailableItems.Size = new System.Drawing.Size(285, 30);
            this.txtAvailableItems.TabIndex = 18;
            this.txtAvailableItems.TextChanged += new System.EventHandler(this.txtAvailableItems_TextChanged);
            // 
            // textBoxCustomerName
            // 
            this.textBoxCustomerName.Location = new System.Drawing.Point(194, 56);
            this.textBoxCustomerName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxCustomerName.Name = "textBoxCustomerName";
            this.textBoxCustomerName.Size = new System.Drawing.Size(285, 30);
            this.textBoxCustomerName.TabIndex = 0;
            this.textBoxCustomerName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxCustomerName_KeyDown);
            // 
            // labelCustomerName
            // 
            this.labelCustomerName.AutoSize = true;
            this.labelCustomerName.Location = new System.Drawing.Point(45, 56);
            this.labelCustomerName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCustomerName.Name = "labelCustomerName";
            this.labelCustomerName.Size = new System.Drawing.Size(154, 25);
            this.labelCustomerName.TabIndex = 2;
            this.labelCustomerName.Text = "Customer Name";
            // 
            // combobox_process_type
            // 
            this.combobox_process_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combobox_process_type.FormattingEnabled = true;
            this.combobox_process_type.Location = new System.Drawing.Point(994, 48);
            this.combobox_process_type.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.combobox_process_type.Name = "combobox_process_type";
            this.combobox_process_type.Size = new System.Drawing.Size(227, 33);
            this.combobox_process_type.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(853, 54);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 25);
            this.label2.TabIndex = 14;
            this.label2.Text = "Process Type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(487, 56);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 25);
            this.label4.TabIndex = 19;
            this.label4.Text = "Customer Type";
            // 
            // combo_customer_type
            // 
            this.combo_customer_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_customer_type.FormattingEnabled = true;
            this.combo_customer_type.Location = new System.Drawing.Point(632, 51);
            this.combo_customer_type.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.combo_customer_type.Name = "combo_customer_type";
            this.combo_customer_type.Size = new System.Drawing.Size(213, 33);
            this.combo_customer_type.TabIndex = 20;
            this.combo_customer_type.SelectedIndexChanged += new System.EventHandler(this.combo_customer_type_SelectedIndexChanged);
            // 
            // combo_paymenttype
            // 
            this.combo_paymenttype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_paymenttype.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo_paymenttype.FormattingEnabled = true;
            this.combo_paymenttype.Location = new System.Drawing.Point(194, 568);
            this.combo_paymenttype.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.combo_paymenttype.Name = "combo_paymenttype";
            this.combo_paymenttype.Size = new System.Drawing.Size(180, 37);
            this.combo_paymenttype.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(29, 571);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(167, 29);
            this.label5.TabIndex = 21;
            this.label5.Text = "Payment Type";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(404, 571);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(149, 29);
            this.label6.TabIndex = 23;
            this.label6.Text = "Amount Paid";
            // 
            // txt_amountPaid
            // 
            this.txt_amountPaid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_amountPaid.Location = new System.Drawing.Point(550, 568);
            this.txt_amountPaid.Multiline = false;
            this.txt_amountPaid.Name = "txt_amountPaid";
            this.txt_amountPaid.Size = new System.Drawing.Size(186, 36);
            this.txt_amountPaid.TabIndex = 24;
            this.txt_amountPaid.Text = "";
            // 
            // OrderPlacingControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.txt_amountPaid);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.combo_paymenttype);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.combo_customer_type);
            this.Controls.Add(this.label4);
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
            this.Size = new System.Drawing.Size(1257, 665);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrderItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBoxAvailableItems;
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox txt_total_amount;
        private System.Windows.Forms.TextBox txtAvailableItems;
        private System.Windows.Forms.TextBox textBoxCustomerName;
        private System.Windows.Forms.Label labelCustomerName;
        private System.Windows.Forms.ComboBox combobox_process_type;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox combo_customer_type;
        private System.Windows.Forms.ComboBox combo_paymenttype;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox txt_amountPaid;
    }
}
