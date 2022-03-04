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

namespace EjercicioMatriz2
{
    class Resta_Y_Transpuesta
    { //Declaracion de variables que se usaran a durante el programa..
        private int[,] matrizA;
        private int[,] matrizB;
        private int[,] matrizC;
        private int[,] TranspuestaResta;
        private Random rnd;
        const int SIZE_MATRIZ = 4;
        public Resta_Y_Transpuesta()
        {
            this.TranspuestaResta = new int[SIZE_MATRIZ, SIZE_MATRIZ];
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
        //La matriz C es la Resta de la matriz A Y B metodo para hacer esta operacion..
        public void CrearMatrizC()
        {
            for (int i = 0; i < SIZE_MATRIZ; i++)
            {
                for (int j = 0; j < SIZE_MATRIZ; j++)
                {
                    matrizC[i, j] = matrizA[i, j] - matrizB[i, j];

                }
            }
        }
        //impresion matriz A
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
        //impresion matriz B
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
        //impresion matriz C
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
        //Metodo para transponer el arreglo C
        public void transponer()
        {
            for (int i = 0; i < SIZE_MATRIZ; i++)
            {
                for (int j = 0; j < SIZE_MATRIZ; j++)
                {
                    TranspuestaResta[i, j] = matrizC[j, i];
                }
            }
        }
        public void imprimir_Transponer()
        {
            string salida = "";
            for (int i = 0; i < SIZE_MATRIZ; i++)
            {
                for (int j = 0; j < SIZE_MATRIZ; j++)
                {
                    salida += TranspuestaResta[i, j] + "\t";
                }
                salida += "\n";
            }
            System.Console.Write(salida);
        }
    }
}
