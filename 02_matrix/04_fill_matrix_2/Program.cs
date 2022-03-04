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

namespace EjercicioMatriz4
{
    class Program
    {
        private LlenarMatriz_X_y_Y xy;

        public Program()
        {
            this.xy = new LlenarMatriz_X_y_Y();
        }
        public void empezarLlenar()
        {
            xy.inicializarMatriz();
            xy.imprimirMatriz();
        }

        static void Main(string[] args)
        {
            Program add = new Program();
            add.empezarLlenar();
            Console.ReadLine();
        }
    }
}