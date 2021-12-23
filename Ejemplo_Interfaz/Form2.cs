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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void BGenerador_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
        }

        private void BOrdenamiento_Click(object sender, EventArgs e)
        {
            Ordenamiento Ordenamiento = new Ordenamiento();
            Ordenamiento.Show();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Busqueda Busqueda = new Busqueda();
            Busqueda.Show();
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            k_vecinos vecinos = new k_vecinos();
            vecinos.Show();
        }
    }
}
