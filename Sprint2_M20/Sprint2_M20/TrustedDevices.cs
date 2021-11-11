using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sprint2_M20
{
    public partial class TrustedDevices : Form
    {
        public TrustedDevices()
        {
            InitializeComponent();
        }

        private void txtMAC_TextChanged(object sender, EventArgs e)
        {

        }

        private void TrustedDevices_Load(object sender, EventArgs e)
        {
            IPGlobalProperties computerProperties = IPGlobalProperties.GetIPGlobalProperties();
            NetworkInterface[] nics = NetworkInterface.GetAllNetworkInterfaces();

            foreach (NetworkInterface adapter in NetworkInterface.GetAllNetworkInterfaces())
            {
                // Only consider Ethernet network interfaces
                if (adapter.NetworkInterfaceType == NetworkInterfaceType.Ethernet &&
                    adapter.OperationalStatus == OperationalStatus.Up)
                {
                    PhysicalAddress address = adapter.GetPhysicalAddress();
                    byte[] bytes = address.GetAddressBytes();
                    for (int i = 0; i < bytes.Length; i++)
                    {
                        // Display the physical address in hexadecimal.
                        txtMAC.Text += String.Format("{0}", bytes[i].ToString("X2"));
                        // Insert a hyphen after each byte, unless we are at the end of the
                        // address.
                        if (i != bytes.Length - 1)
                        {
                            txtMAC.Text += "-";
                        }
                    }
                }
            }

            String hostName = Dns.GetHostName();
            txtHostname.Text = hostName;
        }
    }
}
