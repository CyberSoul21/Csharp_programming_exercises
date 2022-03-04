﻿/**
 * @file 29_calcular_multiplo.cs 
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
    class CalcularMultiplos
    {
        int multiplo;
        int contador;
        public void obtenerMultiplos(int numero)
        {
            contador = 1;
            multiplo = 0;

            do
            {
                multiplo = numero * contador;
                Console.WriteLine("\n" + multiplo);
                ++contador;
            } while (contador <= numero);
        }
    }
}
