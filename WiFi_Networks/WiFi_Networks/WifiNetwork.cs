﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SimpleWifi;

namespace WiFi_Networks
{
    public class WifiNetwork
    {
        public string Name { get; set; }
        public string SignalStrength { get; set; }
        public string Description { get; set; }
        public List<string> BssId { get; set; }
        public bool IsSecured { get; set; }
        public bool IsConnected { get; set; }

        public WifiNetwork(string name, string signalStrength, string description, List<string> bssId, bool isSecured, bool isConnected)
        {
            Name = name;
            SignalStrength = signalStrength;
            Description = description;
            BssId = bssId;
            IsSecured = isSecured;
            IsConnected = isConnected;
        }

        public bool Connect(string password)
        {
            Wifi wifi = new Wifi();
            AccessPoint accessPoint = wifi.GetAccessPoints().FirstOrDefault(x => x.Name.Equals(Name));
            if (accessPoint != null)
            {
                AuthRequest authRequest = new AuthRequest(accessPoint) {Password = password};
                return accessPoint.Connect(authRequest);
            }
            return false;
        }

        public string GetBssIds()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append("BssIds: ");
            builder.Append(String.Join("/r/n", BssId));
            return builder.ToString();
        }
    }
}
