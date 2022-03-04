/**
 * @file 22_letra.cs 
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

namespace Letra
{
    
    class programa
    {
      private char letra;
      
      private string det;

      public void leerLetra()
      {
        Console.Write("Digite letra a clasificar: ");
        letra = char.Parse(Console.ReadLine());
        Determinacion proceso = new Determinacion();
        det = proceso.obtenerClasificacion(letra, det);
        Console.WriteLine("la letra " + letra + " es " + det);
        Console.ReadLine();
     }
     static void Main(string[] args)
     {
      programa lt = new programa();
      lt.leerLetra();
     }
   }
   class Determinacion
   {
       public string obtenerClasificacion(char letra, string det)
       {
           string respuesta = "" ;
           if (letra == 'A')
               det = "es recta";
           else if (letra == 'E')
               det = "es recta";
           else  if (letra == 'F')
               det = "es recta";
           else if (letra == 'H')
               det = "es recta";
           else if (letra == 'I')
               det = "es recta";
           else if (letra == 'K')
               det = "es recta";
           else if (letra == 'L')
               det = "es recta";
           else if (letra == 'M')
               det = "es recta";
           else if (letra == 'N')
               det = "es recta";
           else if (letra == 'T')
               det = "es recta";
           else if (letra == 'V')
               det = "es recta";
           else if (letra == 'W')
               det = "es recta";
           else if (letra == 'X')
               det = "es recta";
           else if (letra == 'Y')
               det = "es recta";
           else if (letra == 'Z')
               det = "es recta";
           
           else if (letra == 'C')
           
               det = "es curva";
           else if (letra == 'J')

               det = "es curva";
           else if (letra == 'S')

               det = "es curva";
           else if (letra == 'Q')

               det = "es curva";
           else if (letra == 'U')

               det = "es curva";
           else if (letra == 'G')

               det = "es curva";
         
           else
               det = "es curva y recta";
           return det;

           
       }
   }
}


   
       
        