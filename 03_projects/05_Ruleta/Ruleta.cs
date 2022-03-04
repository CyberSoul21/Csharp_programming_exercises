/**
 * @file Ruleta.cs 
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
    class Ruleta
    {
        private int numeroRuleta;
        private Bola unaBola;
        private int[] ruleta;

        public Ruleta()
        {
            this.unaBola = new Bola();
            this.ruleta = new int[] { 0, 32, 15, 19, 4, 21, 5, 25, 17, 34, 6, 27, 13, 36, 11, 30, 8, 23, 10, 5, 24, 16, 33, 1, 20, 14, 31, 9, 22, 18, 29, 7, 28, 12, 35, 3 };
            this.numeroRuleta = unaBola.obtenerValorbola();
        }
        public int obtenerNumeroRuleta()
        {
            return ruleta[numeroRuleta];
        }


    }
}
