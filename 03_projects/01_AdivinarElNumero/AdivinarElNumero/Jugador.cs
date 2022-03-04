/**
 * @file Jugador.cs 
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
    class Jugador
    {
        private Numero miNumero;
        public Jugador()
        {
            this.miNumero = new Numero();
        }
        public string evaluarIntento(int numeroUsuario)
        {
            int numeroSistema = this.miNumero.obtenerNumero();
            int resta = numeroSistema - numeroUsuario;
            string resultado = "";
            if (resta < 0)
            {
                resultado = "ALTO";
            }
            else if (resta > 0)
            {
                resultado = "BAJO";
            }
            else if (resta == 0)
            {
                resultado = "IGUAL";
            }
            return resultado;

        }
    }
}