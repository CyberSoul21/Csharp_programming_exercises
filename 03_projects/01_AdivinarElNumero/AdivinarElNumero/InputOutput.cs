/**
 * @file InputOutput.cs 
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
    class InputOutput
    {
        public void imprimirMensaje(string mensaje)
        {
            Console.WriteLine("" + mensaje);
        }
        public int leerNumero()
        {
            int n = 0;
            string numero = "";
            numero = Console.ReadLine();
            n = Convert.ToInt32(numero);
            return n;
        }
        public void pulsarTecla()
        {
            Console.Read();
            imprimirMensaje("Pulse Enter");
        }
    }
}