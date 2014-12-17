using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _3DGraphics;
using ReadFile;

namespace LogicaJuego
{
    
    public static class Juego
    {
        public static int largo; // longitud de la palabra
        public static string hword; //Contiene la palabra codificada
        public static bool fin = false; // Cuando fin es true el juego ha terminado por que la palabra se ha acertado
        public static int intentos = 0; // num de fallos/intentos


       // Convierte la palabra introoducida en un string de *
        public static void OcultarPalabra(string palabra)
        {
            largo = palabra.Length;
            
            for (int i = 0; i < largo; i++)
            {
                hword = hword + "*";
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
                    RemplazoLetra(letra, i);//llamo al metodo 
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
            StringBuilder sbOculto = new StringBuilder(hword);
            sbOculto[i] = letra;//cambio de letra
            hword = sbOculto.ToString();// actualizo variable con palabra oculta
        }

        
        

        //Comprobador si la palabra ha sido acertada
        public static bool ComprobarPalabraFin(string palabra)
        {
            if (palabra.Equals(hword))
            {
                hword = "";
              //  Array.Clear(Dibujo.dibujo, null, null);
                intentos = 0;
                return true;
            }else{
                return false;
            }
        }

        public static bool FiltrarPalabra(string palabra)
        {
             int num;
            if (string.IsNullOrEmpty(palabra))//controla  que la cadena introducida no es vacia
            {
               
               // Dibujo.intro();
                MensajeError("Error!! no se permite palabras vacias\n Pulse una tecla para continuar...");
                return false;
            }
            else
               
                if (int.TryParse(palabra, out num))///comrueba que no se introduzcan numeros como palabra para adivinar
                {
                   
                    MensajeError("Error!! no se permite cadenas de numeros\n Pulse una tecla para continuar...");
                   
                    return false;
                }
            return true; //es un string y no esta vacio
        }

        
     public static void  MensajeError(string mensaje)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(mensaje);
        Console.ResetColor();
        Console.ReadKey();


    }
  
    }

}
