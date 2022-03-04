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

namespace EjercicoMatriz1
{
    class Program
    {
        private Suma op;

        public Program()
        {
            this.op = new Suma();
        }
        public void realizarSumaMatrices()
        {

            op.CrearMatrizA();
            op.CrearMatrizB();
            op.CrearMatrizC();
            Console.WriteLine("Se crea matriz A :\n");
            op.imprimirMatrizA();
            Console.WriteLine("Se crea matriz B :\n");
            op.imprimirMatrizB();
            Console.WriteLine("Suma de la matriz A y B :\n");
            op.imprimirMatrizC();
        }

           
        static void Main(string[] args)
        {
            Program add = new Program();
            add.realizarSumaMatrices();
            Console.ReadLine();
        }
    }
}
