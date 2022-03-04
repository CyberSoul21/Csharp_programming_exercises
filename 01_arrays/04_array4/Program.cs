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

namespace Ejercicio2
{
    class ArrayProceso
    {
        private NumeroMayor Mayor;
        
      

        public ArrayProceso()
        {
            this.Mayor = new NumeroMayor();
        }
        public void GenerarProcesos()
        {

            Mayor.InicializarVector();
            Mayor.ImprimirVector();
            Mayor.IniciarProceso();
        }


        static void Main(string[] args)
        {
            ArrayProceso add = new ArrayProceso();
            add.GenerarProcesos();
            Console.ReadLine();
        }
    }
}

    
