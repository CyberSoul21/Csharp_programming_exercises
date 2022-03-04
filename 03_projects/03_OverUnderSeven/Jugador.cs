/**
 * @file Jugador.cs 
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
    class Jugador
    {
     
        private int dadoUno;
        private int dadoDos;
        private int sumaDados;
        private string resultadoDados;
        private int apuesta;

        public Jugador()
        {
            this.dadoUno = 0;
            this.dadoDos = 0;
            this.sumaDados = 0;
            this.resultadoDados = "";
        }
        public void lanzarDados()
        {
            Random aleatorio = new Random();
           
            this.dadoUno= 1 + aleatorio.Next(1, 7);
            this.dadoDos = 1 + aleatorio.Next(1, 7);

            this.sumaDados = dadoUno + dadoDos;
            this.resultadoDados = "" + dadoUno + "+" + dadoDos + "=" + sumaDados;
        }
        public int obtenerDadoUno()
        {
            return dadoUno;
        }
        public int obtenerDadoDos()
        {
            return dadoDos;
        }
        public int obtenerSumaDadosJugador()
        {
            return sumaDados;
        }
        public void setApuesta(int apuesta)
        {
            this.apuesta = apuesta;
        }
        public int getApuesta()
        {
            return apuesta;
        }
        public string obtenerValorLanzamiento()
        {
            return resultadoDados;
        }
    }
}
