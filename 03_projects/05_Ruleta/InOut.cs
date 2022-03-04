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

namespace Ruleta
{
    class InOut
    {
        public void imprimirMensaje(string mensaje)
        {
            Console.WriteLine(mensaje);
        }

        public void imprimirMenu(string[] mensaje)
        {
            for (int i = 0; i < mensaje.Length; i++)
            {
                Console.WriteLine(mensaje[i]);
            }
        }

        public void iniciarJuego()
        {
            Console.ReadLine();
        }
        public int leerDato()
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
