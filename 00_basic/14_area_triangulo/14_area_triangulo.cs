/**
 * @file 14_area_triangulo.cs 
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

namespace Area
{
    class Area 
    {
        private double a;
        private double b;
        private double c;
        private double p;
        private double A;

        public void leerNumero()
        {
            Console.WriteLine("Area de un triangulo a partir del semiperimetro\n");
            Console.WriteLine("Digite el lado a:");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite el lado b:");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite el lado c:");
            c = double.Parse(Console.ReadLine());
            Calculo proceso = new Calculo();
            p = proceso.obtenerCociente(a, b, c);
            Console.WriteLine("El semiperimetro es:\n");
            Console.WriteLine("p =" + p + "\n");
            A = proceso.obtenerRaiz(a, b, c, p);
            Console.WriteLine("El area del triangulo es:" + A);
            Console.ReadLine(); 

        }
        static void Main(string[] args)
        {
          Area add = new Area();
          add.leerNumero();
                 
        }
    }
    class Calculo
    {
        public double obtenerCociente(double a, double b, double c)
        {
            double p = (a + b + c) / (2);
            return p;
        }
        public double obtenerRaiz(double a, double b, double c, double p)
        {
            double Area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            return Area;

        }
    }

 


 
    

}  
