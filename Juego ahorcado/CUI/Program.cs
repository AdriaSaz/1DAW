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

        //RAFAPUIG: Mira donde tienes el proyecto ReadFile porque esta fuera del repositorio y no carga
        static void Main(string[] args)
        {
            //ReadFile.IOFiles.file.Close();
            Console.SetWindowSize(105, 50);
            string entrada;
            char resp;
            char letra;
            bool PalabraOK = false; //estado si ha pasado control calidad la palabra introducida
            int option;
            string palabra;
            //Dibujo.intro_Animado();

            do
            {
                do
                {
                   
                    do
                    {
                        System.Console.Clear();
                        Dibujo.intro_Animado();
                        Dibujo.cabecera();
                        Console.WriteLine("1)Maquina vs jugador\n2)jugador vs jugador");
                        PalabraOK = int.TryParse(Console.ReadLine(), out option);
                    } while (!PalabraOK);
                    PalabraOK = false;
                    switch (option)
                    {
                        case 1:
                            entrada = IOFiles.RandomWord();
                            PalabraOK = true;
                            break;
                        case 2:
                            Console.WriteLine("Introduce una palabra a ocultar");
                            entrada = Console.ReadLine();
                            PalabraOK = Juego.FiltrarPalabra(entrada);
                            IOFiles.AmpliaDiccionario(entrada);

                            break;
                        default:
                            Console.WriteLine("Error");
                            entrada = "";
                            PalabraOK = false;
                            break;
                    }

                } while (!PalabraOK);
                Dibujo.cargando();
                palabra = entrada.ToUpper(); //cogemos ya la palabra en mayusculas

                //Ocultamos palabra para mostrarla ocuulta
                Juego.OcultarPalabra(palabra);
                //recogemos la letra
                Dibujo.dibujo_inicial();


                do//do while principal
                {
                    //este do while se encarga de repetir proceso mientras no me de una entrada correcta
                    do
                    {
                        System.Console.Clear();
                        Dibujo.cabecera(); //dibujamos
                        PalabraOK = true;
                        if (!PalabraOK) Dibujo.dibujo_inicial(); else Dibujo.dibujar(); //condicion para que dibujo hacer( primera tirada o no)

                        Dibujo.MarcoContador(Juego.intentos);
                        Console.WriteLine("ADIVINA");
                        //Console.WriteLine(palabra);
                        Console.WriteLine("\n-----------------------------------------");
                        Console.WriteLine("{0}", Juego.hword);
                        Console.WriteLine("-----------------------------------------");

                        Console.Write("Introduce una letra\n->");
                        entrada = Console.ReadLine().ToUpper();
                        PalabraOK = Juego.FiltrarPalabra(entrada);
                    } while (!PalabraOK);

                    letra = entrada[0];
                    Juego.fin = Juego.ComprobarLetra(letra, palabra);


                } while (!Juego.fin && Juego.intentos != 7);


                if (Juego.fin)
                {
                    Console.WriteLine("enhorabuena has acertado la palabra oculta '{0}'", palabra);
                }
                else
                {
                    Dibujo.GameOver();
                    Console.WriteLine("Lo siento no acertaste la palabra. la palabra era {0}, te quedaste en {1}", palabra, Juego.hword);
                }
                Console.WriteLine("Pulse un boton para continuar...");
                Console.ReadKey();
                System.Console.Clear();
                Console.Write("Quieres jugar otra partida)\n>(S)i\n>(N)o\n->");
                entrada = Console.ReadLine().ToUpper();
                resp = entrada[0];
            } while (resp != 'N');
            Console.WriteLine("Hasta otraaaaa!!");
            Console.WriteLine("Pulse un boton para continuar...");
            Console.ReadKey();
            IOFiles.CerrarArchivo();
           
            //IOFiles.file.Close();
        }

       
    }
}
