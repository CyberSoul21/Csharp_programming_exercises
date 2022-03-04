using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio1
{
    class EjercicioVector
    {
         private int[] v;
        
        private int x;
        public EjercicioVector()
        {
            Console.WriteLine("Digite longitud del vector");
            x = int.Parse(Console.ReadLine());
            v = new int[x];
            
        }

        public void inicializarVector()
        {
            string num = "";
            for (int i = 0; i < v.Length; ++i)
            {
                Console.Write("Digite edad");
                num = Console.ReadLine();
                v[i] = Convert.ToInt32(num);
            }

        }

        public void ImprimirVector()
        {
            for (int i = 0; i < v.Length; ++i)
            {
                Console.WriteLine("Vector[" + i + "]=" + v[i]);
            }

        }

        public bool buscarNumero(int n)
        {
            bool resp = false;
            for (int i = 0; i < v.Length; i++)
            {   
                if (v[i] == n)
                {
                    resp = true;
                    break;
                }
            }
            return resp;
        }

    }
}
