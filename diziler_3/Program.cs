using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diziler_3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Array Methodlar 
            // IndexOf: Dizinin içindeki elemanın ilk olarak kaçıncı indexte olduğunu bize verir.

            int[] degerler = new int[10] { 2, 6, 4, 7, 8, 2, 3, 7, 5, 6};

            int bul = Array.IndexOf(degerler,7);

            Console.WriteLine("Dizinin kaçıncı elemanı: {0}",bul);


            // IndexOf: Dizinin içindeki elemanın sondan başlayarak ilk olarak kaçıncı indexte olduğunu bize verir.

            int sbul = Array.LastIndexOf(degerler, 7);

            Console.WriteLine("Dizinin kaçıncı elemanı: {0}", sbul);

            string[] isimler = new string[3] { "Ali", "Barış", "Okan" };
            int stringBul = Array.IndexOf(isimler,"Barış");

            Console.WriteLine("String dizinin içinde kaçıncı eleman: {0}",stringBul);

            Console.ReadLine();


        }
    }
}
