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
    public partial class Burbuja : Form
    {
        public Burbuja()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                int n = int.Parse(dos.Text);
                int max = int.Parse(Max.Text);
                String number = "";

                long[] Numeros = new long[n];

                Random Numero = new Random();
                int Num;
                for (int i = 0; i < Numeros.Length; i++)
                {
                    Num = Numero.Next(max);
                    Numeros[i] = Num;
                }



                long auxiliar = 0;
                int Comparaciones = 0;
                int intercambios = 0;
                for (int i = 1; i < Numeros.Length; i++)
                {
                    for (int j = 0; j < Numeros.Length; j++)
                    {
                        Comparaciones++;
                        if (Numeros[j] > Numeros[i])
                        {
                            auxiliar = Numeros[i];
                            Numeros[i] = Numeros[j];
                            Numeros[j] = auxiliar;
                            intercambios++;
                        }

                    }
                }
                for (int f = 0; f < n; f++)
                {
                    number = number + Numeros[f] + " ";
                }
                MessageBox.Show(number);
                MessageBox.Show("Comparaciones: " + Comparaciones + " Intercambios: " + intercambios);

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

