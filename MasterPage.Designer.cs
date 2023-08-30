namespace OrderManagementApp
{
    partial class MasterPage
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabcontrol = new System.Windows.Forms.TabControl();
            this.progress_tab = new System.Windows.Forms.TabPage();
            this.progress_fill_panel = new System.Windows.Forms.Panel();
            this.progress_option_panel = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.order_panel = new System.Windows.Forms.TabPage();
            this.purchase_tab = new System.Windows.Forms.TabPage();
            this.reports_tab = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.setting_subtab = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Settings_process_config = new System.Windows.Forms.TabPage();
            this.settings_customer_panel = new System.Windows.Forms.TabPage();
            this.settings_products_panel = new System.Windows.Forms.TabPage();
            this.tabcontrol.SuspendLayout();
            this.progress_tab.SuspendLayout();
            this.progress_option_panel.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.setting_subtab.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabcontrol
            // 
            this.tabcontrol.Controls.Add(this.progress_tab);
            this.tabcontrol.Controls.Add(this.order_panel);
            this.tabcontrol.Controls.Add(this.purchase_tab);
            this.tabcontrol.Controls.Add(this.reports_tab);
            this.tabcontrol.Controls.Add(this.tabPage5);
            this.tabcontrol.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabcontrol.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabcontrol.Location = new System.Drawing.Point(0, 0);
            this.tabcontrol.Name = "tabcontrol";
            this.tabcontrol.SelectedIndex = 0;
            this.tabcontrol.Size = new System.Drawing.Size(1896, 678);
            this.tabcontrol.TabIndex = 0;
            this.tabcontrol.SelectedIndexChanged += new System.EventHandler(this.tabcontrol_SelectedIndexChanged);
            // 
            // progress_tab
            // 
            this.progress_tab.Controls.Add(this.progress_fill_panel);
            this.progress_tab.Controls.Add(this.progress_option_panel);
            this.progress_tab.Location = new System.Drawing.Point(4, 41);
            this.progress_tab.Name = "progress_tab";
            this.progress_tab.Padding = new System.Windows.Forms.Padding(3);
            this.progress_tab.Size = new System.Drawing.Size(1888, 633);
            this.progress_tab.TabIndex = 0;
            this.progress_tab.Text = "progress";
            this.progress_tab.UseVisualStyleBackColor = true;
            // 
            // progress_fill_panel
            // 
            this.progress_fill_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.progress_fill_panel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.progress_fill_panel.Location = new System.Drawing.Point(3, 69);
            this.progress_fill_panel.Name = "progress_fill_panel";
            this.progress_fill_panel.Size = new System.Drawing.Size(1882, 561);
            this.progress_fill_panel.TabIndex = 1;
            // 
            // progress_option_panel
            // 
            this.progress_option_panel.AutoScroll = true;
            this.progress_option_panel.AutoSize = true;
            this.progress_option_panel.BackColor = System.Drawing.Color.IndianRed;
            this.progress_option_panel.Controls.Add(this.button2);
            this.progress_option_panel.Controls.Add(this.comboBox2);
            this.progress_option_panel.Controls.Add(this.label2);
            this.progress_option_panel.Controls.Add(this.comboBox1);
            this.progress_option_panel.Controls.Add(this.button1);
            this.progress_option_panel.Controls.Add(this.label1);
            this.progress_option_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.progress_option_panel.Location = new System.Drawing.Point(3, 3);
            this.progress_option_panel.Name = "progress_option_panel";
            this.progress_option_panel.Size = new System.Drawing.Size(1882, 66);
            this.progress_option_panel.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(1698, 8);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 50);
            this.button2.TabIndex = 6;
            this.button2.Text = "apply";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // comboBox2
            // 
            this.comboBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "progress 1",
            "progress 2",
            "progress 3"});
            this.comboBox2.Location = new System.Drawing.Point(1350, 11);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(3, 3, 3, 15);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(331, 40);
            this.comboBox2.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1255, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 32);
            this.label2.TabIndex = 4;
            this.label2.Text = "Filter : ";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "progress 1",
            "progress 2",
            "progress 3"});
            this.comboBox1.Location = new System.Drawing.Point(221, 11);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 15);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(315, 40);
            this.comboBox1.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(551, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 50);
            this.button1.TabIndex = 2;
            this.button1.Text = "show";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Process Type : ";
            // 
            // order_panel
            // 
            this.order_panel.Location = new System.Drawing.Point(4, 41);
            this.order_panel.Name = "order_panel";
            this.order_panel.Padding = new System.Windows.Forms.Padding(3);
            this.order_panel.Size = new System.Drawing.Size(1888, 633);
            this.order_panel.TabIndex = 1;
            this.order_panel.Text = "orders";
            this.order_panel.UseVisualStyleBackColor = true;
            // 
            // purchase_tab
            // 
            this.purchase_tab.Location = new System.Drawing.Point(4, 41);
            this.purchase_tab.Name = "purchase_tab";
            this.purchase_tab.Padding = new System.Windows.Forms.Padding(3);
            this.purchase_tab.Size = new System.Drawing.Size(1888, 633);
            this.purchase_tab.TabIndex = 2;
            this.purchase_tab.Text = "purchases";
            this.purchase_tab.UseVisualStyleBackColor = true;
            // 
            // reports_tab
            // 
            this.reports_tab.Location = new System.Drawing.Point(4, 41);
            this.reports_tab.Name = "reports_tab";
            this.reports_tab.Padding = new System.Windows.Forms.Padding(3);
            this.reports_tab.Size = new System.Drawing.Size(1888, 633);
            this.reports_tab.TabIndex = 3;
            this.reports_tab.Text = "reports";
            this.reports_tab.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.setting_subtab);
            this.tabPage5.Location = new System.Drawing.Point(4, 41);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(1888, 633);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "settings";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // setting_subtab
            // 
            this.setting_subtab.Controls.Add(this.tabPage1);
            this.setting_subtab.Controls.Add(this.Settings_process_config);
            this.setting_subtab.Controls.Add(this.settings_customer_panel);
            this.setting_subtab.Controls.Add(this.settings_products_panel);
            this.setting_subtab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.setting_subtab.Location = new System.Drawing.Point(3, 3);
            this.setting_subtab.Name = "setting_subtab";
            this.setting_subtab.SelectedIndex = 0;
            this.setting_subtab.Size = new System.Drawing.Size(1882, 627);
            this.setting_subtab.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 41);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1874, 582);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "account";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // Settings_process_config
            // 
            this.Settings_process_config.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Settings_process_config.Location = new System.Drawing.Point(4, 41);
            this.Settings_process_config.Name = "Settings_process_config";
            this.Settings_process_config.Padding = new System.Windows.Forms.Padding(3);
            this.Settings_process_config.Size = new System.Drawing.Size(1874, 582);
            this.Settings_process_config.TabIndex = 1;
            this.Settings_process_config.Text = "process config";
            this.Settings_process_config.UseVisualStyleBackColor = true;
            // 
            // settings_customer_panel
            // 
            this.settings_customer_panel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settings_customer_panel.Location = new System.Drawing.Point(4, 41);
            this.settings_customer_panel.Name = "settings_customer_panel";
            this.settings_customer_panel.Padding = new System.Windows.Forms.Padding(3);
            this.settings_customer_panel.Size = new System.Drawing.Size(1874, 582);
            this.settings_customer_panel.TabIndex = 2;
            this.settings_customer_panel.Text = "customers";
            this.settings_customer_panel.UseVisualStyleBackColor = true;
            // 
            // settings_products_panel
            // 
            this.settings_products_panel.Location = new System.Drawing.Point(4, 41);
            this.settings_products_panel.Name = "settings_products_panel";
            this.settings_products_panel.Padding = new System.Windows.Forms.Padding(3);
            this.settings_products_panel.Size = new System.Drawing.Size(1874, 582);
            this.settings_products_panel.TabIndex = 3;
            this.settings_products_panel.Text = "products";
            this.settings_products_panel.UseVisualStyleBackColor = true;
            // 
            // MasterPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1896, 678);
            this.Controls.Add(this.tabcontrol);
            this.MinimumSize = new System.Drawing.Size(1918, 56);
            this.Name = "MasterPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.tabcontrol.ResumeLayout(false);
            this.progress_tab.ResumeLayout(false);
            this.progress_tab.PerformLayout();
            this.progress_option_panel.ResumeLayout(false);
            this.progress_option_panel.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.setting_subtab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabcontrol;
        private System.Windows.Forms.TabPage progress_tab;
        private System.Windows.Forms.TabPage order_panel;
        private System.Windows.Forms.TabPage purchase_tab;
        private System.Windows.Forms.TabPage reports_tab;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Panel progress_option_panel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel progress_fill_panel;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TabControl setting_subtab;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage Settings_process_config;
        private System.Windows.Forms.TabPage settings_customer_panel;
        private System.Windows.Forms.TabPage settings_products_panel;
    }
}