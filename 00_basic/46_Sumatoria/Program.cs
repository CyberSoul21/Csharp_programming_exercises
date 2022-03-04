/**
 * @file program.cs 
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

namespace Sumatoria
{
    class LecturaNumero
    {
        private int n;
        private string numero;
        private int respuesta;
        private SumaNumeros proceso;

        public LecturaNumero()
        {
            this.n = 0;
            this.numero = "";
            this.respuesta =0;
            this.proceso = new SumaNumeros();
        }
        public void leerNumeros()
        {
            System.Console.WriteLine("Digite el valor de nmueros naturales a sumar:");
            numero = System.Console.ReadLine();
            n = Convert.ToInt32(numero);
            respuesta = proceso.obtenerSuma(n);
            Console.WriteLine("\n Sumatoria de los " + n + "primeros numeros naturales es " + respuesta);
            Console.ReadLine();
        }
        static void Main(string[] args)
        {
            LecturaNumero datos = new LecturaNumero();
            datos.leerNumeros();
        }
        
    }
}
