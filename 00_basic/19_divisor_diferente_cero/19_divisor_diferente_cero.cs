/**
 * @file 19_divisor_diferente_cero.cs 
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

namespace Divisor_diferente_de_0
{
    class Division
    {
        private double a;
        private double b;
        private double c;
        

        public void leerNumero()
        {
            Console.WriteLine("Digite Dividendo:");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite divisor:");
            b = double.Parse(Console.ReadLine());
            if (b == 0)
            {
                Console.WriteLine("El divisor debe ser diferente de 0");
                Console.ReadLine();
            }
            else
            {
                Calculo proceso = new Calculo();
                c = proceso.obtenerDivision(a, b);
                Console.WriteLine("cociente es igual a: " + c);
                Console.ReadLine();
            }
        }
        static void Main(string[] args)
        {
           Division add = new Division();
            add.leerNumero();
        }
    }
    class Calculo
    {
        public double obtenerDivision(double a, double b)
        {
            double Z = a/b;
            return Z;
        }
    }
}
