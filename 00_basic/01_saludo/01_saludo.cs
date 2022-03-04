/**
 * @file saludo.cs 
 * @brief 
 *
 *
 * @author Wilson Javier Almario Rodriguez
 * @date march - 2010
 * @update: 3/03/2022
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            //se crea un objeto hola de la clase HolaMundo
            HolaMundo hola = new HolaMundo();
            //objeto hola llama al metodo saludar.
            hola.saludar();
        }
    }

    class HolaMundo
    {
        public void saludar()
        {
            //imprime en pantalla el mensaje 
            Console.Write("hola Mundo...¡Como estas!");
            Console.Read(); // Hace una pausa
        }
    }               
} 
