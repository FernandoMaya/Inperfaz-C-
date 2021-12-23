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
    public partial class BusqLineal : Form
    {
        public BusqLineal()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                int n = int.Parse(uno.Text);
                int max = int.Parse(Max.Text);
                String number = "";


                long[] vector = new long[n];

                Random Numero = new Random();
                int Num;
                for (int i = 0; i < vector.Length; i++)
                {
                    Num = Numero.Next(max);
                    vector[i] = Num;
                }


                Console.WriteLine("ingrese un numero para ver");
                int Valor = int.Parse(valor.Text);

                bool valorb = false;
                int contador = 0;
                int Comparaciones = 0;
                while (contador < vector.Length)
                {
                    if (Valor == vector[contador])
                    {
                        valorb = true;
                    }
                    Comparaciones++;

                    contador++;
                }





                for (int f = 0; f < n; f++)
                {
                    number = number + vector[f] + " ";
                }
                MessageBox.Show(number);
                if (valorb == true)
                {
                    MessageBox.Show("Se encontro el número");
                }
                if (valorb == false)
                {
                    MessageBox.Show("No se encontro el número");
                }
                MessageBox.Show("Comparaciones: " + Comparaciones);

            }
            catch (FormatException)
            {
                MessageBox.Show("Formato incorrecto o campos vacios, unicamente números enteros");
            }
            catch (OverflowException)
            {
                MessageBox.Show("Números fuera del rango, ingrese numeros positivos");
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Numero menor a cero, intente otro numero que sea mayor a 0");
            }
        }

        private void BusqLineal_Load(object sender, EventArgs e)
        {

        }
    }
}
