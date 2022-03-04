/**
 * @file 06_conversor_grados_F_a_C.cs 
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

namespace Conversor_de_grados_F_a_C
{
    class Conversor
    {
        private double f;
        private double c;

        public void leerNumero()
        {
            Console.WriteLine("Grados Farenheit:");
            f = double.Parse(Console.ReadLine());
            Calculo proceso = new Calculo();
            c = proceso.obtenerProducto(f, 9/5);
            Console.WriteLine("Grados Celcius:" + c);
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
        public double obtenerProducto(double x, double y)
        {
            double Z = (x - 32) * (9 / 5); 
            return Z;
        }

    }
}

