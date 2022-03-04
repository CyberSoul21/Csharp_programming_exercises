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

namespace NaturalesDoWhile
{
    class Program
    {
        private static GenerarNumeros numero;
        static void Main(string[] args)
        {
            numero = new GenerarNumeros();
            numero.NumerosNaturales();
            Console.Read();
        }
    }
}
