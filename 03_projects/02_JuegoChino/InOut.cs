/**
 * @file InOut.cs 
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
    class InOut
    {
        public void imprimirMensaje(string mensaje)
        {
            Console.WriteLine(mensaje);
        }

        public void iniciarJuego()
        {
            Console.ReadLine();
        }
        public int leerApuesta()
        {
            int numero = 0;
            numero = int.Parse(Console.ReadLine());
            return numero;
        }
        public void stop()
        {
            Console.ReadKey();
        }


    }
}
