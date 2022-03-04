using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace circunferencia
{
    class DatoCircunferencia
    {
        private double radio;
        private double area;
        private double longitud;

        public void leerRadio()
        {
            Console.WriteLine("Digite el radio de la circunferencia:");
            radio = double.Parse(Console.ReadLine());
            OperacionesCircunferencia circ = new OperacionesCircunferencia();
            longitud = circ.obtenerLongitudCircunferencia(radio);
            Console.WriteLine("La longitud de la circunferencia es:" + longitud);

            area = circ.obtenerLongitudCircunferencia(radio);
            Console.WriteLine("\nEl area de la circunferencia es:" + area);
            Console.WriteLine("\npulse enter");
            Console.ReadLine();
        }
        static void Main(string[] args)
        {
            DatoCircunferencia circle = new DatoCircunferencia();
            circle.leerRadio();

        }
    }
    class OperacionesCircunferencia
    {
        public double obtenerLongitudCircunferencia(double r)
        {
             //longitud = 2 * Math.PI * r;
            return 2 * Math.PI * r;
        }
        public double obtenerAreaCircunferencia(double r)
        {
            //area = pi*r*r
            return Math.PI * Math.Pow(r, 2);
        }
    } 


} 



