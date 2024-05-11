using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace while_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Kullanıcıdan 3 defa sayı bilgisi isteyip bu sayıyı ekrana yazdıran program

            int hak = 0;
            while (hak<3)
            {
                hak++;
                Console.WriteLine("Bir sayı giriniz");
                int sayi = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(sayi);    
            }
            Console.ReadLine();
        }
    }
}
