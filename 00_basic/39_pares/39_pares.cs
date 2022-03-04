/**
 * @file 39_pares.cs 
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
    class Program
    {
        private static int numero;
        private static string p;
        private static NumeroPar Par;
        static void Main(string[] args)
        {
            Console.WriteLine("Digite un numero:");
            p = Console.ReadLine();
            numero = Convert.ToInt32(p);
            Par = new NumeroPar();
            Par.numerosPares(numero);
            Console.Read();
        }
    }
    class NumeroPar
    {
        private int par;
       
        public void numerosPares(int numero)
        {
           
            par = 2;

            do
            {
                Console.WriteLine(" " + par + "\n");
                par = par + 2;
            } while (par <= numero);
        }
    }
}

