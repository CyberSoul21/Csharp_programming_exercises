using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EjercicioMatriz3_
{
    class LlenarMatriz
    {

        private int[,] matriz;
        private int numCol;
        private int numFil;

        public LlenarMatriz()
        {
            Console.WriteLine("Digite Numero de columnas:");
            numCol = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite Numero de Filas: ");
            numFil = int.Parse(Console.ReadLine());
            this.matriz = new int[numFil, numCol];
        }
        public void inicializarMatriz()
        {
            for (int i = 0; i < numFil; i++)
            {
                for (int j = 0; j < numCol; j++)
                {
                    matriz[i, j] = 0;
                    if (matriz[i, j] == 0)
                    {
                        matriz[i, i] = 1;
                    }
                }
            }
        }
        public void imprimirMatriz()
        {
            string salida = "";
            for (int i = 0; i < numFil; i++)
            {
                for (int j = 0; j < numCol; j++)
                {
                    salida += matriz[i, j] + "\t";
                }
                salida += "\n";
            }
            System.Console.Write(salida);
        }





    }
}