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

namespace Arrays3
{
    class RadomicoApp
    {
        private VectorRandomico vect;

        public RadomicoApp()
        {
            this.vect = new VectorRandomico();
        }
        public void generarProceso()
        {
            vect.inicializarVector();
            vect.imprimirVector();
            Console.ReadLine();
        }

        static void Main(string[] args)
        {
            RadomicoApp randomico = new RadomicoApp();
            randomico.generarProceso();
        }
    }
    class VectorRandomico
    {
        private int[]v;
        private Random rnd;

        public VectorRandomico()
        {
            v = new int[10];
            rnd = new Random();

        }
        public void inicializarVector()
        {
            for (int i = 0; i < v.Length; ++i)
            {
                v[i] = rnd.Next(-221,50);
            }
        }
        public void imprimirVector()
        {
            for (int i = 0; i < v.Length; ++i)
            {
                Console.WriteLine("Vector[" + i + "]=" + v[i]);
            }
        }

    }
}
