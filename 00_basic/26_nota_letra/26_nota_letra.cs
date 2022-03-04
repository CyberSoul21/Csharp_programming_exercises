/**
 * @file 26_nota_letra.cs 
 * @brief 
 *
 *
 * @author Wilson Javier Almario Rodriguez
 * @date march - 2010
 * @update: 3/03/2022
 *
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NotaLetra
{
    class LetraNota
    {
        class NotaLetra
        {
            private int x;
            private char nota;
            private NotaLetra letra;
            private string n;

            public NotaLetra()
            {
               
                this.letra = new Nota();
            }
            public void leerNumero()
            {
                Console.Write("Primer Valor ");
                n = Console.ReadLine();
                x = Convert.ToInt32(n);

                nota = letra.obtenerNota(x);
                Console.WriteLine("Numero Mayor " + nota);
                Console.ReadLine();
            }
            static void Main(string[] args)
            {
                NotaLetra nm = new NotaLetra();
                nm.leerNumero();
            }
        }
        class Nota
        {
            public char obtenerNota(int nota)
            {
                char valor;
                if (nota >= 90)
                {
                    valor = 'E';
                }
                else if( nota >= 80)
                {
                    valor = 's';
                }
                else if (nota >= 700)
                {
                   valor = 'A';
                }
                else if (nota >= 60)
                {
                valor = 'I';
                }
                else 
                {
                valor = 'D';
                }
            }
        }
            
    }
}



