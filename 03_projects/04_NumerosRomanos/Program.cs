/**
 * @file Program.cs 
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
using System.Text;

namespace NumerosRomanos
{
    class NumeroRomano
    {
        private int unidades;
        private int decenas;
        private int centenas;
        private int miles;
        private int resto;
        private int numero;

        public NumeroRomano()
        {
            this.unidades = 0;
            this.decenas = 0;
            this.centenas = 0;
            this.miles = 0;
            this.resto = 0;
            this.numero = 0;
        }
        public string obtenerNumeroRomano(int numero)
        {
            string elNumeroRomano = "";
            miles = numero / 1000;
            resto = numero % 1000;
            centenas = resto / 100;
            resto = resto % 100;
            decenas = resto / 10;
            resto = resto % 10;
            unidades = resto;

            elNumeroRomano = "" + obtenerMiles(miles) + obtenerCentenas(centenas) + obtenerDecenas(decenas) + obtenerUnidades(unidades);
            return elNumeroRomano;
        }

        public string obtenerUnidades(int unidades)
        {
            string unidad = "";
            switch (unidades)
            {
                case 1: unidad = ("I"); break;
                case 2: unidad = ("II"); break;
                case 3: unidad = ("III"); break;
                case 4: unidad = ("IV"); break;
                case 5: unidad = ("V"); break;
                case 6: unidad = ("VI"); break;
                case 7: unidad = ("VII"); break;
                case 8: unidad = ("VIII"); break;
                case 9: unidad = ("IX"); break;
            }
            return unidad;
        }
        public string obtenerDecenas(int decenas)
        {
            string decena = "";
            switch (decenas)
            {
                case 1: decena = ("X"); break;
                case 2: decena = ("XX"); break;
                case 3: decena = ("XXX"); break;
                case 4: decena = ("XL"); break;
                case 5: decena = ("L"); break;
                case 6: decena = ("LX"); break;
                case 7: decena = ("LXX"); break;
                case 8: decena = ("LXXX"); break;
                case 9: decena = ("XC"); break;
            }
            return decena;
        }
        public string obtenerCentenas(int centenas)
        {
            string cenatena = "";
            switch (centenas)
            {
                case 1: cenatena = ("C"); break;
                case 2: cenatena = ("CC"); break;
                case 3: cenatena = ("CCC"); break;
                case 4: cenatena = ("CD"); break;
                case 5: cenatena = ("D"); break;
                case 6: cenatena = ("DC"); break;
                case 7: cenatena = ("DCC"); break;
                case 8: cenatena = ("DCCC"); break;
                case 9: cenatena = ("CM"); break;
            }
            return cenatena;
        }
        public string obtenerMiles(int miles)
        {
            string mil = "";
            switch (miles)
            {
                case 1: mil = ("M"); break;
                case 2: mil = ("MM"); break;
                case 3: mil = ("MMM"); break;
            }
            return mil;
        }
    }
}
