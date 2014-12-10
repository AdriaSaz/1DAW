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
        public static FileStream file = new FileStream(@".\dictonary.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
        public static StreamWriter writer = new StreamWriter(file);
        public static StreamReader Lectura = new StreamReader(file);

       
        static public string RandomWord()

        {
            Console.ReadKey();

            int counter = 0;
             string linea;
            
            
            while ((Lectura.ReadLine()) != null) counter++;
            int num = alea.Next(1, counter-1);
            counter = 0;
            
            Lectura.BaseStream.Seek(0, System.IO.SeekOrigin.Begin);
            while ((linea = Lectura.ReadLine()) != null)
            {

                if(num == counter++)
                {
                   Lectura.Close();
                    break;
                 }
            }
           
           
            return linea;
           
        }

        static public void AmpliaDiccionario(string NewWord)
        {
            Console.WriteLine(NewWord);
           writer.BaseStream.Seek(0, System.IO.SeekOrigin.End);
            writer.WriteLine(NewWord.ToUpper());
            writer.Close();
        }

       
    }
}
