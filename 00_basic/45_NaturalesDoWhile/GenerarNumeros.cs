using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NaturalesDoWhile
{
    class GenerarNumeros
    {
        public void NumerosNaturales()
        {
            int numero = 1;
            do
            {
                Console.WriteLine("" + numero);
                numero++;
            }
            while (numero < 11);
        }
    }
}
