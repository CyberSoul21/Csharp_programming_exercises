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

namespace Arreglos2
{
    class VectorApp
    {
        private ProcesoVector proceso;

        public VectorApp()
        {
            this.proceso = new ProcesoVector();
        }
        public void obtenerArreglo()
        {
            proceso.inicializarVector();
            proceso.imprimirVector();
            Console.ReadLine();
        }
        static void Main(string[] args)
        {
            VectorApp vector = new VectorApp();
            vector.obtenerArreglo();
        }
    }
    class ProcesoVector
    {
        private int[] v;
        private int cont;

        public ProcesoVector()
        {
            this.v = new int[10];
            this.cont = 1;
        }
        public void inicializarVector()
        {
            for (int i = 0; i < v.Length; ++i)
            {
                v[i] = cont;
                cont++;
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

