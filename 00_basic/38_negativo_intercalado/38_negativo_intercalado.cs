/**
 * @file 38_negativo_intercalado.cs 
 * @brief 
 *
 *
 * @author Wilson Javier Almario Rodriguez
 * @date march - 2010
 * @update: 3/03/2022
 *
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace _1.Numero
{
    class Program
    {
        private  int numero;
        private  string mult;
        private int respuesta;

        private  Entero proceso;

        public  Program()
        {
            this.numero = 0;
            this.mult = "";
            this.respuesta = 0;
            this.proceso = new Entero();
        }
        public void leerNumeros()
        {
            System.Console.WriteLine(" Digite el numero = ");
            mult = System.Console.ReadLine();
            numero = Convert.ToInt32(mult);

            respuesta = proceso.obtenerEntero(numero);

            Console.WriteLine(" "  + respuesta);
            Console.Read();
        }
        static void Main (string[] args)
        {
            Program datos = new Program();
            datos.leerNumeros();
        }

    }
    class Entero
    {
       public int obtenerEntero(int numero)
       {
         int suma = 0;
         int contador = 1;
         int x = 0;
         do{

            if (contador % 2 == 0)
            {

                x = contador * -1;
            }
            else
            {
                x = contador;
            }
                suma = suma + x;
                contador++;
                Console.WriteLine(" "+contador+" "+ x +" "+suma);
        } while (contador <= numero);
        return suma;
      }

        
    }
}
