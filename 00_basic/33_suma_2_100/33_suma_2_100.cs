/**
 * @file 33_suma_2_100.cs 
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

namespace _Sumatoria
{
    class Program
    {

        private static Sumatoria suma;

        static void Main(string[] args)
        {


            suma = new Sumatoria();
            suma.obtenerSumatoria();
            Console.Read();
        }
    }
    class Sumatoria
    {

        int contador;



        public void obtenerSumatoria()
        {
            int suma = 0;
            contador = 2;

            while (contador <= 100)
            {
                suma = contador + suma;
                ++contador;

            }
            Console.WriteLine("la sumatoria del 2 al 100 es = " + suma);
        }

    }
}