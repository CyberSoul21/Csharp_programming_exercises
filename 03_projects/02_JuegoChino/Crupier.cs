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

namespace JuegoChino
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
        }
         public void LanzarDados()
         {
             Random aleatorio = new Random();

             this.dadoUno = 1 + aleatorio.Next(1, 6);
             this.dadoDos = 1 + aleatorio.Next(1, 6);
             this.sumaDados = dadoUno + dadoDos; 
             this.resultadoDados = "" + dadoUno + "+" + dadoDos + "=" + sumaDados;
         }
         public int obtenerdadoUno()
         {
             return dadoUno;
         }
         public int obtenerdadoDos()
         {
             return dadoDos;
         }
         public int obtenersumaDadosCrupier()
         {
             return sumaDados;
         }
         public string ValorLanzamiento()
         {
             return resultadoDados;
         }
         public int pagarApuestas(int valorApuesta)
         {
             return valorApuesta * 2;
         }
       


        

    }
}
