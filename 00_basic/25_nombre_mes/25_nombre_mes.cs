/**
 * @file 25_nombre_mes.cs 
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

namespace NombreDelMes
{
    class NombreDelMes
    {
        private int mes;
        private string numero;
        private string nombreMes;
        private Mes mm;

        public void leerNumeroMes()
        {
            mm = new Mes();
            Console.Write("Digite numero del mes ");
            numero = Console.ReadLine();
            mes = Convert.ToInt32(numero);
            nombreMes = mm.obtenerNombreMes(mes);
            Console.WriteLine("" + nombreMes);
            Console.ReadLine();
            
        }
        static void Main(string[] args)
        {
            NombreDelMes nm = new NombreDelMes();
            nm.leerNumeroMes();

        }
    }
    class Mes
    {
        public string obtenerNombreMes(int mes)
        {
            string respNombre = "Es el mes de ";
            if (mes == 1)
                respNombre += "Enero";
            else if (mes == 2)
                respNombre += "Febrero";
            else if (mes == 3)
                respNombre += "Marzo";
            else if (mes == 4)
                respNombre += "Abril";
            else if (mes == 5)
                respNombre += "Mayo";
            else if (mes == 6)
                respNombre += "Junio";
            else if (mes == 7)
                respNombre += "Julio";
            else if (mes == 8)
                respNombre += "Agosto";
            else if (mes == 9)
                respNombre += "Septiembre";
            else if (mes == 10)
                respNombre += "Octubre";
            else if (mes == 11)
                respNombre += "Noviembre";
            else if (mes == 12)
                respNombre +=         "Diciembre";
            else
                respNombre = "Numero de mes errado";
            return respNombre;
        }
    }
}

