/**
 * @file 32_numeros_impares.cs 
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
using System.Text;

namespace _NumerosImpares
{
    class Program
    {
        private static int numero;
        private static string mult;
        private static Impares proceso;

        static void Main(string[] args)
        {
            Console.Write("Digite un numero = ");
            mult = Console.ReadLine();
            numero = Convert.ToInt32(mult);

            proceso = new Impares();
            proceso.obtenerImpares(numero);
            Console.Read();
        }
    }


    class Impares
    {
         private int impar;

        public void obtenerImpares(int numero)
        {
            impar = 1;

            while (impar <= numero)
            {
                impar = impar + 2;
                if (impar <= numero)
                {
                    Console.WriteLine("" + impar);
                }

            
            }
        }
    }
}