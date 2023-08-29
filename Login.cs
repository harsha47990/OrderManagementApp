using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;


namespace OrderManagementApp
{
    public partial class Login : Form
    {
        
        public Login()
        {
            InitializeComponent();
            MasterPage mf = new MasterPage();
            //Form1 mf =      new Form1();
            mf.ShowDialog();    
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            string jsonFilePath = CodeConfig.jsonFilePath;

            // Check if the JSON file exists
            if (!File.Exists(jsonFilePath))
            {
                MessageBox.Show("create admin user account");
                create_user cu = new create_user(true);
                cu.ShowDialog();
            }
            try
            {
                // Read the entire JSON file as a string
                string jsonString = File.ReadAllText(jsonFilePath);

                // Deserialize the JSON string to a strongly-typed object

                List<UserDetails> users = JsonSerializer.Deserialize<List<UserDetails>>(jsonString);

                foreach (UserDetails user in users)
                {
                    if (user.username == textbox_username.Text.ToLower())
                    {
                        if (user.password == textbox_password.Text)
                        {
                            MessageBox.Show("login success");
                            textbox_password.Clear();
                            textbox_username.Clear();

                            if (user.user_type == CodeConfig.user_type_admin_var)
                            {
                                CodeConfig.admin_login = true;
                            }
                            else
                            {
                                CodeConfig.admin_login = false;
                            }
                            //this.Close();
                            //Form1 f1 = new Form1(); 
                           // f1.ShowDialog();    
                           // return;
                        }
                        else
                        {
                            MessageBox.Show("wrong password, login failed");
                            return;
                        }
                    }
                }

                MessageBox.Show("user details failed");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error reading or parsing the JSON file: " + ex.Message);
            }

        }

        public class UserDetails
        {
            public string username { get; set; }
            public string password { get; set; }
            public string user_type { get; set; }   
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!File.Exists(CodeConfig.jsonFilePath))
            {
                MessageBox.Show("create admin user account");
                create_user cu = new create_user(true);
                cu.ShowDialog();
            }
            else
            {
                create_user cu = new create_user(false);
                cu.ShowDialog();
            }
        }

        private void textbox_password_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                button_login.PerformClick();
            }
        }

        private void textbox_username_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.ProcessTabKey(true);
            }
        }
    }
}
