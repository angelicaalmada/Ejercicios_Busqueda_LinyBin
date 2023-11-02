using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_Busqueda_LinyBin
{
    public class EjercicioLineal
    {
        public void ejercicio1()
        {
            int[] arreglo = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, };
            Console.WriteLine("Ingrese el numero a buscar");
            int numBuscar = Convert.ToInt32(Console.ReadLine());
            int posicion = -1;

            for (int i = 0; i < arreglo.Length; i++)
            {
                if (numBuscar == arreglo[i])
                {     
                    posicion = i;
                }
            }
            if(posicion > -1)
            {
                Console.WriteLine("El numero se encuentra en la posicion " +posicion);
            }
            else
            {
                Console.WriteLine("El numero no se encuentra");
            }
        }



        public void ejercicio2()
        {
            string[] arreglo = new string[] { "ABC", "DEF", "GHI", "JKL" };
            Console.WriteLine("Ingrese la cadena a encontrar");
            string cadena = Console.ReadLine();
            int indice = -1;
            for(int i=0; i<arreglo.Length; i++)
            {
                if(cadena == arreglo[i])
                {
                    indice = i;
                }

            }
            if (indice > -1)
            {
                Console.WriteLine("La cadena se encuentra en la posicion " + indice);
            }
            else
            {
                Console.WriteLine("La cadena no se encuentra");
            }
        }



        public void ejercicio3()
        {
            int[] arreglo = new int[] { 11, 21, 2, 31, 56, 61, 27, 85, 19, 13, 17};
            int posicion = -1;
            for(int i = 0; i < arreglo.Length; i++)
            {
                if (arreglo[i] % 2 == 0)
                {
                    posicion=i;
                    i = arreglo.Length;
                }
            }
            if (posicion > -1)
            {
                Console.WriteLine("El numero par se encuentra en la posicion " + posicion);
            }
            else
            {
                Console.WriteLine("No se encuentra numero par en el arreglo");
            }

        }


            //no terminado
        public void ejercicio4()
        {
            int[] arreglo = new int[] { 25, 5, 8, 7, 38, 9, 13, 17, 19, 50 };
            int[] arreglo2 = new int[4];
            int item = -1;
            for (int i = 0;i < arreglo.Length;i++)
            { 
                if (arreglo[i] % 2 == 0)
                {
                    arreglo[i] = item;
                    item = -1;
                }
            }
            if(item > -1)
            {
                Console.WriteLine("El numero se encuentra en la posicion " + item);
            }
            else 
            {
                Console.WriteLine("No hay numero par");
            }
        }
    }
}
