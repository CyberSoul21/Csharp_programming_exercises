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

namespace EjercicioMatriz3_
{
    class Program
    {
        private LlenarMatriz hacer;

        public Program()
        {
            this.hacer = new LlenarMatriz();
        }
        public void empezarLlenar()
        {
            hacer.inicializarMatriz();
            hacer.imprimirMatriz();
        }

        static void Main(string[] args)
        {
            Program add = new Program();
            add.empezarLlenar();
            Console.ReadLine();
        }
    }
}