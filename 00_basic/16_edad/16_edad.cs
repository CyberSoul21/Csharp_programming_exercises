/**
 * @file 16_edad.cs 
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

namespace ConsoleApplication1
{
    class Edad
    {
        private int edad;
        private string valor;
        private string nombre;
        private string respuesta;
        private EstadoEdad estado;
        
        public void leerEdad()
        {
            estado = new EstadoEdad();
            Console.WriteLine("Digite su Nombre:");
            nombre = Console.ReadLine();
            Console.WriteLine("Digite la edad");
            valor = Console.ReadLine();
            edad = Convert.ToInt32(valor);
            respuesta = estado.esMayorEdad(edad);
            Console.WriteLine(nombre + " " + respuesta);
            Console.ReadLine();
        }

        static void Main(string[] args)
        {
            Edad ed = new Edad();
            ed.leerEdad();
        }
        class EstadoEdad
        {
            public string esMayorEdad(int edad)
            {
                string resp="";
                if(edad >= 18)
                    resp="Eres Mayor de Edad";
                else
                    resp= "Eres menor de edad";
                return resp;
            }
        }     

    }
}
