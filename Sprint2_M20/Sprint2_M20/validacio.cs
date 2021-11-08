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
    public partial class validacio : Form
    {
        public validacio()
        {
            InitializeComponent();
        }

        string numeros;

        //Crear el diccionario con la llave y el valor asignado
        Dictionary<string, string> codiDiccionari = new Dictionary<string, string>();
        private void Validacio_Load(object sender, EventArgs e)
        {

            //Crear array para guardar numeros
            ArrayList elements = new ArrayList();

            //Bucle para añadir numeros del 0 al 9 al array
            for (int i = 0; i < 10; i++)
            {
                elements.Add(i);
            }

            //Crear una cola para añadir los numeros del array.
            Queue<int> cua = new Queue<int>();
            for (int i = 0; i < 10; i++)    //Bucle para generar numero random y sacar los numeros de la cola
            {
                Random rdn = new Random();
                int nums = rdn.Next(elements.Count - 1);
                int valor = (int)elements[nums];
                cua.Enqueue(valor);
                elements.RemoveAt(nums);
            }

            while (cua.Count > 0)   //Mientras la cola tenga 0 o menos elementos quita los elementos de la cola y crea un botón con el numero.
            {
                int valor = cua.Dequeue();
                Button btn = new Button();
                tableLayoutPanel1.Controls.Add(btn);
                btn.Text = valor.ToString();
                btn.Click += new System.EventHandler(this.ClickBotonesNumero);
            }


            Random rng = new Random();  //Generar random fuera del bucle para que no se repitan patrones
            for (char y = 'A'; y <= 'D'; y++)   //Doble bucle para generar una tabla con coordenadas y codigos.
            {
                for (int z = 1; z < 6; z++)
                {
                    int num = rng.Next((9000) + 1000);  //Random del 0 al 9999
                    string codi = y.ToString() + z; //Variable para la coordenada y el codigo
                    codiDiccionari.Add(codi, num.ToString().PadLeft(4, '0'));   //Añade 0 a la izquierda al codigo
                }

            }

            Random random = new Random();
            int numCodi = random.Next(19);

            string key = codiDiccionari.ElementAt(numCodi).Key;
            lblCoordenada.Text = key;

            numeros = codiDiccionari.ElementAt(numCodi).Value;
            MessageBox.Show(numeros);

        }
            

        private void ClickBotonesNumero(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            txtPassAdmin.Text += btn.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtPassAdmin.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
             if (txtPassAdmin.Text == numeros)
            {
                this.Hide();
                FormAdmin frmAdmin = new FormAdmin();
                frmAdmin.ShowDialog();

            }   
        }
    }
}
