using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Matriz2
{
    class OperacionMatriz
    {
        private int numFilas;
        private int numCol;
        private int[,] m;
        private int suma;
        public OperacionMatriz()
        {
            numCol = 5;
            numFilas = 5;
            this.m = new int[numFilas,numCol];
        }

       
        public void llenarMatriz()
        {
            int cont = 1;

            for (int i = 0; i < numFilas; i++)
            {
                for (int j = 0; j < numCol; j++)
                {
                    m[i, j] = cont++;
                }
            }
        }
        public void imprimirMatriz()
        {
            string salida = "";

            for (int i = 0; i < numFilas; i++)
            {
                for (int j = 0; j < numCol; j++)
                {
                    salida += m[i, j] + "\t";
                }
                salida += "\n";
            }
            System.Console.Write(salida);
        }
        public int sumarElementos()
        {
            for (int i = 0; i < numFilas; i++)
            {
                for (int j = 0; j < numCol; j++)
                {
                    suma = suma + m[i, j];
                }
            }
            return suma;
        }
        public int obetenerSumaDiagonal()
        {
            int sumaDiagonal = 0;
            for (int i = 0; i < numCol; i++)
            {
                sumaDiagonal += m[i, i];
            }
            return sumaDiagonal;
            
            
        }


       }

    }

