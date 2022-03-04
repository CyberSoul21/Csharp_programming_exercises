using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EjercicioMatriz5_
{
    class MatrizLlena_Usuario
    {

        private int[,] matriz;
        const int SIZE_MATRIZ = 3;
        private int x;

        public MatrizLlena_Usuario()
        {
            this.matriz = new int[SIZE_MATRIZ, SIZE_MATRIZ];
        }
        public void IniciaMatriz()
        {
            
            for (int i = 0; i < SIZE_MATRIZ; i++)
            {
                for (int j = 0; j < SIZE_MATRIZ; j++)
                {
                    Console.WriteLine("Digite datos para llenar una matriz 3x3 :");
                    x = int.Parse(Console.ReadLine());
                    matriz[i, j] = x;
                }

            }

        }
        public void ImprimirMatriz()
        {
            string salida = "";
            for (int i = 0; i < SIZE_MATRIZ; i++)
            {
                for (int j = 0; j < SIZE_MATRIZ; j++)
                {
                    salida += matriz[i, j] + "\t";
                }
                salida += "\n";
            }
            System.Console.Write("\n"+salida);
        }
    }
}
