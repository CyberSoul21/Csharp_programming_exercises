/**
 * @file 11_volumen_esfera.cs 
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

namespace Calcular_volumen_de_una_esfera 
{
    class Ejercicio
    {
        private double r;
        private double v;
         
  

        public void leerNumero()
        {
            //sentencia para imprimir mensaje
            Console.WriteLine("Digite el radio de la esfera:");
            //sentencia para leer un numero
            r = double.Parse(Console.ReadLine()); 
            //se cra un objeto proceso de la clase Calculo
            Calculo proceso = new Calculo();
            //se accesa al metodo obtenerProducto
            v = proceso.obtenerProducto(r, 0.75); 
            Console.WriteLine("El volumen de la esfera es:" + v);
            Console.ReadLine();//Pausa para ver el resultado
        }
        static void Main()
        {
            //se crea un objeto add de la clase Producto
            Ejercicio add = new Ejercicio();
            add.leerNumero();
        }
    }
    class Calculo
    {
          public double obtenerProducto(double x, double y)
          {
             double Z= (0.75)*Math.Pow(x,3)*Math.PI;     
             return Z;
    
          } 
     } 

 
}  

      