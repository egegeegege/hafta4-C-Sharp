using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace while_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1-100 arasındaki sayıları toplayın
            int count = 0;
            int toplam = 0;
            while (count<100)
            {
                count++;
                toplam += count; // toplam = toplam + count;
            }

            Console.WriteLine("1-100 arasındaki sayıların toplamı: {0}", toplam);

            Console.ReadLine();
        }
    }
}
