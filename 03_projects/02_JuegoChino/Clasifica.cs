/**
 * @file Clasifica.cs 
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

namespace JuegoChino
{
    class Clasifica
    {
        private Crupier unCrupier;
        private Jugador unJugador;
        private InOut interfaz;

        public Clasifica()
        {
            this.unCrupier = new Crupier();
            this.unJugador = new Jugador();
            this.interfaz = new InOut();
        }



        public bool ComparacionInicial(int dadoUno, int dadoDos)
        {
            int dado1 = dadoUno;
            int dado2 = dadoDos;
            bool resp = false;

            if (dado1 == 6 && dado2 == 6)
            {
                resp = true;
            }
            if (dado1 == 5 && dado2 == 4)
            {
                resp = true;
            }
            if (dado1 == 4 && dado2 == 5)
            {
                resp = true;

            }
            return resp;
        }
        public bool ComparacionInicial2(int dadoUno, int dadoDos)
        {
            int dado1 = dadoUno;
            int dado2 = dadoDos;
            bool resp = false;

            if (dado1 == 5 && dado2 == 1)
            {
                resp = true;
            }
            if (dado1 == 1 && dado2 == 5)
            {
                resp = true;
            }
            if (dado1 == 2 && dado2 == 1)
            {
                resp = true;

            }
            if (dado1 == 1 && dado2 == 2)
            {
                resp = true;

            }
            return resp;
        }
    }
  }

