/**
 * @file 40_promedio.cs 
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
using System.Text;

namespace _3._1.PromedioEdad
{
    class Program
    {
        private double edad;
        private string numero;
        private double total;
        private double edades;
        private double contador;

        private Promedio proceso;

        public Program()
        {

            this.edad = 0;
            this.numero = "";
            this.total = 0;
            this.edades = 0;
            this.contador = 0;
            this.proceso = new Promedio();
        }
        public void leerEdad()
        {
            double suma = 0;

            Console.WriteLine("Digite numero de edades a promediar = ");
            numero = Console.ReadLine();
            edades = Convert.ToDouble(numero);

            
            do{                
                Console.WriteLine(" Digite edades  = ");
                numero = Console.ReadLine();
                edad = Convert.ToDouble(numero);
                suma = suma + edad;
                contador++;

            }while (  contador< edades);

            total = proceso.obtenerPromedio(suma,contador);
            Console.WriteLine("Promedio edades = " + total);
            Console.Read();
        }
        static void Main(string[] args)
        {
            Program datos = new Program();
            datos.leerEdad();
        }

    }
    class Promedio
    {
        public double obtenerPromedio(double suma,double total)
        {
            return suma / total;
        }
    }
}
