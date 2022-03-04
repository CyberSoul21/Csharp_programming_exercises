using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EjercicoMatriz1
{
    class Suma
    {
        //Declaracion de variables que se usaran a durante el programa..
        private int[,] matrizA;
        private int[,] matrizB;
        private int[,] matrizC;
        private Random rnd;
        const int SIZE_MATRIZ = 6;
        public Suma()
        {
            this.matrizA = new int[SIZE_MATRIZ, SIZE_MATRIZ];
            this.matrizB = new int[SIZE_MATRIZ, SIZE_MATRIZ];
            this.matrizC = new int[SIZE_MATRIZ, SIZE_MATRIZ];
            this.rnd = new Random();
        }
        //Metodo que inicializa y llena matriz...
        public void CrearMatrizA()
        {
            for (int i = 0; i < SIZE_MATRIZ; i++)
            {
                for (int j = 0; j < SIZE_MATRIZ; j++)
                {
                    matrizA[i, j] = rnd.Next(0, 100);

                }
            }
        }
        public void CrearMatrizB()
        {
            for (int i = 0; i < SIZE_MATRIZ; i++)
            {
                for (int j = 0; j < SIZE_MATRIZ; j++)
                {
                    matrizB[i, j] = rnd.Next(0, 100);

                }
            }
        }
        //La matriz C es la suma de la matriz A Y B metodo para hacer esta operacion..
        public void CrearMatrizC()
        {
            for (int i = 0; i < SIZE_MATRIZ; i++)
            {
                for (int j = 0; j < SIZE_MATRIZ; j++)
                {
                    matrizC[i, j] = matrizA[i, j] + matrizB[i, j];

                }
            }
        }
        public void imprimirMatrizA()
        {
            string salida = "";
            for (int i = 0; i < SIZE_MATRIZ; i++)
            {
                for (int j = 0; j < SIZE_MATRIZ; j++)
                {
                    salida += matrizA[i, j] + "\t";
                }
                salida += "\n";
            }
            System.Console.Write(salida);
        }
        public void imprimirMatrizB()
        {
            string salida = "";
            for (int i = 0; i < SIZE_MATRIZ; i++)
            {
                for (int j = 0; j < SIZE_MATRIZ; j++)
                {
                    salida += matrizB[i, j] + "\t";
                }
                salida += "\n";
            }
            System.Console.Write(salida);
        }
        public void imprimirMatrizC()
        {
            string salida = "";
            for (int i = 0; i < SIZE_MATRIZ; i++)
            {
                for (int j = 0; j < SIZE_MATRIZ; j++)
                {
                    salida += matrizC[i, j] + "\t";
                }
                salida += "\n";
            }
            System.Console.Write(salida);
        }
    }
}
