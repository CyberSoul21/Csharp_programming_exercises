/**
 * @file 27_numero_mayor.cs 
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

namespace NumeroMayor
{
    class NumeroMayor
    {
        private int x;
        private int y;
        private int z;
        private int mayor;
        private Mayor numeroMayor;
        private string n;

        public NumeroMayor()
        {
            this.x = 0;
            this.y = 0;
            this.z = 0;
            this.mayor = 0;
            this.numeroMayor = new Mayor();
        }
        public void leerNumeros()
        {
            Console.WriteLine("Primer valor: ");
            n = Console.ReadLine();
            x = Convert.ToInt32(n);

            Console.Write("Segundo Valor: \n");
            n = Console.ReadLine();
            y = Convert.ToInt32(n);

            Console.Write("Tercer Valor: \n");
            n = Console.ReadLine();
            z = Convert.ToInt32(n);

            mayor = numeroMayor.obtenerMayor(x, y, z);
            Console.WriteLine("Numero Mayor: " + mayor);
            Console.ReadLine();
        }

        static void Main(string[] args)
        {
            NumeroMayor nm = new NumeroMayor();
            nm.leerNumeros();

        }
    }
    class Mayor
    {
        public int obtenerMayor(int x, int y, int z)
        {
            if (x >= y)
                if (x >= z)
                    return x;
                else
                    return z;
            else if (y >= z)
                return y;
            else
                return z;
        }
    }
}


