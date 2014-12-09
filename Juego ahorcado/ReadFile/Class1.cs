using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadFile
{
    public class IOFiles

    {
        static Random alea = new Random();
        static System.IO.StreamReader file = new System.IO.StreamReader(@"dictonary");
        static public string CountLines(string FileName)

        {


            int counter = 0;
            
            while ((file.ReadLine()) != null)
            {

                counter++;
            }
            string linea;
            int num = alea.Next(0, counter);
            counter = 0;
            while ((linea = file.ReadLine()) != null)
            {

                if(num == counter++)
                {
                    file.Close();
                   
                    
                }
            }
            return linea;
           
        }
    }
}
