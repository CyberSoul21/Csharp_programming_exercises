/**
 * @file 24_letras.cs 
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
        Console.Write("Digite letra a clasificar");
        letra = char.Parse(Console.ReadLine());
        Determinacion proceso = new Determinacion();
        det = proceso.obtenerClasificacion(letra, det);
        Console.WriteLine("la letra " + " es " + det);
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
           if (letra == A && E && F && H && I && K && L && M && N && T && V && W && X && Y && Z)
           
               det = "es recta";
           
           else if (letra == C && O && S && U && Q)
           
               det = "es curva";
           
           else
               det = "es curva y recta";
           return det;

           
       }
   }
}


   
       
        