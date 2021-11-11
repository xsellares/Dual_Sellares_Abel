using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sprint2_M20
{
    public partial class FormAdmin : Form
    {
        public FormAdmin()
        {
            InitializeComponent();
        }

        private void btnRegenerar_Click(object sender, EventArgs e)
        {
            FormCoordenades frmCoordenades = new FormCoordenades();
            frmCoordenades.Show();
        }

        private void btnGestioDispo_Click(object sender, EventArgs e)
        {
            TrustedDevices frmTrustedDevices = new TrustedDevices();
            frmTrustedDevices.Show();
        }

        private void btnGestioUsu_Click(object sender, EventArgs e)
        {
            TrustedUsers frmTrustedUsers = new TrustedUsers();
            frmTrustedUsers.Show();
        }
    }
}
