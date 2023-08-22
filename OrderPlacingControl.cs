using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace OrderManagementApp
{
    public partial class OrderPlacingControl : UserControl
    {
        // Data source for customer names auto-completion
        private AutoCompleteStringCollection customerNameAutoComplete, OrderItemsAutoComplete;

        // List of available items
        private List<OrderItemClass> availableItems;

        // List to hold the items in the order
        private BindingList<OrderedItem> orderItems;

        public OrderPlacingControl()
        {
            InitializeComponent();
            InitializeControls();
        }

        private void InitializeControls()
        {
            // Initialize customer name auto-completion data source
            customerNameAutoComplete = new AutoCompleteStringCollection();
            OrderItemsAutoComplete = new AutoCompleteStringCollection();


            txtAvailableItems.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtAvailableItems.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtAvailableItems.AutoCompleteCustomSource = OrderItemsAutoComplete;

            textBoxCustomerName.AutoCompleteMode = AutoCompleteMode.Suggest;
            textBoxCustomerName.AutoCompleteSource = AutoCompleteSource.CustomSource;
            textBoxCustomerName.AutoCompleteCustomSource = customerNameAutoComplete;

            

            // Initialize the list of available items (you can load this from a database or other sources)
            availableItems = new List<OrderItemClass>
            {
                new OrderItemClass { Name = "Item 1", Price = 10.0, AvailableQuantity=100 },
                new OrderItemClass { Name = "Item 2", Price = 25.0, AvailableQuantity=100 },
                new OrderItemClass { Name = "cat 1", Price = 33.0, AvailableQuantity=100 },
                new OrderItemClass { Name = "cow 2", Price = 45.0, AvailableQuantity=100 },
                new OrderItemClass { Name = "deep 1", Price = 50.0, AvailableQuantity=100 },
                new OrderItemClass { Name = "donkey 2", Price = 65.0, AvailableQuantity=100 },
                // Add more items as needed
            };

            List<string> customers = new List<string>(new string[] { "customer1", "customer2", "customer3","amature" });

            SetCustomerNamesAutoComplete(customers);
            SetOrderItemsAutoComplete(availableItems);
            comboBoxAvailableItems.DataSource = availableItems;
            // Initialize the list to hold the items in the order
            orderItems = new BindingList<OrderedItem>();
            dataGridViewOrderItems.DataSource = orderItems;

        }
        
        public void SetOrderItemsAutoComplete(List<OrderItemClass> Items)
        {
            List<string> items = new List<string>();
            foreach(var item in Items)
            {
                items.Add(item.Name);
            }
            OrderItemsAutoComplete.Clear();
            OrderItemsAutoComplete.AddRange(items.ToArray());

        }

        // Method to populate the customer name auto-completion data
        public void SetCustomerNamesAutoComplete(List<string> customerNames)
        {
            customerNameAutoComplete.Clear();
            customerNameAutoComplete.AddRange(customerNames.ToArray());
        }

        // Event handler for selecting an item from the available items list
        private void comboBoxAvailableItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxAvailableItems.SelectedItem != null)
            {
                OrderItemClass selectedItem = (OrderItemClass)comboBoxAvailableItems.SelectedItem;
                textBoxPrice.Text = selectedItem.Price.ToString("0.00");
            }
        }

        // Event handler for adding the selected item to the order
        private void buttonAddToOrder_Click(object sender, EventArgs e)
        {
            if (comboBoxAvailableItems.SelectedItem != null && numericUpDownQuantity.Value > 0)
            {
                OrderItemClass selectedItem = (OrderItemClass)comboBoxAvailableItems.SelectedItem;
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
            }
        }

        // Event handler for saving the order
        private void buttonSaveOrder_Click(object sender, EventArgs e)
        {
            // Implement the logic to save the order here
            // You can use the orderItems list to get the items in the order
            // and textBoxCustomerName.Text to get the customer name.
            // Save the data to a database or any other storage as needed.
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

        private void OrderPlacingControl_Load(object sender, EventArgs e)
        {

        }
    }

    public class OrderItemClass
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public int AvailableQuantity { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }

    public class OrderedItem
    {
        public string ItemName { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public double Total_Price { get; set; }  
    }
}
