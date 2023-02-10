using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DNSItem
{
    public partial class ItemForDNS : UserControl
    {
        public ItemForDNS()
        {
            InitializeComponent();
        }
        private void ItemForDNS_Load(object sender, EventArgs e)
        {

        }




        #region Private Values
            string tick = "✔";
            string cross = "❌";
        #endregion




        #region Public Properties
            public string DNS1Value
            {
                get { return Dns1_Value_LABEL.Text; }
                set { Dns1_Value_LABEL.Text = value; }
            }
            public string DNS2Value
            {
                get { return Dns2_Value_LABEL.Text; }
                set { Dns2_Value_LABEL.Text = value; }
            }
            public string NameValue
            {
                get { return Name_Value_LABEL.Text; }
                set { Name_Value_LABEL.Text = value; }
            }
        #endregion




        #region Public Events
            public event EventHandler Activate_Button_Press;
            public event EventHandler Remove_Button_Press;
            public event EventHandler Edit_Button_Press;
        #endregion




        #region Public Methods
            public void ShowTick()
            {
                Stat_LABEL.Text = tick;
                Stat_LABEL.ForeColor = Color.LimeGreen;
                Activate_BUTTON.Text = "DeActivate";
            }
            public void ShowCross()
            {
                Stat_LABEL.Text = cross;
                Stat_LABEL.ForeColor = Color.Red;
                Activate_BUTTON.Text = "Activate";
            }
            public bool Is_Marked_As_Set()
            {
                if (Activate_BUTTON.Text == "DeActivate")
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        #endregion




        #region Private Methods
            private void Raise_RemoveButtonPress()
            {
                var handler = Remove_Button_Press;
                if (handler == null)
                    return;

                handler(this, EventArgs.Empty);
            }
            private void Raise_ActivateButtonPress()
            {
                var handler = Activate_Button_Press;
                if (handler == null)
                    return;

                handler(this, EventArgs.Empty);
            }
            private void Raise_EditButtonPress()
            {
                var handler = Edit_Button_Press;
                if (handler == null)
                    return;

                handler(this, EventArgs.Empty);
            }
        #endregion




        #region Private Events
        private void Remove_BUTTON_Click(object sender, EventArgs e)
        {
            Raise_RemoveButtonPress();
        }
        private void Activate_BUTTON_Click(object sender, EventArgs e)
        {
            Raise_ActivateButtonPress();
        }
        private void Edit_BUTTON_Click(object sender, EventArgs e)
        {
            Raise_EditButtonPress();
        }
        #endregion


    }
}
