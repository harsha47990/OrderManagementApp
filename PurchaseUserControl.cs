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
    public partial class PurchaseUserControl : UserControl, IRefreshable
    {
        public PurchaseUserControl()
        {
            InitializeComponent();
        }
        public void RefreshData()
        {

        }
    }
}
