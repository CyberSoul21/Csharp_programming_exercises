/**
 * @file program.cs 
 * @brief 
 *
 *
 * @author Wilson Javier Almario Rodriguez
 * @date September - 2010
 * @update: 3/03/2022
 *
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio1
{
    class ArrayUnidimensional
    {
        private EjercicioVector proceso;
        private int n;
        public ArrayUnidimensional()
        {
            this.proceso = new EjercicioVector();
        }
        public void generarproceso()
        {
            proceso.inicializarVector();
            proceso.ImprimirVector();
            Console.WriteLine("Digite numero a buscar de 0 a 25");
            n = int.Parse(Console.ReadLine());
            if (proceso.buscarNumero(n))
            {
                Console.WriteLine("El Numero si esta " );
            }
            else
            {
                Console.WriteLine("El Numero NO esta ");
                
            }

        }
        static void Main(string[] args)
        {
            ArrayUnidimensional add = new ArrayUnidimensional();
            add.generarproceso();
            Console.Read();
        }
    }
   
}
  


