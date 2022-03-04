/**
 * @file Crupier.cs 
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
using System.Linq;
using System.Text;

namespace Ruleta
{
    class Crupier
    {
        public bool obtenerRango_0_18(int numeroRuleta)
        {
            if (numeroRuleta >= 0 && numeroRuleta <= 18)
            {
                return true;
            }
            else { return false; }
        }
        public bool obtenerRango_19_35(int numeroRuleta)
        {
            if (numeroRuleta >= 19 && numeroRuleta <= 35)
            {
                return true;
            }
            else { return false; }
        }
        public bool esPar(int numeroRuleta)
        {
            if (numeroRuleta % 2 == 0)
            {
                return true;
            }
            else { return false; }
        }
        public bool esImpar(int numeroRuleta)
        {
            if (numeroRuleta % 2 != 0)
            {
                return true;
            }
            else { return false; }
        }
        public bool esPrimeraDocena(int numeroRuleta)
        {
            if (numeroRuleta >= 0 && numeroRuleta <= 11)
            {
                return true;
            }
            else { return false; }
        }
        public bool esSegundaDocena(int numeroRuleta)
        {
            if (numeroRuleta >= 12 && numeroRuleta <= 23)
            {
                return true;
            }
            else { return false; }
        }
        public bool esTercerDocena(int numeroRuleta)
        {
            if (numeroRuleta >= 24 && numeroRuleta <= 35)
            {
                return true;
            }
            else { return false; }
        }
        public bool obtenerGanador(int numeroJugador, int numeroRuleta)
        {
            if (numeroJugador == numeroRuleta)
            {
                return true;
            }
            else { return false; }
        }
    }

        
        
    
    
}
