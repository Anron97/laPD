using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace WiFi_Networks
{
    class NetworkPing
    {
        public string PingToAddress(string address)
        {
            Ping ping = new Ping();
            PingReply pingReply;
            try
            {
                pingReply = ping.Send(address);
            }
            catch (PingException e)
            {
                return "Network connection error";
            }
            return "RoundTripTime: " + pingReply.RoundtripTime + "\r\nStatus: " + pingReply.Status + "\r\nAddress: " +
                   pingReply.Address;
        }
    }
}
