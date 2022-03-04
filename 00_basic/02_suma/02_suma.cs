/**
 * @file suma.cs 
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

namespace Suma
{
    class Ejercicio
    {
        private int a;
        private int b;
        private int suma;

        public void leerNumero()
        {
            //sentencia para imprimir el mensaje
            Console.WriteLine("Digite el primer numero a sumar");
            //sentencia para leer un numero
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite el segundo numero a sumar");
            b = int.Parse(Console.ReadLine());
            //se crea un objeto proceso de la clase Calculo
            Calculo proceso = new Calculo();
            // se accesa al metodo obtenerSuma
            suma = proceso.obtenerSuma(a, b);
            Console.WriteLine("La suma es: " + suma);
            Console.ReadLine(); //Pausa para ver el resultado
        }
        static void Main(string[] args)
        {
            //se crea un objeto add de la clase Suma
            Ejercicio add = new Ejercicio();
            add.leerNumero();
        }
    }

    class Calculo
    {
        /*
           *metodo que recibe como parametro dos valoresenteros.
           *los suma y retorna el resultado
           */
        public int obtenerSuma(int x, int y)
        {
            int z = x + y;
            return z;
        }
    }
}
