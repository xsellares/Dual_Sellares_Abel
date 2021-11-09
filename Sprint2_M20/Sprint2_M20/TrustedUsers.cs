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
using System.Configuration;
using System.Xml;

namespace Sprint2_M20
{
    public partial class TrustedUsers : Form
    {
        public TrustedUsers()
        {
            InitializeComponent();
        }


        private void TrustedUsers_Load(object sender, EventArgs e)
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
                        // Convierte la direccion en hexadeximal
                        txtMAC.Text += String.Format("{0}", bytes[i].ToString("X2"));
                        // Inserta un guion entre cada byte
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

        

        private void bntRegister_Click(object sender, EventArgs e)
        {
            string usuarioNuevo = comboBox1.Text;

            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile);

            foreach (XmlElement element in xmlDoc.DocumentElement)
            {
                if (element.Name.Equals("appSettings"))
                {
                    foreach (XmlNode node in element.ChildNodes)
                    {
                        if (node.Attributes[0].Value == "TrustedUser")
                        {
                            node.Attributes[1].Value = usuarioNuevo;
                        }
                        
                    }
                }
            }

            xmlDoc.Save(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile);
            ConfigurationManager.RefreshSection("appSettings");
        }



        
    }
}
