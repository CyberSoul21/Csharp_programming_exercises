/**
 * @file 36_factorial.cs 
 * @brief 
 *
 *
 * @author Wilson Javier Almario Rodriguez
 * @date march - 2010
 * @update: 3/03/2022
 *
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace factorial
{

    class Program
    {
        private static int numero;
        private static string por;
        private static Factorial proceso;

        static void Main(string[] args)
        {
            Console.Write("Digite un numero = ");
            por = Console.ReadLine();
            numero = Convert.ToInt32(por);

            proceso = new Factorial();
            proceso.obtenerSumatoria(numero);
            Console.Read();
        }
    }
    class Factorial
    {
        int por;
        int contador;



        public void obtenerSumatoria(int numero)
        {
            por = 1;
            contador = 1;
            do
            {
                por = contador * por;
                ++contador;
            } while (contador <= numero);
            
            Console.WriteLine("El factorial " + " " + numero + " es =" + por);
        }

    }
}