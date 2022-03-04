/**
 * @file 10_conversion_hora_a_segundos.cs 
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
using System.Linq;
using System.Text;

namespace conversion_a_segundos
{
    class Ejercicio 
    {
        private int a;
        private int b;
        private int c;
        private int conversion;

        public void leerNumero()
        {
            //sentencia para imprimir el mensaje
            Console.WriteLine("Bienvenido al conversor de hora a segundos");
            Console.WriteLine("NOTA: digite la hora, luego los minutos y por ultimo los segundos\n");
            Console.WriteLine("Digite la hora:");
            //sentencia para leer un numero 
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite minutos:");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite segundos:");
            c = int.Parse(Console.ReadLine());
            //se crea un objeto proceso de la clase Calculo
            Calculo proceso = new Calculo();
            //se accesa al metodo obtenerSuma
            conversion = proceso.obtenerSuma(a, b, c);
            Console.WriteLine("En segundos es: " + conversion);
            Console.ReadLine();//Pausa para ver el resultado
        }
        static void Main()
        {
            //se crea un objeto add de la clase Suma
            Ejercicio add = new Ejercicio();
            add.leerNumero();
        }

    }

    
    class Calculo
    {
        public int obtenerSuma(int a, int b, int c)
        {
            int z = a*3600 + b*60 + c;
            return z; 



        }
    }



}  

 

  


 
   


 


