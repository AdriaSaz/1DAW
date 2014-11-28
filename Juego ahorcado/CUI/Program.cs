using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LogicaJuego;
using _3DGraphics;



namespace CUI
{
    class Program
    {
        static void Main(string[] args)
        {
            char letra;
            bool acierto,fin = false;
          
            string palabra;

            Console.WriteLine("Introduce una palabra a ocultar");
            palabra = Console.ReadLine();
            //Ocultamos palabra para mostrarla ocuulta
            Juego.OcultarPalabra(palabra);
            //recogemos la letra
            Dibujo.cargando();
            Dibujo.dibujo_inicial();
           
            do
            {
              
                Console.WriteLine(Juego.intentos);
                Console.WriteLine("{0}", Juego.Oculto);
                Console.WriteLine("Introduce una letra");
                letra = Console.ReadLine()[0];
                acierto = Juego.ComprobarLetra(letra,palabra);
                if(acierto)
                {
                    fin = Juego.ComprobarPalabraFin(palabra);
                }
                
            } while (!fin && Juego.intentos != 7);
                
           
         if(acierto)
         {
             Console.WriteLine("enhorabuena has acertado la palabra oculta '{0}'", palabra);
         }
         else
         {
             Console.WriteLine("Lo siento no acertaste la palabra. la palabra era {0}, te quedaste en {1}", palabra, Juego.Oculto);
         }

            Console.WriteLine(letra);
            Console.ReadKey();
        }
    }
}
