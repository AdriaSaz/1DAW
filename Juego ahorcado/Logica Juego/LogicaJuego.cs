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
        public static int largo; 
        public static string Oculto; //Contiene la palabra codificada
        
        public static int intentos = 0;


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
            int cont=0;
            for(int i = 0; i < largo; i++)
            {
                if(palabra.Substring(i,1)[0] == letra)
                {
                    RemplazoLetra(letra, i);
                    //Oculto.Substring(i,1).Replace('*',letra);
                    cont++;
                }
            }
            if(cont>0)
            {
                Dibujo.dibujar();
                return true;
            }
            else
            {
               
                Dibujo.fallo(intentos++);
                return false;
            }

           
        }

        private static void RemplazoLetra(char letra, int i)
        {
            StringBuilder sbOculto = new StringBuilder(Oculto);
            sbOculto[i] = letra;
            Oculto = sbOculto.ToString();
        }

        
        
        public static bool ComprobarPalabraFin(string palabra)
        {
            return palabra.Equals(Oculto) ? true : false;
               
        }
    }
}
