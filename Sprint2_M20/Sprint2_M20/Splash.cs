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
        public object FormLogin { get; private set; }

        public ProgressBarSplash()
        {
            InitializeComponent();
        }

        private void Splash_Load(object sender, EventArgs e)
        {

        }

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

        private void timer1_Tick(object sender, EventArgs e)
        {
            {
                pgbSplash.ForeColor = Color.Black;
                pgbSplash.BackColor = Color.Black;
                pgbSplash.Increment(10);
                lblProgressBar.Text = pgbSplash.Value.ToString() + "%";

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
