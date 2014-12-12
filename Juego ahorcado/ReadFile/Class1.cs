using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ReadFile
{
    public class IOFiles

    {
       /// string path =".\\dictonary.txt";
        static Random alea = new Random();
        //OBJETO ARCHIVO con permisos escritura/lectura
        public static FileStream file = new FileStream(@".\dictionary", FileMode.OpenOrCreate, FileAccess.ReadWrite); //Archivo en CUI/bin/debug 
        public static StreamWriter writer = new StreamWriter(file); //Objeto de lectura
        public static StreamReader Lectura = new StreamReader(file); //Objeto de escritura

       
        static public string RandomWord()

        {
            Console.ReadKey();

            int counter = 0;//cantidad lineas
             string linea;//contendra la palabra sacada del archivo
            
            
            while ((Lectura.ReadLine()) != null) counter++; //contamos las lineas del archivo
            int num = alea.Next(1, counter-1); //numero aleatorio para seleccionar palabra aleatoria
            counter = 0;
            
            Lectura.BaseStream.Seek(0, System.IO.SeekOrigin.Begin);//nos volvemos a situar al principio de archivo y vamos linea por linea
            while ((linea = Lectura.ReadLine()) != null)
            {
                //cuando coincida el numero de linea con el aleatorio extraemos palabra y paramos
                if(num == counter++)
                {
                  
                    break;
                 }
            }
           
           
            return linea; ///devolvemos la palabra
           
        }

        static public void AmpliaDiccionario(string NewWord)
        {
           // Console.WriteLine(NewWord);
           writer.BaseStream.Seek(0, System.IO.SeekOrigin.End); //situamos el puntero al final del archivo
            writer.WriteLine(NewWord.ToUpper()); //añadimos la palabra
           
        }

        static public void CerrarArchivo()
        {
            writer.Close(); //cerramos escritura
            Lectura.Close(); //cerramos la lectura
            file.Close();
        }

       
    }
}
