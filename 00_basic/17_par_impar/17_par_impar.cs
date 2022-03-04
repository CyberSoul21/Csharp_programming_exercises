/**
 * @file 17_par_impar.cs 
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

namespace NumeroPar
{
    class Principal
    {
        private int numero;
        private string n;
        private ParImpar tipoNumero;

        public void leerNumero()
        {
            tipoNumero = new ParImpar
            Console.Write("Digite un numero");
            n = Console.ReadLine();
            numero = Convert.ToInt32(n);
            if(tipoNumero.esPar(numero))
                Console.WriteLine("" + numero + " Es un numero par");
            else
                Console.WriteLine("" + numero + " Es un numero inpar");
            Console.ReadLine();
        }
        static void Main(string[] args)
        {
            Principal ppal = new Principal();
            ppal.leerNumero();

        }
    }
    class ParImpar
    {
        public bool esPar(int num)
        {
            bool resp = false;
            if (num % 2 == 0)
                resp = true;
            return resp;
        }
    }
}
