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
    public partial class BusqBinaria : Form
    {
        public BusqBinaria()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try {
                int[] vector = new int[6];

                vector[0] = 2;
                vector[1] = 4;
                vector[2] = 6;
                vector[3] = 8;
                vector[4] = 10;
                vector[5] = 12;
                Console.WriteLine("Introduce valor a buscar");
                int val = int.Parse(tvalor.Text); //6


                int inferior = 0;
                int superior = vector.Length - 1; //5
                int pivote = 0; //2
                bool encontrado = false;
                pivote = (inferior + superior) / 2;
                while (inferior <= superior)
                {
                    pivote = (inferior + superior) / 2;
                    if (vector[pivote] == val)
                    {
                        MessageBox.Show("Número encontrado");
                        encontrado = true;
                        inferior = 6;
                        superior = 5;
                    }
                    else
                    {
                        if (val < vector[pivote])
                        {
                            superior = pivote - 1;
                        }
                        else
                        {
                            inferior = pivote + 1;
                        }
                    }
                }
                if (encontrado == false)
                {
                    MessageBox.Show("Número no encontrado");
                }

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
    }
}
