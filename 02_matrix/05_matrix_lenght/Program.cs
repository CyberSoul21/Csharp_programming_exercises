/**
 * @file program.cs 
 * @brief 
 *
 *
 * @author Wilson Javier Almario Rodriguez
 * @date October - 2010
 * @update: 3/03/2022
 *
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EjercicioMatriz5_
{
    class Program
    {
        private MatrizLlena_Usuario llenar;

        public Program()
        {
            this.llenar = new MatrizLlena_Usuario();
        }
        public void HacerProceso()
        {
            llenar.IniciaMatriz();
            llenar.ImprimirMatriz();
        }

        static void Main(string[] args)
        {
            Program add = new Program();
            add.HacerProceso();
            Console.ReadLine();
        }
    }
}
