using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sprint2_M20
{
    public partial class FormCoordenades : Form
    {
        public FormCoordenades()
        {
            InitializeComponent();
        }

        string codi;
        int num;
        bool lleno = false;

        //Crear el diccionario con la llave y el valor asignado
        Dictionary<string, string> codiDiccionari = new Dictionary<string, string>();

        private void FormCoordenades_Load(object sender, EventArgs e)
        {

        }

        private void bntGenerar_Click(object sender, EventArgs e)
        {
            codiDiccionari.Clear();
            Random rng = new Random();
            for (char y = 'A'; y <= 'D'; y++)   //Doble bucle para generar una tabla con coordenadas y codigos.
            {
                for (int z = 1; z < 6; z++)
                {
                    num = rng.Next((9000) + 1000);  //Random del 0 al 9999
                    codi = y.ToString() + z; //Variable para la coordenada y el codigo
                    codiDiccionari.Add(codi, num.ToString().PadLeft(4, '0'));   //Añade 0 a la izquierda al codigo
                }

            }


        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            if (lleno == true)
            {
                for (int i = 0; i < 20; i++)
                {
                    tableLayoutPanel1.Controls.Remove(tableLayoutPanel1.GetControlFromPosition(1,1));
                }
            }
            
                for (int i = 0; i < 20; i++)
                {
                    Label lbl = new Label();
                    tableLayoutPanel1.Controls.Add(lbl);
                    string values = codiDiccionari.ElementAt(i).Value;
                    lbl.Text = values;
                }
            lleno = true;
        }
    }
}
