using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_Busqueda_LinyBin
{
    public class EjercicioBinario
    {
        public void ejercicio1()
        {
            int[] arreglo = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Console.WriteLine("Ingrese el numero a buscar");
            int valor = Convert.ToInt32(Console.ReadLine());
            int inferior = 0;
            int superior = arreglo.Length - 1;
            int indice = -1;

            while (inferior <= superior)
            {
                int medio = (inferior + superior + 1) / 2;
                if (arreglo[medio] == valor)
                {
                    indice = medio;
                    break;
                }
                if (arreglo[medio] < valor)
                {
                    inferior = medio + 1;
                }
                if (valor < arreglo[medio])
                {
                    superior = medio - 1;
                }
            }
            Console.WriteLine($"El numero se encuentra en la posicion {indice}");
        }

        public void ejercicio2()
        {
            string[] arreglo = new string[] { "ABC", "DEF", "GHI", "JKL", "MNO"};
            Console.WriteLine("Ingrese la cadena a encontrar");
            string cadena = Console.ReadLine();
            int inferior = 0;
            int superior = arreglo.Length;
            int indice = -1;
            while (inferior <= superior)
            {
                int medio = inferior + (superior - inferior) / 2;

                if (String.Compare(arreglo[medio],cadena)==0)
                {
                    indice = medio;
                    break;
                }
                if (String.Compare(arreglo[medio], cadena) < 0)
                {
                    inferior = medio + 1;
                }
                if (String.Compare(cadena, arreglo[medio]) < 0)
                {
                    superior = medio - 1;
                }
            }
            Console.WriteLine("La cadena se encuentra en la posicion " + indice);
        }


        public void ejercicio3()
        {
            int[] arreglo = new int[] {1,2,3,4,5,6,7,8,9,10,12,13,14};
            int inferior = 0;
            int superior = arreglo.Length - 1;
            int indice= -1;

              while (inferior <= superior)
              {
                  int medio = inferior + (superior - inferior) / 2;
                   if (arreglo[medio] % 2 == 0)
                   {
                       indice = medio;
                       superior = medio - 1;
                   }
                   else
                   {
                       inferior = medio + 1;
                   }     
              }
                Console.WriteLine("El primer numero par esta en la posicion " + indice);
        }
    }
}
