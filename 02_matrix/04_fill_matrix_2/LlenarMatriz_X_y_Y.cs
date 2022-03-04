using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EjercicioMatriz4
{
    class LlenarMatriz_X_y_Y
    { 
        private string[,] matriz;
        private int numCol;
        private int numFil;

        public LlenarMatriz_X_y_Y()
        {
            Console.WriteLine("Digite Numero de columnas:");
            numCol = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite Numero de Filas: ");
            numFil = int.Parse(Console.ReadLine());
            this.matriz = new string[numFil, numCol];
        }
        public void inicializarMatriz()
        {
            string a = "X";
            string b = "Y";
            for (int i = 0; i < numFil; i++)
            {
                for (int j = 0; j < numCol; j++)
                {
                    matriz[i, j] = " ";
                    if (matriz[i, j] == " ")
                    {
                        matriz[i, i] = a;
                        
                    }
                }
            }
            int jo = numCol - 1;
            for (int i = 0; i < numFil; i++)
            {
                matriz[i, jo] = " ";
                if (matriz[i, jo] == " ")
                {
                    matriz[i, jo] = b;
                    jo--;
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