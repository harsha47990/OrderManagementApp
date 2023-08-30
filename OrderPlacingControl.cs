using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text.Json;
using System.Windows.Forms;
using static OrderManagementApp.MasterPage;

namespace OrderManagementApp
{
    public partial class OrderPlacingControl : UserControl, IRefreshable
    {
        private AutoCompleteStringCollection customerNameAutoComplete, OrderItemsAutoComplete;

        private List<ProductItem> availableItems;

        private BindingList<OrderedItem> orderItems = new BindingList<OrderedItem>();
        
        private List<string> CustomerNames;

        private List<ProcessClass> processes = new List<ProcessClass>();

        Dictionary<string, double> custom_price_dict;

        List<CustomerData> customers;

        CustomerData selected_customer;

        bool IsCustomPrice = false;
        public OrderPlacingControl()
        {
            InitializeComponent();
            combo_customer_type.Items.Add(CodeConfig.string_Studio);
            combo_customer_type.Items.Add(CodeConfig.string_Amature);
            // Initialize customer name auto-completion data source
            customerNameAutoComplete = new AutoCompleteStringCollection();
            OrderItemsAutoComplete = new AutoCompleteStringCollection();

            txtAvailableItems.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtAvailableItems.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtAvailableItems.AutoCompleteCustomSource = OrderItemsAutoComplete;

            textBoxCustomerName.AutoCompleteMode = AutoCompleteMode.Suggest;
            textBoxCustomerName.AutoCompleteSource = AutoCompleteSource.CustomSource;
            textBoxCustomerName.AutoCompleteCustomSource = customerNameAutoComplete;
            combo_paymenttype.Items.AddRange(CodeConfig.PaymentTypes.ToArray());
           
            dataGridViewOrderItems.DataSource = orderItems;
            dataGridViewOrderItems.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            processes = Utils.ReadProcesses();
            combobox_process_type.Items.AddRange(processes.Select(obj => obj.Name).ToArray());
            CleanAll();
            RefreshData();
        }

        private void CleanAll()
        {
            orderItems.Clear();
            txt_total_amount.Text = "0";
            txt_amountPaid.Text = "0";
            textBoxCustomerName.Text = String.Empty;
            combo_customer_type.SelectedIndex = 0;
            combobox_process_type.SelectedIndex= 0;
            txt_comments.Text = String.Empty;
            textBoxPrice.Text = String.Empty;
            numericUpDownQuantity.Value = 1;
            combo_paymenttype.SelectedIndex= 0;
        }

        private void LoadNeccesaryDetailsForCustomer()
        {
            // Initialize the list of available items (you can load this from a database or other sources)
            
            availableItems = Utils.LoadProducts().FindAll(obj => obj.Group == combo_customer_type.Text);
            SetOrderItemsAutoComplete(availableItems);
            comboBoxAvailableItems.DataSource = availableItems;
            comboBoxAvailableItems.SelectedIndex = -1;
        }
        public void SetOrderItemsAutoComplete(List<ProductItem> Items)
        {
            List<string> items = new List<string>();
            foreach(var item in Items)
            {
                items.Add(item.Name);
            }
            OrderItemsAutoComplete.Clear();
            OrderItemsAutoComplete.AddRange(items.ToArray());

        }

        public void SetCustomerNamesAutoComplete(List<string> customerNames)
        {
            customerNameAutoComplete.Clear();
            customerNameAutoComplete.AddRange(customerNames.ToArray());
        }

