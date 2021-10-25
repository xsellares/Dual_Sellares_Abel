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

        private void Validacio_Load(object sender, EventArgs e)
        {
            ArrayList elements = new ArrayList();

            for (int i = 0; i < 10; i++)
            {
                elements.Add(i);
            }

            Queue<int> cua = new Queue<int>();
            for (int i = 0; i < 10; i++)
            {
                Random rdn = new Random();
                int nums = rdn.Next(elements.Count - 1);
                int valor = (int)elements[nums];
                cua.Enqueue(valor);
                elements.RemoveAt(nums);
            }

            while (cua.Count > 0)
            {
                int valor = cua.Dequeue();
                Button btn = new Button();
                tableLayoutPanel1.Controls.Add(btn);
                btn.Text = valor.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "1234")
            {
                FormAdmin frmAdmin = new FormAdmin();
                this.Hide();
                frmAdmin.ShowDialog();
            }
        }
    }
}
