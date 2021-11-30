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
        string hostname;
        string dbusername;
        string dbpassword;
        string iduser;
        string iddevice;
        LibreriaM20.LibreriaMESSI bd = new LibreriaM20.LibreriaMESSI();
        DataSet dts;
        int contador = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            
            contador++;
         
                if (contador == 3)
                {
                    MessageBox.Show("Tindràs represàlies per part de la Primera Ordre");
                    Application.Exit();
                    FileStream fitxer = new FileStream("log_error.log", FileMode.Append, FileAccess.Write);
                    DateTimeOffset thisDate2 = new DateTimeOffset(DateTime.Now);
                    StreamWriter escriptor = new StreamWriter(fitxer);

                    escriptor.WriteLine(thisDate2.ToString("yyyymmdd:Hmmss") + ":" + txtUser.Text.ToString());
                    escriptor.Close();
                }

                dts = bd.TraerDatos("Users","Select * from Users where codeUser = '" + txtUser.Text + "' and password = '" + txtPass.Text + "';");
                DataTable dtlogin = dts.Tables[0];

                if (dtlogin.Rows.Count == 1)
                {
                    DataRow drlogin = dtlogin.Rows[0];

                    iduser = drlogin["idUser"].ToString();
                    dbusername = drlogin["codeuser"].ToString();
                    dbpassword = drlogin["password"].ToString();


                if (dbusername == txtUser.Text && dbpassword == txtPass.Text)
                {
                    dts = bd.TraerDatos("TrustedDevices", "Select * from TrustedDevices where MAC = '" + MAC + "' and hostname = '" + hostname + "';");
                    DataTable dtdevices = dts.Tables[0];
                    DataRow drdevices = dtdevices.Rows[0];

                    iddevice = drdevices["idDevice"].ToString();

                    if (dtdevices.Rows.Count == 1)
                    {
                        dts = bd.TraerDatos("MessiUsers", "Select idUser, idDevice from MessiUsers where idUser =" + iduser + "and idDevice =" + iddevice + ";");
                        DataTable dtmessi = dts.Tables[0];

                        if (dtmessi.Rows.Count == 1)
                        {
                            this.Hide();
                            PantallaInicio frmPantallainicio = new PantallaInicio();
                            frmPantallainicio.ShowDialog();
                        }
                        
                    }
                }
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
                        MAC += String.Format("{0}", bytes[i].ToString("X2")).ToString();
                        // Inserta un guion entre cada byte
                        if (i != bytes.Length - 1)
                        {
                            MAC += "-".ToString();
                        }
                    }
                }
            }

            hostname = Dns.GetHostName();

        }
    }
}
