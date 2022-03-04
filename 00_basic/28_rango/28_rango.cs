/**
 * @file 28_rango.cs 
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

namespace Rango
{
    class Numero
    {
        private int numero;
        private static string nro;
        private RangoNumero rango;

        public void ingresarNumero()
        {
            rango = new RangoNumero();
            Console.Write("Digite un numero:");
            nro = Console.ReadLine();
            numero = Int32.Parse(nro);
            Console.WriteLine("" + numero + "" + rango.obtenerRango(numero));
            Console.ReadLine();
        }


        static void Main(string[] args)
        {
            Numero unNumero = new Numero();
            unNumero.ingresarNumero();

        }
    }
    class RangoNumero
    {
        public string obtenerRango(int numero)
        {
            string respuesta = "";
            if(numero < 0 )
            {
                respuesta = "el numero es menor a cero";
            }
            else if (numero == 0)
            {
                respuesta = "el numero es igual que cero";
            }
            else if (numero > 0 && numero <= 10)
            {
                respuesta = "el numero esta entre 1 y 10";
            }
            else if (numero > 10 && numero <= 20)
            {
                respuesta = "el numero esta entre 11 y 20";
            }
            else if (numero > 20 && numero <= 30)
            {
                respuesta = "el numero esta entre 21 y 30";
            }
            else if (numero > 30 && numero <= 40)
            {
                respuesta = "el numero esta entre 31 y 40";
            }
            else if (numero > 41 && numero <= 50)
            {
                respuesta = "el numero esta entre 41 y 50";
            }
            else
            {
                respuesta = "el numero es mayor que 50";
            }
            return respuesta;
        }
    }
            

}

