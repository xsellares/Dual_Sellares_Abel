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

        LibreriaM20.LibreriaMESSI bd = new LibreriaM20.LibreriaMESSI();
        DataSet dts;
        string clau;
        string valor;

        private void FormCoordenades_Load(object sender, EventArgs e)
        {
            
        }

        private void bntGenerar_Click(object sender, EventArgs e)
        {
            dts = bd.TraerDatos("AdminCoordinates", "Select * from AdminCoordinates where 1 = 2");
            DataTable dtcoordenada = dts.Tables[0];

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

            foreach (var item in codiDiccionari)
            {
                clau = item.Key.ToString();
                valor = item.Value.ToString();
                string query = "select * from AdminCoordinates where 1=2";
                int resultat = bd.Executar("insert into AdminCoordinates(Coordinate, ValueCoord) values('" + clau + "','" + valor + "');");
                int result = bd.Actualizar(query, dts);

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
            
                    dts = bd.TraerDatos("AdminCoordinates","Select ValueCoord from AdminCoordinates order by Coordinate");
                    DataTable dtCoord = dts.Tables[0];


                foreach (DataRow dr in dtCoord.Rows)
                {
                    Label lbl = new Label();
                    tableLayoutPanel1.Controls.Add(lbl);
                    //values = codiDiccionari.ElementAt(i).Value;
                    lbl.Text = dr[0].ToString();
                }

            lleno = true;
        }
    }
}
