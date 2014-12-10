using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Dibujo creado con una array bidimensional con caracteres ascii
namespace _3DGraphics
{
    public class Dibujo
    {
        static public int[,] dibujo = new int[19,14];//plantilla dibujo 
        public static void cargando()//barra de carga
        {

            int car = 20;
            int i = 0;
            Console.Write("cargando");
            for (i = 0; i <= car; i++)
            {
                Console.Write("{0}", (char)35);
                System.Threading.Thread.Sleep(50);

            }
            Console.WriteLine();
        }   

       //Creador de poster
        static public void dibujo_inicial()
        {
            int i, j;
            for( i=0; i<19; i++)
            {    
                      
              for ( j=0;j<14;j++)
              {
                dibujo[i,j]=32;
              }      
            }   
                  //Palo horizontal
          
            for(j=0;j<=7;j++)
                dibujo[3,j]=35;
             //Palo VERTICAL
            for (i=4;i<=18;i++)
                dibujo[i,0]=35;
            dibujar();
        }


        //metodo universal que dibuja 
        public static void dibujar()
        {
            int i, j;

            //System.Console.Clear(); 
            for (i = 0; i < 19; i++)
            {
                j = 0;
                for (j = 0; j < 14; j++)
                    if (j < 13)
                       Console.Write("{0}", (char)dibujo[i,j]);
                    else
                       Console.WriteLine("{0}", (char)dibujo[i,j]);
            }
            Console.WriteLine("===================================================================");
        }


        //MOdificador de dibujos segun el fallo ( caracter no acertado en la palabra) 
        static public void fallo(int x)
        {
             int i,j;
  
             switch(x)
             {
              
             case 0:
                   //cabeza
                   for (i=6;i<=8;i++)
                   {    
                      for (j=6;j<=8;j++)
                      {
                          dibujo[i,j]=35;                    
                      }      
                   }
                   break; 
             case 1:
                   //cuerpo
           
                   for (i=9;i<=12;i++)
                   {    
                       dibujo[i,7]=35;
                   }
                   break;
          
             case 2:     
                   //brazo izquierdo
          
                   dibujo[10,6]=35;
                   dibujo[11,5]=35;
                   dibujo[12,4]=35;
                   break;
             case 3:
                   //brazo derecho
                   dibujo[10,8]=35;
                   dibujo[11,9]=35;
                   dibujo[12,10]=35;
                   break;
             case 4:         
     
                   //pierna izquierda
                   dibujo[13,6]=35;
                   dibujo[14,5]=35;
                   dibujo[15,4]=35;
                   break;
             case 5:           
                   //pierna derecha
                   dibujo[13,8]=35;
                   dibujo[14,9]=35;
                   dibujo[15,10]=35;
                   break;
             case 6:
                  //cuerda
           
                   for (j=4;j<=5;j++)
                     dibujo[j,7]=35;
                   break; 
  
             }
            
        }


        static public void intro_Animado()
        {
    
             System.Console.Clear(); 
             Console.Write("########################################################################################################\n");
             System.Threading.Thread.Sleep(250);
             Console.Write("##                                                                                                    ##\n");
             System.Threading.Thread.Sleep(250);
             Console.Write("##  Juego                                                                                             ##\n");
             System.Threading.Thread.Sleep(250);
             Console.Write("##  Autor:Adria saz                                                                                   ##\n");
             System.Threading.Thread.Sleep(250);
             Console.Write("##  Ver.: 3.0                                                                                         ##\n");
             System.Threading.Thread.Sleep(250);
             Console.Write("##                                                                                                    ##\n");
             System.Threading.Thread.Sleep(250);
             Console.Write("########################################################################################################\n");
             System.Threading.Thread.Sleep(250);
             Console.WriteLine();  
            
      }
        static public void intro()
        {

                 System.Console.Clear(); 
                 Console.Write("###############################################################################\n");
                 Console.Write("##                                                                           ##\n");
                 Console.Write("##  Juego                                                                    ##\n");
                 Console.Write("##  Autor:Adria saz                                                          ##\n");
	             Console.Write("##  Ver.: 3.0                                                                ##\n");
	             Console.Write("##                                                                           ##\n");
	             Console.Write("###############################################################################\n");
                 Console.Write("\n");
        }

