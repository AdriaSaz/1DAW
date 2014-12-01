using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _3DGraphics;

namespace LogicaJuego
{
    
    public static class Juego
    {
        public static int largo; // longitud de la palabra
        public static string Oculto; //Contiene la palabra codificada
        public static bool fin = false; // Cuando fin es true el juego ha terminado por que la palabra se ha acertado
        public static int intentos = 0; // num de fallos/intentos


       // Convierte la palabra introoducida en un string de *
        public static void OcultarPalabra(string palabra)
        {
            largo = palabra.Length;
            
            for (int i = 0; i < largo; i++)
            {
                Oculto = Oculto + "*";
            }

        }
        
        // Comprobamos letra y remplazamos caracteres
        public static bool ComprobarLetra(char letra, string palabra)
        {
            int cont=0;// contador de caracteres acertados en la string
            for(int i = 0; i < largo; i++)//recorremos la string caracter a caracter
            {
                if(palabra.Substring(i,1)[0] == letra)
                {
                    RemplazoLetra(letra, i);
                    cont++;
                }
            }
            if(cont>0)
            {   //si el contador es mayor a 0 dibujamos el dibujo sin modificar
               
                return fin = Juego.ComprobarPalabraFin(palabra);
            }
            else
            {
               //de lo contrario modificamos dibujo 
                Dibujo.fallo(intentos++);
                return false;
            }

           
        }

       //metodo que remplaza el caracter acertado solo si se acierta uno o mas caracteres
        private static void RemplazoLetra(char letra, int i)
        {
            StringBuilder sbOculto = new StringBuilder(Oculto);
            sbOculto[i] = letra;
            Oculto = sbOculto.ToString();
        }

        
        

        //Comprobador si la palabra ha sido acertada
        public static bool ComprobarPalabraFin(string palabra)
        {
            return palabra.Equals(Oculto) ? true : false;
               
        }

        public static bool FiltrarPalabra(string palabra)
        {
             int num;
            if (string.IsNullOrEmpty(palabra))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error!! no se permite palabras vacias\n Pulse una tecla para continuar...");
                Console.ResetColor();
                Console.ReadKey();
               // Dibujo.intro();
                return false;
            }
            else
               
                if (int.TryParse(palabra, out num))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Error!! no se permite cadenas de numeros\n Pulse una tecla para continuar...");
                    Console.ResetColor();
                    Console.ReadKey();
                    //Dibujo.intro();
                    return false;
                }
            return true; //es un string y no esta vacio
        }

       
    }
}
