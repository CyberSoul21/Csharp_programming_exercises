/**
 * @file 12_conversor_grados_C _a _F.cs 
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

namespace Conversor_de_grados_celcius_a_farenheit
{
    class Conversor
    {
        private double c;
        private double f; 

        public void leerNumero()
        {
            Console.WriteLine("Grados Celcius:");
            c = double.Parse(Console.ReadLine());
            Calculo proceso = new Calculo();
            f = proceso.obtenerSuma(c,32);
            Console.WriteLine("Grados Farenheit:" + f);
            Console.ReadLine();
        }
        static void Main(string[] args)
        {
            Conversor add = new Conversor();
            add.leerNumero();
        }
     }
     class Calculo
     {
       public double obtenerSuma(double x, double y)
       {
          double Z = (1.8)*(x) + y;  
          return Z;
       } 

    }
} 


