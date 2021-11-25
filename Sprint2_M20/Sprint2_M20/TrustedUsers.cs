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
        string idDevice;
        string id;
        string idUser;
       
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

            dts = bd.TraerDatos("TrustedDevices", "select * from TrustedDevices where HostName = '" + hostName + "' and MAC = '" + txtMAC.Text + "'");
            DataTable dtDevices = dts.Tables[0];

            if (dtDevices.Rows.Count == 0)
            {
                MessageBox.Show("Tu dipositivo no está registrado");
                this.Close();

            } else
            {
                DataRow drDevice = dtDevices.Rows[0];

                idDevice = drDevice[0].ToString();
            }

            dts = bd.TraerDatos("Users", "Select idUser,codeUser from Users");
            DataTable dtUsers = dts.Tables[0];

            cmbUsers.DataSource = dts.Tables[0];
            cmbUsers.ValueMember = "idUser";
            cmbUsers.DisplayMember = "codeUser";

        }

        private void bntRegister_Click(object sender, EventArgs e)
        {
            string key = "TrustedUser";
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

            dts = bd.TraerDatos("MessiUsers", "Select idDevice from MessiUsers where idDevice = '" + idDevice + "';");
            DataTable dtDevice = dts.Tables[0];

            if (dtDevice.Rows.Count == 0)
            {
                string query = "select * from TrustedDevices where 1=2";
                int resultat = bd.Executar("SET IDENTITY_INSERT MessiUsers ON insert into MessiUsers(idMessiUser, idDevice, idUser) values(" + id + "," + idDevice + "," + idUser + ");");
                int result = bd.Actualizar(query, dts);
            } else
            {
                MessageBox.Show("Solo se puede registrar un usuario con este dispositivo");
                btnRegister.Enabled = false;
            }

            btnRegister.Enabled = false;

        }

        private void cmbUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            id = cmbUsers.SelectedValue.ToString();
        }

        private void bntCheck_Click(object sender, EventArgs e)
        {
            dts = bd.TraerDatos("MessiUsers", "Select * from MessiUsers where idMessiUser =" + id + " and idDevice = " + idDevice + " and idUser = " + idUser);
            DataTable dtMessi = dts.Tables[0];

            if (dtMessi.Rows.Count == 0)
            {
                btnRegister.Enabled = true;
                btnDelete.Enabled = false;

            } else
            {
                btnDelete.Enabled = true;
                btnRegister.Enabled = false;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string query = "select * from TrustedDevices where 1=2";
            int resultat = bd.Executar("delete from MessiUsers where idMessiUser =" + id + "and idDevice =" + idDevice + "and idUser = " + idUser + ";");
            int result = bd.Actualizar(query, dts);

            btnDelete.Enabled = false;
        }

        private void cmbUsers_Validating(object sender, CancelEventArgs e)
        {
            dts = bd.TraerDatos("Users", "select idUser from Users where codeUser = '" + cmbUsers.Text + "'");
            DataTable dtUsers = dts.Tables[0];
            DataRow drUsers = dtUsers.Rows[0];
            idUser = drUsers[0].ToString();
        }
    }

}
