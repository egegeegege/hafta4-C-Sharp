using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace do_while_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // kullanıcı 0 rakamını girene kadar tüm girilen sayıları toplayan ve kullanıcı 0 girdiğinde sayıların toplamını bize veren program.

            int toplam = 0;
            int sayi = 0;

            do
            {
                Console.WriteLine("Sayı giriniz:");
                sayi = int.Parse(Console.ReadLine());
                toplam += sayi;
            } while (sayi != 0);

            Console.WriteLine("Toplam: {0}", toplam);

            Console.ReadLine();
        }
    }
}
