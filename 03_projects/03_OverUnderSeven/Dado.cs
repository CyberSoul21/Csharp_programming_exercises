/**
 * @file Dado.cs 
 * @brief 
 *
 *
 * @author Wilson Javier Almario Rodriguez
 * @date November - 2010
 * @update: 3/03/2022
 *
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OverAndUnderSeven
{
    class Dado
    {
        private int numero;
        private Random aleatorio;

        public Dado()
        {
            const int VALOR_MAXIMO = 6;
            this.aleatorio = new Random();
            this.numero = aleatorio.Next(1, VALOR_MAXIMO);
            Console.WriteLine("numero aleatorio  "+numero);
        }
        public int obtenerResultado()
        {
            return numero;
        }


    }
}
