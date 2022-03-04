/**
 * @file NumeroPar.cs 
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
    class NumeroPar
    {
        private int par;
        public void numerosPares()
        {
            par = 2;
            while (par <= 20)
            {
                Console.WriteLine("" + par + "\n");
                par = par + 2;
            }
        }
    }
}
