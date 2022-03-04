/**
 * @file 31_numero_aleatorios.cs 
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
using System.Text;

namespace _NumerosAleatorios
{
    class Program
    {
        private static  string mult;
        private  static Numero proceso;

        static void Main(string[] args)
        {
            Console.Write("Pulse la tecla enter");
            mult = Console.ReadLine();
           
            proceso = new Numero();
            proceso.obtenerNumero();
            Console.Read();
        }

    }

    class Numero
    {
        private Random rnd;
        private int contador;
        private int n;
        


        public void obtenerNumero()
        {
            
            contador = 1;
            n = 0;

           rnd = new Random();

            while (contador  <= 15)
            {
                n = rnd.Next(0, 50);
                Console.WriteLine("" + n);
                ++contador;
                
            }
        }
    }
}
