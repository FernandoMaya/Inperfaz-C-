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
    public partial class OrdeXSelec : Form
    {
        public OrdeXSelec()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                int n = int.Parse(uno2.Text);
                int max = int.Parse(Max2.Text);
                String number = "";


                long[] vector = new long[n];

                Random Numero = new Random();
                int Num;
                for (int i = 0; i < vector.Length; i++)
                {
                    Num = Numero.Next(max);
                    vector[i] = Num;
                }

                long Comparaciones = 0;
                long intercambios = 0;

                long aux = 0;
                for (int j = 0; j < vector.Length; j++)
                {

                    long menor = vector[j];
                    int i_menor = j;
                    for (int i = j; i < vector.Length; i++)
                    {
                        if (vector[i] < menor)
                        {
                            menor = vector[i];
                            i_menor = i;
                            intercambios++;
                        }
                        Comparaciones++;
                    }
                    aux = vector[j];
                    vector[j] = vector[i_menor];
                    vector[i_menor] = aux;
                }

                

                for (int f = 0; f < n; f++)
                {
                    number = number + vector[f] + " ";
                }
                MessageBox.Show(number);
                MessageBox.Show("Comparaciones: " +Comparaciones + " Intercambios: "+ intercambios);
            }
            catch (FormatException)
            {
                MessageBox.Show("Formato incorrecto o campos vacios, unicamente números enteros");
            }catch (OverflowException){
                MessageBox.Show("Números fuera del rango, ingrese numeros positivos");
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Numero menor a cero, intente otro numero que sea mayor a 0");
            }

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

      
    } 
    
}
