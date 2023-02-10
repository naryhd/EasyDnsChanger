using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using DNSItem;
using System.Management;
using System.Security.Principal;
using System.Diagnostics;

namespace EasyDnsChanger
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        SaveLoadData newSLD = new SaveLoadData();
        Point nextPoint = new Point(7, 10);//Location of dns item
        bool isNew = false;
        ItemForDNS oldDNSItem = new ItemForDNS();

        private void Main_Load(object sender, EventArgs e)
        {
            /* if you want to force user run it with administrator privileges , there are two options :
             
             First Way : uncomment the if condition below

             Second Way : in app.manifest file uncomment the below code : 
                    <requestedExecutionLevel level="requireAdministrator" uiAccess="false" /> 
            
                and comment the below code : 
                    <requestedExecutionLevel level="asInvoker" uiAccess="false" /> */

            //if (!IsAdministrator())
            //{
            //    ProcessStartInfo proc = new ProcessStartInfo();
            //    proc.UseShellExecute = true;
            //    proc.WorkingDirectory = Environment.CurrentDirectory;
            //    proc.FileName = Application.ExecutablePath;
            //    proc.Verb = "runas";
            //    try
            //    {
            //        Process.Start(proc);
            //    }
            //    catch
            //    {
            //        return;
            //    }
            //    Application.Exit();
            //}

            newSLD.Create_File();
            Set_Network_Interfaces();
            Load_DNSs();
        }

        /// <summary>
        /// check if application is ran with administartor privileges
        /// </summary>
        /// <returns></returns>
        private static bool IsAdministrator()
        {
            WindowsIdentity identity = WindowsIdentity.GetCurrent();
            WindowsPrincipal principal = new WindowsPrincipal(identity);
            return principal.IsInRole(WindowsBuiltInRole.Administrator);
        }

        /// <summary>
        /// set primary and secondary DNS to selected Network
        /// </summary>
        /// <param name="Dns">array containing primary and secondary DNS</param>
        public void SetDNS(string[] Dns)
        {
            //get the selected interface from Network_COMBOBOX
            var CurrentInterface = Get_Selected_NetworkInterface(Network_COMBOBOX.Text);
            if (CurrentInterface == null) return;

            //find the selected adapter and set DNSs
            ManagementClass objMC = new ManagementClass("Win32_NetworkAdapterConfiguration");
            ManagementObjectCollection objMOC = objMC.GetInstances();
            foreach (ManagementObject objMO in objMOC)
            {
                if ((bool)objMO["IPEnabled"])
                {
                    if (objMO["Caption"].ToString().Contains(CurrentInterface.Description))
                    {
                        ManagementBaseObject objdns = objMO.GetMethodParameters("SetDNSServerSearchOrder");
                        if (objdns != null)
                        {
                            objdns["DNSServerSearchOrder"] = Dns;
                            objMO.InvokeMethod("SetDNSServerSearchOrder", objdns, null);
                        }
                    }
                }
            }
        }

        /// <summary>
        /// unset DNS from selected Network
        /// </summary>
        public void UnsetDNS()
        {
            var CurrentInterface = Get_Selected_NetworkInterface(Network_COMBOBOX.Text);
            if (CurrentInterface == null) return;

            ManagementClass objMC = new ManagementClass("Win32_NetworkAdapterConfiguration");
            ManagementObjectCollection objMOC = objMC.GetInstances();
            foreach (ManagementObject objMO in objMOC)
            {
                if ((bool)objMO["IPEnabled"])
                {
                    if (objMO["Caption"].ToString().Contains(CurrentInterface.Description))
                    {
                        ManagementBaseObject objdns = objMO.GetMethodParameters("SetDNSServerSearchOrder");
                        if (objdns != null)
                        {
                            objdns["DNSServerSearchOrder"] = null;
                            objMO.InvokeMethod("SetDNSServerSearchOrder", objdns, null);
                        }
                    }
                }
            }
        }

        /// <summary>
        /// list all network adapters , add them to Network_COMBOBOX, select the active one
        /// </summary>
        private void Set_Network_Interfaces()
        {
            NetworkInterface[] Nics = NetworkInterface.GetAllNetworkInterfaces();
            foreach (NetworkInterface ni in Nics)
            {
                Network_COMBOBOX.Items.Add(ni.Name);
            }

            Network_COMBOBOX.Text = GetActiveEthernetOrWifiNetworkInterface().Name;
            CurrentDNS_Value_LABEL.Text = Get_Current_DNS(Network_COMBOBOX.Text);
        }

        /// <summary>
        /// find currently active network adapter
        /// </summary>
        /// <returns>return currently active network adapter</returns>
        public NetworkInterface GetActiveEthernetOrWifiNetworkInterface()
        {
            var Nic = NetworkInterface.GetAllNetworkInterfaces().FirstOrDefault(
                a => a.OperationalStatus == OperationalStatus.Up &&
                (a.NetworkInterfaceType == NetworkInterfaceType.Wireless80211 || a.NetworkInterfaceType == NetworkInterfaceType.Ethernet) &&
                a.GetIPProperties().GatewayAddresses.Any(g => g.Address.AddressFamily.ToString() == "InterNetwork"));
            
            return Nic;
        }

        /// <summary>
        /// get currently set DNS for seleted network adapter
        /// </summary>
        /// <param name="NetworkName">Network Name</param>
        /// <returns>returns pair of DNS</returns>
        public string Get_Current_DNS(string NetworkName)
        {
            string result = "";
            NetworkInterface[] Nics = NetworkInterface.GetAllNetworkInterfaces();
            foreach (NetworkInterface ni in Nics)
            {
                if (ni.Name==NetworkName)
                {
                    
                    IPAddressCollection ni_dns = ni.GetIPProperties().DnsAddresses;
                    foreach (IPAddress dns in ni_dns)
                    {
                        result += dns.ToString() + "\n\r";
                    }
                }
            }
            if (result=="")
            {
                result = "NA\n\rNA";
            }
            return result;
        }

        public NetworkInterface Get_Selected_NetworkInterface(string NetworkName)
        {
            NetworkInterface[] Nics = NetworkInterface.GetAllNetworkInterfaces();
            foreach (NetworkInterface ni in Nics)
            {
                if (ni.Name == NetworkName)
                {
                    return ni;
                }
            }
            return null;
        }

        /// <summary>
        /// Load all DNSs from file to UI
        /// </summary>
        private void Load_DNSs()
        {
            List<DNSItemClass> dnsList = newSLD.Load_Data();
            string _currentDNSs = CurrentDNS_Value_LABEL.Text;
            if (dnsList == null) { return; }
            foreach (DNSItemClass dns in dnsList)
            {
                ItemForDNS newIFDNS = new ItemForDNS();
                newIFDNS.NameValue = dns.Name;
                newIFDNS.DNS1Value = dns.DNS1;
                newIFDNS.DNS2Value = dns.DNS2;
                newIFDNS.Activate_Button_Press += DNSITEM_Activate_Click;
                newIFDNS.Remove_Button_Press += DNSITEM_Remove_Click;
                newIFDNS.Edit_Button_Press += DNSITEM_Edit_Click;

                string _tmpDNS = dns.DNS1 + "\n\r" + dns.DNS2 + "\n\r";
                if (_tmpDNS==_currentDNSs)
                {
                    newIFDNS.ShowTick();
                }
                else
                {
                    newIFDNS.ShowCross();
                }

                newIFDNS.Location = nextPoint;
                DnsList_PANEL.Controls.Add(newIFDNS);
                nextPoint.Y += 57 + 10;
            }
        }
        private void DNSITEM_Activate_Click(object sender, EventArgs e)
        {
            ItemForDNS target = (sender as ItemForDNS);
            if (target.Is_Marked_As_Set())
            {
                UnsetDNS();
            }
            else
            {
                string[] dnss = new string[2];
                dnss[0] = target.DNS1Value;
                dnss[1] = target.DNS2Value;
                SetDNS(dnss);
            }
            CurrentDNS_Value_LABEL.Text = Get_Current_DNS(Network_COMBOBOX.Text);
            nextPoint = new Point(7, 10);
            DnsList_PANEL.Controls.Clear();
            Load_DNSs();
            
        }
        private void DNSITEM_Remove_Click(object sender, EventArgs e)
        {
            ItemForDNS target = (sender as ItemForDNS);

            DialogResult dialogResult = MessageBox.Show("Are You Sure?", "Alert", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                newSLD.Delete_DNS(target.NameValue, target.DNS1Value, target.DNS2Value);
                nextPoint = new Point(7, 10);
                DnsList_PANEL.Controls.Clear();
                Load_DNSs();
            }
            else if (dialogResult == DialogResult.No)
            {
                
            }
        }
        private void DNSITEM_Edit_Click(object sender, EventArgs e)
        {
            isNew = false;
            ItemForDNS target = (sender as ItemForDNS);
            oldDNSItem = target;
            DNS_Name_TEXTBOX.Text = target.NameValue;
            DNS1_TEXTBOX.Text = target.DNS1Value;
            DNS2_TEXTBOX.Text = target.DNS2Value;
            Add_DNS_PANEL.Enabled = true;
            Add_DNS_PANEL.Visible = true;
        }
        private void Exit_BUTTON_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AddDns_BUTTON_Click(object sender, EventArgs e)
        {
            isNew = true;
            DNS_Name_TEXTBOX.Text = "";
            DNS1_TEXTBOX.Text = "";
            DNS2_TEXTBOX.Text = "";
            Add_DNS_PANEL.Enabled = true;
            Add_DNS_PANEL.Visible = true;
        }

        private void Minimize_BUTTON_Click(object sender, EventArgs e)
        {
            Tray_NOTIFY.Visible = true;
            this.Hide();
        }

        private void Save_DNS_BUTTON_Click(object sender, EventArgs e)
        {
            string _dnsName = DNS_Name_TEXTBOX.Text;
            string _dns1Value = DNS1_TEXTBOX.Text;
            string _dns2Value = DNS2_TEXTBOX.Text;
            if (_dnsName == "" || _dnsName == null)
            {
                _dnsName = "NA";
            }
            Regex regex = new Regex(@"\b\d{1,3}\.\d{1,3}\.\d{1,3}\.\d{1,3}\b");
            Match match = regex.Match(_dns1Value);
            if (match.Success == false)
            {
                MessageBox.Show("DNS 1 is not valid");
                return;
            }
            match = regex.Match(_dns2Value);
            if (match.Success == false)
            {
                MessageBox.Show("DNS 2 is not valid");
                return;
            }
            if (isNew)
            {
                bool res = newSLD.Save_Data(_dnsName, _dns1Value, _dns2Value);
                if (res)
                {
                    MessageBox.Show("Saved");
                }
                else
                {
                    MessageBox.Show("an error accured");
                }
            }
            else
            {
                newSLD.Edit_DNS(oldDNSItem.NameValue, oldDNSItem.DNS1Value, oldDNSItem.DNS2Value, _dnsName, _dns1Value, _dns2Value);
            }
            nextPoint = new Point(7, 10);
            DnsList_PANEL.Controls.Clear();
            Load_DNSs();
            Add_DNS_PANEL.Enabled = false;
            Add_DNS_PANEL.Visible = false;
        }

        private void Cancel_DNS_BUTTON_Click(object sender, EventArgs e)
        {
            Add_DNS_PANEL.Enabled = false;
            Add_DNS_PANEL.Visible = false;
        }

        private void Network_COMBOBOX_SelectedIndexChanged(object sender, EventArgs e)
        {
            CurrentDNS_Value_LABEL.Text = Get_Current_DNS(Network_COMBOBOX.Text);
        }

        private void Tray_NOTIFY_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Tray_NOTIFY.Visible = false;
            this.Show();
        }


        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        private void Main_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
    }
}