        private void comboBoxAvailableItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxAvailableItems.SelectedItem != null)
            {
                ProductItem selectedItem = (ProductItem)comboBoxAvailableItems.SelectedItem;
                if (IsCustomPrice && custom_price_dict.ContainsKey(selectedItem.Name))
                {
                    textBoxPrice.Text = custom_price_dict[selectedItem.Name].ToString("0.00");
                }
                else
                {
                    textBoxPrice.Text = selectedItem.Price.ToString("0.00");
                }
            }
        }

        private void buttonAddToOrder_Click(object sender, EventArgs e)
        {
            if (comboBoxAvailableItems.SelectedItem != null && numericUpDownQuantity.Value > 0)
            {
                ProductItem selectedItem = (ProductItem)comboBoxAvailableItems.SelectedItem;
                double price = double.Parse(textBoxPrice.Text);
                int quantity = (int)numericUpDownQuantity.Value;

                OrderedItem orderItem = new OrderedItem
                {
                    ItemName = selectedItem.Name,
                    Price = price,
                    Quantity = quantity,
                    Total_Price =  (double)quantity * price
                };

                orderItems.Add(orderItem);
                txt_total_amount.Text = Convert.ToString(Convert.ToDouble(txt_total_amount.Text) + orderItem.Total_Price);
            }
        }

        // Event handler for saving the order
        private void buttonSaveOrder_Click(object sender, EventArgs e)
        {
            DateTime currentTime = DateTime.Now;
            string id = currentTime.ToString("yyyyMMddHHmmssfff");
            Order order_item = new Order();
            order_item.ID = id;
            order_item.ProcessType = combobox_process_type.SelectedItem.ToString();
            order_item.CustomerId = selected_customer.ID;
            order_item.Comments = txt_comments.Text;
            order_item.Items = orderItems.ToList();
            order_item.TotalAmount = Convert.ToDouble(txt_total_amount.Text);
            order_item.Due = order_item.TotalAmount - Convert.ToDouble(txt_amountPaid.Text);
            order_item.PaymentType = combo_paymenttype.SelectedItem.ToString();
            Utils.SaveOrderDetails(order_item);
            CleanAll();
        }

        private void textBoxCustomerName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (CustomerNames.Contains(textBoxCustomerName.Text.ToString(), StringComparer.OrdinalIgnoreCase))
                {
                    string name = textBoxCustomerName.Text.ToString().Split(',')[0];
                    string type = textBoxCustomerName.Text.ToString().Split(',')[1];
                    string studio_name = textBoxCustomerName.Text.ToString().Split(',')[2];
                    string address = textBoxCustomerName.Text.ToString().Split(',')[3];
                    string mobile = textBoxCustomerName.Text.ToString().Split(',')[4];
                    selected_customer = customers.Find(obj => obj.Name == name && obj.CustomerType == type && obj.StudioName == studio_name && obj.Address == address && obj.MobileNo == mobile);
                    textBoxCustomerName.Text = selected_customer.Name;
                    combo_customer_type.Text = selected_customer.CustomerType;

                    if (selected_customer.CustomPriceList.Count > 0)
                    {
                        IsCustomPrice = true;
                        custom_price_dict = selected_customer.CustomPriceList;
                    }
                    else
                    {
                        custom_price_dict = null;
                        IsCustomPrice = false;
                    }
                    LoadNeccesaryDetailsForCustomer();
                }
               
            }
        }

        private void txtAvailableItems_TextChanged(object sender, EventArgs e)
        {
            string searchText = txtAvailableItems.Text.ToLower();
            var filteredItems = availableItems.Where(item => item.Name.ToLower().Contains(searchText)).ToList();
            if (filteredItems.Count > 0)
            {
                comboBoxAvailableItems.SelectedItem = filteredItems[0];
            }

            //MessageBox.Show(searchText);
        }

        private void combo_customer_type_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadNeccesaryDetailsForCustomer();
        }

        private void dataGridViewOrderItems_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            int ind = e.Row.Index;
            var deleted_item = orderItems[ind];
            //orderItems.Remove(deleted_item);
            txt_total_amount.Text = Convert.ToString(Convert.ToDouble(txt_total_amount.Text) - deleted_item.Total_Price);

        }

        public void RefreshData()
        {
            custom_price_dict = new Dictionary<string, double>();
            customers = Utils.LoadCustomers();
            CustomerNames = customers.Select(obj => obj.Name + "," + obj.CustomerType + ',' + obj.StudioName + "," + obj.Address + "," + obj.MobileNo).ToList();
            SetCustomerNamesAutoComplete(CustomerNames);
        }
    }

}
