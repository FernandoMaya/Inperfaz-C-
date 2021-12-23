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
    public partial class QuickSort : Form
    {
        public QuickSort()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {

            int n;
           
            n = int.Parse(tValor.Text);
          
            Llenar b = new Llenar(n);
        }

        class Llenar
        {
            int h;
            int[] vector;
            public Llenar(int n)
            {
                h = n;
                vector = new int[n];

                Random numero = new Random();
                Console.WriteLine("Numeros generados");
                for (int f = 0; f < n; f++)
                {
                    int Num = numero.Next(n);
                    vector[f] = Num;
                }

              
                quicksort(vector, 0, h - 1);

            }

            private void quicksort(int[] vector, int primero, int ultimo)
            {
                string number = "";
                int i, j, central;
                double pivote;
                central = (primero + ultimo) / 2;
                pivote = vector[central];
                i = primero;
                j = ultimo;
                do
                {
                    while (vector[i] < pivote) i++;
                    while (vector[j] > pivote) j--;
                    if (i <= j)
                    {
                        int temp;
                        temp = vector[i];
                        vector[i] = vector[j];
                        vector[j] = temp;
                        i++;
                        j--;
                    }
                } while (i <= j);

                if (primero < j)
                {
                    quicksort(vector, primero, j);
                }
                if (i < ultimo)
                {
                    quicksort(vector, i, ultimo);
                }
                for (int f = 0; f < vector.Length; f++)
                {
                    number = number + vector[f] + " ";
                }
                MessageBox.Show(number);
            }
        }
    
    }
}
