/**
 * @file 18_dos_numeros.cs 
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

namespace Dos_numeros
{
    class Numeros
    {
        private static int a;
        private static int b;

        static void Main(string[] args)
        {
            Console.WriteLine("Deigite primer numero:");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite segundo numero:");
            b = int.Parse(Console.ReadLine());
            if (a != b)
            {
                Console.Write("\n"+ a + " Es diferente de " + b);
            }
            if (a == b)
            {
                Console.Write("\n"+ a + " Es igual que " + b);
            }
            Console.ReadLine();

        }
    }
}
