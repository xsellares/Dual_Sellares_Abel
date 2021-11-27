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
using System.IO;

namespace Sprint2_M20
{
    public partial class LoginNormal : Form
    {
        public LoginNormal()
        {
            InitializeComponent();
        }

        string MAC;
        LibreriaM20.LibreriaMESSI bd = new LibreriaM20.LibreriaMESSI();
        DataSet dts;
        int contador = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            
            contador++;
         
                if (contador == 3)
                {
                    MessageBox.Show("Tindràs represàlies per part de la Primera Ordre");
                    this.Close();
                    FileStream fitxer = new FileStream("log_error.log", FileMode.Append, FileAccess.Write);
                    DateTimeOffset thisDate2 = new DateTimeOffset(DateTime.Now);
                    StreamWriter escriptor = new StreamWriter(fitxer);

                    escriptor.WriteLine(thisDate2.ToString("yyyymmdd:Hmmss") + ":" + txtUser.Text.ToString());
                    escriptor.Close();
                }

                if (txtUser.Text == "Abel" && txtPass.Text == "12345")
                {
                    this.Hide();
                    PantallaInicio frmPantallaInicio = new PantallaInicio();
                    frmPantallaInicio.ShowDialog();
                }
        }

        private void LoginNormal_Load(object sender, EventArgs e)
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
                        MAC = String.Format("{0}", bytes[i].ToString("X2"));
                        // Inserta un guion entre cada byte
                        if (i != bytes.Length - 1)
                        {
                            address += "-";
                        }
                    }
                }
            }

            Dns.GetHostName();


            dts = bd.TraerDatos("Users", "Select codeUser, password from Users;");
            DataTable dtUsers = dts.Tables[0];

            dts = bd.TraerDatos("Users", "Select codeUser, password from Users;");
            DataTable dtDevices = dts.Tables[0];
        }
    }
}
