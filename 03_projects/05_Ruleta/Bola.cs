/**
 * @file Bola.cs 
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

namespace Ruleta
{
    class Bola
    {
        private int numeroBola;

        public Bola()
        {
            Random aleatorio = new Random();
            const int VALOR_MAXIMO = 36;
            this.numeroBola = aleatorio.Next(VALOR_MAXIMO);
        }
        public int obtenerValorbola()
        {
            return numeroBola;
        }
    }
}
