namespace EasyDnsChanger
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.DnsList_PANEL = new System.Windows.Forms.Panel();
            this.Add_DNS_PANEL = new System.Windows.Forms.Panel();
            this.Cancel_DNS_BUTTON = new System.Windows.Forms.Button();
            this.Save_DNS_BUTTON = new System.Windows.Forms.Button();
            this.DNS2_TEXTBOX = new System.Windows.Forms.TextBox();
            this.DNS1_TEXTBOX = new System.Windows.Forms.TextBox();
            this.DNS_Name_TEXTBOX = new System.Windows.Forms.TextBox();
            this.DNS2_Title_LABEL = new System.Windows.Forms.Label();
            this.DNS1_Title_LABEL = new System.Windows.Forms.Label();
            this.DNSName_Title_LABEL = new System.Windows.Forms.Label();
            this.AddDns_BUTTON = new System.Windows.Forms.Button();
            this.Minimize_BUTTON = new System.Windows.Forms.Button();
            this.Exit_BUTTON = new System.Windows.Forms.Button();
            this.Network_Title_LABEL = new System.Windows.Forms.Label();
            this.Network_COMBOBOX = new System.Windows.Forms.ComboBox();
            this.CurrentDNS_Title_LABEL = new System.Windows.Forms.Label();
            this.CurrentDNS_Value_LABEL = new System.Windows.Forms.Label();
            this.Tray_NOTIFY = new System.Windows.Forms.NotifyIcon(this.components);
            this.Add_DNS_PANEL.SuspendLayout();
            this.SuspendLayout();
            // 
            // DnsList_PANEL
            // 
            this.DnsList_PANEL.AutoScroll = true;
            this.DnsList_PANEL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.DnsList_PANEL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DnsList_PANEL.Location = new System.Drawing.Point(12, 47);
            this.DnsList_PANEL.Name = "DnsList_PANEL";
            this.DnsList_PANEL.Size = new System.Drawing.Size(688, 359);
            this.DnsList_PANEL.TabIndex = 0;
            // 
            // Add_DNS_PANEL
            // 
            this.Add_DNS_PANEL.BackColor = System.Drawing.Color.Gray;
            this.Add_DNS_PANEL.Controls.Add(this.Cancel_DNS_BUTTON);
            this.Add_DNS_PANEL.Controls.Add(this.Save_DNS_BUTTON);
            this.Add_DNS_PANEL.Controls.Add(this.DNS2_TEXTBOX);
            this.Add_DNS_PANEL.Controls.Add(this.DNS1_TEXTBOX);
            this.Add_DNS_PANEL.Controls.Add(this.DNS_Name_TEXTBOX);
            this.Add_DNS_PANEL.Controls.Add(this.DNS2_Title_LABEL);
            this.Add_DNS_PANEL.Controls.Add(this.DNS1_Title_LABEL);
            this.Add_DNS_PANEL.Controls.Add(this.DNSName_Title_LABEL);
            this.Add_DNS_PANEL.Enabled = false;
            this.Add_DNS_PANEL.Location = new System.Drawing.Point(202, 127);
            this.Add_DNS_PANEL.Name = "Add_DNS_PANEL";
            this.Add_DNS_PANEL.Size = new System.Drawing.Size(303, 186);
            this.Add_DNS_PANEL.TabIndex = 0;
            this.Add_DNS_PANEL.Visible = false;
            // 
            // Cancel_DNS_BUTTON
            // 
            this.Cancel_DNS_BUTTON.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Cancel_DNS_BUTTON.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Cancel_DNS_BUTTON.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancel_DNS_BUTTON.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Cancel_DNS_BUTTON.Location = new System.Drawing.Point(21, 143);
            this.Cancel_DNS_BUTTON.Name = "Cancel_DNS_BUTTON";
            this.Cancel_DNS_BUTTON.Size = new System.Drawing.Size(85, 28);
            this.Cancel_DNS_BUTTON.TabIndex = 7;
            this.Cancel_DNS_BUTTON.Text = "Cancel";
            this.Cancel_DNS_BUTTON.UseVisualStyleBackColor = false;
            this.Cancel_DNS_BUTTON.Click += new System.EventHandler(this.Cancel_DNS_BUTTON_Click);
            // 
            // Save_DNS_BUTTON
            // 
            this.Save_DNS_BUTTON.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Save_DNS_BUTTON.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Save_DNS_BUTTON.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Save_DNS_BUTTON.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Save_DNS_BUTTON.Location = new System.Drawing.Point(189, 143);
            this.Save_DNS_BUTTON.Name = "Save_DNS_BUTTON";
            this.Save_DNS_BUTTON.Size = new System.Drawing.Size(85, 28);
            this.Save_DNS_BUTTON.TabIndex = 6;
            this.Save_DNS_BUTTON.Text = "Save";
            this.Save_DNS_BUTTON.UseVisualStyleBackColor = false;
            this.Save_DNS_BUTTON.Click += new System.EventHandler(this.Save_DNS_BUTTON_Click);
            // 
            // DNS2_TEXTBOX
            // 
            this.DNS2_TEXTBOX.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DNS2_TEXTBOX.Location = new System.Drawing.Point(112, 90);
            this.DNS2_TEXTBOX.Name = "DNS2_TEXTBOX";
            this.DNS2_TEXTBOX.Size = new System.Drawing.Size(162, 21);
            this.DNS2_TEXTBOX.TabIndex = 5;
            // 
            // DNS1_TEXTBOX
            // 
            this.DNS1_TEXTBOX.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DNS1_TEXTBOX.Location = new System.Drawing.Point(112, 54);
            this.DNS1_TEXTBOX.Name = "DNS1_TEXTBOX";
            this.DNS1_TEXTBOX.Size = new System.Drawing.Size(162, 21);
            this.DNS1_TEXTBOX.TabIndex = 4;
            // 
            // DNS_Name_TEXTBOX
            // 
            this.DNS_Name_TEXTBOX.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DNS_Name_TEXTBOX.Location = new System.Drawing.Point(112, 20);
            this.DNS_Name_TEXTBOX.Name = "DNS_Name_TEXTBOX";
            this.DNS_Name_TEXTBOX.Size = new System.Drawing.Size(162, 21);
            this.DNS_Name_TEXTBOX.TabIndex = 3;
            // 
            // DNS2_Title_LABEL
            // 
            this.DNS2_Title_LABEL.AutoSize = true;
            this.DNS2_Title_LABEL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DNS2_Title_LABEL.Location = new System.Drawing.Point(16, 93);
            this.DNS2_Title_LABEL.Name = "DNS2_Title_LABEL";
            this.DNS2_Title_LABEL.Size = new System.Drawing.Size(60, 15);
            this.DNS2_Title_LABEL.TabIndex = 2;
            this.DNS2_Title_LABEL.Text = "DNS 2 : ";
            // 
            // DNS1_Title_LABEL
            // 
            this.DNS1_Title_LABEL.AutoSize = true;
            this.DNS1_Title_LABEL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DNS1_Title_LABEL.Location = new System.Drawing.Point(16, 57);
            this.DNS1_Title_LABEL.Name = "DNS1_Title_LABEL";
            this.DNS1_Title_LABEL.Size = new System.Drawing.Size(60, 15);
            this.DNS1_Title_LABEL.TabIndex = 1;
            this.DNS1_Title_LABEL.Text = "DNS 1 : ";
            // 
            // DNSName_Title_LABEL
            // 
            this.DNSName_Title_LABEL.AutoSize = true;
            this.DNSName_Title_LABEL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DNSName_Title_LABEL.Location = new System.Drawing.Point(16, 23);
            this.DNSName_Title_LABEL.Name = "DNSName_Title_LABEL";
            this.DNSName_Title_LABEL.Size = new System.Drawing.Size(90, 15);
            this.DNSName_Title_LABEL.TabIndex = 0;
            this.DNSName_Title_LABEL.Text = "DNS Name : ";
            // 
            // AddDns_BUTTON
            // 
            this.AddDns_BUTTON.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.AddDns_BUTTON.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddDns_BUTTON.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddDns_BUTTON.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.AddDns_BUTTON.Location = new System.Drawing.Point(12, 412);
            this.AddDns_BUTTON.Name = "AddDns_BUTTON";
            this.AddDns_BUTTON.Size = new System.Drawing.Size(85, 28);
            this.AddDns_BUTTON.TabIndex = 1;
            this.AddDns_BUTTON.Text = "ADD DNS";
            this.AddDns_BUTTON.UseVisualStyleBackColor = false;
            this.AddDns_BUTTON.Click += new System.EventHandler(this.AddDns_BUTTON_Click);
            // 
            // Minimize_BUTTON
            // 
            this.Minimize_BUTTON.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Minimize_BUTTON.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Minimize_BUTTON.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Minimize_BUTTON.ForeColor = System.Drawing.Color.Yellow;
            this.Minimize_BUTTON.Location = new System.Drawing.Point(311, 412);
            this.Minimize_BUTTON.Name = "Minimize_BUTTON";
            this.Minimize_BUTTON.Size = new System.Drawing.Size(85, 28);
            this.Minimize_BUTTON.TabIndex = 2;
            this.Minimize_BUTTON.Text = "Minimize";
            this.Minimize_BUTTON.UseVisualStyleBackColor = false;
            this.Minimize_BUTTON.Click += new System.EventHandler(this.Minimize_BUTTON_Click);
            // 
            // Exit_BUTTON
            // 
            this.Exit_BUTTON.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Exit_BUTTON.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Exit_BUTTON.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit_BUTTON.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Exit_BUTTON.Location = new System.Drawing.Point(614, 412);
            this.Exit_BUTTON.Name = "Exit_BUTTON";
            this.Exit_BUTTON.Size = new System.Drawing.Size(85, 28);
            this.Exit_BUTTON.TabIndex = 3;
            this.Exit_BUTTON.Text = "Exit";
            this.Exit_BUTTON.UseVisualStyleBackColor = false;
            this.Exit_BUTTON.Click += new System.EventHandler(this.Exit_BUTTON_Click);
            // 
            // Network_Title_LABEL
            // 
            this.Network_Title_LABEL.AutoSize = true;
            this.Network_Title_LABEL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Network_Title_LABEL.ForeColor = System.Drawing.Color.Silver;
            this.Network_Title_LABEL.Location = new System.Drawing.Point(12, 15);
            this.Network_Title_LABEL.Name = "Network_Title_LABEL";
            this.Network_Title_LABEL.Size = new System.Drawing.Size(131, 17);
            this.Network_Title_LABEL.TabIndex = 4;
            this.Network_Title_LABEL.Text = "Select Network : ";
            // 
            // Network_COMBOBOX
            // 
            this.Network_COMBOBOX.FormattingEnabled = true;
            this.Network_COMBOBOX.Location = new System.Drawing.Point(149, 14);
            this.Network_COMBOBOX.Name = "Network_COMBOBOX";
            this.Network_COMBOBOX.Size = new System.Drawing.Size(238, 21);
            this.Network_COMBOBOX.TabIndex = 5;
            this.Network_COMBOBOX.SelectedIndexChanged += new System.EventHandler(this.Network_COMBOBOX_SelectedIndexChanged);
            // 
            // CurrentDNS_Title_LABEL
            // 
            this.CurrentDNS_Title_LABEL.AutoSize = true;
            this.CurrentDNS_Title_LABEL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentDNS_Title_LABEL.ForeColor = System.Drawing.Color.Silver;
            this.CurrentDNS_Title_LABEL.Location = new System.Drawing.Point(416, 15);
            this.CurrentDNS_Title_LABEL.Name = "CurrentDNS_Title_LABEL";
            this.CurrentDNS_Title_LABEL.Size = new System.Drawing.Size(114, 17);
            this.CurrentDNS_Title_LABEL.TabIndex = 6;
            this.CurrentDNS_Title_LABEL.Text = "Current DNS : ";
            // 
            // CurrentDNS_Value_LABEL
            // 
            this.CurrentDNS_Value_LABEL.AutoSize = true;
            this.CurrentDNS_Value_LABEL.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentDNS_Value_LABEL.ForeColor = System.Drawing.Color.Yellow;
            this.CurrentDNS_Value_LABEL.Location = new System.Drawing.Point(536, 11);
            this.CurrentDNS_Value_LABEL.Name = "CurrentDNS_Value_LABEL";
            this.CurrentDNS_Value_LABEL.Size = new System.Drawing.Size(61, 13);
            this.CurrentDNS_Value_LABEL.TabIndex = 7;
            this.CurrentDNS_Value_LABEL.Text = "dns-name";
            this.CurrentDNS_Value_LABEL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Tray_NOTIFY
            // 
            this.Tray_NOTIFY.Icon = ((System.Drawing.Icon)(resources.GetObject("Tray_NOTIFY.Icon")));
            this.Tray_NOTIFY.Text = "Easy DNS Changer";
            this.Tray_NOTIFY.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Tray_NOTIFY_MouseDoubleClick);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(711, 452);
            this.Controls.Add(this.Add_DNS_PANEL);
            this.Controls.Add(this.CurrentDNS_Value_LABEL);
            this.Controls.Add(this.CurrentDNS_Title_LABEL);
            this.Controls.Add(this.Network_COMBOBOX);
            this.Controls.Add(this.Network_Title_LABEL);
            this.Controls.Add(this.Exit_BUTTON);
            this.Controls.Add(this.Minimize_BUTTON);
            this.Controls.Add(this.AddDns_BUTTON);
            this.Controls.Add(this.DnsList_PANEL);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Easy DNS Changer";
            this.Load += new System.EventHandler(this.Main_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Main_MouseDown);
            this.Add_DNS_PANEL.ResumeLayout(false);
            this.Add_DNS_PANEL.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel DnsList_PANEL;
        private System.Windows.Forms.Button AddDns_BUTTON;
        private System.Windows.Forms.Button Minimize_BUTTON;
        private System.Windows.Forms.Button Exit_BUTTON;
        private System.Windows.Forms.Panel Add_DNS_PANEL;
        private System.Windows.Forms.Label DNSName_Title_LABEL;
        private System.Windows.Forms.Button Cancel_DNS_BUTTON;
        private System.Windows.Forms.Button Save_DNS_BUTTON;
        private System.Windows.Forms.TextBox DNS2_TEXTBOX;
        private System.Windows.Forms.TextBox DNS1_TEXTBOX;
        private System.Windows.Forms.TextBox DNS_Name_TEXTBOX;
        private System.Windows.Forms.Label DNS2_Title_LABEL;
        private System.Windows.Forms.Label DNS1_Title_LABEL;
        private System.Windows.Forms.Label Network_Title_LABEL;
        private System.Windows.Forms.ComboBox Network_COMBOBOX;
        private System.Windows.Forms.Label CurrentDNS_Title_LABEL;
        private System.Windows.Forms.Label CurrentDNS_Value_LABEL;
        private System.Windows.Forms.NotifyIcon Tray_NOTIFY;
    }
}