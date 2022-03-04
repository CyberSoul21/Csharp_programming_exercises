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

namespace Matriz1
{
    class Program
    {
        private MatrizAleatoria proceso;

        public Program()
        {
            this.proceso = new MatrizAleatoria();

        }
        public void realizar()
        {
            proceso.llenarMatriz();
            proceso.imprimirMatriz();
        }

        static void Main(string[] args)
        {
            Program add = new Program();
            add.realizar();
            Console.ReadLine();
        }
    }
}
