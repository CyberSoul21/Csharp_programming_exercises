/**
 * @file 07_valor_producto.cs 
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

namespace IVAdeUnProducto
{
    class IVA
    {
        private double v;
        private double vf;

        public void leerNumero()
        {
            Console.WriteLine("Digite el precio del producto:");
            v = double.Parse(Console.ReadLine());
            Calculo procedimiento = new Calculo();
            vf = procedimiento.obtenerprecio(v);
            Console.WriteLine("El precio final es:" + vf);
            Console.ReadLine();
        }
        static void Main(string[] args)
        {
            IVA pres = new IVA();
            pres.leerNumero();
        }
    }

    class Calculo
    {
        public double obtenerprecio(double v)
        {
            double pf = v + v * 0.16;
            return pf;
        }
    }
}
