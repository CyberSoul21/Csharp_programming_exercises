/**
 * @file Numero.cs 
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
using System.Text;

namespace AdivinarNumero
{
    class Numero
    {
        private int numero;
        private Random aleatorio;
        public Numero()
        {
            this.numero = 0;
            const int VALOR_MAXIMO = 100;
            aleatorio = new Random();
            this.numero = aleatorio.Next(VALOR_MAXIMO);
        }
        public int obtenerNumero()
        {
            return numero;
        }
    }
}
