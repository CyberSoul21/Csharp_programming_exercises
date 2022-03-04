/**
 * @file 34_sumatoria_impares.cs 
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

namespace SumatoriaImpares
{
    class Program
    {
        private static int numero;
        private static string suma;
        private static Sumatoria proceso;

        static void Main(string[] args)
        {
            Console.Write("Digite un numero = ");
            suma = Console.ReadLine();
            numero = Convert.ToInt32(suma);

            proceso = new Sumatoria();
            proceso.obtenerSumatoria(numero);
            Console.Read();
        }
    }
    class Sumatoria
    {
        int suma;
        int contador;



        public void obtenerSumatoria(int numero)
        {
            suma = 0;
            contador = 1;

            while (contador <= numero)
            {
                suma = (contador*2-1) + suma;
                ++contador;
            }
            Console.WriteLine("la sumatoria de los impares es = " + suma);
        }

    }
}