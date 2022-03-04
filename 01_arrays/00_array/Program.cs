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

namespace Arreglo
{
    class Principal
    {
        static void Main(string[] args)
        {
            InicioVector arreglo = new InicioVector();
            arreglo.imprimirVaector();
            Console.ReadLine();
        
        }
            
    }
    class InicioVector
    {
        private int[] numeros;

        public InicioVector()
        {
            numeros = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        }
        public void imprimirVaector()
        {
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine("" + numeros[i]);
            }
        }
    }
}

    

