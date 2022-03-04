/**
 * @file 23_compara_cero.cs 
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

namespace ComparaCero
{
    class Numero
    {
        private int numero;
        private string nro;
        private ComparacionCero compara;

        public Numero()
        {
            this.numero = 0;
            this.nro = "";
            this.compara = new ComparacionCero();
        }
        public void leerNumero()
        {
            Console.Write("Digite un numero: ");
            nro = Console.ReadLine();
            numero = Int32.Parse(nro);
            Console.WriteLine("" + numero + "" + compara.obtenerComparacion(numero));
            Console.ReadLine();
        }
        static void Main(string[] args)
        {
            Numero numero = new Numero();
            numero.leerNumero();

        }
    }
    class ComparacionCero
    {
        public string obtenerComparacion(int numero)
        {
            string respuesta = "";
            if (numero > 0)
            {
                respuesta = " Es un numero mayor que cero";
            }
            if (numero < 0)
                respuesta = " Es un numero menor que cero";
            if (numero == 0)
            {
                respuesta = "Numero es igual a cero";
            }
            return respuesta;
        }
    }

}
