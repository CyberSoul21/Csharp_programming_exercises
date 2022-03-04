using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Matriz1
{
    class MatrizAleatoria
    {
        private int[,]matriz;
        const int SIZE_MATRIZ = 4;
        public MatrizAleatoria()
        {
            
            this.matriz = new int[SIZE_MATRIZ, SIZE_MATRIZ];
        }
        public void llenarMatriz()
        {
            int cont=0;
            Random rnd = new Random();
            for (int i = 0; i < SIZE_MATRIZ; i++)
            {
                for (int j = 0; j < SIZE_MATRIZ; j++)
                {
                    matriz[i, j] = cont+1;
                    cont++;
                }

            }
        }
        public void imprimirMatriz()
        {
            string salida = "";
            for (int i = 0; i < SIZE_MATRIZ; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    salida += matriz[i, j] + "\t";
                }
                salida += "\n";
            } 
            System.Console.Write(salida);
        }
    }
}
