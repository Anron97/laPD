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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Ping_Click(object sender, EventArgs e)
        {
            if (addressF.Text.Length > 0)
            {
                NetworkPing ping = new NetworkPing();
                outputText.Text = ping.PingToAddress(addressF.Text);
            }
        }
    }
}
