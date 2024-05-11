using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace while_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Şifre çözme uygulaması
            Random rand = new Random(); // instance
            Console.WriteLine("Şifrenizi giriniz");
            int sifre = int.Parse(Console.ReadLine());
            int hak = 0;

            while (true)
            {
                hak++;
                int tahmin = rand.Next(0,sifre+1);
                if(sifre == tahmin)
                {
                    break;
                }
                Console.WriteLine(tahmin);
                Thread.Sleep(1000);
            }

            Console.WriteLine("Şifreniz {0}. kez denenerek çözüldü ve şifreniz {1}", hak, sifre);

            Console.ReadLine();
        }
    }
}
