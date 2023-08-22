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
    public partial class MasterPage : Form
    {
        public MasterPage()
        {
            InitializeComponent();
            //Form1 f1 = new Form1();
            ProgressUserControl f1 =   new ProgressUserControl();
            AddProcessUserControl f2 = new AddProcessUserControl(); 

            OrderPlacingControl f3 = new OrderPlacingControl(); 
            //f1.TopLevel = false;
            this.WindowState = FormWindowState.Maximized;
            this.MaximizeBox = false; // Disables minimize button
            this.FormBorderStyle = FormBorderStyle.FixedDialog; 
            // Set the Dock property to fill the panel
            f1.Dock = DockStyle.Fill;

            // Add MyWinFormPage to the panel's Controls collection
            
            progress_fill_panel.Controls.Add(f1);
            Settings_process_config.Controls.Add(f2);
            order_panel.Controls.Add(f3);

            // Show the form
            f1.Show();
        }
    }
}
