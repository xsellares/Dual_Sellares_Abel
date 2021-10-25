using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Sprint2_M20
{
    public partial class ProgressBarSplash : Form
    {
        //Inicializamos la progressBar
        public ProgressBarSplash()
        {
            InitializeComponent();
        }
        private void Splash_Load(object sender, EventArgs e)
        {

        }

        //Hacemos un trigger para que al pulsar Alt+F2 nos lleve al login de admins
        private void Splash_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Alt && e.KeyCode == Keys.F2)
            {
                this.timer1.Enabled = false;
                this.Hide();
                validacio frmvalidacio = new validacio();
                frmvalidacio.ShowDialog();
            } 
        }

        //Esto hara que la progressBar funciones
        private void timer1_Tick(object sender, EventArgs e)
        {
            {
                pgbSplash.Increment(10);
                lblProgressBar.Text = pgbSplash.Value.ToString() + "%";

                //Si pasa el tiempo y no hemos pulsado Alt+F2 nos manda al login normal
                if (pgbSplash.Value == pgbSplash.Maximum)
                {
                    timer1.Stop();
                    this.Hide();
                    LoginNormal frmLoginNormal = new LoginNormal();
                    frmLoginNormal.ShowDialog();
                }
            }
        }
    }
}
