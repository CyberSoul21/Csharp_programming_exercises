/**
 * @file 30_multiplo14.cs 
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

namespace multiplos14
{
    class Multiplo14
    {
        int multiplo;
        int n;
        int b;

        public void obtenerMultiplos(int b)
        {
            n = 1;
            multiplo = 0;

            while (n <= b )
            {
                multiplo = 14 * n;
                Console.WriteLine("" + multiplo);
                ++n;
            }
        }
    }
}
