using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sumatoria
{
    class SumaNumeros
    {
        public int obtenerSuma(int num)
        {
            int suma = 0;
            int cont = 1;
            do
            {
                suma += cont;
                cont++;
            }
            while (cont <= num);
            return suma;
        }
    }
}