        static public void cabecera()
        {
         Console.ForegroundColor = ConsoleColor.Green;
         Console.WriteLine(" ▄▄▄▄▄▄▄▄▄▄▄  ▄         ▄  ▄▄▄▄▄▄▄▄▄▄▄  ▄▄▄▄▄▄▄▄▄▄▄  ▄▄▄▄▄▄▄▄▄▄▄  ▄▄▄▄▄▄▄▄▄▄▄  ▄▄▄▄▄▄▄▄▄▄   ▄▄▄▄▄▄▄▄▄▄▄ ");
         Console.WriteLine("▐░░░░░░░░░░░▌▐░▌       ▐░▌▐░░░░░░░░░░░▌▐░░░░░░░░░░░▌▐░░░░░░░░░░░▌▐░░░░░░░░░░░▌▐░░░░░░░░░░▌ ▐░░░░░░░░░░░▌");
         Console.WriteLine("▐░█▀▀▀▀▀▀▀█░▌▐░▌       ▐░▌▐░█▀▀▀▀▀▀▀█░▌▐░█▀▀▀▀▀▀▀█░▌▐░█▀▀▀▀▀▀▀▀▀ ▐░█▀▀▀▀▀▀▀█░▌▐░█▀▀▀▀▀▀▀█░▌▐░█▀▀▀▀▀▀▀█░▌");
         Console.WriteLine("▐░▌       ▐░▌▐░▌       ▐░▌▐░▌       ▐░▌▐░▌       ▐░▌▐░▌          ▐░▌       ▐░▌▐░▌       ▐░▌▐░▌       ▐░▌");
         Console.WriteLine("▐░█▄▄▄▄▄▄▄█░▌▐░█▄▄▄▄▄▄▄█░▌▐░▌       ▐░▌▐░█▄▄▄▄▄▄▄█░▌▐░▌          ▐░█▄▄▄▄▄▄▄█░▌▐░▌       ▐░▌▐░▌       ▐░▌");
         Console.WriteLine("▐░░░░░░░░░░░▌▐░░░░░░░░░░░▌▐░▌       ▐░▌▐░░░░░░░░░░░▌▐░▌          ▐░░░░░░░░░░░▌▐░▌       ▐░▌▐░▌       ▐░▌");
         Console.WriteLine("▐░█▀▀▀▀▀▀▀█░▌▐░█▀▀▀▀▀▀▀█░▌▐░▌       ▐░▌▐░█▀▀▀▀█░█▀▀ ▐░▌          ▐░█▀▀▀▀▀▀▀█░▌▐░▌       ▐░▌▐░▌       ▐░▌");
         Console.WriteLine("▐░▌       ▐░▌▐░▌       ▐░▌▐░▌       ▐░▌▐░▌     ▐░▌  ▐░▌          ▐░▌       ▐░▌▐░▌       ▐░▌▐░▌       ▐░▌");
         Console.WriteLine("▐░▌       ▐░▌▐░▌       ▐░▌▐░█▄▄▄▄▄▄▄█░▌▐░▌      ▐░▌ ▐░█▄▄▄▄▄▄▄▄▄ ▐░▌       ▐░▌▐░█▄▄▄▄▄▄▄█░▌▐░█▄▄▄▄▄▄▄█░▌");
         Console.WriteLine("▐░▌       ▐░▌▐░▌       ▐░▌▐░░░░░░░░░░░▌▐░▌       ▐░▌▐░░░░░░░░░░░▌▐░▌       ▐░▌▐░░░░░░░░░░▌ ▐░░░░░░░░░░░▌");
         Console.WriteLine(" ▀         ▀  ▀         ▀  ▀▀▀▀▀▀▀▀▀▀▀  ▀         ▀  ▀▀▀▀▀▀▀▀▀▀▀  ▀         ▀  ▀▀▀▀▀▀▀▀▀▀   ▀▀▀▀▀▀▀▀▀▀▀ ");
         Console.ResetColor();
         Console.WriteLine("\n\n\n");

        }


        static public void GameOver()
        {

            System.Console.Clear(); 
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n\n\n");
                                                     
         Console.WriteLine("  ▄████  ▄▄▄       ███▄ ▄███▓▓█████     ▒█████   ██▒   █▓▓█████  ██▀███  ");
         Console.WriteLine(" ██▒ ▀█▒▒████▄    ▓██▒▀█▀ ██▒▓█   ▀    ▒██▒  ██▒▓██░   █▒▓█   ▀ ▓██ ▒ ██▒");
         Console.WriteLine("▒██░▄▄▄░▒██  ▀█▄  ▓██    ▓██░▒███      ▒██░  ██▒ ▓██  █▒░▒███   ▓██ ░▄█ ▒");
         Console.WriteLine("░▓█  ██▓░██▄▄▄▄██ ▒██    ▒██ ▒▓█  ▄    ▒██   ██░  ▒██ █░░▒▓█  ▄ ▒██▀▀█▄  ");
         Console.WriteLine("░▒▓███▀▒ ▓█   ▓██▒▒██▒   ░██▒░▒████▒   ░ ████▓▒░   ▒▀█░  ░▒████▒░██▓ ▒██▒");
         Console.WriteLine(" ░▒   ▒  ▒▒   ▓▒█░░ ▒░   ░  ░░░ ▒░ ░   ░ ▒░▒░▒░    ░ ▐░  ░░ ▒░ ░░ ▒▓ ░▒▓░");
         Console.WriteLine("  ░   ░   ▒   ▒▒ ░░  ░      ░ ░ ░  ░     ░ ▒ ▒░    ░ ░░   ░ ░  ░  ░▒ ░ ▒░");
         Console.WriteLine("░ ░   ░   ░   ▒   ░      ░      ░      ░ ░ ░ ▒       ░░     ░     ░░   ░ ");
         Console.WriteLine("      ░       ░  ░       ░      ░  ░       ░ ░        ░     ░  ░   ░     ");
         Console.WriteLine("                                                     ░                   ");
         Console.ResetColor();
         Console.WriteLine("\n\n\n");

        }

        static public void MarcoContador(int intento){

       
                    Console.WriteLine("█▀▀▀▀█");
                    Console.Write("█");
                    if (intento >= 5) Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(" {0}  ",intento);
                    Console.ResetColor();
                    Console.WriteLine("█");
                    Console.WriteLine("█▄▄▄▄█");
        }
    }
}
