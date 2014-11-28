using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _3DGraphics
{
    public class Dibujo
    {
        static public int[,] dibujo = new int[19, 14];
        public static void cargando()
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

        /// <summary>
        ///  ahorca
        /// </summary>
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


        //metodo que dibuja 
        public static void dibujar()
        {
            int i, j;

            System.Console.Clear(); 
            for (i = 0; i < 19; i++)
            {
                j = 0;
                for (j = 0; j < 14; j++)
                    if (j < 13)
                       Console.Write("{0}", (char)dibujo[i,j]);
                    else
                       Console.WriteLine("{0}", (char)dibujo[i,j]);
            }
        }


        static public void fallo(int x)
        {
             int i,j;
  
             switch(x)
             {
              
             case 1:
                   //CAP
                   for (i=6;i<=8;i++)
                   {    
             
                      for (j=6;j<=8;j++)
                      {
                          dibujo[i,j]=35;                    
                      }      
                   }
                   break; 
             case 2:
                   //COS
           
                   for (i=9;i<=12;i++)
                   {    
                       dibujo[i,7]=35;
                   }
                   break;
          
             case 3:     
                   //BRAÇ ESQUERRE
          
                   dibujo[10,6]=35;
                   dibujo[11,5]=35;
                   dibujo[12,4]=35;
                   break;
             case 4:
                   //BRAÇ DRET
                   dibujo[10,8]=35;
                   dibujo[11,9]=35;
                   dibujo[12,10]=35;
                   break;
             case 5:         
     
                   //CAMA ESQUERRE
                   dibujo[13,6]=35;
                   dibujo[14,5]=35;
                   dibujo[15,4]=35;
                   break;
             case 6:           
                   //CAMA DRETA
                   dibujo[13,8]=35;
                   dibujo[14,9]=35;
                   dibujo[15,10]=35;
                   break;
             case 7:
                  //SOGA
           
                   for (j=4;j<=5;j++)
                     dibujo[j,7]=35;
                   break; 
  
             }
             dibujar();
        }
    }
}
