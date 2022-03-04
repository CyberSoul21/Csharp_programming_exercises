/**
 * @file 04_pendiente.cs 
 * @brief 
 *
 *
 * @author Wilson Javier Almario Rodriguez
 * @date march - 2010
 * @update: 3/03/2022
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pendiente_de_la_recta
{
    class Pendiente
    {
        private double a;
        private double b;
        private double c;
        private double d;
        private double m;

        public void leerNumero()
        {
            Console.WriteLine("Digite X1:");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite X2:");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite Y1:");
            c = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite Y2:");
            d = double.Parse(Console.ReadLine());
            Calculo proceso = new Calculo();
            m = proceso.obtenerDivision(a, b, c, d);
            Console.WriteLine("m =" + m);
            Console.ReadLine();
        }
        static void Main(string[] args)
        {
            Pendiente add = new Pendiente();
            add.leerNumero();
        }
    }
    class Calculo
    {
        public double obtenerDivision(double a, double b, double c, double d)  
        {
            double Z = (d - c) / (b - a);
            return Z;
        }
    }  
}
 