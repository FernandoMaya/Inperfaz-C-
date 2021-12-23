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
    public partial class Shell : Form
    {
        public Shell()
        {
            InitializeComponent();
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try { 
            int n = int.Parse(tres.Text);
            int max = int.Parse(Max.Text);
            String number = "";

            int[] vector = new int[n];


            Random r = new Random();
            vector[0] = r.Next(max);
            for (int f = 1; f < vector.Length; f++)
            {
                int j = f - 1;
                if (vector[f] != vector[j])
                {
                    int k = r.Next(max);
                    vector[f] = k;
                }
                else
                {
                    int a = 1;
                    int b = 2;
                    int c = a + b;
                    vector[f] = r.Next(max);

                }

            }



            int salto = 0;
            int sw = 0;
            int procesos = 0;
            int movimientos = 0;
            int auxi = 0;
            int ñ = 0;
            salto = vector.Length / 2;
            while (salto > 0)
            {
                sw = 1;
                while (sw != 0)
                {
                    sw = 0;
                    ñ = 1;
                    while (ñ <= (vector.Length - salto))
                    {
                        if (vector[ñ - 1] > vector[(ñ - 1) + salto])
                        {
                            auxi = vector[(ñ - 1) + salto];
                            vector[(ñ - 1) + salto] = vector[ñ - 1];
                            vector[(ñ - 1)] = auxi;
                            sw = 1;
                            movimientos++;
                        }
                        procesos++;
                        ñ++;
                    }
                }
                salto = salto / 2;
            }
            Console.WriteLine("procesos: " + procesos);
            Console.WriteLine("movimientos: " + movimientos);


            for (int f = 0; f < n; f++)
            {
                number = number + vector[f] + " ";
            }
            MessageBox.Show(number);
            MessageBox.Show("Comparaciones: " + procesos + " Intercambios: " + movimientos);
        } catch (FormatException)
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

