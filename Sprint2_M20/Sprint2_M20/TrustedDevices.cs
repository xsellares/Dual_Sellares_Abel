using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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

        LibreriaM20.LibreriaMESSI bd = new LibreriaM20.LibreriaMESSI();
        string tabla = "TrustedDevices";
        DataSet dts;

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

            //Hostname
            String hostName = Dns.GetHostName();
            txtHostname.Text = hostName;

            //Conexion a base de datos

            dts = bd.TraerDatos(tabla, "select hostname, MAC from TrustedDevices where HostName = '" + hostName + "' and MAC = '" + txtMAC.Text + "'");
            DataTable dtDevices = dts.Tables[0];

            if (dtDevices.Rows.Count == 0)
            {
                MessageBox.Show("Tu dipositivo no está registrado");
                btnSave.Enabled = true;
                
            } else
            {
                MessageBox.Show("Tu dispositivo ya está registrado");
                btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
                btnDelete.Enabled = true;
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DataRow drDevices = dts.Tables[0].NewRow();

            drDevices[0] = txtHostname.Text;
            drDevices[1] = txtMAC.Text;

            dts.Tables["TrustedDevices"].Rows.Add(drDevices);

            dts = bd.Actualizar("select * from TrustedDevices");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            dts = bd.TraerDatos(tabla, "select hostname, MAC from TrustedDevices where HostName = '" + txtHostname.Text + "' and MAC = '" + txtMAC.Text + "'");
            DataTable dtDevices = dts.Tables["TrustedDevices"];

            for (int i = dtDevices.Rows.Count -1; i >= 0; i--)
            {
                DataRow drDevices = dtDevices.Rows[i];
                if (drDevices["MAC"].ToString() == txtMAC.Text && drDevices["HostName"].ToString() == txtHostname.Text) 
    {
                    dtDevices.Rows.Remove(drDevices);
                }
            }

            dtDevices.AcceptChanges();

            dts = bd.Actualizar("select * from TrustedDevices");

        }
    }
}
