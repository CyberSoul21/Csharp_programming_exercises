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

namespace NumerosPares
{
    class Program
    {
        private static NumeroPar Par;
        static void Main(string[] args)
        {
            Par = new NumeroPar();
            Par.numerosPares();
            Console.Read();
        }
    }
}
