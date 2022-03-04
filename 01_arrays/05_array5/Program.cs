/**
 * @file program.cs 
 * @brief 
 *
 *
 * @author Wilson Javier Almario Rodriguez
 * @date September - 2010
 * @update: 3/03/2022
 *
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PromedioEdades
{
    class PromedioApp
    {
        private PromedioEdad promedio;

        public PromedioApp()
        {
            this.promedio = new PromedioEdad();
        }
        public void obtenerDatos()
        {
           promedio.leerEdades();
           promedio.imprimirEdades();
           Console.WriteLine("Edad promedo"+promedio.obtenerPromedio());
           Console.ReadLine();
        }

        static void Main(string[] args)
        {
            PromedioApp pe = new PromedioApp();
            pe.obtenerDatos();
        }
    }
    class PromedioEdad
    {
        private int[]edad;
        public PromedioEdad()
        {
            edad = new int[10];

        }
        public void leerEdades()
        {
            string num = "";
            for (int i = 0; i < edad.Length; ++i)
            {
                Console.Write("Digite edad");
                num = Console.ReadLine();
                edad[i] = Convert.ToInt32(num);
            }
        }
        public void imprimirEdades()
        {
            string salida = "";
            for (int i = 0; i < edad.Length; ++i)
            {
                salida += "edad[" + i + "]=" + edad[i] + "\n";
            }
            Console.WriteLine((salida));
        }
        public double obtenerPromedio()
        {
            int i;
            double suma = 0;
            int n = edad.Length;
            for (i = 0; i < n; i++)
            {
                suma += edad[i];
            }
            return suma/n;
        }
    }
}
