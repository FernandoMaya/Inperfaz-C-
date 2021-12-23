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
    public partial class k_vecinos : Form
    {
        public k_vecinos()
        {
            InitializeComponent();
        }

        private void TextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {

            try
            {

                int contador = 0;
                Double resultadoAlter = 0;
                int x1 = -1, x2 = -1, x3 = -1, x4 = -1, x5 = 0 - 1, x6 = -1, y1 = -1, y2 = -1, y3 = -1, y4 = -1, y5 = -1, y6 = -1;
                do
                {
                    Console.WriteLine("Ingrese la coordenada x1");
                    int equis1 = int.Parse(xuno.Text);
                    if (equis1 >= 0)
                    {
                        x1 = equis1;
                    }
                } while (x1 == -1);

                do
                {
                    Console.WriteLine("Ingrese la coordenada y1");
                    int equis2 = int.Parse(yuno.Text);
                    if (equis2 >= 0)
                    {
                        y1 = equis2;
                    }
                } while (y1 == -1);
                do
                {
                    Console.WriteLine("Ingrese la coordenada x2");
                    int equis3 = int.Parse(xdos.Text);
                    if (equis3 >= 0)
                    {
                        x2 = equis3;
                    }
                } while (x2 == -1);
                do
                {
                    Console.WriteLine("Ingrese la coordenada y2");
                    int equis4 = int.Parse(ydos.Text);
                    if (equis4 >= 0)
                    {
                        y2 = equis4;
                    }
                } while (y2 == -1);
                do
                {
                    Console.WriteLine("Ingrese la coordenada x3");
                    int equis5 = int.Parse(xtres.Text);
                    if (equis5 >= 0)
                    {
                        x3 = equis5;
                    }
                } while (x3 == -1);
                do
                {
                    Console.WriteLine("Ingrese la coordenada y3");
                    int equis6 = int.Parse(ytres.Text);
                    if (equis6 >= 0)
                    {
                        y3 = equis6;
                    }
                } while (y3 == -1);
                do
                {
                    Console.WriteLine("Ingrese la coordenada x4");
                    int equis7 = int.Parse(xcuatro.Text);
                    if (equis7 >= 0)
                    {
                        x4 = equis7;
                    }
                } while (x4 == -1);
                do
                {
                    Console.WriteLine("Ingrese la coordenada y4");
                    int equis8 = int.Parse(ycuatro.Text);
                    if (equis8 >= 0)
                    {
                        y4 = equis8;
                    }
                } while (y4 == -1);
                do
                {
                    Console.WriteLine("Ingrese la coordenada x5");
                    int equis9 = int.Parse(xcinco.Text);
                    if (equis9 >= 0)
                    {
                        x5 = equis9;
                    }
                } while (x5 == -1);
                do
                {
                    Console.WriteLine("Ingrese la coordenada y5");
                    int equis10 = int.Parse(ycinco.Text);
                    if (equis10 >= 0)
                    {
                        y5 = equis10;
                    }
                } while (y5 == -1);
                do
                {
                    Console.WriteLine("Ingrese la coordenada x6");
                    int equis11 = int.Parse(xseis.Text);
                    if (equis11 >= 0)
                    {
                        x6 = equis11;
                    }
                } while (x6 == -1);
                do
                {
                    Console.WriteLine("Ingrese la coordenada y6");
                    int equis12 = int.Parse(yseis.Text);
                    if (equis12 >= 0)
                    {
                        y6 = equis12;
                    }
                } while (y6 == -1);
                int[] nada = { x1, y1, x2, y2, x3, y3, x4, y4, x5, y5, x6, y6 };
                int maximo = nada.Max();
                int min = nada.Min();

                long[] vector = new long[100];//comparadores para centros

                Random Numero = new Random();
                int Num;
                for (int i = 0; i < vector.Length; i++)
                {
                    Num = Numero.Next(min, maximo);
                    vector[i] = Num;
                }

                long x = 0;
                long y = 0;
                while (contador < vector.Length)
                {
                    long x_centroide = vector[contador];
                    contador++;
                    long y_centroide = vector[contador];
                    double resultado1 = Math.Sqrt(Math.Pow(x_centroide - x1, 2) + Math.Pow(y_centroide - y1, 2));
                    double resultado2 = Math.Sqrt(Math.Pow(x_centroide - x2, 2) + Math.Pow(y_centroide - y2, 2));
                    double resultado3 = Math.Sqrt(Math.Pow(x_centroide - x3, 2) + Math.Pow(y_centroide - y3, 2));
                    double resultado4 = Math.Sqrt(Math.Pow(x_centroide - x4, 2) + Math.Pow(y_centroide - y4, 2));
                    double resultado5 = Math.Sqrt(Math.Pow(x_centroide - x5, 2) + Math.Pow(y_centroide - y5, 2));
                    double resultado6 = Math.Sqrt(Math.Pow(x_centroide - x6, 2) + Math.Pow(y_centroide - y6, 2));

                    double resultadoF = (resultado1 + resultado2 + resultado3 + resultado4 + resultado5 + resultado6) / 6;

                    if (contador == 1)
                    {
                        resultadoAlter = resultadoF;
                        x = vector[0];
                        y = vector[1];
                    }
                    if (resultadoF < resultadoAlter)
                    {
                        resultadoAlter = resultadoF;
                        x = vector[contador - 1];
                        y = vector[contador];
                    }


                    contador++;
                }
                MessageBox.Show("X: " + x + "Y: " + y);

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
