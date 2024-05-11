using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace while_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // While Döngüsü
            /* 
             Yapı
             while(kosul){
            
                Console.WriteLine("while");
             } 
             */
            int i = 0;
            while (i<10)
            {
                Console.WriteLine("while");
                i++;
            }

            Console.ReadLine();
        }
    }
}
