using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DriversOnTheStorm
{
    public partial class Form1 : Form
    {
        private readonly DeviceController _controller = new DeviceController();
        private List<Device> _devices;

        public Form1()
        {
            InitializeComponent();
        }

        private void UpdateDeviceList()
        {
            _devices = _controller.GetDevices();
            foreach (Device device in _devices)
            {
                DeviceList.Items.Add(device.Name);
            }
        }

        private void DeviceList_MouseClick(object sender, MouseEventArgs e)
        {
            DisplayDeviceInfo(_devices[DeviceList.SelectedItems[0].Index]);
        }

        private void DisplayDeviceInfo(Device device)
        {
            string info = new StringBuilder("Guid: ").Append(device.ClassGuid).Append("\r\nHardwareID: ")
                .Append(device.HardwareId).Append("\r\nManufacturer: ").Append(device.Manufacturer)
                .Append("\r\nProvider: ").Append(device.Provider).Append("\r\nDriver description: ")
                .Append(device.Description).Append("\r\n.sys path: ").Append(device.SysPath)
                .Append("\r\nDevice path: ").Append(device.DevicePath).ToString();
            DeviceInfo.Text = info;
            DisableBt.Text = device.Status ? "Disable" : "Enable";
        }

        private void DisableB_Click(object sender, EventArgs e)
        {
            Device device = _devices[DeviceList.SelectedItems[0].Index];
            device.ChangeConnection(device.Status ? "Disable" : "Enable");
            device.Status = !device.Status;
            DisableBt.Text = device.Status ? "Disable" : "Enable";
        }
    }
}