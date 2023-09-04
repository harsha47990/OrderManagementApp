using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderManagementApp
{
    public partial class MasterPage : Form
    {
        public MasterPage()
        {
            InitializeComponent();
            //Form1 f1 = new Form1();
            ProgressUserControl f1 =   new ProgressUserControl();
            AddProcessUserControl f2 = new AddProcessUserControl(); 

            OrderPlacingControl f3 = new OrderPlacingControl(); 

            Settings_ProductsUserControl f4 = new Settings_ProductsUserControl();

            Settings_CustomerUserControl f5 = new Settings_CustomerUserControl();
            PurchaseUserControl f6 = new PurchaseUserControl();
            ReportsUserControl f7 = new ReportsUserControl();   

            //f1.TopLevel = false;
            this.WindowState = FormWindowState.Maximized;
            this.MaximizeBox = false; // Disables minimize button
            this.FormBorderStyle = FormBorderStyle.FixedDialog; 
            // Set the Dock property to fill the panel
            f1.Dock = DockStyle.Fill;


            progress_fill_panel.Controls.Add(f1);
            Settings_process_config.Controls.Add(f2);
            order_panel.Controls.Add(f3);
            settings_products_panel.Controls.Add(f4);
            settings_customer_panel.Controls.Add(f5);
            purchase_tab.Controls.Add(f6);
            reports_tab.Controls.Add(f7);

            // Show the form
            f1.Show();
        }
        
        private void tabcontrol_SelectedIndexChanged(object sender, EventArgs e)
        {
            TabControl tabControl = (TabControl)sender;

            if (tabControl.SelectedIndex >= 0)
            {
                TabPage selectedTab = tabControl.TabPages[tabControl.SelectedIndex];
                LoadDataForTab(selectedTab);
            }
        }

        private void LoadDataForTab(TabPage tab)
        {
            // Clear existing content or refresh data here
            // For demonstration purposes, let's update a label's text
            UserControl userControl = tab.Controls[0] as UserControl;

            if (userControl != null && userControl is IRefreshable)
            {
                ((IRefreshable)userControl).RefreshData();
            }
        }

        public interface IRefreshable
        {
            void RefreshData();
        }

        private void setting_subtab_SelectedIndexChanged(object sender, EventArgs e)
        {
            tabcontrol_SelectedIndexChanged(sender, e);
        }

        private void MasterPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }

}
