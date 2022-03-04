/**
 * @file 05_longitud_circunferencia.cs 
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

namespace Longitud_de_la_circunferencia
{
    class circunferencia
    {
        private double radio;
        private double longitud;
        
        public void leerRadio()
        {
            Console.WriteLine("Digite el radio de la circunferencia:"); 
            radio = double.Parse(Console.ReadLine());
            OperacionesCircunferencia circ = new OperacionesCircunferencia();
            longitud = circ.obtenerLongitudCircunferencia(radio);
            Console.WriteLine("La longitud de la circunferencia es:" + longitud);
            Console.WriteLine("\npulse enter");
            Console.ReadLine();
        }
        static void Main(string[] args)
        {
            circunferencia circle = new circunferencia();
            circle.leerRadio();

        }
    }
    class OperacionesCircunferencia
    {
        public double obtenerLongitudCircunferencia(double r)
        {
            double longitud = 2 * Math.PI * r;
            return longitud;
        }
    }

} 


