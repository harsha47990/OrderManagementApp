﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static OrderManagementApp.MasterPage;

namespace OrderManagementApp
{
    public partial class Settings_AccountUserControl : UserControl, IRefreshable
    {
        public Settings_AccountUserControl()
        {
            InitializeComponent();
        }

        public void RefreshData()
        {

        }
    }
}
