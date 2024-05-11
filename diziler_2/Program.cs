using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diziler_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Array Methodlar
            int[] sayilar = { 2, 7, 1, 5, 8, 3 };

            foreach (var sayi in sayilar)
            {
                Console.WriteLine(sayi);
            }
            Console.WriteLine("***********************");
            Array.Sort(sayilar); // Küçükten büyüğe doğru sıralar. Asceding => artar sıralama (Desceding => azalan sıralama)
            Array.Reverse(sayilar); // Diziyi terse çevirme

            foreach (var sayi in sayilar)
            {
                Console.WriteLine(sayi);
            }

            // bir ismi terse çevirme

            string isim = "METE";
            char[] isimDizisi = new char[isim.Length];

            for (int i = 0; i < isimDizisi.Length; i++)
            {
                isimDizisi[i] = isim[i];
            }

            Array.Reverse(isimDizisi);

            foreach (var i in isimDizisi)
            {

                Console.Write(i);
            }

            Console.ReadLine();
        }
    }
}
