using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace do_while_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do  // do while döngüsü önce işi yapar sonra koşula bakar ilk dönüş durumu için her defasında ilk dönüşü gerçekleştirir.
            {
                Console.WriteLine("Heyo Do-While");
            } while (false);

            while (false) {   
                Console.WriteLine("Heyo While");
            }
            Console.ReadLine();
        }
    }
}
