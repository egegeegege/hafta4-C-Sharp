using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace while_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // kullanıcıya 3 kez hak vererek kullanıcı adını girmesini isteyeceğiz.
            // kullanıcı adı admin olacak
            // hak bitene kadar kullanıcı adı doğru girilmez ise hakkınız bittiğinden dolayı atıldınız 3.sn bekleyin ve tekrar deneyin uyarısı verilecek.
            // eğer kullanıcı adı doğru girilirse GİRİŞ BAŞARILI uyarısı verilecek.
            Start:
            int hak = 0;
            string kad = null;
            while (kad!="admin" && hak<3)
            {
                hak++;
                Console.WriteLine("Lütfen kullanıcı adını giriniz");
                kad = Console.ReadLine();
            }

            if(hak == 3 && kad != "admin")
            {
                Console.WriteLine("Hakkınız bittiğinden dolayı atıldınız 3 sn. bekleyin ve tekrar deneyin");
                Thread.Sleep(3000);
                goto Start;
            }
            else
            {
                Console.WriteLine("\tGİRİŞ BAŞARILI");
            }

            Console.ReadLine();
        }
    }
}
