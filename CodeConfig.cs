using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace OrderManagementApp
{
    static class CodeConfig
    {
        public const string jsonFilePath = "logindetails.json";

        public const string ProcessOptionTypes = "ProcessOptionTypes.json";

        public static readonly List<string> PaymentTypes = new List<string> {
            "Cash",
            "PhonePe",
            "GooglePe",
            "BharatPe",
            "Other"
        };
        public const string CustomersOrdersJson = "CustomersOrders.json";
        public const string OrdersPath = "C:\\Users\\harsh\\source\\repos\\OrderManagementApp\\bin\\Debug\\orders";

        public const string user_type_admin_var = "admin user";

        public const string string_Studio = "Studio";

        public const string string_Amature = "Amature";

        public const string process_json_path = "processes.json";

        public const string CustomerDetails_json_path = "CustomerDetails.json";

        public const string productItems_json_path = "ProductItems.json";

        public const int user_type_normal_index = 0;

        public static bool admin_login = false;
    }

    static class Utils
    {
        public static List<CustomerData> LoadCustomers()
        {
            List<CustomerData> customers = new List<CustomerData>();
            string filePath = CodeConfig.CustomerDetails_json_path;
            if (File.Exists(filePath))
            {
                string jsonString = File.ReadAllText(filePath);
                customers = JsonSerializer.Deserialize<List<CustomerData>>(jsonString);
            }

            return customers;
        }

        public static bool SaveCustomers(List<CustomerData> customers)
        {
            try
            {
                string Data = JsonSerializer.Serialize(customers);
                File.WriteAllText(CodeConfig.CustomerDetails_json_path, Data);
                return true;
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }

        public static bool SaveOrderDetails(Order order_item)
        {
            try
            {
                string jsonString = String.Empty;
                Dictionary<string, List<string>> co_list = new Dictionary<string, List<string>>();
                if (File.Exists(CodeConfig.CustomersOrdersJson))
                {
                    jsonString = File.ReadAllText(CodeConfig.CustomersOrdersJson);
                    co_list = JsonSerializer.Deserialize<Dictionary<string, List<string>>>(jsonString);
                }
                if (co_list.ContainsKey(order_item.CustomerId))
                {
                    co_list[order_item.CustomerId].Add(order_item.ID);
                }
                else
                {
                    co_list[order_item.CustomerId] = new List<string> { order_item.ID };
                }
                string Data = JsonSerializer.Serialize(co_list);
                File.WriteAllText(CodeConfig.CustomersOrdersJson, Data);


                string save_path = Path.Combine(CodeConfig.OrdersPath,order_item.ID.ToString()+".json");
                Data = JsonSerializer.Serialize(order_item);
                File.WriteAllText(save_path, Data);
                return true;
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return false;
        }
        public static List<ProcessClass> ReadProcesses()
        {
            List<ProcessClass> processes = new List<ProcessClass>();
            string filePath = CodeConfig.process_json_path;
            if (File.Exists(filePath))
            {
                string jsonString = File.ReadAllText(filePath);
                processes = JsonSerializer.Deserialize<List<ProcessClass>>(jsonString);

            }
            return processes;
        }

        public static List<ProductItem> LoadProducts()
        {
            List<ProductItem> products = new List<ProductItem>();
            string filePath = CodeConfig.productItems_json_path;
            if (File.Exists(filePath))
            {
                string jsonString = File.ReadAllText(filePath);
                products = JsonSerializer.Deserialize<List<ProductItem>>(jsonString);
            }

            return products;


                return new List<ProductItem>
            {
                new ProductItem { Name = "Item 1", Price = 10.0, AvailableQuantity=100 },
                new ProductItem { Name = "Item 2", Price = 25.0, AvailableQuantity=100 },
                new ProductItem { Name = "cat 1", Price = 33.0, AvailableQuantity=100 },
                new ProductItem { Name = "cow 2", Price = 45.0, AvailableQuantity=100 },
                new ProductItem { Name = "deep 1", Price = 50.0, AvailableQuantity=100 },
                new ProductItem { Name = "donkey 2", Price = 65.0, AvailableQuantity=100 }
            };

        }

        public static bool SaveProducts(List<ProductItem> products)
        {
            try
            {
                string Data = JsonSerializer.Serialize(products);
                File.WriteAllText(CodeConfig.productItems_json_path, Data);
                return true;
            }
            catch { return false; } 
        }

    }
    
    public class CustomerOrderClass
    {
        public string CustomerId { get; set; }
        public List<string> orders { get; set; }
    }
    public class Order
    {
        public string ID { get; set; }
        public string CustomerId { get; set; }
        public string ProcessType { get; set; }
        public double TotalAmount { get; set; }
        public double Due { get; set; }
        public string PaymentType { get; set; }
        public string Comments { get; set; }
        public List<OrderedItem> Items { get; set; }

    }
    public class CustomerData
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string MobileNo { get; set; }
        public string CustomerType { get; set; }
        public string StudioName { get; set; }
        public string Address { get; set; } 
        public Dictionary<string,double> CustomPriceList { get; set; }
    }

    public class ProductItem
    {
        public string ID { get; set; }  
        public string Name { get; set; }
        public double Price { get; set; }
        public string Group { get; set; }   
        public int AvailableQuantity { get; set; }
        public bool IgnoreQuantity { get; set; }
        public ProductItem()
        {
            IgnoreQuantity = true; 
        }
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

    public class ProgressDataGridItems
    {
        public int OrderID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Options { get; set; }
        public int Progress { get; set; }
        public string Status { get; set; }
    }

    public class ProcessClass
    {
        public string Name { get; set; }
        public List<string> Steps { get; set; }

        public ProcessClass(string name, List<string> steps)
        {
            Name = name;
            Steps = steps;
        }
    }

}
