using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LogicaJuego;
using _3DGraphics;
using ReadFile;


namespace CUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //ReadFile.IOFiles.file.Close();
            Console.SetWindowSize(105, 50);
            string entrada;
            char letra;
            bool estado = false;
          
            string palabra;
            //Dibujo.intro_Animado();
            
            do
            {
                System.Console.Clear();
                Dibujo.intro_Animado();
                Dibujo.cabecera();
               Console.WriteLine("1)Maquina vs jugador\n2)jugadorvsjugador");
                 int option = int.Parse(Console.ReadLine());
               switch (option)
               {
                   case 1:
                       entrada =IOFiles.RandomWord();
                        estado = true;
                        break;
                   case 2:
                         Console.WriteLine("Introduce una palabra a ocultar");
                         entrada = Console.ReadLine();
                         estado = Juego.FiltrarPalabra(entrada);
                         IOFiles.AmpliaDiccionario(entrada);

                         break;
                   default:
                         Console.WriteLine("Error");
                         entrada = "";
                         estado = false;
                         break;
               }
                
                
               

               
            } while (!estado);
            Dibujo.cargando();
            palabra = entrada.ToUpper();
           
            //Ocultamos palabra para mostrarla ocuulta
            Juego.OcultarPalabra(palabra);
            //recogemos la letra
           Dibujo.dibujo_inicial();
           
           
            do
            {

                do
                {
                    System.Console.Clear();
                    Dibujo.cabecera();
                    estado = true;
                    if (!estado) Dibujo.dibujo_inicial(); else Dibujo.dibujar();

                    Dibujo.MarcoContador(Juego.intentos);
                    Console.WriteLine("ADIVINA");
                    //Console.WriteLine(palabra);
                    Console.WriteLine("\n-----------------------------------------");
                    Console.WriteLine("{0}", Juego.hword);
                    Console.WriteLine("-----------------------------------------");

                    Console.WriteLine("Introduce una letra");
                    entrada = Console.ReadLine().ToUpper();
                    estado = Juego.FiltrarPalabra(entrada);
                } while (!estado);

                letra = entrada[0];
                Juego.fin = Juego.ComprobarLetra(letra,palabra);
               
                
            } while (!Juego.fin && Juego.intentos != 7);
                
           
         if(Juego.fin)
         {
             Console.WriteLine("enhorabuena has acertado la palabra oculta '{0}'", palabra);
         }
         else
         {
             Dibujo.GameOver();
             Console.WriteLine("Lo siento no acertaste la palabra. la palabra era {0}, te quedaste en {1}", palabra, Juego.hword);
         }

         
            Console.ReadKey();
        }

       
    }
}
