/**
 * @file 15_descuento.cs 
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

namespace DescuentoIF
{
    class Program
    {
        private static double compra;
        private static double descuento;
        private static double iva;
        private static double subTotal;
        private static double totalPagar;
        private static string valor;

        static void Main(string[] args)
        {
            descuento = 0;
            Console.Write("Valor de la compra");
            valor = Console.ReadLine();
            compra = Convert.ToDouble(valor);
            if (compra >= 50000)
                descuento = calcularDescuento(compra);
            subTotal = compra - descuento;
            iva = obtenerIva(subTotal);
            totalPagar = calcularTotal(subTotal, iva);

            Console.WriteLine("\nCompra $" + compra);
            Console.WriteLine("Descuento $" + descuento);
            Console.WriteLine("Sub Total $" + subTotal);
            Console.WriteLine("iva $" + iva);
            Console.WriteLine("Total a Pagar $" + totalPagar);
            Console.ReadLine();
        }
        public static double calcularDescuento(double compra)
        {
            return compra * 0.05;
        }
        public static double obtenerIva(double subTotal)
        {
            return (subTotal * 0.16);
        }
        public static double calcularTotal(double subTotal, double iva)
        {
            return subTotal + iva;
        }
    }
}

