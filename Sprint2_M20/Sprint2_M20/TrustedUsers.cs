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

        LibreriaM20.LibreriaMESSI bd = new LibreriaM20.LibreriaMESSI();
        DataSet dts;

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

            dts = bd.TraerDatos("TrustedDevices", "select hostname, MAC from TrustedDevices where HostName = '" + hostName + "' and MAC = '" + txtMAC.Text + "'");
            DataTable dtDevices = dts.Tables[0];

            if (dtDevices.Rows.Count == 0)
            {
                MessageBox.Show("Tu dipositivo no está registrado");
                this.Close();

            }
            else
            {
                MessageBox.Show("Tu dispositivo ya está registrado");

            }


        }

        private void bntRegister_Click(object sender, EventArgs e)
        {
            string key = "TrustedUsers";
            string value = cmbUsers.Text;

                var configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                var settings = configFile.AppSettings.Settings;
                if (settings[key] == null)
                {
                    settings.Add(key, value);
                }
                else
                {
                    settings[key].Value = value;
                }
                configFile.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection(configFile.AppSettings.SectionInformation.Name);
            
        }
    }

}
