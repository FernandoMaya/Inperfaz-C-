using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo_Interfaz
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void BGenerar_Click(object sender, EventArgs e)
        {
            int Max = int.Parse(tMax.Text);
            int n = int.Parse(tCantidad.Text);
            String number="";

            int[] Numeros = new int[n];

            Random Numero = new Random();
            int Num;
            for(int i = 0; i < n; i++)
            {
                Num = Numero.Next(Max);
                Numeros[i] = Num;
            }
            for(int f = 0; f < n; f++)
            {
                number = number + Numeros[f];
            }
        MessageBox.Show(number);
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
