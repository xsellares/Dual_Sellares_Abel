using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sprint2_M20
{
    public partial class LoginNormal : Form
    {
        public LoginNormal()
        {
            InitializeComponent();
        }
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
    }
}
