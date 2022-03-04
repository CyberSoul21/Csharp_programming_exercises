/**
 * @file 09_area_y_longitud_circunferencia.cs 
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

namespace Seno
{
    class Principal
    {
        private double numero;
        private double resultado;

        public void leerNumero()
        {
            Console.WriteLine("Digite un numero:");
            numero = double.Parse(Console.ReadLine());
            CalculoSeno sin = new CalculoSeno();
            resultado = sin.calcularSeno(numero);
            Console.WriteLine("El seno de: " + numero + " es " + resultado);
            Console.ReadLine();
        }
        static void Main(string[] args)
        {
            Principal ppal = new Principal();
            ppal.leerNumero();
        }
    }
    class CalculoSeno
    {
        public double calcularSeno(double n)
        {
            double grados = n*82*Math.PI/360;
            double seno = Math.Sin(grados);
            return seno;
        }
    }
}
