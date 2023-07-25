namespace OrderManagementApp
{
    partial class create_user
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textbox_username = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listbox_usertype = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button_save = new System.Windows.Forms.Button();
            this.textbox_password = new System.Windows.Forms.TextBox();
            this.textbox_reenter = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textbox_username
            // 
            this.textbox_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_username.Location = new System.Drawing.Point(229, 46);
            this.textbox_username.Multiline = false;
            this.textbox_username.Name = "textbox_username";
            this.textbox_username.Size = new System.Drawing.Size(307, 40);
            this.textbox_username.TabIndex = 1;
            this.textbox_username.Text = "";
            this.textbox_username.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textbox_username_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(93, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "PASSWORD :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(93, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "USER NAME :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(107, 172);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 21);
            this.label1.TabIndex = 9;
            this.label1.Text = "RE ENTER :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listbox_usertype
            // 
            this.listbox_usertype.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listbox_usertype.FormattingEnabled = true;
            this.listbox_usertype.ItemHeight = 27;
            this.listbox_usertype.Items.AddRange(new object[] {
            "normal user",
            "admin user"});
            this.listbox_usertype.Location = new System.Drawing.Point(229, 228);
            this.listbox_usertype.Name = "listbox_usertype";
            this.listbox_usertype.Size = new System.Drawing.Size(307, 31);
            this.listbox_usertype.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(96, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 21);
            this.label4.TabIndex = 12;
            this.label4.Text = "USER TYPE :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_save
            // 
            this.button_save.BackColor = System.Drawing.Color.Gold;
            this.button_save.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_save.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_save.Location = new System.Drawing.Point(229, 301);
            this.button_save.Margin = new System.Windows.Forms.Padding(0);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(191, 46);
            this.button_save.TabIndex = 5;
            this.button_save.Text = "SAVE";
            this.button_save.UseVisualStyleBackColor = false;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // textbox_password
            // 
            this.textbox_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_password.Location = new System.Drawing.Point(229, 105);
            this.textbox_password.Name = "textbox_password";
            this.textbox_password.Size = new System.Drawing.Size(307, 35);
            this.textbox_password.TabIndex = 2;
            this.textbox_password.UseSystemPasswordChar = true;
            this.textbox_password.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textbox_password_KeyDown);
            // 
            // textbox_reenter
            // 
            this.textbox_reenter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_reenter.Location = new System.Drawing.Point(229, 166);
            this.textbox_reenter.Name = "textbox_reenter";
            this.textbox_reenter.Size = new System.Drawing.Size(307, 35);
            this.textbox_reenter.TabIndex = 3;
            this.textbox_reenter.UseSystemPasswordChar = true;
            this.textbox_reenter.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textbox_reenter_KeyDown);
            // 
            // create_user
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(629, 389);
            this.Controls.Add(this.textbox_reenter);
            this.Controls.Add(this.textbox_password);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listbox_usertype);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textbox_username);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.MaximizeBox = false;
            this.Name = "create_user";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "create_user";
            this.Load += new System.EventHandler(this.create_user_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        
        private System.Windows.Forms.RichTextBox textbox_username;
        private System.Windows.Forms.ListBox listbox_usertype;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
       
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.TextBox textbox_password;
        private System.Windows.Forms.TextBox textbox_reenter;
    }
}