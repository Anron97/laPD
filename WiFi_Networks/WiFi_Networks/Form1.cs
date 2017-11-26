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
    public partial class Form1 : Form
    {
        private readonly NetworkSearcher _searcher = new NetworkSearcher();
        private List<WifiNetwork> _networks;

        public Form1()
        {
            InitializeComponent();
            timer1.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateNetworkList();
        }

        private void UpdateNetworkList()
        {
            NetworkList.Items.Clear();
            _networks = _searcher.GetNetworks();
            foreach (WifiNetwork network in _networks)
            {
                ListViewItem item = new ListViewItem(network.SignalStrength);
                item.SubItems.Add(network.Name);
                if (network.IsConnected) item.Font = new Font(item.Font, FontStyle.Bold);
                NetworkList.Items.Add(item);
            }
        }

        public void NetworkList_DoubleMouseClick(object sender, MouseEventArgs e)
        {
            Form modalWindow = new Form2(_networks[NetworkList.SelectedItems[0].Index]);
            modalWindow.Show();
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            if (NetworkList.SelectedItems.Count == 0)
            {
                UpdateNetworkList();
            }
        }
    }
}