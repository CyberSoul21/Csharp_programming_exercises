/**
 * @file 20_valor_absoluto.cs 
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

namespace Valor_absoluto
{
    class Valor
    {
        private int a;
        private int b;

        public void leerNumero()
        {
            Console.WriteLine("Digite Numero:");
            a = int.Parse(Console.ReadLine());
            Calculo proceso = new Calculo();
            b = proceso.obtenerValorabsoluto(a);
            Console.WriteLine("El valor absoluto de " + a + " es: " + b);
            Console.ReadLine();
        }

        static void Main(string[] args)
        {
            Valor ab = new Valor();
            ab.leerNumero();



        }

    }
    class Calculo
    {
        public int obtenerValorabsoluto(int a)
        {
            int b = Math.Abs(a);
            return b;
        }
    }
 
}

