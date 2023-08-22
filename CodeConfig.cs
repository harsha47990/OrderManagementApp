using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace OrderManagementApp
{
    static class CodeConfig
    {
        public const string jsonFilePath = "logindetails.json";

        public const string ProcessOptionTypes = "ProcessOptionTypes.json";

        public const string user_type_admin_var = "admin user";

        public const string process_json_path = "processes.json";

        public const int user_type_normal_index = 0;

        public static bool admin_login = false;
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
