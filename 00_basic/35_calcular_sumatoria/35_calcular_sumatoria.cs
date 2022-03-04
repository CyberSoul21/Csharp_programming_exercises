/**
 * @file 35_calcular_sumatoria.cs 
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

namespace CalcularSumatoria
{
    class CicloFor
    {
        private int n;
        private string numero;
        private int respuesta;
        private SumaNumeros proceso;

        
        public void leerNumeros()
        {
            proceso = new SumaNumeros();    
            System.Console.WriteLine("Digite el valor de numeros naturales a sumar:");
            numero = System.Console.ReadLine();
            n = Convert.ToInt32(numero);
            respuesta = proceso.obtenerSuma(n);
            Console.WriteLine("\nSumatoria de los " + n + " primeros numeros naturales es " + respuesta);
            Console.Read();
        }
        static void Main(string[] args)
        {
            CicloFor datos = new CicloFor();
            datos.leerNumeros();
        }
    }
    class SumaNumeros
    {
        public int obtenerSuma(int num)
        {
            int suma = 0;
            for (int n = 1; n <= num; n++)
            {
                suma += n;
            }
            return suma;
        }
    }
}
