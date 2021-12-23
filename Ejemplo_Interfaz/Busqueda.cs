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
    public partial class Busqueda : Form
    {
        public Busqueda()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            BusqLineal BusqLineal = new BusqLineal();
            BusqLineal.Show();
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            BusqBinaria busqBinaria = new BusqBinaria();
            busqBinaria.Show();
        }
    }
}
