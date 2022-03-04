/**
 * @file program.cs 
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

namespace AdivinarNumero
{
    class AdivinaElNumero
    {
        private InputOutput interfaz;
        private Jugador unJugador;

        public AdivinaElNumero()
        {
            this.interfaz = new InputOutput();
            this.unJugador = new Jugador();
        }
        public void jugar()
        {
            interfaz.imprimirMensaje("tengo un numero en memoria entre 1 y 100");
            int intento = 0;
            int numeroJugador = 0;
            string comparacion = "";
            while (!comparacion.Equals("IGUAL"))
            {
                interfaz.imprimirMensaje("¡cual cree que es ...?");
                numeroJugador = interfaz.leerNumero();
                comparacion = Jugador.evaluarIntento(numeroJugador);
                interfaz.imprimirMensaje("su intento fue " + comparacion);
                intento++;
            }
            interfaz.imprimirMensaje("Felicitaciones, adivino el numero depues de " + intento + " Intento");
            interfaz.pulsarTecla();
        }
        static void Main(string[] args)
        {
            AdivinaElNumero control = new AdivinaElNumero();
            control.jugar();

        }
    }
}