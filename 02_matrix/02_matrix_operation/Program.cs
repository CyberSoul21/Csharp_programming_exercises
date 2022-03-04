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
    class MatrizTranspuesta
    {
        //Invoca las diferentes Clases
        private Suma_y_Transpuesta Strans;
        private Resta_Y_Transpuesta Rtrans;
        private Producto_y_Transpuesta Ptrans;

        public MatrizTranspuesta()
        {
            this.Strans = new Suma_y_Transpuesta();
            this.Rtrans = new Resta_Y_Transpuesta();
            this.Ptrans = new Producto_y_Transpuesta();
        }
        public void Hacer_Procesos()
        {
            // Inician Procesos llamando los metodos
            Strans.CrearMatrizA();
            Strans.CrearMatrizB();
            Strans.CrearMatrizC();
            Strans.transponer();
            Rtrans.CrearMatrizA();
            Rtrans.CrearMatrizB();
            Rtrans.CrearMatrizC();
            Rtrans.transponer();
            Ptrans.CrearMatrizA();
            Ptrans.CrearMatrizB();
            Ptrans.CrearMatrizC();
            Ptrans.transponer();

            //Impresion proceso Suma y transponer
            Console.WriteLine("OPERACION SUMA Y LA TRANSPUESTA");
            Console.WriteLine("Se crea matriz A :\n");
            Strans.imprimirMatrizA();
            Console.WriteLine("Se crea matriz B :\n");
            Strans.imprimirMatrizB();
            Console.WriteLine("Suma de matriz A y B :\n");
            Strans.imprimirMatrizC();
            Console.WriteLine("Transponer la Suma :\n");
            Strans.imprimir_Transponer();

            //Impresion proceso Resta y transponer
            Console.WriteLine("\nOPERACION RESTA Y LA TRANSPUESTA");
            Console.WriteLine("Se crea matriz A :\n");
            Strans.imprimirMatrizA();
            Console.WriteLine("Se crea matriz B :\n");
            Strans.imprimirMatrizB();
            Console.WriteLine("Suma de matriz A y B :\n");
            Strans.imprimirMatrizC();
            Console.WriteLine("Transponer la Resta :\n");
            Rtrans.imprimir_Transponer();

            //Impresion proceso Producto y transponer
            Console.WriteLine("\nOPERACION PRODUCTO Y LA TRANSPUESTA");
            Console.WriteLine("Se crea matriz A :\n");
            Strans.imprimirMatrizA();
            Console.WriteLine("Se crea matriz B :\n");
            Strans.imprimirMatrizB();
            Console.WriteLine("Suma de matriz A y B :\n");
            Strans.imprimirMatrizC();
            Console.WriteLine("Transponer el Producto :\n");
            Ptrans.imprimir_Transponer();
        }
        static void Main(string[] args)
        {
            MatrizTranspuesta add = new MatrizTranspuesta();
            add.Hacer_Procesos();
            Console.ReadLine();
        }
    }
}
