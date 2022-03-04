/**
 * @file 37_factorialFor.cs 
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
            proceso.obtenerFactorial(numero);
            Console.Read();
        }
    }
    class Factorial
    {
        public void obtenerFactorial(int numero)
        {
            int por = 1;
            for (int contador = 1; contador <= numero; ++contador)
            {

                por = contador * por;
                
                
            }
            Console.WriteLine("El factorial " + "de " + numero + " es = " + por);
        }
    }
}

           
          
            
            
        