/**
 * @file 03_raiz_cuadrada.cs 
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

namespace RaizCuadrada
{
    class Principal
    {
        private double numero;
        private double respuesta;

        public void leerNumero()
        {
            //sentencia para imprimir el mensaje
            Console.WriteLine("Digite un numero");
            //sentencia para leer un numero
            numero = double.Parse(Console.ReadLine());

            //se crea un objeto proceso de la clase Raiz
            Raiz r = new Raiz();
            //se accesa al metodo obtenerSuma
            respuesta = r.calcularRaiz(numero);
            Console.WriteLine("La raiz Cuadrada es: " + respuesta);
            Console.ReadLine(); //pausa para ver el resultado
        }

        static void Main(string[] args)
        {
            //se cra un objeto add de la clase RaizCuadrada
            Principal raiz = new Principal();
            raiz.leerNumero();

        }
    }

    class Raiz
    {
        public double calcularRaiz(double n)
        {
            double raiz = Math.Sqrt(n);
            return raiz;
        }
    }
}
