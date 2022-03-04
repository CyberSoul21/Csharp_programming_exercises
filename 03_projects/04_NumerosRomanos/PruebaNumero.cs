/**
 * @file PruebaNumero.cs 
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
using System.Text;

namespace NumerosRomanos
{
    class PruebaNumero
    {
        private NumeroRomano unNumeroRomano;
        private InOut input;

        public PruebaNumero()
        {
            this.input = new InOut();
            this.unNumeroRomano = new NumeroRomano();
        }

        public void leerNumero()
        {
            string numeroRomano = "";
            int numero = -2;
            while (numero < 0 || numero > 3999)
            {
                input.imprimirMensaje("Ingrese un numero mayor a 0 y menor 4000:");
                numero = int.Parse(Console.ReadLine());
            }

            numeroRomano = unNumeroRomano.obtenerNumeroRomano(numero);
            input.imprimirMensaje("En Numeros Romanos es :" + numeroRomano);
            input.imprimirMensaje("Pulse enter para seguir ");
            input.stop();
        }

        static void Main(string[] args)
        {
            PruebaNumero pn = new PruebaNumero();
            pn.leerNumero();

        }
    }
}
