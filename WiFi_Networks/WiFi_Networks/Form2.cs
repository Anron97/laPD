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
            if (network.IsConnected)
            {
                PasswordInput.Enabled = false;
                connect.Enabled = false;
            }
        }

        public void ConnectBt_MouseClick(object sender, EventArgs e)
        {
            if (PasswordInput.Text.Length > 0 && _network.Connect(PasswordInput.Text))
            {
                PasswordInput.Enabled = false;
                connect.Enabled = false;
            }
        }
    }
}