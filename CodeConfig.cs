using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Windows.Forms;
using static OrderManagementApp.Login;

namespace OrderManagementApp
{
    static class CodeConfig
    {
        public static string DataStorageFolder  = ConfigurationManager.AppSettings["DataStorageFolder"].ToString();
       
        public const string LoginDetailsJsonFilePath = "logindetails.json";

        public const string ProcessOptionTypes = "ProcessOptionTypes.json";

        public const string OrderProgressPath = "OrderProgress.json";

        public static readonly List<string> PaymentTypes = new List<string> {
            "Cash",
            "PhonePe",
            "GooglePe",
            "BharatPe",
            "Other"
        };
        public const string CustomersOrdersJson = "CustomersOrders.json";
        public const string OrdersPath = "orders";

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
        public static List<CustomerData> ReadCustomers()
        {
            List<CustomerData> customers = new List<CustomerData>();
            try
            {
                string filePath = Path.Combine(CodeConfig.DataStorageFolder, CodeConfig.CustomerDetails_json_path);

                if (File.Exists(filePath))
                {
                    string jsonString = File.ReadAllText(filePath);
                    customers = JsonSerializer.Deserialize<List<CustomerData>>(jsonString);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("error in LoadCustomers, " + ex.Message);
            }

            return customers;
        }

        public static List<UserDetails> ReadUsersData()
        {
            List<UserDetails> users = new List<UserDetails>();

            try
            {
                string jsonFilePath = Path.Combine(CodeConfig.DataStorageFolder, CodeConfig.LoginDetailsJsonFilePath);
                string jsonString = File.ReadAllText(jsonFilePath);

                users = JsonSerializer.Deserialize<List<UserDetails>>(jsonString);
            }
            catch (Exception ex)
            {
                MessageBox.Show("error in ReadUsersData, " + ex.Message);
            }

            return users;

        }
        public static void SaveProcessData(List<ProcessClass> SaveProcesses)
        {
            try
            {
                string Data = JsonSerializer.Serialize<List<ProcessClass>>(SaveProcesses);
                File.WriteAllText(Path.Combine(CodeConfig.DataStorageFolder, CodeConfig.process_json_path), Data);
            }

            catch (Exception ex)
            {
                MessageBox.Show("error in SaveProcessData, " + ex.Message);
            }
        }

        public static CustomerData GetCustomerDataFromID(string id)
        {
            CustomerData SelectedCustomer = new CustomerData();
            try
            {
                var customerData = ReadCustomers();
                foreach (var customer in customerData)
                {
                    if (customer.ID == id)
                    {
                        SelectedCustomer = customer;
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("error in GetCustomerDataFromID, " + ex.Message);
            }
            return SelectedCustomer;
        }

        public static List<string> GetStagesOftheProcess(string ProcessName)
        {
            List<string> stages = new List<string>();
            try
            {
                var processes = ReadProcesses();
                foreach (var process in processes)
                {
                    if (process.Name == ProcessName)
                    {
                        stages = process.Steps;
                        break;
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("error in GetStagesOftheProcess, " + ex.Message);
            }
            return stages;
        }
        public static bool SaveCustomers(List<CustomerData> customers)
        {
            try
            {
                string Data = JsonSerializer.Serialize(customers);
                File.WriteAllText(Path.Combine(CodeConfig.DataStorageFolder,CodeConfig.CustomerDetails_json_path), Data);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("error in SaveCustomers, " + ex.Message);
                return false;
            }
           
        }

        public static void SaveOrderJsonFile(Order order_item)
        {
            string save_path = Path.Combine(CodeConfig.DataStorageFolder, CodeConfig.OrdersPath, order_item.ID.ToString() + ".json");
            string Data = JsonSerializer.Serialize(order_item);
            File.WriteAllText(save_path, Data);
        }
        public static void UpdateCustomer_OrderJson(Order order_item)
        {
            string jsonString = String.Empty;
            Dictionary<string, List<string>> co_list = new Dictionary<string, List<string>>();
            if (File.Exists(Path.Combine(CodeConfig.DataStorageFolder, CodeConfig.CustomersOrdersJson)))
            {
                jsonString = File.ReadAllText(Path.Combine(CodeConfig.DataStorageFolder, CodeConfig.CustomersOrdersJson));
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
            File.WriteAllText(Path.Combine(CodeConfig.DataStorageFolder, CodeConfig.CustomersOrdersJson), Data);

        }
        public static bool SaveNewOrder(Order order_item)
        {
            try
            {
                //saving order details in customer-order json
                UpdateCustomer_OrderJson(order_item);

                //saving OrderJson data
                SaveOrderJsonFile(order_item);


                //saving Order process data 
                SaveOrderProcessData(order_item);

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("error in SaveOrderDetails, " + ex.Message);
            }
            return false;
        }
        public static Dictionary<string, Tuple<string, string>> ReadOrderProcessData()
        {
            Dictionary<string, Tuple<string, string>> OrderProcessData = new Dictionary<string, Tuple<string, string>>();
            try
            {
                if (File.Exists(CodeConfig.OrderProgressPath))
                {
                    string jsonString = File.ReadAllText(CodeConfig.OrderProgressPath);
                    OrderProcessData = JsonSerializer.Deserialize<Dictionary<string, Tuple<string, string>>>(jsonString);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("error in GetOrderProcessData, " + ex.Message);
            }
            return OrderProcessData;
        }
        public static void SaveOrderProcessData(Order order_item)
        {
            Dictionary<string, Tuple<string, string>> OrderProcessData = new Dictionary<string, Tuple<string, string>>();
            string jsonString = string.Empty, Data = string.Empty;
            try
            {
                if (File.Exists(CodeConfig.OrderProgressPath))
                {
                    jsonString = File.ReadAllText(CodeConfig.OrderProgressPath);
                    OrderProcessData = JsonSerializer.Deserialize<Dictionary<string, Tuple<string, string>>>(jsonString);
                }
                OrderProcessData[order_item.ID] = Tuple.Create(order_item.ProcessType, order_item.StatusProgress.Last()); //(order_item.ProcessType,order_item.StatusProgress[0]);
                Data = JsonSerializer.Serialize(OrderProcessData);
                File.WriteAllText(CodeConfig.OrderProgressPath, Data);
            }
            catch (Exception ex)
            {
                MessageBox.Show("error in SaveOrderProcessData, " + ex.Message);
            }
        }
        public static List<ProcessClass> ReadProcesses()
        {
            List<ProcessClass> processes = new List<ProcessClass>();
            try
            {
                string filePath = Path.Combine(CodeConfig.DataStorageFolder, CodeConfig.process_json_path);
                if (File.Exists(filePath))
                {
                    string jsonString = File.ReadAllText(filePath);
                    processes = JsonSerializer.Deserialize<List<ProcessClass>>(jsonString);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("error in ReadProcesses, " + ex.Message);
            }
            return processes;
        }

        public static List<ProductItem> ReadProducts()
        {
            List<ProductItem> products = new List<ProductItem>();
            try
            {
                string filePath = Path.Combine(CodeConfig.DataStorageFolder, CodeConfig.productItems_json_path);
                if (File.Exists(filePath))
                {
                    string jsonString = File.ReadAllText(filePath);
                    products = JsonSerializer.Deserialize<List<ProductItem>>(jsonString);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("error in LoadProducts, " + ex.Message);
            }
            return products;
        }

        public static Order ReadOrderData(string OrderId)
        {
            Order orderData = new Order();
            try
            {
                string order_path = Path.Combine(CodeConfig.DataStorageFolder, CodeConfig.OrdersPath, OrderId + ".json");
                string jsonString = File.ReadAllText(order_path);
                orderData = JsonSerializer.Deserialize<Order>(jsonString);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("error in ReadOrderData, " + ex.Message);
            }
            return orderData;

        }
        public static void UpdateOrderStatus(string OrderID,string CurrentStatus)
        {
            Dictionary<string, Tuple<string, string>> OrderProcessData = new Dictionary<string, Tuple<string, string>>();
            string jsonString = string.Empty, Data = string.Empty;
            try
            {
                //updating OrderProcessJson
                if (File.Exists(CodeConfig.OrderProgressPath))
                {
                    jsonString = File.ReadAllText(CodeConfig.OrderProgressPath);
                    OrderProcessData = JsonSerializer.Deserialize<Dictionary<string, Tuple<string, string>>>(jsonString);
                }
                Tuple<string,string> values = OrderProcessData[OrderID];
                OrderProcessData[OrderID] = Tuple.Create(values.Item1, CurrentStatus); //(order_item.ProcessType,order_item.StatusProgress[0]);
                Data = JsonSerializer.Serialize(OrderProcessData);
                File.WriteAllText(CodeConfig.OrderProgressPath, Data);
                //updating OrderJson
                var order_data = ReadOrderData(OrderID);
                order_data.StatusProgress.Add(CurrentStatus);
                order_data.DateTimeProgress.Add(DateTime.Now.ToString());
                SaveOrderProcessData(order_data);
                SaveOrderJsonFile(order_data);
            }
            catch (Exception ex)
            {
                MessageBox.Show("error in UpdateOrderStatus, " + ex.Message);
            }
        }
        public static bool SaveProducts(List<ProductItem> products)
        {
            try
            {
                string Data = JsonSerializer.Serialize(products);
                File.WriteAllText(Path.Combine(CodeConfig.DataStorageFolder, CodeConfig.productItems_json_path), Data);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("error in SaveProducts, " + ex.Message);
                return false;
            }
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
        
        public List<string> StatusProgress { get; set; }
        public List<string> DateTimeProgress { get; set; }

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
        public string OrderID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Process_Type { get; set; }
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
