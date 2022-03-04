/**
 * @file 21_multiplo_7.cs 
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

namespace Multiplo_de_7
{
    class Program
    {
        private double numero;
        private string n;
        private multiplo7 tiponumero;

        public void leernumero()
        {
            tiponumero = new multiplo7();
            Console.Write("Digite un numero: ");
            n = Console.ReadLine();
            numero = Convert.ToDouble(n);
            if (tiponumero.esmultiplo7(numero))
                Console.WriteLine("" + numero + " es multiplo de 7");
            else
                Console.WriteLine("" + numero + " no es multiplo de 7");
            Console.ReadLine();
        }
        static void Main(string[] args)
        {
            Program ppal = new Program();
            ppal.leernumero();
        }
    }
    class multiplo7
    {
        public bool esmultiplo7(double numero)
        {
            bool resp = false;
            if (numero % 7 == 0)
                resp = true;
            return resp;
        }
    }
}
