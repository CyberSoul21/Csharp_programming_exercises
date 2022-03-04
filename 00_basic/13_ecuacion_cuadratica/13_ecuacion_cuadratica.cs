/**
 * @file 13_ecuacion_cuadratica.cs 
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

namespace solucion_de_la_ecuacion
{
    class Ecuacion
    {
        private double A;
        private double B;
        private double C;
        private double R;
        private double X1;
        private double X2;

        public void leerNumero()
        {
            Console.WriteLine("Solucion a la ecuacion de la forma Ax2 + Bx + C\n");
            Console.WriteLine("Digite A:");
            A = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite B:");
            B = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite C:");
            C = double.Parse(Console.ReadLine());
            Calculo proceso = new Calculo();
            R = proceso.obtenerOperacion(A, B, C);
            if (R < 0)
            {
                Console.WriteLine("No pertenece a los reales\n");
            }
            else
            X1 = proceso.obtenerCociente(A, B, C, R);
            Console.WriteLine("Las soluciones de la ecuacion son:\n");
            Console.WriteLine("X1=" + X1 + "\n");
            X2 = proceso.obtenerCociente2(A, B, C, R);
            Console.WriteLine("X2=" + X2);
            Console.ReadLine();

        }
        static void Main(string[] args)
        {
            Ecuacion add = new Ecuacion();
            add.leerNumero();
        }

    }

    class Calculo
    {
        public double obtenerOperacion(double A, double B, double C)
        {
            double R = B * B - 4 * A * C;

            return R;

        }
        public double obtenerCociente(double A, double B, double C, double R)
        {
            double X1 = (-B + Math.Sqrt(R)) / (2 * A);
           
            return X1;
        
        }
        public double obtenerCociente2(double A, double B, double C, double R)
        {
            
            double X2 = (-B - Math.Sqrt(R)) / (2 * A);
         
            return X2;
        }
    }



}
