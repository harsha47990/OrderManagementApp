using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static OrderManagementApp.MasterPage;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace OrderManagementApp
{
    public partial class Settings_CustomerUserControl : UserControl, IRefreshable
    {
        Dictionary<string,double> custom_price_dict = new Dictionary<string,double>();
        
        List<CustomerData> customers;

        CustomerData searched_customer;

        Dictionary<string, string> searcby_dict;

        private bool ModifyCustomer = false;

        List<ProductItem> products;

        Guid uniqueId;
        public Settings_CustomerUserControl()
        {
            InitializeComponent();
            combo_customPrice.Items.Add("YES");
            combo_customPrice.Items.Add("NO");
            combo_customPrice.SelectedIndex = 1;
          
            combobox_group.Items.Add(CodeConfig.string_Studio);
            combobox_group.Items.Add(CodeConfig.string_Amature);
            combobox_group.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            combobox_group.AutoCompleteSource = AutoCompleteSource.CustomSource; 
            combobox_group.AutoCompleteCustomSource = new AutoCompleteStringCollection{ CodeConfig.string_Studio, CodeConfig.string_Amature };
            
            searcby_dict = new Dictionary<string, string>
            {
                { "Customer Name", "Name" },
                { "Studio Name", "StudioName" },
                { "Mobile", "MobileNo" }
            };


            combo_searchby.DataSource = searcby_dict.Keys.ToArray(); // searchby_list.ToArray();
            combo_searchby.SelectedIndex = 0;
            RefreshData();
        }

        public void RefreshData()
        {
            EnableDisableCustomPrice(false);
            products = Utils.ReadProducts();
            customers = Utils.ReadCustomers();
        }
     
        private bool validateData()
        {
            bool status = true;
            var duplicate = customers.Find(obj => obj.Name == txt_customername.Text.Trim() && obj.CustomerType == combobox_group.SelectedItem.ToString() && obj.MobileNo == txt_mobile.Text.Trim() && obj.StudioName == txt_studioName.Text.Trim());
            if (duplicate != null) {
                MessageBox.Show("Duplicate User Found");
                status = false;
            }
            return status;
        }

        private void EnableDisableCustomPrice(bool enable)
        { 
            label_price.Visible = enable;
            label_product.Visible = enable;
            label_customPrice.Visible = enable;
            txt_givenPrice.Visible = enable;
            combobox_products.Visible = enable;
            txt_customPrice.Visible = enable;
            btn_updatePrice.Visible = enable;
        }
      
        private void combo_customPrice_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combo_customPrice.SelectedItem.ToString() == "YES")
            { EnableDisableCustomPrice(true); }
            else
            {
                EnableDisableCustomPrice(false);
            }
            
        }

        private void btn_updatePrice_Click(object sender, EventArgs e)
        {
            custom_price_dict.Add(combobox_products.SelectedItem.ToString(), Convert.ToDouble(txt_customPrice.Text));
            MessageBox.Show("Custom price updated");
        }

        private void combobox_group_SelectedIndexChanged(object sender, EventArgs e)
        {
            combobox_products.DataSource = products.FindAll(obj => obj.Group == combobox_group.SelectedItem?.ToString()).Select(obj => obj.Name).ToList();
        }

        private void combobox_products_SelectedIndexChanged(object sender, EventArgs e)
        {
            ProductItem seleted_product = products.Find(obj => obj.Group == combobox_group.SelectedItem.ToString() && obj.Name == combobox_products.SelectedItem.ToString());
            txt_givenPrice.Text = Convert.ToString(seleted_product.Price);
            if (custom_price_dict.ContainsKey(seleted_product.Name))
            {
                txt_customPrice.Text = Convert.ToString(custom_price_dict[seleted_product.Name]);
            }
            else
            {
                txt_customPrice.Text = string.Empty;
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_customername.Clear();
            txt_mobile.Clear();
            txt_studioName.Clear();
            txt_address.Clear();
            combobox_group.SelectedIndex = 0;
            combo_customPrice.SelectedIndex = 1;
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            var deleteItem = customers.Find(obj => obj.Name == txt_customername.Text.Trim() && obj.CustomerType == combobox_group.SelectedItem.ToString() && obj.MobileNo == txt_mobile.Text.Trim() && obj.StudioName == txt_studioName.Text.Trim());
            customers.Remove(deleteItem);
            Utils.SaveCustomers(customers);
            MessageBox.Show("Deleted successfully");
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            uniqueId = Guid.NewGuid();
            if (ModifyCustomer)
            {
                customers.Remove(searched_customer);
                ModifyCustomer = false;
            }
            if (validateData())
            {
                customers.Add(new CustomerData()
                {
                    ID = uniqueId.ToString(),
                    Name = txt_customername.Text,
                    CustomerType = combobox_group.SelectedItem.ToString(),
                    MobileNo = txt_mobile.Text.Trim(),
                    StudioName = txt_studioName.Text.Trim(),
                    Address = txt_address.Text.Trim(),
                    CustomPriceList = custom_price_dict
                });
                EnableDisableCustomPrice(false);
                Utils.SaveCustomers(customers);
                RefreshData();
                btn_clear.PerformClick();
            }
        }

        private void view_btn_Click(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable("SearchResult");
            dataTable.Columns.Add("Name", typeof(string));
            dataTable.Columns.Add("MobileNo", typeof(string));
            dataTable.Columns.Add("CustomerType", typeof(string));
            dataTable.Columns.Add("StudioName", typeof(string));
            dataTable.Columns.Add("Address", typeof(string));

            string propertyName = searcby_dict[combo_searchby.SelectedItem.ToString()];
            string searchValue = txt_searchText.Text.ToString();
            var search_result = customers.Where(obj => obj.GetType().GetProperty(propertyName).GetValue(obj).ToString().ToLower().Contains(searchValue));//.FindAll(obj => obj.Name == combobox_group.SelectedItem?.ToString()).Select(obj => obj.Name).ToList();

            foreach( var obj in search_result)
            {
                dataTable.Rows.Add(obj.Name,obj.MobileNo, obj.CustomerType, obj.StudioName, obj.Address);
            }

            // Load the DataTable into the UserControl
            CustomDataGridViewUserControl dataTablePreviewControl = new CustomDataGridViewUserControl();
            dataTablePreviewControl.LoadDataTable(dataTable);

            // Show the DataTablePreviewControl as a dialog
            using (Form dialogForm = new Form())
            {
                dialogForm.Text = "Search Result";
                dialogForm.ClientSize = new System.Drawing.Size(600, 400);
                dialogForm.Controls.Add(dataTablePreviewControl);
                dataTablePreviewControl.Dock = DockStyle.Fill;
                dialogForm.ShowDialog();
            }

            if (dataTablePreviewControl.Result)
            {
                int seleted_ind = dataTablePreviewControl.SeletedRow;
                string name = dataTable.Rows[seleted_ind]["Name"].ToString();
                string studio = dataTable.Rows[seleted_ind]["StudioName"].ToString();
                string mobile = dataTable.Rows[seleted_ind]["MobileNo"].ToString();
                string type = dataTable.Rows[seleted_ind]["CustomerType"].ToString();
                string address = dataTable.Rows[seleted_ind]["Address"].ToString();
                searched_customer = customers.Find(obj => obj.Name == name && obj.StudioName == studio
                                        && obj.MobileNo == mobile && obj.CustomerType == type
                                        && obj.Address == address);

                txt_customername.Text = name;
                combobox_group.SelectedIndex = combobox_group.FindStringExact(type);
                txt_mobile.Text = mobile;
                txt_studioName.Text = studio;
                txt_address.Text = address;
                if (searched_customer.CustomPriceList != null)
                {
                    custom_price_dict = searched_customer.CustomPriceList;
                    //combobox_products.DataSource = products.FindAll(obj => obj.Group == combobox_group.SelectedItem?.ToString()).Select(obj => obj.Name).ToList();
                    combo_customPrice.SelectedIndex = 0;
                }
                ModifyCustomer = true; 
            }

        }


        private void txt_searchText_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                view_btn.PerformClick();
            }
        }

    }
}
