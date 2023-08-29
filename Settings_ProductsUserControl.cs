using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace OrderManagementApp
{
    public partial class Settings_ProductsUserControl : UserControl
    {
        List<ProductItem> products;
        List<string> Product_names = new List<string>();

        private AutoCompleteStringCollection groups, truefalse,auto_products;
        Guid uniqueId;

        public Settings_ProductsUserControl()
        {
            InitializeComponent();
            LoadNecessaryDetails();

            groups = new AutoCompleteStringCollection();
            truefalse = new AutoCompleteStringCollection();
            auto_products = new AutoCompleteStringCollection(); 


            groups.Add(CodeConfig.string_Studio);
            groups.Add(CodeConfig.string_Amature);

            truefalse.Add("True");
            truefalse.Add("False");

            combobox_ignorestock.AutoCompleteMode = AutoCompleteMode.Suggest;
            combobox_ignorestock.AutoCompleteSource = AutoCompleteSource.CustomSource;
            combobox_ignorestock.AutoCompleteCustomSource = truefalse;
            combobox_ignorestock.DataSource = truefalse;

            combobox_group.AutoCompleteMode = AutoCompleteMode.Suggest;
            combobox_group.AutoCompleteSource = AutoCompleteSource.CustomSource;
            combobox_group.AutoCompleteCustomSource = groups;
            combobox_group.DataSource = groups;


            combobox_view_group.AutoCompleteMode = AutoCompleteMode.Suggest;
            combobox_view_group.AutoCompleteSource = AutoCompleteSource.CustomSource;
            combobox_view_group.AutoCompleteCustomSource = groups;
            combobox_view_group.DataSource = groups;

            combobox_products.AutoCompleteMode = AutoCompleteMode.Suggest;
            combobox_products.AutoCompleteSource = AutoCompleteSource.CustomSource;
            combobox_products.AutoCompleteCustomSource = auto_products;

            /*
            combobox_group.Items.Add("Studio");
            combobox_group.Items.Add("Amature");

            combobox_view_group.Items.Add("Studio");
            combobox_view_group.Items.Add("Amature");

            combobox_ignorestock.Items.Add("True");
            combobox_ignorestock.Items.Add("False");
            */

        }

        private void LoadNecessaryDetails()
        {
            products = Utils.LoadProducts();

        }

        private void btn_view_Click(object sender, EventArgs e)
        {
            btn_save.Text = "Modify";
            btn_delete.Enabled = true;
            string selectedName = combobox_products.SelectedItem?.ToString();
            string seletedGroup = combobox_view_group.SelectedItem?.ToString();
            ProductItem selectedObject = products.Find(obj => obj.Name == selectedName && obj.Group == seletedGroup);
            if (selectedObject != null)
            {
                txt_productname.Text = selectedObject.Name;
                txt_price.Text = selectedObject.Price.ToString();
                txt_stock.Text = selectedObject.AvailableQuantity.ToString();
                combobox_group.SelectedItem = selectedObject.Group;
                combobox_ignorestock.SelectedItem = selectedObject.IgnoreQuantity.ToString();
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            btn_save.Text = "Save";
            btn_delete.Enabled = false;
            txt_price.Text = string.Empty;
            txt_productname.Text = string.Empty;
            txt_stock.Text = string.Empty; 
            combobox_ignorestock.SelectedIndex = -1;
            combobox_group.SelectedIndex  = -1;
        }

        private void combobox_products_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_view.PerformClick();
            }
        }

        private bool ValidateData(bool  Include_name)
        {
            bool status = true;
            if (Include_name)
            {
                if (Product_names.Contains(txt_productname.Text.Trim()))
                {
                    MessageBox.Show("Duplicate Product exists");
                    status = false;
                }
            }
            try { Convert.ToDouble(txt_price.Text); }
            catch {
                MessageBox.Show("Please enter valid price");
                status = false;
            }

            try { Convert.ToInt32(txt_stock.Text); }
            catch {
                MessageBox.Show("Please enter valid stock number");
                status = false;
                }

            return status;
        }
        
        private void btn_save_Click(object sender, EventArgs e)
        {
            uniqueId = Guid.NewGuid();
            if (btn_save.Text == "Save")
            { 
                if(ValidateData(true))
                {
                    products.Add(new ProductItem { 
                        ID = uniqueId.ToString(),
                        Name = txt_productname.Text.Trim(),
                        Price = Convert.ToDouble(txt_price.Text), 
                        AvailableQuantity = Convert.ToInt32(txt_stock.Text), 
                        IgnoreQuantity = Convert.ToBoolean(combobox_ignorestock.SelectedItem?.ToString()),
                        Group = combobox_group.SelectedItem?.ToString()});
                    if (Utils.SaveProducts(products))
                    {
                        btn_clear.PerformClick();
                        LoadNecessaryDetails();
                        MessageBox.Show("New Product Saved, Successfully");
                    }
                }

            }
           else
            {
                if (ValidateData(false))
                {
                    string selectedName = combobox_products.SelectedItem.ToString();
                    string seletedGroup = combobox_view_group.SelectedItem.ToString();
                    ProductItem selectedObject = products.Find(obj => obj.Name == selectedName && obj.Group == seletedGroup);
                    selectedObject.Name = txt_productname.Text.Trim();
                    selectedObject.Price = Convert.ToDouble(txt_price.Text);
                    selectedObject.AvailableQuantity = Convert.ToInt32(txt_stock.Text);
                    selectedObject.IgnoreQuantity = Convert.ToBoolean(combobox_ignorestock.SelectedItem?.ToString());
                    selectedObject.Group = combobox_group.SelectedItem.ToString();
                    if (Utils.SaveProducts(products))
                    {
                        btn_clear.PerformClick();
                        LoadNecessaryDetails();
                        MessageBox.Show("Product Modified, Successfully");
                    }
                }

            }
        }

        private void combobox_view_group_SelectedIndexChanged(object sender, EventArgs e)
        {
            Product_names.Clear();
            combobox_products.DataSource = null;
            combobox_products.Items.Clear();
            string selected_group = combobox_view_group.SelectedItem.ToString();    
            var temp_products = products.FindAll(obj => obj.Group == selected_group);
            foreach (ProductItem item in temp_products)
            {
                Product_names.Add(item.Name);
            }
            auto_products.AddRange(Product_names.ToArray());
            combobox_products.DataSource = Product_names;
           

        }
    }

}
