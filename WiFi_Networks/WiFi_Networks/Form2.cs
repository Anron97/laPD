using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WiFi_Networks
{
    public partial class Form2 : Form
    {
        private readonly WifiNetwork _network;

        public Form2(WifiNetwork network)
        {
            this._network = network;
            InitializeComponent();
            textBox.Text = network.Description + network.GetBssIds();
            connect.Enabled = !network.IsConnected;
            PasswordInput.Enabled = !network.IsConnected && network.IsSecured;
            ErrorL.Visible = false;
        }

        public void ConnectBt_MouseClick(object sender, EventArgs e)
        {
            if (PasswordInput.Text.Length > 0 && _network.Connect(PasswordInput.Text))
            {
                this.Close();
            }
            else
            {
                ErrorL.Visible = true;
                PasswordInput.Text = "";
            }
        }
    }
}