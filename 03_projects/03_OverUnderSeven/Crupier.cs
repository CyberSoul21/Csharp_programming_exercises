/**
 * @file Crupier.cs 
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
    class Crupier
    {
       
        private int dadoUno;
        private int dadoDos;
        private int sumaDados;
        private string resultadoDados;
 

        public Crupier()
        {
            this.dadoUno = 0;
            this.dadoDos = 0;
            this.sumaDados = 0;
            this.resultadoDados = "";
            
            lanzarDados();
        }
        public void lanzarDados()
        {
            Random aleatorio1 = new Random();
           
            dadoUno = 1 + aleatorio1.Next(1, 6);
      
            dadoDos = 1 + aleatorio1.Next(1, 6);
            sumaDados = dadoUno + dadoDos;
            resultadoDados = "" + dadoUno + "+" + dadoDos + "=" + sumaDados;
        }
        public int obtenerDadoUno()
        {
            return dadoUno;
        }
        public int obtenerDadoDos()
        {
            return dadoDos;
        }
        public int obtenerSumaDadosCrupier()
        {
            return sumaDados;

        }


        public int pagarApuestas(int valorApuesta)
        {
            return valorApuesta * 2;
        }


        public string obtenerValorLanzamiento()
        {
            return resultadoDados;
        }
        public bool obtenerGanador(int dadosCrupier, int dadosJugador)
        {
           int valorLanzamientoJugador = 0;
           valorLanzamientoJugador = dadosJugador;
           int valorLanzamientoCrupier = dadosCrupier;
           bool resp = false;
   
          if(valorLanzamientoCrupier < 7 && valorLanzamientoJugador < 7)
          {
             resp = true;
          }
          else if(valorLanzamientoCrupier > 7 && valorLanzamientoJugador > 7)
          {
             resp = true;
          }
          else if (valorLanzamientoCrupier == 7 && valorLanzamientoJugador == 7)
          {
             resp = true;
          }
          return resp;
        }
    }
}
