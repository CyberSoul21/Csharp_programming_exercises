using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio2
{
    class NumeroMayor
    {
        private int[] v;
        private Random rnd;

        public NumeroMayor()
        {
            v = new int[10];
            rnd = new Random();
        }
        public void InicializarVector()
        {
            for (int i = 0; i < v.Length; ++i)
            {
                v[i] = rnd.Next(0, 25);
            }

        }
        public void ImprimirVector()
        {
            for (int i = 0; i < v.Length; ++i)
            {
                Console.WriteLine("Vector[" + i + "]=" + v[i]);
            }

        }
        public void IniciarProceso()
        {
            int m = v[0];
            for (int i = 0; i < v.Length; ++i)
            {
                if (m < v[i])
                {
                    m = v[i];
                    Console.WriteLine("El mayor es" + m);
                }
            }
        }



    }
}
