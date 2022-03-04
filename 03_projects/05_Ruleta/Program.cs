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
using System.Linq;
using System.Text;

namespace Ruleta
{
    class Casino
    {

        private Ruleta unaRuleta;
        private InOut interfaz;
        private Crupier unCrupier;
        private Bola unaBola;
        private int apuesta;
        public Casino()
        {
            this.unaBola = new Bola();
            this.unaRuleta = new Ruleta();
            this.interfaz = new InOut();
            this.apuesta = 0;
            this.unCrupier = new Crupier();
        }
        public void Jugar()
        {
            int seguir = 0;
            string[] rangoApuesta = { "1.Elegir Numero", "2.Valor entre 0-18", "3.Valor entre 19 y 35", "4.Numero par", "5.Numero impar", "6.primera Docena[0-11]", "7.Segunda Docena[12-23]", "8.Tercera Docena[24-35]", "Seleccione tipo apuesta" };
            int opcionApuesta = 0;
            do
            {
                if (seguir == 1)
                {
                    this.unaBola = new Bola();
                    this.unaRuleta = new Ruleta();
                    this.interfaz = new InOut();
                    this.apuesta = 0;
                    this.unCrupier = new Crupier();
                   
                }
                interfaz.imprimirMensaje("Digite valor apuesta");
                apuesta = interfaz.leerDato();
                interfaz.imprimirMenu(rangoApuesta);
                opcionApuesta = interfaz.leerDato();
                evaluarRangoApuesta(opcionApuesta);
                interfaz.imprimirMensaje("Desea volver a jugar\n1.Seguir\n2.Salir");
                seguir = interfaz.leerDato();

            } while (seguir == 1);
        }
        public void evaluarRangoApuesta(int opcion)
        {
            int numeroJugador = 0;
            int numroRuleta = unaRuleta.obtenerNumeroRuleta();
            int posicionBolita = unaBola.obtenerValorbola();
            string resultado = "";
            if (opcion == 1)
            {
                interfaz.imprimirMensaje("Digite numero entre 0 y 35");
                numeroJugador = interfaz.leerDato();
                if (unCrupier.obtenerGanador(numeroJugador, numroRuleta))
                {
                    resultado = "¡Felicitaciones Gano!";
                }
                else
                {
                    resultado = "Perdio hasta una nueva oportunidad";
                }
            }
            else if (opcion == 2)
            {
                if (unCrupier.obtenerRango_0_18(numroRuleta))
                {
                    resultado = "¡Felicitaciones Gano!";
                }
                else
                {
                    resultado = "Perdio hasta una nueva oportunidad";
                }
            }
            else if (opcion == 3)
            {
                if (unCrupier.obtenerRango_19_35(numroRuleta))
                {
                    resultado = "¡Felicitaciones Gano!";
                }
                else
                {
                    resultado = "Perdio hasta una nueva oportunidad";
                }
            }
            else if (opcion == 4)
            {
                if (unCrupier.esPar(numroRuleta))
                {
                    resultado = "¡Felicitaciones Gano!";
                }
                else
                {
                    resultado = "Perdio hasta una nueva oportunidad";
                }
            }
            else if (opcion == 5)
            {
                if (unCrupier.esImpar(numroRuleta))
                {
                    resultado = "¡Felicitaciones Gano!";
                }
                else
                {
                    resultado = "Perdio hasta una nueva oportunidad";
                }
            }
            else if (opcion == 6)
            {
                if (unCrupier.esPrimeraDocena(numroRuleta))
                {
                    resultado = "¡Felicitaciones Gano!";
                }
                else
                {
                    resultado = "Perdio hasta una nueva oportunidad";
                }
            }
            else if (opcion == 7)
            {
                if (unCrupier.esSegundaDocena(numroRuleta))
                {
                    resultado = "¡Felicitaciones Gano!";
                }
                else
                {
                    resultado = "Perdio hasta una nueva oportunidad";
                }
            }
            else if (opcion == 8)
            {
                if (unCrupier.esTercerDocena(numroRuleta))
                {
                    resultado = "¡Felicitaciones Gano!";
                }
                else
                {
                    resultado = "Perdio hasta una nueva oportunidad";
                }
            }
            resultado += "\nEl numero de la posicion de la Bolita " + posicionBolita;
            resultado += "\nEl numero de la Ruleta " + numroRuleta;
            interfaz.imprimirMensaje(resultado);
        }






        static void Main(string[] args)
        {
            Casino unCasino = new Casino();
            unCasino.Jugar();
        }
    }
}
