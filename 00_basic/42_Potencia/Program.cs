/**
 * @file program.cs 
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

namespace potenciaCuadradoyCubo
{
    class Program
    {
        private static int n;
        private static string n1;
        private static potencia numeros;
        static void Main(string[] args)
        {
            Console.Write("Digite la cantidad de numeros los cuales se les mostrara informacion:");
            n1 = Console.ReadLine();
            n = Convert.ToInt32(n1);
           
            numeros = new potencia(); 
            numeros.numerosNaturales(n);
            Console.Read();
        }
    }
}

