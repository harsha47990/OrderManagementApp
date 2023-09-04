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
using static OrderManagementApp.Login;

namespace OrderManagementApp
{
    public partial class create_user : Form
    {
        bool first_time = false;
        public create_user(bool firsttime)
        {
            first_time = firsttime;
            InitializeComponent();
            listbox_usertype.Items.Add("normal user");
            listbox_usertype.Items.Add("admin user");

            if (firsttime)
            {
                listbox_usertype.SelectedIndex = 1;
                listbox_usertype.Enabled = false;
            }
            else
            {
                listbox_usertype.SelectedIndex = 0;
            }
        }


        private void button_save_Click(object sender, EventArgs e)
        {
            if (textbox_username.Text == string.Empty || textbox_password.Text == string.Empty)
            {
                MessageBox.Show("USERNAME AND PASSWORDS CAN'T BE EMPTY");
                return;
            }
            if (textbox_password.Text != textbox_reenter.Text)
            {
                MessageBox.Show("PASSWORDS DO NOT MATCH");
                return;

            }
            
            List<UserDetails> users;

            //if the JSON file exists
            if (File.Exists(Path.Combine(CodeConfig.DataStorageFolder, CodeConfig.LoginDetailsJsonFilePath)))
            {
                string jsonString = File.ReadAllText(Path.Combine(CodeConfig.DataStorageFolder, CodeConfig.LoginDetailsJsonFilePath));
                users = JsonSerializer.Deserialize<List<UserDetails>>(jsonString);
                foreach (UserDetails user in users)
                {
                   if (user.username == textbox_username.Text.ToLower())
                    {
                        MessageBox.Show("USERNAME EXISTS, USE DIFFERENT USERNAME");
                        return;
                    }
                }
               
            }
            // if the JSON doesnt exists
            else
            {users = new List<UserDetails>();}


            UserDetails new_user = new UserDetails();
            new_user.username = textbox_username.Text;
            new_user.password = textbox_password.Text;
            new_user.user_type = listbox_usertype.Text;
            if (!verify_admin_type())
            {
                return;
            }
            users.Add(new_user);
            string json_string = JsonSerializer.Serialize(users, new JsonSerializerOptions
            {
                WriteIndented = true // Set to true for pretty-printing
            });

            // Save the JSON string to a file
            File.WriteAllText(Path.Combine(CodeConfig.DataStorageFolder, CodeConfig.LoginDetailsJsonFilePath), json_string);

            MessageBox.Show("Account created!!!");
            this.Hide();
                
        }

        private bool verify_admin_type()
        { 
            if (listbox_usertype.SelectedIndex == CodeConfig.user_type_normal_index) {
                return true;
            }
            else if(first_time || CodeConfig.admin_login)
            {
                return true;
            }
            else
            {
                MessageBox.Show("only an admin can create an admin account, login with admin credentials");
                Login lgn = new Login();
                lgn.ShowDialog();
                if (CodeConfig.admin_login)
                {
                    return true;
                }
            }

            return false;
        }

        private void textbox_username_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.ProcessTabKey(true);
            }
        }

        private void textbox_password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.ProcessTabKey(true);
            }
        }

        private void textbox_reenter_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.ProcessTabKey(true);
            }
        }
    }
}
