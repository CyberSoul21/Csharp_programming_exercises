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

namespace Matriz2
{
    class Program
    {
        private OperacionMatriz op;
       
        public Program()
        {
            this.op = new OperacionMatriz();
        }
        public void HacerOperacionMatriz()
        {
            op.llenarMatriz();
            op.imprimirMatriz();
           
            Console.Write("\n" + op.sumarElementos());
            Console.Write("\n" + op.obetenerSumaDiagonal());
        }
            

        static void Main(string[] args)
        {
            Program add = new Program();
            add.HacerOperacionMatriz();
            Console.ReadLine();
        }
    }
}
