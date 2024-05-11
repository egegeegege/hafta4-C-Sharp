using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace while_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 250 - 100 arasındaki 12'nin katı kaç sayı olduğunu ve toplamını bulunuz.

            int count = 250;
            int adet = 0;
            int toplam = 0;
            while (count > 100)
            {
                if(count % 12 == 0)
                {
                    adet++;
                    toplam += count;
                }
                count--;
            }


            Console.WriteLine("Adet: {0} - Toplam: {1}",adet,toplam);

            Console.ReadLine();
        }
    }
}
