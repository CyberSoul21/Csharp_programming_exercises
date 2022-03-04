using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace potenciaCuadradoyCubo
{
    class potencia 
    {
        int contador;
        int cuadrado;
        int cubo;
        
       
        public void numerosNaturales(int n)
        {

            contador = 1;

            
            while(contador <= n) 
            {
                cuadrado = contador * contador;
                cubo = contador * contador * contador;
                Console.WriteLine( + contador + " " + cuadrado + " " + cubo + "\n");
                contador++;
                
            }
           

        }

    }
}

