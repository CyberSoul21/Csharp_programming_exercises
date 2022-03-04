/**
 * @file program.cs 
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

namespace JuegoChino
{
    class Casino
    {
        private InOut interfaz;
        private Clasifica lanzamiento;
        private Crupier unCrupier;
        private Jugador unJugador;
        

        public Casino()
        {

            this.interfaz = new InOut();
            this.lanzamiento = new Clasifica();
            this.unCrupier = new Crupier();
            this.unJugador = new Jugador();
            
        }
        public void Jugar()
        {
            ConsoleKeyInfo tecla;
            
            interfaz.imprimirMensaje("¡¡¡Bienvenido a Juego Dado!!!\n");
            interfaz.imprimirMensaje("El crupier hara el lanzamiento de los dados asi se determinara el juego\n");
            interfaz.imprimirMensaje("CIVIL                MILITAR\n6y6 Praiso           5y4\n1y1 Tierra           6y3 Nueve\n4y4 Hombre           5y3\n3y1 Armonia          6y2 OCHO\n5y5 Flor de cerezo   4y3\n3y3 Tres largo       5y2 SIETE\n2y2 Trono            4y2 SEIS\n6y5 Cabeza de tigre  3y2\n6y4 Diez Rojo        4y1 CINCO\n6y1 Siete larzo      2y1 TRES FINAL\n5y1 Seis Rojo      ");
        
            int valorApuesta = 0;
            interfaz.imprimirMensaje("\nValor Apuesta");
            valorApuesta = interfaz.leerApuesta();
            unJugador.setApuesta(valorApuesta);
           
       
            unCrupier.LanzarDados();
            int sumaDadosCrupier = unCrupier.obtenersumaDadosCrupier();
            interfaz.imprimirMensaje("\nlanzamiento Crupier " + unCrupier.ValorLanzamiento());
            int dadoUno=unCrupier.obtenerdadoUno();
            int dadoDos=unCrupier.obtenerdadoDos();
            
            
            
            if (lanzamiento.ComparacionInicial(dadoUno, dadoDos))
            {
                interfaz.imprimirMensaje("\nEl crupier gana las apuestas");

            }
            else if (lanzamiento.ComparacionInicial(dadoUno, dadoDos))
            {
                interfaz.imprimirMensaje("\nEl crupier pierde todas las apuestas");
                interfaz.imprimirMensaje("\nValor apuesta " + unCrupier.pagarApuestas(unJugador.getApuesta()));
            }
            else
            {
                string resp = "5";
                string resp2 = "3";
                do
                {
                    interfaz.imprimirMensaje("\nPresione enter para lanzar dados... ");
                    tecla = Console.ReadKey();
                    if (tecla.KeyChar == '\r')
                    {
                        unJugador.lanzarDados();
                        int sumaDados = unJugador.obtenerSumaDadosJugador();
                        interfaz.imprimirMensaje("\nlanzamiento jugador " + unJugador.obtenerValorLanzamiento());

                    }

                    if (unCrupier.obtenerdadoUno() == 6 && unCrupier.obtenerdadoDos() == 6)

                        resp = "CIVIL";



                    if (unCrupier.obtenerdadoUno() == 1 && unCrupier.obtenerdadoDos() == 1)

                        resp = "CIVIL";


                    if (unCrupier.obtenerdadoUno() == 4 && unCrupier.obtenerdadoDos() == 4)

                        resp = "CIVIL";


                    if (unCrupier.obtenerdadoUno() == 3 && unCrupier.obtenerdadoDos() == 1)

                        resp = "CIVIL";


                    if (unCrupier.obtenerdadoUno() == 5 && unCrupier.obtenerdadoDos() == 5)

                        resp = "CIVIL";


                    if (unCrupier.obtenerdadoUno() == 3 && unCrupier.obtenerdadoDos() == 3)

                        resp = "CIVIL";


                    if (unCrupier.obtenerdadoUno() == 2 && unCrupier.obtenerdadoDos() == 2)

                        resp = "CIVIL";


                    if (unCrupier.obtenerdadoUno() == 6 && unCrupier.obtenerdadoDos() == 5)

                        resp = "CIVIL";


                    if (unCrupier.obtenerdadoUno() == 6 && unCrupier.obtenerdadoDos() == 4)

                        resp = "CIVIL";


                    if (unCrupier.obtenerdadoUno() == 6 && unCrupier.obtenerdadoDos() == 1)

                        resp = "CIVIL";


                    if (unCrupier.obtenerdadoUno() == 5 && unCrupier.obtenerdadoDos() == 1)

                        resp = "CIVIL";


                    if (unCrupier.obtenerdadoUno() == 5 && unCrupier.obtenerdadoDos() == 4)

                        resp = "MILITAR";


                    if (unCrupier.obtenerdadoUno() == 6 && unCrupier.obtenerdadoDos() == 3)

                        resp = "MILITAR";


                    if (unCrupier.obtenerdadoUno() == 5 && unCrupier.obtenerdadoDos() == 3)

                        resp = "MILITAR";


                    if (unCrupier.obtenerdadoUno() == 6 && unCrupier.obtenerdadoDos() == 2)

                        resp = "MILITAR";


                    if (unCrupier.obtenerdadoUno() == 4 && unCrupier.obtenerdadoDos() == 3)

                        resp = "MILITAR";


                    if (unCrupier.obtenerdadoUno() == 5 && unCrupier.obtenerdadoDos() == 2)

                        resp = "MILITAR";


                    if (unCrupier.obtenerdadoUno() == 4 && unCrupier.obtenerdadoDos() == 2)

                        resp = "MILITAR";


                    if (unCrupier.obtenerdadoUno() == 3 && unCrupier.obtenerdadoDos() == 2)

                        resp = "MILITAR";


                    if (unCrupier.obtenerdadoUno() == 4 && unCrupier.obtenerdadoDos() == 1)

                        resp = "MILITAR";


                    if (unCrupier.obtenerdadoUno() == 2 && unCrupier.obtenerdadoDos() == 1)

                        resp = "MILITAR";


                    if (unCrupier.obtenerdadoUno() == 6 && unCrupier.obtenerdadoDos() == 6)

                        resp = "CIVIL";



                    if (unCrupier.obtenerdadoUno() == 1 && unCrupier.obtenerdadoDos() == 1)

                        resp = "CIVIL";


                    if (unCrupier.obtenerdadoUno() == 4 && unCrupier.obtenerdadoDos() == 4)

                        resp = "CIVIL";

                    if (unCrupier.obtenerdadoUno() == 3 && unCrupier.obtenerdadoDos() == 1)

                        resp = "CIVIL";


                    if (unCrupier.obtenerdadoUno() == 5 && unCrupier.obtenerdadoDos() == 5)

                        resp = "CIVIL";


                    if (unCrupier.obtenerdadoUno() == 3 && unCrupier.obtenerdadoDos() == 3)

                        resp = "CIVIL";


                    if (unCrupier.obtenerdadoUno() == 2 && unCrupier.obtenerdadoDos() == 2)

                        resp = "CIVIL";


                    if (unCrupier.obtenerdadoUno() == 6 && unCrupier.obtenerdadoDos() == 5)

                        resp = "CIVIL";


                    if (unCrupier.obtenerdadoUno() == 6 && unCrupier.obtenerdadoDos() == 4)

                        resp = "CIVIL";


                    if (unCrupier.obtenerdadoUno() == 6 && unCrupier.obtenerdadoDos() == 1)

                        resp = "CIVIL";


                    if (unCrupier.obtenerdadoUno() == 5 && unCrupier.obtenerdadoDos() == 1)

                        resp = "CIVIL";


                    if (unCrupier.obtenerdadoUno() == 5 && unCrupier.obtenerdadoDos() == 4)

                        resp = "MILITAR";


                    if (unCrupier.obtenerdadoUno() == 6 && unCrupier.obtenerdadoDos() == 3)

                        resp += "MILITAR";


                    if (unCrupier.obtenerdadoUno() == 5 && unCrupier.obtenerdadoDos() == 3)

                        resp = "MILITAR";


                    if (unCrupier.obtenerdadoUno() == 6 && unCrupier.obtenerdadoDos() == 2)

                        resp = "MILITAR";


                    if (unCrupier.obtenerdadoUno() == 4 && unCrupier.obtenerdadoDos() == 3)

                        resp = "MILITAR";


                    if (unCrupier.obtenerdadoUno() == 5 && unCrupier.obtenerdadoDos() == 2)

                        resp = "MILITAR";


                    if (unCrupier.obtenerdadoUno() == 4 && unCrupier.obtenerdadoDos() == 2)

                        resp = "MILITAR";


                    if (unCrupier.obtenerdadoUno() == 3 && unCrupier.obtenerdadoDos() == 2)

                        resp = "MILITAR";


                    if (unCrupier.obtenerdadoUno() == 4 && unCrupier.obtenerdadoDos() == 1)

                        resp = "MILITAR";


                    if (unCrupier.obtenerdadoUno() == 2 && unCrupier.obtenerdadoDos() == 1)

                        resp = "MILITAR";


                    if (unCrupier.obtenerdadoUno() == 1 && unCrupier.obtenerdadoDos() == 1)

                        resp = "CIVIL";


                    if (unCrupier.obtenerdadoUno() == 4 && unCrupier.obtenerdadoDos() == 4)

                        resp = "CIVIL";


                    if (unCrupier.obtenerdadoUno() == 1 && unCrupier.obtenerdadoDos() == 3)

                        resp = "CIVIL";



                    if (unCrupier.obtenerdadoUno() == 5 && unCrupier.obtenerdadoDos() == 6)

                        resp = "CIVIL";


                    if (unCrupier.obtenerdadoUno() == 4 && unCrupier.obtenerdadoDos() == 6)

                        resp = "CIVIL";


                    if (unCrupier.obtenerdadoUno() == 1 && unCrupier.obtenerdadoDos() == 6)

                        resp += "CIVIL";


                    if (unCrupier.obtenerdadoUno() == 1 && unCrupier.obtenerdadoDos() == 5)

                        resp += "CIVIL";


                    if (unCrupier.obtenerdadoUno() == 4 && unCrupier.obtenerdadoDos() == 5)

                        resp = "MILITAR";


                    if (unCrupier.obtenerdadoUno() == 3 && unCrupier.obtenerdadoDos() == 6)

                        resp = "MILITAR";


                    if (unCrupier.obtenerdadoUno() == 3 && unCrupier.obtenerdadoDos() == 5)

                        resp = "MILITAR";


                    if (unCrupier.obtenerdadoUno() == 2 && unCrupier.obtenerdadoDos() == 6)

                        resp = "MILITAR";


                    if (unCrupier.obtenerdadoUno() == 3 && unCrupier.obtenerdadoDos() == 4)

                        resp = "MILITAR";


                    if (unCrupier.obtenerdadoUno() == 2 && unCrupier.obtenerdadoDos() == 5)

                        resp = "MILITAR";


                    if (unCrupier.obtenerdadoUno() == 2 && unCrupier.obtenerdadoDos() == 4)

                        resp = "MILITAR";


                    if (unCrupier.obtenerdadoUno() == 2 && unCrupier.obtenerdadoDos() == 3)

                        resp = "MILITAR";


                    else if (unCrupier.obtenerdadoUno() == 1 && unCrupier.obtenerdadoDos() == 4)

                        resp += "MILITAR";


                    if (unCrupier.obtenerdadoUno() == 1 && unCrupier.obtenerdadoDos() == 2)

                        resp = "MILITAR";

                    if (unJugador.obtenerdadoUno() == 6 && unJugador.obtenerdadoDos() == 6)

                        resp2 = "CIVIL";

                    if (unJugador.obtenerdadoUno() == 1 && unJugador.obtenerdadoDos() == 1)

                        resp2 = "CIVIL";

                    if (unJugador.obtenerdadoUno() == 4 && unJugador.obtenerdadoDos() == 4)

                        resp2 = "CIVIL";

                    if (unJugador.obtenerdadoUno() == 3 && unJugador.obtenerdadoDos() == 1)

                        resp2 = "CIVIL";

                    if (unCrupier.obtenerdadoUno() == 5 && unJugador.obtenerdadoDos() == 5)

                        resp2 = "CIVIL";

                    if (unJugador.obtenerdadoUno() == 3 && unJugador.obtenerdadoDos() == 3)

                        resp2 = "CIVIL";

                    if (unJugador.obtenerdadoUno() == 2 && unJugador.obtenerdadoDos() == 2)

                        resp2 = "CIVIL";

                    if (unJugador.obtenerdadoUno() == 6 && unJugador.obtenerdadoDos() == 5)

                        resp2 = "CIVIL";

                    if (unJugador.obtenerdadoUno() == 6 && unJugador.obtenerdadoDos() == 4)

                        resp2 = "CIVIL";

                    if (unJugador.obtenerdadoUno() == 6 && unJugador.obtenerdadoDos() == 1)

                        resp2 = "CIVIL";

                    if (unJugador.obtenerdadoUno() == 5 && unJugador.obtenerdadoDos() == 1)

                        resp2 = "CIVIL";

                    if (unJugador.obtenerdadoUno() == 5 && unJugador.obtenerdadoDos() == 4)

                        resp2 = "MILITAR";

                    if (unJugador.obtenerdadoUno() == 6 && unJugador.obtenerdadoDos() == 3)

                        resp2 = "MILITAR";

                    if (unJugador.obtenerdadoUno() == 5 && unJugador.obtenerdadoDos() == 3)

                        resp2 = "MILITAR";

                    if (unJugador.obtenerdadoUno() == 6 && unJugador.obtenerdadoDos() == 2)

                        resp2 = "MILITAR";

                    if (unJugador.obtenerdadoUno() == 4 && unJugador.obtenerdadoDos() == 3)

                        resp2 = "MILITAR";

                    if (unJugador.obtenerdadoUno() == 5 && unJugador.obtenerdadoDos() == 2)

                        resp2 = "MILITAR";

                    if (unJugador.obtenerdadoUno() == 4 && unJugador.obtenerdadoDos() == 2)

                        resp2 += "MILITAR";

                    if (unJugador.obtenerdadoUno() == 3 && unJugador.obtenerdadoDos() == 2)

                        resp2 = "MILITAR";

                    if (unJugador.obtenerdadoUno() == 4 && unJugador.obtenerdadoDos() == 1)

                        resp2 = "MILITAR";

                    if (unJugador.obtenerdadoUno() == 2 && unJugador.obtenerdadoDos() == 1)

                        resp2 += "MILITAR";

                    if (unJugador.obtenerdadoUno() == 1 && unJugador.obtenerdadoDos() == 3)

                        resp2 = "CIVIL";

                    if (unJugador.obtenerdadoUno() == 5 && unJugador.obtenerdadoDos() == 6)

                        resp2 = "CIVIL";

                    if (unJugador.obtenerdadoUno() == 4 && unJugador.obtenerdadoDos() == 6)

                        resp2 = "CIVIL";

                    if (unJugador.obtenerdadoUno() == 1 && unJugador.obtenerdadoDos() == 6)

                        resp2 = "CIVIL";

                    if (unJugador.obtenerdadoUno() == 1 && unJugador.obtenerdadoDos() == 5)

                        resp2 = "CIVIL";

                    if (unJugador.obtenerdadoUno() == 4 && unJugador.obtenerdadoDos() == 5)

                        resp2 = "MILITAR";

                    if (unJugador.obtenerdadoUno() == 3 && unJugador.obtenerdadoDos() == 6)

                        resp2 = "MILITAR";

                    if (unJugador.obtenerdadoUno() == 3 && unJugador.obtenerdadoDos() == 5)

                        resp2 += "MILITAR";

                    if (unJugador.obtenerdadoUno() == 2 && unJugador.obtenerdadoDos() == 6)

                        resp2 = "MILITAR";

                    if (unJugador.obtenerdadoUno() == 3 && unJugador.obtenerdadoDos() == 4)

                        resp2 = "MILITAR";

                    if (unJugador.obtenerdadoUno() == 2 && unJugador.obtenerdadoDos() == 5)

                        resp2 += "MILITAR";

                    if (unJugador.obtenerdadoUno() == 2 && unJugador.obtenerdadoDos() == 4)

                        resp2 = "MILITAR";

                    if (unJugador.obtenerdadoUno() == 2 && unJugador.obtenerdadoDos() == 3)

                        resp2 = "MILITAR";

                    if (unJugador.obtenerdadoUno() == 1 && unJugador.obtenerdadoDos() == 4)

                        resp2 += "MILITAR";

                    else if (unJugador.obtenerdadoUno() == 1 && unJugador.obtenerdadoDos() == 2)

                        resp2 = "MILITAR";
                } while (resp != resp2);
                if (unCrupier.obtenersumaDadosCrupier() < unJugador.obtenerSumaDadosJugador())
                {
                    interfaz.imprimirMensaje("\n¡¡Felicitaciones gano la apuesta!!  :)");
                    interfaz.imprimirMensaje("\nValor apuesta: " + unCrupier.pagarApuestas(unJugador.getApuesta()));
                }
                else if (unCrupier.obtenersumaDadosCrupier() > unJugador.obtenerSumaDadosJugador())
                {
                    interfaz.imprimirMensaje("\nPerdio  :(");
                }
                else
                { interfaz.imprimirMensaje("\nEmpatan cada uno retira sus apuestas  ;)"); }
            }
          }
         
        static void Main(string[] args)
        {
            Casino add = new Casino();
            add.Jugar();
            Console.ReadLine();
        }
    }
}
