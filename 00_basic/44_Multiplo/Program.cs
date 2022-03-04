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

namespace Multiplo
{
    class Program
    {
        private static int numero; 
        private static string mult; 
        private static CalcularMultiplos proceso;

        static void Main(string[] args)
        {
            Console.Write("Digite un numero: ");
            mult = Console.ReadLine();
            numero = Convert.ToInt32(mult);
            proceso = new CalcularMultiplos();
            proceso.obtenerMultiplos(numero);
            Console.Read();
        }
    }
}
