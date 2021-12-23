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
    public partial class Ordenamiento : Form
    {
        public Ordenamiento()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            OrdeXSelec orde = new OrdeXSelec();
            orde.Show();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Burbuja burbuja = new Burbuja();
            burbuja.Show();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Shell shell = new Shell();
            shell.Show();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            QuickSort quickSort = new QuickSort();
            quickSort.Show();
        }
    }
}
