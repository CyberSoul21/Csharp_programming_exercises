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
        private static VerTabla proceso;

        static void Main(string[] args)
        {
            Console.Write("Digite la tabla que desea ver: ");
            mult = Console.ReadLine();
            numero = Convert.ToInt32(mult);
            proceso = new VerTabla();
            proceso.obtenerMultiplos(numero);
            Console.Read();
        }
    }
}
