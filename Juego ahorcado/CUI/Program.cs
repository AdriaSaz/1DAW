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
            string entrada;
            char letra;
            bool estado = false;
          
            string palabra;
            Dibujo.intro_Animado();
            do
            {
                Console.WriteLine("Introduce una palabra a ocultar");
                entrada = Console.ReadLine();
                estado = Juego.FiltrarPalabra(entrada);

               
            } while (!estado);
            palabra = entrada;
            //Ocultamos palabra para mostrarla ocuulta
            Juego.OcultarPalabra(palabra);
            //recogemos la letra
           
            Dibujo.dibujo_inicial();
           
            do
            {
              
                Console.WriteLine(Juego.intentos);
                Console.WriteLine("{0}", Juego.Oculto);
                Console.WriteLine("Introduce una letra");
                letra = Console.ReadLine()[0];
                Juego.fin = Juego.ComprobarLetra(letra,palabra);
               
                
            } while (!Juego.fin && Juego.intentos != 7);
                
           
         if(Juego.fin)
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
