﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Multiplo
{
    class VerTabla
    {
        int multiplo;
        int contador;
        public void obtenerMultiplos(int numero)
        {
            contador = 1;
            multiplo = 0;

            while (contador <= 10)
            {
                multiplo = numero * contador;
                Console.WriteLine(+numero + " * " + contador + " = " + multiplo);
                ++contador;
            }
        }
    }
}
