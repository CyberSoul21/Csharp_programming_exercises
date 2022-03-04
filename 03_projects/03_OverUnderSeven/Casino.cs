/**
 * @file Casino.cs 
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
    class Casino
    {
        private InOut interfaz;
        private Jugador unJugador;
        private Crupier unCrupier;

        public Casino()
        {
            
            this.interfaz = new InOut();
            this.unJugador = new Jugador();
            this.unCrupier = new Crupier();
        }
        public void Jugar()
        {
            int valorApuesta = 0;
            

            interfaz.imprimirMensaje("Valor Apuesta");
            valorApuesta = interfaz.leerApuesta();

            unJugador.setApuesta(valorApuesta);
            interfaz.imprimirMensaje("" + unJugador.obtenerDadoDos());
            
            unJugador.lanzarDados();
            int sumaDadosJugador = unJugador.obtenerSumaDadosJugador();
            interfaz.imprimirMensaje("lanzamiento jugador " + unJugador.obtenerValorLanzamiento());

           
            unCrupier.lanzarDados();
            int sumaDadosCrupier = unCrupier.obtenerSumaDadosCrupier();
            interfaz.imprimirMensaje("lanzamiento Crupier " + unCrupier.obtenerValorLanzamiento());


            if (unCrupier.obtenerGanador(sumaDadosCrupier,sumaDadosJugador))
            {
                interfaz.imprimirMensaje("Ganado...");
                interfaz.imprimirMensaje("Valor apuesta " + unCrupier.pagarApuestas(unJugador.getApuesta()));
            }
            else
            {
                interfaz.imprimirMensaje("Perdio");
            }
            Console.ReadLine();
        }
        static void Main(string[] args)
        {
            Casino juegoDado = new Casino();
            juegoDado.Jugar();
        }
    }

}
